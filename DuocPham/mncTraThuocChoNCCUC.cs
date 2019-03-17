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
    public partial class mncTraThuocChoNCCUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncTraThuocChoNCCUC()
        {
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hi?n th? theo kích thu?c c?a màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;

            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1386 là chi?u r?ng, 788 là chi?u cao Form khi thi?t k?, xem trong Properties c?a Form
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            loadForm();
        }

        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                //g?i d? quy n?u nhu 1 control nào có ch?a các control khác n?a

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                //canh l?i to? d? x, y, chi?u r?ng, cao cho các control trên form

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }

        private void loadForm()
        {
            Common.clsControl.LoadLookup(lkDonViNhan, "DanhSachDonViGiao_NhapBenNgoai", 2);
            Common.clsControl.LoadLK(lkDonViGiao, "DanhSachDonViNhan_NhapBenNgoai");
            Common.clsControl.LoadLK(lkTrangThai, "DanhSachTrangThai_NhapBenNgoai");
            dtNgayTra.DateTime = DateTime.Now;
            dtNgayNhap.DateTime = DateTime.Now;
            dtNgayHoaDon.DateTime = DateTime.Now;
            Common.clsControl.LoadLookUpRepos(lkDuoc, "DanhMucDuoc_NhapBenNgoai");
            Common.clsControl.LoadLookUpRepos(lkDVT, "DonViTinh");

        }

        private void GetChungTu_ChiTiet(int ID)
        {
            EntityClass.Cls_ChungTu ct = new EntityClass.Cls_ChungTu();
            ct.Get_By_Key(ID);
            if (ct.mvarChungTu_Id > 0)
            {
                txtSoPhieu.Tag = ct.mvarChungTu_Id;
                txtPhieuNhap.Tag = ct.mvarChungTu_Id;
                lkDonViGiao.EditValue = ct.mvarKhoNhap_Id;
                lkNguoiGiao.EditValue = ct.mvarNguoiGiao_Id;
                lkDonViNhan.EditValue = ct.mvarDonViGiao_Id;
                dtNgayNhap.DateTime = ct.mvarNgayNhap;
                dtNgayHoaDon.DateTime = ct.mvarNgayTao;
                txtSoSeRi.Text = ct.mvarSoSeri;
                txtSoHoaDon.Text = ct.mvarSoHoaDon;
                lkTrangThai.EditValue = ct.mvarTrangThai;
                txtDienGiai.Text = ct.mvarDienGiai;
            }

        }

        private void GetChungTuNhap()
        {
            EntityClass.Cls_ChungTu_ChiTiet ctct = new EntityClass.Cls_ChungTu_ChiTiet();
            DataTable dt = new DataTable();
            dt = ctct.GetThongtinChungTu(int.Parse(txtPhieuNhap.Tag.ToString()));
            if (ctct.mvarChungTuChiTiet_Id > 0)
            {
                //dt = ctct.GetThongtinChungTu(int.Parse(txtPhieuNhap.Tag.ToString()));
                gridControl1.DataSource = dt;
            }
        }

        private void GetChungTuTra()
        {
            EntityClass.Cls_ChungTu_ChiTiet ctct = new EntityClass.Cls_ChungTu_ChiTiet();
            DataTable dt = new DataTable();
            dt = ctct.GetThongtinChungTuHoanTra(int.Parse(txtSoPhieu.Tag.ToString()));
            if (ctct.mvarChungTuChiTiet_Id > 0)
            {
                //dt = ctct.GetThongtinChungTuHoanTra(int.Parse(txtSoPhieu.Tag.ToString()));
                gridControl1.DataSource = dt;
            }
        }



        private void txtPhieuNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                GetChungTu_ChiTiet(int.Parse(txtPhieuNhap.Text));
                GetChungTuNhap();
            }
        }

        private void txtSoPhieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                GetChungTu_ChiTiet(int.Parse(txtSoPhieu.Text));
                GetChungTuTra();
            }

        }
    }

}
