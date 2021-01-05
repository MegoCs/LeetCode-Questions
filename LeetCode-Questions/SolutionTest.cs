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
               Tuple.Create(new int []{1, 4, 1, 4, 5, 6},5),1
            },
            {
               Tuple.Create(new int []{1, 4, 1, 4, 5, 6},6),1
            },
            {
               Tuple.Create(new int []{0, 1, 2, 3, 4, 5, 6, 7, 8},6),1
            },
            {
               Tuple.Create(new int []{1, 4, 1},5),0
            },
            {
               Tuple.Create(new int []{8, 8, 8, 8, 7, 7, 7},15),0
            },
            {
               Tuple.Create(new int []{8, -8, 8, 8, 7, 7, -7},-15),0
            },
            {
               Tuple.Create(new int []{3},3),0
            },
            {   
               Tuple.Create(new int []{},0),0
            },
        };
    }
}