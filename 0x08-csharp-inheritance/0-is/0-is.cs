using System;

class Obj
{
    /// <summary>Check if the object <paramref name="obj" /> is of type int, if it is return true otherwise return false.</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return true;
        else
            return false;
    }
}