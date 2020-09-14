using System;
using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using NUnit.Framework;

namespace CreatePhoneNumber
{
    [TestFixture]
    public class UnitTests
    {
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "(000) 000-0000")]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "(012) 345-6789")]

        public void ValidInputs(int[] numbers, string expected)
        {
            // Act
            string actual = Logic.TranslateToPhoneNumber(numbers);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
