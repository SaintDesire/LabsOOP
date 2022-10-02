//Вариант 8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace telephone
{
    static class House
    {
        static int Main()
        {
            bool end = false;
            int choice;
            int mass_elem;
            int mass_lenght = 4;
            string? findName;
            int NumberForID = 12;
            int? takecol;
            (int? hours, int? minutes) AllowedTime;
            telephone.Phone[] PhoneMassive = new telephone.Phone[100];

            Phone phone1 = new Phone();
            Phone phone2 = new Phone("Олег", "Борисов", "Анатольевич", "1234 5632 2312 5156", 3, 19);
            Phone phone3 = new Phone("Анатолий", "Боярский", "Валерьевич", "9123 5162 3216 9312", 0, 27, "Улица Петрова", 92700, 12349);
            Phone phone4 = new Phone(4, "Николай", "Насолях");

            PhoneMassive[0] = phone1;
            PhoneMassive[1] = phone2;
            PhoneMassive[2] = phone3;
            PhoneMassive[3] = phone4;
            /*  
              tovarka.Product obj = new tovarka.Product(ref NumberForID, out takecol);
              for (int i = 0; i < 10; i++)
              {
                  obj[i] = (float)1.5 * i;
              }
              for (int i = 0; i < 10; i++)
              {
                  Console.WriteLine("{0}", obj[i]);
              }
            пример как работает индексатор
            */
            do
            {
                Console.WriteLine("Главное меню\n" +
                    "1)Доавить телефон\n" +
                    "2)Посмотреть информацию о телефоне\n" +
                    "3)Посмотреть текущий баланс\n" +
                    "4)Cписок абонентов с превышеным временем внутригородских звонков\n" +
                    "5)Список абонентов которые пользовались междугородней связью\n" +
                    "6)Информация о классе\n"
                    );
                Console.WriteLine("\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PhoneMassive[mass_lenght] = new telephone.Phone(ref NumberForID, out takecol);
                        PhoneMassive[mass_lenght].Interface();
                        mass_lenght++;
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.WriteLine("Введите номер телефона в массиве");
                        mass_elem = Convert.ToInt32(Console.ReadLine());
                        if (mass_lenght > mass_elem)
                        {
                            PhoneMassive[mass_elem-1].ShowInfo();
                        }
                        else
                            Console.WriteLine("Error\n");
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("Введите номер продукта в массиве");
                        mass_elem = Convert.ToInt32(Console.ReadLine());
                        if (mass_lenght > mass_elem)
                        {
                            PhoneMassive[mass_elem].ShowBalance();
                        }
                        else
                            Console.WriteLine("Error\n");
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        int hours, minutes;
                        
                        Console.WriteLine("Введите разрешенное кол-во часов");
                        hours = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите разрешенное кол-во минут");
                        minutes = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < mass_lenght; i++)
                        {
                            if (PhoneMassive[i].hours > hours && PhoneMassive[i].minutes > minutes)
                            {
                                Console.WriteLine("Превышено время внутригородских звонков");
                                PhoneMassive[i].ShowInfo();
                            }
                        }
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Console.WriteLine("\nПользовались междугородней связью\n");
                        for (int i = 0; i < mass_lenght; i++)
                        {
                            if (PhoneMassive[i].CallType == true)
                            {
                                PhoneMassive[i].ShowInfo();
                                Console.WriteLine("\n");
                            }
                        }
                        break;
                    case 6:
                        if (mass_lenght != 0)
                            telephone.Phone.ClassInfo();
                        Console.WriteLine("\n");
                        break;
                    default:
                        break;
                }
            } while (!end);
            return 0;
        }
    }
}