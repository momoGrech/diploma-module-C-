using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDOCP_assignment
{
    /// <summary>
    /// This class contains information about dropdown questions
    /// </summary>
    public class DropDownQuestion
    {
        //Atributes
        private int questionNumber;
        private string text;
        private List<string> options = new List<string>();
        private string answer;
        private QuestionType questionType;

        //Properties
        public int QuestionNumber { get => questionNumber; set => questionNumber = value; }
        public string Text { get => text; set => text = value; }
        public List<string> Options { get => options; set => options = value; }
        public string Answer { get => answer; set => answer = value; }
        public QuestionType QuestionType { get => questionType; set => questionType = value; }

        //Constructor
        public DropDownQuestion()
        {
            //empty constructor
            this.questionType = QuestionType.DropDown;
        }

        public DropDownQuestion(int questionNumber, string questionText, List<string> option, string answer)
        {
            this.questionNumber = questionNumber;
            this.text = questionText;
            this.options = option;
            this.answer = answer;
            this.questionType = QuestionType.DropDown;
        }

        //Methods
    }
}
