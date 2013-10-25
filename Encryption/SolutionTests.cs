using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Encryption
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void EncryptionTest()
        {
            Assert.AreEqual(Solution.Encrypt("eric"), "ei rc");
            Assert.AreEqual(Solution.Encrypt("haveaniceday"), "hae and via ecy");
            Assert.AreEqual(Solution.Encrypt("feedthedog"), "fto ehg ee dd");
            Assert.AreEqual(Solution.Encrypt("chillout"), "clu hlt io");
        }
        
    }
}
