using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(10, 7, 1, 18)]
        [InlineData(2, 4, 1, 7)]
        [InlineData(1, -1, 2, 2)]
        [InlineData(0, 0, 0, 0)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            // Arrange
            var test = new UnitTestMethods();

            // Act
            var actual = test.Add(num1, num2, num3);

            // Assert
            Assert.Equal(expected, actual);          
        }


        [Theory]
        [InlineData(10, 7, 3)]
        [InlineData(2, 1, 1)]
        [InlineData(3, 6, -3)]
        [InlineData(0, 0, 0)]

        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(1, 0, 0)]
        [InlineData(3, -1, -3)]
        [InlineData(0, 0, 0)]

        public void Multiply(int factor1, int factor2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(factor1, factor2);
            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(10, 5, 2)]
        [InlineData(5, 2, 2)]
        [InlineData(1, 1, 1)]
        public void Divide(int dividend, int divisor, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(dividend, divisor);
            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void VerifyName()
        {
            //arrange  
            var test = new UnitTestMethods();

            //act   
            var actual = test.LastName();

            //assert   
            Assert.Equal("Jones", actual);
        }

        [Fact]
        public void VerifyLastFourSSN()
        {
            //arrange
            var database = new UnitTestMethods();
            //act
            var actual = database.LastFourSSN();
            //assert
            Assert.Equal(9558, actual);
        }
    }
}
