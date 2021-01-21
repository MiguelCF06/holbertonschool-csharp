using System;
using System.Collections.Generic;

///<summary>Represents a matrix operations class.</summary>
class MatrixMath
{
    ///<summary>Shear a 2D matrix <paramref name="matrix" /></summary>
    /// <returns>The resulting matrix</returns>
   public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		double[,] failMatrix = { { -1 } };
		double[,] result = new double[2, 2];
		double[,] shear;
		double prod = 0;

		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return new double[,] {{-1}};

		if (direction == 'x')
			shear = new double[,] { { 1, 0 }, { factor, 1 } };
		else if (direction == 'y')
			shear = new double[,] { { 1, factor }, { 0, 1 } };
		else
			return new double[,] {{-1}};

		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				prod = 0;
				for (int k = 0; k < 2; k++)
				{
					prod += matrix[i, k] * shear[k, j];
				}
				result[i, j] = Math.Round(prod, 2);
			}
		}
		return (result);
	}
}