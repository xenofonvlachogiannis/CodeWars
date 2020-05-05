public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        string position = null;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == "needle")
            {
                position = $"found the needle at position {i}";
            }
        }
        return position;
    }
}