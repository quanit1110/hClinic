using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DanhMuc
{
    public partial class mnc1DMHoatChatUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mnc1DMHoatChatUC()
        {
            InitializeComponent();
            //lấy kích thước của màn hình
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hiển thị theo kích thước của màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;

            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1386 là chiều rộng, 788 là chiều cao Form khi thiết kế, xem trong Properties của Form
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            ThuVien.DanhMuc.TreeDMHC(tvDMHoatChat);
            Common.clsControl.LoadLK(lkLoaiVatTu, "LoaiVatTu");
        }
        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                //gọi đệ quy nếu như 1 control nào có chứa các control khác nữa

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                //canh lại toạ độ x, y, chiều rộng, cao cho các control trên form

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }

        private void tvDMHoatChat_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ThuVien.loadform.clearForm(this.groupBox1);
            txtMaCha.Text = e.Node.Tag.ToString();
            string lever = e.Node.Level.ToString();
            SqlConnection con = ThuVien.mySQL.Conn();
            string sql = "select * from [mHIS_Hethong].[dbo].[DM_Duoc_HoatChat] where HoatChat_Id =" + txtMaCha.Text + "";
            string sql1= "select * from [mHIS_Hethong].[dbo].[DM_LoaiVatTu] where LoaiVatTu_Id =" + txtMaCha.Text + "";
            if (lever == "0")
            {

            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtMaHoatChat.Text = dt.Rows[0]["MaHoatChat"].ToString();
                txtMaHoatChatRef.Text = dt.Rows[0]["MaHoatChatRef"].ToString();
                txtTenHoatChat.Text = dt.Rows[0]["TenHoatChat"].ToString();
                txtTenHoatChat1.Text = dt.Rows[0]["TenHoatChat_1"].ToString();
                txtTenHoatChat2.Text = dt.Rows[0]["TenHoatChat_2"].ToString();
                txtIdx.Text = dt.Rows[0]["TenHoatChat_2"].ToString();
                string ten = dt.Rows[0]["HoatChat"].ToString();
                if (ten == "True")
                {
                    cbHoatChat.Checked = true;
                }
                else
                {
                    cbHoatChat.Checked = false;
                }
            }
        }
    }
}
