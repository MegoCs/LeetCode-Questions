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

            var result = ReplaceElements(input);

            return result.SequenceEqual(expectedResult);
        }
        public int[] ReplaceElements(int[] arr)
        {
            int currentMax = arr[arr.Length - 1];

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] > currentMax)
                {
                    int temp = arr[i];
                    arr[i] = currentMax;
                    currentMax = temp;
                }
                else
                {
                    arr[i] = currentMax;
                }
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }
    }
}