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
    public class StringCompressionTests
    {
        public const string Test01Result = "a2b1c5a3";
        public const string Test02Result = "aabcccccfghjkyreaaa";

        [TestMethod()]
        public void RunTest01()
        {
            StringCompression test = new StringCompression("aabcccccaaa");
            var result = test.Run();
            Assert.AreEqual(Test01Result, result);
        }

        [TestMethod()]
        public void RunTest02()
        {
            StringCompression test = new StringCompression("aabcccccfghjkyreaaa");
            var result = test.Run();
            Assert.AreEqual(Test02Result, result);
        }
    }
}