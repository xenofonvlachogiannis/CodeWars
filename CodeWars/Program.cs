using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using static System.Convert;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    using System;

    public class Persist
    {
        public static int Persistence(long n)
        {
            List<long> number = new List<long>();
            int x = 0;
            do
            {
                ++x;
                number.Clear();
                while (n > 0)
                {
                    number.Add(n % 10);
                    n /= 10;
                }
                n = 1;
                foreach (var item in number)
                {
                    n *= item;
                }
                number[0] = n;
            } while (number[0]>=9);
            return x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persist.Persistence(39);
        }
    }


}