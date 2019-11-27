using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class ListyIterator<T>
{
    private class Iterator<T> : IEnumerator<T>
    {
        private List<T> list;
        private int index;

        public Iterator()
        {
            this.index = 0;
            this.list = new List<T>();
        }

        public T Current => list[index];

        object IEnumerator.Current => this.Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (index < list.Count)
            {
                return true;
            }
            return false;
        }

        public bool Move()
        {
            if (MoveNext())
            {
                this.index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            this.index = 0;
        }
    }

    private List<Iterator<T>> iterator;
    public ListyIterator()
    {
        this.iterator = new List<Iterator<T>>();
    }

    public bool Move()
    {
        return iterator.MoveNext();
    }

    public bool HasNext()
    {
        return iterator.Move();
    }

    public void Print()
    {
        Console.WriteLine(iterator.Current);
    }

    public void End()
    {
        Environment.Exit(0);
    }
}
