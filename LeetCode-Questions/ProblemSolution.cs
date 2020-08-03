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
            var input = (string)key;

            //Convert result object to problem output type
            var expectedResult = (int)value;

            var result = FirstUniqChar(input);

            return result.Equals(expectedResult);
        }
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                    map[s[i]]++;
                else
                    map[s[i]] = 1;
            }
            foreach (var item in map)
            {
                if(item.Value==1)
                    return s.IndexOf(item.Key); 
            }
            return -1;
        }
    }
}