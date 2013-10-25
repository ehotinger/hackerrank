using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRank
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual("IPv4", Solution.GetIpType("128.128.128.12"));
            Assert.AreEqual("Neither", Solution.GetIpType("This line has junk text."));
            Assert.AreEqual("IPv6", Solution.GetIpType("2001:0db8:0000:0000:0000:ff00:0042:8329"));
        }
        
    }
}
