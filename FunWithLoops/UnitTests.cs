// <copyright file="UnitTests.cs" company="Ace Olszowka">
// Copyright (c) 2020 Ace Olszowka.
// </copyright>

namespace FunWithLoops
{
    using NUnit.Framework;

    using System.Collections.Generic;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class UnitTests
    {
        [Test]
        public void NumbersOneThruTwentyFive_Test()
        {
            string expected = "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25";
            string actual = string.Join(',', Program.NumbersOneThruTwentyFive());

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void EvenNumbersOneThruTwentyFive_Test()
        {
            string expected = "2,4,6,8,10,12,14,16,18,20,22,24";
            string actual = string.Join(',', Program.EvenNumbersOneThruTwentyFive());

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void OddNumbersOneThruTwentyFive_Test()
        {
            string expected = "1,3,5,7,9,11,13,15,17,19,21,23,25";
            string actual = string.Join(',', Program.OddNumbersOneThruTwentyFive());

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void PrimeNumbersOneThruTwentyFive_Test()
        {
            string expected = "2,3,5,7,11,13,17,19,23";
            string actual = string.Join(',', Program.PrimeNumbersOneThruTwentyFive());

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-1, new int[0])]
        [TestCase(0, new int[0])]
        [TestCase(1, new int[] { 1 })]
        [TestCase(5, new int[] { 1, 2, 3, 4, 5 })]
        public void GetNumbersOneThru(int thru, IEnumerable<int> expected)
        {
            IEnumerable<int> actual = Program.GetNumbersOneThru(thru);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-3, 3, new int[] { -3, -2, -1, 0, 1, 2, 3 })]
        [TestCase(1, 5, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(90, 100, new int[] { 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 })]
        public void GetRangeThruInclusive(int start, int end, IEnumerable<int> expected)
        {
            IEnumerable<int> actual = Program.GetRangeThruInclusive(start, end);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-3, 3, new int[] { 2, 3 })]
        [TestCase(90, 100, new int[] { 97 })]
        public void GetPrimesInRangeInclusive(int start, int end, IEnumerable<int> expected)
        {
            IEnumerable<int> actual = Program.GetPrimesInRangeInclusive(start, end);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-1, false)]
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(42, false)]
        [TestCase(47, true)]
        [TestCase(97, true)]
        public void IsPrime(int number, bool expected)
        {
            bool actual = Program.IsPrime(number);

            Assert.That(actual, Is.EqualTo(expected));
        }


    }
}
