using System;
using System.Collections.Generic;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        numbers[i, j] = 1;
                    }
                    else
                    {
                        numbers[i, j] = 0;
                    }

                    if (j != 4)
                    {
                        Console.Write($"{numbers[i, j]} ");
                    }
                    else
                    {
                        Console.Write($"{numbers[i, j]}");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
