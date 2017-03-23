using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson08
{
    class StringCase
    {
        public static String Stringer() {
            String stringToDisplay = "";
            char[] charArrayToString = { 'a', 'b', 'c', 'd' };

            for (int i = 0; i < charArrayToString.Length; i++)
            {
                stringToDisplay += charArrayToString[i];
            }

            Console.WriteLine(stringToDisplay);
            return stringToDisplay;

        }

        public static void NewStringer() {
            String s1 = "first string";
            String s2 = " and second string";
            s1 += s2;
            Console.WriteLine("Concat string example: " + s1);

            String s3 = "1";
            String s4 = " and 2";
            s3 = String.Concat(s3, s4);
            Console.WriteLine("Another concat string example: " + s3);

        }

        public static void StringComparison() {
            String soldRoomName = "room";
            String newRoomName = "room";
            if (soldRoomName.Equals(newRoomName))
            {
                Console.WriteLine("Names are equal");
            }
            else {
                Console.WriteLine("Names are not equal");
            }
        }

        public static bool IsPalindrome() {
            String palindrome = "momm";
            bool isPalindrome = true;

            for (int i = 0; i < palindrome.Length / 2; i++)
            {
                isPalindrome = isPalindrome && (palindrome[i] == palindrome[palindrome.Length - i - 1]);
            }
            if (isPalindrome) {
                Console.WriteLine("Palindrome");
            }
            else {
                Console.WriteLine("Not palindrome");
            }
            return isPalindrome;
        }
    }
}
