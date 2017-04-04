using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson13
{
    public class ACMEBicycle : IBicycle
    {
        int cadence = 0;
        int speed = 0;
        int gear = 1;
        public void changeCadence(int newValue)
        {
            this.cadence = newValue;
        }
        public void changeGear(int newValue)
        {
            this.gear = newValue;
        }
        public void printStates()
        {
            Console.WriteLine(cadence + " " + speed + " " + gear);
        }
    }
}
