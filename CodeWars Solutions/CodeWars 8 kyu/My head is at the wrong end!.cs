using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string[] FixTheMeerkat(string[] arr)
    {
        List<string> temp = new List<string>();
        temp = arr.Reverse().ToList();

        return temp.ToArray();
    }
}