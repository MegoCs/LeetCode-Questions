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
                new [] {1,4,4},1
            },
            {
                new [] {4,4,0},0
            },
            {
                new [] {1,3,3},3
            }
        };
    }
}