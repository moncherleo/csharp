using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson02
{
    class NarrowingCasting
    {
        int int1 = 0;
        float float1 = 3.14159f;

        public void Narrowing()
        {
            int1 = (int) float1;
            //Should get error
            //"Cannot implicitly convert type 'float' to 'int'"
            Console.WriteLine(float1);
        }

    }
}
