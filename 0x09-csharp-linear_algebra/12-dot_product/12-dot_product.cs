using System;

/// <summary>Represents a Vector Operations class</summary>
class VectorMath
{
    /// <summary>Find the dot product of two vectors <paramref name="vector1"/> <paramref name="vector2"/>that can be 2D or 3D.</summary>
    /// <returns>The dot product</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double result = 0;
        if ((vector1.Length == 2 && vector2.Length == 2) || (vector1.Length == 3 && vector2.Length == 3))
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                result += (vector1[i] * vector2[i]); 
            }
            return result;
        }
        else
        {
            return -1;
        }
    }
}