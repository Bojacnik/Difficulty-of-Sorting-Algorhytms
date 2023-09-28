using System;

namespace DifficultyOfSortingAlgorithms;

public static class Populate
{
    public static void Array(int[] array)
    {
        var rdm = new Random();
        for (var i = 0; i < array.Length; i++)
            array[i] = rdm.Next(0, 50000);
    }
}