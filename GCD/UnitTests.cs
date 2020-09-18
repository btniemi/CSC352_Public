namespace GCD
{
    using NUnit.Framework;

    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class UnitTests
    {
        [TestCase(1, 2, 1)]
        [TestCase(2, 4, 2)]
        [TestCase(30, 45, 15)]
        [TestCase(12962250, 12345, 12345)]
        [TestCase(1,long.MaxValue, 1)]
        public void gcd_test(long x, long y, long expected)
        {
            long actual = Logic.gcd(x, y);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
