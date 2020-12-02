using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index > myList.Count - 1)
        {
            Console.Write("Index is out of range\n");
            return myList;
        }

        int numberToDelete = myList[index];
        myList.Remove(numberToDelete);
        return myList;
    }
}