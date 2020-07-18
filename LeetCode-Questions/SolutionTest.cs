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
                Tuple.Create(new int [] {3,3},6),new int []{0,1}
            }
        };
    }
}