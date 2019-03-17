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

namespace KhamBenh
{
    public partial class mncQuanLyNoiTruUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncQuanLyNoiTruUC()
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

            Common.clsControl.LoadLookup(lkBenhAn, "BenhAnNoiTru", 2);
            Common.clsControl.LoadLookup(lkPhongBan, "KhoaKham", 2);
            Common.clsControl.LoadLookup(lkLoaiBenhAn, "Lib_LoaiBenhAn", 2);
            Common.clsControl.LoadLookup(lkBacSiDieuTri, "BacSi", 2);
            Common.clsControl.LoadLookup(lkBacSiDieuTriChinh, "BacSi", 2);
            Common.clsControl.LoadLookup(lkNguoiLap, "BacSi", 2);
            Common.clsControl.LoadLookup(lkKetQuaDieuTri, "KetQuaDieuTri", 2);
            Common.clsControl.LoadLookup(lkICDChinh_cd, "DsICD", 2);
            Common.clsControl.LoadLookup(lkICDChuanDoan_cd, "DsICD", 2);
            Common.clsControl.LoadLookup(lkICDPhu_cd, "DsICD", 2);
            Common.clsControl.LoadLookup(lkICDRaVien_cd, "DsICD", 2);
            Common.clsControl.LoadLookup(lkNhomMau_qlhc, "NhomMau", 2);
            Common.clsControl.LoadLookup(lkYeuToRh_qlhc, "YeuToRH", 2);
            Common.clsControl.LoadLookup(lkDanToc_qlhc, "DanToc", 2); 
            Common.clsControl.LoadLookup(lkLoaiTaiNan_tttn, "LoaiTaiNan", 2);

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
        string[] ttbn = new string[0];
        string[] ttba = new string[0];
        private void txtMaYTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //ttbn = ThuVien.clsQuanLyNoiTru.LoadThongTinBenhNhan_SVV(txtMaYTe.Text);
                //if (ttbn.Length > 0)
                //{
                //    lbHoTen.Text = ttbn[3];
                //    lbNamSinh.Text = ttbn[5];
                //    if (ttbn[4] == "T") { lbGioiTinh.Text = "Nam"; }
                //    else { lbGioiTinh.Text = "Nữ"; }
                //    lbTuoi.Text = (Int32.Parse(DateTime.Now.Year.ToString()) - Int32.Parse(ttbn[5])).ToString();
                //    lbHoTen_qlhc.Text = ttbn[3];
                //    lbNgaySinh_qlhc.Text = ttbn[8];
                //    if (ttbn[4] == "T") { lbGioiTinh_qlhc.Text = "Nam"; }
                //    else { lbGioiTinh_qlhc.Text = "Nữ"; }
                //    lbTuoi_qlhc.Text = (Int32.Parse(DateTime.Now.Year.ToString()) - Int32.Parse(ttbn[5])).ToString();
                //    lbDiaChi_qlhc.Text = ttbn[6];
                //    ThuVien.clsQuanLyNoiTru.BenhAnBenhNhan(lkBenhAn,txtMaYTe.Text);
                //    ThuVien.clsQuanLyNoiTru.loadGrvLichSuBenhAn(grv_qlhc, txtMaYTe.Text);
                //}
                //else { ThuVien.clsQuanLyNoiTru.BenhAn(lkBenhAn);
                //    txtMaYTe.Text = "";
                //}
            }
        }

        private void lkBenhAn_EditValueChanged(object sender, EventArgs e)
        {
            if(lkBenhAn.EditValue != null)
            {
                EntityClass.cls_BenhAn ba = new EntityClass.cls_BenhAn();
                ba.Get_By_Key(int.Parse(lkBenhAn.EditValue.ToString()));
                EntityClass.cls_BenhAnChiTiet bact = new EntityClass.cls_BenhAnChiTiet();
                bact.Get_By_Key(ba.mvarBenhAn_Id);
                if (ba.mvarBenhAn_Id > 0)
                {
                    EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
                    DataRow dtr = bn.Get_By_Key_AllCol(ba.mvarBenhNhan_Id);

                    lbHoTen.Text = bn.mvarTenBenhNhan;
                    lbNamSinh.Text = bn.mvarNamSinh.ToString();
                    if (bn.mvarGioiTinh == "T") { lbGioiTinh.Text = "Nam"; }
                    else { lbGioiTinh.Text = "Nữ"; }
                    lbTuoi.Text = (Int32.Parse(DateTime.Now.Year.ToString()) - Int32.Parse(bn.mvarNamSinh.ToString())).ToString();
                    lbHoTen_qlhc.Text = bn.mvarTenBenhNhan;
                    lbNgaySinh_qlhc.Text = bn.mvarNgaySinh.ToString();
                    if (bn.mvarGioiTinh == "T") { lbGioiTinh_qlhc.Text = "Nam"; }
                    else { lbGioiTinh_qlhc.Text = "Nữ"; }
                    lbTuoi_qlhc.Text = (Int32.Parse(DateTime.Now.Year.ToString()) - Int32.Parse(bn.mvarNamSinh.ToString())).ToString();


                    try
                    {
                        lbQuocTich_qlhc.Text = dtr["QuocTich"].ToString();
                        lbNgheNghiep_qlhc.Text = dtr["NgheNghiep"].ToString();

                    }
                    catch { }


                    txtSoLuuTru.Text = ba.mvarSoLuuTru;
                    lkPhongBan.EditValue = ba.mvarNoiLap_Id;
                    lkBacSiDieuTri.EditValue = ba.mvarBacSiDieuTri_Id;
                    lkBacSiDieuTriChinh.EditValue = ba.mvarBacSiDieuTriChinh_Id;
                    lkNguoiLap.EditValue = ba.mvarNguoiLap_Id;
                    lkLoaiBenhAn.EditValue = ba.mvarLoaiBenhAn_Id;
                    lbLoaiBenhAn_qlhc.Text = lkLoaiBenhAn.Text;
                    txtDienThoai_qlhc.Text = bn.mvarSoDienThoai;
                    lbTienSu_qlhc.Text = ba.mvarTienSuBanThan;
                    lkDanToc_qlhc.EditValue = bn.mvarDanToc_Id;
                    lkNhomMau_qlhc.EditValue = bn.mvarNhomMau_Id;
                    lkYeuToRh_qlhc.EditValue = bn.mvarYeuToRh_Id;
                    txtNoiLamViec_qlhc.Text = bn.mvarDiaChiCoQuan;
                    lbVaoVien_qlhc.Text =ba.mvarNgayVaoVien.ToString();
                    txtDienThoai_qlhc.Text = ba.mvarSoDienThoai;
                    
                    //lbTiepNhanTai_qlhc.Text =;
                    lbDiaChi_qlhc.Text = bn.mvarDiaChi;
                    txtVaoVienLanThu_qlhc.Text =ba.mvarLanVaoVien>0?ba.mvarLanVaoVien.ToString():"";
                    dtNgayVaoKhoa_qlhc.DateTime = ba.mvarNgayLap;
                    rtxtChuanDoanKB_cd.Text = ba.mvarChanDoanKhamBenh;
                    rtxtChuanDoanRaVien_cd.Text = ba.mvarChanDoanRaVien;
                    lkICDChuanDoan_cd.EditValue = ba.mvarChanDoanVaoKhoa;
                    lkICDChinh_cd.EditValue = ba.mvarICD_BenhChinh;
                    lkICDPhu_cd.EditValue = ba.mvarICD_BenhPhu;
                    lkICDRaVien_cd.EditValue = ba.mvarICD_NguyenNhanXuatVien;
                    rtxtChuanDoanTruocPhauThuat_cd.Text =bact.mvarChanDoanTruocPhauThuat;
                    rtxtChuanDoanSauPhanThuat_cd.Text = bact.mvarChanDoanSauPhauThuat;
                }
            }

        }
        public bool editCommand()
        {

            return true;
        }

        public bool deleteCommand()
        {
            //bn.Delete();

            /*GridView view = tbThamSoHeThong.FocusedView as GridView;
            foreach (int dtr in view.GetSelectedRows())
            {
                DataRowView dataView = view.GetRow(dtr) as DataRowView;
                ThuVien.mySQL.updateData("UPDATE Sys_AppSettings SET IsDel=1 WHERE Code='" + dataView[0].ToString() + "'");
            }
            view.DeleteSelectedRows();*/
            return true;
        }
        public bool addCommand()
        {
            ThuVien.loadform.enableControl(this);

            return true;
        }
        public bool saveCommand()
        {
            return true;
        }

    }
}
