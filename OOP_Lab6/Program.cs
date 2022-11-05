using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger Log = new Logger();
            try { 
            Console.WriteLine("----------------------------------------");
            StructCont structCont = new StructCont((int)Enum.Октябрь, "Октябрь");
            Console.WriteLine($"{structCont.Num} - {structCont.Str}\n");
            Challenge challenge = new Challenge(5, 60, "Белый?", "Черный", "Зачет");
            Challenge challenge1 = new Challenge(3, 15, "Без чего ничего никогда не бывает??", "Название", "Конфета");
            Exam exam = new Exam(35, 70, "Русский язык");
            Exam exam1 = new Exam(60, 32, "Математика");
            Test test = new Test(3, 5, "Загадки с подвохом", "Что было «завтра», а будет «вчера»?", "Сегодня");
            Test test1 = new Test(5, 2, "Загадки с подвохом", "Каких камней нет ни в одном море?", "Сухих");
            Test test2 = new Test(7, 6, "Загадки с подвохом", "Какая птица из яйца родится, а яйца не несёт?", "Петух");

            Log.WriteLine("Созданы 7 объектов");

            Session session = new Session(7);

            Log.WriteLine("Создан обьект класса Session");


            session.Add(challenge);
            session.Add(challenge1);
            session.Add(exam);
            session.Add(exam1);
            session.Add(test);
            session.Add(test1);
            session.Add(test2);
            session.Out();

            Log.WriteLine("Произведен вывод на экран");


            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Количество испытаний: {Controller.Challenge(session)}");
            Console.WriteLine("----------------------------------------");

            Log.WriteLine("Посчитали количество испытаний");

            Controller.Exam(session, "Русский язык");

            Log.WriteLine("Вывели на экран все экзамены по заданному пр едмету");

            Console.WriteLine("----------------------------------------");

            Controller.Test(session, 4);

            Log.WriteLine("Вывели на экран все тесты с требуемым балом");

            Console.WriteLine("----------------------------------------");

            Controller.ZeroEx(6, 2);
            Controller.FormatEx();
            Controller.IndexEx();
            Controller.AssertEx();

            }
            catch (Ex1 ex1)
            {
                // пример всех методов класса Exception
                Log.WriteError(ex1.Message);
                Console.WriteLine(ex1.Message);
                Console.WriteLine(ex1.TargetSite);
                Console.WriteLine(ex1.StackTrace);
                Console.WriteLine(ex1.Source);
                Console.WriteLine(ex1.InnerException);
            }
            catch (Ex2 ex2)
            {
                Log.WriteError(ex2.Message);
                Console.WriteLine(ex2.Message);
                Console.WriteLine(ex2.TargetSite);
                Console.WriteLine(ex2.StackTrace);
            }
            catch (Ex3 ex3)
            {
                Log.WriteError(ex3.Message);
                Console.WriteLine(ex3.Message);
                Console.WriteLine(ex3.TargetSite);
                Console.WriteLine(ex3.StackTrace);
            }
            catch (FormatException f)
            {
                Log.WriteError(f.Message);
                Console.WriteLine(f.Message);
                Console.WriteLine(f.TargetSite);
                Console.WriteLine(f.StackTrace);
            }
            catch (IndexOutOfRangeException ind)
            {
                Log.WriteError(ind.Message);
                Console.WriteLine(ind.Message);
                Console.WriteLine(ind.TargetSite);
                Console.WriteLine(ind.StackTrace);
            }
            catch
            {
                // Непридвиденная ошибка
                Console.WriteLine("Сработал универсальный обработчик");
            }
            finally
            {
                // Данный блок будет всегда выполняться
                Console.WriteLine("Программа завершена");
            }
            Log.WriteEnd();
        }

    }
}