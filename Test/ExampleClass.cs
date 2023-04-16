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
        {
            int[,] result = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                    if (sum == value)
                    {
                        result[i, j] = value;
                    }
                }
            }
            return result;
        }
    }
}
