using System.Collections.Generic;
using System.Linq;
namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (int[])key;

            //Convert result object to problem output type
            var expectedResult = (int)value;

            var result = SingleNumber(input);

            return result.Equals(expectedResult);
        }
        public int SingleNumber(int[] nums)
        {
            SortedSet<int> set = new SortedSet<int>();
            foreach (var num in nums)
            {
                if (set.Contains(num))
                    set.Remove(num);
                else
                    set.Add(num);
            }
            return set.First();
        }
    }
}
