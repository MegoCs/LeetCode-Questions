using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Questions
{
    class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (Tuple<int[],int>)key;

            //Convert result object to problem output type
            var expectedResult = (int[])value;

            var result = TwoSum(input.Item1,input.Item2);

            return result .SequenceEqual( expectedResult);
        }
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0, j = numbers.Length - 1;
            int sum = numbers[i] + numbers[j];
            while (sum != target)
            {
                if (sum < target)
                    i++;
                else
                    j--;
                sum = numbers[i] + numbers[j];
            }
                    return new int[] { i + 1, j + 1 };

        }
    }
}
