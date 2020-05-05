using System;

public class Kata
{
    public string Pattern(int n)
    {
        string final = "1";
        string temp = "";
        if (n < 1)
        {
            return "";
        }
        else
        {
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    temp += i;
                }
                final += "\n" + temp;
                temp = "";
            }
            return final;
        }

    }
}