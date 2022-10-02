using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telephone
{
    partial class Phone
    {
        const string Type = "phone"; // поле константа
        public static readonly int NumberForHesh;
        public int Id { get; set; }
        public String? Name { get; set; }
        public String? Surname { get; set; }
        public String? Patronymic { get; set; }
        public String? Adress { get; set; }
        public String? CardNumber { get; set; }

        public int hours;
        public int minutes;

        public bool CallType;
        public int Debet { get; set; }
        public int Credit { get; set; }
        public int kol_voObject = 0;

        public Phone()
        {
            Id = 1;
            Name = "Александр";
            Surname = "Питерский";
            Patronymic = "Олегович";
            Adress = "Улица Пушкина";
            CardNumber = "5470 8740 4560 2388";
            Debet = 23516;
            Credit = 2380;
            CallType = false;
            hours = 2;
            minutes = 15;
            kol_voObject++;
        }

        public Phone(string name, string surname, string patronymic, string cardNumber, int hours, int minutes)
        {
            Id = 2;
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            Adress = "Улица Пушкина";
            this.CardNumber = cardNumber;
            Debet = 23516;
            Credit = 2380;
            CallType = true;
            this.hours = hours;
            this.minutes = minutes;
            kol_voObject++;
        }

        public Phone(string name, string surname, string patronymic, string cardNumber, int hours, int minutes, string adress, int debet, int credit)
        {
            Id = 3;
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Adress = adress;
            this.CardNumber = cardNumber;
            this.Debet = debet;
            this.Credit = credit;
            this.hours = hours;
            this.minutes = minutes;
            CallType = true;
            kol_voObject++;
        }

        public Phone(int id, string name, string surname, string patronymic = " ")
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            Adress = "Улица Колотушкина";
            CardNumber = "1234 5678 9101 1121";
            Debet = 56712;
            Credit = 12341;
            CallType = true;
            hours = 1;
            minutes = 46;
            kol_voObject++;
        }

        public override int GetHashCode()
        {
            Random x = new Random();
            return Id * 3 * x.Next(100) * NumberForHesh;
        }

        static Phone() { NumberForHesh = 10; }
        public Phone(ref int Debet, out int? take)
        {
            Id = Debet;
            Id = this.GetHashCode();
            take = 14;
        }
        protected float[] msf = new float[10];
        public float this[int j]
        {
            get
            {
                return msf[j];
            }
            set
            {
                msf[j] = value;
            }
        }
        public static void ClassInfo()
        {
            Console.WriteLine("Статическая информация о классе");
            Console.WriteLine("Это класс телефон");
            Console.WriteLine("Его тип: " + Type);
            Secret();
        }
        private static void Secret()
        {
            Console.WriteLine("Закрытый конструктор");
        }
        public void TotalAmountOfClients()
        {
            Console.WriteLine($"Общее кол-во телефонов {kol_voObject}");
        }
        static void Menu()
        {
            Console.WriteLine("Ввод данных");

        }
        public void Interface()
        {

            Menu();
            Console.WriteLine("Ввести фамилию");
            Surname = Console.ReadLine();
            Console.WriteLine("Ввести имя");
            Name = Console.ReadLine();
            Console.WriteLine("Ввести отчество");
            Patronymic = Console.ReadLine();
            Console.WriteLine("Ввести адрес");
            Adress = Console.ReadLine();
            Console.WriteLine("Ввести номер карты");
            CardNumber = Console.ReadLine();
            Console.WriteLine("Ввести дебет");
            Debet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввести кредит");
            Credit = Convert.ToInt32(Console.ReadLine());

        }
        public void ShowInfo()
        {
            Console.WriteLine(Surname + " " + Name + " " + Patronymic + " | ФИО");
            Console.WriteLine(Adress + " | адрес");
            Console.WriteLine(CardNumber + " | номер карты");
            Console.WriteLine(Debet + " | дебет");
            Console.WriteLine(Credit + " | кредит");
            Console.WriteLine(Id + " | ID");
        }
        public void ShowBalance()
        {
            Console.WriteLine("Баланс на текущий момент: " + Debet);
        }
        public override string ToString()
        {
            return $"{Name}";
        }
        //override - Если было использовано это ключевое слово, на выходе будет использоваться переопределенный метод. Вне зависимости от того, как было оформлено обращение к методу.
    }
}