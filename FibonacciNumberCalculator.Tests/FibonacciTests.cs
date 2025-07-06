using System;
using Xunit;
using FibonacciApp; // <-- Reference to main app

namespace FibonacciApp.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(10, 55)]
        [InlineData(15, 610)]
        public void Fibonacci_ValidInput_ReturnsCorrectResult(int input, int expected)
        {
            int result = FibonacciCalculator.Fibonacci(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Fibonacci_NegativeInput_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => FibonacciCalculator.Fibonacci(-1));
        }

        [Fact]
        public void Fibonacci_LargeInput_DoesNotCrash()
        {
            int result = FibonacciCalculator.Fibonacci(30);
            Assert.Equal(832040, result);
        }
    }
}
