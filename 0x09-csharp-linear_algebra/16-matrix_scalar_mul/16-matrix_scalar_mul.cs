using System;

/// <summary>Represents a Matrix Operations class</summary>
class MatrixMath
{
    /// <summary>Multiplies a matrix <paramref name="matrix1"/> and a scalar <paramref name="matrix2"/>that can be 2D or 3D.</summary>
    /// <returns>The resulting matrix</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if ((matrix.GetLength(0) == 2) || (matrix.GetLength(0) == 3))
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j] * scalar;
                }
            }
            return matrix;
        }
        else
        {
            return new double[,] { { -1 } };
        }
    }
}