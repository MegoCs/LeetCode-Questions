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
            var input = (int)inputObj;

            //Convert result object to problem output type
            var expectedResult = (int)expectedObj;

            var result = MySqrt(input);

            return result.Equals(expectedResult);
        }

        public int MySqrt(int x)
        {
            return (int)Math.Sqrt(x);
        }
    }
}