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
    public partial class mnc1DanhMucPhongBanUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mnc1DanhMucPhongBanUC()
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
            tvPhongBan.ImageList = imageList1;
            ThuVien.DanhMuc.loadTVPB(tvPhongBan);
            Common.clsControl.LoadLK(lkLoaiPhongBan, "LoaiPhongBan");
            Common.clsControl.LoadLK(lkLoaiPhongBan1, "LoaiPhongBan");
            Common.clsControl.LoadLK(lkLoaiPhongBenh, "LoaiPhongBenh");
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

        private void tvPhongBan_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            ThuVien.loadform.clearForm(this.groupBox1);
            txtMaPhongBan.Text = e.Node.Tag.ToString();
            DataTable dt = new DataTable();
            SqlConnection con = ThuVien.mySQL.Conn();
            string sql = "select * from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where PhongBan_Id=" + txtMaPhongBan.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            txtMaQuiDinh.Text = dt.Rows[0]["MaTheoQuiDinh"].ToString();
            txtTenPhongBan.Text = dt.Rows[0]["TenPhongBan"].ToString();
            txtTenTiengAnh.Text = dt.Rows[0]["TenPhongBan_En"].ToString();
            txtTenTiengNga.Text = dt.Rows[0]["TenPhongBan_Ru"].ToString();
            lkLoaiPhongBan1.Properties.NullText = dt.Rows[0]["LoaiPhongBan_Id"].ToString();
            lkCap1.Properties.NullText = dt.Rows[0]["Cap"].ToString();
            lkCapTren1.Properties.NullText = dt.Rows[0]["CapTren_Id"].ToString();
            txtTruongPhong.Text = dt.Rows[0]["TruongPhong"].ToString();
            lkLoaiPhongBenh.Properties.NullText = dt.Rows[0]["LoaiPhongBenh_Id"].ToString();
            lkCostCenter.Properties.NullText = dt.Rows[0]["CostCenTer_Id"].ToString();

            string tn= dt.Rows[0]["TamNgung"].ToString();
            if (tn== "True")
            {
                cbTamNgung.Checked = true;
            }
            else
            {
                cbTamNgung.Checked = false;
            }

            string dv = dt.Rows[0]["CoThucHienDichVu"].ToString();
            if (dv == "True")
            {
                cbDichVu.Checked = true;
            }
            else
            {
                cbDichVu.Checked = false;
            }

            string ns = dt.Rows[0]["QuanLyNhanSu"].ToString();
            if (ns == "True")
            {
                cbQLNhanSu.Checked = true;
            }
            else
            {
                cbQLNhanSu.Checked = false;
            }

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            tvPhongBan.Nodes.Clear();
            string where = lkLoaiPhongBan.EditValue.ToString(); 
            ThuVien.DanhMuc.TimloadTVPB(tvPhongBan,where);
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            tvPhongBan.Nodes.Clear();
        }
    }
}
