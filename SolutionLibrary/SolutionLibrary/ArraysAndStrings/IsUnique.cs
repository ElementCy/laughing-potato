using System.Collections.Generic;

namespace SolutionLibrary.ArraysAndStrings
{
    /// <summary>
    /// Implement an algorithm to determine if a string has all unique characters.
    /// </summary>
    public class IsUnique
    {
        private string theString;

        public IsUnique(string s)
        {
            theString = s;
        }

        public bool Run()
        {
            if (string.IsNullOrEmpty(theString))
                return true;

            // We want to treat Caps as the same as Lower.
            theString = theString.ToLower();

            HashSet<char> characters = new HashSet<char>();

            for(int i = 0; i < theString.Length; i++)
            {
                if(!characters.Add(theString[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
