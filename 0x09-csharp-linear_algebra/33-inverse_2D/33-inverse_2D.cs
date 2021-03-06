﻿using System;

class MatrixMath
{
    /// <summary>Inverse a 2D matrix <paramref name="matrix"/></summary>
	/// <returns>The new matrix</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        double determinant;

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};

        determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (determinant == 0)
            return new double[,] {{-1}};

        result[0, 0] = Math.Round((1 / determinant) * matrix[1, 1], 2);
        result[0, 1] = Math.Round((1 / determinant) * matrix[0, 1] * -1, 2);
        result[1, 0] = Math.Round((1 / determinant) * matrix[1, 0] * -1, 2);
        result[1, 1] = Math.Round((1 / determinant) * matrix[0, 0], 2);

        return result;
    }
}
