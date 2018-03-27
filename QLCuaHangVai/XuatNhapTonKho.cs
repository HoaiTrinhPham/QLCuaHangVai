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
    public partial class XuatNhapTonKho : Form
    {
        public XuatNhapTonKho()
        {
            InitializeComponent();
        }

        

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapKho n = new NhapKho();
            n.MdiParent = this;
            n.Show();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuatKho x = new XuatKho();
            x.MdiParent = this;
            x.Show();
        }

        private void kiểmTraKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TonKho t = new TonKho();
            t.MdiParent = this;
            t.Show();
        }

        private void XuatNhapTonKho_Load(object sender, EventArgs e)
        {
           
        }
    }
}
