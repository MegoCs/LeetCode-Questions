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
                new char [] {'h','e','l','l','o'},new char [] {'o','l','l','e','h'}
            },
            {
                new char [] {'H','a','n','n','a','h'},new char [] { 'h', 'a', 'n', 'n', 'a', 'H' }
            }
        };
    }
}