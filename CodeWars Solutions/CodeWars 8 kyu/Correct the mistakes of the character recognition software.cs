public class Kata
{
    public static string Correct(string text)
    {
        return text.Replace('5', 'S').Replace('0', 'O').Replace('1', 'I');
    }
}