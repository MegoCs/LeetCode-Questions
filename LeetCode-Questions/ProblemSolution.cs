using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object inputObj, object expectedObj)
        {
            //Convert Object to problem real type
            var input = (int[])inputObj;

            //Convert result object to problem output type
            var expectedResult = (int[])expectedObj;

            var result = SortedSquares(input);

            return result.SequenceEqual(expectedResult);
        }
        public int[] SortedSquares(int[] nums)
        {
            int r =nums.Length - 1,l=0;
            var result = new int[nums.Length];
            for (int i = nums.Length-1; i >=0; i--)
            {
                var left = nums[l] * nums[l];
                var right = nums[r]* nums[r];
                if (left >= right)
                {
                    result[i]= left;
                    l++;
                }
                else
                {
                    result[i] = right;
                    r--;
                }
            }
            return result;
        }
    }
}