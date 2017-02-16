using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson06
{
    class Loopers
    {
        public void Decrement()
        {
            Console.WriteLine("Please enter first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            while (firstNumber > secondNumber)
            {
                firstNumber--;
                Console.WriteLine("First number is " + firstNumber + " and second number is " + secondNumber);
            }
        }

        public void AllNumbersFrom10To1()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void PreAndPostIncrements()
        {
            int a = 1;
            Console.WriteLine("Original a value " + a);
            Console.WriteLine("Post-increment a " + a++);
            Console.WriteLine("After post-increment " + a);
            Console.WriteLine("Pre-increment a " + ++a);
            Console.WriteLine("After pre-increment " + a);
        }

        public void CountEvenNumbers()
        {
            int counter = 0;
            //for (int i = 0; i <= 20; i++) {
            //    if (i % 2 == 0) {
            //        counter++;
            //    }
            //}

            for (int i = 0; i <= 20; i += 2)
            {
                counter++;
            }

            Console.WriteLine(counter);
        }

        public void ArrayLooper() {
            int[] intArray = {0,2,4,6,8};

            foreach (int element in intArray) {
                Console.WriteLine(element);
            }
        }
    }
}
