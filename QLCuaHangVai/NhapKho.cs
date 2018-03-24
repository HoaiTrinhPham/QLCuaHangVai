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
        public NhapKho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString);
            cmd = new SqlCommand("ThemSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHH", txtMa.Text);
            cmd.Parameters.Add("@TenHH", txtTen.Text);
            cmd.Parameters.Add("@LoaiHH", txtLoai.Text);
            cmd.Parameters.Add("@Mau", txtMau.Text);
            cmd.Parameters.Add("@SoLuong", txtSL.Text);
            cmd.Parameters.Add("@DonGia", txtDonGia.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

     
    }
}
