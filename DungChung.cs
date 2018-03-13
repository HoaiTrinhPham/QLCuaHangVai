using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace QLCuaHangVai
{
    public class DungChung
    {
        SqlConnection con;
        SqlCommand cmd;
        public string getImages(string ID, string loai)
        {
            con = new SqlConnection("Server=.; Database = QLCuaHangVai;Integrated Security = true;");
            con.Open();
            if(loai == "NhanVien")
                cmd = new SqlCommand("getImagesNhanVien", con);
            else
                cmd = new SqlCommand("getImagesQuanLy", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ID);
            string tmp = cmd.ExecuteScalar().ToString();
            con.Close();
            return tmp;
        }
    }
}
