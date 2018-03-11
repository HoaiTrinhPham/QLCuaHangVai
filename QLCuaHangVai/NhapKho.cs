using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLCuaHangVai
{
    public partial class NhapKho : Form
    {
        string connectionString = DungChung.ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        public NhapKho()
        {
            InitializeComponent();
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("LayTatCaHangHoa", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();
                List<HangHoa> lstHangHoa = new List<HangHoa>();
                while(dr.Read())
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

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("THEMSOLUONGVAOHANGHOASANCO", con);
                HangHoa selectedItem = (HangHoa)cbVai.SelectedItem;
                cmd.Parameters.AddWithValue("@Id", selectedItem.Id);
                cmd.Parameters.AddWithValue("@SoLuong", nmrSoLuong.Value);
                if (cmd.ExecuteScalar().ToString() == "1")
                    MessageBox.Show(string.Format("Nhập kho thành công\nThêm {0} hàng hóa vào hàng hóa sẵn có", nmrSoLuong.Value.ToString()));
                else
                    MessageBox.Show("Nhập kho thất bại\nVui lòng thử lại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    class HangHoa {
        public int Id { get; set; }
        public string Ten { get; set; }
    }
}
