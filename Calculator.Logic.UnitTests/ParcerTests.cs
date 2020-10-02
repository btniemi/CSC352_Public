using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Logic.UnitTests
{
    [TestFixture]
    public class ParcerTests
    {
        [TestCase ("1=1", 2)]
        public void Parcse_ValidInput(string input, int expected)
        {
            //Arrange
            //taken care of in arguments

            //Act
            int actual = Parser.Parse(input);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
