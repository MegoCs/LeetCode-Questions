using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Questions
{
    class ProblemSolution
    {
        public bool ValidateSolutionAgainst(object key, object value)
        {
            //Convert Object to problem real type
            var input = (int[][])key;
        
            //Convert result object to problem output type
            var expectedResult = (int[])value;

            var result = SpiralOrder(input);

            return result.SequenceEqual(expectedResult);
        }
        IList<int> SpiralOrder(int[][] matrix)
        {
            int rows = matrix.Length;
            if (rows == 0)
                return Array.Empty<int>();
            int columns = matrix[0].Length;
            int cycles = rows > columns ? columns - 1 : rows - 1;
            if (cycles == 0)
                cycles = 1;
            List<int> result = new List<int>();
            for (int cycleIndex = 0; cycleIndex < cycles; cycleIndex++)
            {
                //print first row 
                for (int j = cycleIndex; j <= columns - (cycleIndex + 1); j++)
                    result.Add(matrix[cycleIndex][j]);

                //print last column
                for (int i = cycleIndex + 1; i < rows - cycleIndex; i++)
                    result.Add(matrix[i][columns - 1 - cycleIndex]);

                //print last row 
                for (int j = columns - 1 - cycleIndex - 1; j > cycleIndex && result.Count != rows * columns; j--)
                    result.Add(matrix[rows - 1 - cycleIndex][j]);

                //print first column
                for (int i = rows - 1 - cycleIndex; i > cycleIndex && result.Count != rows * columns; i--)
                    result.Add(matrix[i][cycleIndex]);
            }
            return result;
        }
    }
}
