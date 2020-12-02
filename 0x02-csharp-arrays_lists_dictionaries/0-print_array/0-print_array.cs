using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.Write("\n");
        }
        else if (size < 0)
        {
            Console.Write("Size cannot be negative\n");
            return null;
        }

        int[] arrayNums = new int[size];

        for (int i = 0; i < arrayNums.Length; i++)
        {
            arrayNums[i] = i;
            if (arrayNums[i] == arrayNums.Length - 1)
            {
                Console.Write($"{arrayNums[i]}\n");
            }
            else
            {
                Console.Write($"{arrayNums[i]} ");
            }
        }

        return arrayNums;
    }
}