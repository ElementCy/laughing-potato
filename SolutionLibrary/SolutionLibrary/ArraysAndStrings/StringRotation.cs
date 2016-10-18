namespace SolutionLibrary.ArraysAndStrings
{
    /// <summary>
    /// Assume you have a method IsSubstring which checks if one word is asubstring of another.
    /// Given two strings, s1 and s2, write code to check if s2 is a rotation fo s1 using only one
    /// call to isSubstring.
    /// </summary>
    public class StringRotation
    {
        private string s1;
        private string s2;

        public StringRotation(string s1, string s2)
        {
            this.s1 = s1;
            this.s2 = s2;
        }

        public bool Run()
        {
            // typewriter
            // writertype

            // if we append s1 to s1, we get 
            // typewritertypewriter
            // s2 is in the middle of that.
            // if it isn't, then it isn't a rotation.
            int length = s1.Length;
            if (length == s2.Length && length > 0)
            {
                string s3 = s1 + s1;
                return isSubstring(s3, s2);
            }
            return false;
        }

        private bool isSubstring(string orig, string sub)
        {
            return orig.Contains(sub);
        }
    }
}
