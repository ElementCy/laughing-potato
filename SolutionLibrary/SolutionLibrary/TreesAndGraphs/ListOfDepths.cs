using System.Collections.Generic;

namespace SolutionLibrary.TreesAndGraphs
{
    public class ListOfDepths
    {
        private TreeNode<int> tree;

        public ListOfDepths(TreeNode<int> tree)
        {
            this.tree = tree;
        }

        public List<LinkedList<TreeNode<int>>> Run()
        {
            List<LinkedList<TreeNode<int>>> result = new List<LinkedList<TreeNode<int>>>();
            LinkedList<TreeNode<int>> cur = new LinkedList<TreeNode<int>>();

            if (tree != null)
                cur.AddFirst(tree);

            while(cur.Count > 0)
            {
                result.Add(cur);
                LinkedList<TreeNode<int>> nodes = cur;
                cur = new LinkedList<TreeNode<int>>();
                foreach(TreeNode<int> n in nodes)
                {
                    if (n.Left != null)
                        cur.AddLast(n.Left);
                    if (n.Right != null)
                        cur.AddLast(n.Right);
                }
            }
            return result;
        }
    }
}
