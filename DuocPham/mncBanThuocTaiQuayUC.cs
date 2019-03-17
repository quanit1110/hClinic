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
    public partial class mncBanThuocTaiQuayUC : DevExpress.XtraEditors.XtraUserControl
    {
        
        #region Khai báo biến    
        DataTable dt = new DataTable();
        int status = 0;

        #endregion
        /*-----------------------------------------------*/
        #region Khởi tạo from

        public mncBanThuocTaiQuayUC()
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
        #endregion
        /*-----------------------------------------------*/
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
            ThuVien.loadform.enableControl(this);
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
        private void btnMaYTe_Click(object sender, EventArgs e)
        {
            ThuVien.FcLoadLookup mayte = new ThuVien.FcLoadLookup("[hsvClinic].[dbo].[DM_BenhNhan]", "BenhNhan_Id", "TenBenhNhan", "SoVaoVien", "");
            mayte.ShowDialog();
            if (mayte.lkChange)
            {
                txtMaYTe.Text = mayte.lkText;
                txtMaYTe.Tag = mayte.lkId;
                LoadTTBN_SoVaoVien(txtMaYTe.Text);
            }
            mayte.Dispose();
        }
        private string LoadTTBN_SoVaoVien(string sovaovien)
        {
            EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
            bn.Get_By_MaYTe(sovaovien);
            if (bn.mvarBenhNhan_Id > 0)
            {
                txtMaYTe.Text = bn.mvarSoVaoVien;
                txtMaYTe.Tag = bn.mvarBenhNhan_Id;
                txtDiaChi.Text = bn.mvarDiaChi;
                txtTenBenhNhan.Text = bn.mvarTenBenhNhan;
                txtNamSinh.Text = bn.mvarNamSinh.ToString(); 
                if (bn.mvarGioiTinh == "T")
                {
                    rdNam.Checked = true;
                    rdNu.Checked = false;
                }
                else
                {
                    rdNu.Checked = true;
                    rdNam.Checked = false;
                }
            }
            return bn.mvarBenhNhan_Id.ToString();
        }

        private void txtMaYTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String chuoi = (sender as TextEdit).Text.ToString();// txtHoTen.Text;

                if (chuoi.Length >= 8 && chuoi.Length < 15)
                {
                    txtMaYTe.Tag = LoadTTBN_SoVaoVien(chuoi);
                }
                else if (chuoi.Length > 15)
                {
                    txtMaYTe.Tag = LoadTTBN_QrCode(chuoi);
                }
            }
        }
        //Load thông tin bệnh nhân theo qrcode
        private string LoadTTBN_QrCode(string qr_Code)
        {
            int rs = Common.clsQrCode.HamTachChuoi_QRCODE(qr_Code);
            if (rs == 3)
            {
                return LoadTTBN_SoVaoVien(Common.clsQrCode.SoVaoVien);
            }
            return "";
        }

        private void mncBanThuocTaiQuayUC_Load(object sender, EventArgs e)
        {
            Common.clsControl.LoadLookup(lkNguonDuoc, "DanhSachKhoDuoc", 2, "", "", "Kho dược", "Id");
            Common.clsControl.LoadLookup(lkNoiGiao, "DanhSachDonViGiao_ThanhLy", 2, "", "", "Nơi giao", "Id");
            Common.clsControl.LoadLookup(lkNguoiGiao, "NhanVien", 2, "", "", "Nhân viên", "Id");
            Common.clsControl.LoadLookup(lkDuoc, "Get_Dm_Duoc", 2, "", "", "Tên dược", "Id");
            Common.clsControl.LoadLookup(lkSoLo, "getAll_SoLoNhap", 2, "", "", "Số lô", "Id");//SoLoNhap_ByKhoa_Id
            Common.clsControl.LoadLookup(lkDoiTuong, "DoiTuong", 2, "", "", "Đối tượng", "Id");
        }

        private void btnSoPhieu_Click(object sender, EventArgs e)
        {

            ThuVien.FcLoadLookup chungtu = new ThuVien.FcLoadLookup("[hsvClinic].[dbo].[ChungTu]", "ChungTu_Id",  "SoChungTu", "MaChungTu", "");
            chungtu.ShowDialog();
            if (chungtu.lkChange)
            {
                txtSoPhieu.Text = chungtu.lkText;
                txtSoPhieu.Tag = chungtu.lkId;
                LoadTTChungTu(int.Parse(chungtu.lkId));
            }
            chungtu.Dispose();
        }

        private void LoadTTChungTu(int chungTu_Id)
        {
            EntityClass.Cls_ChungTu chungTu = new EntityClass.Cls_ChungTu();
            chungTu.Get_By_Key(chungTu_Id);
            if(chungTu.mvarChungTu_Id>0)
            {
                txtTenBenhNhan.Text = chungTu.mvarTenBenhNhan;
                txtDienGiai.Text = chungTu.mvarDienGiaiNghiepVuPhatSinh;
                dtNgayGiao.DateTime = chungTu.mvarNgayChungTu;
                lkNguoiGiao.EditValue = chungTu.mvarNguoiGiao;
                lkNoiGiao.EditValue = chungTu.mvarKhoXuat_Id;
                EntityClass.Cls_ChungTu_ChiTiet ctct = new EntityClass.Cls_ChungTu_ChiTiet();
                ctct.GetListChiTiet(gridControl1, chungTu.mvarChungTu_Id);
                if (chungTu.mvarGioiTinh == "T")
                {
                    rdNam.Checked = true;
                    rdNu.Checked = false;
                }else if (chungTu.mvarGioiTinh == "G")
                {
                    rdNam.Checked = false;
                    rdNu.Checked = true;
                }
                txtNamSinh.Text =chungTu.mvarNamSinh==int.MinValue?"": chungTu.mvarNamSinh.ToString();
                txtDiaChi.Text = chungTu.mvarDiaChi;
                if (chungTu.mvarDoiTuong_Id > 0) { lkDoiTuong.EditValue = chungTu.mvarDoiTuong_Id; }
                if (chungTu.mvarBenhNhan_Id > 0)
                {
                    EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
                    bn.Get_By_Key(chungTu.mvarBenhNhan_Id);
                    if (bn.mvarBenhNhan_Id > 0)
                    {
                        txtMaYTe.Text = bn.mvarSoVaoVien;
                        txtMaYTe.Tag = bn.mvarBenhNhan_Id;
                        txtDiaChi.Text = bn.mvarDiaChi;
                        txtTenBenhNhan.Text = bn.mvarTenBenhNhan;
                        txtNamSinh.Text = bn.mvarNamSinh.ToString();
                        if (bn.mvarGioiTinh == "T")
                        {
                            rdNam.Checked = true;
                            rdNu.Checked = false;
                        }
                        else
                        {
                            rdNu.Checked = true;
                            rdNam.Checked = false;
                        }
                    }
                }

            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            lbThanhToan.Text = gridView1.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString();
        }
    }
}
