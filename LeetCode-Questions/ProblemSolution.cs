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

            //var result = 
                DuplicateZeros(input);

            return true;//result.SequenceEqual(expectedResult);
        }

        public void DuplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = arr.Length-1; j > i+1; j--)
                    {
                        arr[j] = arr[j-1];
                    }
                    arr[i++ + 1] = 0;
                }
            }
        }
    }
}