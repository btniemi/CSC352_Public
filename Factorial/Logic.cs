using System;
using System.Numerics;

namespace Factorial
{
    public class Logic
    {
        public static int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
    }
}
