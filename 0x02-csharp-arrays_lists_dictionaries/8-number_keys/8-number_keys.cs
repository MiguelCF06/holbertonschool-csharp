using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keyCounter = 0;
        foreach (KeyValuePair<string, string> kvp in myDict)
        {
            keyCounter += 1;
        }

        return keyCounter;
    }
}