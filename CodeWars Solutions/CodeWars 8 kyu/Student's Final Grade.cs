using System;
using System.Linq;

namespace Solution
{
    public class Kata
    {
        public static int FinalGrade(int exam, int projects)
        {
            return exam > 90 || projects > 10 ? 100 : exam > 75 && projects >= 5 ? 90 : exam > 50 && projects >= 2 ? 75 : 0;
        }
    }
}