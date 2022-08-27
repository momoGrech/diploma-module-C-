using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDOCP_assignment
{
    /// <summary>
    /// This calss contains information about Rating questions
    /// </summary>
    public class RaitingQuestion
    {
        //Atributes
        private int questionNumber;
        private string text;
        private int answer;
        private QuestionType questionType;

        //Properties
        public int QuestionNumber { get => questionNumber; set => questionNumber = value; }
        public string Text { get => text; set => text = value; }
        public int Answer { get => answer; set => answer = value; }
        public QuestionType QuestionType { get => questionType; set => questionType = value; }

        //Constructor
        public RaitingQuestion()
        {
            // empty constructor
            this.QuestionType = QuestionType.Raiting;
        }

        //overloaded constructor
        public RaitingQuestion(int questionNumber, string questionText, int answer)
        {
            this.questionNumber = questionNumber;
            this.text = questionText;
            this.answer = answer;
            this.QuestionType = QuestionType.Raiting;
        }
    }
}
