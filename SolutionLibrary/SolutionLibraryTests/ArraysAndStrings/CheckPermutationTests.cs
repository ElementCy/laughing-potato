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
    public class CheckPermutationTests
    {
        [TestMethod()]
        public void RunTest01()
        {
            CheckPermutation cp = new CheckPermutation("abc", "cba");
            var result = cp.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest02()
        {
            CheckPermutation cp = new CheckPermutation("", "");
            var result = cp.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest03()
        {
            CheckPermutation cp = new CheckPermutation(null, null);
            var result = cp.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest04()
        {
            CheckPermutation cp = new CheckPermutation("", "cba");
            var result = cp.Run();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void RunTest05()
        {
            CheckPermutation cp = new CheckPermutation(null, "cba");
            var result = cp.Run();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void RunTest06()
        {
            CheckPermutation cp = new CheckPermutation("cba", "");
            var result = cp.Run();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void RunTest07()
        {
            CheckPermutation cp = new CheckPermutation("cba", null);
            var result = cp.Run();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void RunTest08()
        {
            CheckPermutation cp = new CheckPermutation("abc", "aab");
            var result = cp.Run();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void RunTest09()
        {
            CheckPermutation cp = new CheckPermutation("abc", "cbb");
            var result = cp.Run();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void RunTest10()
        {
            CheckPermutation cp = new CheckPermutation("abcasdffe", "cbb");
            var result = cp.Run();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void RunTest11()
        {
            CheckPermutation cp = new CheckPermutation("asdf", "afewfs");
            var result = cp.Run();
            Assert.IsFalse(result);
        }
    }
}