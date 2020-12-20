using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    /// <summary>Prints the names of the available properties and methods of an object.</summary>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
        IEnumerable<MethodInfo> mList = t.DeclaredMethods;

        Console.WriteLine(t.Name + " " + "Properties:");
        foreach (PropertyInfo p in pList)
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine(t.Name + " " + "Methods:");
        foreach (MemberInfo m in mList)
        {
            Console.WriteLine(m.Name);
        }
    }
}