using Tyuiu.GrabinaSA.Sprint2.Task6.V10.Lib;
namespace Tyuiu.GrabinaSA.Sprint2.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер года: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Дата предыдущего дня: " + ds.FindDateOfPreviousDay(g, m, n));

            Console.ReadKey();
        }
    }
}
