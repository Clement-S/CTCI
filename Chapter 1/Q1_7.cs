using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class Q1_7
    {
        public void FindZeroAndReplaceRowAndColumn(int[,] matrix, int M, int N)
        {
            // This is a basic implementation that finds the first zero. 
            // Will need to loop to handle more than first occurence, and store the noted rows and column in arrays
            int rowWithZero = 0, columnWithZero = 0;

            // find location of zero in matrix
            for (var i = 0; i < M; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        rowWithZero = i;
                        columnWithZero = j;
                        break;
                    }

                }
            }

            // Now replace values in the matrix using the row and column details
            // first replace entire row with zeros
            for (var ii = 0; ii < N; ii++)
            {
                matrix[rowWithZero, ii] = 0;
            }

            // then replace entire column with zeros for each row
            for (var jj = 0; jj < M; jj++)
            {
                matrix[jj, columnWithZero] = 0;
            }

            OutputMatrix(matrix, M, N);
        }

        public void OutputMatrix(int[,] matrix, int M, int N)
        {
            for (var i = 0; i < M; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j]);

                    if (j < N - 1)
                        Console.Write(",");
                }
                Console.WriteLine();
            }
        }
    }
}
