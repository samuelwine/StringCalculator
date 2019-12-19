using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (String.IsNullOrWhiteSpace(numbers)) return 0;

            var stringArray = numbers.Split(",");
            var intArray = Convert(stringArray);
            int total = 0;
            foreach (var integer in intArray)
            {
                total += integer;
            }
            return total;            
        }

        public int[] Convert(string[] stringArray)
        {
            int[] intArray = new int[] { };           

            stringArray.CopyTo(intArray, 0);

            return intArray;
        }
    }
}
