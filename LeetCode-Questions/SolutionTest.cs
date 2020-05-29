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
                Tuple.Create(new int [] {2,7,11,15},9),new int [] { 1,2}
            },
            {
                Tuple.Create(new int [] {2,7,11,15},22),new int [] { 2,4}
            }
        };
    }
}