using System;

public class Kata
{
    public static string AbbrevName(string name)
    {
        string temp = name.Substring(0, 1);
        string temp1 = name.Substring(name.IndexOf(' ') + 1, 1);
        return (temp + "." + temp1).ToUpper();
    }
}