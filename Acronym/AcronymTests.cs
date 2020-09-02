namespace Acronym
{
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
            Assert.That(Acronym.Abbreviate("GNU Image Manipulation Program"), Is.EqualTo("GIMP"));
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
    }
}
