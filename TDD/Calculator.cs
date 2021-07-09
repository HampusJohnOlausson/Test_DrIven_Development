using System;
using System.Collections.Generic;
using System.Linq;

namespace TDD
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            var delimiters = new List<char>{',', '\n'};

            if (numbers.StartsWith("//"))
            {
                var splitOnFirstNewLine = numbers.Split(new[] { '\n' }, count: 2);
                var customDelimiter = splitOnFirstNewLine[0].Replace(oldValue: "//", newValue: string.Empty).Single();
                delimiters.Add(customDelimiter);
                numbers = splitOnFirstNewLine[1];
            }

            var splitNumbers = numbers
                .Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            return splitNumbers.Sum();
        }
    }
}
