using System.Collections.Generic;
using System.Diagnostics;

namespace DifficultyOfSortingAlgorithms;

internal class ImprovedBubblesort : SortingAlgorithm
{
    public override PerformanceData Sort(int[] pole)
    {
        var s = new Stopwatch();
        s.Start();

        improvedBubbleSort(pole);

        s.Stop();
        return new PerformanceData(s, 0, pole.Length);
    }

    private static void improvedBubbleSort(IList<int> arr)
    {
        var n = arr.Count;
        for (var i = 0; i < n - 1; i++)
        for (var j = 0; j < n - i - 1; j++)
            if (arr[j] > arr[j + 1])
            {
                // swap temp and arr[i]
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
    }

    public ImprovedBubblesort(string name) : base(name)
    {
    }
}