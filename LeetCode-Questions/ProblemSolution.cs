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

            var result = CheckIfExist(input);

            return result.Equals(expectedResult);
        }

        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> mem = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (mem.Contains(arr[i] * 2) || (arr[i]%2==0&&mem.Contains(arr[i] / 2)))
                    return true;
                if (!mem.Contains(arr[i]))
                    mem.Add(arr[i]);
            }
            return false;
        }
    }
}