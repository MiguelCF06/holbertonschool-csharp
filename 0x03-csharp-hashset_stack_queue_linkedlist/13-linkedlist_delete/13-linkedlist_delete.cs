using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int counter = 0;
        int numToDel = 0;

        foreach (int num in myLList)
        {
            if (counter == index)
                numToDel = num;
            counter += 1;
        }
        myLList.Remove(numToDel);
    }
}