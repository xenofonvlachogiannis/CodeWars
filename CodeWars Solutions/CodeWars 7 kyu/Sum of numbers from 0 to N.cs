using System;

public class SequenceSum
{
    public static string ShowSequence(int n)
    {
        string total = "0";
        int sum = 0;
        if (n < 0)
        {
            return total = $"{n}<0";
        }
        else if (n == 0)
        {
            return total = "0=0";
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                total += $"+{i}";
                sum += i;
            }
            return total + $" = {sum}";
        }
    }
}