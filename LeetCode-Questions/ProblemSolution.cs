using System;
using System.Collections.Generic;

namespace LeetCode_Questions
{
    internal class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object inputObj, object expectedObj)
        {
            //Convert Object to problem real type
            var input = (Tuple<string,long>)inputObj;

            //Convert result object to problem output type
            var expectedResult = (long)expectedObj;

            var result = repeatedString(input.Item1,input.Item2);

            return result.Equals(expectedResult);
        }

        static long repeatedString(string s, long n)
        {
            List<int> aIndecis= new List<int>();
            for (int i = 0; i < s.Length; i++)
                if (s[i] == 'a')
                    aIndecis.Add(i);

            double count = (n /s.Length)*aIndecis.Count;

            for (int i = 0; i < aIndecis.Count; i++)
            {
                if (aIndecis[i] < n % s.Length)
                    count++;
            }
            return (long)count;
        }


    }
}