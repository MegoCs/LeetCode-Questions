using System.Collections.Generic;

namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (int)key;

            //Convert result object to problem output type
            var expectedResult = (bool)value;

            var result = IsHappy(input);

            return result.Equals(expectedResult);
        }
        public bool IsHappy(int n)
        {
            HashSet<int> histroySet = new HashSet<int>();

            while (!histroySet.Contains(n) && n != 1)
            {
                histroySet.Add(n);
                int newN = 0;
                while (n != 0)
                {
                    var digit = n % 10;
                    var square = digit * digit;
                    newN += square;
                    n /= 10;
                }
                n = newN;
            }
            return n == 1;
        }
    }
}