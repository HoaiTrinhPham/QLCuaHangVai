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
        List<NhanVien> list = new List<NhanVien>();
        string str = "Server=.; Database = QLCuaHangVai;Integrated Security = true;";
        SqlConnection con;
        SqlCommand cmd;
        public QLNhanVien()
        {
            InitializeComponent();
            
        }
        public class NhanVien
        {
            
            public int STT { get; set; }
            public string ID { get; set; }
            public string Ho { get; set; }
            public string Ten { get; set; }
            public string GioVao { get; set; }
            public string GioRa { get; set; }
            public string GioLuong { get; set; }
        }
        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            DungChung t = new DungChung();
            string path = Application.StartupPath + @"\Images\";
            picAnhDaiDien.Image = Image.FromFile(path + t.getImages("hoaitrinh", "NhanVien") + ".png");
            txtMaNV.Text = txtMaNV.Text + " " + t.getImages("hoaitrinh", "NhanVien");
            loadData();
            txtSTT.DataBindings.Clear();
            txtID.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "Ho");
            txtTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "Ten");
            txtID.DataBindings.Add("Text", dgvNhanVien.DataSource, "ID");
            txtSTT.DataBindings.Add("Text", dgvNhanVien.DataSource, "STT");
            txtDate.Text = (DateTime.Now).ToString();
        }

        void loadData()
        {
            con = new SqlConnection(str);
            cmd = new SqlCommand("select * from NhanVien", con);
            con.Open();
            SqlDataReader da = cmd.ExecuteReader();
            int i = 1;
            while (da.Read())
            {
                NhanVien db = new NhanVien();
                db.STT = i++;
                db.ID = da["ID"].ToString();
                db.Ho = da["Ho"].ToString();
                db.Ten = da["Ten"].ToString();
                db.GioLuong = String.Format("{0:0.##}", da["GioLuong"]).ToString();
                list.Add(db);
            }
            dgvNhanVien.DataSource = list;
            
            con.Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = (DateTime.Now).ToString();
        }

        private void btChamCong_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            cmd = new SqlCommand("getGioCong", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            try {
                con.Open();
                double a = (double) cmd.ExecuteScalar();
                a = a + TinhCong(getChiSo(txtSTT.Text.ToString()));
                a = double.Parse(String.Format("{0:0.##}", a));
                SqlCommand cmd2 = new SqlCommand("ChamCongNV", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("@ID", txtID.Text);
                cmd2.Parameters.Add("giaTriMoi", a);
                cmd2.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            con.Close();

            loadData();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox t = (CheckBox)sender;
            if(t.Checked == true)
                list[getChiSo(txtSTT.Text.ToString())].GioVao = DateTime.Now.ToString("hh:mm:ss");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox t = (CheckBox)sender;
            if (t.Checked == true)
                list[getChiSo(txtSTT.Text.ToString())].GioRa = DateTime.Now.ToString("hh:mm:ss");
        }

        int getChiSo(string txt)
        {
            return Int16.Parse(txt) - 1;
        }

        double TinhCong(int MaNV)
        {
            string tmp = list[MaNV].GioVao;
            string tmp2 = list[MaNV].GioRa;
            if (tmp != "" && tmp2 != "")
            {
                tmp = tmp.ToString().Trim();
                int GioVao = Int16.Parse(tmp.Split(':')[0]);
                int PhutVao = Int16.Parse(tmp.Split(':')[1]);
                tmp2 = tmp2.ToString().Trim();
                int GioRa = Int16.Parse(tmp2.Split(':')[0]);
                int PhutRa = Int16.Parse(tmp2.Split(':')[1]);
                double gioCong = GioRa - GioVao;
                gioCong = gioCong > 0 ? gioCong : gioCong * -1;
                int phutCong = PhutRa - PhutVao;
                gioCong = Double.Parse(String.Format("{0:0.##}", (gioCong * 60 + phutCong) / 60));
                return gioCong;
            }
            return 0;
        }
    }
}
