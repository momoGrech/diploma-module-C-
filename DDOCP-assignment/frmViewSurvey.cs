using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOCP_assignment
{
    public partial class frmViewSurvey : Form
    {
        //Intialise survey object to store responses
        Survey selectedSurvey = new Survey();

        // Initilise response object to allow the responses to be inserted into the database
        Response surveyResponse = new Response();

        // Intialising index numbers to allow next question to be displayed
        int nextYesNoQuestionIndex = 0;
        int nextDropDownQuestionIndex = 0;
        int nextRaitingQuestionIndex = 0;

        /// <summary>
        /// Disable all the rating buttons
        /// </summary>
        /// <returns></returns>
        public bool disableRatingButtons()
        {
            rBtnTen.Checked = false;
            rBtnNine.Checked = false;
            rBtnEight.Checked = false;
            rBtnSeven.Checked = false;
            rBtnSix.Checked = false;
            rBtnFive.Checked = false;
            rBtnFour.Checked = false;
            rBtnThree.Checked = false;
            rBtnTwo.Checked = false;
            rBtnOne.Checked = false;
            return true;
        }

        // storing username text in a variable and pass it to username label
        string customerUserName;

        /// <summary>
        /// this method is displayiong the survey and having currentUser as a parameter which was passed from the login form
        /// </summary>
        /// <param name="currentUser"></param>
        public frmViewSurvey(User currentUser)
        {
            customerUserName = currentUser.UserName;
            InitializeComponent();
        }

        // Load view survey
        private void FrmViewSurvey_Load(object sender, EventArgs e)
        {
            try
            {
                btnSurveyResponse.Enabled = false;
                lblUserNameText.Text = customerUserName;

                grpDropDownQuestion.Enabled = false;
                grpYesNoQuestion.Enabled = false;
                grpRaitingQuestion.Enabled = false;

                //Load the survey method to obtain survey names
                List<Survey> mySurveyList = selectedSurvey.LoadAllSurvey();

                for (int i = 0; i < mySurveyList.Count; i++)
                {
                    comboBoxListOfSurvey.Items.Add(mySurveyList[i].Name);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Menu option - Logout
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainForm frmMainForm = new frmMainForm();
            frmMainForm.Show();
            this.Hide();
        }

        // Menu option - Exit
        private void existToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Display a Survey from the comboBox List Of Survey
        private void comboBoxListOfSurvey_SelectedIndexChanged(object sender, EventArgs e)
        { 
            try
            {
                //Enable save button
                btnSurveyResponse.Enabled = true;

                //Enable the questions
                btnNextQuestionYesNo.Enabled = true;
                btnNextQuestionDropdown.Enabled = true;
                btnNextQuestionRaiting.Enabled = true;

                // Setting the question index to 0
                nextYesNoQuestionIndex = 0;
                nextDropDownQuestionIndex = 0;
                nextRaitingQuestionIndex = 0;

                // Enabling the group questions
                grpDropDownQuestion.Enabled = true;
                grpYesNoQuestion.Enabled = true;
                grpRaitingQuestion.Enabled = true;

                // Select survey ID from by getting survey name from the combo box and pass it to the getSureyID as a parameter
                int selectedSurveyID = selectedSurvey.GetSurveyID(comboBoxListOfSurvey.Text);

                // LOad survey based on the survey ID
                selectedSurvey = selectedSurvey.LoadSurvey(selectedSurveyID);

                // Update survey name and survey description labels
                lblSurveyName.Text = selectedSurvey.Name;
                lblDispalySurveyDiscrip.Text = selectedSurvey.Description;

                //Load all the Yes/No questions into the survey
                selectedSurvey = selectedSurvey.LoadYesNoQuestion(selectedSurvey);

                //Retrive the first Yes/No question from the survey
                YesNoQuestion selectedYesNoQuestion = selectedSurvey.YesNoQuestions[nextYesNoQuestionIndex];

                lblYesNoQuestion.Text = selectedYesNoQuestion.Text;


                //Load all the Raiting questions into the survey
                selectedSurvey = selectedSurvey.LoadRaitingQuestion(selectedSurvey);

                //Retrive the first Rating question from the survey
                RaitingQuestion selectedRaitingQuestion = selectedSurvey.RaitingQuestions[nextRaitingQuestionIndex];

                lblRaitingQuestion.Text = selectedRaitingQuestion.Text;


                // Load all the Drop dwon questions into the survey
                selectedSurvey = selectedSurvey.LoadDropDownQuestion(selectedSurvey);

                // Retreive the first drop down question from the survey
                DropDownQuestion selectedDropdownQuestion = selectedSurvey.DropDownQuestions[nextDropDownQuestionIndex];

                lblDropDownQuestion.Text = selectedDropdownQuestion.Text;
                comboBoxBoxDisplayOptions.Items.Clear();

                // Add the options to the combobox
                for (int i = 0; i < selectedDropdownQuestion.Options.Count; i++)
                {
                    comboBoxBoxDisplayOptions.Items.Add(selectedDropdownQuestion.Options[i]);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        // Next Dropdown question
        private void btnNextQuestionDropdown_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an option is selected
                if ((bool)(comboBoxBoxDisplayOptions.SelectedItem != null))
                {
                    //create variable to hold current answer
                    string currAnswer;

                    //Store current question answer 
                    currAnswer = (string)comboBoxBoxDisplayOptions.SelectedItem;

                    selectedSurvey.DropDownQuestions[nextDropDownQuestionIndex].Answer = currAnswer;

                    //move to next question
                    nextDropDownQuestionIndex++;

                    //Check if end of question list. 
                    if (nextDropDownQuestionIndex >= selectedSurvey.DropDownQuestions.Count)
                    {
                        MessageBox.Show("All DropDown Questions displayed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Diosable DropDown question group
                        comboBoxBoxDisplayOptions.Text = " ";
                        grpDropDownQuestion.Enabled = false;
                    }
                    else
                    {
                        // Update Dropdown question babel
                        lblDropDownQuestion.Text = selectedSurvey.DropDownQuestions[nextDropDownQuestionIndex].Text;

                        // Clear comboBox items
                        comboBoxBoxDisplayOptions.Items.Clear();
                        comboBoxBoxDisplayOptions.Text = " ";

                        // Add next drop down options to the comboBox
                        for (int i = 0; i < selectedSurvey.DropDownQuestions[nextDropDownQuestionIndex].Options.Count; i++)
                        {
                            comboBoxBoxDisplayOptions.Items.Add(selectedSurvey.DropDownQuestions[nextDropDownQuestionIndex].Options[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an answer to proceed to proceed to next question", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        // Next Yes/No question
        public void btnNextQuestionYesNo_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if any radio button was clicked
                if (rbtnYes.Checked || rbtnNo.Checked)
                {
                    //create variable to hold current answer
                    bool currAnswer = false;

                    //Store current question answer 
                    if (rbtnYes.Checked)
                    {
                        currAnswer = true;
                    }
                    selectedSurvey.YesNoQuestions[nextYesNoQuestionIndex].Answer = currAnswer;

                    //move to next question
                    nextYesNoQuestionIndex++;

                    //Check if end of question list. 
                    if (nextYesNoQuestionIndex >= selectedSurvey.YesNoQuestions.Count)
                    {
                        MessageBox.Show("All Yes/No Questions displayed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Diosable Yes/No question group
                        grpYesNoQuestion.Enabled = false;

                        // Clear radion buttons
                        rbtnNo.Checked = false;
                        rbtnYes.Checked = false;
                    }
                    else
                    {
                        // Update Yes/No question babel
                        lblYesNoQuestion.Text = selectedSurvey.YesNoQuestions[nextYesNoQuestionIndex].Text;

                        // Clear radion buttons
                        rbtnNo.Checked = false;
                        rbtnYes.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please select an answer to proceed to next question", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        // Next Rating question.
        private void btnNextQuestionRaiting_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirm if any of the raiting buttons were checked
                if (rBtnTen.Checked || rBtnNine.Checked || rBtnEight.Checked || rBtnSeven.Checked || rBtnSix.Checked || rBtnFive.Checked || rBtnFour.Checked || rBtnThree.Checked || rBtnTwo.Checked || rBtnOne.Checked)
                {
                    // Create variable to hold current answer
                    int raitingResponseCode = 0;

                    ////Store current question answer 
                    if (rBtnTen.Checked)
                    {
                        raitingResponseCode = 10;
                    }
                    else if (rBtnNine.Checked)
                    {
                        raitingResponseCode = 9;
                    }
                    else if (rBtnEight.Checked)
                    {
                        raitingResponseCode = 8;
                    }
                    else if (rBtnSeven.Checked)
                    {
                        raitingResponseCode = 7;
                    }
                    else if (rBtnSix.Checked)
                    {
                        raitingResponseCode = 6;
                    }
                    else if (rBtnFive.Checked)
                    {
                        raitingResponseCode = 5;
                    }
                    else if (rBtnFour.Checked)
                    {
                        raitingResponseCode = 4;
                    }
                    else if (rBtnThree.Checked)
                    {
                        raitingResponseCode = 3;
                    }
                    else if (rBtnTwo.Checked)
                    {
                        raitingResponseCode = 2;
                    }
                    else if (rBtnOne.Checked)
                    {
                        raitingResponseCode = 1;
                    }

                    selectedSurvey.RaitingQuestions[nextRaitingQuestionIndex].Answer = raitingResponseCode;

                    // Move to next question
                    nextRaitingQuestionIndex++;

                    if (nextRaitingQuestionIndex >= selectedSurvey.RaitingQuestions.Count)
                    {
                        MessageBox.Show("All Raiting Questions displayed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Disable Rating question group
                        grpRaitingQuestion.Enabled = false;

                        disableRatingButtons();
                    }
                    else
                    {
                        // Update rating  question babel
                        lblRaitingQuestion.Text = selectedSurvey.RaitingQuestions[nextRaitingQuestionIndex].Text;

                        // Clear radion buttons
                        disableRatingButtons();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an answer to proceed to proceed to next question", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        // Save survey response
        private void btnSurveyResponse_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the group boxes are disabled
                if (grpDropDownQuestion.Enabled == false && grpRaitingQuestion.Enabled == false && grpYesNoQuestion.Enabled == false)
                {
                    // Save the Yes/No Question into the database.
                    foreach (YesNoQuestion ynq in selectedSurvey.YesNoQuestions)
                    {
                        surveyResponse.SaveResponseYnQ(ynq);
                    }

                    // Save the Rating Question into the database.
                    foreach (RaitingQuestion rtn in selectedSurvey.RaitingQuestions)
                    {
                        surveyResponse.SaveResponseRtN(rtn);
                    }

                    // Save the Drop Dwon Question into the database.
                    foreach (DropDownQuestion ddn in selectedSurvey.DropDownQuestions)
                    {
                        surveyResponse.SaveResponseDdN(ddn);
                    }

                    MessageBox.Show("Your response was submitted. Thank you!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //enable question groups
                    grpDropDownQuestion.Enabled = true;
                    grpYesNoQuestion.Enabled = true;
                    grpRaitingQuestion.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please answer all the questions prior to saving your responses", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}
