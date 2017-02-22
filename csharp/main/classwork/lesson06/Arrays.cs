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
            int[,] array2 = new int[2, 3];

            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    array2[j, k] = (j + 1) * (k + 1);
                    Console.Write(array2[j, k] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
