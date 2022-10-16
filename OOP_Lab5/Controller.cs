using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
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
    }
}
