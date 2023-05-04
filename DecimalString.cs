using System;
using System.Collections.Generic;

public class DStringCollection
{
    private Queue<DecimalString> queue;

    public DStringCollection()
    {
        queue = new Queue<DecimalString>();
    }

    public int Count
    {
        get { return queue.Count; }
    }

    public void Add(DecimalString item)
    {
        queue.Enqueue(item);
    }

    public DecimalString Remove()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }
        return queue.Dequeue();
    }

    public DecimalString Peek()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }
        return queue.Peek();
    }

    public void Clear()
    {
        queue.Clear();
    }
}
