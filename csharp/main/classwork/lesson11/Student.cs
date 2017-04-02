using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    public class Student : Person
    { //class name   
        private String university; //class fields
        private String response = "Ehhh, what was the question?";
        public readonly double pi = 3.14; // essentially a constant

        public Student(String name, String university)
            : base(name) // call parent (super) class constructor       
        { // constructor       
            this.university = university; // extend with new fields   
        }
        public override String GetResponse(String q)
        { // method       
            return response;
        }
    }
}