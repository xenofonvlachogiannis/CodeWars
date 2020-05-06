using System;

public class Kata
{
    public static int[] Get_size(int w, int h, int d)
    {
        int[] totalAreaAndVolume = new int[2] { 2 * d * w + 2 * d * h + 2 * w * h, w * h * d };
        return totalAreaAndVolume;
    }
}