using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson04
{
    class CircleArea
    {
        public const double PI = 3.14159d;

        public static int CalculateBigger(double radius1, double radius2)
        {
            double area1 = radius1 * PI;
            double area2 = radius2 * PI;

            if (area1 > area2)
            {
                Console.WriteLine("First circle area is bigger");
                return 1;
            }
            else if (area1 < area2)
            {
                Console.WriteLine("Second circle area is bigger");
                return 2;
            }
            else
            {
                Console.WriteLine("Both circle areas are equal");
                return 0;
            }
        }

    }
}
