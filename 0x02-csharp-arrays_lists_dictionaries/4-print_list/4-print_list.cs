using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if (size == 0)
        {
            Console.Write("\n");
        }

        List<int> numbers = new List<int>();

        for (int i = 0; i <= size - 1; i++)
        {
            numbers.Add(i);
            if (i != size - 1)
            {
                Console.Write($"{numbers[i]} ");
            }
            else
            {
                Console.Write($"{numbers[i]}\n");
            }
        }
        return numbers;
    }
}