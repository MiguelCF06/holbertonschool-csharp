using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.Write("List is empty\n");
            return -1;
        }
        int maxValue = myList[0];
        foreach (int number in myList)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }

        return maxValue;
    }
}