using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nСоздание двух объектов класса Question");
            Question question = new Question(5, "Что такое полиморфизм?", "Переопределение членов базового класса в классе - наследнике");
            Question question1 = new Question(4, "Что такое наследование?", "Это механизм получения нового класса на основе уже существующего");
            Console.WriteLine();
            Console.WriteLine(question.ToString());
            Console.WriteLine(question.Clone(question1));
            Console.WriteLine("Клонированный объект: " + question.ToString());
            Console.WriteLine();
            Console.WriteLine(((IClone)question).Clone(question1));

            Console.WriteLine("Создание объекта класса Exam");
            Exam exam = new Exam(60, 55, "Математика");
            exam.Info();
            exam.InfoRequired();
            exam.Diff();

            Console.WriteLine("\nСоздание объекта класса FinalExam, наследующего класс Exam");
            FinalExam final = new FinalExam(40, 56, "Английский язык");
            final.Info(); final.InfoRequired(); final.Diff();

            Console.WriteLine("\nIs и As");
            if (exam is Exam)
            {
                Exam Exam1 = exam;
                Exam1.InfoRequired();
            }
            if (exam is IExam)
            {
                IExam Exam2 = exam;
                Exam2.Diff();
            }
            Console.WriteLine(exam is Exam);

            Console.WriteLine();
            Challenge challenge = new Challenge(56, 90, "C# нужный ЯП?", "Конечно", "Зачет");
            Test test = new Test(20, 67, "Конкатенация строк", "С помощью какого метода можно обьединить две строки?", "Concat");

            Printer print = new Printer();
            print.IAmPrinting(challenge);
            print.IAmPrinting(test);
        }

    }
}