namespace Exam
{

    internal class Final : Exam
    {
        public int TypeOfExam { get; set; }
        public int ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public Questions[] questions { get; set; }

        //public Final (int examtime, int numberofquestions)
        //{
        //    ExamTime = examtime;
        //    NumberOfQuestions = numberofquestions;
        //}  
         
        public void ShowExam()
        {
            
        }
    }
}
