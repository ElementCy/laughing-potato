namespace SolutionLibrary.TreesAndGraphs
{
    public class MinimalTree
    {
        private int[] dataToPopulate;

        public MinimalTree(int[] data)
        {
            dataToPopulate = data;
        }

        public TreeNode<int> Run()
        {
            return CreateTree(dataToPopulate, 0, dataToPopulate.Length-1);
        }

        private TreeNode<int> CreateTree(int[] arr, int start, int end)
        {
            if (end < start) return null;

            int mid = (start + end) / 2;
            TreeNode<int> n = new TreeNode<int>(arr[mid]);
            n.Left = CreateTree(arr, start, mid - 1);
            n.Right = CreateTree(arr, mid + 1, end);
            return n;
        }
    }
}
