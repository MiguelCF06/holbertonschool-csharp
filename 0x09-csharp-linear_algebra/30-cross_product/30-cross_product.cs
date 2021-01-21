using System;


class VectorMath
{
    /// <summary>Finds the cross product of a 3D vector <paramref name="vector1" /> by another 3D vector <paramref name="vector2"/></summary>
	/// <returns>The new vector</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] result = new double[vector1.Length];

        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[] {-1};

        result[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        result[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        result[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return result;
    }
}