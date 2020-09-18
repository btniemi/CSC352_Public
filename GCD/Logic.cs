using System;

namespace GCD
{
    public class Logic
    {
        public static long gcd(long x, long y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return gcd(y, x % y);
            }
        }
    }
}
