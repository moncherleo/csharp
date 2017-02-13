using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson02
{
    class PrimitiveConvertor
    {
        public char FloatToChar(float inputFloat) {
            char outputChar = (char)inputFloat;
            return outputChar;
        }

        public char IntToChar(int inputInt)
        {
            char outputChar = (char)inputInt;
            return outputChar;
        }

        public int CharToInt(char inputChar)
        {
            int outputInt = (int)inputChar;
            return outputInt;
        }
    }
}
