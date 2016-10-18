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
    public class RotateMatrixTests
    {

        public readonly int[][] Test01Matrix = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 }, new int[] { 13, 14, 15, 16 } };
        public readonly int[][] Test01Result = new int[][] { new int[] { 13, 9, 5, 1 }, new int[] { 14, 10, 6, 2 }, new int[] { 15, 11, 7, 3 }, new int[] { 16, 12, 8, 4 } };

        [TestMethod()]
        public void RunTest01()
        {
            RotateMatrix test = new RotateMatrix(Test01Matrix);
            var result = test.Run();
            CollectionAssert.AreEqual(result, Test01Result, new CollectionAssertComperator());
        }
    }
}