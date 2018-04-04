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
        DungChung tool;
        List<NhanVien> list;
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
            tongLuong = 0;
            list = new List<NhanVien>();
            tool.connect();
            cmd = new SqlCommand("TTMotNhanVien", tool.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", txtMaNV.Text.ToString());
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
                tongLuong += tmp * tmp2;
                list.Add(db);
            }
            dgvNhanVien.DataSource = list;
            txtTongLuong.Text = tongLuong.ToString();
            tool.disConnect();
        }

        void loadData()
        {
            tongLuong = 0;
            list = new List<NhanVien>();
            tool.connect();
            cmd = new SqlCommand("TTNhanVien", tool.con);
            cmd.CommandType = CommandType.StoredProcedure;
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
            tool.disConnect();

        }

        private void rdTungNV_CheckedChanged(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
        }

        private void TinhLuong_Load(object sender, EventArgs e)
        {
            tool = new DungChung();
        }
    }
}
