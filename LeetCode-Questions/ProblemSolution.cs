using System;

namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object inputObj, object expectedObj)
        {
            //Convert Object to problem real type
            var input = (Tuple<int, string>)inputObj;

            //Convert result object to problem output type
            var expectedResult = (int)expectedObj;

            var result = CountingValleys(input.Item1, input.Item2);

            return result.Equals(expectedResult);
        }

        public int CountingValleys(int steps, string path)
        {
            int seaLevel = 0, result = 0;
            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    seaLevel += 1;
                    if (seaLevel == 0)
                        result++;
                }
                else if (path[i] == 'D')
                {
                    seaLevel -= 1;
                }
            }
            return result;
        }

    }
}