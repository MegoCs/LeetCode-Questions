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
            var expectedResult = (int[])value;

            var result = TwoSum(input.Item1, input.Item2);

            return result.SequenceEqual(expectedResult);
        }
        public int[] TwoSum(int[] nums, int target)
        {
            IDictionary<int, int> _map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!_map.ContainsKey(nums[i]))
                    _map.Add(nums[i], i);
                if (_map.ContainsKey(target - nums[i]) && _map[target - nums[i]] != i)
                {
                    return new int[] { _map[target - nums[i]], i };
                }
            }
            return new int[] { };
        }
    }
}