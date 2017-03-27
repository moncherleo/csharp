using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson09
{
    class FilesAndExceptions
    {
        public int GetNumber(int index)
        {
            int[] arr1 = { 100, 200, 300 };
            if (index < 0 || index > arr1.Length)
            {
                throw new IndexOutOfRangeException("Index " + index + " is not a valid index for number");
            }
            return arr1[index];
        }

        public void FileWriter()
        {
            string path = @"c:\Temp\MyTest.txt";
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("Hello, ");
                sw.WriteLine("Welcome");
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void TxtReader()
        {
            string s = "";
            int a = 0;
            int b = 0;
            string path = @"c:\Temp\MyTest.txt";
            try
            {
                StreamReader sr = File.OpenText(path);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(a / b);
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("This is an file exception message: " + e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("This is an directory exception message: " + e.Message);
            }
            finally
            {
                Console.WriteLine("This is finally block");
                Console.ReadKey();
            }
        }
    }
}
