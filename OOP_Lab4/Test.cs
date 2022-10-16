using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    class Test : Question
    {
        public int Required { get; set; }
        public string Theme { get; set; }

        public Test() { Required = 4; Theme = "Системы Счисления"; Score = 1; Task = "Переведите 0101 в десятичную СС"; Answer = "5"; }
        public Test(int required, int score, string theme, string task, string answer) {
            Required = required;
            Score = score;
            Theme = theme;
            Task = task;
            Answer = answer;
        }
        public override string ToString()
        {
            return $"{GetType()} {Required} {Score} {Theme} {Task} {Answer}";
        }
    }
}
