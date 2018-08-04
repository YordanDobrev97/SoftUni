using System;
class ArrayList<T>
{
    private T[] array;
    private const int MIN_CAPACITY = 4;  
    public int Count { get; private set; }

    public ArrayList()
    {
        this.array = new T[MIN_CAPACITY];
    }
    public void Add(T item)
    {
        if (this.Count == this.array.Length)
        {
            ExpandArray(this.Count * 2);
        }
        array[this.Count++] = item;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException("Index is less zero or large from currentSize");
            }

            return this.array[index];
        }
        set
        {
            if (index < 0 || index >=this.Count)
            {
                throw new InvalidOperationException("Index large from count");
            }
            this.array[index] = value;
        }
    }

    public void RemoveAt(int index)
    {
        if (index > this.Count || index < 0)
        {
            throw new ArgumentOutOfRangeException("Index less or large count");
        }
        T item = this.array[index];
        Shift(index);

        if (this.Count <= this.array.Length / 4)
        {
            Shrink();
        }
    }
    private void Shrink()
    {
        T[] newArray = new T[this.array.Length / 2];
        Array.Copy(this.array, newArray, this.Count);

        array = newArray;
    }

    private void Shift(int index)
    {
        this.Count--;
        for (int i = index; i < this.Count; i++)
        {
            this.array[i] = this.array[i + 1];
        }
    }

    private void ExpandArray(int size)
    {
        T[] newArray = new T[size];

        for (int i = 0; i < this.Count; i++)
        {
            newArray[i] = array[i];
        }
        array = newArray;
    }
}