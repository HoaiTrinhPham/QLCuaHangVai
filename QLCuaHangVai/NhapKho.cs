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
    public partial class NhapKho : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DungChung getCode;
        public NhapKho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (getCode.CheckMaHH(txtMa.Text) && getCode.CheckLoaiVai(txtLoai.Text) && getCode.CheckTenVai(txtTen.Text)
                && getCode.CheckSoLuong(txtSL.Text) && getCode.CheckMauVai(txtMau.Text))
            {
                getCode.connect();
                cmd = new SqlCommand("ThemSP", getCode.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHH", txtMa.Text);
                cmd.Parameters.Add("@TenHH", txtTen.Text);
                cmd.Parameters.Add("@LoaiHH", txtLoai.Text);
                cmd.Parameters.Add("@Mau", txtMau.Text);
                cmd.Parameters.Add("@SoLuong", txtSL.Text);
                cmd.Parameters.Add("@DonGia", txtDonGia.Text);
                cmd.ExecuteNonQuery();
                getCode.disConnect();
            }
            else
            {
                MessageBox.Show("Định dạng không hợp lệ!");
            }
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            getCode = new DungChung();
        }

     
    }
}
