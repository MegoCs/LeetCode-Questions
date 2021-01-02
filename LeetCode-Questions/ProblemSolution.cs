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
            var expectedResult = (bool)expectedObj;

            var result = ValidMountainArray(input);

            return result.Equals(expectedResult);
        }

        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
                return false;
            int i = 0;
            while (i + 1 < arr.Length&&arr[i] < arr[i+1] )
                i++;
            if (i == arr.Length - 1 || i == 0)
                return false;
            while (i + 1 < arr.Length&&arr[i] > arr[i + 1])
                i++;
            return i == arr.Length-1;
        }
    }
}