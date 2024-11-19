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
                        questions[i]=Helper.CreateTrueOrFalseQuestion();

                        break;
                    case 2:
                        questions[i]=Helper.CreateChooseOnlyQuestion();
                        break;
                    case 3:
                        questions[i]=Helper.CreateChooseAllQuestion();
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
                Console.WriteLine(questions[i].PrintData()); 
            }
            #endregion








        }
    }
}
