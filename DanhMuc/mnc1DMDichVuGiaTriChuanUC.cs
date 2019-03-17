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
    public partial class mnc1DMDichVuGiaTriChuanUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mnc1DMDichVuGiaTriChuanUC()
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
            tvNhomDichVu.ImageList = imageList1;
            ThuVien.DanhMuc.loadTV(tvNhomDichVu);
            Common.clsControl.LoadLK(lkPhanNhomDichVu, "DM_NhomDichVu");
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

        private void tvNhomDichVu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string level = e.Node.Level.ToString();
            string maDV = e.Node.Tag.ToString();
            ThuVien.loadform.clearForm(this.groupBox1);
            if(level == "2" || level == "3")
            {
                SqlConnection con = ThuVien.mySQL.Conn();
                string sql = "select * from [mHIS_Hethong].[dbo].[view_DM_DichVu_GiaTriChuan] where DichVu_Id=" + maDV + "";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtTenDichVu.Text = dr["TenDichVu"].ToString();
                    txtDonVi.Text = dr["DonViTinh"].ToString();
                    lkKieuDuLieu.Properties.NullText = dr["KieuDuLieu"].ToString();
                    txtNamMax.Text = dr["Nam_Max"].ToString();
                    txtNamMin.Text = dr["Nam_Min"].ToString();
                    txtNuMax.Text = dr["Nu_Max"].ToString();
                    txtNuMin.Text = dr["Nu_Min"].ToString();
                    txtTreEmMin.Text = dr["TreEm_Min"].ToString();
                    txtTreEmMax.Text = dr["TreEm_Max"].ToString();
                    txtGhiChu.Text = dr["GhiChu"].ToString();
                }
            }
        }
    }
}
