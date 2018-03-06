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

        bool checkUser(string str)
        {
            if (str == null)
                return false;
            if (str == "")
                return false;
            if (str.Length > 20)
                return false;
            return true;
        }

        private void btLoginQuanLy_Click(object sender, EventArgs e)
        {
            string str = "Server=.; Database = QLCuaHangVai;Integrated Security = true;";
            con = new SqlConnection(str);
            con.Open();
            cmd = new SqlCommand("LoginQuanLy",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID",txtID.Text);
            if (checkUser(txtID.Text))
            {
                string tmp = cmd.ExecuteScalar().ToString();
                if (tmp != "")
                {
                    if (txtPass.Text == tmp)
                    {
                        TrangChu f = new TrangChu();
                        f.ShowDialog();
                    }
                    else
                        MessageBox.Show("Error", "Tài khoản không hợp lệ");
                }
                else
                    MessageBox.Show("Error", "Tài khoản không hợp lệ");
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
            if (checkUser(txtID.Text))
            {
                string tmp = cmd.ExecuteScalar().ToString();
                if (tmp != "")
                {
                    if (txtPass.Text == tmp)
                    {
                        TrangChu f = new TrangChu(1);
                        f.ShowDialog();

                    }
                    else
                        MessageBox.Show("Error", "Tài khoản không hợp lệ");
                }
                else
                    MessageBox.Show("Error", "Tài khoản không hợp lệ");
            }
            else
                MessageBox.Show("Error", "Tài khoản không hợp lệ");

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn đang cố gắng thoát khỏi hệ thống?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

       
    }
}
