using System.Collections.Generic;

namespace SolutionLibrary.TreesAndGraphs
{
    public class RouteBetweenNodes
    {
        private Graph graph;
        private Node start;
        private Node end;

        public RouteBetweenNodes(Graph graph, Node start, Node end)
        {
            this.graph = graph;
            this.start = start;
            this.end = end;
        }

        public bool Run()
        {
            if (start == end)
                return true;

            Queue<Node> queue = new Queue<Node>();

            foreach(Node aNode in graph.Nodes)
            {
                aNode.NodeState = NodeState.NotVisited;
            }

            start.NodeState = NodeState.Visiting;

            queue.Enqueue(start);

            Node n;
            while(queue.Count > 0)
            {
                n = queue.Dequeue();

                if(n != null)
                {
                    if (n.Children != null)
                    {
                        foreach (Node a in n.Children)
                        {
                            if (a.NodeState == NodeState.NotVisited)
                            {
                                if (a == end)
                                {
                                    return true;
                                }
                                else
                                {
                                    a.NodeState = NodeState.Visiting;
                                    queue.Enqueue(a);
                                }
                            }
                        }
                    }

                    n.NodeState = NodeState.Visited;
                }
            }

            return false;
        }
    }
}
