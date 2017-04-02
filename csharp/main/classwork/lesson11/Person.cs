using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    public class Person
    {
        protected String name;
        public Person(String name)
        {
            this.name = name;
        }

        public virtual String GetResponse(String q)
        {
            return "My answer is " + q;
        }
    }
}
