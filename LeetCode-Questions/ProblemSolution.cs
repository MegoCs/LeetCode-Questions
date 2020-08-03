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
            var input = (Tuple<int[], int[]>)key;

            //Convert result object to problem output type
            var expectedResult = (int[])value;

            var result = Intersect(input.Item1, input.Item2);

            return result.SequenceEqual(expectedResult);
        }
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> map1 = new Dictionary<int, int>();
            List<int> result = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                _ = map1.ContainsKey(nums1[i]) ? map1[nums1[i]]++ : map1[nums1[i]] = 1;
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (map1.ContainsKey(nums2[i]) && map1[nums2[i]] > 0)
                {
                    result.Add(nums2[i]);
                    map1[nums2[i]]--;
                }
            }
            return result.ToArray();
        }
    }
}