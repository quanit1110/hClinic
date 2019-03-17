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

namespace DuocPham
{
    public partial class mncPhieuLinhDuocUC : DevExpress.XtraEditors.XtraUserControl
    {
       

        #region Khai báo biến
        int status = 0;
        #endregion
        /*-----------------------------------------------*/
        #region Khởi tạo form
        public mncPhieuLinhDuocUC()
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
        private void mncPhieuLinhDuocUC_Load(object sender, EventArgs e)
        {
            Common.clsControl.LoadLookup(lkNguonDuoc, "DanhSachNguonHang_NhapBenNgoai", 2, "", "", "Nguồn dược", "Id");
            Common.clsControl.LoadLookup(lkNoiGiao, "DanhSachDonViGiao_ThanhLy", 2, "", "", "Nơi giao", "Id");
            Common.clsControl.LoadLookup(lkNoiNhan, "DanhSachDonViNhan_NhapBenNgoai", 2, "", "", "Nơi nhận", "Id");
            Common.clsControl.LoadLookup(lkNguoiNhan, "NhanVien", 2, "", "", "Nhân viên", "Id");
            Common.clsControl.LoadLookup(lkLoaiPhieuLinh, "LoaiPhieuDuoc_PhieuLinhDuoc", 2, "", "", "Loại phiếu", "Id");
            Common.clsControl.LoadLookup(lkMucDich, "HauCanBoSung", 2, "", "", "Mục đích", "Id");
            
        }
        #endregion
        #region Hàm chức năng
        public bool editCommand()
        {
            status = 3;
            return true;
        }

        public bool deleteCommand()
        {
            status = 2;
            return true;
        }
        public bool addCommand()
        {
            status = 1;
            return true;
        }
        public bool saveCommand()
        {
            status = 0;
            return true;
        }

        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí nghiệp vụ
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí sự kiện
        private void btnSoPhieu_Click(object sender, EventArgs e)
        {
            ThuVien.FcLoadLookup chungtu = new ThuVien.FcLoadLookup("[hsvClinic].[dbo].[PhieuLinhDuoc]", "ChungTu_Id", "SoChungTu", "MaChungTu", "");
            chungtu.ShowDialog();
            if (chungtu.lkChange)
            {
                txtSoPhieu.Text = chungtu.lkText;
                txtSoPhieu.Tag = chungtu.lkId;
                LoadTTChungTu(int.Parse(chungtu.lkId));
            }
            chungtu.Dispose();
        }
        private void btnTongHop_Click(object sender, EventArgs e)
        {
            FmTongHopYLenh fm = new FmTongHopYLenh(dtTuNgay.DateTime, DateTime.Now);
            fm.ShowDialog();
            if (fm.DialogResult == DialogResult.OK)
            {
                gridControl1.DataSource = fm.dtYLenh; 
            }
            txtDienGiai.Text = fm.rtvalue;
            fm.Dispose();
        }
        #endregion
        /*-----------------------------------------------*/
        #region Các hàm con
        private void LoadTTChungTu(int chungTu_Id)
        {
            EntityClass.cls_PhieuLinhDuoc chungTu = new EntityClass.cls_PhieuLinhDuoc();
            chungTu.Get_By_Key(chungTu_Id);
            if (chungTu.mvarChungTu_Id > 0)
            {  
                txtDienGiai.Text = chungTu.mvarDienGiaiNghiepVuPhatSinh;
                dtNgayPhieuLinh.DateTime = chungTu.mvarNgayChungTu;
                lkNoiGiao.EditValue = chungTu.mvarKhoXuat_Id;
                lkNoiNhan.EditValue = chungTu.mvarKhoNhap_Id;
                lkNguoiNhan.EditValue = chungTu.mvarNguoiNhan_Id;
                lkLoaiPhieuLinh.EditValue = chungTu.mvarMucDichChungTu_Id;
                lkNguonDuoc.EditValue = chungTu.mvarNguonDuoc_Id;
                EntityClass.cls_PhieuLinhDuocChiTiet ctct = new EntityClass.cls_PhieuLinhDuocChiTiet();
                ctct.GetListChiTiet(gridControl1, chungTu.mvarChungTu_Id);
            }
        }

        #endregion

       
    }
}
