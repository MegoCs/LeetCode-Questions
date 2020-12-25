namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object inputObj, object expectedObj)
        {
            //Convert Object to problem real type
            var input = (int[])inputObj;

            //Convert result object to problem output type
            var expectedResult = (int)expectedObj;

            var result = RemoveDuplicates(input);

            return result.Equals(expectedResult);
        }
        public int RemoveDuplicates(int[] nums)
        {
            int lastUnique=0;
            if (nums.Length == 0)
                return 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    while (i < nums.Length - 1 && nums[i]==nums[i+1])
                    {
                        i++;
                    }
                    nums[++lastUnique] = nums[i];
                }
            }
            return lastUnique+1;
        }
    }
}