using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCuaHangVai
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
        }

        private void btLoginQuanLy_Click(object sender, EventArgs e)
        {
            string str = "Server=.; Database = QLCuaHangVai;Integrated Security = true;";
            con = new SqlConnection(str);
            con.Open();
            cmd = new SqlCommand("LoginQuanLy",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID",txtID.Text);
            string tmp = cmd.ExecuteScalar().ToString();
            if (tmp != "")
            {
                if (txtPass.Text == tmp)
                {
                    TrangChu f = new TrangChu();
                    f.ShowDialog();
                   
                }
            }
            else
                MessageBox.Show("Error", "Tài khoản không hợp lệ");
            con.Close();

        }

        private void btLoginNhanVien_Click(object sender, EventArgs e)
        {
            string str = "Server=.; Database = QLCuaHangVai;Integrated Security = true;";
            con = new SqlConnection(str);
            con.Open();
            cmd = new SqlCommand("LoginNhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            string tmp = cmd.ExecuteScalar().ToString();
            if (tmp != "")
            {
                if (txtPass.Text == tmp)
                {
                    TrangChu f = new TrangChu(1);
                    f.ShowDialog();

                }
            }
            else
                MessageBox.Show("Error", "Tài khoản không hợp lệ");
        }

       
    }
}
