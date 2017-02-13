using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson04
{
    class Calculators
    {
        public static bool IsTriangleRightAngled(int sideA, int sideB, int sideC)
        {
            bool isRightAngled = false;

            if ((sideA * sideB * sideC) != 0)
            {
                if (sideA * sideA + sideB * sideB == sideC * sideC || sideA * sideA + sideC * sideC == sideB * sideB || sideB * sideB + sideC * sideC == sideA * sideA)
                {
                    isRightAngled = true;
                }
            }

            return isRightAngled;
        }

        public static bool IsNumberEven(int number)
        {
            bool isEven = false;

            int castedHalf = (int)number / 2;
            if (castedHalf * 2 == number)
            {
                isEven = true;
            }

            return isEven;
        }

        public static double WhatNumberIsBigger(int numberA, int numberB)
        {
            if (numberA > numberB)
            {
                return numberA;
            }
            else if (numberA < numberB)
            {
                return numberB;
            }

            return 0;

        }
    }
}
