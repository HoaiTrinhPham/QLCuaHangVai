using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLCuaHangVai
{
    public partial class XuatKho : Form
    {
        SqlCommand cmd;
        DungChung tool = new DungChung();
        public XuatKho()
        {
            InitializeComponent();
        }

        private void XuatKho_Load(object sender, EventArgs e)
        {
            List<object> da = new List<object>();
            tool.connect();
            cmd = new SqlCommand("getSanPham", tool.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var db = new
                {
                    TenVai = dr["TenHH"],
                    MaVai = dr["MaHH"]
                };
                da.Add(db);
            }
            
            txtMa.DataSource = da;
            txtMa.DisplayMember = "TenVai";
            txtMa.ValueMember = "MaVai";
            tool.disConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tool.CheckSoLuong(txtSoLuong.Text)>-1 && 
                tool.CheckGetSoLuong(tool.getSoLuong(txtMa.SelectedValue.ToString()),tool.CheckSoLuong(txtSoLuong.Text.ToString())))
            {
                tool.connect();
                cmd = new SqlCommand("XuatHang", tool.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ma", txtMa.SelectedValue.ToString());
                cmd.Parameters.Add("@SoLuong", txtSoLuong.Text);
                cmd.ExecuteNonQuery();
                tool.disConnect();
                MessageBox.Show("Hàng đã xuất!");
            }else
                MessageBox.Show("Số lượng sai!");
        }

    }
}
