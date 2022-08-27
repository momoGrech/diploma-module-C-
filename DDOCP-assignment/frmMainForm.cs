using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOCP_assignment
{
    public partial class frmMainForm : Form
    {
        DialogResult messageBoxResult;

        // count the nmumber of wrong credential
        int FailedCounter = 3;
        //Keeps track of the numbber of incorrect Log Ins
        int incorrectLogIns = 0;

        //Keeps track of the number of seconds passed after account locking
        int secondsPassed = 0;

        //Create a user object
        User user = new User();

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnMainClear_Click(object sender, EventArgs e)
        {
            txtMainUsernameInput.Text = "";
            txtMainPwdInput.Text = "";
            txtMainPwdInput.PasswordChar = '*';
        }

        //Styling Login button
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnMainLogin.FlatStyle = FlatStyle.Flat;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnMainLogin.FlatStyle = FlatStyle.Popup;
        }

        //Styling Clear button
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnMainClear.FlatStyle = FlatStyle.Flat;
        }

        //Styling Clear button
        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnMainClear.FlatStyle = FlatStyle.Popup;
        }

        // SHow/Hide password
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtMainPwdInput.UseSystemPasswordChar)
            {
                // show password
                btnShowHidePwd.BackgroundImage = Properties.Resources.showPassword;
                txtMainPwdInput.UseSystemPasswordChar = false;
            }
            else
            {
                //Hide password
                btnShowHidePwd.BackgroundImage = Properties.Resources.hidePassword;
                txtMainPwdInput.UseSystemPasswordChar = true;
            }
        }

        bool validInput = false;

        private void btnMainLogin_Click(object sender, EventArgs e)
        {
            if (txtMainUsernameInput.Text.Trim() == "")
            {
                validInput = false;
                errorProviderUsername.SetError(txtMainUsernameInput, "Username must not be empty");
            }
            else
            {
                errorProviderUsername.Clear();
                validInput = true;
            }

            if (txtMainPwdInput.Text.Trim() == "")
            {
                validInput = false;
                errorProviderPassword.SetError(txtMainPwdInput, "Password must not be empty");
            }
            else
            {
                errorProviderPassword.Clear();
                validInput = true;
            }


            if(validInput == true)
            {
                if (Program.users.LoadAllUsers() == true)
                {
                    bool login = false;
                    foreach (User currentUser in Program.users.UserList)
                    {
                        if (currentUser.UserName == txtMainUsernameInput.Text && currentUser.Password == txtMainPwdInput.Text)
                        {
                            // Log In
                            login = true;

                            //Distinguish between the forms to shown based on whether the user is an admin or a customer
                            if (currentUser.IsAdministrator == true)
                            {
                                MessageBox.Show("Login successful for Admin Account", "Login successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Display the Admin form
                                //Load the new window
                                frmCreateSurvey frmSurvey = new frmCreateSurvey(txtMainUsernameInput.Text);
                                frmSurvey.Show();
                            }
                            else
                            {
                                MessageBox.Show("Login successful for Customer Account", "Login successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Show normal user form and pass the current user as param to be able to see his data in the next form
                                frmViewSurvey viewSurvey = new frmViewSurvey(currentUser);
                                viewSurvey.Show();
                            }

                            //Hide this form
                            this.Hide();
                        }
                    }


                    if (login == false)
                    {
                        //Add 1 to the incorrectLogIns Variable
                        incorrectLogIns++;

                        //If logged in incorreectly more than 3 times - lock the window
                        if (incorrectLogIns > 3)
                        {
                            //Show the Account Locked Label
                            lblAccountLocked.Visible = true;

                            //Disable all textboxes & buttons
                            txtMainUsernameInput.Enabled = false;
                            txtMainPwdInput.Enabled = false;
                            btnMainClear.Enabled = false;
                            btnMainLogin.Enabled = false;
                            btnShowHidePwd.Enabled = false;
                            btnMainSignup.Enabled = false;

                            //Start the timer
                            timerLockAccount.Enabled = true;
                            timerLockAccount.Start();
                        }
                        else
                        {
                            if (FailedCounter == 1)
                            {
                                MessageBox.Show("Incorrect Log In Credential.\n\nYou have no more attempts to login.", "Log In Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                //Show an Error Message & Saving which button was clicked
                                messageBoxResult = MessageBox.Show("Incorrect Log In Credential.\n\nAfter " + (FailedCounter = FailedCounter - 1) + " more attempts your credential will be blocked",
                                                                               "Log In Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            }

                            //Use an if statement to get the program to obehave differently based on which button was clicked in the message box
                            if (messageBoxResult == DialogResult.Retry)
                            {
                                //Clear my log in textboxes
                                txtMainUsernameInput.Clear();
                                txtMainPwdInput.Clear();
                            }
                            else
                            {
                                //Disable all textboxes & buttons
                                txtMainUsernameInput.Enabled = false;
                                txtMainPwdInput.Enabled = false;
                                btnMainClear.Enabled = false;
                                btnMainLogin.Enabled = false;
                                btnShowHidePwd.Enabled = false;
                                btnMainSignup.Enabled = false;
                            }
                        }
                    }

                }
            }

        }   

        private void btnMainSignup_Click(object sender, EventArgs e)
        {
            //load sign up form
            frmSignUp signUpForm = new frmSignUp();
            signUpForm.Show();

            //close current form
            this.Hide();
        }

        //Styling Sign up button
        private void btnMainSignup_MouseEnter(object sender, EventArgs e)
        {
            btnMainSignup.BackColor = Color.Transparent;
            btnMainSignup.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        private void btnMainSignup_MouseLeave(object sender, EventArgs e)
        {
            btnMainSignup.BackColor = Color.Transparent;
            btnMainSignup.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
        }

        //Setting up a temporarily block on the account
        private void timerLockAccount_Tick(object sender, EventArgs e)
        {
            //Add 1 second to the time passed from when the account was locked
            secondsPassed++;

            if (secondsPassed > 3)
            {
                //Unlock the account - enable all components
                txtMainUsernameInput.Enabled = true;
                txtMainPwdInput.Enabled = true;
                btnMainClear.Enabled = true;
                btnMainLogin.Enabled = true;
                btnShowHidePwd.Enabled = true;
                btnMainSignup.Enabled = true;

                //Hide the Account locked label
                lblAccountLocked.Visible = false;

                //Reset the seconds passed from account locking, the number of failed log ins
                secondsPassed = 0;
                incorrectLogIns = 0;

                FailedCounter = 3;
                //Stop the timer
                timerLockAccount.Stop();
                timerLockAccount.Enabled = false;
            }
        }

        //Styling the locked title
        private void lblAccountLocked_MouseMove(object sender, MouseEventArgs e)
        {
            lblAccountLocked.BackColor = Color.Maroon;
        }

        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
