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
                5,
                new List<List<int>>(){
                    new List<int>{1 },
                    new List<int>{1,1 },
                    new List<int>{1,2,1 },
                    new List<int>{1,3,3,1 },
                    new List<int>{1,4,6,4,1 }                  
               }
            }
        };
    }
}