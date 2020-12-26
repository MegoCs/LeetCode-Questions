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

            var result = SortArrayByParity(input);

            return result.SequenceEqual(expectedResult);
        }
        public int[] SortArrayByParity(int[] A)
        {
            int nextEvenLoc = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] % 2 != 0)
                {
                    nextEvenLoc = i < nextEvenLoc ? i : nextEvenLoc;
                }
                if(A[i]%2==0&& nextEvenLoc!= int.MaxValue)
                {
                    int temp = A[i];
                    A[i] = A[nextEvenLoc];
                    A[nextEvenLoc++] = temp;
                }
            }
            return A;
        }
    }
}