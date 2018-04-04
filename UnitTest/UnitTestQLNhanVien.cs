using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLCuaHangVai;

namespace UnitTest
{
    [TestClass]
    public class UnitTestQLNhanVien
    {
        private DungChung tool;
        [TestInitialize]
        public void setup()
        {
            tool = new DungChung();
        }

        [TestMethod]
        public void CheckUser()
        {
            Assert.AreEqual(tool.checkUser(""),false);
            Assert.AreEqual(tool.checkUser(null), false);
            Assert.AreEqual(tool.checkUser("12345adsddsdadsasdada678910"), false);
            Assert.AreEqual(tool.checkUser("a a"), false);
            Assert.AreEqual(tool.checkUser("hoaitrinh"), true);
        }
        [TestMethod]
        public void ChiSo()
        {
            Assert.AreEqual(tool.getChiSo("12"), 11);
            Assert.AreEqual(tool.getChiSo("1a2"), -1);
            Assert.AreEqual(tool.getChiSo("1 2"), -1);
            Assert.AreEqual(tool.getChiSo("aa"), -1);
        }
    }
}
