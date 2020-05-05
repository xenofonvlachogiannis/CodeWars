using System.Collections.Generic;

public class Persist
{
    public static int Persistence(long n)
    {
        List<long> number = new List<long>();
        int x = 0;
        if (n < 10) return 0;
        do
        {
            ++x;
            number.Clear();
            while (n > 0)
            {
                number.Add(n % 10);
                n /= 10;
            }
            n = 1;
            foreach (var item in number)
            {
                n *= item;
            }
            number[0] = n;
        } while (number[0] >= 9);
        return x;
    }
}