using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson02
{
    class WideningCasting
    {
        byte byte1 = 127;
        short short1 = 0;
        int int1 = 0;
        long long1 = 0L;
        float float1 = 0.0f;
        double double1 = 0.0d;
        //correct conversion 64f<=32f<=64<=32<=16<=8
        public void CastToWidening()
        {
            double1 = float1 = long1 = int1 = short1 = byte1;
            Console.WriteLine(double1);
        }

    }
}
