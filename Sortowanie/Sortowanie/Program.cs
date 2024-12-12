using System;
using System.Net.Http.Headers;

namespace Sortowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 7, -5, 1, 4, 14, 3, 9, 6, 2, 11 };

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }

            sortowanieznotepada.bubblesort(tab);
            //insertsort(tab);
            //mergesort(tab);
            //quicksort(tab, 0, tab.Length - 1);
            //countingsort(tab);
            Console.WriteLine();
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
        }

        //    static void bubblesort(int[] tab)
        //    {
        //        int temp = 0;
        //        for (int i = 0; i < tab.Length; i++)
        //        {
        //            for (int j = 0; j < tab.Length - 1; j++)
        //            {
        //                if (tab[j] > tab[j + 1])
        //                {
        //                    temp = tab[j + 1];
        //                    tab[j + 1] = tab[j];
        //                    tab[j] = temp;
        //                }
        //            }

        //        }
        //    }
        //    static void insertsort(int[] tab)
        //    {

        //        for (int i = 1; i < tab.Length; i++)
        //        {
        //            int temp = tab[i];
        //            int j = i - 1;
        //            while (j >= 0 && tab[j] > temp)
        //            {
        //                tab[j + 1] = tab[j];
        //                j--;
        //            }
        //            tab[j + 1] = temp;

        //        }
        //    }
        //    static void mergesort(int[] tab)
        //    {
        //        int length = tab.Length;
        //        if (length <= 1) return;

        //        int mid = length / 2;
        //        int[] leftTab = new int[mid];
        //        int[] rightTab = new int[length - mid];

        //        int i = 0;
        //        int j = 0;

        //        for (; i < length; i++)
        //        {
        //            if (i < mid)
        //            {
        //                leftTab[i] = tab[i];
        //            }
        //            else
        //            {
        //                rightTab[j] = tab[i];
        //                j++;
        //            }
        //        }
        //        mergesort(leftTab);
        //        mergesort(rightTab);
        //        merge(leftTab, rightTab, tab);
        //    }
        //    static void merge(int[] leftTab, int[] rightTab, int[] tab)
        //    {
        //        int leftSize = tab.Length / 2;
        //        int rightSize = tab.Length - leftSize;
        //        int i = 0;
        //        int l = 0;
        //        int r = 0;

        //        while (l < leftSize && r < rightSize)
        //        {
        //            if (leftTab[l] < rightTab[r])
        //            {
        //                tab[i] = leftTab[l];
        //                i++;
        //                l++;
        //            }
        //            else
        //            {
        //                tab[i] = rightTab[r];
        //                i++;
        //                r++;
        //            }
        //        }
        //        while (l < leftSize)
        //        {
        //            tab[i] = leftTab[l];
        //            i++;
        //            l++;
        //        }
        //        while (r < rightSize)
        //        {
        //            tab[i] = rightTab[r];
        //            i++;
        //            r++;
        //        }

        //    }
        //    static void quicksort(int[] tab, int start, int end)
        //    {
        //        if (end <= start) return;

        //        int pivot = partition(tab, start, end);
        //        quicksort(tab, start, pivot - 1);
        //        quicksort(tab, pivot + 1, end);
        //    }

        //    static int partition(int[] tab, int start, int end)
        //    {
        //        int pivot = tab[end];
        //        int i = start - 1;

        //        for (int j = start; j <= end - 1; j++)
        //        {
        //            if (tab[j] < pivot)
        //            {
        //                i++;
        //                int temp1 = tab[i];
        //                tab[i] = tab[j];
        //                tab[j] = temp1;
        //            }
        //        }
        //        i++;
        //        int temp2 = tab[i];
        //        tab[i] = tab[end];
        //        tab[end] = temp2;
        //        return i;
        //    }
        //    static void countingsort(int[] tab)
        //    {
        //        int max = int.MinValue;
        //        int min = int.MaxValue;
        //        for (int i = 0; i < tab.Length; i++)
        //        {
        //            if (tab[i] < min)
        //            {
        //                min = tab[i];
        //            }
        //            if (tab[i] > max)
        //            {
        //                max = tab[i];
        //            }
        //        }
        //        int[] count = new int[max - min + 1];
        //        int[] output = new int[tab.Length];
        //        // Initialize count array
        //        for (int i = 0; i < tab.Length; i++)
        //        {
        //            count[tab[i] - min]++;
        //        }

        //        // Update count array to store positions
        //        for (int i = 1; i < count.Length; i++)
        //        {
        //            count[i] += count[i - 1];
        //        }

        //        // Build output array
        //        for (int i = tab.Length - 1; i >= 0; i--)
        //        {
        //            output[count[tab[i] - min] - 1] = tab[i];
        //            count[tab[i] - min]--;
        //        }

        //        // Copy sorted elements back to original array
        //        for (int i = 0; i < tab.Length; i++)
        //        {
        //            tab[i] = output[i];
        //        }
        //    }
    }
}