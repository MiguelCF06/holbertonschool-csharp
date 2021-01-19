using System;

/// <summary>Represents a Matrix Operations class</summary>
class MatrixMath
{
    /// <summary>Multiplies a matrix <paramref name="matrix1"/> and a matrix <paramref name="matrix2"/>that can be 2D or 3D.</summary>
    /// <returns>The resulting matrix</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int col = 0; col < matrix1.GetLength(1); col++)
                    {
                        result[i, j] += matrix1[i, col] * matrix2[col, j];
                    }
                }            
            }
            return result;
        }
        else
        {
            return new double[,] {{-1}};
        }
    }
}