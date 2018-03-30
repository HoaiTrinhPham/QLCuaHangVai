using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace QLCuaHangVai
{
    public class DungChung
    {
        public SqlConnection con;
        SqlCommand cmd;

        public bool checkUser(string str)
        {
            if (str == null)
                return false;
            if (str == "")
                return false;
            if (str.Length > 20)
                return false;
            foreach (char c in str)
            {
                if (c == ' ' || c == '-' || c == '+')
                    return false;
            }
            return true;
        }

        public SqlConnection connect()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString);
            try
            {
                if(con.State == ConnectionState.Closed)
                con.Open();
            }
            catch (SqlException ex)
            {
                return null;
            }
            return con;
        }

        public string disConnect()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return null;
        }

        public string getImages(string ID, string loai)
        {
            connect();
            if(loai == "NhanVien")
                cmd = new SqlCommand("getImagesNhanVien", con);
            else
                cmd = new SqlCommand("getImagesQuanLy", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ID);
            string tmp = cmd.ExecuteScalar().ToString();
            disConnect();
            return tmp;
        }
        public bool CheckMaHH(string txtMa)
        {
            if (txtMa == null || txtMa.Length > 10 || txtMa == "")
            {
                return false;
            }
            foreach (char c in txtMa)
            {
                if (c == ' ')
                    return false;
            }
            return true;
        }
        public int CheckSoLuong(string txtSoLuong)
        {
            if (txtSoLuong == null || txtSoLuong == "")
                return -1;
            foreach (char c in txtSoLuong)
            {
                if (c == ' ' || checkSo(c) == false)
                    return -1;
            }
            return Int16.Parse(txtSoLuong);
        }

        public bool CheckTenVai(string txtTenVai)
        {
            if (txtTenVai == null || txtTenVai == "")
                return false;
            return true;
        }
        public bool CheckMauVai(string txtMauVai)
        {
            if (txtMauVai == null || txtMauVai == "")
            {
                return false;
            }
            return true;
        }

        public bool CheckLoaiVai(string txtLoaiVai)
        {
            if (txtLoaiVai == null || txtLoaiVai == "")
                return false;
            return true;
        }

        public bool CheckDonGia(string txtDonGia)
        {
            if (txtDonGia == null || txtDonGia == "")
                return false;
            foreach (char c in txtDonGia)
            {
                if (c == ' ' || checkSo(c) == false)
                    return false;
            }
            return true;
        }

        protected bool checkSo(char c)
        {
            return c >= '0' && c <= '9';
        }

        public int getSoLuong(string txtMa)
        {
            connect();
            cmd = new SqlCommand("KiemTraHangTon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Ma", txtMa);
            SqlDataReader dr = cmd.ExecuteReader();
            int SLTon = 0;
            while (dr.Read())
            {
                SLTon = Int16.Parse(dr["SoLuong"].ToString());
                break;
            }
            disConnect();
            return SLTon;
        }

        public bool CheckGetSoLuong(int SLTon, int SL)
        {        
            if (SL <= 0 || SL > SLTon)
                return false;
            return true;
          
        }
        public bool SearchMa(string txtMa)
        {
            connect();
            cmd = new SqlCommand("KiemTraHangTon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Ma", txtMa);
            object tmp = cmd.ExecuteScalar();
            if (tmp == null)
            {
                disConnect();
                return false;
            }
            foreach (char c in txtMa)
            {
                if (c == ' ' || c == '-' || c == '+')
                    return false;
            }
            return true;
        }
        
        public int getChiSo(string txt)
        {
            foreach (char c in txt)
            {
                if (c < '0' || c > '9')
                    return -1;
            }
            return Int16.Parse(txt) - 1;
        }
    }
    public class NhanVien
    {

        public int STT { get; set; }
        public string ID { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string GioVao { get; set; }
        public string GioRa { get; set; }
        public string GioLuong { get; set; }
        public string TienCong { get; set; }
        public string Luong { get; set; }
    }

 
}
