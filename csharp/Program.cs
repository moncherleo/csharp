using csharp.main.classwork.lesson02;
using csharp.main.classwork.lesson06;
using csharp.main.menus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static int[] array1 = { 1, 2, 3 };

        static void Main(string[] args)
        {
            Arrays arrays = new Arrays();
            arrays.Multi();
            Console.ReadKey();

            arrays.Jagged();

            //Loopers loopers = new Loopers();
            //loopers.ArrayLooper();

            Console.ReadKey();
        }
    }
}
