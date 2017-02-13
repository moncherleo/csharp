using csharp.main.classwork.lesson03;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.classwork.lesson03
{
    [TestFixture]
    class MathFuncTest
    {
        [Test]
        public void MultiplyTest() {
            int a = 1, b = 2, expRes = 2;
            MathFunc mathFunc = new MathFunc();

            Assert.AreEqual(expRes, mathFunc.Multiply(a, b));
        }

        [Test]
        public void DivisionTest()
        {
            int a = 6, b = 2, expRes = 3;
            MathFunc mathFunc = new MathFunc();

            Assert.AreEqual(expRes, mathFunc.Division(a, b));
        }

        [Test]
        public void AdditionTest()
        {
            int a = -1, b = 2, expRes = 1;
            MathFunc mathFunc = new MathFunc();

            Assert.AreEqual(expRes, mathFunc.Addition(a, b));
        }

        [Test]
        public void SubstractionTest()
        {
            int a = 2, b = -1, expRes = 3;
            MathFunc mathFunc = new MathFunc();

            Assert.AreEqual(expRes, mathFunc.Substraction(a, b));
        }
    }
}
