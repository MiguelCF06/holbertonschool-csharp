using System;

class Queue<T>
{
    /// <summary>Check and return the type of the Queue's type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>Class Node inside queue class</summary>
    public class Node
    {
        public T value;
        public Node next = null;

        public Node(T _value)
        {
            value = _value;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    ///<summary>Add new node at the end</summary>
    public void Enqueue(T _value)
    {
        Node newNode = new Node(_value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    ///<summary>Removes the first node in the queue and returns its value.</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        T valueFirstNode = head.value;
        head = head.next;
        count--;
        return valueFirstNode;
    }

    ///<summary>Returns the first node value.</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }

        return head.value;
    }

    ///<summary>Return the number of nodes in the Queue</summary>
    public int Count()
    {
        return count;
    }
}