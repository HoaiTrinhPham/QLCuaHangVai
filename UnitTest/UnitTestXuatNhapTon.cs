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
            Assert.AreEqual(getHam.CheckMaHH("sdasdasdasdasdasd11215"), false);
            Assert.AreEqual(getHam.CheckMaHH("hoaitrinh"), true);
        }

        [TestMethod]
        public void TestCheckGetSoLuong()
        {
            Assert.AreEqual(getHam.CheckGetSoLuong(-1,5), false);
            Assert.AreEqual(getHam.CheckGetSoLuong(4, 5), false);
            Assert.AreEqual(getHam.CheckGetSoLuong(6, 5), true);
        }

        [TestMethod]
        public void TestCheckSoLuong()
        {
            Assert.AreEqual(getHam.CheckSoLuong(""), -1);
            Assert.AreEqual(getHam.CheckSoLuong("adsda"), -1);
            Assert.AreEqual(getHam.CheckSoLuong(null), -1);
            Assert.AreEqual(getHam.CheckSoLuong("adsd d"), -1);
            Assert.AreEqual(getHam.CheckSoLuong("12a"), -1);
            Assert.AreEqual(getHam.CheckSoLuong("1a2"), -1);
            Assert.AreEqual(getHam.CheckSoLuong("a12"), -1);
            Assert.AreEqual(getHam.CheckSoLuong("1 2"), -1);
            Assert.AreNotEqual(getHam.CheckSoLuong("1"), -1);
        }

        [TestMethod]
        public void TestCheckTenVai()
        {
            Assert.AreEqual(getHam.CheckTenVai(""), false);
            Assert.AreEqual(getHam.CheckTenVai(null), false);
            Assert.AreEqual(getHam.CheckTenVai("The"), true);
        }

        [TestMethod]
        public void TestCheckMauVai()
        {
            Assert.AreEqual(getHam.CheckMauVai(""), false);
            Assert.AreEqual(getHam.CheckMauVai(null), false);
            Assert.AreEqual(getHam.CheckMauVai("Đen"), true);
        }

        [TestMethod]
        public void TestCheckLoaiVai()
        {
            Assert.AreEqual(getHam.CheckLoaiVai(""), false);
            Assert.AreEqual(getHam.CheckLoaiVai(null), false);
            Assert.AreEqual(getHam.CheckLoaiVai("Áo"), true);
        }

        [TestMethod]
        public void TestCheckDonGia()
        {
            Assert.AreEqual(getHam.CheckDonGia(""), false);
            Assert.AreEqual(getHam.CheckDonGia(null), false);
            Assert.AreEqual(getHam.CheckDonGia("Đen"), false);
            Assert.AreEqual(getHam.CheckDonGia("1 1"), false);
            Assert.AreEqual(getHam.CheckDonGia("1a2"), false);
            Assert.AreEqual(getHam.CheckDonGia("Đen"), false);
            Assert.AreEqual(getHam.CheckDonGia("12000"), true);
        }
    }
}
