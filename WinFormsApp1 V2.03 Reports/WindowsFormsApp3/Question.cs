using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Question
    {
        public int ID { get; set; }
        public string QuestionTxt { get; set; }
        List<string> choices = new List<string>();
        public List<string> Choices
        {
            get
            {
                return choices;
            }
        }
    }

}
