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
    }
}
