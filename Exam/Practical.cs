namespace Exam
{
    internal class Practical : Exam
    {
        public int TypeOfExam { get; set; }
        public int ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public Questions[] questions { get ; set; }

        //public Practical(int examtime, int numberofquestions)
        //{
        //    ExamTime = examtime;
        //    NumberOfQuestions = numberofquestions;
        //}

        public void ShowExam()
        {
            
        }
    }
}
