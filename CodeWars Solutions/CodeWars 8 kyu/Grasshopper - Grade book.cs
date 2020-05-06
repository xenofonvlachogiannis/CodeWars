public class Kata
{
    public static char GetGrade(int s1, int s2, int s3)
    {
        int score = (s1 + s2 + s3) / 3;

        if (score >= 0 && score < 60)
        {
            return 'F';
        }
        else if (score > -60 && score < 70)
        {
            return 'D';
        }
        else if (score >= 70 && score < 80)
        {
            return 'C';
        }
        else if (score >= 80 && score < 90)
        {
            return 'B';
        }
        else
        {
            return 'A';
        }

    }
}