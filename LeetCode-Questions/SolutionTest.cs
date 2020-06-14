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
                Tuple.Create(4,new int [] {1,4,4}),1
            },
            {
                Tuple.Create(7,new int [] {2,3,1,2,4,3}),2
            },
            {
                Tuple.Create(10,new int [] {10,0,5,4,1,11,}),1
            }
        };
    }
}