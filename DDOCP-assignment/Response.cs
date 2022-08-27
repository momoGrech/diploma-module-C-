using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOCP_assignment
{
    /// <summary>
    /// Response class contains informatation about a survey response
    /// </summary>
    public class Response
    {
        //Attribute - data that you will store about the survey response
        private int repsonseID;
        private int questionID;
        private QuestionType questionType;
        private string responseAnswer;

        //Properties - enable atributes to be usable by other forms/classes
        public int RepsonseID { get => repsonseID; set => repsonseID = value; }
        public int QuestionID { get => questionID; set => questionID = value; }
        public QuestionType QuestionType { get => questionType; set => questionType = value; }
        public string ResponseAnswer { get => responseAnswer; set => responseAnswer = value; }



        //Constructors - special methods that allow copy of the class to be created and used
        public Response()
        {
            //empty constructor
        }

        //overloaded constructor
        public Response(int repsonseID, int questionID, string responseAnswer)
        {
            this.repsonseID = repsonseID;
            this.questionID = questionID;
            this.responseAnswer = responseAnswer;
        }


        //Behaviours - methods that need to be carried out on the data of this object

        /// <summary>
        /// This method saves Yes/No question response
        /// </summary>
        /// <param name="yesNoQuestion">The parameter contains the Yes/No question response</param>
        public void SaveResponseYnQ(YesNoQuestion yesNoQuestion)
        {
            try
            {
                // Create a connection 
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                // create a string with the command (SQL)
                string SQLCOmmandText = "INSERT INTO SurveyResponse (QuestionID, Response) VALUES (@questionID, @response);";

                //Execute a coomand
                using (SQLiteCommand command = new SQLiteCommand(SQLCOmmandText, connection))
                {
                    //open the connection
                    connection.Open();

                    //preparing sql statments 
                    command.Parameters.AddWithValue("@questionID", yesNoQuestion.QuestionNumber);
                    command.Parameters.AddWithValue("@response", yesNoQuestion.Answer);
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method saves Rating question response
        /// </summary>
        /// <param name="raitingQuestion">The parameter contains the Rating question response</param>
        public void SaveResponseRtN(RaitingQuestion raitingQuestion)
        {
            try
            {
                // Create a connection 
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                // create a string with the command (SQL)
                string SQLCOmmandText = "INSERT INTO SurveyResponse (QuestionID, Response) VALUES (@questionID, @response);";

                //Execute a coomand
                using (SQLiteCommand command = new SQLiteCommand(SQLCOmmandText, connection))
                {
                    //open the connection
                    connection.Open();

                    //preparing sql statments 
                    command.Parameters.AddWithValue("@questionID", raitingQuestion.QuestionNumber);
                    command.Parameters.AddWithValue("@response", raitingQuestion.Answer);
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method saves Rating response
        /// </summary>
        /// <param name="dropDownQuestion">The parameter contains the DropDown question response</param>
        public void SaveResponseDdN(DropDownQuestion dropDownQuestion)
        {
            try
            {
                // Create a connection 
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                // create a string with the command (SQL)
                string SQLCOmmandText = "INSERT INTO SurveyResponse (QuestionID, Response) VALUES (@questionID, @response);";

                //Execute a coomand
                using (SQLiteCommand command = new SQLiteCommand(SQLCOmmandText, connection))
                {
                    //open the connection
                    connection.Open();

                    //preparing sql statments 
                    command.Parameters.AddWithValue("@questionID", dropDownQuestion.QuestionNumber);
                    command.Parameters.AddWithValue("@response", dropDownQuestion.Answer);
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
