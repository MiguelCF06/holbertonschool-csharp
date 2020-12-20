using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

class Obj
{
    /// <summary>Prints the names of the available properties and methods of an object.</summary>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.GetProperties();
        IEnumerable<MethodInfo> mList = t.GetMethods();

        Console.WriteLine(t.Name + ' ' + "Properties:");
        foreach (PropertyInfo p in pList)
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine(t.Name + ' ' + "Methods:");
        foreach (MemberInfo m in mList)
        {
            Console.WriteLine(m.Name);
        }
    }
}