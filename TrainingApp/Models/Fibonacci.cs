using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingApp.Models
{
    public static class Fibonacci
    {
        // Method implements the generating limited Fibonacci values
        public static IEnumerable<int> GetFibonacciNumbers(int upperLimit)
        {
            if (upperLimit <= 0)
            {
                throw new ArgumentException("Upper limit must be a positive number bigger than zero");
            }
            var zeroElement = 0;
            yield return zeroElement;
            if (upperLimit == 1)
            {
                yield break;
            }
            var firstElement = 1;
            yield return firstElement;
            if (upperLimit == 2)
            {
                yield break;
            }
            for (var i = 0; i < upperLimit - 2; i++)
            {
                var currentValue = checked(zeroElement + firstElement);
                yield return currentValue;
                zeroElement = firstElement;
                firstElement = currentValue;
            }
        }

        public static string ToString(IEnumerable<int> sequence)
        {
            var sequenceStringBuilder = new StringBuilder();
            foreach (var sequenceMember in sequence)
            {
                sequenceStringBuilder.Append(sequenceMember.ToString());
                sequenceStringBuilder.Append("; ");
            }
            sequenceStringBuilder.Remove(sequenceStringBuilder.Length - 2, 2);
            return sequenceStringBuilder.ToString();
        }
    }
}