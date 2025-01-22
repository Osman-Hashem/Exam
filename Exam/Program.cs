namespace Exam
{
    internal class Program
    {
        static void Main()
        {

            Subject subject = new Subject();

            Console.WriteLine("Please Enter The Type Of Exam ( 1- For Final || 2- For Practical ??");
            int TypeOfExam = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Please Enter Time Of Exam For ( 30 Min To 180 Min ) ?? ");

            int TimeOfExam = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Please Enter The Number Of Questions ?? ");

            int NumberOfQuestions = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Questions questions;



            Console.WriteLine("Please Enter Type Of Questions ( 1- For MCQ || 2- For T || F ) ?? ");

            TypeOfExam = int.Parse(Console.ReadLine());



            if (TypeOfExam == 1)
            {
                questions = new MCQQuestions();
                Console.WriteLine("MCQ Questions ");


                Console.WriteLine("Please Enter Questions Body ??");
                questions.Body = Console.ReadLine();

                Console.WriteLine("Please Enter Questions Mark ??");
                questions.Mark = int.Parse(Console.ReadLine());

                Console.WriteLine("Choices Of Questions -");
                Console.WriteLine("Enter Choice Number 1 ??");
                questions.Body = Console.ReadLine();

                Console.WriteLine("Enter Choice Number 2 ??");
                questions.Body = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Please Enter The Right Answer ID ?? ");
                questions.RightAnwser = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Please Enter Type Of Questions ( 1- For MCQ || 2- For T || F ) ?? ");
            TypeOfExam = int.Parse(Console.ReadLine());



            if (TypeOfExam == 2)
            {

                questions = new TruFalseQuestions();

                Console.WriteLine("True | False Questions ");

                Console.WriteLine("Please Enter Questions Body ??");
                questions.Body = Console.ReadLine();

                Console.WriteLine("Please Enter Questions Mark ??");
                questions.Mark = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter The Right Answer ID (1- For True || 2- For False ?? ");
                questions.RightAnwser = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("Do You Want To Start The Exam ?? (Y | N)");
            subject.Exam = Console.ReadLine();


        }
    }
}
