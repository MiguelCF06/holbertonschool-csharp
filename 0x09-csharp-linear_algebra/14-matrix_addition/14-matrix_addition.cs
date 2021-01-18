using System;

/// <summary>Represents a Matrix Operations class</summary>
class MatrixMath
{
    /// <summary>Adds two matrices <paramref name="matrix1"/> <paramref name="matrix2"/>that can be 2D or 3D.</summary>
    /// <returns>The sum of both matrices</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int m1Len = matrix1.GetLength(1);
        int m2Len = matrix2.GetLength(1);
        double[,] result = new double[m1Len, m1Len];

        if ((m1Len == 2 && m2Len == 2) || (m1Len == 3 && m2Len == 3))
        {
            for (int i = 0; i < m1Len; i++)
            {
                for (int j = 0; j < m1Len; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
        else
        {
            double[,] error = {{-1}};
            return error;
        }

    }
}