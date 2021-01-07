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

            var result = HeightChecker(input);

            return result.Equals(expectedResult);
        }

        public int HeightChecker(int[] heights)
        {
            var unchanged = (int[])heights.Clone();
            heights = heights.OrderBy(x => x).ToArray();
            int result = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != unchanged[i])
                    result++;
            }
            return result;
        }

    }
}