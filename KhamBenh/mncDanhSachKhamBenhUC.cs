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
using DevExpress.XtraGrid;

namespace KhamBenh
{
    public partial class mncDanhSachKhamBenhUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncDanhSachKhamBenhUC()
        {
            InitializeComponent();

            //lấy kích thước của màn hình
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


        private void mncDanhSachKhamBenhUC_Load(object sender, EventArgs e)
        {
            LoadPhongBan(lkPhongBan);
            dtNgayKham.DateTime = DateTime.Now;
            LoadDanhSach(gridControl1,lkPhongBan,txtMaYTe,dtNgayKham,false);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDanhSach(gridControl1, lkPhongBan, txtMaYTe, dtNgayKham, true);
        }

        private void btbBoLoc_Click(object sender, EventArgs e)
        {
            LoadDanhSach(gridControl1, lkPhongBan, txtMaYTe, dtNgayKham, false);
            dtNgayKham.DateTime = DateTime.Now;
            txtMaYTe.Text = "";
            lkPhongBan.EditValue = null;
        }

        private void btbMaYte_Click(object sender, EventArgs e)
        {
            ThuVien.FcLoadLookup mayte = new ThuVien.FcLoadLookup("[hsvClinic].[dbo].[View_DM_BenhNhan]", "BenhNhan_Id", "TenBenhNhan", "SoVaoVien", "");
            mayte.ShowDialog();
            if (mayte.lkChange)
            {
                txtMaYTe.Text = mayte.lkText;
                txtMaYTe.Tag = mayte.lkId;
            }
            mayte.Dispose();
        }

        //////////
        /* Load Lookup Phòng ban*/
        private void LoadPhongBan(LookUpEdit lk)
        {
            //string select = "select Dictionary_Id from[mHIS_Hethong].[dbo].[Lst_Dictionary] where Dictionary_Type_Code = 'LoaiPhongBan' and Dictionary_Code = 'KhamBenh'";
            ThuVien.mySQL.Load_Lookup_2C(lk, "PhongBan_Id", "TenPhongBan", "[mHIS_Hethong].[dbo].[View_DM_PhongBan]", "where LoaiPhongBan_Id = '566'");
        }
        /* End */
        //Load danh sachs khams beenhj
        private void LoadDanhSach(GridControl grv, LookUpEdit lk, TextEdit txt, DateEdit dt, bool ys)
        {
            if (ys)
            {
                string where = "Select SoPhieuYeuCau,TenBenhNhan,NamSinh,DiaChi,TenDichVu,TenPhongBan,TenDoiTuong,TenLoaiGia from [hsvClinic].[dbo].[View_DangKyDichVu] where MaNhomDichVu='04' and NgayYeuCau>='" + dt.DateTime.ToString("yyyy-MM-dd hh:mm:ss") + "'";
                if (lk.EditValue != null) { where = where + " and NoiThucHien_Id='" + lk.EditValue.ToString() + "'"; }
                if (txt.Text.Length > 0) { where = where + " and BenhNhan_Id='" + txt.Tag.ToString() + "'"; }
                ThuVien.mySQL.LoadGirdControl(grv, where);
            }
            else
            {
                string where = "Select SoPhieuYeuCau,TenBenhNhan,NamSinh,DiaChi,TenDichVu,TenPhongBan,TenDoiTuong,TenLoaiGia from [hsvClinic].[dbo].[View_DangKyDichVu] where  MaNhomDichVu='04'";
                ThuVien.mySQL.LoadGirdControl(grv, where);
            }
        }
    }
}
