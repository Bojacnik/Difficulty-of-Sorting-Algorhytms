using System.Collections.Generic;
using System.Diagnostics;

namespace DifficultyOfSortingAlgorithms;

public class Bubblesort : SortingAlgorithm
{
    public override PerformanceData Sort(int[] numbers)
    {
        int Iterations;
        var s = new Stopwatch();
        s.Start();

        Iterations = _sort(numbers);

        s.Stop();
        return new PerformanceData(s, Iterations, numbers.Length);
    }


    private static int _sort(IList<int> numbers)
    {
        var iterace = 0;
        for (var x = 0; x < numbers.Count - 1; x++)
        {
            for (var y = 0; y < numbers.Count - 1; y++)
                if (numbers[y] > numbers[y + 1])
                    _swap(numbers, y + 1, y);
            iterace++;
        }

        return iterace;
    }

    private static void _swap(IList<int> numbers, int index1, int index2)
    {
        (numbers[index1], numbers[index2]) = (numbers[index2], numbers[index1]);
    }

    public Bubblesort(string name) : base(name)
    {
    }
}