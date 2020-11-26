namespace Solution
{
    using NUnit.Framework;

    using System;

    [TestFixture]
    public class Tests
    {
        [TestCase("The quick brown fox jumps over the lazy dog.", true)]
        [TestCase("The dog is a man under those hairy cloths.", false)]
        [TestCase("abcdefghijklmnopqrstuvwxyz", true)]
        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", true)]


        public void SampleTests(string testString, bool expected)
        {
            Assert.AreEqual(expected, Kata.IsPangram(testString));
        }
    }
}


