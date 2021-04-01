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
            Tuple.Create("a",(long)1000000000000),(long)1000000000000
        },
        {
            Tuple.Create("aadcdaccacabdaabadadaabacdcbcacabbbadbdadacbdadaccbbadbdcadbdcacacbcacddbcbbbaaccbaddcabaacbcaabbaaa",(long)942885108885),(long)330009788107
        }
    };

#region PostSection

    }
} 
#endregion