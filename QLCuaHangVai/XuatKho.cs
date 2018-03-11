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
    public partial class XuatKho : Form
    {
        string connectionString = DungChung.ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        public XuatKho()
        {
            InitializeComponent();
        }

        private void XuatKho_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("LayTatCaHangHoa", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();
                List<HangHoa> lstHangHoa = new List<HangHoa>();
                while (dr.Read())
                {
                    lstHangHoa.Add(new HangHoa()
                    {
                        Id = dr.GetInt32(0),
                        Ten = dr.GetString(1)
                    });
                }

                foreach (var item in lstHangHoa)
                {
                    cbVai.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("GIAMSOLUONGVAOHANGHOASANCO", con);
                HangHoa selectedItem = (HangHoa)cbVai.SelectedItem;
                cmd.Parameters.AddWithValue("@Id", selectedItem.Id);
                cmd.Parameters.AddWithValue("@SoLuong", nmrSoLuong.Value);
                if (cmd.ExecuteScalar().ToString() == "1")
                    MessageBox.Show(string.Format("Xuất kho thành công\nGiảm {0} hàng hóa từ hàng hóa sẵn có", nmrSoLuong.Value.ToString()));
                else
                    MessageBox.Show("Xuất kho thất bại\nVui lòng thử lại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
