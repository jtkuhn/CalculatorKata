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
            Assert.AreEqual(calculator.Add("12"), 12);
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

        [Test]
        public void TestNewLineSeparator()
        {
            Assert.AreEqual(5, calculator.Add("1\n4"));
        }

        [TestCase(15, "1\n2\n3\n4\n5")]
        [TestCase(15, "1\n2,3,4\n5")]
        public void TestNewLinesAndCommas(int number, String numberString)
        {
            Assert.AreEqual(number, calculator.Add(numberString));
        }

        [Test]
        public void TestDifferentDelimiter()
        {
            Assert.AreEqual(3, calculator.Add("//;\n1;2"));
        }

        [Test]
        public void TestDifferentDelimiterComplex()
        {
            Assert.AreEqual(15, calculator.Add("//;\n1;2\n3,4;5"));
        }

        [Test]
        public void TestThrowNegativeException()
        {
            var ex = Assert.Throws<Exception>(() => calculator.Add("1,-2"));
            Assert.That(ex.Message, Is.EqualTo("Negatives not allowed"));
        }

        [Test]
        public void TestNumbersTooLarge()
        {
            Assert.AreEqual(2, calculator.Add("1001, 2005, 17884, 23874\n1384,2"));
        }

    }
}
