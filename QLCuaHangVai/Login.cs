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
        SqlCommand cmd;
        DungChung tool;
        public Login()
        {
            InitializeComponent();
        }



        private void btLoginQuanLy_Click(object sender, EventArgs e)
        {

            tool.connect();
            cmd = new SqlCommand("LoginQuanLy", tool.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            if (tool.checkUser(txtID.Text))
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
            tool.disConnect();


        }

        private void btLoginNhanVien_Click(object sender, EventArgs e)
        {
            tool.connect();
            cmd = new SqlCommand("LoginNhanVien", tool.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            if (tool.checkUser(txtID.Text))
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
            tool.disConnect();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn đang cố gắng thoát khỏi hệ thống?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tool = new DungChung();
        }

       
    }
}
