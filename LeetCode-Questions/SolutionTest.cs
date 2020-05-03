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
                new int[][]
                {
                    new int[] { 2, 3, 4},
                    new int[] { 5, 6, 7 },
                    new int[] { 8, 9, 10 },
                    new int[] { 11, 12, 13 }
                }, 
                new int []{2,3,5,8,6,4,7,9,11,12,10,13 }
            }
        };
    }
}