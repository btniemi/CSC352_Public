// <copyright file="UnitTests.cs" company="Ace Olszowka">
// Copyright (c) 2020 Ace Olszowka.
// </copyright>

namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Xml.XPath;
    using NUnit.Framework.Interfaces;

    public static class WordCount
    {
        public static IDictionary<string, int> CountWords(string phrase)
        {
            IDictionary<string, int> dictionary = new Dictionary<string, int>();

            string[] splitCharacters =
                new string[] 
                {
                    " ",
                    ",",
                    "\n",
                };

            string[] splitPhrases = phrase.Split(splitCharacters, StringSplitOptions.RemoveEmptyEntries);

            foreach (string splitPhrase in splitPhrases)
            {
                string sanitizedPhrase = SanitizePhrase(splitPhrase);

                if (dictionary.ContainsKey(sanitizedPhrase))
                {
                    dictionary[sanitizedPhrase] += 1;      //indexing into dictionary and give me index of place shown by this phrase
                }
                else
                {
                    dictionary.Add(sanitizedPhrase, 1);    //add this to the dictionary and increase the value by one
                }
            }

            return dictionary;

        }

        internal static string SanitizePhrase(string splitPhrase)
        {
            string[] forbiddenCharacters = 
                new string[] 
                {
                    "!",
                    "@",
                    "#",
                    "$",
                    "%",
                    "^",
                    "&",
                    "*",
                    "?",
                    ":",
                    ",",
                    ".",
                };

            foreach (string forbiddenChar in forbiddenCharacters)
            {
                splitPhrase = splitPhrase.Replace(forbiddenChar, string.Empty);
            }
            return splitPhrase.ToLower();
        }
    }
}
