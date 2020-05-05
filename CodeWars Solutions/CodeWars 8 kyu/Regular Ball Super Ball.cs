using System;

public class Ball
{
    public string ballType { get; set; }
    public Ball()
    {
        ballType = "regular";
    }
    public Ball(string ballType)
    {
        this.ballType = ballType;
    }
}