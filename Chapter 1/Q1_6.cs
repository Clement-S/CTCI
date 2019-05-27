using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class Q1_6
    {
        public int[,] RotateImageMatrix(int[,] matrix, int N)
        {
            var size = N - 1;
            int[,] rotatedMatrix = new int[N, N];
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    rotatedMatrix[j, size] = matrix[i, j];
                }
                size--;
            }
            return rotatedMatrix;
        }

        public void OutputMatrix(int[,] matrix, int N)
        {
            for (var i = 0; i < N; i++)
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
