namespace Acronym
{
    using System;
    using System.Text;

    public static class Acronym
    {
        public static string Abbreviate(string phrase)
        {
            StringBuilder sb = new StringBuilder();

            string[] splitPhrase = phrase.Split(' ');

            foreach(string subphrase in splitPhrase)
            {
                char firstCharacter = subphrase[0];
                sb.Append(firstCharacter);
            }

            return sb.ToString().ToUpper();

        }
    }
}
