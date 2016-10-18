namespace SolutionLibrary.ArraysAndStrings
{
    /// <summary>
    /// Write an algorithm such that if an element in an MxN matrix is 0, the entire row and column are set to 0.
    /// </summary>
    public class ZeroMatrix
    {
        private int[][] matrix;

        public ZeroMatrix(int[][] matrix)
        {
            this.matrix = matrix;
        }

        public int[][] Run()
        {
            if (matrix.Length < 1)
                return null;

            bool[] row = new bool[matrix.Length];
            bool[] cols = new bool[matrix[0].Length];

            for(int x = 0; x < matrix.Length; x++)
            {
                for(int y = 0; y < matrix[x].Length; y++)
                {
                    if(matrix[x][y] == 0)
                    {
                        row[x] = true;
                        cols[y] = true;
                    }
                }
            }

            for(int i = 0; i < row.Length; i++)
            {
                if (row[i])
                    ZeroRow(i);
            }

            for(int i = 0; i < cols.Length; i++)
            {
                if (cols[i])
                    ZeroColumn(i);
            }

            return matrix;
        }

        private void ZeroRow(int row)
        {
            for(int i = 0; i < matrix[row].Length; i++)
            {
                matrix[row][i] = 0;
            }
        }

        private void ZeroColumn(int col)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][col] = 0;
            }
        }
    }
}
