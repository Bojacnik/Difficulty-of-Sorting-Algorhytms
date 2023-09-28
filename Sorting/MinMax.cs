using System.Collections.Generic;
using System.Diagnostics;

namespace DifficultyOfSortingAlgorithms;

internal class MinMax : SortingAlgorithm
{
    public override PerformanceData Sort(int[] pole)
    {
        var s = new Stopwatch();
        s.Start();

        minMaxSelectionSort(pole, pole.Length);

        s.Stop();
        return new PerformanceData(s, 0, pole.Length);
    }

    private static void minMaxSelectionSort(IList<int> arr, int n)
    {
        for (int i = 0, j = n - 1;
             i < j;
             i++, j--)
        {
            int min = arr[i], max = arr[i];
            int min_i = i, max_i = i;
            for (var k = i; k <= j; k++)
                if (arr[k] > max)
                {
                    max = arr[k];
                    max_i = k;
                }

                else if (arr[k] < min)
                {
                    min = arr[k];
                    min_i = k;
                }

            _swap(arr, i, min_i);

            if (arr[min_i] == max)
                _swap(arr, j, min_i);
            else
                _swap(arr, j, max_i);
        }
    }

    private static void _swap(IList<int> arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }

    public MinMax(string name) : base(name)
    {
    }
}