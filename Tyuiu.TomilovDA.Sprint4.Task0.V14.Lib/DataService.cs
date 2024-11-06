﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TomilovDA.Sprint4.Task0.V14.Lib
{
    public class DataService : ISprint4Task0V14
    {
        public int GetSumOddArrEl(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}