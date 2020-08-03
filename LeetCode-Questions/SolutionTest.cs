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
                Tuple.Create(new int []{1,2,3,1},3),true
            },
            {
                Tuple.Create(new int []{1,0,1,1},1),true
            },
            {
                Tuple.Create(new int []{1,2,3,1,2,3},2),false
            }
        };
    }
}