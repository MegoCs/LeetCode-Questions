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
            var input = (int[])key;

            //Convert result object to problem output type
            var expectedResult = (int)value;

            var result = ArrayPairSum(input);

            return result == expectedResult;
        }
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int res = 0;
            for (int i = nums.Length-2; i >=0 ; i-=2)
                res += nums[i];
            return res;
        }
    }
}
