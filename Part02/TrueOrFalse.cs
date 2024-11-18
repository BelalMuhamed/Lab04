using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02
{
    internal class TrueOrFalse:Question
    {
		private  int correctanswerindex;

		public virtual  int CorrectAnswerIndex
        {
			get { return correctanswerindex; }
			set 
			{
				if (value == 0 || value == 1)
					correctanswerindex = value;
				else
					throw new ArgumentException("Not valid");
			}
		}
        public TrueOrFalse()
        {
			Header = "True or False";
			Answers = ["True", "False"];
        }
        public override void PrintData()
		{
			base.PrintData();
            Console.WriteLine($"correct answer:{correctanswerindex}");
		}
    }
}
