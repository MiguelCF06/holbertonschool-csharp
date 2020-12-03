using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonEl = new List<int>();

        commonEl = list1.FindAll(elem => list2.Contains(elem));

        commonEl.Sort();
        return commonEl;
    }
}