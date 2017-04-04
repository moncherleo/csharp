using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson13
{
    public class Circle : Figure
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
