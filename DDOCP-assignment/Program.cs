using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDOCP_assignment
{
    public enum QuestionType { Raiting = 1, DropDown = 2, YesNo = 3 }


    static class Program
    { 
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        public static User users = new User();


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainForm());
        }

        public static string GetConnString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
    }
}
