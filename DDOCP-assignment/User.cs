using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SQLite;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOCP_assignment
{
    /// <summary>
    /// This calss contains information about both Customers and Administrators
    /// </summary>
    public class User
    {
        //Attribute - data that you will store about the project
        private string fullName;
        private int age;
        private string userName;
        private string password;
        private bool isAdministrator;
        private List<User> userList = new List<User>();

        //Properties - enable atributes to be usable by other forms/classes
        public string FullName { get => fullName; set => fullName = value; }
        public int Age { get => age; set => age = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public bool IsAdministrator { get => isAdministrator; set => isAdministrator = value; }
        public List<User> UserList { get => userList; set => userList = value; }

        //Constructors - special methods that allow copy of the class to be created and used
        public User()
        {
            //empty constructor.
        }

        //overloaded constructor
        public User(string fullName, int age, string userName, string password, bool isAdministrator, List<User> userList)
        {
            this.fullName = fullName;
            this.age = age;
            this.userName = userName;
            this.password = password;
            this.isAdministrator = isAdministrator;
            this.userList = userList;
        }

        /// <summary>
        /// Adds an instance of a user object to the list of users in the database
        /// </summary>
        /// <param name="newUser"> user object to be added to the list of users in the database</param>
        public void registerUser(User newUser)
        {
            UserList.Add(newUser);
        }

        /// <summary>
        /// Searches for a user in the User list using the username; returns null if the user is not found
        /// </summary>
        /// <param name="username">User's unique username is passed as a parameter</param>
        /// <returns>>User which matches the username supplied as parameter or null otherwise</returns>
        // search user
        public User SearchUser(string username)
        {
            try
            {
                //Store the details of the required username if found
                User requiredUser = null;

                //Go through the list of usrList 1 by 1
                for (int index = 0; index < UserList.Count; index++)
                {
                    //Get the current user from the list
                    User currentUser = UserList[index];

                    //Check if the current member number is equal to the supplied member number parameter
                    if (currentUser.UserName.ToLower() == username.ToLower())
                    {
                        //Member found and set required member to current member
                        requiredUser = currentUser;
                    }
                }
                return requiredUser;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// This method saves the user's detail in the database
        /// </summary>
        /// <param name="myUser"> User object is passed as a parameter which contains user's detail</param>
        public void SaveUser(User myUser)
        {
            try
            {
                int adminCode = 0;

                if (isAdministrator == true)
                {
                    adminCode = 1;
                }
                // Create a connection 
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                // create a string with the command (SQL)
                string SQLCOmmandText = "INSERT INTO User (FullName, Age, Username, Password, RegisterAsAdmin) VALUES (@fullName, @age, @username, @password, @registerAsAdmin);";
                //Execute a coomand
                using (SQLiteCommand command = new SQLiteCommand(SQLCOmmandText, connection))
                {
                    //open the connection
                    connection.Open();

                    //preparing sql statments
                    command.Parameters.AddWithValue("@fullName", myUser.FullName);
                    command.Parameters.AddWithValue("@age", myUser.Age);
                    command.Parameters.AddWithValue("@username", myUser.UserName);
                    command.Parameters.AddWithValue("@password", myUser.Password);
                    command.Parameters.AddWithValue("@registerAsAdmin", adminCode);

                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Account is alreay exist!");
            }
        }

        /// <summary>
        /// This method laods all the user and save it to the list of users
        /// </summary>
        /// <returns></returns>
        public bool LoadAllUsers()
        {
            //Clear list from previous users so it does not keep on adding duplicates
            UserList.Clear();
            try
            {
                //Create a connection
                SQLiteConnection connection = new SQLiteConnection(Program.GetConnString());

                //Create a string with the command (SQL)                              
                string SQLCommandText = "SELECT Username, Password, RegisterAsAdmin FROM User;";

                //Execute a Command
                using (SQLiteCommand command = new SQLiteCommand(SQLCommandText, connection))
                {
                    connection.Open();

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //Create a user object
                        User user = new User();

                        //Read the data from the reader into the user object attribute
                        user.UserName = reader["Username"].ToString();
                        user.Password = reader["Password"].ToString();
                        int isAdmin =  Convert.ToInt32(reader["RegisterAsAdmin"]);

                        if (isAdmin == 1)
                        {
                            user.isAdministrator = true;
                        }
                        else
                        {
                            user.isAdministrator = false;
                        }

                        //Add the user to the list of users
                        userList.Add(user);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                throw;
            }
        }
    }
}
