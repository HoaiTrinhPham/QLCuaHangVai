using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLCuaHangVai
{
    public partial class TinhLuong : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        List<NhanVien> list = new List<NhanVien>();
        double tongLuong = 0;
        public TinhLuong()
        {
            InitializeComponent();
        }

        private void btLuong_Click(object sender, EventArgs e)
        {
            if (rdAll.Checked == true)
            {
                txtMaNV.Enabled = false;
                loadData();
            }
            if (rdTungNV.Checked == true)
            {
                loadDataMotNhanVien();
            }
        }

        void loadDataMotNhanVien()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString);
            cmd = new SqlCommand("TTMotNhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", txtMaNV.Text.ToString());
            con.Open();
            SqlDataReader da = cmd.ExecuteReader();
            int i = 1;
            while (da.Read())
            {
                NhanVien db = new NhanVien();
                db.STT = i++;
                db.ID = da["ID"].ToString();
                db.Ho = da["Ho"].ToString();
                db.Ten = da["Ten"].ToString();
                db.GioLuong = String.Format("{0:0.##}", da["GioLuong"]).ToString();
                db.TienCong = String.Format("{0:0.##}", da["TienCong"]).ToString();
                double tmp = Convert.ToDouble(db.GioLuong);
                double tmp2 = Convert.ToDouble(db.TienCong);
                db.Luong = (tmp * tmp2).ToString();

                list.Add(db);
            }
            dgvNhanVien.DataSource = list;

            con.Close();
        }

        void loadData()
        {

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString);
            cmd = new SqlCommand("TTNhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader da = cmd.ExecuteReader();
            int i = 1;
            while (da.Read())
            {
                NhanVien db = new NhanVien();
                db.STT = i++;
                db.ID = da["ID"].ToString();
                db.Ho = da["Ho"].ToString();
                db.Ten = da["Ten"].ToString();
                db.GioLuong = String.Format("{0:0.##}", da["GioLuong"]).ToString();
                db.TienCong = String.Format("{0:0.##}", da["TienCong"]).ToString();
                double tmp = Convert.ToDouble(db.GioLuong);
                double tmp2 = Convert.ToDouble(db.TienCong);
                db.Luong = (tmp * tmp2).ToString();
                list.Add(db);
                tongLuong += tmp * tmp2;
            }
            dgvNhanVien.DataSource = list;
            txtTongLuong.Text = tongLuong.ToString();
            con.Close();

        }
    }
}
