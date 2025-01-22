using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class MCQQuestions : Questions
    {
        public string Header { get ; set ; }
        public string Body { get ; set ; }
        public int Mark { get; set; }
        public Answer AnswerArray { get ; set ; }
        public int RightAnwser { get ; set ; }

        public void DisplayQuestions()
        {
            
        }
    }
}
