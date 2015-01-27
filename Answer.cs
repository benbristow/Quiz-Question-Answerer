using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Question_Answerer
{
    class Answer
    {
        public string Answer_Text { get; protected set; }

        public int Count { get; protected set; }

        public Answer(string text)
        {            
            this.Answer_Text = text;
            this.Count = 0;
        }

        public void IncrementCount() {
            this.Count += 1;
        }
    }
}
