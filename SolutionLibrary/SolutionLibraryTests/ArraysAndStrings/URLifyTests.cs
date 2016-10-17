using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionLibrary.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionLibrary.ArraysAndStrings.Tests
{
    [TestClass()]
    public class URLifyTests
    {
        public readonly char[] Test01Result = new char[] { 'H', 'e', 'l', 'l', 'o', '%', '2', '0', 'T', 'h', 'e', 'r', 'e' };

        [TestMethod()]
        public void RunTest01()
        {
            URLify test = new URLify("Hello There  ".ToCharArray(), 11);
            var result = test.Run();
            CollectionAssert.AreEqual(Test01Result, result);
        }
    }
}