using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCuaHangVai
{
    public partial class TrangChu : Form
    {
        int kt = 0;
        public TrangChu()
        {
            InitializeComponent();
        }

        public TrangChu(int i)
        {
            kt = i;
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                qlnv.Enabled = false;
            }
        }

        private void tínhLợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xuấtNhậpTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
