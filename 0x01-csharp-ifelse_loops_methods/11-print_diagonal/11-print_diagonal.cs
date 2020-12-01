using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            Console.Write("\n");
        }
        else
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("\\\n");
                for (int j = 0; j <= i; j++)
                {
                    if (i != length - 1)
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.Write("\n");
        }
    }
}
