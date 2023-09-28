namespace DifficultyOfSortingAlgorithms;

public abstract class SortingAlgorithm
{
    public readonly string Name;

    protected SortingAlgorithm(string name)
    {
        Name = name;
    }

    public abstract PerformanceData Sort(int[] pole);
}