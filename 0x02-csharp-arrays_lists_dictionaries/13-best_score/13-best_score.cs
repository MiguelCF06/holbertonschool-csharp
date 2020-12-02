using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count <= 0)
        {
            return "None";
        }

        string student = "";
        foreach (KeyValuePair<string, int> kvp in myList)
        {
            int maxValue = myList.Values.Max();
            if (kvp.Value == maxValue)
            {
                student = kvp.Key;
            }
        }

        return student;
    }
}