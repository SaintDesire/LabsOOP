using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    partial class Exam : ForExam, IExam
    {
        public int Required { get; set; }
        public int Score { get; set; }
        public string Subject { get; set; }

        public Exam() { Required = 60; Subject = "Русский язык"; }
        public Exam(int required, int score, string subject)
        {
            Required = required;
            Score = score;
            Subject = subject;
        }
    }
}
