using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Subject
    {
        public int SubjrctId { get; set; }
        public string SubjectName  { get; set; }
        public string Exam { get; set; }

      
        public void ShowExam (string exam)
        {
            Exam = exam;
        }
           

    }
}
