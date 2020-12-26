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
            {
                results.Add(problem.ValidateSolutionAgainst(problemInput, problemOutput));
            }

            return results;
        }

        private static readonly Dictionary<object, object> Inputs = new Dictionary<object, object>()
        {
            {
               new int[] {-4,-1,0,3,10},new int[] { 0, 1, 9, 16, 100 }
            }
        };
    }
}