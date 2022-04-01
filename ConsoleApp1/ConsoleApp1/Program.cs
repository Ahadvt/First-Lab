using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3 reqemli ededin reqemlerini bir bir yazirdmaq

            int Number = 876;
            NumberSmash(Number);
            #endregion

            #region Random eded ve texmin etmek
            FindNUmber();
            #endregion
        }

        static void NumberSmash(int number)
        {
            int a = 0;
            int b = 0;

            while (number >= 1)
            {
                a = number / 10;
                b = number - (a * 10);
                number = a;
                Console.Write($"{b},");
            }
        }

        static void FindNUmber()
        {
            Random random = new Random();
            int Texmin = 0;
            int Num = Num = random.Next(1, 100);

            int Count = 0;
            do
            {

                Console.WriteLine("Eded  Daxil edin");
                string NumStr = Console.ReadLine();
                Texmin = int.Parse(NumStr);
                Count++;
                if (Texmin > Num)
                {
                    Console.WriteLine("Asagi");
                }
                else if (Texmin < Num)
                {
                    Console.WriteLine("Yuxari");
                }
            } while (Texmin != Num);
            Console.WriteLine("Cavad Duzgundur" + Count + "Defede Tapdiniz");
        }
    }
}
