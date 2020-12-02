using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int width = myMatrix.GetLength(0);
        int height = myMatrix.GetLength(1);
        int[,] newMatrix = new int[width, height];

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                newMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }
        return newMatrix;
    }
}