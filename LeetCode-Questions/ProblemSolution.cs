using System;
using System.Linq;

namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object inputObj, object expectedObj)
        {
            //Convert Object to problem real type
            var input = (Tuple<int[],int[]>)inputObj;

            //Convert result object to problem output type
            var expectedResult = (int)expectedObj;

            //var result = 
            Merge(new[] { 1, 2, 3, 0, 0, 0 }, 3, new int [] { 2, 5, 6 }, 3);

            return false; //result.Equals(expectedResult);
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = 0, p2 = 0;
            while (p2 < nums2.Length)
            {
                if (nums1[p1] > nums2[p2] || p1-p2 >= m)
                {
                    for (int j = nums1.Length - 1; j > p1; j--)
                    {
                        nums1[j] = nums1[j - 1];
                    }
                    nums1[p1++] = nums2[p2++];
                }
                else
                {
                    p1++;
                }
            }
        }
    }
}