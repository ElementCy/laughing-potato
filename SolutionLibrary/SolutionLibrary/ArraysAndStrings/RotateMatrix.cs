namespace SolutionLibrary.ArraysAndStrings
{
    /// <summary>
    /// Given an image represented by an NxN matrix, where each pixel in the image is 4
    /// bytes, write a method to rotate the image by 90 degrees.
    /// </summary>
    public class RotateMatrix
    {
        private int[][] imageMatrix;

        public RotateMatrix(int[][] matrix)
        {
            imageMatrix = matrix;
        }

        public int[][] Run()
        {
            if (imageMatrix.Length == 0 || imageMatrix.Length != imageMatrix[0].Length)
                return null;

            int n = imageMatrix.Length;

            for(int rc = 0; rc < n/2; rc++)
            {
                // first row/column
                int frc = rc;
                // last row/column
                int lrc = n - 1 - rc;

                for(int i = frc; i < lrc; i++)
                {
                    int offset = i - frc;

                    int top = imageMatrix[frc][i];
                    // left to top
                    imageMatrix[frc][i] = imageMatrix[lrc - offset][frc];
                    // bottom to left
                    imageMatrix[lrc - offset][frc] = imageMatrix[lrc][lrc - offset];
                    // right to bottom
                    imageMatrix[lrc][lrc - offset] = imageMatrix[i][lrc];
                    // top to right
                    imageMatrix[i][lrc] = top;
                }

            }
            return imageMatrix;
        }
    }
}
