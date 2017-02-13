using csharp.main.classwork.lesson04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.menus
{
    class Lesson04Menu
    {
        public static void Menu() {
            Console.WriteLine("Please enter value '1' to run right-angle triangle check program");
            Console.WriteLine("Please enter value '2' to run circle area comparison program");
            Console.WriteLine("Please enter value '3' to run circle area calculation program");
            Console.WriteLine("Please enter value '4' to run even or odd definition program");
            Console.WriteLine("Please enter value '0' to exit program");

            int value = Convert.ToInt32(Console.ReadLine());

            if (value == 1) {
                Console.WriteLine("Please enter side A length");
                int sideA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter side B length");
                int sideB = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter side C length");
                int sideC = Convert.ToInt32(Console.ReadLine());
                if (Calculators.IsTriangleRightAngled(sideA, sideB, sideC))
                {
                    Console.WriteLine("Triangle with such side lengths is right-triangle");
                }
                else {
                    Console.WriteLine("Triangle with such side lengths is not right-triangle");
                }
            } else if (value == 2) {
                Console.WriteLine("Please enter radius of first circle");
                double radius1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter radius of second circle");
                double radius2 = Convert.ToDouble(Console.ReadLine());

                CircleArea.CalculateBigger(radius1, radius2);
            } else if (value == 3) {
                Console.WriteLine("Please enter circle radius");
                double radius = Convert.ToDouble(Console.ReadLine());
                CircleRadius.Calculate(radius);
            } else if (value == 4) {
                Console.WriteLine("Please enter number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (Calculators.IsNumberEven(number))
                {
                    Console.WriteLine("This number is even");
                }
                else {
                    Console.WriteLine("This number is odd");
                }
            }

            Console.WriteLine("It was nice to work with you. Goodbye!");
            Console.ReadKey();
        }
    }
}
