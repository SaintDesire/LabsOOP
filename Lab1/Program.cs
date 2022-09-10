using System;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1а

            sbyte sb = 12;
            short sh = 13;
            int i = 24;
            long lg = 126513;
            byte b = 44;
            ushort us = 92;
            uint ui = 762;
            ulong ul = 556;
            char ch = 'F';
            bool bl = true;
            float fl = 11.43F;
            double db = 12.12;
            decimal dc = 1234532;
            string str = "Chel";
            object ojb = str;

            // Задание 1b

            int y1 = (int)sh;
            int y2 = (int)lg;
            short y3 = (short)b;
            byte y4 = (byte)us;
            ushort y5 = (ushort)ul;

            int y6 = sh;
            int y7 = us;
            short y8 = b;
            int y9 = sb;
            long y10 = us;

            // Задание 1c

            Int32 k = 16;
            Object d = k;
            short s = (short)(int)d;

            // Задание 1d

            var xz = 45;

            // Задание 1e

            int? xz1 = null;
            int? xz2 = null;
            Console.WriteLine(xz1 == xz2);

            // Задание 1f

            //var js = 12;
            //js = 144F;

            // Задание 2a

            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine(String.CompareOrdinal(str1, str2));

            // Задание 2b
            string str3 = "It's ";
            string str4 = "me, ";
            string str5 = "Mario!";
            string str9 = "My name is ";

            string str12 = String.Concat(str3, str4, str5);
            Console.WriteLine(str12);

            string str6 = String.Copy(str5);
            Console.WriteLine(str6);

            string str7 = str12.Substring(5);
            Console.WriteLine(str7);

            string[] words = str12.Split(new char[] { ' ' });
            foreach (string bj in words)
            {
                Console.WriteLine(bj);
            }

            str12 = str12.Insert(9, str9);
            Console.WriteLine(str12);

            str12 = str12.Remove(9, 11);
            Console.WriteLine(str12);

            int age = 12;
            string name = "Alexandr";
            Console.WriteLine($"Имя: {name} Возраст: {age}");

            // Задание 2c

            string nullstr = null;
            string sclear = "";

            bool bnull = String.IsNullOrEmpty(nullstr);
            Console.WriteLine(bnull);
            bool bclear = String.IsNullOrEmpty(sclear);
            Console.WriteLine(bclear);

            // Задание 2d

            var spb = new StringBuilder("Привет компьютерный мир!");
            Console.WriteLine(spb);

            spb.Remove(6, 13);
            Console.WriteLine(spb);
            spb.Replace("Привет", "Hello");
            Console.WriteLine(spb);

            // Задание 3a

            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int p = 0; p < arr.GetLength(0); p++)
            {
                for (int l = 0; l < arr.GetLength(1); l++)
                {
                    Console.Write("{0}\t", arr[p, l]);
                }
                Console.WriteLine();
            }

            // Задание 3b

            //string[] sarr = { "Салам", "Алейкум", "Братка" };
            //foreach (var uz in sarr) {
            //    Console.WriteLine(uz);
            //}
            //Console.WriteLine(sarr.GetLength(0));
            //string sbarr = Console.ReadLine();
            //int spos = Convert.ToInt32(Console.ReadLine());
            //if (spos > 3 || spos < 1)
            //{
            //    Console.WriteLine("Ошибка ввода!");
            //    return;
            //}
            //sarr[--spos] = sbarr;
            //foreach (var uz in sarr)
            //{
            //    Console.WriteLine(uz);
            //}

            // Задание 3c

            //double[][] darr = new double[3][];
            //darr[0] = new double[2];
            //darr[1] = new double[3];
            //darr[2] = new double[4];
            //int dr = 2;

            //for (int i1 = 0; i1 < 3; i1++)
            //{
            //    for (int j1 = 0; j1 < dr; j1++)
            //    {
            //        darr[i1][j1] = Convert.ToDouble(Console.ReadLine());
            //    }
            //    dr++;
            //}
            //for (int i1 = 0; i1 < 3; i1++)
            //{
            //    for (int j1 = 0; j1 < dr; j1++)
            //    {
            //        Console.Write("{0}\t", darr[i1][j1]);
            //    }
            //    Console.WriteLine();
            //    dr++;
            //}

            // Задание 3d

            var varr = new[] { "Прiвiт", "Кабанчiк" };
            foreach (var pp in varr)
            {
                Console.WriteLine(pp);
            }

            // Задание 4a

            (int, string, char, string, ulong) tuple = (28, "January", 'D', "New", 256);

            // Задание 4b

            Console.WriteLine();
            Console.Write(tuple.Item1 + " ");
            Console.Write(tuple.Item3 + " ");
            Console.Write(tuple.Item4 + " ");
            Console.WriteLine();

            // Задание 4c

            Console.WriteLine();
            string month = tuple.Item2;
            Console.WriteLine(month);

            char letter = tuple.Item3;
            Console.WriteLine(letter);

            // Задание 4d

            Console.WriteLine();
            int bbol = (2, 16).CompareTo((17, 14));
            Console.WriteLine(bbol);
            int bvol = (12, 25).CompareTo((2, 4));
            Console.WriteLine(bvol);
            int bdol = (19, 13).CompareTo((19, 13));
            Console.WriteLine(bdol);

            // Задание 5

            void findTuple(int[] arrb, string strb)
            {
                int min = arrb[0], minIndex = 0;
                for (int i = 0; i < arrb.GetLength(0); i++)
                {
                    if (min > arrb[i])
                    {
                        min = arrb[i];
                        minIndex = i;
                    }
                }
                int max = arrb[0];
                for (int i = 0; i < arrb.GetLength(0); i++)
                {
                    if (max < arrb[i])
                    {
                        max = arrb[i];
                    }
                }
                int sumb = 0;
                for (int i = 0; i < arrb.GetLength(0); i++)
                {
                    sumb += arrb[i];
                }
                (int, int, int, char) tupleb = (min, max, sumb, strb[0]);
                Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, First letter: {3}", min, max, sumb, strb[0]);
            }

            int[] arrb = { 1, 2, 3, 4, 5, 6, 7 };
            string strb = "Ya stanu vodopadom";
            findTuple(arrb, strb);

            void checkFunc()
            {
                int a = 2147483647;
                try
                {
                    checked
                    {
                        Console.WriteLine(a + 1);
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
                }
            }
            checkFunc();
            void uncheckFunc()
            {
                int a = 2147483647;
                try
                {
                    unchecked
                    {
                        Console.WriteLine(a + 1);
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
                }
            }
            uncheckFunc();

        }
    }
}
