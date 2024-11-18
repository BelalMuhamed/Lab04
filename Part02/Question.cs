using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }

        private int mark;

        public int Mark
        {
            get { return mark; }
            set 
            {
                if (value.GetType() == typeof(int))
                {
                    mark = value;
                }
                else 
                {
                    throw new ArgumentException("invalid input");
                }
            }
        }

        public string[] Answers { get; set; }
       
        public virtual void PrintData()
        {
            Console.WriteLine($"{Header} \n {Body} ");
            for (int i = 0; i < Answers.Length; i++)
            {
                Console.WriteLine($" {i+1}) {Answers[i]}");
            }
            Console.WriteLine($"Marks = {mark}");
        }
        
    }
}
