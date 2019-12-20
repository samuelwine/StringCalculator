using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StringCalculator.Test
{
    public class ValidateInputRemoveTrailingCommas
    {
        public ValidateInput inputValidator { get; set; } = new ValidateInput();

        [Theory]
        [InlineData("3,4,5,","5")]
        [InlineData("3,4,5,,","5")]
        [InlineData("3,4,5,,,","5")]
        public void AddsZeroForTrailingCommas(string input, string output)
        {
            //  Act
            var result = inputValidator.RemoveTrailingCommas(input);

            //  Assert
            Assert.EndsWith(output, result);
        }
    }
}
