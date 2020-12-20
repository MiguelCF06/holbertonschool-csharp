using System;

class Obj
{
    /// <summary>Check if the object <paramref name="obj" /> is an instance of Array, if it is return true otherwise return false.</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        else
            return false;
    }
}