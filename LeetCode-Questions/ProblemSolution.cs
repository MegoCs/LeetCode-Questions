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
            var input = (int)key;

            //Convert result object to problem output type
            var expectedResult = (List<List<int>>)value;

            var result = Generate(input);

            int i = 0;
            foreach (var item in result)
                if (!item.SequenceEqual(expectedResult[i++]))
                    return false;

            return true;
        }
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                result.Add(new List<int>());
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        result[i].Add(1);
                    else
                        result[i].Add(result[i - 1][j - 1] + result[i - 1][j]);
                }
            }
            return result;
        }
    }
}
