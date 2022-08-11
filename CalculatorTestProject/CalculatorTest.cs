using System;
using Xunit;
using NewCalculator;

namespace CalculatorTestProject
{
    public class CalculatorTest
    {
        [Fact]
        public void ShouldDoAdding()
        {
            double result = 12;
            double num1 = 10;
            double num2 = 2;
            string operatian = "a";
            Assert.Equal(result, Calculator.DoOperation(num1, num2, operatian));
        }

        [Fact]
        public void ShouldDoDividing()
        {
            double result = 5;
            double num1 = 10;
            double num2 = 2;
            string operatian = "d";
            Assert.Equal(result, Calculator.DoOperation(num1, num2, operatian));
        }

        [Fact]
        public void ShouldDoMultiplication()
        {
            double result = 20;
            double num1 = 10;
            double num2 = 2;
            string operatian = "m";
            Assert.Equal(result, Calculator.DoOperation(num1, num2, operatian));
        }

        [Fact]
        public void ShouldDoSubstraction()
        {
            double result = 8;
            double num1 = 10;
            double num2 = 2;
            string operatian = "s";
            Assert.Equal(result, Calculator.DoOperation(num1, num2, operatian));
        }

        [Fact]
        public void ShouldDoNothing()
        {
            double result = double.NaN;
            double num1 = 10;
            double num2 = 2;
            string operatian = "";
            Assert.Equal(result, Calculator.DoOperation(num1, num2, operatian));
        }
    }
}
