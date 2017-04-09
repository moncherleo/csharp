using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson14
{
    class HashSetExample
    {
        public void HashSetSample()
        {
            HashSet<String> hs = new HashSet<String>();
            hs.Add("C");
            hs.Add("R");
            hs.Add("E");
            hs.Add("A");
            hs.Add("M");
            hs.Add("C");
            foreach (String elem in hs)
            {
                Console.Write(elem + " ");
            } //[C R E A M]
        }
    }
}
