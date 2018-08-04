using System;

public class Queue<T>
{
    private int MIN_CAPACITY = 16;
    private T[] array;

    private int startIndex;
    private int endIndex;
    
    public Queue()
    {
        this.array = new T[MIN_CAPACITY];
    }

    public int Count { get; set; }

    public void Enqueue(T item)
    {
        if (this.Count >= this.array.Length)
        {
            //Resize array
            Resize();
        }

        this.array[endIndex] = item;
        endIndex = (endIndex + 1) % this.array.Length;
        this.Count++;
    }

    private void Resize()
    {
        T[] newArray = new T[this.array.Length * 2];
        int startIndx = startIndex;
        int indx = 0;
        for (int i = 0; i <this.Count; i++)
        {
            newArray[indx++] = this.array[startIndex];
            startIndex = (startIndex + 1) % this.array.Length;
        }
        startIndex = 0;
        endIndex = this.Count;

        this.array = newArray;
    }

    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Empty queue");
        }

        T item = this.array[startIndex];
        startIndex = (startIndex + 1) % this.array.Length;
        this.Count--;
        return item;
    }
    
    public T Peek()
    {
        T item = this.array[startIndex];

        return item;
    }
}

