using System;
using System.Collections.Generic;

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

            //ITERATIVE WAY BRUTE FORCE BRAEDON
            long result = 0;

            for (long i = 1; i <= x; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    result = i;
                }
            }
            return result;

            //Iterative Way using the most optiomal solution
            //long gcd = 0; 
            //while( y != 0)
            //{
            //    long modXY = x % y;
            //    gcd = y;
            //    y = modXY;
            //    x = gcd;
            //}

            //return gcd; 

            //MANAGING OWN STACK(did not fully solve this if possible)
            //Stack<long> stack = new Stack<long>();
            //long lowerValue;
            //if (x > y)
            //{
            //    lowerValue = x;
            //}
            //else
            //{
            //    lowerValue = y;
            //}

            //while (lowerValue > 0)
            //{
            //    stack.Push(lowerValue);
            //    lowerValue -= 1;
            //}

            //long result = 0;

            //while (stack.Count < 0)
            //{

            //}



        }
    }
}
