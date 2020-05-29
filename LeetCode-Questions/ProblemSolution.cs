using System;
using System.Linq;

namespace LeetCode_Questions
{
    class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (Tuple<string, string>)key;

            //Convert result object to problem output type
            var expectedResult = (int)value;

            var result = StrStr(input.Item1, input.Item2);

            return result == expectedResult;
        }
        public int StrStr(string haystack, string needle)
        {
            if (string.Empty == needle)
                return 0;
            if (needle.Length > haystack.Length)
                return -1;
            int ni = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[ni])
                {
                    ni++;
                    if (ni == needle.Length)
                        return i + 1 - ni;
                }
                else
                {
                    i -= ni;
                    ni = 0;
                }
            }
            return -1;
        }
    }
}
