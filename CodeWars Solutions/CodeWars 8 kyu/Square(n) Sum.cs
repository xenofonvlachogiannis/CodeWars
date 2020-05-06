public static class Kata
{
    public static int SquareSum(int[] n)
    {
        int sum = 0;
        foreach (var item in n)
        {
            sum += item * item;
        }
        return sum;
    }
}