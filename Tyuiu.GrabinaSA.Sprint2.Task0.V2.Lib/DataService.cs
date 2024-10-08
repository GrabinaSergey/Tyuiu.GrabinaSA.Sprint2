﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GrabinaSA.Sprint2.Task0.V2.Lib
{
    public class DataService : ISprint2Task0V2
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 1;
            res[1] = x != y - 1;
            res[2] = x < y;
            res[3] = x + 1 > y;
            res[4] = x + 1 <= y;
            res[5] = x >= y;
            return res;
        }
    }
}
