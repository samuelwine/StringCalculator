using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StringCalculator.Test
{
    public class ValidateInputRemoveTrailingSeperator
    {
        public ValidateInput inputValidator { get; set; } = new ValidateInput();

        [Theory]
        [InlineData("3,4,5,", "5", ",")]
        [InlineData("4,5,6,,", "6", ",")]
        [InlineData("7,8,9,,,", "9", ",")]
        [InlineData("7\n8\n9\n\n\n", "9", "\n")]
        public void ReturnsStringwithoutTrailingSeperator(string input, string output, string seperator)
        {
            //  Act
            var result = inputValidator.RemoveTrailingSeperator(input, seperator);

            //  Assert
            Assert.EndsWith(output, result);
        }
    }
}
