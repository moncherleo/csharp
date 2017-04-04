using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson13
{
    public class Rectangle : Figure
    {
        private int side1, side2;
        public Rectangle(int side1, int side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        override public double GetArea() {
            return side1 * side2;
        }
        override public double GetPerimeter() {
            return (side1 + side2) * 2;
        }
    }
}
