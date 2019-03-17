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

namespace CanLamSang
{
    public partial class mncChuanDoanHinhAnhXQuangCTMRIUC : DevExpress.XtraEditors.XtraUserControl
    {
        EntityClass.cls_CLSYeuCau cls = new EntityClass.cls_CLSYeuCau();
        EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
        EntityClass.cls_CLSKetQua kq = new EntityClass.cls_CLSKetQua();
        public mncChuanDoanHinhAnhXQuangCTMRIUC()
        {
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            ThuVien.loadform.disableControl(this);
            LoadLookUp();
        }
        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }

        private void btSoPhieu_Click(object sender, EventArgs e)
        {
            ThuVien.FcLoadLookup mayte = new ThuVien.FcLoadLookup("[hsvClinic].[dbo].[CLSYeuCau]", "CLSYeuCau_Id", "SoPhieuYeuCau", "BenhNhan_Id", "");
            mayte.ShowDialog();
            string ID = mayte.lkId;
            if (mayte.lkChange)
            {
                txtSoPhieu.Text = mayte.lkInt;
                EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
                DataRow dr = bn.Get_ThongTinBenhNhan_For_CanLamSang(mayte.lkText);
                if (dr.Table.Rows[0]["BenhNhan_Id"].ToString().Length > 0)
                {
                    txtMaYTe.Text = dr.Table.Rows[0]["MaYTe"].ToString();
                    txtSoVaoVien.Text = dr.Table.Rows[0]["SoVaoVien"].ToString();
                    lbHoTen.Text = dr.Table.Rows[0]["TenBenhNhan"].ToString();
                    lbGioiTinh.Text = dr.Table.Rows[0]["GioiTinh"].ToString();
                    lbNamSinh.Text = dr.Table.Rows[0]["NamSinh"].ToString(); ;
                    lbDiaChi.Text = dr.Table.Rows[0]["DiaChi"].ToString();
                    lbDoiTuong.Text = dr.Table.Rows[0]["TenDoiTuong"].ToString();
                    lbTuoi.Text = dr.Table.Rows[0]["Tuoi"].ToString();
                }
            }
            GetSoPhieuCLS(txtSoPhieu.Text);
        }
        private void GetSoPhieuCLS(string ID)
        {
            EntityClass.cls_CLSYeuCau cls = new EntityClass.cls_CLSYeuCau();
            cls.GetData_BySoPhieuYeuCau(ID);
            if (cls.mvarCLSYeuCau_Id > 0)
            {
                dtNgayChiDinh.Text = cls.mvarNgayYeuCau.ToString("dd/M/yyyy");
                lkNoiChiDinh.EditValue = cls.mvarNoiYeuCau_Id;
                txtLamSang.Text = cls.mvarChanDoan;
                lkBSChiDinh.EditValue = cls.mvarBacSiChiDinh_Id;
                lkDVThucHien.EditValue = cls.mvarNoiThucHien_Id;
            }
        }
        private void LoadLookUp()
        {
            Common.clsControl.LoadLK(lkNoiChiDinh, "NoiYeuCauCLS");
            Common.clsControl.LoadLK(lkBSChiDinh, "BacSi_CanLamSan");
            Common.clsControl.LoadLK(lkDVThucHien, "DonViThucHien");
            Common.clsControl.LoadLK(lkBSKetLuan, "BacSi_CanLamSan");
            Common.clsControl.LoadLK(lkKyThuatVien, "KyThuatVien");
            Common.clsControl.LoadLK(lkThietBi, "ThietBi");
            Common.clsControl.LoadLK(lkNhanXet, "NhanXet_CLS");
            Common.clsControl.LoadLK(lkDichVuCLS, "NhomDichVu");
        }

        public bool addCommand()
        {
            return true;
        }

        public bool saveCommand()
        {
            getDataInForm();
            cls.mvarCLSYeuCau_Id = int.Parse(ThuVien.mySQL.getIdByNameFiled(cls.mvarSoPhieuYeuCau, "sp_clsYeuCau", "@Action", "GetData_BySoPhieuYeuCau", "@SoPhieuYeuCau"));

            bool check = ThuVien.mySQL.updateValue("Update CLSYeuCau set SoPhieuYeuCau=@SoPhieuYeuCau,NgayYeuCau=@NgayYeuCau,BacSiChiDinh_Id=@BacSiChiDinh_Id,ChanDoan=@ChanDoan,NoiThucHien_Id=@NoiThucHien_Id,NoiDungChiTiet=@NoiDungChiTiet WHERE CLSYeuCau_Id = " + cls.mvarCLSYeuCau_Id,
                "@SoPhieuYeuCau", cls.mvarSoPhieuYeuCau,
                "@NgayYeuCau", cls.mvarNgayYeuCau.ToString(),
                "@BacSiChiDinh_Id", cls.mvarBacSiChiDinh_Id.ToString(),
                "@ChanDoan", cls.mvarChanDoan,
                "@NoiThucHien_Id", cls.mvarNoiThucHien_Id.ToString(),
                "@NoiDungChiTiet", cls.mvarNoiDungChiTiet.ToString());
            bool checkKQ = false;
            if (check == true)
            {
                string getKqId = ThuVien.mySQL.getIdByNameFiled(cls.mvarCLSYeuCau_Id.ToString(), "sp_CLSKETQUA", "@Action", "getIdByCLSYC", "@CLSYeuCau_Id");
                kq.mvarCLSYeuCau_Id = cls.mvarCLSYeuCau_Id;
                if (getKqId != null)
                {
                    kq.mvarCLSKetQua_Id = int.Parse(getKqId);

                    checkKQ = ThuVien.mySQL.updateValue("Update CLSKetQua set NgayChiDinh=@NgayChiDinh, NoiChiDinh_Id=@NoiChiDinh_Id, BacSiChiDinh=@BacSiChiDinh,ChanDoanLamSang=@ChanDoanLamSang,NoiThucHien_Id=@NoiThucHien_Id,NgayGioThucHien=@NgayGioThucHien,BacSiKetLuan_Id=@BacSiKetLuan_Id,KyThuatVien01_Id=@KyThuatVien01_Id,MaYTe=@MaYTe,KhoaDuLieu=@KhoaDuLieu,ThietBi_Id=@ThietBi_Id,SoVaoVien=@SoVaoVien, KetLuan=@KetLuan WHERE CLSKetQua_Id = " + kq.mvarCLSKetQua_Id,
                    "@NgayChiDinh",kq.mvarNgayChiDinh.ToString(),
                    "@BacSiChiDinh", kq.mvarBacSiChiDinh,
                    "@NoiChiDinh_Id", kq.mvarNoiChiDinh_Id.ToString(),
                    "@NgayGioThucHien", kq.mvarNgayGioThucHien.ToString(),
                    "@ThietBi_Id", kq.mvarThietBi_Id.ToString(),
                    "@ChanDoanLamSang", kq.mvarChanDoanLamSang,
                    "@NoiThucHien_Id", kq.mvarNoiThucHien_Id.ToString(),
                    "@BacSiKetLuan_Id", kq.mvarBacSiKetLuan_Id.ToString(),
                    "@KyThuatVien01_Id", kq.mvarKyThuatVien01_Id.ToString(),
                    "@MaYTe", kq.mvarMaYTe.ToString(),
                    "@KhoaDuLieu", kq.mvarKhoaDuLieu.ToString(),
                    "@SoVaoVien", kq.mvarSoVaoVien.ToString(),
                    "@KetLuan", kq.mvarKetLuan.ToString());
                }
                else
                {
                    kq.mvarNgayThucHien = DateTime.Now.Date;
                    //kq.mvarNgayGioThucHien = DateTime.Now;
                    kq.mvarThoiGianThucHien = DateTime.Now;
                    kq.mvarGioThucHien = DateTime.Now.Hour;
                    kq.mvarNamThucHien = DateTime.Now.Year;
                    kq.mvarThangThucHien = DateTime.Now.Month;
                    String checkAdd = kq.Add();
                    if (checkAdd == "err" || String.IsNullOrEmpty(checkAdd))
                    {
                        checkKQ = false;
                    }
                    else
                    {
                        checkKQ = true;
                    }
                }
            }
            //string checkCls = cls.Add();
            //string checkkq = kq.Add();
            if (check == false || checkKQ == false)
            {
                MessageBox.Show("Lưu dữ liệu không thành công!");
                return false;
            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thành công!");
                return true;
            }
        }

        public void editCommand()
        {

        }

        public bool deleteCommand()
        {
            return false;
        }

        private void getDataInForm()
        {
            cls.mvarSoPhieuYeuCau = txtSoPhieu.Text;
            cls.mvarNgayYeuCau = DateTime.Parse(dtNgayChiDinh.Text);
            //cls.mvarNoi = int.Parse(lkNoiChiDinh.EditValue.ToString());
            cls.mvarBacSiChiDinh_Id = int.Parse(lkBSChiDinh.EditValue.ToString());
            cls.mvarNoiDungChiTiet = txtNoiDung.Text;
            cls.mvarChanDoan = txtLamSang.Text;//snv
            cls.mvarNoiThucHien_Id = int.Parse(lkDVThucHien.EditValue.ToString());
            
            kq.mvarNgayChiDinh = DateTime.Parse(dtNgayChiDinh.Text);
            kq.mvarNoiChiDinh_Id = int.Parse(lkNoiChiDinh.EditValue.ToString());
            kq.mvarBacSiChiDinh = lkBSChiDinh.EditValue.ToString();
            kq.mvarSoVaoVien = txtSoVaoVien.Text;
            kq.mvarChanDoanLamSang = txtLamSang.Text;
            kq.mvarNoiThucHien_Id = int.Parse(lkDVThucHien.EditValue.ToString());
            kq.mvarBacSiKetLuan_Id = int.Parse(lkBSKetLuan.EditValue.ToString());
            kq.mvarKyThuatVien01_Id = int.Parse(lkKyThuatVien.EditValue.ToString());
            kq.mvarNgayGioThucHien = DateTime.Parse(dtNgayGioThucHien.Text);
            kq.mvarMaYTe = txtMaYTe.Text;
            kq.mvarKhoaDuLieu = chKhoaKQ.Checked;
            kq.mvarThietBi_Id = int.Parse(lkThietBi.EditValue.ToString());
            kq.mvarKetLuan = txtKetLuan.Text;

        }
    }
}
