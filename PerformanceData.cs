using System.Diagnostics;

namespace DifficultyOfSortingAlgorithms;

public class PerformanceData
{
    public readonly int Iterations;
    public readonly int Length;
    public readonly Stopwatch Time;

    public PerformanceData(Stopwatch stopwatch, int Iterations)
    {
        Time = stopwatch;
        this.Iterations = Iterations;
    }

    public PerformanceData(Stopwatch stopwatch, int Iterations, int length)
    {
        Time = stopwatch;
        this.Iterations = Iterations;
        Length = length;
    }
}