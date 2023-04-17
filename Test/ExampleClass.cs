using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ExampleClass
    {
        public static int[,] Method(int[,] array, int value)
        {//0
            int[,] result = new int[array.GetLength(0), array.GetLength(1)];//1
            for (int i = 0; i < array.GetLength(0); i++)//2
            {
                int sum = 0;//3
                for (int j = 0; j < array.GetLength(1); j++)//4
                {
                    sum += array[i, j];//5
                    if (sum == value)//6
                    {//7
                        result[i, j] = value;//7
                    }//7
                }//4
            }//2
            return result;//8
        }
    }
}
