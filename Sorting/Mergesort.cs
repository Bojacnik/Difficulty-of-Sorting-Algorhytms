using System.Collections.Generic;
using System.Diagnostics;

namespace DifficultyOfSortingAlgorithms;

internal class Mergesort : SortingAlgorithm
{
    public override PerformanceData Sort(int[] pole)
    {
        var s = new Stopwatch();
        s.Start();

        sort(pole, 0, pole.Length - 1);

        s.Stop();
        return new PerformanceData(s, 0, pole.Length);
    }

    private static void merge(IList<int> arr, int l, int m, int r)
    {
        var n1 = m - l + 1;
        var n2 = r - m;

        var L = new int[n1];
        var R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];

        i = 0;
        j = 0;

        var k = l;
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

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    private static void sort(IList<int> arr, int l, int r)
    {
        if (l >= r) return;
        var m = l + (r - l) / 2;

        sort(arr, l, m);
        sort(arr, m + 1, r);

        merge(arr, l, m, r);
    }

    public Mergesort(string name) : base(name)
    {
    }
}