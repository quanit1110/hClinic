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
    public partial class mnc1DMDichVuUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mnc1DMDichVuUC()
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
            tvDanhMuc.ImageList = imageList1;
            ThuVien.DanhMuc.loadTV(tvDanhMuc);
            Common.clsControl.LoadLK(lkDonGia, "TienTe");
        }
        private void CleanForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextEdit)
                {
                    ((TextEdit)c).Text = String.Empty;
                }
                if (c is LookUpEdit)
                {
                    ((LookUpEdit)c).Text = String.Empty;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
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

        private void tvDanhMuc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            ThuVien.loadform.clearForm(this.groupBox1);
            txtMDV.Text = e.Node.Tag.ToString();
            string level = e.Node.Level.ToString();
            DataTable dt = new DataTable();
            SqlConnection con = ThuVien.mySQL.Conn();
            string sql_LoaiDV = "select * from [mHIS_Hethong].[dbo].[view_DM_LoaiDichVu] where LoaiDichVu_Id=" + txtMDV.Text + "";
            string sql_NhomDV = "select * from [mHIS_Hethong].[dbo].[view_DM_NhomDichVu] where NhomDichVu_Id=" + txtMDV.Text + "";
            string sql_DichVu = "select * from [mHIS_Hethong].[dbo].[view_DM_DichVu] where DichVu_Id=" + txtMDV.Text + "";
            if(level == "0")
            {

                SqlDataAdapter da = new SqlDataAdapter(sql_LoaiDV, con);
                da.Fill(dt);
                txtMDV.Text = dt.Rows[0]["LoaiDichVu_Id"].ToString();
                txtMQD.Text = dt.Rows[0]["MaLoaiDichVu"].ToString();
                txtTDV.Text = dt.Rows[0]["TenLoaiDichVu"].ToString();
            }
            else
                if(level == "1")
            {

                SqlDataAdapter da = new SqlDataAdapter(sql_NhomDV, con);
                da.Fill(dt);

            }
            else
            {

                SqlDataAdapter da = new SqlDataAdapter(sql_DichVu, con);
                da.Fill(dt);
                //txtMDV.Text = dt.Rows[0]["MaDichVu"].ToString();
                txtCTMDV.Text = dt.Rows[0]["MaDichVu_Seg01"].ToString();
                txtMQD.Text = dt.Rows[0]["MaQuiDinh"].ToString();
                txtIC.Text = dt.Rows[0]["InputCode"].ToString();
                txtTDV.Text = dt.Rows[0]["TenDichVu"].ToString();
                txtTT.Text = dt.Rows[0]["TenKhongDau"].ToString();
                txtDVT.Text = dt.Rows[0]["DonViTinh"].ToString();
                txtSTT.Text = dt.Rows[0]["Cap"].ToString();
                txtPhim.Text = dt.Rows[0]["SoPhim"].ToString();
                if ( dt.Rows[0]["CoGiaDichVu"].ToString() == "True")
                {
                    ckbCoGiaDichVu.Checked = true;
                }
                else
                {
                    ckbCoGiaDichVu.Checked = false;
                }
                if (dt.Rows[0]["GiaCoDinh"].ToString() == "True")
                {
                    ckbCoGiaDichVu.Checked = true;
                }
                else
                {
                    ckbCoGiaDichVu.Checked = false;
                }
                if (dt.Rows[0]["Test"].ToString() == "True")
                {
                    ckbTest.Checked = true;
                }
                else
                {
                    ckbTest.Checked = false;
                }
                if (dt.Rows[0]["TamNgung"].ToString() == "True")
                {
                    ckbTamNgung.Checked = true;
                }
                else
                {
                    ckbTamNgung.Checked = false;
                }

                if (dt.Rows[0]["ChonHetCapDuoi"].ToString() == "True")
                {
                    ckbChonHetCapDuoi.Checked = true;
                }
                else
                {
                    ckbChonHetCapDuoi.Checked = false;
                }
                if (dt.Rows[0]["PrintWhenNull"].ToString() == "True")
                {
                    ckbIn.Checked = true;
                }
                else
                {
                    ckbIn.Checked = false;
                }
                if (dt.Rows[0]["CoGiaTriChuan"].ToString() == "True")
                {
                    ckbCoGiaTriChuan.Checked = true;
                }
                else
                {
                    ckbCoGiaTriChuan.Checked = false;
                }
                if (dt.Rows[0]["NoResult"].ToString() == "True")
                {
                    ckbKetQua.Checked = true;
                }
                else
                {
                    ckbKetQua.Checked = false;
                }
                if (dt.Rows[0]["ThucHienBenNgoai"].ToString() == "True")
                {
                    ckbThucHienBenNgoai.Checked = true;
                }
                else
                {
                    ckbThucHienBenNgoai.Checked = false;
                }

                lkApDungCho.Properties.NullText = dt.Rows[0]["ApplyFor"].ToString();
                txtDacBiet.Text = dt.Rows[0]["Attribute2"].ToString();
                txtTiengAnh.Text = dt.Rows[0]["TenDichVu_En"].ToString();
                txtReportCode.Text = dt.Rows[0]["ReportCode"].ToString();
                txtReportTitle.Text = dt.Rows[0]["ReportTitle"].ToString();

                //ThuVien.DanhMuc.LayDonGia(txtDonGia,lkDonGia,txtMDV.Text);
            }
       
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

     
        
    }
}
