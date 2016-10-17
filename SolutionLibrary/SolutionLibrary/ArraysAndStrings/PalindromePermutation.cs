using System.Collections.Generic;

namespace SolutionLibrary.ArraysAndStrings
{
    /// <summary>
    /// Given a string, write a function to check if it is a permutation of a palindrome.
    /// </summary>
    public class PalindromePermutation
    {
        private string theString;

        public PalindromePermutation(string s)
        {
            theString = s;
        }

        public bool Run()
        {
            if (string.IsNullOrEmpty(theString))
                return false;

            theString = theString.ToLower();

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            for(int i = 0; i < theString.Length; i++)
            {
                if (theString[i] == ' ')
                    continue;

                if (!charCount.ContainsKey(theString[i]))
                    charCount.Add(theString[i], 1);
                else
                    charCount[theString[i]]++;
            }

            int numOdd = 0;

            foreach(KeyValuePair<char, int> kvp in charCount)
            {
                if (kvp.Value % 2 != 0)
                    numOdd++;

                if (numOdd > 1)
                    return false;
            }

            return true;
        }
    }
}
