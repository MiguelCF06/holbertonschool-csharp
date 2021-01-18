using System;

/// <summary>Represents a Vector Operations class</summary>
class VectorMath
{
    /// <summary>Calculates the length of a given <param name="vector"/>vector that can be 2D or 3D.</summary>
    /// <returns>The length of the vector</returns>
    public static double Magnitude(double[] vector)
    {
        double result = 0;

        if (vector.Length == 2)
        {
            result = Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 1);
        }
        else if (vector.Length == 3)
        {
            result = Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 1);
        }
        else
        {
            result = -1;
        }
        return result;
    }
}