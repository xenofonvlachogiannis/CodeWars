using System;

public class Game
{
    public static int Move(int position, int roll)
    {
        return roll * 2 + position;
    }
}