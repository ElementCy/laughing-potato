using System.Text;

namespace SolutionLibrary.ArraysAndStrings
{
    /// <summary>
    /// Implement a method to perform basic string compression using teh counts
    /// of repeated characters. If compressed string is longer than original, 
    /// return original string. Only upper/lower case a-z.
    /// </summary>
    public class StringCompression
    {
        private string theString;

        public StringCompression(string s)
        {
            theString = s;
        }

        public string Run()
        {
            StringBuilder str = new StringBuilder();

            int charCount = 1;
            char prevChar = theString[0];

            for(int i = 1; i < theString.Length; i++)
            {
                if (prevChar == theString[i])
                    charCount++;
                else
                {
                    str.Append(prevChar).Append(charCount);
                    prevChar = theString[i];
                    charCount = 1;
                }

                if (i == theString.Length - 1)
                    str.Append(prevChar).Append(charCount);
            }

            if(str.Length > theString.Length)
                return theString;

            return str.ToString();
        }
    }
}
