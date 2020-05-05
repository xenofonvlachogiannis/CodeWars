using System;
using System.Linq;

public class Kata
{
    public static int FindDifference(int[] a, int[] b)
    {
        return Math.Abs(a.Aggregate((x, y) => x * y) - b.Aggregate((x, y) => x * y));
    }
}