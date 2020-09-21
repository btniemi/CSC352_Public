using System;

namespace GCD
{
    public class Logic
    {
        public static long gcd(long x, long y)
        {
            //RESURSIVE WAY
            //I do not get how this works at all even through research and debuging
            //if (y == 0)
            //{
            //    return x;
            //}
            //else
            //{
            //    return gcd(y, x % y);
            //}

            //ITERATIVE WAY
            long result = 0;

            for(long i = 1; i <= x; i++)
            {
                if(x % i == 0 && y % i == 0)
                {
                    result = i;
                }
            }
            return result;


        }
    }
}
