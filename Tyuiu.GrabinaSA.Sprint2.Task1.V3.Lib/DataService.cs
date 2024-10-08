using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GrabinaSA.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            // a = 185, b = 316, c = 134, d = 134.
            res[0] = (a < b) | (c > d); // true
            res[1] = (a < b) & (c > d); // false
            res[2] = (a > b) || (c > d); // false
            res[3] = (a > b) && (c > d); // false
            res[4] = !(res[0]); // false
            res[5] = (a > b) ^ (c < d); //false
            return res;

        }
    }
}
