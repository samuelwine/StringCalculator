using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class ValidateInput : IValidateInput
    {
        public bool EmptyStringInput(string input)
        {
            if (String.IsNullOrWhiteSpace(input)) return true;

            return false;
        }

        public string RemoveTrailingSeperator(string input, string seperator)
        {
            return input.TrimEnd(seperator.ToCharArray());
        }
    }

    
}
