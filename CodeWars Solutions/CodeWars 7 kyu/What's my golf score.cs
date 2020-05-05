using System.Linq;

public static class Kata
{
    public static int GolfScoreCalculator(string par, string score)
    {
        return par.Zip(score, (x, y) => y - x).Sum();
    }
}