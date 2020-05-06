using System;

public static class Kata
{
    public static int GetRealFloor(int n)
    {
        return n <= 0 ? n : n <= 13 ? n - 1 : n - 2;
    }
}