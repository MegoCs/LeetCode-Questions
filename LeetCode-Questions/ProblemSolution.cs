using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object inputObj, object expectedObj)
        {
            //Convert Object to problem real type
            var input = (string)inputObj;

            //Convert result object to problem output type
            var expectedResult = (string)expectedObj;

            var result = ReverseWords(input);

            return result.SequenceEqual(expectedResult);
        }
        public string ReverseWords(string s)
        {
            var words = s.Split(" ");
            StringBuilder result = new StringBuilder();
            for (int i = words.Length-1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                    result.Append(words[i] + " ");
            }
            result=result.Remove(result.Length-1, 1);
            return result.ToString();
        }
    }
}