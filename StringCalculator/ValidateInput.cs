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

        public string RemoveTrailingCommas(string input)
        {
            return input.TrimEnd(',');
        }
    }

    
}
