using FindHackerRank;
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
        public void TestHackerRank()
        {
            Assert.AreEqual(2, Solution.FindHackerRank("i love hackerrank"));
            Assert.AreEqual(1, Solution.FindHackerRank("hackerrank is an awesome place for programmers"));
            Assert.AreEqual(0, Solution.FindHackerRank("hackerrank"));
            Assert.AreEqual(-1, Solution.FindHackerRank("i think hackerrank is a great place to hangout"));
        }
        
    }
}
