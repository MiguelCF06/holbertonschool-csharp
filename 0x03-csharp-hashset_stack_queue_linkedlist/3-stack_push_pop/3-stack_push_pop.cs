using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {

        Console.Write($"Number of items: {aStack.Count}\n");
        if (aStack.Count <= 0)
            Console.Write("Stack is empty\n");
        else
            Console.Write($"Top item: {aStack.Peek()}\n");
        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");
        if (aStack.Contains(search))
        {
            while (aStack.Contains(search))
            {
                aStack.Pop();
            }
        }

        aStack.Push(newItem);
        

        return aStack;
    }
}