using System;

/// <summary>Represents a Vector Operations class</summary>
class VectorMath
{
    /// <summary>Adds two vectors <paramref name="vector1"/> <paramref name="vector2"/>that can be 2D or 3D.</summary>
    /// <returns>The sum of both vectors</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] result = new double[vector1.Length];

        if ((vector1.Length == 2 && vector2.Length == 2) || (vector1.Length == 3 && vector2.Length == 3))
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = vector1[i] + vector2[i];
            }
            return result;
        }
        else
        {
            double[] error = {-1};
            return error;
        }
    }
}