using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    internal class Kata
    {

        internal static bool IsPangram(string v)
        {
            Dictionary<string, int> letterFrequency = new Dictionary<string, int>()
            {
                {"a", 0 },
                {"b", 0 },
                {"c", 0 },
                {"d", 0 },
                {"e", 0 },
                {"f", 0 },
                {"g", 0 },
                {"h", 0 },
                {"i", 0 },
                {"j", 0 },
                {"k", 0 },
                {"l", 0 },
                {"m", 0 },
                {"n", 0 },
                {"o", 0 },
                {"p", 0 },
                {"q", 0 },
                {"r", 0 },
                {"s", 0 },
                {"t", 0 },
                {"u", 0 },
                {"v", 0 },
                {"w", 0 },
                {"x", 0 },
                {"y", 0 },
                {"z", 0 },
            };

            foreach(char currentChar in v)
            {
                string lowerChar = currentChar.ToString().ToLower();
                if (letterFrequency.ContainsKey(lowerChar))
                {
                    letterFrequency[lowerChar]++;
                }
            }

            //return !letterFrequency.Any(kvp => kvp.Value == 0);
            return letterFrequency.Where(kvp => kvp.Value == 0).ToArray().Length == 0;
        }
    }
}
