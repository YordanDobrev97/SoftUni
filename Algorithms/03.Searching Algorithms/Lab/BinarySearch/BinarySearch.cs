
using System;

public class BinarySearch<T> where T : IComparable
{
    public int Search(T[] array, T item)
    {
        int index = -1;
        int middle = array.Length / 2;
        T[] left = new T[middle];
        T[] right = new T[middle];
        T middleItem = array[middle];
 
        FillLeftPart(array, left);
        FillRightPart(array, right);

        if (middleItem.CompareTo(item) == 0)
        {
            index = middle;
        }

        return index;
    }

    private void FillLeftPart(T[] array, T[] leftPart)
    {
        for (int i = 0; i < leftPart.Length; i++)
        {
            leftPart[i] = array[i];
        }
    }

    private void FillRightPart(T[] array, T[] rightPart)
    {
        int start = array.Length - rightPart.Length;

        int index = 0;
        for (int i = start; i < array.Length; i++)
        {
            rightPart[index] = array[i];
            index++;
        }
    }
}

