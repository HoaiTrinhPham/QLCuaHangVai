using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLCuaHangVai;

namespace UnitTest
{
    [TestClass]
    public class UnitTestXuatNhapTon
    {
        private DungChung getHam;
        [TestInitialize]
        public void setup()
        {
            getHam = new DungChung();
        }

        [TestMethod]

        public void TestMa() 
        {
            Assert.AreEqual(getHam.CheckMaHH(""), false);
            Assert.AreEqual(getHam.CheckMaHH(null), false);
        }
    }
}
