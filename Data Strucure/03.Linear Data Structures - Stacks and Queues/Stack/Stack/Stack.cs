using System;
using System.Collections;
using System.Collections.Generic;
public class StaticStack<T> : IEnumerable<T>
{
    private int MIN_CAPACITY = 4;
    private T[] array;
    private int index;

    public int Count { get; set; }
    public int Capacity => this.array.Length;

    public StaticStack()
    {
        this.array = new T[MIN_CAPACITY];
        index = 0;
    }
    public void Push(T item)
    {
        if (this.Count >= this.array.Length)
        {
            Resize();
        }
        this.array[index++] = item;

        this.Count++;
    }

    private void Resize()
    {
        T[] newArray = new T[this.array.Length * 2];
        for (int i = 0; i < this.array.Length; i++)
        {
            newArray[i] = this.array[i];
        }
        this.array = newArray;
    }

    public T Pop()
    {
        if (this.Count == 0 || index < 0)
        {
            throw new InvalidOperationException("Empty stack");
        }
        T element = this.array[index - 1];
        this.array[index--] = default(T);
        this.Count--;
        return element;
    }

    public T Peek()
    {
        if (this.Count == 0 || index < 0)
        {
            throw new InvalidOperationException("Empty stack");
        }
        T element = this.array[index-1];

        return element;
    }

    public void TrimExcess()
    {
        T[] newArray = new T[this.Count];
        int last = newArray.Length - 1;

        for (int i = this.array.Length - 1; i > index; i--)
        {
            newArray[last--] = this.array[i];
        }
        this.array = newArray;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.array.Length; i++)
        {
            yield return this.array[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

