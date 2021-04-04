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
            var input = (Tuple<int,List<string>>)inputObj;

            //Convert result object to problem output type
            var expectedResult = (int)expectedObj;

            var result = connectedSum(input.Item1,input.Item2);

            return result.Equals(expectedResult);
        }

        public static int connectedSum(int n, List<string> edges)
        {
            Dictionary<int, List<int>> pairs= new Dictionary<int, List<int>>();
            for (int i = 0; i < edges.Count; i++)
            {
                var first = int.Parse(edges[i].Split(' ')[0]);
                var second = int.Parse(edges[i].Split(' ')[1]);
                if (pairs.ContainsKey(first))
                    pairs[first].Add(second);
                else if (pairs.ContainsKey(second))
                    pairs[second].Add(first);
                else
                    pairs.Add(first, new List<int>() { second });
            }
            for (int i = 0; i < pairs.Count; i++)
            {
                if(pairs.Count>i)
                for (int j = i + 1; j < pairs.Count; j++)
                {
                    var elem = pairs.ElementAt(j);
                    if (pairs.ElementAt(i).Value.Contains(elem.Key))
                    {
                        pairs.ElementAt(i).Value.AddRange(elem.Value);
                        pairs.Remove(elem.Key);
                        j--;
                    }   
                }
            }

            var connectedLinks = 0;
            int totalSum=0;
            for (int i = 0; i < pairs.Count; i++)
            {
                connectedLinks += pairs.ElementAt(i).Value.Count+1;
                totalSum += (int)Math.Ceiling((double)Math.Sqrt(pairs.ElementAt(i).Value.Count + 1));
            }
            var unconnected = n - connectedLinks;
            totalSum += unconnected;
            return totalSum;
        }
    }
}