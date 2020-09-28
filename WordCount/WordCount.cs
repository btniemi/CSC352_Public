// <copyright file="UnitTests.cs" company="Ace Olszowka">
// Copyright (c) 2020 Ace Olszowka.
// </copyright>

namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using NUnit.Framework.Interfaces;

    public static class WordCount
    {
        public static IDictionary<string, int> CountWords(string phrase)
        {
            char[] delimeters = new char[] { ' ', ',', '\n' };
            string[] splitPhrase = phrase.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> CountTheOccurances = new Dictionary<string, int>();
            for (int i = 0; i < splitPhrase.Length; i++)                                       // Loop the splited string  
            {
                if (CountTheOccurances.ContainsKey(splitPhrase[i]))                           // Check if word is already in dictionary update the count  
                {
                    int value = CountTheOccurances[splitPhrase[i]];
                    CountTheOccurances[splitPhrase[i]] = value + 1;
                }
                else                                                                     // If we found the same word we just increase the count in the dictionary 
                {
                    CountTheOccurances.Add(splitPhrase[i], 1);
                }
            }

            foreach (KeyValuePair<string, int> kvp in CountTheOccurances)
            {
                string v = $"Counts: {kvp.Value}for {kvp.Key}";
                return v;
            }




        }
    }
}
