﻿// <copyright file="UnitTests.cs" company="Ace Olszowka">
// Copyright (c) 2019 Exercise - Original XUnit Implementation
// Copyright (c) 2020 Ace Olszowka - Conversion to NUnit
// </copyright>

namespace WordCount
{
    using NUnit.Framework;
    using NUnit.Framework.Constraints;
    using System.Collections.Generic;
    using System.ComponentModel;

    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class WordCountTests
    {
        [Test]
        public void Count_one_word()
        {
            IDictionary<string, int> actual = WordCount.CountWords("word");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["word"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_one_of_each_word()
        {
            IDictionary<string, int> actual = WordCount.CountWords("one of each");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["of"] = 1,
                ["each"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Multiple_occurrences_of_a_word()
        {
            IDictionary<string, int> actual = WordCount.CountWords("one fish two fish red fish blue fish");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["fish"] = 4,
                ["two"] = 1,
                ["red"] = 1,
                ["blue"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Handles_cramped_lists()
        {
            IDictionary<string, int> actual = WordCount.CountWords("one,two,three");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 1,
                ["three"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Handles_expanded_lists()
        {
            IDictionary<string, int> actual = WordCount.CountWords("one,\ntwo,\nthree");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 1,
                ["three"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Ignore_punctuation()
        {
            IDictionary<string, int> actual = WordCount.CountWords("car: carpet as java: javascript!!&@$%^&");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["car"] = 1,
                ["carpet"] = 1,
                ["as"] = 1,
                ["java"] = 1,
                ["javascript"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Include_numbers()
        {
            IDictionary<string, int> actual = WordCount.CountWords("testing, 1, 2 testing");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["testing"] = 2,
                ["1"] = 1,
                ["2"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Normalize_case()
        {
            IDictionary<string, int> actual = WordCount.CountWords("go Go GO Stop stop");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["go"] = 3,
                ["stop"] = 2
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_apostrophes()
        {
            IDictionary<string, int> actual = WordCount.CountWords("First: don't laugh. Then: don't cry.");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["first"] = 1,
                ["don't"] = 2,
                ["laugh"] = 1,
                ["then"] = 1,
                ["cry"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_quotations()
        {
            IDictionary<string, int> actual = WordCount.CountWords("Joe can't tell between 'large' and large.");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["joe"] = 1,
                ["can't"] = 1,
                ["tell"] = 1,
                ["between"] = 1,
                ["large"] = 2,
                ["and"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_quotations_and_contractions()
        {
            IDictionary<string, int> actual = WordCount.CountWords("Joe 'don't' know what is don't.");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["joe"] = 1,
                ["don't"] = 2,
                ["know"] = 1,
                ["what"] = 1,
                ["is"] = 1,
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_plural_possive_noun()
        {
            IDictionary<string, int> actual = WordCount.CountWords("The cats' meow");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["the"] = 1,
                ["cats'"] = 1,  //specific corner case that is hard to represent
                ["meow"] = 1,
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void With_quotations_multiwords()
        {
            IDictionary<string, int> actual = WordCount.CountWords("Joe 'don't know' what is don't.");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["joe"] = 1,
                ["don't"] = 2,
                ["know"] = 1,
                ["what"] = 1,
                ["is"] = 1,
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Substrings_from_the_beginning()
        {
            IDictionary<string, int> actual = WordCount.CountWords("Joe can't tell between app, apple and a.");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["joe"] = 1,
                ["can't"] = 1,
                ["tell"] = 1,
                ["between"] = 1,
                ["app"] = 1,
                ["apple"] = 1,
                ["and"] = 1,
                ["a"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Multiple_spaces_not_detected_as_a_word()
        {
            IDictionary<string, int> actual = WordCount.CountWords(" multiple   whitespaces");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["multiple"] = 1,
                ["whitespaces"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Alternating_word_separators_not_detected_as_a_word()
        {
            IDictionary<string, int> actual = WordCount.CountWords(",\n,one,\n ,two \n 'three'");
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                ["one"] = 1,
                ["two"] = 1,
                ["three"] = 1
            };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("apple.", "apple")]
        [TestCase("apple,", "apple")]
        [TestCase("apple!", "apple")]
        [TestCase("apple?", "apple")]
        public void TestSanitizeMethod(string input, string expected)
        {
            //Arrange
            //this is done as part of the arguments coming in

            //Act
            string actual = WordCount.SanitizePhrase(input);

            //Assert
            Assert.That(actual, Is.EqualTo(expected)); 
        }
    }
}
