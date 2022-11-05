using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab6
{
    static class Controller
    {
        static int numOfChallenge = 0;
        static int numOfTest = 0;

        static public int Challenge(Session session)
        {
            Challenge challenge = new Challenge(0, 0, "", "", "");
            for (int i = 0; i < session.Size; i++)
            {
                if ((session.Arr[i]).GetType() == challenge.GetType())
                {
                    numOfChallenge++;
                }
            }
            return numOfChallenge;
        }

        static public void Exam(Session session, string str)
        {
            Exam exam = new Exam(0, 0, "");
            for (int i = 0; i < session.Size; i++)
            {
                if ((session.Arr[i]).GetType() == exam.GetType())
                {
                    exam = (Exam)session.Arr[i];
                    exam.Subject = str;
                    if (session.Arr[i] == exam)
                    {
                        Console.WriteLine(session.Arr[i].ToString());
                    }
                }
            }
        }

        static public void Test(Session session, int amount)
        {
            Test test = new Test(0, 0, "", "", "");
            for(int i = 0; i < session.Size; i++)
            {
                if((session.Arr[i]).GetType() == test.GetType())
                {
                    test = (Test)session.Arr[i];
                    if(test.Required >= amount)
                    {
                        numOfTest++;
                    }
                }
            }
            Console.WriteLine("Количество тестов с заданым количеством вопросов: " + numOfTest);
        }

        static public void ZeroEx(int x, int y)
        {
            if (y == 0)
            {
                throw new Ex3("Деление на 0 невозможно");
            }
            else
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }
        }

        static public void FormatEx()
        {
            Console.WriteLine("Введите число");
            int x;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out x))
            {
                x *= x;
                Console.WriteLine("Квадрат числа: " + x);
            }
            else
            {
                throw new FormatException("Недопустимый формат введенного значения");
            }
        }

        static public void IndexEx()
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = i;
            }
            Console.WriteLine("Введите индекс: ");
            int x;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out x))
            {
                if (x < 0 || x > 4)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за границы массива");
                }
                else
                {
                    Console.WriteLine("Элемент массива: " + arr[x]);
                }
            }
            else
            {
                throw new FormatException("Недопустимый формат введенного значения");
            }
        }

        static public void AssertEx()
        {
            int aa = 2;
            Debug.Assert(aa != 1, "Некорректно");
        }

        // Debug.Assert нужен для проверки условий, которые должны выполняться во время выполнения программы.
        // Если условие не выполняется, то программа останавливается и выводится сообщение об ошибке.
        // Если условие выполняется, то программа продолжает работу.
    }
}
