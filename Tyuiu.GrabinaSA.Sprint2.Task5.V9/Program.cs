﻿using Tyuiu.GrabinaSA.Sprint2.Task5.V9.Lib;
namespace Tyuiu.GrabinaSA.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            int y = 0;

            switch (x)

            {

                case -3:

                case -2:

                case -1: y = -x; break;

                case 0: y = 5; break;

                case 3:

                case 2:

                case 1: y = 2 * x; break;

            }
            Console.WriteLine(y);
            DataService ds = new DataService();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Введите переменную m:");
            int m = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите переменную n:");
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine(ds.FindDateOfNextDay(m, n));
        }
    }
}
