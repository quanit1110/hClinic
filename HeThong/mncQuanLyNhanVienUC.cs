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

namespace HeThong
{
    public partial class mncQuanLyNhanVienUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncQuanLyNhanVienUC()
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
            

            //ThuVien.mySQL.Load_Lookup_2C(lkGroupCode, "Group_Id", "Group_Code", "[hsvClinic].[dbo].[Sys_Groups]", "");
            //Common.clsControl.LoadLookup(lkLanguage, "getLanguage", 2);
            //ThuVien.mySQL.Load_Lookup_1C(lkMaNhanVien, "MaNhanVien", "[hsvClinic].[dbo].[NS_NhanVien]", "");
            //List<SqlParameter> lisPara = new List<SqlParameter>();
            Common.clsControl.LoadLookup(lkPhongBan, "KhoaKham", 2);
            Common.clsControl.LoadLookup(lkDanToc, "DanToc", 2);
            Common.clsControl.LoadLookup(lkQuocTich, "QuocTich", 2);
            Common.clsControl.LoadLookup(lkTinhThanh, "TinhThanhPho", 2);
            EntityClass.cls_NSNhanVien nsNV = new EntityClass.cls_NSNhanVien();
            nsNV.GetListNhanVien(gridControlEX, "GetListData");
            ThuVien.loadform.disableControl(this);
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
        
        private void lkPhongBan_EditValueChanged_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetAllNhanVienByPhongBan_Id");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", lkPhongBan.EditValue.ToString());
            dt = ThuVien.mySQL.ExcDataTable("sp_NS_NhanVien", listPara, dt);
            gridControlEX.DataSource = dt;
        }



        private void btnThemUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xtrHeThong.SelectedTabPage = xtrThongTinGroup;
            
        }

        private void gridControl2_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            }
        }

        public bool saveCommand()
        {

            EntityClass.cls_NSNhanVien nsNV = getDataFromUINhanVien();
            string id = nsNV.Add();
            if (String.IsNullOrEmpty(id)||id=="err")
            {
                MessageBox.Show("Lưu thông tin nhân viên thất bại! Bạn vui lòng kiểm tra lại thông tin.");
            }else
            {
                MessageBox.Show("Lưu thông tin nhân viên thành công!");
            }
            
            return true;
        }

        public bool addCommand()
        {
            ThuVien.loadform.enableControl(this);
            txtMaNhanVien.Text = "";
            txtHo.Text ="";
            txtTen.Text ="";
            lkPhongBan.EditValue= null;
            edtngaySinh.EditValue = null;
            txtnoiSinh.Text="";
            edtGioiTinh.EditValue=null;
            lkDanToc.Properties.ReadOnly=false;
            lkQuocTich.Properties.ReadOnly = false;
            edtTonGiao.EditValue=null;
            txtquequan.Text ="";
            txtdiaChihokhau.Text ="";
            txtdiaChiLienhe.Text ="";
            txtPassport.Text ="";
            txtSoTaiKhoan.Text ="";
            lkNganHang.EditValue = null;
            edtNgayThamGiaCM.EditValue = null;
            edtNgayVaoDoan.EditValue = null;
            edtNgayVaoDang.EditValue = null;
            txtSucKhoe.Text = "";
            txtChieuCao.Text = "";
            txtCanNang.Text = "";
            lkNhomMau.EditValue = null;
            txtdienThoai.Text="";
            txtemail.Text="";
            txtCMND.Text="";
            txtNoiCap.Text="";
            edtNgayCap.EditValue = null;
            lkHonNhan.EditValue = null;
            chbxDangLamViec.Checked = false;
            txtdidong.Text="";
            txtNangKhieu.Text="";
            txtGhiChu.Text="";
            txtMaSoThue.Text="";
            lkTinhThanh.EditValue = null;
            txtSapXep.Text = "";
            lkLoaiHopDong.EditValue = null;
            chbxDangVien.Checked=false;
            
            return true;
        }

        public EntityClass.cls_NSNhanVien getDataFromUINhanVien()
        {
            EntityClass.cls_NSNhanVien nsNV = new EntityClass.cls_NSNhanVien();
            nsNV.mvarMaNhanVien = txtMaNhanVien.Text;
            nsNV.mvarHo = txtHo.Text;
            nsNV.mvarTen = txtTen.Text;
            nsNV.mvarMaPhongBan = lkPhongBan.EditValue.ToString();
            nsNV.mvarHinhAnh = "";
            nsNV.mvarNgaySinh = edtngaySinh.Text.Equals(String.Empty) ? DateTime.MinValue : DateTime.Parse(edtngaySinh.Text);
            nsNV.mvarNoiSinh = txtnoiSinh.Text;
            nsNV.mvarGioiTinh = edtGioiTinh.Text;
            nsNV.mvarMaDanToc = lkDanToc.Text;// lkDanToc.Properties.GetKeyValueByDisplayText(lkDanToc.Text);
            nsNV.mvarMaQuocTich = lkQuocTich.Text;
            nsNV.mvarMaTonGiao = edtTonGiao.Text;
            nsNV.mvarQuequan = txtquequan.Text;
            nsNV.mvarDiaChihokhau = txtdiaChihokhau.Text;
            nsNV.mvarDiaChiLienhe = txtdiaChiLienhe.Text;
            nsNV.mvarPassport = txtPassport.Text;
            nsNV.mvarSoTaikhoan = txtSoTaiKhoan.Text;
            nsNV.mvarNganhang = lkNganHang.Text;
            nsNV.mvarNgayThamGiaCM = edtNgayThamGiaCM.Text.Equals(String.Empty) ? DateTime.MinValue : DateTime.Parse(edtNgayThamGiaCM.Text);
            nsNV.mvarNgayVaoDoan = edtNgayVaoDoan.Text.Equals(String.Empty) ? DateTime.MinValue : DateTime.Parse(edtNgayVaoDoan.Text);
            nsNV.mvarNgayVaoDang = edtNgayVaoDang.Text.Equals(String.Empty) ? DateTime.MinValue : DateTime.Parse(edtNgayVaoDang.Text);
            nsNV.mvarSucKhoe = txtSucKhoe.Text;
            nsNV.mvarChieuCao = txtChieuCao.Text.Equals(String.Empty) ? Double.MinValue : Double.Parse(txtChieuCao.Text);
            nsNV.mvarCanNang = txtCanNang.Text.Equals(String.Empty) ? Double.MinValue : Double.Parse(txtCanNang.Text);
            nsNV.mvarNhomMau = lkNhomMau.Text;
            nsNV.mvarDienThoai = txtdienThoai.Text;
            nsNV.mvarEmail = txtemail.Text;
            nsNV.mvarCMND = txtCMND.Text;
            nsNV.mvarNoiCap = txtNoiCap.Text;
            nsNV.mvarNgayCap = edtNgayCap.Text.Equals(String.Empty) ? DateTime.MinValue : DateTime.Parse(edtNgayCap.Text);
            nsNV.mvarHonNhan = lkHonNhan.Text;
            nsNV.mvarDangLamViec = chbxDangLamViec.Checked.ToString();
            nsNV.mvarDidong = txtdidong.Text;
            nsNV.mvarNangkhieu = txtNangKhieu.Text;
            nsNV.mvarGhichu = txtGhiChu.Text;
            nsNV.mvarMaSoThue = txtMaSoThue.Text;
            nsNV.mvarTinhThanh = lkTinhThanh.Text;
            nsNV.mvarSapXep = txtSapXep.Text.Equals(String.Empty) ? int.MinValue : Int32.Parse(txtSapXep.Text);
            nsNV.mvarMaHopDong = lkLoaiHopDong.Text;
            nsNV.mvarDangVien = chbxDangVien.Checked;
            return nsNV;
        }

        private void lkPhongBan_EditValueChanged(object sender, EventArgs e)
        {
            Common.clsControl.LoadLookup(lkPhongBan, "KhoaKham", 2);
        }

        private void btnChonHA_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Bitmaps|*.bmp|jpeps|*jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureNhanVien.Image = Bitmap.FromFile(open.FileName);
            }
        }
    }
}
