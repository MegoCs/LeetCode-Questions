namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object inputObj, object expectedObj)
        {
            //Convert Object to problem real type
            var input = (string)inputObj;

            //Convert result object to problem output type
            var expectedResult = (string)expectedObj;

            var result = MakeGood(input);

            return result.Equals(expectedResult);
        }

        public string MakeGood(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (char.ToLowerInvariant(s[i]) == char.ToLowerInvariant(s[i + 1]) && s[i] != s[i + 1])
                {
                    s=s.Remove(i, 2);
                    i = -1;
                }
            }
            return s;
        }
    }
}