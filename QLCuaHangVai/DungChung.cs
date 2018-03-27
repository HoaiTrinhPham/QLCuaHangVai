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
            return true;
        }
        public bool CheckSoLuong(string txtSoLuong)
        {
            if (txtSoLuong == null || txtSoLuong == "")
                return false;
            return true;
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
