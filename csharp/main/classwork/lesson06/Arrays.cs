using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson06
{
    class Arrays
    {
        public void Jagged()
        {
            int[,] a = {{1,2,3},
            {4,5,6},
            {7,8,9}};


            int[][] array2 = new int[2][];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new int[3];
            }

            for (int j = 0; j < array2.Length; j++)
            {
                for (int k = 0; k < array2[j].Length; k++)
                {
                    array2[j][k] = (j + 1) * (k + 1);
                    Console.Write(array2[j][k] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Multi()
        {
            int[,] arr = new int[2, 3];
            for (int j = 0; j<arr.GetLength(0); j++)
            {
                for (int k = 0; k<arr.GetLength(1); k++)
                {
                    arr[j, k] = (j + 1) * (k + 1);
                }
            }
        }
    }
}
