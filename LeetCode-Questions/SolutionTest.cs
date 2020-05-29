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
                new string [] {"dog","racecar","car"},""
            },
            {
                new string [] {"flower","0low","flight"},""
            },
            {
                new string [] {"1",""},""
            },
            {
                new string [] {""},""
            },
            {
                new string [] {"",""},""
            }
        };
    }
}