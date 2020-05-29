using System;
using System.Linq;

namespace LeetCode_Questions
{
    class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (Tuple<string, string>)key;

            //Convert result object to problem output type
            var expectedResult = (string)value;

            var result = AddBinary(input.Item1, input.Item2);

            return result == expectedResult;
        }
        public string AddBinary(string a, string b)
        {
            string result = string.Empty;
            var aArr = a.ToCharArray();
            var bArr = b.ToCharArray();
            Array.Reverse(aArr);
            Array.Reverse(bArr);
            b = new string(bArr);
            a = new string(aArr);
            
            int cary = 0;
            for (int i = 0; i <a.Length||i<b.Length; i++)
            {
                var aDigit = a.Length > i ? int.Parse(a[i].ToString()) : 0;
                var bDigit = b.Length > i ? int.Parse(b[i].ToString()) : 0;

                int sum = aDigit + bDigit + cary;
                cary = sum / 2;

                result += (sum % 2).ToString();
            }
            if (cary == 1)
                result += "1";

             var resArr = result.ToCharArray();
            Array.Reverse(resArr);
            return new string(resArr);
        }
    }
}
