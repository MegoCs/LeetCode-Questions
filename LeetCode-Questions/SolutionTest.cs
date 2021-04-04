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
                Tuple.Create(8,new List<string>(){ 
                "8 1",
                "5 8",
                "7 3",
                "8 6"
                })
            ,
            6
        },
    };

#region PostSection

    }
} 
#endregion