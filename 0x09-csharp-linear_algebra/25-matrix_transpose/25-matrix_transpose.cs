using System;

/// <summary>Represents a matrix operations class</summary>
class MatrixMath
{
    /// <summary>transpose a matrix <paramref name="matrix"/></summary>
    /// <returns>The resulting matrix</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[j, i] = matrix[i, j];
            }   
        }
        return result;
    }
}