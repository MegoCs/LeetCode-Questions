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
            var input = (Tuple<int[],int>)inputObj;

            //Convert result object to problem output type
            var expectedResult = (int)expectedObj;

            var result = isPairedN(input.Item1, input.Item2);

            return result.Equals(expectedResult);
        }

        public int isPairedN(int[] a, int n) {

            if (a.Length - 1 + a.Length - 2 < n || a.Length<2 || n<=0)
                return 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] + a[j] == n && i + j == n)
                        return 1;
                }
            }
            return 0;
        }

        public int is123Array(int[] a)
        {
            int valid = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i + 2 < a.Length && a[i] == 1 && a[i + 1] == 2 && a[i + 2] == 3)
                {
                    i += 2;
                    valid = 1;
                }
                else
                {
                    return 0;
                }
            }
            return valid;
        }
        public int hasNValues(int[] a, int n)
        {
            HashSet<int> uniqueSet = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (!uniqueSet.Contains(a[i]))
                    uniqueSet.Add(a[i]);
            }
            return uniqueSet.Count == n ? 1 : 0;
        }
    }
}