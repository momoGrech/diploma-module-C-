using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDOCP_assignment
{
    /// <summary>
    /// This calss contains information about Yes/No questions
    /// </summary>
    public class YesNoQuestion
    {
        //Atributes
        private int questionNumber;
        private string text;
        private bool answer;
        private QuestionType questionType;

        //Properties
        public int QuestionNumber { get => questionNumber; set => questionNumber = value; }
        public string Text { get => text; set => text = value; }
        public bool Answer { get => answer; set => answer = value; }
        public QuestionType QuestionType { get => questionType; set => questionType = value; }

        //Constructor
        public YesNoQuestion()
        {
            //empty constructor
            this.questionType = QuestionType.YesNo;
        }

        //overloaded constructor
        public YesNoQuestion(int questionNumber, string questionText, bool answer)
        {
            this.questionNumber = questionNumber;
            this.text = questionText;
            this.answer = answer;
            this.questionType = QuestionType.YesNo;
        }
    }
}
