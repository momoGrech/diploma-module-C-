using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DDOCP_assignment
{
    /// <summary>
    /// This class contains information about a survey inclouding the type of the questions and the responses
    /// </summary>
    public class Survey
    {
        //Attributes - data that you will store about the project
        private int surveyId;
        private string name;
        private string description;
        private User surveyCreator;
        private List<DropDownQuestion> dropDownQuestions = new List<DropDownQuestion>();
        private List<YesNoQuestion> yesNoQuestions = new List<YesNoQuestion>();
        private List<RaitingQuestion> raitingQuestions = new List<RaitingQuestion>();
        private List<Response> responses = new List<Response>();


        //Properties - enable atributes to be usable by other forms/classes
        public int SurveyId { get => surveyId; set => surveyId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public User SurveyCreator { get => surveyCreator; set => surveyCreator = value; }
        public List<DropDownQuestion> DropDownQuestions { get => dropDownQuestions; set => dropDownQuestions = value; }
        public List<YesNoQuestion> YesNoQuestions { get => yesNoQuestions; set => yesNoQuestions = value; }
        public List<RaitingQuestion> RaitingQuestions { get => raitingQuestions; set => raitingQuestions = value; }
        public List<Response> Responses { get => responses; set => responses = value; }


        //Constructor - special methods that allow copy of the class to be created and used
        public Survey()
        {
            //empty constructor
        }

        //overloaded constructor 
        public Survey(int surveyId, string name, string description, User surveyCreator, List<DropDownQuestion> dropDownQuestions, List<YesNoQuestion> yesNoQuestions, List<RaitingQuestion> ratingQuestions, List<Response> responses)
        {
            this.surveyId = surveyId;
            this.name = name;
            this.description = description;
            this.surveyCreator = surveyCreator;
            this.dropDownQuestions = dropDownQuestions;
            this.yesNoQuestions = yesNoQuestions;
            this.raitingQuestions = ratingQuestions;
            this.responses = responses;
        }

        //Behaviours - methods that need to be carried out on the data of this object

        /// <summary>
        /// This method saves the created survey in the database
        /// </summary>
        /// <param name="newSurvey"> a new survey as a parameter is passed to be saved in the database</param>
        public int SaveSurvey(Survey newSurvey)
        {
            try
            {
                // Save Survey in the database
                int surveyID;

                // Create a connection 
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                // create a string with the command (SQL)
                string SQLCOmmandText = "INSERT INTO Survey (SurveyName, SurveyDescription) VALUES (@surveyName, @surveyDescription);";

                //Execute a coomand
                using (SQLiteCommand command = new SQLiteCommand(SQLCOmmandText, connection))
                {
                    //open the connection
                    connection.Open();

                    //preparing sql statments 
                    command.Parameters.AddWithValue("@surveyName", newSurvey.Name);
                    command.Parameters.AddWithValue("@surveyDescription", newSurvey.Description);
                    command.Prepare();
                    command.ExecuteNonQuery();

                    SQLCOmmandText = "SELECT MAX(SurveyID) FROM Survey;";
                    command.CommandText = SQLCOmmandText;
                    surveyID = Convert.ToInt32(command.ExecuteScalar());
                }
                return surveyID;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        /// <summary>
        /// This method saves Yes/No question types
        /// </summary>
        /// <param name="newYesNoQuestion">An instance of YesNO question type is passed as aparameter to be saved in the database</param>
        public void SaveQuestionYnQ(YesNoQuestion newYesNoQuestion)
        {
            try
            {
                // Create a connection 
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                // create a string with the command (SQL)
                string SQLCOmmandText = "INSERT INTO Question (SurveyID, QuestionTypeID, QuestionText) VALUES (@surveyID, @questionType, @questionText);";

                //Execute a coomand
                using (SQLiteCommand command = new SQLiteCommand(SQLCOmmandText, connection))
                {
                    //open the connection
                    connection.Open();

                    command.Parameters.AddWithValue("@surveyID", this.SurveyId);
                    command.Parameters.AddWithValue("@questionType", (int)newYesNoQuestion.QuestionType);
                    command.Parameters.AddWithValue("@questionText", newYesNoQuestion.Text);

                    //preparing sql statments 
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
        /// This method saves Rating question types
        /// </summary>
        /// <param name="newRaitingQuestion">An instance of Rating question type is passed as aparameter to be save in the database</param>
        public void SaveQuestionRt(RaitingQuestion newRaitingQuestion)
        {
            try
            {
                // Create a connection 
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                // create a string with the command (SQL)
                string SQLCOmmandText = "INSERT INTO Question (SurveyID, QuestionTypeID, QuestionText) VALUES (@surveyID, @questionType, @questionText);";

                //Execute a coomand
                using (SQLiteCommand command = new SQLiteCommand(SQLCOmmandText, connection))
                {
                    //open the connection
                    connection.Open();

                    command.Parameters.AddWithValue("@surveyID", this.SurveyId);
                    command.Parameters.AddWithValue("@questionType", (int)newRaitingQuestion.QuestionType);
                    command.Parameters.AddWithValue("@questionText", newRaitingQuestion.Text);

                    //preparing sql statments 
                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        int QuestionID;

        /// <summary>
        /// This method saves drop down question types
        /// </summary>
        /// <param name="newDropDownQuestion">An instance of dropdown question type is passed as aparameter to be save in the database</param>
        public int SaveQuestionDdQ(DropDownQuestion newDropDownQuestion)
        {
            try
            {
                // Create a connection 
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                // create a string with the command (SQL)
                string SQLCOmmandText = "INSERT INTO Question (SurveyID, QuestionTypeID, QuestionText) VALUES (@surveyID, @questionType, @questionText);";

                //Execute a coomand
                using (SQLiteCommand command = new SQLiteCommand(SQLCOmmandText, connection))
                {
                    //open the connection
                    connection.Open();

                    command.Parameters.AddWithValue("@surveyID", this.SurveyId);
                    command.Parameters.AddWithValue("@questionType", (int)newDropDownQuestion.QuestionType);
                    command.Parameters.AddWithValue("@questionText", newDropDownQuestion.Text);

                    //preparing sql statments 
                    command.Prepare();
                    command.ExecuteNonQuery();

                    SQLCOmmandText = "SELECT MAX(QuestionID) FROM Question;";
                    command.CommandText = SQLCOmmandText;
                    QuestionID = Convert.ToInt32(command.ExecuteScalar());
                }
                return QuestionID;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method saves the options of a dropdown question into QuestionOptions table in the database
        /// </summary>
        /// <param name="newDropDownQuestion">An instance of dropdown question type is passed as aparameter to save the options in the database</param>
        public void SaveQuestionOptionsDdQ(DropDownQuestion newDropDownQuestion)
        {
            try
            {
                // Create a connection 
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                // create a string with the command (SQL)
                string SQLCOmmandText = "INSERT INTO QuestionOptions (QuestionID, OptionText) VALUES (@questionID, @optionText);";

                //Execute a coomand
                connection.Open();

                for (int i = 0; i < newDropDownQuestion.Options.Count; i++)
                {
                    using (SQLiteCommand command = new SQLiteCommand(SQLCOmmandText, connection))
                    {
                        //open the connection
                        command.Parameters.AddWithValue("@questionID", this.QuestionID);
                        command.Parameters.AddWithValue("@optionText", newDropDownQuestion.Options[i]);

                        //preparing sql statments 
                        command.Prepare();
                        command.ExecuteNonQuery();
                    }
                }

                connection.Close();
                connection.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Adding a drop down question to a survey
        /// </summary>
        /// <param name="ddq"> ddq parameter is passed in the method to represent the administartor's dropdown question</param>
        //Add Question
        public void AddDropDownQuestion(DropDownQuestion ddq)
        {
            dropDownQuestions.Add(ddq);
        }

        /// <summary>
        /// Adding a Yes or No question to a survey
        /// </summary>
        /// <param name="ynq">ynq parameter is passed in the method to represent the administartor's Yes/No question</param>
        public void AddYesNoQuestion(YesNoQuestion ynq)
        {
            yesNoQuestions.Add(ynq);
        }

        /// <summary>
        /// Adding a Ranking question to a survey
        /// </summary>
        /// <param name="rt">rt parameter is passed in the method to represent the administartor's Rating question</param>
        public void AddRaitingQuestion(RaitingQuestion rt)
        {
            raitingQuestions.Add(rt);
        }


        /// <summary>
        /// This method loads all the surveys which we used to get survey names
        /// </summary>
        /// <returns></returns>
        public List<Survey> LoadAllSurvey()
        {
            List<Survey> mySurveys = new List<Survey>();

            try
            {
                //Create a connection
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                //Create a string with the command (SQL)                              
                string SQLCommandText = "SELECT SurveyID, SurveyName, SurveyDescription FROM Survey;";

                //Execute a Command
                using (SQLiteCommand command = new SQLiteCommand(SQLCommandText, connection))
                {
                    connection.Open();

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        mySurveys.Add(new Survey() { SurveyId = reader.GetInt32(0), Name = reader.GetString(1), Description = reader.GetString(2) });
                    }
                    reader.Close();
                }
                return mySurveys;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// This method is used to get survey ID by passing a parameter of a survey name
        /// </summary>
        /// <param name="surveyName"> Survey name is passed as a parameter to get its ID</param>
        /// <returns></returns>
        public int GetSurveyID(string surveyName)
        {
            try
            {
                int convertedSurveyID;
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    command.CommandText = "SELECT SurveyID FROM Survey WHERE SurveyName = @surveyName;";
                    command.Parameters.AddWithValue("@surveyName", surveyName);
                    command.Prepare();
                    convertedSurveyID = Convert.ToInt32(command.ExecuteScalar());
                }
                return convertedSurveyID;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method loads the a survey which its ID is equal to the parameter
        /// </summary>
        /// <param name="SurveyID">SurveyID as a parameter is passed to get the survey details</param>
        /// <returns></returns>
        public Survey LoadSurvey(int SurveyID)
        {
            Survey survey = new Survey();

            try
            {
                //Load survey into memory. 
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    command.CommandText = "SELECT SurveyID, SurveyName, SurveyDescription FROM Survey WHERE SurveyID = @surveyID;";
                    command.Parameters.AddWithValue("@surveyID", SurveyID);
                    command.Prepare();

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        survey.SurveyId = reader.GetInt32(0);
                        survey.Name = reader.GetString(1);
                        survey.Description = reader.GetString(2);
                    }
                }
                return survey;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// This method laods Yes/No question based on the parameter which contains a particular survey
        /// </summary>
        /// <param name="selectedSurvey"> This parameter is refering to a particular survey selected by the user</param>
        /// <returns></returns>
        public Survey LoadYesNoQuestion(Survey selectedSurvey)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    command.CommandText = "SELECT QuestionID, QuestionTypeID, QuestionText FROM Question WHERE SurveyID = @surveyID AND QuestionTypeID = 3;";
                    command.Parameters.AddWithValue("@surveyID", selectedSurvey.surveyId);
                    command.Prepare();

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        YesNoQuestion yesNoQuestion = new YesNoQuestion();
                        yesNoQuestion.QuestionNumber = reader.GetInt32(0);
                        yesNoQuestion.QuestionType = (QuestionType)reader.GetInt32(1);
                        yesNoQuestion.Text = reader.GetString(2);
                        selectedSurvey.YesNoQuestions.Add(yesNoQuestion);
                    }
                }
                return selectedSurvey;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// This method laods Rating question based on the parameter which contains a particular survey
        /// </summary>
        /// <param name="selectedSurvey"> This parameter is refering to a particular survey selected by the user</param>
        /// <returns></returns>
        public Survey LoadRaitingQuestion(Survey selectedSurvey)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    command.CommandText = "SELECT QuestionID, QuestionTypeID, QuestionText FROM Question WHERE SurveyID = @surveyID AND QuestionTypeID = 1;";
                    command.Parameters.AddWithValue("@surveyID", selectedSurvey.surveyId);
                    command.Prepare();

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        RaitingQuestion raitingQuestion = new RaitingQuestion();
                        raitingQuestion.QuestionNumber = reader.GetInt32(0);
                        raitingQuestion.QuestionType = (QuestionType)reader.GetInt32(1);
                        raitingQuestion.Text = reader.GetString(2);

                        //set drop down question atributes
                        selectedSurvey.RaitingQuestions.Add(raitingQuestion);
                    }
                }
                return selectedSurvey;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// This method laods Dropdown question based on the parameter which contains a particular survey
        /// </summary>
        /// <param name="selectedSurvey">This parameter is refering to a particular survey selected by the user</param>
        /// <returns></returns>
        public Survey LoadDropDownQuestion(Survey selectedSurvey)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    command.CommandText = "SELECT QuestionID, QuestionTypeID, QuestionText FROM Question WHERE SurveyID = @surveyID AND QuestionTypeID = 2;";
                    command.Parameters.AddWithValue("@surveyID", selectedSurvey.SurveyId);
                    command.Prepare();

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DropDownQuestion dropDownQuestion = new DropDownQuestion();
                        dropDownQuestion.QuestionNumber = reader.GetInt32(0);
                        dropDownQuestion.QuestionType = (QuestionType)reader.GetInt32(1);
                        dropDownQuestion.Text = reader.GetString(2);
                        dropDownQuestion.Options = LoadDropDownOptions(reader.GetInt32(0));

                        //set drop down question atributes
                        selectedSurvey.dropDownQuestions.Add(dropDownQuestion);
                    }
                }
                return selectedSurvey;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// This method is to load drop down options
        /// </summary>
        /// <param name="QuestionID"> QuestionID is passed as a parameter in LoadDropDownOptions method as to get only the options related to that questionID</param>
        /// <returns></returns>
        public List<string> LoadDropDownOptions(int QuestionID)
        {
            List<string> optionList = new List<string>();

            try
            {
                // creating a nested loop to load the Dropdown options                               
                string SQLCommandTextDdNOptions = "SELECT QuestionID, OptionText FROM QuestionOptions WHERE QuestionID = @questionID;";

                //SQL Connection
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                //Execute a Command
                using (SQLiteCommand command = new SQLiteCommand(SQLCommandTextDdNOptions, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@questionID", QuestionID);
                    command.Prepare();


                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        optionList.Add(reader.GetString(1));
                    }
                }

                return optionList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// This method Loads Yes/No result from the database
        /// </summary>
        /// <param name="surveyID">surveyID passed as parameter to identify the survey</param>
        /// <param name="questionID">questionID passed as parameter to identify the question</param>
        /// <param name="responseType">responseType passed as parameter to identify the response type</param>
        /// <returns></returns>
        public int GetYesNoResult(int surveyID, int questionID, int responseType)
        {
            try
            {
                //SQL Connection
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    command.CommandText = "SELECT Cnt FROM YesNoQuestionResults WHERE SurveyID = @surveyID and QuestionID = @questionID AND Response = @responseType";
                    command.Parameters.AddWithValue("@surveyID", surveyID);
                    command.Parameters.AddWithValue("@questionID", questionID);
                    command.Parameters.AddWithValue("@responseType", responseType);
                    command.Prepare();

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// This method Loads Rating result from the database
        /// </summary>
        /// <param name="surveyID">surveyID passed as parameter to identify the survey</param>
        /// <param name="questionID">questionID passed as parameter to identify the question</param>
        /// <returns></returns>
        public double GetRatingResult(int surveyID, int questionID)
        {
            try
            {
                //SQL Connection
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    command.CommandText = "SELECT Avg FROM RaitingQuestionResults WHERE SurveyID = @surveyID and QuestionID = @questionID";
                    command.Parameters.AddWithValue("@surveyID", surveyID);
                    command.Parameters.AddWithValue("@questionID", questionID);
                    command.Prepare();

                    double avgResult = Convert.ToDouble(command.ExecuteScalar());

                    return avgResult;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// This method Loads Dropdown result from the database
        /// </summary>
        /// <param name="surveyID">surveyID passed as parameter to identify the survey</param>
        /// <param name="questionID">questionID passed as parameter to identify the question</param>
        /// <returns></returns>
        public List<string> GetDropDownResult(int surveyID, int questionID)
        {
            try
            {
                List<string> ddResult = new List<string>();

                //SQL Connection
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    command.CommandText = "SELECT ResponseReturn FROM DropDownQuestionResults WHERE SurveyID = @surveyID and QuestionID = @questionID" +
                                          " ORDER BY Cnt Desc;";
                    command.Parameters.AddWithValue("@surveyID", surveyID);
                    command.Parameters.AddWithValue("@questionID", questionID);

                    command.Prepare();

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ddResult.Add(reader.GetString(0));
                    }

                    return ddResult;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


