using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson04
{
    class CircleRadius
    {
        const double PI = 3.14159;

        public static double Calculate(double radius)
        {
            double circleArea = PI * radius * radius;
            Console.WriteLine("Circle area is " + circleArea);
            return circleArea;
        }

    }
}
