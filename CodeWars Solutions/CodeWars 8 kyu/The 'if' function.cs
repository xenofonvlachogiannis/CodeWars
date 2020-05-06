using System;

public class Kata
{
    public static void If(bool condition, Action func1, Action func2)
    {
        (condition ? func1 : func2)();
    }
}