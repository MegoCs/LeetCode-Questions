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

            var result = FindNumbers(input);

            return result.Equals(expectedResult);
        }
        public int FindNumbers(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].ToString().Length % 2 == 0)
                    result++;
            }
            return result;
        }
    }
}