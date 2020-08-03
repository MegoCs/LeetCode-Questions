using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (Tuple<int[], int>)key;

            //Convert result object to problem output type
            var expectedResult = (bool)value;

            var result = ContainsNearbyDuplicate(input.Item1, input.Item2);

            return result.Equals(expectedResult);
        }
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    if (Math.Abs(map[nums[i]] - i) <= k)
                        return true;
                    else
                        map[nums[i]] = i;
                }
                else
                    map[nums[i]] = i;
            }
            return false;
        }
    }
}