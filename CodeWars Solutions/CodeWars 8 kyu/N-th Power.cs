using System;

public class Kata
{
    public static double Index(int[] array, int n)
    {
        return n < array.Length ? Math.Pow(array[n], n) : -1;
    }
}