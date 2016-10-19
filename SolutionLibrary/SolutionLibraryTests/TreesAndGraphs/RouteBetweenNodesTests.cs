using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionLibrary.TreesAndGraphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionLibrary.TreesAndGraphs.Tests
{
    [TestClass()]
    public class RouteBetweenNodesTests
    {
        private Graph graph;
        private Node start;
        private Node end;

        [TestInitialize()]
        public void SetupTestGraphs()
        {
            Node[] nodes = new Node[6];
            Node node0 = new Node("0");
            node0.Children = new Node[3];
            Node node1 = new Node("1");
            node1.Children = new Node[2];
            Node node2 = new Node("2");
            node2.Children = new Node[1];
            Node node3 = new Node("3");
            node3.Children = new Node[2];
            Node node4 = new Node("4");
            Node node5 = new Node("5");

            node0.Children[2] = node5;
            node0.Children[1] = node4;
            node0.Children[0] = node1;
            node1.Children[1] = node3;
            node1.Children[0] = node4;
            node2.Children[0] = node1;
            node3.Children[1] = node2;
            node3.Children[0] = node4;

            nodes[0] = node0;
            nodes[1] = node1;
            nodes[2] = node2;
            nodes[3] = node3;
            nodes[4] = node4;
            nodes[5] = node5;

            start = node0;
            end = node3;
            graph = new Graph();
            graph.Nodes = nodes;
        }

        [TestMethod()]
        public void RunTest01()
        {
            RouteBetweenNodes test = new RouteBetweenNodes(graph, start, end);
            var result = test.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest02()
        {
            RouteBetweenNodes test = new RouteBetweenNodes(graph, graph.Nodes[5], end);
            var result = test.Run();
            Assert.IsFalse(result);
        }
    }
}