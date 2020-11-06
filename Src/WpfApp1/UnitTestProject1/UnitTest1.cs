using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTest
    {

        [TestMethod]
        public void Add_positive_interger()
        {
            var calculator = new Calculator();
            int first = 1;
            int second = 2;
            var sum = calculator.Add(first, second); 
            
            Assert.AreEqual(3, sum);

        }
    }

    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }
    }
}
