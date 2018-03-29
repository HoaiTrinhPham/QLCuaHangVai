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
    public partial class TonKho : Form
    {
        SqlDataAdapter da;
        DataTable tb = new DataTable();
        DungChung tool = new DungChung();
        public TonKho()
        {
            InitializeComponent();
        }

        private void TonKho_Load(object sender, EventArgs e)
        {
            tool.connect();
            da = new SqlDataAdapter("getSanPham", tool.con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(tb);
            dgvView.DataSource = tb;
            tool.disConnect();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (tool.CheckMaHH(txtMa.Text) && tool.SearchMa(txtMa.Text))
            {
                tool.connect();
                DataTable tbq = new DataTable();
                da = new SqlDataAdapter("kiemTraHangTon", tool.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Ma", txtMa.Text);
                da.Fill(tbq);
                dgvView.DataSource = tbq;
                tool.disConnect();
            }else
                MessageBox.Show("Mã chưa đúng!");
        }
    }
}
