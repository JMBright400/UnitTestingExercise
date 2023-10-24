using System;
using Xunit;

namespace UnitTestingExercise.Tests
{

    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5 )] //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Subtract(minuend, subtrhend);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 10, 20 )]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Multiply(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(80, 10, 8 )]//Add test data <-------
        public void DivideTest(int dividend, int divisor, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(dividend, divisor);
            Assert.Equal(expected, actual);
        }

    }
}
