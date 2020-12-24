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
            var input = (int)inputObj;

            //Convert result object to problem output type
            var expectedResult = (IList<int>)expectedObj;

            var result = GetRow(input);

            return result.SequenceEqual(expectedResult);
        }
        public IList<int> GetRow(int rowIndex)
        {
            List<List<int>> pascalTriangle = new List<List<int>>();
            pascalTriangle.Add(new List<int>() { 1 });
            pascalTriangle.Add(new List<int>() { 1, 1 });

            for (int i = 2; i <= rowIndex; i++)
            {
                pascalTriangle.Add(new List<int>
                {
                    1
                });
                for (int j = 1; j < i; j++)
                {
                    pascalTriangle[i].Add(pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j]);
                }
                pascalTriangle[i].Add(1);
            }
            return pascalTriangle[rowIndex];
        }
    }
}