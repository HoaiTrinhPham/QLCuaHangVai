using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCuaHangVai
{
    public partial class TinhLoiNhuan : Form
    {
        SqlConnection con;
        public TinhLoiNhuan()
        {
            InitializeComponent();
        }
        private void TinhLoiNhuan_Load(object sender, EventArgs e)
        {
            try
            {
                KhoiTao();
                this.con = new SqlConnection("Server=.; Database = QLCuaHangVai;Integrated Security = true;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void KhoiTao()
        {
            // ComboBox
            cbTheo.Items.Add(new ItemCB() { Id = 1, Value = "Tháng" });
            cbTheo.Items.Add(new ItemCB() { Id = 2, Value = "Năm" });

            // Label
            lblDoanThu.Text = "";
            lblLoiNhuan.Text = "";
        }

        private void cbTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (con.State == ConnectionState.Closed)
                    con.Open();

                switch (((ItemCB)cbTheo.SelectedItem).Id)
                {
                    case 1:
                        cmd = new SqlCommand("P_LAYNHUNGTHANGDACOHOADON", con);
                        break;
                    case 2:
                        cmd = new SqlCommand("P_LAYNHUNGNAMDACOHOADON", con);
                        break;
                }
                
                SqlDataReader dr = cmd.ExecuteReader();
                List<GridViewItem> nhungThangCoHoaDon = new List<GridViewItem>();
                while (dr.Read())
                {
                    if(((ItemCB)cbTheo.SelectedItem).Id == 1)
                        nhungThangCoHoaDon.Add(new GridViewItem(LayThangTiengViet(dr[0].ToString())));
                    else
                        nhungThangCoHoaDon.Add(new GridViewItem(LayNamTiengViet(dr[0].ToString())));
                }
                if (con.State == ConnectionState.Open)
                    con.Close();
                dtgTheo.DataSource = nhungThangCoHoaDon;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string LayThangTiengViet(string ngaySQL)
        {
            // 01/03/2018
            string thang = ngaySQL.Substring(ngaySQL.IndexOf("/") + 1, 2);
            string nam = ngaySQL.Substring(ngaySQL.LastIndexOf("/") + 1, 4);
            return thang + "-" + nam;
        }
        private string LayNamTiengViet(string ngaySQL)
        {
            // 01/03/2018
            return ngaySQL.Substring(ngaySQL.LastIndexOf("/") + 1, 4);
        }
        private DateTime LayNgayThangTuGridView(string ngay)
        {
            int year = Convert.ToInt32(ngay.Substring(ngay.IndexOf("-") + 1));
            int month = Convert.ToInt32(ngay.Substring(0, 2));
            DateTime dt = new DateTime(year, month, 1);
            return dt;
        }

        private Tuple<int, int> DateTimeSangThangNam(string date)
        {
            if (string.IsNullOrEmpty(date))
                return Tuple.Create(1, 2018);
            if (date.IndexOf("-") > 0)
            {
                return Tuple.Create(Convert.ToInt32(date.Substring(0, 2)), Convert.ToInt32(date.Substring(date.IndexOf("-") + 1)));
            }
            return Tuple.Create(1, Convert.ToInt32(date));
        }
        private void dtgTheo_SelectionChanged(object sender, EventArgs e)
        {
            var selectedCell = dtgTheo.SelectedCells;
            string date = "";
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (dtgTheo.Rows.Count > 0)
                {
                    if (selectedCell.Count > 0)
                        date = selectedCell[0].Value.ToString();
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    if (((ItemCB)cbTheo.SelectedItem).Id == 1)
                    {
                        var tp = DateTimeSangThangNam(date);
                        // Doanh thu
                        cmd = new SqlCommand("P_LAYDOANHTHUTHEOTHANG", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@thang", tp.Item1);
                        cmd.Parameters.AddWithValue("@nam", tp.Item2);
                        var doanhThu = cmd.ExecuteScalar();
                        lblDoanThu.Text = doanhThu == null ? "0" : Convert.ToInt32(doanhThu).ToString() + " VND";

                        // Loi nhuan 
                        cmd = new SqlCommand("P_LAYVONTHUCCHITHEOTHANG", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@thang", tp.Item1);
                        cmd.Parameters.AddWithValue("@nam", tp.Item2);
                        var thucChi = cmd.ExecuteScalar();
                        lblLoiNhuan.Text = thucChi == null ? "Lỗi" : (Convert.ToInt32(doanhThu) - Convert.ToInt32(thucChi)).ToString() + " VND";
                    }
                    else
                    {
                        // Doanh thu
                        cmd = new SqlCommand("P_LAYDOANHTHUTHEONAM", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nam", DateTimeSangThangNam(date).Item2);
                        var doanhThu = cmd.ExecuteScalar();
                        lblDoanThu.Text = doanhThu == null ? "0" : Convert.ToInt32(doanhThu).ToString() + " VND";

                        // Loi nhuan
                        cmd = new SqlCommand("P_LAYVONTHUCCHITHEONAM", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nam", DateTimeSangThangNam(date).Item2);
                        var thucChi = cmd.ExecuteScalar();
                        lblLoiNhuan.Text = thucChi == null ? "Lỗi" : (Convert.ToInt32(doanhThu) - Convert.ToInt32(thucChi)).ToString() + " VND";
                    }
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
class ItemCB
{
    public int Id { get; set; }
    public string Value { get; set; }
    public ItemCB()
    {
        this.Id = 0;
        this.Value = "";
    }

    public override string ToString()
    {
        return this.Value ?? "";
    }

    public int GetId()
    {
        return this.Id;
    }
}


class GridViewItem
{
    string _thang;
    public GridViewItem(string thang)
    {
        this._thang = thang;
    }

    public GridViewItem()
    {
        // TODO: Complete member initialization
    }
    private string thang;

    public string ThoiGian
    {
        get { return _thang; }
        set { _thang = value; }
    }
    
}
