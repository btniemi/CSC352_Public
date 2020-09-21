using System;
using System.Collections.Generic;
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
            //int result = 1;

            //for(int i = 1; i <= n; i++)
            //{
            //    result = result * i;
            //}
            //return result;

            //MANAGING OWN STACK
            Stack<long> stack = new Stack<long>();

            while(n != 0)
            {
                stack.Push(n);
                n = n - 1;
            }

            long result = 0;

            while(stack.Count != 0)
            {
                result = result * stack.Pop();
            }
            return (int)result; // why cant i hold this as a long and have to cast it as an int if I take out the (int) it give me and error

        }
    }
}
