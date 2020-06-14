using System;
using System.Collections.Generic;

namespace LeetCode_Questions
{
    class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (Tuple<int, int[]>)key;

            //Convert result object to problem output type
            var expectedResult = (int)value;

            var result = MinSubArrayLen(input.Item1, input.Item2);

            return result.Equals(expectedResult);
        }
        public int MinSubArrayLen(int s, int[] nums)
        {
            int minAnswer = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = nums[i];

                if (sum >= s)
                {
                    minAnswer = minAnswer > 1 ? 1 : minAnswer;
                    break;
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum < s) continue;
                    minAnswer = minAnswer > (j - i + 1) ? (j - i + 1) : minAnswer;;
                    break;

                }
            }
            return minAnswer != int.MaxValue ? minAnswer : 0;
        }
    }
}
