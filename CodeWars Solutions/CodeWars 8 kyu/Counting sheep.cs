using System;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        int sumOfSheeps = 0;
        foreach (var item in sheeps)
        {
            if (item == true) sumOfSheeps += 1;
        }
        return sumOfSheeps;
    }
}