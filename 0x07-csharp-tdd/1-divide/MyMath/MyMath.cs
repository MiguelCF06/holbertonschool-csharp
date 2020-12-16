using System;

namespace MyMath
{
    /// <summary>Represents the matrix class.</summary>
    public class Matrix
    {
        /// <summary>Divide every element in the matrix and return it inside a new matrix.</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);

            int[,] dividedValues = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    dividedValues[i, j] = matrix[i, j] / num;
                }
            }
            return dividedValues;
        }
    }
}
