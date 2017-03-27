using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson08
{
    class StringOperations
    {
        public void StringOps() {
            string strOriginal = "These functions will come handy";
            string strModified = String.Empty;

            foreach (char c in strOriginal)
            {
                Console.Write(c.ToString() + ' ');
            }

            char[] delim = { ' ', 'l'};
            string[] strArr = strOriginal.Split(delim);
            foreach (string s in strArr)
            {
                Console.WriteLine(s);
            }

            // only starting position specified
            strModified = strOriginal.Substring(25);

            // starting position and length of string to be extracted specified
            strModified = strOriginal.Substring(20, 3);

            char[] inputarray = strOriginal.ToCharArray();
            Array.Reverse(inputarray);
            strModified = new string(inputarray);

            Console.WriteLine(strModified);

            if ((string.Compare(strOriginal, strModified, false)) < 0)
            {
                Console.WriteLine("strOriginal is less than strOriginal1");
            }
            else if ((string.Compare(strOriginal, strModified, false)) > 0)
            {
                Console.WriteLine("strOriginal is more than strOriginal1");
            }
            else if ((string.Compare(strOriginal, strModified, false)) == 0)
            {
                Console.WriteLine("Both strings are equal");
            }

            char[] chArr = strOriginal.ToCharArray();

            strModified = new String(chArr);

            Console.ReadKey();

            bool check = String.IsNullOrEmpty(strOriginal);

            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            // Lower Case
            Console.WriteLine(textInfo.ToLower(strOriginal));
            // Upper Case
            Console.WriteLine(textInfo.ToUpper(strOriginal));
            // Proper Case
            Console.WriteLine(textInfo.ToTitleCase(strOriginal));



            // Using IndexOf
            int strt = 0;
            int cnt = -1;
            int idx = -1;
            strOriginal = "She sells sea shells on the sea shore";
            string srchString = "sea";
            while (strt != -1)
            {
                strt = strOriginal.IndexOf(srchString, idx + 1);
                cnt += 1;
                idx = strt;
            }
            //MessageBox.Show(srchString + " occurs " + cnt + " times");


            strModified = strOriginal.Insert(26, "very ");
            //MessageBox.Show(strModified);


            strModified = strOriginal.Replace("come handy", "be useful");
            //MessageBox.Show(strModified);

        }
    }
}
