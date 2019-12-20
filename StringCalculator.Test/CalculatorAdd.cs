using System;
using Xunit;

namespace StringCalculator.Test
{
    public class CalculatorAdd
    {
        public Calculator calculator { get; set; } = new Calculator(new ValidateInput());

        [Theory]
        [InlineData("", 0, ',')]
        [InlineData("1", 1, ',')]
        [InlineData("2", 2, ',')]
        [InlineData("33", 33, ',')]
        [InlineData("1,2", 3, ',')]
        [InlineData("3,4,5", 12, ',')]
        [InlineData("3,4,5,", 12, ',')]
        public void ReturnsCorrectOutput(string input, int output, char seperator)
        {
            //  Act
            var result = calculator.Add(input, seperator);

            //  Assert
            Assert.Equal(output, result);
        }
    }
}
