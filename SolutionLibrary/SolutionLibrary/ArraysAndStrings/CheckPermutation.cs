using System;

namespace SolutionLibrary.ArraysAndStrings
{
    /// <summary>
    /// Given two strings, write a method to decide if one is a permutation fo the other.
    /// </summary>
    public class CheckPermutation
    {
        private string first;
        private string second;

        public CheckPermutation(string s1, string s2)
        {
            first = s1;
            second = s2;
        }

        private string SortString(string s)
        {
            char[] c = s.ToCharArray();
            Array.Sort(c);
            return string.Concat(c);
        }

        public bool Run()
        {
            if (string.IsNullOrEmpty(first) && string.IsNullOrEmpty(second))
                return true;

            if (string.IsNullOrEmpty(first) && !string.IsNullOrEmpty(second))
                return false;

            if (!string.IsNullOrEmpty(first) && string.IsNullOrEmpty(second))
                return false;

            if (first.Length != second.Length)
                return false;

            return SortString(first).Equals(SortString(second));
        }
    }
}
