using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    class Challenge : Question
    {
        public int Time { get; set; }
        public string Award { get; set; }

        public Challenge(int score,int time, string task, string answer, string award)
        {
            Score = score;
            Time = time;
            Task = task;
            Award = award;
            Answer = answer;
        }

        public override string ToString()
        {
            return $"{GetType()} {Score} {Time} {Task} {Award} {Answer}";
        }
    }
}
