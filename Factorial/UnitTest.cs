using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

using NUnit.Framework;

namespace Factorial
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class UnitTest
    {
        [TestCase(5,120)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        public void factorial_test(int n, int expected)
        {
            int actual = Logic.factorial(n);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
