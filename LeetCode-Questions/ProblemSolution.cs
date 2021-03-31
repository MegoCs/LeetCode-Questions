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
            var input = (string)inputObj;

            //Convert result object to problem output type
            var expectedResult = (string)expectedObj;

            var result = SimplifyPath(input);

            return result.Equals(expectedResult);
        }

        public string SimplifyPath(string path)
        {
            var tokens = path.Split(@"/");
            var validTokens = new Stack<string>();
            foreach (var token in tokens)
            {
                if (token == "" || token == ".")
                    continue;
                else if (!string.IsNullOrEmpty(token) && validTokens.Count>0&& token == "..")
                    validTokens.Pop();
                else if (token != "..")
                    validTokens.Push(token);
            }
            return "/" +string.Join("/", validTokens.Reverse());
        }
    }
}