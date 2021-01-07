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
            {
                results.Add(problem.ValidateSolutionAgainst(problemInput, problemOutput));
            }

            return results;
        }

        private static readonly Dictionary<object, object> Inputs = new Dictionary<object, object>()
        {
            {
               new int []{ 1,1,4,2,1,3},3
            },
            {
               new int []{5,1,2,3,4},5
            },
            {
               new int []{ 1,2,3,4,5},0
            }
        };
    }
}