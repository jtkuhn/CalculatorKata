using System;
using NUnit.Framework;
using CalculatorKata;

namespace CalculatorKataTest
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calculator;

        [SetUp]
        public void Init()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(calculator.Add(""), 0);
        }

        [Test]
        public void TestOneNumber()
        {
            Assert.AreEqual(calculator.Add("1"), 1);
        }

        [TestCase(3, "1,2")]
        [TestCase(12, "5,7")]
        [TestCase(317, "237, 80")]
        public void TestTwoNumbers(int number, String numberString)
        {
            Assert.AreEqual(number, calculator.Add(numberString));
        }

        [TestCase(6, "1,2,3")]
        [TestCase(20, "7,5,8")]
        [TestCase(371, "100,250,21")]
        public void TestThreeNumbers(int number, String numberString)
        {
            Assert.AreEqual(number, calculator.Add(numberString));
        }

    }
}
