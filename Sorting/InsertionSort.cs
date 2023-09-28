using System.Collections.Generic;
using System.Diagnostics;

namespace DifficultyOfSortingAlgorithms;

public class InsertionSort : SortingAlgorithm
{
    public override PerformanceData Sort(int[] pole)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        insertionSort(pole);

        stopwatch.Stop();
        return new PerformanceData(stopwatch, 0, pole.Length);
    }

    private static void insertionSort(IList<int> arr)
    {
        for (var i = 1; i <= arr.Count - 1; i++)
        {
            var temp = arr[i];
            var j = i - 1;
            while (j >= 0 && arr[j] > temp)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = temp;
        }
    }

    public InsertionSort(string name) : base(name)
    {
    }
}