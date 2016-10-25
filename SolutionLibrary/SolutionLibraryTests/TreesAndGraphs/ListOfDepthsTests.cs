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
    public class ListOfDepthsTests
    {
        private TreeNode<int> tree;

        [TestInitialize()]
        public void SetupTestGraphs()
        {
            TreeNode<int> n1 = new TreeNode<int>(9);
            TreeNode<int> n2 = new TreeNode<int>(18);
            TreeNode<int> n3 = new TreeNode<int>(3);
            TreeNode<int> n4 = new TreeNode<int>(7);
            TreeNode<int> n5 = new TreeNode<int>(5);
            TreeNode<int> n6 = new TreeNode<int>(20);
            tree = new TreeNode<int>(10);
            n5.Left = n1;
            n5.Right = n2;
            n6.Left = n3;
            n6.Right = n4;
            tree.Left = n5;
            tree.Right = n6;
        }

        [TestMethod()]
        public void RunTest01()
        {
            ListOfDepths test = new ListOfDepths(tree);
            var result = test.Run();
            Assert.IsTrue(result.Count == 3);
            Assert.IsTrue(result[0].Count == 1);
            Assert.IsTrue(result[1].Count == 2);
            Assert.IsTrue(result[2].Count == 4);
        }
    }
}