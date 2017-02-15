using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.utils
{
    class TestDataProvider
    {
        private int [][] arrayOfIntArrays;
        private int counterOfArrays = 0;
        private int currentArrayIndex = 0;

        public static int[][] ReadTestData(string fileName)
        {
            int counter = 0;
            int[][] intArray;
            string[] stringArray;
            string line;

            // Read the file and display it line by line
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);

            //Count the lines in file
            while ((line = file.ReadLine()) != null)
            {
                counter++;
            }
            //Define array with qty of lines in file
            stringArray = new string[counter];

            //Read all the lines into array
            counter = 0;
            while ((line = file.ReadLine()) != null)
            {
                stringArray[counter] = line;
                counter++;
            }
            file.Close();

            //Define size of array of int arrays
            intArray = new int[stringArray.Length - 1][];

            //Convert lines to int arrays skipping first line
            for (int i = 1; i < stringArray.Length; i++)
            {
                // Split each line onto values
                string[] splittedString = stringArray[i].Split(',');
                intArray[i - 1] = new int[splittedString.Length];

                //Converting each number in line to int
                for (int j = 0; j < splittedString.Length; j++)
                {
                    intArray[i - 1][j] = Convert.ToInt32(splittedString[j]);
                }
            }
            return intArray;
        }

        public void setArrayOfIntArrays(int[][] arrayOfIntArrays) {
            this.arrayOfIntArrays = arrayOfIntArrays;
            counterOfArrays = arrayOfIntArrays.Length;
        }

        public int[] getNextIntArray() {
            if ((counterOfArrays > 0) && (counterOfArrays < arrayOfIntArrays.Length)) {
                int[] currentArray = arrayOfIntArrays[currentArrayIndex];
                currentArrayIndex++;
                return currentArray;
            }
            return new int[0];
        }
    }
}
