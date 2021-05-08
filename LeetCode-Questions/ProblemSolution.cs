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
            int maxsubset = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int andTotal = A[i],subsetLen=1;

                for (int j = i+1; j < A.Length; j++)
                {
                    var restult = andTotal & A[j];
                    if (restult > 0)
                    {
                        andTotal &= A[j];
                        subsetLen++;
                    }
                }
                maxsubset = maxsubset > subsetLen ? maxsubset : subsetLen;
            }
            return maxsubset;
        }
    }
}