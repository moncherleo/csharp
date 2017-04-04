using csharp.main.classwork.lesson02;
using csharp.main.classwork.lesson06;
using csharp.main.classwork.lesson08;
using csharp.main.classwork.lesson09;
using csharp.main.classwork.lesson11;
using csharp.main.classwork.lesson12;
using csharp.main.classwork.lesson13;
using csharp.main.menus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static int[] array1 = { 1, 2, 3 };

        static void Main(string[] args)
        {
            IBicycle bicycle1 = new ACMEBicycle();
            bicycle1.changeCadence(1);
            ACMEBicycle acmeBicycle = new ACMEBicycle();
            acmeBicycle.printStates();

            Bicycle bicycle = new Bicycle();
            bicycle.Ride();
            bicycle = new Bicycle(28);
            bicycle.Ride();
            bicycle = new Bicycle(24, "green");
            bicycle.Ride();

            Console.ReadKey();


            Student student = new Student("Egor", "KPI");
            Console.WriteLine(student.GetResponse("What is class?"));
            Teacher teacher = new Teacher("Ivan", "NAU");
            Console.WriteLine(teacher.GetResponse("What time is now?"));
            /* - - - - - - - - - - - - - - - - - - - - - - - */
            Person person = new Student("Ilya", "LNU");
            Console.WriteLine(person.GetResponse("What is class?"));

            person = new Teacher("Evgeniy", "HPI");
            Console.WriteLine(person.GetResponse("What time is now?"));

            /* 
            Pixel pixel = new Pixel(2, 5);
           int[] pixCoords = pixel.GetCoords();
           Console.WriteLine(pixCoords[0] + ", " + pixCoords[1]);

           Student student = new Student("John", "MIT");
           Console.WriteLine(student.GetResponse("WTF?")); 
           Console.ReadKey();
           */

           /* FilesAndExceptions fex = new FilesAndExceptions();
           fex.FileWriter();
           try
            {
                fex.GetNumber(5);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.ReadKey();
            }
            */



            /*
             
            int[,] arr = new int[4, 3];
            if (arr.Rank > 1)
            {
                for (int dim = 0; dim < arr.Rank; dim++)
                    Console.WriteLine("Dim {0}: {1}", dim, arr.GetLength(dim));
            }
            Console.ReadKey();

            Arrays arrays = new Arrays();

            arrays.Multi();
            Console.ReadKey();

            arrays.Jagged();

            //Loopers loopers = new Loopers();
            //loopers.ArrayLooper();

            */

            Console.ReadKey();
        }
    }
}
