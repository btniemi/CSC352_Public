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
        [TestCase("( 2 + 2 ) ^ 2", "2 2 + 2 ^")]
        [TestCase("3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3", "3 4 2 * 1 5 - 2 3 ^ ^ / +")]
        //[TestCase("1 + 2 + 3", "123++" )] // does not work but is RPN equivalant
        [TestCase("1 + 2 + 3", "1 2 + 3 +")]
        [TestCase("1 + sqrt ( 4 )", "1 4 sqrt +")]
        [TestCase("1 + sqrt ( 2 ^ 2 )", "1 2 2 ^ sqrt +")]
        [TestCase("1 + sqrt ( sqrt ( ( 2 ^ 2 + 2 ) ) )", "1 2 2 ^ 2 + sqrt sqrt +")]

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
        [TestCase("-", "^", false)]
        [TestCase("-", "+", true)]
        [TestCase("-", "-", true)]
        [TestCase("-", "*", false)]
        [TestCase("-", "/", false)]
        [TestCase("*", "^", false)]
        [TestCase("*", "+", false)]
        [TestCase("*", "-", false)]
        [TestCase("*", "*", true)]
        [TestCase("*", "/", true)]
        [TestCase("/", "^", false)]
        [TestCase("/", "+", false)]
        [TestCase("/", "-", false)]
        [TestCase("/", "*", true)]
        [TestCase("/", "/", true)]
        public void OperatorHasEqualPrecidence_ValidInput(string op1, string op2, bool expected)
        {
            bool actual = Parser.OperatorHasEqualPrecidence(op1, op2);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("^", "^", false)]
        [TestCase("^", "+", true)]
        [TestCase("^", "-", true)]
        [TestCase("^", "*", true)]
        [TestCase("^", "/", true)]
        [TestCase("+", "^", false)]
        [TestCase("+", "+", false)]
        [TestCase("+", "-", false)]
        [TestCase("+", "*", false)]
        [TestCase("+", "/", false)]
        [TestCase("-", "^", false)]
        [TestCase("-", "+", false)]
        [TestCase("-", "-", false)]
        [TestCase("-", "*", false)]
        [TestCase("-", "/", false)]
        [TestCase("*", "^", false)]
        [TestCase("*", "+", true)]
        [TestCase("*", "-", true)]
        [TestCase("*", "*", false)]
        [TestCase("*", "/", false)]
        [TestCase("/", "^", false)]
        [TestCase("/", "+", true)]
        [TestCase("/", "-", true)]
        [TestCase("/", "*", false)]
        [TestCase("/", "/", false)]
        public void OperatorHasGreaterPrecidence_ValidInput(string op1, string op2, bool expected)
        {
            bool actual = Parser.OperatorHasGreaterPrecidence(op1, op2);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
