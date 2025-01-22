namespace Exam
{
    internal interface Questions
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public int Mark { get; set; }

        public Answer AnswerArray { get; set; }
        public int RightAnwser { get; set; }

        public void Questions(string header, string body, int mark, Answer answerarray, int rightanswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerArray = answerarray;
            RightAnwser = rightanswer;
        }

        public void DisplayQuestions();


    }
}
