using System;
using System.Numerics;

namespace Factorial
{
    public class Logic
    {
        public static int factorial(int n)
        {
            //RECURSIVE WAY
            //if (n == 0)
            //{
            //    return 1;
            //}
            //else
            //{
            //    int nextFactorial = factorial(n - 1);
            //    return n * nextFactorial;
            //}

            //ITERATIVE WAY
            int result = 1;

            for(int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
