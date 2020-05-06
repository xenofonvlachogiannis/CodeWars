using System;

public class Kata
{
    public static double SquareArea(double A)
    {
        return Math.Round(Math.Pow((A * 2 / Math.PI), 2), 2);
    }
}