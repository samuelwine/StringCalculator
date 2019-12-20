using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StringCalculator.Test
{
    public class ValidateInputEmptyStringInput
    {
        public ValidateInput inputValidator { get; set; } = new ValidateInput();

        [Theory]
        [InlineData("", true)]
        [InlineData(null, true)]
        [InlineData("0", false)]
        public void ReturnsTrueForEmptyOrNullString(string input, bool output)
        {
            //  Act
            var result = inputValidator.EmptyStringInput(input);

            //  Assert
            Assert.Equal(output, result);
        }
    }
}
