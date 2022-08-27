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
    public partial class frmSurveyAnalysis : Form
    {
        //Intialise survey object to be used to store responses
        Survey selectedSurvey = new Survey();

        // Intialising index numbers to allow next question to be displayed
        int nextYesNoQuestionIndex = 0;
        int nextDropDownQuestionIndex = 0;
        int nextRaitingQuestionIndex = 0;

        // store the number of users replying to the survey
        int totalNumberOfUsers;

        public frmSurveyAnalysis()
        {
            InitializeComponent();
        }

        // Loading Survey Analysis form
        private void frmSurveyAnalysis_Load(object sender, EventArgs e)
        {
            try
            {
                //Disable the question groups
                grpBoxYesNoQuestionType.Enabled = false;
                grpBoxRatingQuestionType.Enabled = false;
                grpBoxDropDownQuestionType.Enabled = false;

                //Load the survey method to obtain survey names
                List<Survey> mySurveyList = selectedSurvey.LoadAllSurvey();

                // Populate the survey names in the list of surveys
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

        private void comboBoxListOfSurvey_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Enable all the group box containing the question types
                grpBoxYesNoQuestionType.Enabled = true;
                grpBoxRatingQuestionType.Enabled = true;
                grpBoxDropDownQuestionType.Enabled = true;

                //Reseting next question index
                nextYesNoQuestionIndex = 0;
                nextDropDownQuestionIndex = 0;
                nextRaitingQuestionIndex = 0;

                // Get Selected surveyID 
                int selectedSurveyID = selectedSurvey.GetSurveyID(comboBoxListOfSurvey.Text);

                //Select survey based on surveyID
                selectedSurvey = selectedSurvey.LoadSurvey(selectedSurveyID);


                //Load all the Yes/No questions into the survey
                selectedSurvey = selectedSurvey.LoadYesNoQuestion(selectedSurvey);

                // Error handling by ensuring that Yes/No question contains data
                if (selectedSurvey.YesNoQuestions.Count > 0)
                {

                    // Fill in the form with Yes/no response
                    FillInYesNoResultElements();


                    //Retrive the first Yes/No question from the survey
                    YesNoQuestion selectedYesNoQuestion = selectedSurvey.YesNoQuestions[nextYesNoQuestionIndex];

                    lblYesNoQuestion.Text = selectedYesNoQuestion.Text;
                }
                

                //Load all the Raiting questions into the survey
                selectedSurvey = selectedSurvey.LoadRaitingQuestion(selectedSurvey);

                // Error handling by ensuring that Rating question contains data
                if (selectedSurvey.RaitingQuestions.Count > 0)
                {
                    // Fill in the form with rating response
                    FillInRaitingResultElements();

                    //Retrive the first Yes/No question from the survey
                    RaitingQuestion selectedRaitingQuestion = selectedSurvey.RaitingQuestions[nextRaitingQuestionIndex];

                    lblRaitingQuestion.Text = selectedRaitingQuestion.Text;
                }


                // Load all the Drop dwon questions into the survey
                selectedSurvey = selectedSurvey.LoadDropDownQuestion(selectedSurvey);

                // Error handling by ensuring that Dropdown question contains data
                if (selectedSurvey.DropDownQuestions.Count > 0)
                {
                    // Fill in the form with Dropdown response
                    FillInDropDownResultElements();

                    // Retreive the first drop down question from the survey
                    DropDownQuestion selectedDropdownQuestion = selectedSurvey.DropDownQuestions[nextDropDownQuestionIndex];

                    lblDropDownQuestion.Text = selectedDropdownQuestion.Text;
                }

                if (totalNumberOfUsers == 0)
                {
                    // Disable all the group box containing the question types
                    grpBoxYesNoQuestionType.Enabled = false;
                    grpBoxRatingQuestionType.Enabled = false;
                    grpBoxDropDownQuestionType.Enabled = false;
                    MessageBox.Show("There is no response for this survey as yet.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// This method fills in the form with Yes/No response
        /// </summary>
        private void FillInYesNoResultElements()
        {
            try
            {
                //Get Question ID 
                int currentQuestionID = selectedSurvey.YesNoQuestions[nextYesNoQuestionIndex].QuestionNumber;

                int numberOfUser1 = selectedSurvey.GetYesNoResult(selectedSurvey.SurveyId, currentQuestionID, 1);

                int numberOfUser0 = selectedSurvey.GetYesNoResult(selectedSurvey.SurveyId, currentQuestionID, 0);

                totalNumberOfUsers = (numberOfUser1 + numberOfUser0);

                lblNumberOfUser.Text = totalNumberOfUsers.ToString();

                //Fill in the Yes Count Answer
                lblYesAnswer.Text = selectedSurvey.GetYesNoResult(selectedSurvey.SurveyId, currentQuestionID, 1).ToString();

                //Fill in No Counter Answer
                lblNoAnswer.Text = selectedSurvey.GetYesNoResult(selectedSurvey.SurveyId, currentQuestionID, 0).ToString();
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// This method fills in the form with Rating response
        /// </summary>
        private void FillInRaitingResultElements()
        {
            try
            {
                //Get Question ID 
                int currentQuestionID = selectedSurvey.RaitingQuestions[nextRaitingQuestionIndex].QuestionNumber;

                //Fill in the Yes Count Answer
                double averageDoubleType = selectedSurvey.GetRatingResult(selectedSurvey.SurveyId, currentQuestionID);

                float ratingAverageResponse;

                ratingAverageResponse = (float)Math.Round(averageDoubleType, 2);

                lblAverage.Text = ratingAverageResponse.ToString();
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// This method fills in the form with Dropdown response
        /// </summary>
        private void FillInDropDownResultElements()
        {
            try
            {
                //Get Question ID 
                int currentQuestionID = selectedSurvey.DropDownQuestions[nextDropDownQuestionIndex].QuestionNumber;

                List<string> ddResult = new List<string>();

                ddResult = selectedSurvey.GetDropDownResult(selectedSurvey.SurveyId, currentQuestionID);

                int currentDGIndex = 0;
                dgDropDownOptionResult.Rows.Clear();

                if (ddResult.Count > 0)
                {
                    foreach (string ddAnswer in ddResult)
                    {
                        int indexComma = ddAnswer.IndexOf(',');

                        string optionText = ddAnswer.Substring(0, indexComma);
                        string optionResult = ddAnswer.Substring(indexComma + 1, ddAnswer.Length - (indexComma + 1));

                        dgDropDownOptionResult.Rows.Add();

                        currentDGIndex = dgDropDownOptionResult.Rows.Count - 1;
                        dgDropDownOptionResult.Rows[currentDGIndex].Cells["optionText"].Value = optionText;
                        dgDropDownOptionResult.Rows[currentDGIndex].Cells["optionResult"].Value = optionResult;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        // Display next yes/No Response
        private void btnNextYesNoResult_Click(object sender, EventArgs e)
        {
            try
            {
                //Increment to next question
                nextYesNoQuestionIndex++;

                //Check for the last question
                if (nextYesNoQuestionIndex >= selectedSurvey.YesNoQuestions.Count)
                {
                    MessageBox.Show("All Yes/No responses displayed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpBoxYesNoQuestionType.Enabled = false;
                }
                else
                {
                    //Update the Question Text to next Question in list
                    lblYesNoQuestion.Text = selectedSurvey.YesNoQuestions[nextYesNoQuestionIndex].Text;

                    //Update the Resultes for current quesiton.
                    FillInYesNoResultElements();
                }
            }
            catch (Exception)
            {

                throw;
            }
         
        }

        // Display next Rating Response
        private void btnNextRatingNextResult_Click(object sender, EventArgs e)
        {
            try
            {
                //Increment to next question
                nextRaitingQuestionIndex++;

                //Check for the last question
                if (nextRaitingQuestionIndex >= selectedSurvey.RaitingQuestions.Count)
                {
                    MessageBox.Show("All Rating responses displayed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpBoxRatingQuestionType.Enabled = false;
                }
                else
                {
                    //Update the Question Text to next Question in list
                    lblRaitingQuestion.Text = selectedSurvey.RaitingQuestions[nextRaitingQuestionIndex].Text;

                    //Update the Resultes for current quesiton.
                    FillInRaitingResultElements();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Display next Dropdown Response
        private void btnNextDropDownResult_Click(object sender, EventArgs e)
        {
            try
            {
                //Increment to next question
                nextDropDownQuestionIndex++;

                //Check for the last question
                if (nextDropDownQuestionIndex >= selectedSurvey.DropDownQuestions.Count)
                {
                    MessageBox.Show("All Dropdown responses displayed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpBoxDropDownQuestionType.Enabled = false;
                }
                else
                {
                    //Update the Question Text to next Question in list
                    lblDropDownQuestion.Text = selectedSurvey.DropDownQuestions[nextDropDownQuestionIndex].Text;

                    //Update the Resultes for current quesiton.
                    FillInDropDownResultElements();
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
