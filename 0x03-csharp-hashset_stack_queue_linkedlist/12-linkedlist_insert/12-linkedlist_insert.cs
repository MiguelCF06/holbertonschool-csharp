using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        var current = myLList.Find(n);
        foreach (int num in myLList)
        {
            if (num >= n)
            {
                current = myLList.Find(num);
                break;
            }
        }
        return myLList.AddBefore(current, n);
    }
}