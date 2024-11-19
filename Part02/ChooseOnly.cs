using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Part02
{
    internal class ChooseOnly:Question
    {
        private int correctanswerindex;

        public int CorrectAnswerIndex
        {
            get { return correctanswerindex; }
            set
            {
                if (value<=numberofanswers)
                    correctanswerindex = value;
                else
                    throw new ArgumentException("Not valid");
            }
        }
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

        public ChooseOnly()
        {
            Header = "Choose Only ";
            Answers = new string[numberofanswers];
        }
        public override StringBuilder PrintData()
        {
            return (base.PrintData().Append($"correct answer:{correctanswerindex}"));
            
        }
    }
}
