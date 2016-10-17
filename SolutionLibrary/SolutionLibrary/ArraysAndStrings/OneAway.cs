using System;

namespace SolutionLibrary.ArraysAndStrings
{
    /// <summary>
    /// There are three types of edits that can be performed on strings, insert a character,
    /// remove a character, or replace a character. Given two strings,
    /// write a function to check if htey are one edit (or zero edits) away.
    /// </summary>
    public class OneAway
    {
        private string first;
        private string second;

        public OneAway(string s1, string s2)
        {
            first = s1;
            second = s2;
        }

        public bool Run()
        {
            if (string.IsNullOrEmpty(first) && string.IsNullOrEmpty(second))
                return true;

            if (string.IsNullOrEmpty(first) && second.Length == 1)
                return true;

            if (string.IsNullOrEmpty(second) && first.Length == 1)
                return true;

            if (string.IsNullOrEmpty(first) && second.Length > 1)
                return false;

            if (string.IsNullOrEmpty(second) && first.Length > 1)
                return false;

            if (Math.Abs(first.Length - second.Length) > 1)
                return false;

            first = first.ToLower();
            second = second.ToLower();

            int fIdx = 0;
            int sIdx = 0;

            int numChanges = 0;

            do
            {
                if (first[fIdx] != second[sIdx])
                {
                    numChanges++;
                    if (first.Length == second.Length)
                    {
                        fIdx++;
                        sIdx++;
                    }
                    else if (first.Length > second.Length)
                    {
                        fIdx++;
                    }else if(first.Length < second.Length)
                    {
                        sIdx++;
                    }
                }else
                {
                    fIdx++;
                    sIdx++;
                }

                if (numChanges > 1)
                    return false;

            } while (fIdx < first.Length && sIdx < second.Length);

            return true;
        }
    }
}
