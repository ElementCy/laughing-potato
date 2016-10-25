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
    public class MinimalTreeTests
    {
        private int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestMethod()]
        public void RunTest01()
        {
            MinimalTree test = new MinimalTree(data);
            var result = test.Run();
            int depth = MaxDepth(result);
            Assert.IsTrue(depth == 4);
            Assert.IsTrue(result.Value == 5);
        }

        private int MaxDepth(TreeNode<int> node)
        {
            if (node == null)
            {
                return (0);
            }
            else
            {
                // compute the depth of each subtree
                int leftDepth = MaxDepth(node.Left);
                int rightDepth = MaxDepth(node.Right);
                // use the larger one
                if (leftDepth > rightDepth)
                    return (leftDepth + 1);
                else
                    return (rightDepth + 1);
            }
        }
    }
}