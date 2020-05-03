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

            var result = FindDiagonalOrder(input);

            return result.SequenceEqual(expectedResult);
        }
        int[] FindDiagonalOrder(int[][] matrix)
        {
            int rows = matrix.Length;
            if (rows == 0)
                return Array.Empty<int>();
            int columns = matrix[0].Length;
            List<int> result = new List<int>(rows * columns);
            int direction = 0;
            for (int rowDiagonalIndex = 0; rowDiagonalIndex < rows; rowDiagonalIndex++)
            {
                int diagonalLength = (rowDiagonalIndex + 1) < columns ? rowDiagonalIndex + 1 : columns;
                result.AddRange(PrintDiagonalFor(diagonalLength, rowDiagonalIndex, 0, matrix, direction++ % 2 == 0));
            }
            for (int lowerColumnDiagonalIndex = 1; lowerColumnDiagonalIndex < columns; lowerColumnDiagonalIndex++)
            {
                int diagonalLength = columns - lowerColumnDiagonalIndex < rows ? columns - lowerColumnDiagonalIndex : rows;
                result.AddRange(PrintDiagonalFor(diagonalLength, rows - 1, lowerColumnDiagonalIndex, matrix, direction++ % 2 == 0));
            }

            return result.ToArray();
        }
        List<int> PrintDiagonalFor(int lengthOfDiagonal, int statringRowIndex, int startingColumnIndex, int[][] matrix, bool direction = true)
        {
            List<int> diagonal = new List<int>(lengthOfDiagonal)
            {
                matrix[statringRowIndex][startingColumnIndex]
            };
            for (int i = 1; i < lengthOfDiagonal; i++)
                diagonal.Add(matrix[--statringRowIndex][++startingColumnIndex]);

            if (!direction)
                diagonal.Reverse();

            return diagonal;
        }
    }
}
