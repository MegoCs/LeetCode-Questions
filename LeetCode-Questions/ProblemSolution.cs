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
            var expectedResult = (int)value;

            var result = RemoveElement(input.Item1,input.Item2);

            return result.Equals( expectedResult);
        }
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int k = 0;
            for (; i < nums.Length; i++)
            {
                if (nums[i]!=val)
                    nums[k++] = nums[i];
            }
            return k;
        }
    }
}
