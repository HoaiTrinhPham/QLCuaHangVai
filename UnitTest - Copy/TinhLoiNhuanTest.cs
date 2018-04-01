using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLCuaHangVai;
using System.Diagnostics; 

namespace UnitTest
{
    [TestClass]
    public class TinhLoiNhuanTest: TinhLoiNhuan
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]    
        public void TinhLoiNhuanTheoNam()
        {
            Assert.IsTrue(TinhLoiNhuanTheoNam("01-2017") >= 0);
        }
        [TestMethod]
        public void TinhLoiNhuanTheoNamChuoiRong()
        {
            Assert.IsTrue(TinhLoiNhuanTheoNam("") >= 0);
        }
        [TestMethod]
        public void TinhLoiNhuanTheoNamChuoiSaiFormat()
        {
            Assert.IsTrue(TinhLoiNhuanTheoNam("-") >= 0);
            Assert.IsTrue(TinhLoiNhuanTheoNam("/") >= 0);
            Assert.IsTrue(TinhLoiNhuanTheoNam("815415454545") == 0);
            Assert.IsTrue(TinhLoiNhuanTheoNam("1-1-2017") == 0);
        }
        [TestMethod]   
        public void TinhLoiNhuanTheoThang()
        {
            Assert.IsTrue(TinhLoiNhuanTheoThang("01-2017") >= 0);
        }
        [TestMethod]
        public void TinhLoiNhuanTheoThangChuoiRong()
        {
            Assert.IsTrue(TinhLoiNhuanTheoThang("") >= 0);
        }
        [TestMethod]
        public void TinhLoiNhuanTheoThangChuoiSaiFormat()
        {
            Assert.IsTrue(TinhLoiNhuanTheoThang("-") >= 0);
            Assert.IsTrue(TinhLoiNhuanTheoThang("/") >= 0);
            Assert.IsTrue(TinhLoiNhuanTheoThang("815415454545") >= 0);
            Assert.IsTrue(TinhLoiNhuanTheoThang("1-1-2017") >= 0);
        }
        [TestMethod]
        public void TinhDoanhThuTheoNam()
        {
            Assert.IsTrue(TinhDoanhThuTheoNam("01-2017") >= 0);
        }
        [TestMethod]
        public void TinhDoanhThuTheoNamChuoiRong()
        {
            Assert.IsTrue(TinhDoanhThuTheoNam("") >= 0);
        }
        [TestMethod]
        public void TinhDoanhThuTheoNamChuoiSaiFormat()
        {
            Assert.IsTrue(TinhDoanhThuTheoNam("-") >= 0);
            Assert.IsTrue(TinhDoanhThuTheoNam("/") >= 0);
            Assert.IsTrue(TinhDoanhThuTheoNam("815415454545") >= 0);
            Assert.IsTrue(TinhDoanhThuTheoNam("1-1-2017") >= 0);
        }
        [TestMethod]
        public void TinhDoanhThuTheoThang()
        {
            Assert.IsTrue(TinhDoanhThuTheoThang("01-2017") >= 0);
        }
        [TestMethod]
        public void TinhDoanhThuTheoThangChuoiRong()
        {
            Assert.IsTrue(TinhDoanhThuTheoThang("") >= 0);
        }
        [TestMethod]
        public void TinhDoanhThuTheoThangChuoiSaiFormat()
        {
            Assert.IsTrue(TinhDoanhThuTheoThang("-") >= 0);
            Assert.IsTrue(TinhDoanhThuTheoThang("/") >= 0);
            Assert.IsTrue(TinhDoanhThuTheoThang("815415454545") >= 0);
            Assert.IsTrue(TinhDoanhThuTheoThang("1-1-2017") >= 0);
        }
 
    }
}
