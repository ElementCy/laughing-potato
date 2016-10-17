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
    public class PalindromePermutationTests
    {
        [TestMethod()]
        public void RunTest01()
        {
            PalindromePermutation test = new PalindromePermutation("tact coa");
            var result = test.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest02()
        {
            PalindromePermutation test = new PalindromePermutation("hello world");
            var result = test.Run();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void RunTest03()
        {
            PalindromePermutation test = new PalindromePermutation("Tact Coa");
            var result = test.Run();
            Assert.IsTrue(result);
        }
    }
}