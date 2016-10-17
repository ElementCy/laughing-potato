namespace SolutionLibrary.ArraysAndStrings
{
    /// <summary>
    /// Write a method to replace all spaces in a string with '%20'.
    /// You may assume that the string has sufficient space at the end to hold
    /// the additional characters, and that you are given the "true" length of the string.
    /// (Using a char array instead of a string, so has set length)
    /// </summary>
    public class URLify
    {
        private char[] rawString;
        private int trueSize;

        public URLify(char[] ca, int size)
        {
            rawString = ca;
            trueSize = size;
        }

        public char[] Run()
        {
            int numSpaces = 0;
            for(int i = 0; i < trueSize; i++)
            {
                if (rawString[i] == ' ')
                    numSpaces++;
            }

            int idx = trueSize + (numSpaces * 2);

            for(int i = trueSize -1; i >= 0; i--)
            {
                if (rawString[i] == ' ')
                {
                    rawString[idx - 1] = '0';
                    rawString[idx - 2] = '2';
                    rawString[idx - 3] = '%';
                    idx -= 3;
                }
                else
                {
                    rawString[idx-1] = rawString[i];
                    idx--;
                }
            }
            return rawString;
        }
    }
}
