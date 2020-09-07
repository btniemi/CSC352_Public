namespace Acronym
{
    using System.Runtime.InteropServices;
    using System.Runtime.InteropServices.ComTypes;
    using Microsoft.VisualBasic;
    using NUnit.Framework;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class AcronymTests
    {
        [TestCase]
        public void Basic()
        {
            Assert.That(Acronym.Abbreviate("Portable Network Graphics"), Is.EqualTo("PNG"));
        }

        [TestCase]
        public void Lowercase_words()
        {
            Assert.That(Acronym.Abbreviate("Ruby on Rails"), Is.EqualTo("ROR"));
        }

        [TestCase]
        public void Punctuation()
        {
            Assert.That(Acronym.Abbreviate("First In, First Out"), Is.EqualTo("FIFO"));
        }

        [TestCase]
        public void All_caps_word()
        {
            //AAA
            //Arange, Act, Assert

            //Arange - Gather Test Data
            var arrangeTestData = "GUN Image Manipulation Program";
            var expectedResult = "GIMP";

            //Act-Preform some action
            var actualResult = Acronym.Abbreviate(arrangeTestData);

            //Assert - Check your results against what is expected
            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }


        [TestCase]
        public void Punctuation_without_whitespace()
        {
            Assert.That(Acronym.Abbreviate("Complementary metal-oxide semiconductor"), Is.EqualTo("CMOS"));
        }

        [TestCase]
        public void Very_long_abbreviation()
        {
            Assert.That(Acronym.Abbreviate("Rolling On The Floor Laughing So Hard That My Dogs Came Over And Licked Me"), Is.EqualTo("ROTFLSHTMDCOALM"));
        }

        [TestCase]
        public void Consecutive_delimiters()
        {
            Assert.That(Acronym.Abbreviate("Something - I made up from thin air"), Is.EqualTo("SIMUFTA"));
        }

        [TestCase]
        public void Apostrophes()
        {
            Assert.That(Acronym.Abbreviate("Halley's Comet"), Is.EqualTo("HC"));
        }

        [TestCase]
        public void Underscore_emphasis()
        {
            Assert.That(Acronym.Abbreviate("The Road _Not_ Taken"), Is.EqualTo("TRNT"));
        }

        [TestCase]
        public void Underscore_Double_emphasis()
        {
            Assert.That(Acronym.Abbreviate("The Road __Not_ Taken"), Is.EqualTo("TRNT"));
        }

        [TestCase]
        public void Numbers_In_Name()
        {
            // AAA
            var arrange = "This 1 Acronmym Has 2 Numbers";

            var actual = Acronym.Abbreviate(arrange);

            var expected = "T1AH2N";

            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase]
        public void specialCharacter_In_Name()
        {
            // AAA
            var arrange = "This Acronmym Has !";

            var actual = Acronym.Abbreviate(arrange);

            var expected = "TAH!";

            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase("Indexed Simple Access Mapping", "ISAM")] //this is the same as making and coping the test cases over and over

        public void TestFunction(string input, string expected)
        {
            Assert.That(Acronym.Abbreviate(input), Is.EqualTo(expected));
        }


    }
}
