using System.Collections.Generic;

public class Deadfish
{
    public static int[] Parse(string data)
    {
        int temp = 0;
        List<int> result = new List<int>();
        foreach (var item in data)
        {
            if (item == 'i')
            {
                temp += 1;
            }
            if (item == 'd')
            {
                temp -= 1;
            }
            if (item == 'o')
            {
                result.Add(temp);
            }
            if (item == 's')
            {
                temp *= temp;
            }
        }

        return result.ToArray();
    }
}