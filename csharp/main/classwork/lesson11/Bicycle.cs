using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    public class Bicycle
    {
        private int wheelSize; private string color; //variable
        public Bicycle(int wheelSize, string color)
        { // constructor with args       
            this.color = color; this.wheelSize = wheelSize;
        }
        public Bicycle(int wheelSize)                // constructor with args 
          : this()                // call no-args constructor
        {
            this.wheelSize = wheelSize;
        }
        public Bicycle()
        {       // no-args constructor      
            wheelSize = 26; color = "red";
        }
        public string Ride()
        {   // method  
            Console.WriteLine("Bicycle color is " + color + " size is " + wheelSize);     
            return "Wroom!";
        }
    }

}
