namespace SolutionLibrary.TreesAndGraphs
{
    public enum NodeState
    {
        NotVisited,
        Visited,
        Visiting
    }

    public class Graph
    {
        public Node[] Nodes;
    }

    public class Node
    {
        public string Name;
        public Node[] Children;
        public NodeState NodeState;

        public Node(string name)
        {
            Name = name;
            Children = null;
        }

        public Node(string name, Node[] children)
        {
            Name = name;
            Children = children;
        }
    }

    public class TreeNode<T>
    {
        public T Value;
        public TreeNode<T> Left;
        public TreeNode<T> Right;
        public NodeState NodeState;

        public TreeNode(T val)
        {
            Value = val;
            Left = null;
            Right = null;
        }
    }
}
