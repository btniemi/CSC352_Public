using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Logic.UnitTests
{
    [TestFixture]
    class EvaluateTests
    {
        [TestCase("1 1 +", 2)]
        [TestCase("1 2 3 + -", -4)]
        [TestCase("3 4 2 * 1 5 - 2 3 ^ ^ / +", 3.0001220703125)]
        public void Evaluate_ValidInput(string input, double expected)
        {
            //Arrange
            //taken care of in arguments

            //Act
            double actual = Evaluate.EvaluateRPN(input);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
