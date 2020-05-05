using System;
using System.Linq;

public static class Kata
{
    public static string boolToWord(bool word)
    {
        return word is true ? "Yes" : "No";
    }
}