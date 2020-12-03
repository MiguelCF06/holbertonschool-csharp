using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        if (aQueue.Count <= 0)
        {
            Console.WriteLine("Queue is empty");
        }
        Console.WriteLine($"Number of items: {aQueue.Count}");
        Console.WriteLine($"First item: {aQueue.Peek()}");

        if (aQueue.Contains(search))
        {
            Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");
            while (aQueue.Contains(search))
            {
                aQueue.Dequeue();
            }
        }

        aQueue.Enqueue(newItem);

        return aQueue;
    }
}