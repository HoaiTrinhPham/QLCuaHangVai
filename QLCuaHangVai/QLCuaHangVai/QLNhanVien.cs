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
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            DungChung t = new DungChung();
            string path = Application.StartupPath + @"\Images\";
            picAnhDaiDien.Image = Image.FromFile(path + t.getImages("hoaitrinh", "NhanVien") + ".png");
            txtMaNV.Text = txtMaNV.Text + " " + t.getImages("hoaitrinh", "NhanVien");
            string str = "Server=.; Database = QLCuaHangVai;Integrated Security = true;";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("select * from NhanVien", con);
            con.Open();
            SqlDataReader da = cmd.ExecuteReader();
            List<object> list = new List<object>();
            int i = 1;
            while (da.Read())
            {
                var db = new
                {
                    STT = i++,
                    ID = da["ID"].ToString(),
                    Ho = da["Ho"].ToString(),
                    Ten = da["Ten"].ToString()
                };
                list.Add(db);
            }
            dgvNhanVien.DataSource = list;
            txtHoTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "Ho" );
            txtTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "Ten");
            txtID.DataBindings.Add("Text", dgvNhanVien.DataSource, "ID");
            con.Close();
            txtDate.Text = (DateTime.Now).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = (DateTime.Now).ToString();
        }

        private void btChamCong_Click(object sender, EventArgs e)
        {

        }
    }
}
