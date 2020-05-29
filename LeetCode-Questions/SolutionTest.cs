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
                Tuple.Create(new int [] {0,1,2,2,3,0,4,2},2),5
            },
            {
                Tuple.Create(new int [] {3,2,2,3},3), 2
            }
        };
    }
}