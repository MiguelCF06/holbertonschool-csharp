using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> kvp in myDict)
        {
            int numbers = kvp.Value;
            newDict[kvp.Key] = numbers *= 2;
        }
        
        return newDict;
    }
}