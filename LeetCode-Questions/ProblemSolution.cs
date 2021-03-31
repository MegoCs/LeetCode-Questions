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

            var result = RotatedDigits(input);

            return result.Equals(expectedResult);
        }

        public int RotatedDigits(int N)
        {
            int res= 0;
            for (int i = 1; i <= N; i++)
            {
                string s = i.ToString();
                if (s.Contains('3') || s.Contains('4') || s.Contains('7'))
                    continue;
                if (s.Contains('2') || s.Contains('5') || s.Contains('9') || s.Contains('6'))
                    res++;
            }
            return res;
        }
    }
}