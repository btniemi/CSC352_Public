namespace FunWithLoops
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        internal static IEnumerable<int> NumbersOneThruTwentyFive()
        {
            //List<int> numbers = new List<int>();

            //for(int i=1; i<=25; i++)
            //{
            //    numbers.Add(i);
            //}
            //return numbers;

            for(int i=1; i <=25; i++)
            {
                yield return i;
            }

        }

        internal static IEnumerable<int> EvenNumbersOneThruTwentyFive()
        {
            for(int i=2; i<=25; i += 2)
            {
                yield return i;
            }
        }

        internal static IEnumerable<int> OddNumbersOneThruTwentyFive()
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<int> PrimeNumbersOneThruTwentyFive()
        {
            throw new NotImplementedException();
        }

        internal static bool IsPrime(int number)
        {
            //any positive integer
            //divisible by one and itself
            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

            }
            return isPrime;
        }

        internal static IEnumerable<int> GetNumbersOneThru(int thruInclusive)
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<int> GetRangeThruInclusive(int start, int end)
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<int> GetPrimesInRangeInclusive(int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
