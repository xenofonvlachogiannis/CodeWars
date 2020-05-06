using System.Linq;

public static class Kata
{
    public static bool IsLockNessMonster(string sentence)
    {
        string[] check = new string[] { "3.50", "tree fiddy", "three fifty" };
        return check.Any(sentence.ToLower().Contains);
    }
}