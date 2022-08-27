using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOCP_assignment
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clearing user's input when login button or clear button is clicked
        /// </summary>
        //clearing fields
        private void clearFields()
        {
            txtFullNameInput.Text = "";
            numericAgeInput.Value = 15;
            txtUsernameInput.Text = "";
            txtPasswordInput2.Text = "";
            txtPasswordInput1.Text = "";
            errorFirstPwd.Clear();
            errorSecondPwd.Clear();
            errorUserName.Clear();
            errorFullName.Clear();
        }

        // Show/Hide first passowrd
        private void btnShowHidePwd1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPasswordInput1.UseSystemPasswordChar)
                {
                    // show password
                    btnShowHidePwd1.BackgroundImage = Properties.Resources.showPassword;
                    txtPasswordInput1.UseSystemPasswordChar = false;
                }
                else
                {
                    //Hide password
                    btnShowHidePwd1.BackgroundImage = Properties.Resources.hidePassword;
                    txtPasswordInput1.UseSystemPasswordChar = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        // Show/Hide second passowrd
        private void btnShowHidePwd2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPasswordInput2.UseSystemPasswordChar)
                {
                    // show password
                    btnShowHidePwd2.BackgroundImage = Properties.Resources.showPassword;
                    txtPasswordInput2.UseSystemPasswordChar = false;
                }
                else
                {
                    //Hide password
                    btnShowHidePwd2.BackgroundImage = Properties.Resources.hidePassword;
                    txtPasswordInput2.UseSystemPasswordChar = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        //Login button
        private void btnSignUp_MouseEnter(object sender, EventArgs e)
        {
            btnSignUp.FlatStyle = FlatStyle.Flat;
        }

        // Login
        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.FlatStyle = FlatStyle.Popup;
        }

        //Clear button affect-flat
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.FlatStyle = FlatStyle.Flat;
        }

        // Clear button affect-popup
        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.FlatStyle = FlatStyle.Popup;
        }

        // Sign up button - Save User's credential
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                bool accountValidation = false;
                Regex passwordRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{5,}$");
                Regex fullNameRegex = new Regex("^([^0-9]*)$");
                Regex userNameRegex = new Regex("^([^0-9]*)$");

                if (accountValidation == false)
                {
                    if (txtFullNameInput.Text.Trim() == "" || txtUsernameInput.Text.Trim() == "" || txtPasswordInput1.Text.Trim() == "" || txtPasswordInput2.Text.Trim() == "")
                    {
                        MessageBox.Show("Input field cannot be left blank. Please provide the correct details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int errorCount = 0;

                        //setting up validators for the user inputs
                        if (fullNameRegex.IsMatch(txtFullNameInput.Text))
                        {
                            errorFullName.Clear();
                            accountValidation = true;
                        }
                        else
                        {
                            accountValidation = false;
                            errorCount = errorCount + 1;
                            errorFullName.SetError(txtFullNameInput, "Full name must not include numbers");
                        }

                        if (userNameRegex.IsMatch(txtUsernameInput.Text))
                        {
                            errorUserName.Clear();
                            accountValidation = true;
                        }
                        else
                        {
                            accountValidation = false;
                            errorCount = errorCount + 1;
                            errorUserName.SetError(txtUsernameInput, "username name must not include numbers");
                        }

                        if (passwordRegex.IsMatch(txtPasswordInput1.Text))
                        {
                            errorFirstPwd.Clear();
                            accountValidation = true;
                        }
                        else
                        {
                            accountValidation = false;
                            errorCount = errorCount + 1;
                            errorFirstPwd.SetError(txtPasswordInput1, "Passwords needs min 6 char, and at least 1 small letter, 1 capital letter & 1 symbol.");
                        }

                        if (txtPasswordInput1.Text == txtPasswordInput2.Text)
                        {
                            errorSecondPwd.Clear();
                            accountValidation = true;
                        }
                        else
                        {
                            accountValidation = false;
                            errorCount = errorCount + 1;
                            errorSecondPwd.SetError(txtPasswordInput2, "Passwords do not match!");
                        }

                        if (errorCount > 0)
                        {
                            accountValidation = false;
                        }
                    }
                }

                if (accountValidation == true)
                {
                    if (Program.users.LoadAllUsers() == true)
                    {
                        int userFound = 0;
                        foreach (User currentUser in Program.users.UserList)
                        {
                            if (currentUser.UserName == txtUsernameInput.Text)
                            {
                                userFound = userFound + 1;
                            }
                        }
                        if (userFound == 0)
                        {
                            //create a user object
                            User newUser = new User()
                            {
                                FullName = txtFullNameInput.Text,
                                Age = (int)numericAgeInput.Value,
                                UserName = txtUsernameInput.Text,
                                Password = txtPasswordInput1.Text,
                                IsAdministrator = CheckBtnIsAdmin.Checked
                            };
                            newUser.SaveUser(newUser);

                            //Message box to differentiate between admin and customer
                            if (CheckBtnIsAdmin.Checked == false)
                            {
                                MessageBox.Show("Account for Customer " + txtFullNameInput.Text + " created.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Account for Administrator " + txtFullNameInput.Text + " created.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            Program.users.registerUser(newUser);
                            // Program.usersList.Add(newUser); I cannot use it in the validation login section

                            //Load the new window
                            frmMainForm MainAccount = new frmMainForm();
                            MainAccount.Show();
                            this.Hide();

                            // Hide the current window
                            //this.Hide();
                            clearFields();
                        }
                        else
                        {
                            MessageBox.Show("Account already exist ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}

