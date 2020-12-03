using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> diffElem = new List<int>();

        foreach (int i in list1)
        {
            if (!list2.Contains(i))
            {
                diffElem.Add(i);
            }
        }
        foreach (int i in list2)
        {
            if (!list1.Contains(i))
            {
                diffElem.Add(i);
            }
        }

        diffElem.Sort();
        return diffElem;
    }
}