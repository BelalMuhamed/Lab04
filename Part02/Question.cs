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
       
        public virtual StringBuilder PrintData()
        {
            StringBuilder sb = new StringBuilder($"{Header} \n {Body} \n");
            for (int i = 0; i < Answers.Length; i++)
            {
                sb.Append($" {i+1}) {Answers[i]} \n");
            }
            sb.Append($"Marks = {mark} \n");
            return sb;
        }
        
    }
}
