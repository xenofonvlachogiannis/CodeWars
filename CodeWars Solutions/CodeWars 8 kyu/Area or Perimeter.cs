public class MathCheck
{
    public static int AreaOrPerimeter(int l, int w)
    {
        return l - w == 0 ? l * w : (l + w) * 2;
    }
}