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
