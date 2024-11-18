using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Part02
{
    internal class Choose_Many:Question
    {
        public int[] CorrectAnswerIndexes { get; set; }
        private int numberofanswers;

        public int NumberOfAnswers
        {
            get { return numberofanswers; }
            set
            {
                if (value > 0 && value < 6)
                    numberofanswers = value;
                else
                    throw new ArgumentOutOfRangeException("lot of answers");
            }
        }
        private int correctanswersnumber;

        public int CorrectAnswersNumber
        {
            get { return correctanswersnumber; }
            set { 
                if(value<=numberofanswers)
                    correctanswersnumber = value;
                else
                    throw new ArgumentOutOfRangeException("out of range ");
            }
        }

        public Choose_Many()
        {
            Header = "Choose Maney ";
            Answers = new string[numberofanswers];
            CorrectAnswerIndexes=new int[correctanswersnumber];
        }
        public override void PrintData()
        {
            base.PrintData();
            Console.Write("Correct Answer : ");
            for (int i = 0; i < CorrectAnswerIndexes.Length; i++) 
            {
                Console.Write($"{CorrectAnswerIndexes[i] },");
            }
        }
    }
}
