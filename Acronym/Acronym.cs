namespace Acronym
{
    using System;
    using System.Text;

    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            StringBuilder sb = new StringBuilder();

            char[] delimiters = new char[] { ' ', '-', '_' };
            string[] splitPhrase = phrase.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach(string subphrase in splitPhrase)
            {
                char firstCharacter = subphrase[0];
                sb.Append(firstCharacter);
            }

            return sb.ToString().ToUpper();

        }
    }
}
