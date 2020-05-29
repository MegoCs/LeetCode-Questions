using System;
using System.Collections.Generic;

namespace LeetCode_Questions
{
    public static class SolutionTest
    {

        public static List<bool> Run()
        {
            var results = new List<bool>();
            ProblemSolution problem = new ProblemSolution();
            foreach (var item in Inputs)
                results.Add(problem.ValidateSolutionAgainst(item.Key, item.Value));
            return results;
        }

        private static Dictionary<object, object> Inputs = new Dictionary<object, object>()
        {
            {
                Tuple.Create("1010","1011"),"10101"
            },
            {
                Tuple.Create("11","1"),"100"
            },
            {
                Tuple.Create("1","111"),"1000"
            }
        };
    }
}