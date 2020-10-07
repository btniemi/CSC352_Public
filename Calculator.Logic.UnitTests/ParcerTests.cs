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
        [TestCase("1 + 1", "1 1 +")]
        public void ConvertToRPN_ValidInput(string input, string expected)
        {
            //Arrange
            //taken care of in arguments

            //Act
            string actual = Parser.ConvertToRPN(input);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("^", "^", true)]
        [TestCase("^", "+", false)]
        [TestCase("^", "-", false)]
        [TestCase("^", "*", false)]
        [TestCase("^", "/", false)]
        [TestCase("+", "^", false)]
        [TestCase("+", "+", true)]
        [TestCase("+", "-", true)]
        [TestCase("+", "*", false)]
        [TestCase("+", "/", false)]
        [TestCase("-", "", )]
        [TestCase("-", "", )]
        [TestCase("-", "", )]
        [TestCase("-", "", )]
        [TestCase("-", "", )]
        [TestCase("*", "", )]
        [TestCase("*", "", )]
        [TestCase("*", "", )]
        [TestCase("*", "", )]
        [TestCase("*", "", )]
        [TestCase("/", "", )]
        [TestCase("/", "", )]
        [TestCase("/", "", )]
        [TestCase("/", "", )]
        [TestCase("/", "", )]
        public void OperatorHasEqualPrecidence_ValidInput(string op1, string op2, bool expected)
        {
            bool actual = Parser.OperatorHasEqualPrecidence(op1, op2);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
