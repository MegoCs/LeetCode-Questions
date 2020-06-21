using System.Collections.Generic;

namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (int[])key;

            //Convert result object to problem output type
            var expectedResult = (bool)value;

            var result = ContainsDuplicate(input);

            return result.Equals(expectedResult);
        }
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums)
            {
                if (set.Contains(num))
                    return true;
                set.Add(num);
            }
            return false;
        }
    }
}
