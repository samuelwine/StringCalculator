using System;
using Xunit;

namespace StringCalculator.Test
{
    public class Calculator_Add
    {
        public Calculator calculator { get; set; } = new Calculator();

        [Fact]
        public void ReturnsZeroForEmptyString()
        {
            //  Arrange
            var input = "";

            //  Act
            var result = calculator.Add(input);

            //  Assert
            Assert.Equal(0, result);
        }
    }
}
