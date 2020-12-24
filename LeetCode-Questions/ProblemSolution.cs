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
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    var rev = new string(words[i].Reverse().ToArray());
                    result.Append(rev+" "); 
                }
            }
            if(result.Length>0)
            result=result.Remove(result.Length-1, 1);
            return result.ToString();
        }
    }
}