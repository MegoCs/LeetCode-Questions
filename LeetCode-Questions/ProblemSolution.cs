using System;

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

            var result = JumpingOnClouds(input);

            return result.Equals(expectedResult);
        }

        public int JumpingOnClouds(int[] c)
        {
            int steps = 0,current=0;
            for (int i = 1; i < c.Length-1; i++)
            {
                if (c[i] == 0)
                {
                    steps++;
                    if (c[i + 1] == 0 && i + 1 == current + 2)
                    {
                        current = i + 1;
                        i++;
                        if (current == c.Length - 1)
                            steps--;
                    }
                    else
                        current = i;
                }
            }
            return steps+1;
        }

    }
}