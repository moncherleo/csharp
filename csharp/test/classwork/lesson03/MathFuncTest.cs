using csharp.main.classwork.lesson03;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.classwork.lesson03
{
    class MathFuncTest
    {
        MathFunc mathFunc;

        [OneTimeSetUp]
        public void OneTimeSetUp() {
            mathFunc = new MathFunc();
        }

        static object[][] multiplyData = {
        new object[] { 12, 3, 4, true },
        new object[] { 12, 2, 6, true },
        new object[] { 12, 2, 5, false },
        };

        static object[][] divisionData = {
        new object[] { 12, 3, 4 },
        new object[] { 10, 4, 2.5 }
        };

        static object[][] additionData = {
        new object[] { 12, 12, 24 },
        new object[] { -2, 4, 2 }
        };

        static object[][] substractionData = {
        new object[] { 12, 12, 0 },
        new object[] { -2, -4, 2 }
        };

        [Test, TestCaseSource("multiplyData")]
        public void MultiplyTest(int a, int b, int expRes, bool booleanResult) {
            Assert.AreEqual(booleanResult, expRes == mathFunc.Multiply(a, b));
        }

        [Test, TestCaseSource("divisionData")]
        [Ignore("I would not to run this test because of")]
        public void DivisionTest(int a, int b, double expRes)
        {
            Assert.AreEqual(expRes, mathFunc.Division(a, b));
        }

        [Test, TestCaseSource("additionData")]
        public void AdditionTest(int a, int b, int expRes)
        {
            Assert.AreEqual(expRes, mathFunc.Addition(a, b));
        }

        [Test, TestCaseSource("substractionData")]
        public void SubstractionTest(int a, int b, int expRes)
        {
            Assert.AreEqual(expRes, mathFunc.Substraction(a, b));
        }
    }
}
