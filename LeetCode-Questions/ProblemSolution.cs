using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Questions
{
    class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (char[])key;

            //Convert result object to problem output type
            var expectedResult = (char[])value;
            ReverseString(input);
            return input.SequenceEqual(expectedResult);
        }
        public void ReverseString(char[] s)
        {
            for (int i = 0,j= s.Length-1; i < s.Length/2; i++,j--)
            {
                var temp=s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }
    }
}
