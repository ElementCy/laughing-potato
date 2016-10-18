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
    public class StringRotationTests
    {
        [TestMethod()]
        public void RunTest01()
        {
            StringRotation test = new StringRotation("typewriter", "writertype");
            var result = test.Run();
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void RunTest02()
        {
            StringRotation test = new StringRotation("bottlewater", "bottlterewa");
            var result = test.Run();
            Assert.IsFalse(result);
        }
    }
}