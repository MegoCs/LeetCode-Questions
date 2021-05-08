#region PreSection
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
#endregion

    private static readonly Dictionary<object, object> Inputs = new Dictionary<object, object>()
    {
        {
                new int [] { 3,2,3,2,3} , 5
        },
        {
                new int [] { 7,4,-2,4,-2,-9} , 4
        },
        {
                new int [] { 7,-5,-5,-5,7,-1,7} , 3
        },
        {
                new int [] { 4} , 1
        },
    };

#region PostSection

    }
} 
#endregion