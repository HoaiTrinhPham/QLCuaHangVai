using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCuaHangVai
{
    public partial class ThemVai : Form
    {
        string connectionString = DungChung.ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        public ThemVai()
        {
            InitializeComponent();
        }

        private void ThemVai_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("ThemHangHoa", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                cmd.Parameters.AddWithValue("@SoLuong", nmrSoLuong.Value);
                cmd.Parameters.AddWithValue("@DonGia", Convert.ToDecimal(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);

                string returnText = (cmd.ExecuteScalar().ToString() == "1" ?
                                     "Thêm thành công" :
                                     "Thêm thất bại");
                MessageBox.Show(returnText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
