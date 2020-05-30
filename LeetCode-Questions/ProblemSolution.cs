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

            var result = FindMaxConsecutiveOnes(input);

            return result.Equals( expectedResult);
        }
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            SortedSet<int> maxOcc = new SortedSet<int>();
            var occ = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    occ++;
                else
                {
                    maxOcc.Add(occ);
                    occ = 0;
                }
            }
            maxOcc.Add(occ);
            return maxOcc.Last();
        }
    }
}
