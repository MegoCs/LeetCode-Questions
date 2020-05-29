using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Questions
{
    class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (string[])key;

            //Convert result object to problem output type
            var expectedResult = (string)value;

            var result = LongestCommonPrefix(input);

            return result == expectedResult;
        }
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            if (strs.Length == 1)
                return strs[0];

            var common = strs[0];
            SortedSet<int> commonPrefixes = new SortedSet<int>();
            for (int i = 1; i < strs.Length; i++)
            {
                int j = 0;
                for (; j < strs[i].Length && j < common.Length; j++)
                    if (common[j] != strs[i][j])
                        break;
                commonPrefixes.Add(j);
                if (j == 0)
                    break;
            }
            return common.Substring(0, commonPrefixes.ElementAt(0));
        }
    }
}
