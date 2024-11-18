using System.IO.IsolatedStorage;

namespace Part02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TypeOfQuestion;
            int NumberOfQuestions;
            
            bool flag=true;
            do
            {
                Console.WriteLine("Enter the number of questions ");
                flag = int.TryParse(Console.ReadLine(), out NumberOfQuestions);
            } while (!flag);
            Question[] questions = new Question[NumberOfQuestions];

            for (int i=0; i<NumberOfQuestions;i++)
            {
                #region TakeTypeOfTheQuestion
                do
                {
                    Console.WriteLine("Enter the Type of Question ");
                    Console.WriteLine("choose 1 for True or False ");
                    Console.WriteLine("choose 2 for Choose one ");
                    Console.WriteLine("choose 3 for choose many ");
                    flag = int.TryParse(Console.ReadLine(), out TypeOfQuestion);
                } while (!flag);
                #endregion

                #region Fill the array of question 
               
                switch (TypeOfQuestion)
                {
                    case 1:
                            questions[i] = new TrueOrFalse();
                            Console.WriteLine("Enter Your Question");
                            questions[i].Body = Console.ReadLine();
                            Console.WriteLine("Enter the marks of the question ?");
                            questions[i].Mark = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Correct Answer number ");
                            ((TrueOrFalse)questions[i]).CorrectAnswerIndex = int.Parse(Console.ReadLine());
                            

                        break;
                    case 2:
                        questions[i] = new ChooseOnly();
                        Console.WriteLine("Enter Your Question");
                        questions[i].Body = Console.ReadLine();
                        Console.WriteLine("Enter the marks of the question ?");
                        questions[i].Mark = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter how many answers you want ?");
                        ((ChooseOnly)questions[i]).NumberOfAnswers = int.Parse(Console.ReadLine());
                        questions[i].Answers = new string[((ChooseOnly)questions[i]).NumberOfAnswers];
                        for (int j =0; j< ((ChooseOnly)questions[i]).NumberOfAnswers;j++)
                        {
                            Console.WriteLine($"Enter the {j+1}Answer");
                            questions[i].Answers[j] = Console.ReadLine();
                        }
                        Console.WriteLine("Enter the Correct Answer number ");
                        ((ChooseOnly)questions[i]).CorrectAnswerIndex = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        questions[i] = new Choose_Many();
                        Console.WriteLine("Enter Your Question");
                        questions[i].Body = Console.ReadLine();
                        Console.WriteLine("Enter the marks of the question ?");
                        questions[i].Mark = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter how many answers you want ?");
                        ((Choose_Many)questions[i]).NumberOfAnswers = int.Parse(Console.ReadLine());
                        questions[i].Answers = new string[((Choose_Many)questions[i]).NumberOfAnswers];

                        for (int j = 0; j < ((Choose_Many)questions[i]).NumberOfAnswers; j++)
                        {
                            Console.WriteLine($"Enter the {j + 1}Answer");
                            questions[i].Answers[j] = Console.ReadLine();
                        }
                        Console.WriteLine("Enter how many answers are correct ? ");
                        ((Choose_Many)questions[i]).CorrectAnswersNumber = int.Parse(Console.ReadLine());
                        ((Choose_Many)questions[i]).CorrectAnswerIndexes = new int[((Choose_Many)questions[i]).CorrectAnswersNumber];
                        for (int j = 0; j < ((Choose_Many)questions[i]).CorrectAnswersNumber;j++)
                        {
                            Console.WriteLine($"Enter the Number of {j+1} correct answer");
                            ((Choose_Many)questions[i]).CorrectAnswerIndexes[j]=int.Parse(Console.ReadLine());
                        }
                        break ;
                    default:
                        Console.WriteLine("Enter the correct choice");
                        break;

                }
                #endregion


            }


            #region PrintArray
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].PrintData();
            }
            #endregion








        }
    }
}
