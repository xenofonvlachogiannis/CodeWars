using System;
using System.Linq;

public class Kata
{
    public static long SuperSize(long num)
    {
        return Convert.ToInt64(string.Join("", num.ToString().ToCharArray().OrderByDescending(x => x)));
    }
}