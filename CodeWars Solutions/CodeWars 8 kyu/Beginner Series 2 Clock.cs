using System;
public static class Clock
{
    public static int Past(int h, int m, int s)
    {
        return (s * 1000) + (m * 60000) + (h * 3600000);
    }
}