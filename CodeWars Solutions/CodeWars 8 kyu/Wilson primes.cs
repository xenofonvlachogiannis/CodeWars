using System;

public class Kata
{
    public static bool AmIWilson(int p)
    {
        int fact = 1;
        for (int i = p - 1; i >= 1; i--)
        {
            fact *= i;
        }


        return ((double)(fact + 1) / ((double)p * (double)p)) % 1 == 0;
    }
}