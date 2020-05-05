using System;
public static class Paper
{
    public static int Paperwork(int n, int m)
    {
        return n < 0 || m < 0 ? 0 : n * m;
    }
}