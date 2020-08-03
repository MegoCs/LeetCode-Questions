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
            foreach (var (problemInput, problemOutput) in Inputs)
                results.Add(problem.ValidateSolutionAgainst(problemInput, problemOutput));
            return results;
        }

        private static readonly Dictionary<object, object> Inputs = new Dictionary<object, object>()
        {
            {
                Tuple.Create(new int []{1,2,2,1},new int []{2,2}),new int []{2,2}
            },
            {
                Tuple.Create(new int []{4,9,5},new int []{9,4,9,8,4}),new int []{9,4}
            }
        };
    }
}