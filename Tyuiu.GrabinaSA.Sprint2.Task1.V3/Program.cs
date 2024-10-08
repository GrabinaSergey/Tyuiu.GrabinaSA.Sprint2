using System.ComponentModel;
using Tyuiu.GrabinaSA.Sprint2.Task1.V3.Lib;
namespace Tyuiu.GrabinaSA.Sprint2.Task1.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
