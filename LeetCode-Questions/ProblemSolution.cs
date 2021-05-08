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
            var expectedResult = (int)expectedObj;

            var result = solutionB(input);

            return result.Equals(expectedResult);
        }

        public int solutionB(int[] A)
        {
            if (A.Length == 1) return 1;
            int even = A[0], odd = A[1];
            int start = 0, max_len = 0;
            for (int i = 2; i < A.Length; ++i)
            {
                if (i % 2 == 0 && A[i] != even || i % 2 == 1 && A[i] != odd)
                {
                    max_len = Math.Max(max_len, i - start);
                    start = i - 1;
                    if (i % 2 == 0)
                    {
                        even = A[i];
                        odd = A[i - 1];
                    }
                    else
                    {
                        even = A[i - 1];
                        odd = A[i];
                    }
                }
            }
            return Math.Max(max_len, A.Length - start);
        }
    }
}