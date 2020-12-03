using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> numbers = new LinkedList<int>();
        if (size < 0)
        {
            return numbers;
        }

        for (int i = 0; i < size; i++)
        {
            numbers.AddLast(i);
        }
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        return numbers;
    }
}