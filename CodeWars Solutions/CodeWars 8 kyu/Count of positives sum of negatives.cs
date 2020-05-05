using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input is null || input.Length == 0)
        {
            return new int[0];
        }
        int a = input.Count(x => x > 0);
        int b = input.Sum(x => x < 0 ? x : 0);
        int[] final = new int[] { a, b };
        return final;
    }
}