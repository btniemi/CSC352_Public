namespace Summation
{
    using NUnit.Framework;

    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class UnitTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 3)]
        [TestCase(5, 15)]
        [TestCase(100, 5050)]
        [TestCase(200000, -1)]
        public void Summation_Test(int input, int expected)
        {
            int actual = Logic.Summation(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
