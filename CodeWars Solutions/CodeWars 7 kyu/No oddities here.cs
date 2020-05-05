using System.Linq;

public class NoOddities
{
    public static int[] NoOdds(int[] values)
    {
        return values.Where(x => x % 2 == 0).ToArray(); ;
    }
}