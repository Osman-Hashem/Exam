namespace Exam
{
    internal interface  Exam
    {
        public int TypeOfExam { get; set; }
        public int ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }

        public Questions[] questions { get; set; }

        public void Exam(int typeofexam , int examtime , int numberofquestions)
        {
            TypeOfExam = typeofexam;
            ExamTime = examtime;
            NumberOfQuestions = numberofquestions;
        }

        public void ShowExam();


    }
}
