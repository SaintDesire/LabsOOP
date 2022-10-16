using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    class Question : ForClone, IClone
    {
        public int Score { get; set; }
        public string Task { get; set; }
        public string Answer { get; set; }
        
        public Question() { Score = 2; Task = "Зимой зеленое"; Answer = "Елка"; }

        public Question(int score, string task, string answer)
        {
            Score = score; 
            Task = task;
            Answer = answer;
        }

        public override bool Clone(object Obj)
        {
            Question question = (Question)Obj;
            Score = question.Score;
            Task = question.Task;
            Answer = question.Answer;
            Console.WriteLine("Клонирование успешно");
            return true;
        }

        bool IClone.Clone(object Obj)
        {
            Question question = (Question)Obj;
            Console.WriteLine($"Баллы - {Score}, Вопрос - {Task}, Ответ - {Answer}");
            return true;
        }

        public override string ToString()
        {
            return $"{GetType()} {Score} {Task} {Answer}";
        }
    }
}
