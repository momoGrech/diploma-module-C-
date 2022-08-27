using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOCP_assignment
{
    public partial class frmCreateSurvey : Form
    {
        //1. create a survey object
        Survey mySurvey = new Survey();


        string loggedInUsername;
        public frmCreateSurvey(string userName)
        {
            InitializeComponent();
            loggedInUsername = userName;
        }

        /// <summary>
        /// This method is used to disable the questions
        /// </summary>
        private void disableQuestions()
        {
            grpDropDown.Enabled = false;
            grpRaiting.Enabled = false;
            grpYesNo.Enabled = false;
            btnSaveSurvey.Enabled = false;
        }

        /// <summary>
        /// This method is used to enable the questions
        /// </summary>
        private void endableQuestions()
        {
            grpDropDown.Enabled = true;
            grpRaiting.Enabled = true;
            grpYesNo.Enabled = true;
            btnSaveSurvey.Enabled = true;
        }

        /// <summary>
        /// This method is disabling survey details
        /// </summary>
        private void disableSurveyDetails()
        {
            btnClear.Enabled = false;
            btnCreateSurvey.Enabled = false;
            txtSurveyName.Enabled = false;
            txtSurveyDescription.Enabled = false;
        }

        /// <summary>
        /// This method is enabling survey details
        /// </summary>
        private void enableSurveyDetails()
        {
            btnClear.Enabled = true;
            btnCreateSurvey.Enabled = true;
            txtSurveyName.Enabled = true;
            txtSurveyDescription.Enabled = true;
            txtSurveyName.Clear();
            txtSurveyDescription.Clear();
        }

        /// <summary>
        /// This methoid is clearnig survey detail inputs
        /// </summary>
        private void clearSurveyDetails()
        {
            txtSurveyName.Text = "";
            txtSurveyDescription.Text = "";
        }

        private void btnCreateSurvey_Click(object sender, EventArgs e)
        {

            try
            {
                //Get the survey details
                string surveyName = txtSurveyName.Text;
                string surveyDescription = txtSurveyDescription.Text;

                bool surveyValidation = false;

                Regex SurveyNameRegex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])|[ ]+$");
                Regex SurveyDescriptionRegex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])|[ ]+$");

                if (surveyName.Trim() == "" || surveyDescription.Trim() == "")
                {
                    MessageBox.Show("Cannot create a Survey with blank text", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (surveyValidation == false)
                    {
                        //setting up validators for the user inputs
                        if (SurveyNameRegex.IsMatch(txtSurveyName.Text))
                        {
                            errorSurveyName.Clear();
                            surveyValidation = true;
                        }
                        else
                        {
                            surveyValidation = false;
                            errorSurveyName.SetError(txtSurveyName, "Survey Name must contain at least capital and small letter");
                        }

                        if (SurveyDescriptionRegex.IsMatch(txtSurveyDescription.Text))
                        {
                            errorSurveyDescription.Clear();
                            surveyValidation = true;
                        }
                        else
                        {
                            surveyValidation = false;
                            errorSurveyDescription.SetError(txtSurveyDescription, "Survey Name must contain at least capital and small letter");
                        }

                        if (SurveyNameRegex.IsMatch(txtSurveyName.Text) && SurveyDescriptionRegex.IsMatch(txtSurveyDescription.Text))
                        {
                            surveyValidation = true;
                        }
                        else
                        {
                            surveyValidation = false;
                        }
                        disableQuestions();
                    }
                }

                //If the survey name is valid - create survey
                if (surveyValidation == true)
                {

                    //1. set the name of the survey to the one taken from the survey textbox
                    mySurvey.Name = surveyName;
                    mySurvey.Description = surveyDescription;

                    //2. Enable group boxes to add questions
                    endableQuestions();

                    //3. Disable survey details
                    disableSurveyDetails();

                    /*Clear the survey detail*//*
                    clearSurveyDetails();*/

                }
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        // creating a Yes/No question
        private void btnAddYesNo_Click(object sender, EventArgs e)
        {
            
            try
            {
                Regex yesNoQuestionRegex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])|[ ]+$");

                //Get the question text
                string questionText = txtYesNoText.Text;


                if (questionText.Trim() == "")
                {
                    MessageBox.Show("Cannot create a question with blank text", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (yesNoQuestionRegex.IsMatch(questionText))
                    {
                        //1. create a Yes No question object with the given text
                        YesNoQuestion question = new YesNoQuestion();

                        question.Text = questionText;

                        //2. Add this question to the survey
                        mySurvey.AddYesNoQuestion(question);

                        MessageBox.Show("Question created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtYesNoText.Clear();
                    }
                    else
                    {
                        MessageBox.Show("The question must contain at least capital and small letter", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Creating a DropDown question
        private void btnAddDropDown_Click(object sender, EventArgs e)
        {
            try
            {
                Regex dropDownQuestionRegex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])|[ ]+$");

                //Get the question text
                string questionText = txtDropDownText.Text;

                if (questionText.Trim() == "")
                {
                    MessageBox.Show("Cannot create a question with blank text", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (dropDownQuestionRegex.IsMatch(questionText))
                    {
                        //1. create a DropDown question object with the given text
                        DropDownQuestion question = new DropDownQuestion();

                        question.Text = questionText;

                        //2. Get the options from the multiLine Textbox
                        foreach (string opt in MultiOptionsList.Items)
                        {
                            question.Options.Add(opt);
                        }

                        //3. Add this question to the survey
                        mySurvey.AddDropDownQuestion(question);

                        MessageBox.Show("A drop down question created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDropDownText.Clear();
                        txtEnterOption.Clear();
                        MultiOptionsList.Items.Clear();
                        MultiOptionsList.Refresh();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Creating a Rating question
        private void btnAddRaiting_Click(object sender, EventArgs e)
        {
            try
            {
                Regex ratingQuestionRegex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])|[ ]+$");

                //Get the question text
                string questionText = txtRaitingText.Text;

                if (questionText.Trim() == "")
                {
                    MessageBox.Show("Cannot create a question with blank text", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (ratingQuestionRegex.IsMatch(questionText))
                    {
                        //1. create a Rating question object with the given text
                        RaitingQuestion question = new RaitingQuestion();

                        question.Text = questionText;

                        //2. Add this question to the survey
                        mySurvey.AddRaitingQuestion(question);

                        MessageBox.Show("A Raiting question created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRaitingText.Clear();
                    }
                    else
                    {
                        MessageBox.Show("The question must contain at least capital and small letter", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /* Save survey */
        private void btnSaveSurvey_Click(object sender, EventArgs e)
        {
            int minimumquestion = 1;
            int minimumTotalQuestions = 6;

            try
            {
                int totalQuestions = mySurvey.YesNoQuestions.Count + mySurvey.DropDownQuestions.Count + mySurvey.RaitingQuestions.Count;

                int minimumYesNoQuestion = mySurvey.YesNoQuestions.Count;

                int minimumDropDwonQuestion = mySurvey.DropDownQuestions.Count;

                int minimumRatingQUestion = mySurvey.RaitingQuestions.Count;

                // Check if the survey consist of at east 6 questions and at least 1 question from each question type
                if (totalQuestions >= minimumTotalQuestions & 
                    minimumYesNoQuestion >= minimumquestion & 
                    minimumDropDwonQuestion >= minimumquestion & 
                    minimumRatingQUestion >= minimumquestion)
                {
                    mySurvey.SurveyId = mySurvey.SaveSurvey(mySurvey);

                    // Save each Yes/No question
                    foreach (YesNoQuestion yesNo in mySurvey.YesNoQuestions)
                    {
                        //Save the Yes No question
                        mySurvey.SaveQuestionYnQ(yesNo);
                    }

                    // Save each Dropdown question
                    foreach (DropDownQuestion dropDown in mySurvey.DropDownQuestions)
                    {
                        //Save the drop down question question
                        mySurvey.SaveQuestionDdQ(dropDown);
                        mySurvey.SaveQuestionOptionsDdQ(dropDown);
                    }

                    // Save each Rating question
                    foreach (RaitingQuestion rating in mySurvey.RaitingQuestions)
                    {
                        mySurvey.SaveQuestionRt(rating);
                    }

                    MessageBox.Show("A new survey created", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /*disable survey questions*/
                    disableQuestions();

                    /*enable survey details*/
                    enableSurveyDetails();
                }
                else
                {
                    MessageBox.Show("You must have at least a total of 6 questions and at least 1 question from each type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Loading survey form and pass username to a Survey creator label
        private void frmSurvey_Load(object sender, EventArgs e)
        {
            lblAdminSurveyCreator.Text = loggedInUsername;
        }

        // Clear button to clear survey details
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearSurveyDetails();
        }

        //Add options to the dropdown list
        private void btnAddOption_Click(object sender, EventArgs e)
        {
            string option = txtEnterOption.Text;

            if (option.Trim() =="")
            {
                MessageBox.Show("Please add an option", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MultiOptionsList.Items.Add(option);
                txtEnterOption.Clear();
            }
        }

        // Select Survey Analysis from menu bar to load surveyAnalysis Form
        private void ToolStripSurveyAnalysis_Click(object sender, EventArgs e)
        {
            frmSurveyAnalysis surveyAnalysisForm = new frmSurveyAnalysis();

            // Load survey Analysis
            surveyAnalysisForm.Show();

        }

        // Menu option - Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Menu option - Logout
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainForm frmMainForm = new frmMainForm();
            frmMainForm.Show();
            this.Hide();
        }

    }
}