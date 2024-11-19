using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02
{
    internal static class Helper
    {
        #region CreateTrueOrFalseQuestion
        public static TrueOrFalse CreateTrueOrFalseQuestion( )
        {
           TrueOrFalse question = new TrueOrFalse();
            Console.WriteLine("Enter Your Question");
            question.Body = Console.ReadLine();
            //take marks
            question.Mark = TakeTheMarksFromUser();
            // take the correct answer 
            while (true)
            {
                Console.WriteLine("Enter the Correct Answer number (1 or 2):");
                if (int.TryParse(Console.ReadLine(), out int correctAnswerIndex) && (correctAnswerIndex == 1 || correctAnswerIndex == 2))
                {
                    question.CorrectAnswerIndex = correctAnswerIndex;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter either 1 or 2 for the correct answer index.");
                }
            }
            return question;
        }
        #endregion

        #region CreateChooseOnlyQuestion
        public static ChooseOnly CreateChooseOnlyQuestion()
        {
            ChooseOnly question = new ChooseOnly();
            Console.WriteLine("Enter Your Question");
            question.Body = Console.ReadLine();
            //take marks 
            question.Mark = TakeTheMarksFromUser();
            //how many answers
            question.NumberOfAnswers = TakeNumberOfAnswers();

            //filling array of answers 
            question.Answers = new string[question.NumberOfAnswers];
            for (int j = 0; j < question.NumberOfAnswers; j++)
            {
                Console.WriteLine($"Enter the {j + 1}Answer");
                question.Answers[j] = Console.ReadLine();
            }
            //take correct answer 
            while (true)
            {
                Console.WriteLine("Enter the Correct Answer number :");
                if (int.TryParse(Console.ReadLine(), out int correctAnswerIndex) && (correctAnswerIndex > 0 && correctAnswerIndex <= question.NumberOfAnswers+1))
                {
                    question.CorrectAnswerIndex = correctAnswerIndex;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. ");
                }
            }
            return question;

        }

        #endregion

        #region  CreateChooseManyQuestion
        public static Choose_Many CreateChooseAllQuestion()
        {
            Choose_Many question = new Choose_Many();
            Console.WriteLine("Enter Your Question");
            question.Body = Console.ReadLine();
            //Mark
            question.Mark = TakeTheMarksFromUser();
            //how many answers
            question.NumberOfAnswers = TakeNumberOfAnswers();
            //array of all answers 
            question.Answers = new string[(question).NumberOfAnswers];

            for (int j = 0; j < (question).NumberOfAnswers; j++)
            {
                Console.WriteLine($"Enter the {j + 1}Answer");
                question.Answers[j] = Console.ReadLine();
            }
            //how many  answers are correct 
            while (true)
            {
                Console.WriteLine("how many  answers are correct ?");
                if (int.TryParse(Console.ReadLine(), out int correctAnswersNumber) && correctAnswersNumber >= 0&&correctAnswersNumber<=question.NumberOfAnswers)
                {
                    question.CorrectAnswersNumber = correctAnswersNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative integer for the number of correct answers.");
                }
            }
            //array of correct answers numbers 
            question.CorrectAnswerIndexes = new int[question.CorrectAnswersNumber];
            for (int j = 0; j < question.CorrectAnswersNumber; j++)
            {
                while (true)
                {
                    Console.WriteLine($"Enter the number of {j + 1} correct answer:");
                    if (int.TryParse(Console.ReadLine(), out int correctAnswerIndex) && correctAnswerIndex >= 0&&correctAnswerIndex<=question.NumberOfAnswers+1)
                    {
                        question.CorrectAnswerIndexes[j] = correctAnswerIndex;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid non-negative integer for the correct answer index.");
                    }
                }
            }
            return question;
        }

        #endregion

        #region take the marks 
        public static int TakeTheMarksFromUser()
        {
            int marks;
            while (true)
            {
                Console.WriteLine("Enter the marks of the question:");
                if (int.TryParse(Console.ReadLine(), out  marks) && marks >= 0)
                {
                  
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative integer for marks.");
                }
                
            }
            return marks;
        }
        #endregion

        #region TakeNumberOFAnswers
        public static int TakeNumberOfAnswers()
        {
            int answers;
            while (true)
            {
                Console.WriteLine("Enter how many answers you want ?");
                if (int.TryParse(Console.ReadLine(), out  answers) && answers >= 0 && answers < 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid non-negative integer for how many answers .");
                }

            }
            return answers;
        }
        #endregion


    }
}
