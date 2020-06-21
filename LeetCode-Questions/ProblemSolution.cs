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

            var result = Intersection(input.Item1, input.Item2);

            return result.SequenceEqual(expectedResult);
        }
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>();

            HashSet<int> intersectionSet = new HashSet<int>();

            for (int i = 0; i < nums1.Length; i++)
                set1.Add(nums1[i]);
            for (int i = 0; i < nums2.Length; i++)
                if (set1.Contains(nums2[i]))
                    intersectionSet.Add(nums2[i]);
            return intersectionSet.ToArray();
        }
    }
}