using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    class Exam : ForExam, IExam
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
        public override void InfoRequired()
        {
            Console.WriteLine($"Требуется баллов: {Required}");
        }
        public void Diff()
        {
            if (Required <= Score)
            {
                Console.WriteLine($"Вам хватает баллов и + сверху: {Score - Required}");
            } else
            {
                Console.WriteLine($"Вам не хватает: {Required - Score}");
            }
        }
        public virtual void Info()
        {
            Console.WriteLine($"Экзамен: Требуемое кол-во баллов - {Required}, Текущее кол-во баллов - {Score}, Предмет - {Subject}");
        }

        public override string ToString()
        {
            return $"{GetType()} {Required} {Score} {Subject}";
        }

    }
}
