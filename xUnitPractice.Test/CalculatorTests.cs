using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace xUnitPractice.Test
{
    public class CalculatorTests
    {
        //告訴編譯器要執行的測試方法
        [Fact]
        public void Correct1()
        {
            // Arrange
            double expected = 20;

            // Act
            var actual = Calculator.Add(5, 15);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct2()
        {
            // Arrange
            double expected = 20;

            // Act
            var actual = Calculator.Add(7, 13);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Correct3()
        {
            // Arrange
            double expected = 10;

            // Act
            var actual = Calculator.Add(15, -5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Correct4()
        {
            // Arrange
            double expected = 0;

            // Act
            var actual = Calculator.Add(-5, 5);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Correct5()
        {
            // Arrange
            double expected = -10;

            // Act
            var actual = Calculator.Add(-15, 5);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}