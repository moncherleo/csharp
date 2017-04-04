using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson13
{
    abstract public class Figure
    {
        public virtual double GetArea() { return 0.0d; }
        abstract public double GetPerimeter();
    }
}
