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
    public class OneAwayTests
    {
        [TestMethod()]
        public void RunTest01()
        {
            OneAway test = new OneAway("pale", "ple");
            var result = test.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest02()
        {
            OneAway test = new OneAway("pales", "pale");
            var result = test.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest03()
        {
            OneAway test = new OneAway("pale", "bale");
            var result = test.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest04()
        {
            OneAway test = new OneAway("pale", "bake");
            var result = test.Run();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void RunTest05()
        {
            OneAway test = new OneAway("payles", "pale");
            var result = test.Run();
            Assert.IsFalse(result);
        }
    }
}