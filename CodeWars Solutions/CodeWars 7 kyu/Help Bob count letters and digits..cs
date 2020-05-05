using System.Linq;

public static class Kata
{
    public static int CountLettersAndDigits(string input)
    {
        return input.Where(char.IsLetterOrDigit).Count();
    }
}