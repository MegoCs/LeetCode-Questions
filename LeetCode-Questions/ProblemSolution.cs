using System;
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

            //var result = 
                MoveZeroes(input);

            return true;// result.SequenceEqual(expectedResult);
        }
        public void MoveZeroes(int[] nums)
        {
            int nextNonZeroLocation = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nextNonZeroLocation++] = nums[i];
                    if(i!=nextNonZeroLocation-1)
                    nums[i] = 0;
                }
            }
        }
    }
}