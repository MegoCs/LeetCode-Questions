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
            var input = (string[])key;

            //Convert result object to problem output type
            var expectedResult = (List<List<string>>)value;

            var result = GroupAnagrams(input);

            return result.SequenceEqual(expectedResult);
        }
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var sortedValue = String.Concat(strs[i].OrderBy(c => c));
                if (map.ContainsKey(sortedValue))
                    map[sortedValue].Add(strs[i]);
                else
                    map[sortedValue] = new List<string>() { strs[i] };
            }
            return map.Values.ToList();
        }
    }
}