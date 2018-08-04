
using System;
using System.Collections;
using System.Collections.Generic;

public class ReversedList<T> : IEnumerable<T>
{
    private T[] data;
    private const int MIN_CAPACITY = 2;
    private int index;

    public ReversedList()
    {
        data = new T[MIN_CAPACITY];
        index = this.data.Length - 1;
    }
    public int Count { get; private set; }
    public int Capacity => this.data.Length;

    public void Add(T item)
    {
        if (index < 0)
        {
            Resize();
        }
        data[index--] = item;
        this.Count++;
    }

    private void Resize()
    {
        T[] newArray = new T[this.data.Length * 2];

        int lastIndexNewArray = newArray.Length - 1;
        int lastIndexOldArray = this.data.Length - 1;
        for (int i = 0; i < this.data.Length; i++)
        {
            newArray[lastIndexNewArray--] = this.data[lastIndexOldArray--];
        }
        index = lastIndexNewArray;
        this.data = newArray;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >=this.Count)
            {
                throw new IndexOutOfRangeException("Index it's less zero or large from length");
            }
            return this.data[index];
        }
        set
        {
            if (index < 0 || index >=this.Count)
            {
                throw new IndexOutOfRangeException("Index it's less zero or large from length");
            }
            this.data[index] = value;
        }
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index > this.Count)
        {
            throw new ArgumentOutOfRangeException("Index it's less zero or large from length");
        }
        Shift(index);

    }

    private void Shift(int index)
    {
        for (int i = index; i < this.data.Length - 1; i++)
        {
            this.data[i] = this.data[i + 1];
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.data.Length; i++)
        {
            yield return this.data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

