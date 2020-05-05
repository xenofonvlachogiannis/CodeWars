using System;
using System.Linq;

public static class Kata
{
    public static string RemoveDuplicateWords(string s)
    {
        return string.Join(" ", s.Split(' ').ToList().Distinct());
    }
}