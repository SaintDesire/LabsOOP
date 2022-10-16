using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    class FinalExam : Exam
    {
        public FinalExam(int required, int score, string subject)
        {
            Required = required;
            Score = score;
            Subject = subject;
        }
        public override bool Equals(object Obj)
        {
            if (Obj == null)
                return false;
            FinalExam final = (FinalExam)Obj;
            return final.Score == Score;
        }
        public override int GetHashCode()
        {
            return 123 * Score;
        }

        public override string ToString()
        {
            return $"{GetType()} {Required} {Score} {Subject}";
        }
    }
}
