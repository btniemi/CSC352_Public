using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FunWithClasses
{
    [TestFixture]
    public class UnitTests
    {
        [TestCase("ace", "Ace")]
        public void TestFirstNameProperty(string input, string expected)
        {
            //Arrange
            Person person = new Person();
            //Act
            person.FirstName = input;
            person.LastName = "Olzsweska";
            //Assert
            Assert.That(person.FirstName, Is.EqualTo(expected));
        }
    }
}
