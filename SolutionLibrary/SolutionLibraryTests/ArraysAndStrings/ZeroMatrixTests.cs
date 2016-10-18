using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionLibrary.ArraysAndStrings;
using SolutionLibraryTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionLibrary.ArraysAndStrings.Tests
{
    [TestClass()]
    public class ZeroMatrixTests
    {
        public readonly int[][] Test01Matrix = new int[][] { new int[] { 1, 2, 3, 4, 0 }, new int[] { 5, 0, 6, 7, 8 }, new int[] { 9, 1, 10, 11, 2 }, new int[] { 0, 4, 1, 6, 9 } };
        public readonly int[][] Test01Result = new int[][] { new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 10, 11, 0 }, new int[] { 0, 0, 0, 0, 0 } };

        [TestMethod()]
        public void RunTest01()
        {
            ZeroMatrix test = new ZeroMatrix(Test01Matrix);
            var result = test.Run();
            CollectionAssert.AreEqual(result, Test01Result, new CollectionAssertComperator());
        }
    }
}