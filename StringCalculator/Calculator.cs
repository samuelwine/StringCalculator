using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    public class Calculator
    {
        private readonly IValidateInput _validateInput;

        public Calculator(IValidateInput validateInput)
        {
            _validateInput = validateInput;
        }

        public int Add(string numbers, string seperator)
        {           
            if (_validateInput.EmptyStringInput(numbers)) return 0;

            if (!numbers.Contains(seperator)) return Int32.Parse(numbers);

            var trimmedNumbers = _validateInput.RemoveTrailingSeperator(numbers, seperator);

            var stringArray = trimmedNumbers.Split(seperator);
            var intArray = ConvertStringArrayToIntArray(stringArray);

            int total = 0;
            foreach (var integer in intArray)
            {
                total += integer;
            }
            return total;            
        }

        public int[] ConvertStringArrayToIntArray(string[] stringArray)
        {
            var intArray = Array.ConvertAll(stringArray, Int32.Parse);

            return intArray;
        }         
    }
}
