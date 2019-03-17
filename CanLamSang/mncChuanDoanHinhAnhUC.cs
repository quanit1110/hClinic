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
    public partial class mncChuanDoanHinhAnhUC : DevExpress.XtraEditors.XtraUserControl
    {
        EntityClass.cls_CLSYeuCau cls = new EntityClass.cls_CLSYeuCau();
        EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
        EntityClass.cls_CLSKetQua kq = new EntityClass.cls_CLSKetQua();
        public mncChuanDoanHinhAnhUC()
        {
            InitializeComponent();
            //l?y kích thu?c c?a màn hình
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
            ThuVien.loadform.disableControl(this);
            LoadLookUp();
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
            Common.clsControl.LoadLK(lkNoiChiDinh, "NoiChiDinh");
            Common.clsControl.LoadLK(lkBSChiDinh, "BacSi_CanLamSan");
            Common.clsControl.LoadLK(lkDVThucHien, "DonViThucHien");
            Common.clsControl.LoadLK(lkBSKetLuan, "BacSi_CanLamSan");
            Common.clsControl.LoadLK(lkKyThuatVien, "KyThuatVien");
            Common.clsControl.LoadLK(lkThietBi, "ThietBi");
            Common.clsControl.LoadLK(lkTrangThai, "CLS_TrangThai");
        }

        public bool addCommand()
        {
            
            return true;
        }

        public bool saveCommand()
        {
            getDataInForm();
            cls.mvarCLSYeuCau_Id = int.Parse(ThuVien.mySQL.getIdByNameFiled(cls.mvarSoPhieuYeuCau, "sp_clsYeuCau", "@Action", "GetData_BySoPhieuYeuCau", "@SoPhieuYeuCau"));
            
            bool check = ThuVien.mySQL.updateValue("Update CLSYeuCau set SoPhieuYeuCau=@SoPhieuYeuCau,NgayYeuCau=@NgayYeuCau,BacSiChiDinh_Id=@BacSiChiDinh_Id,ChanDoan=@ChanDoan,NoiThucHien_Id=@NoiThucHien_Id,ThoiGianYeuCau=@ThoiGianYeuCau,NoiDungChiTiet=@NoiDungChiTiet,TiemCanQuang=@TiemCanQuang WHERE CLSYeuCau_Id = "+ cls.mvarCLSYeuCau_Id,
                "@SoPhieuYeuCau", cls.mvarSoPhieuYeuCau,
                "@NgayYeuCau", cls.mvarNgayYeuCau.ToString(),
                "@BacSiChiDinh_Id", cls.mvarBacSiChiDinh_Id.ToString(),
                "@ChanDoan", cls.mvarChanDoan,
                "@NoiThucHien_Id", cls.mvarNoiThucHien_Id.ToString(),
                "@ThoiGianYeuCau", cls.mvarThoiGianYeuCau.ToString(), 
                "@NoiDungChiTiet", cls.mvarNoiDungChiTiet.ToString(), 
                "@TiemCanQuang", cls.mvarTiemCanQuang.ToString());
            bool checkKQ = false;
            if (check == true)
            {
                string getKqId = ThuVien.mySQL.getIdByNameFiled(cls.mvarCLSYeuCau_Id.ToString(), "sp_CLSKETQUA", "@Action", "getIdByCLSYC", "@CLSYeuCau_Id");
                kq.mvarCLSYeuCau_Id = cls.mvarCLSYeuCau_Id;
                if (getKqId != null)
                {
                    kq.mvarCLSKetQua_Id = int.Parse(getKqId);
                
                    checkKQ = ThuVien.mySQL.updateValue("Update CLSKetQua set NoiChiDinh_Id=@NoiChiDinh_Id,ChanDoanLamSang=@ChanDoanLamSang,NoiThucHien_Id=@NoiThucHien_Id,TiemCanQuang=@TiemCanQuang,SoPhimSuDung=@SoPhimSuDung,BacSiKetLuan_Id=@BacSiKetLuan_Id,KyThuatVien01_Id=@KyThuatVien01_Id,TrangThai=@TrangThai,GhiChu=@GhiChu,MaYTe=@MaYTe,KhoaDuLieu=@KhoaDuLieu,SoVaoVien=@SoVaoVien, KetLuan=@KetLuan WHERE CLSKetQua_Id = " + kq.mvarCLSKetQua_Id,
                    "@NoiChiDinh_Id", kq.mvarNoiChiDinh_Id.ToString(),
                    "@ChanDoanLamSang", kq.mvarChanDoanLamSang,
                    "@NoiThucHien_Id", kq.mvarNoiThucHien_Id.ToString(),
                    "@TiemCanQuang", kq.mvarTiemCanQuang.ToString(),
                    "@SoPhimSuDung", kq.mvarSoPhimSuDung.ToString(),
                    "@BacSiKetLuan_Id", kq.mvarBacSiKetLuan_Id.ToString(),
                    "@KyThuatVien01_Id", kq.mvarKyThuatVien01_Id.ToString(),
                    "@TrangThai", kq.mvarTrangThai.ToString(),
                    "@GhiChu", kq.mvarGhiChu.ToString(),
                    "@MaYTe", kq.mvarMaYTe.ToString(),
                    "@KhoaDuLieu", kq.mvarKhoaDuLieu.ToString(),
                    "@SoVaoVien", kq.mvarSoVaoVien.ToString(),
                    "@KetLuan", kq.mvarKetLuan.ToString());
                }
                else
                {
                    kq.mvarNgayThucHien = DateTime.Now.Date;
                    kq.mvarThoiGianThucHien = DateTime.Now;
                    kq.mvarNgayGioThucHien = DateTime.Now;
                    kq.mvarGioThucHien = DateTime.Now.Hour;
                    kq.mvarNamThucHien= DateTime.Now.Year;
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
            if (check==false|| checkKQ ==false)
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

        public bool deleteCommand()
        {
            EntityClass.cls_CLSYeuCau yc = new EntityClass.cls_CLSYeuCau();
            yc.mvarCLSYeuCau_Id = int.Parse(yc.getIdBySoPhieu(txtSoPhieu.Text));
            yc.Delete();
            return false;
        }

        public bool editCommand()
        {

            return false;
        }

        private void getDataInForm()
        {
            cls.mvarSoPhieuYeuCau = txtSoPhieu.Text;
            cls.mvarNgayYeuCau = DateTime.Parse(dtNgayChiDinh.Text);
            //cls.mvarNoi = int.Parse(lkNoiChiDinh.EditValue.ToString());
            cls.mvarBacSiChiDinh_Id = int.Parse(lkBSChiDinh.EditValue.ToString());
            cls.mvarChanDoan = txtLamSang.Text;
            cls.mvarNoiThucHien_Id = int.Parse(lkDVThucHien.EditValue.ToString());
            cls.mvarThoiGianYeuCau = DateTime.Parse(dtThoiGian.Text.ToString());
            cls.mvarNoiDungChiTiet = txtNoiDung.Text;
            cls.mvarTiemCanQuang = chTimCanQuang.Checked;

            kq.mvarNoiChiDinh_Id = int.Parse(lkNoiChiDinh.EditValue.ToString());
            kq.mvarChanDoanLamSang= txtLamSang.Text;
            kq.mvarNoiThucHien_Id= int.Parse(lkDVThucHien.EditValue.ToString());
            kq.mvarTiemCanQuang = chTimCanQuang.Checked;
            //so luong cls.mvs
            kq.mvarSoPhimSuDung = int.Parse(txtSL.Text);
            //GT
            kq.mvarBacSiKetLuan_Id = int.Parse(lkBSKetLuan.EditValue.ToString());
            kq.mvarKyThuatVien01_Id = int.Parse(lkKyThuatVien.EditValue.ToString());
            //bn.mvarNamSinh
            kq.mvarTrangThai = lkTrangThai.EditValue.ToString();
            kq.mvarGhiChu = txtGhiChu.Text;
            //kq.mvarMaYTe = lkMaYTe.EditValue.ToString();
            kq.mvarMaYTe = txtMaYTe.Text;
            kq.mvarKhoaDuLieu = chKhoaKQ.Checked;
            //bn.mvarSoVaoVien = txtSoVaoVien.Text;
            kq.mvarSoVaoVien= txtSoVaoVien.Text;

            kq.mvarKetLuan = txtKetLuan.Text;
            //kq.

        }
    }
}
    