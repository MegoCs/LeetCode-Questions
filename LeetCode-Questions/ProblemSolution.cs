using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (Tuple<string, string>)key;

            //Convert result object to problem output type
            var expectedResult = (bool)value;

            var result = IsIsomorphic(input.Item1, input.Item2);

            return result.Equals(expectedResult);
        }
        public bool IsIsomorphic(string s, string t)
        {
            IDictionary<char, char> _charMap = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!_charMap.ContainsKey(s[i]))
                {
                    if (_charMap.Values.Contains(t[i]))
                        return false;
                    _charMap.Add(s[i], t[i]);
                }
                else
                {
                    if (t[i] != _charMap[s[i]])
                        return false;
                }
            }
            return true;
        }
    }
}