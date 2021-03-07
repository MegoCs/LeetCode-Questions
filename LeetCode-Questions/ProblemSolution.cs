using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object inputObj, object expectedObj)
        {
            //Convert Object to problem real type
            var input = (int)inputObj;

            //Convert result object to problem output type
            var expectedResult = (int)expectedObj;

            var result = Reverse(input);

            return result.Equals(expectedResult);
        }

        public int Reverse(int x)
        {
            try
            {
                while (x % 10 == 0 && x!=0)
                    x /= 10;

                bool neg = x < 0;

                string s = neg ? (x * -1).ToString() : x.ToString();
                var rs = new string(s.Reverse().ToArray());

                return neg ? int.Parse(rs) * -1 : int.Parse(rs);
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}