using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqueNums = new HashSet<int>();
        int sum = 0;

        foreach (int i in myList)
        {
            uniqueNums.Add(i);
        }

        foreach (int i in uniqueNums)
        {
            sum += i;
        }

        return sum;
    }
}