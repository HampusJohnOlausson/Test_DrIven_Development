using System;
using System.Linq;

namespace TDD
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            var splitNumbers = numbers.Split(new[]{','}, StringSplitOptions.RemoveEmptyEntries);

            if(splitNumbers.Length == 1)
            {
                if(!splitNumbers.Any())
                {
                    return 0;
                }

                if(splitNumbers.Length == 1)
                {
                    return int.Parse(splitNumbers[0]);
                }
            }

            return int.Parse(splitNumbers[0]) + int.Parse(splitNumbers[1]);
        }
    }
}
