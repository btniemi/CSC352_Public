namespace FunWithLoops
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        internal static IEnumerable<int> NumbersOneThruTwentyFive()
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<int> EvenNumbersOneThruTwentyFive()
        {
            throw new NotImplementedException();
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
            if (number <= 1)
                return false;
            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    return false;
            return true;
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
