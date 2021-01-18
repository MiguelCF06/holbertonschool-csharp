using System;

/// <summary>Represents a Matrix Operations class</summary>
class MatrixMath
{
    /// <summary>Adds two matrices <paramref name="matrix1"/> <paramref name="matrix2"/>that can be 2D or 3D.</summary>
    /// <returns>The sum of both matrices</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int m1LenI = matrix1.GetLength(0);
        int m1LenJ = matrix1.GetLength(1);
        int m2LenI = matrix2.GetLength(0);
        int m2LenJ = matrix2.GetLength(1);
        double[,] result = new double[m1LenJ, m1LenJ];

        if ((m1LenI == 2 && m1LenJ == 2 && m2LenI == 2 && m2LenJ == 2) || (m1LenI == 3 && m1LenJ == 3 && m2LenI == 3 && m2LenJ == 3))
        {
            for (int i = 0; i < m1LenJ; i++)
            {
                for (int j = 0; j < m1LenJ; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
        else
        {
            return new double[,] { { -1 } };
        }

    }
}