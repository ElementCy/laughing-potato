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
    public class IsUniqueTests
    {
        [TestMethod()]
        public void RunTest01()
        {
            IsUnique test = new IsUnique("It works!");
            var result = test.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest02()
        {
            IsUnique test = new IsUnique("This one will fail.");
            var result = test.Run();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void RunTest03()
        {
            IsUnique test = new IsUnique("");
            var result = test.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest04()
        {
            IsUnique test = new IsUnique(null);
            var result = test.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest05()
        {
            IsUnique test = new IsUnique("Dud");
            var result = test.Run();
            Assert.IsFalse(result);
        }
    }
}