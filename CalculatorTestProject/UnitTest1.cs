using System;
using Xunit;
using NewCalculator;

namespace CalculatorTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double result = 12;
            double num1 = 10;
            double num2 = 2;
            string operatian = "a";
            Assert.Equal(result, Calculator.DoOperation(num1, num2, operatian));
        }
    }
}
