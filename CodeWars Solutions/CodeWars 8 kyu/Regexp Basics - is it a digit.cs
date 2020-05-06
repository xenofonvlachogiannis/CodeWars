using System;
using System.Text.RegularExpressions;

public static class Kata
{
    public static bool Digit(this string s)
    {
        return Regex.IsMatch(s, @"^\d\z");
    }
}