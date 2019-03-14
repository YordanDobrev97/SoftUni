
using System;

public class Merge<T> where T : IComparable
{
    public void Sort(T[] array)
    {
        if (array.Length == 1)
        {
            return;
        }

        int middle = array.Length / 2;
        T[] left = new T[middle];
        T[] right = new T[middle];

        for (int i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }

        int index = 0;

        for (int i = middle; i < array.Length; i++)
        {
            right[index] = array[i];
            index++;
        }

        Sort(left);

        left = MergeArray(left, right);

        Sort(right);
        //Merge
    }

    private T[] MergeArray(T[] left, T[] right)
    {
        T[] newArray = new T[left.Length + right.Length];
        
        for (int i = 0; i < left.Length; i++)
        {
            if (left[i].CompareTo(right[i]) == 1)
            {
                newArray[i] = right[i];
            }
            else
            {
                newArray[i] = left[i];
            }
        }

        return newArray;
    }
}

