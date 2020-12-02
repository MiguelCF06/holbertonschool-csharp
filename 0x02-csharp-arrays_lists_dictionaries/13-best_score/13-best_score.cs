using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }

        int maxScore = 0;
        string student = "";
        foreach (KeyValuePair<string, int> kvp in myList)
        {
            if (kvp.Value > maxScore)
            {
                maxScore = kvp.Value;
                student = kvp.Key;
            }
        }

        return student;
    }
}