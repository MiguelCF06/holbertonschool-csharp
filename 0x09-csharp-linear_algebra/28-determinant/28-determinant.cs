﻿using System;

class MatrixMath
{
	/// <summary>Finds the determinant of a 2D or 3D matrix <paramref name="matrix" /></summary>
	/// <returns>The determinant of the matrix</returns>
    public static double Determinant(double[,] matrix)
	{
		double determinant = 0;

		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
		{
			determinant = Math.Round(
				(matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
		}
		else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			determinant = Math.Round(
				matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[1, 2])) -
				matrix[0, 1] * ((matrix[0, 1] * matrix[2, 2]) - (matrix[2, 1] * matrix[0, 2])) +
				matrix[0, 2] * ((matrix[0, 1] * matrix[1, 2]) - (matrix[1, 1] * matrix[0, 2])), 2);
		}
		else
		{
			return (-1);
		}
		return (determinant);
	}
}