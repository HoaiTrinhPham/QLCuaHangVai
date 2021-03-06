﻿using System;
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
        DungChung tool;
        List<NhanVien> list;
        SqlCommand cmd;

        public QLNhanVien()
        {
            InitializeComponent();
            
        }
        
        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            tool = new DungChung();
            string path = Application.StartupPath + @"\Images\";
            picAnhDaiDien.Image = Image.FromFile(path + tool.getImages(txtID.Text, "NhanVien") + ".png");
            txtMaNV.Text ="Mã NV: "+tool.getImages(txtID.Text, "NhanVien");
           
            loadData();

         

            txtDate.Text = (DateTime.Now).ToString();
            
        }

        void loadData()
        {

            list = new List<NhanVien>();
            tool.connect();
            cmd = new SqlCommand("select * from NhanVien", tool.con);
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
            tool.disConnect();
            txtHoTen.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtID.DataBindings.Clear();
            txtSTT.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "Ho");
            txtTen.DataBindings.Add("Text", dgvNhanVien.DataSource, "Ten");
            txtID.DataBindings.Add("Text", dgvNhanVien.DataSource, "ID");
            txtSTT.DataBindings.Add("Text", dgvNhanVien.DataSource, "STT");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = (DateTime.Now).ToString();
        }

        private void btChamCong_Click(object sender, EventArgs e)
        {
            if (cbCheckin.Checked == true && cbCheckout.Checked == true)
            {
                //list[tool.getChiSo(txtSTT.Text.ToString())].GioRa = "10:00:00";
                tool.connect();
                cmd = new SqlCommand("getGioCong", tool.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                double a = (double)cmd.ExecuteScalar();
                a = a + TinhCong(tool.getChiSo(txtSTT.Text.ToString()));
                a = double.Parse(String.Format("{0:0.##}", a));
                SqlCommand cmd2 = new SqlCommand("ChamCongNV", tool.con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("@ID", txtID.Text);
                cmd2.Parameters.Add("giaTriMoi", a);
                cmd2.ExecuteNonQuery();
                tool.disConnect();
                loadData();
                cbCheckin.Checked = false;
                cbCheckout.Checked = false;
            }
            else
                MessageBox.Show("Chưa checkin hoặc checkout");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox t = (CheckBox)sender;
            if(t.Checked == true)
                list[tool.getChiSo(txtSTT.Text.ToString())].GioVao = DateTime.Now.ToString("hh:mm:ss");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox t = (CheckBox)sender;
            if (t.Checked == true)
                list[tool.getChiSo(txtSTT.Text.ToString())].GioRa = DateTime.Now.ToString("hh:mm:ss");
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

        private void button1_Click(object sender, EventArgs e)
        {
            (new TinhLuong()).Show();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Images\";
            picAnhDaiDien.Image = Image.FromFile(path + tool.getImages(txtID.Text, "NhanVien") + ".png");
            txtMaNV.Text = "Mã NV: " + tool.getImages(txtID.Text, "NhanVien");
           
        }
    }
}
