using System;
using System.Linq;

namespace TDD
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            var splitNumbers = numbers
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            return splitNumbers.Sum();
        }
    }
}
