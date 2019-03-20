
using System;

public class Merge<T> where T : IComparable
{
    public void Merging(int[] arr, int l, int m, int r)
    {
        // Find sizes of two subarrays to be merged 
        int n1 = m - l + 1;
        int n2 = r - m;

        /* Create temp arrays */
        int[] L = new int[n1];
        int[] R = new int[n2];

        /*Copy data to temp arrays*/
        for (int p = 0; p < n1; p++)
        {
            L[p] = arr[l + p];
        }

        for (int c = 0; c < n2; ++c)
        {
            R[c] = arr[m + 1 + c];
        }

        /* Merge the temp arrays */

        // Initial indexes of first and second subarrays 
        int i = 0, j = 0;

        // Initial index of merged subarry array 
        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        /* Copy remaining elements of L[] if any */
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        /* Copy remaining elements of R[] if any */
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    public void Sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            // Find the middle point 
            int m = (l + r) / 2;

            Sort(arr, l, m);// sort left parts
            Sort(arr, m + 1, r); // sort right parts

            // Merge the sorted halves 
            Merging(arr, l, m, r);
        }
    }
}

