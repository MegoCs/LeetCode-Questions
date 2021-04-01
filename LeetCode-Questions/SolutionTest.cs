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
        //{
        //    new int []{ 0,1,0,0,0,1,0},3
        //},
        //{
        //    new int []{ 0,0,0,0,1,0},3
        //},
        //{
        //    new int []{ 0 ,0 ,1 ,0 ,0 ,1 ,0},4
        //},
        {
            new int []{ 0,1,0,0,0,0,0,1,0,1,0,0,0,1,0,0,1,0,1,0,0,0,0,1,0,0,1,0,0,1,0,1,0,1,0,1,0,0,0,1,0,1,0,0,0,1,0,1,0,1,0,0,0,1,0,1,0,0,0,1,0,1,0,0,0,1,0,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,0,1,0,1,0,1,0,1,0,0,0,0,0,0,1,0,0,0},53
        }
    };

#region PostSection

    }
} 
#endregion