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
        [Test]
        public void factorial_test()
        {
            var expected = -1;
            var actual = Logic.factorial(15000);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
