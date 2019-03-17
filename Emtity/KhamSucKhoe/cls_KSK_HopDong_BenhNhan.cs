using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityClass
{
    public class cls_KSK_HopDong_BenhNhan
    {
        #region "Constants"
        private const string sp_KSK_HOPDONG_BENHNHAN = "sp_KSK_HOPDONG_BENHNHAN";
        #endregion
        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarBenhNhan_Id { get; set; }
        public System.Int32 mvarHopDong_id { get; set; }
        public System.Int32 mvarBenhnhan_ehos_id { get; set; }
        public System.String mvarMaYTe { get; set; }
        public System.Int32 mvarSTT { get; set; }
        public System.String mvarTenBenhNhan { get; set; }
        public System.String mvarHo { get; set; }
        public System.String mvarTen { get; set; }
        public System.String mvarGioiTinh { get; set; }
        public System.DateTime mvarNgaySinh { get; set; }
        public System.Int32 mvarNamSinh { get; set; }
        public System.String mvarDiaChi { get; set; }
        public System.Int32 mvarNhomMau_Id { get; set; }
        public System.Int32 mvarYeuToRH_Id { get; set; }
        public System.String mvarTienSuDiUng { get; set; }
        public System.String mvarSoLuuTruNgoaiTru { get; set; }
        public System.String mvarSoLuuTruNoiTru { get; set; }
        public System.Boolean mvarTuVong { get; set; }
        public System.String mvarGhiChu { get; set; }
        public System.Int32 mvarQuocTich_Id { get; set; }
        public System.Int32 mvarTinhThanh_Id { get; set; }
        public System.Int32 mvarQuanHuyen_Id { get; set; }
        public System.Int32 mvarXaPhuong_Id { get; set; }
        public System.Int32 mvarDanToc_Id { get; set; }
        public System.Int32 mvarNgheNghiep_Id { get; set; }
        public System.String mvarCMND { get; set; }
        public System.String mvarHoChieu { get; set; }
        public System.String mvarTenKhongDau { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.String mvarSoDienThoai { get; set; }
        public System.String mvarKetQua { get; set; }
        public System.DateTime mvarNgayCapThe { get; set; }
        public System.Int32 mvarNamCapThe { get; set; }
        public System.Int32 mvarNhanVien_Id { get; set; }
        public System.String mvarTienSuBenh { get; set; }
        public System.String mvarTienSuHutThuocLa { get; set; }
        public System.Int32 mvarDonViCongTac_Id { get; set; }
        public System.String mvarSoDienThoai1 { get; set; }
        public System.DateTime mvarNgayTiepNhanGanNhat { get; set; }
        public System.DateTime mvarThoiGianTiepNhanGanNhat { get; set; }
        public System.Int32 mvarXeploai_id { get; set; }
        public System.Int32 mvarbsketluan_id { get; set; }
        public System.Int32 mvartinhtranghonnhan_id { get; set; }
        public System.Int32 mvarNhomDoiTuong_Id { get; set; }
        public System.Int32 mvarChuyenChungTuID { get; set; }
        public System.Int32 mvarChuyenChungTu_HoaDonID { get; set; }
        public System.Int32 mvarIDChuyen { get; set; }
        public System.DateTime mvarNgayHen { get; set; }
        public System.Int32 mvarMach { get; set; }
        public System.Int32 mvarHuyetApThap { get; set; }
        public System.Int32 mvarHuyetApCao { get; set; }
        public System.Int32 mvarNhipTho { get; set; }
        public System.Decimal mvarNhietDo { get; set; }
        public System.Decimal mvarChieuCao { get; set; }
        public System.Decimal mvarCanNang { get; set; }
        public System.Decimal mvarBMI { get; set; }
        public System.String mvarMat_KhongKinh_Phai { get; set; }
        public System.String mvarMat_KhongKinh_Trai { get; set; }
        public System.String mvarMat_CoKinh_Phai { get; set; }
        public System.String mvarMat_CoKinh_Trai { get; set; }
        public System.String mvarMat_CacBenhVeMat { get; set; }
        public System.String mvarTMH_TaiTrai_NoiThuong { get; set; }
        public System.String mvarTMH_TaiTrai_NoiTham { get; set; }
        public System.String mvarTMH_TaiPhai_NoiThuong { get; set; }
        public System.String mvarTMH_TaiPhai_NoiTham { get; set; }
        public System.String mvarTMH_CacBenhVeTMH { get; set; }
        public System.String mvarRHM_HamTren { get; set; }
        public System.String mvarRHM_HamDuoi { get; set; }
        public System.String mvarRHM_CacBenhVeRHM { get; set; }
        public System.String mvarMaNhanVien { get; set; }
        public System.String mvarDonVi_BoPhan { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_KSK_HopDong_BenhNhan()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_KSK_HopDong_BenhNhan(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_KSK_HopDong_BenhNhan(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_KSK_HopDong_BenhNhan(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = dal;
        }
        #endregion

        public void ReSet()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarBenhNhan_Id = int.MinValue;
            mvarHopDong_id = int.MinValue;
            mvarBenhnhan_ehos_id = int.MinValue;
            mvarMaYTe = String.Empty;
            mvarSTT = int.MinValue;
            mvarTenBenhNhan = String.Empty;
            mvarHo = String.Empty;
            mvarTen = String.Empty;
            mvarGioiTinh = String.Empty;
            mvarNgaySinh = DateTime.MinValue;
            mvarNamSinh = int.MinValue;
            mvarDiaChi = String.Empty;
            mvarNhomMau_Id = int.MinValue;
            mvarYeuToRH_Id = int.MinValue;
            mvarTienSuDiUng = String.Empty;
            mvarSoLuuTruNgoaiTru = String.Empty;
            mvarSoLuuTruNoiTru = String.Empty;
            mvarTuVong = false;
            mvarGhiChu = String.Empty;
            mvarQuocTich_Id = int.MinValue;
            mvarTinhThanh_Id = int.MinValue;
            mvarQuanHuyen_Id = int.MinValue;
            mvarXaPhuong_Id = int.MinValue;
            mvarDanToc_Id = int.MinValue;
            mvarNgheNghiep_Id = int.MinValue;
            mvarCMND = String.Empty;
            mvarHoChieu = String.Empty;
            mvarTenKhongDau = String.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarSoDienThoai = String.Empty;
            mvarKetQua = String.Empty;
            mvarNgayCapThe = DateTime.MinValue;
            mvarNamCapThe = int.MinValue;
            mvarNhanVien_Id = int.MinValue;
            mvarTienSuBenh = String.Empty;
            mvarTienSuHutThuocLa = String.Empty;
            mvarDonViCongTac_Id = int.MinValue;
            mvarSoDienThoai1 = String.Empty;
            mvarNgayTiepNhanGanNhat = DateTime.MinValue;
            mvarThoiGianTiepNhanGanNhat = DateTime.MinValue;
            mvarXeploai_id = int.MinValue;
            mvarbsketluan_id = int.MinValue;
            mvartinhtranghonnhan_id = int.MinValue;
            mvarNhomDoiTuong_Id = int.MinValue;
            mvarChuyenChungTuID = int.MinValue;
            mvarChuyenChungTu_HoaDonID = int.MinValue;
            mvarIDChuyen = int.MinValue;
            mvarNgayHen = DateTime.MinValue;
            mvarMach = int.MinValue;
            mvarHuyetApThap = int.MinValue;
            mvarHuyetApCao = int.MinValue;
            mvarNhipTho = int.MinValue;
            mvarNhietDo = decimal.MinValue;
            mvarChieuCao = decimal.MinValue;
            mvarCanNang = decimal.MinValue;
            mvarBMI = decimal.MinValue;
            mvarMat_KhongKinh_Phai = String.Empty;
            mvarMat_KhongKinh_Trai = String.Empty;
            mvarMat_CoKinh_Phai = String.Empty;
            mvarMat_CoKinh_Trai = String.Empty;
            mvarMat_CacBenhVeMat = String.Empty;
            mvarTMH_TaiTrai_NoiThuong = String.Empty;
            mvarTMH_TaiTrai_NoiTham = String.Empty;
            mvarTMH_TaiPhai_NoiThuong = String.Empty;
            mvarTMH_TaiPhai_NoiTham = String.Empty;
            mvarTMH_CacBenhVeTMH = String.Empty;
            mvarRHM_HamTren = String.Empty;
            mvarRHM_HamDuoi = String.Empty;
            mvarRHM_CacBenhVeRHM = String.Empty;
            mvarMaNhanVien = String.Empty;
            mvarDonVi_BoPhan = String.Empty;
        }

        public void FillData(DataRow row)
        {
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarHopDong_id = Common.clsControl.IsNullOrEmpty(row["HopDong_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HopDong_id"]);
            mvarBenhnhan_ehos_id = Common.clsControl.IsNullOrEmpty(row["Benhnhan_ehos_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Benhnhan_ehos_id"]);
            mvarMaYTe = Common.clsControl.getValueInRow<string>(row["MaYTe"]);
            mvarSTT = Common.clsControl.IsNullOrEmpty(row["STT"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["STT"]);
            mvarTenBenhNhan = Common.clsControl.getValueInRow<string>(row["TenBenhNhan"]);
            mvarHo = Common.clsControl.getValueInRow<string>(row["Ho"]);
            mvarTen = Common.clsControl.getValueInRow<string>(row["Ten"]);
            mvarGioiTinh = Common.clsControl.getValueInRow<string>(row["GioiTinh"]);
            mvarNgaySinh = Common.clsControl.IsNullOrEmpty(row["NgaySinh"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgaySinh"]);
            mvarNamSinh = Common.clsControl.IsNullOrEmpty(row["NamSinh"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NamSinh"]);
            mvarDiaChi = Common.clsControl.getValueInRow<string>(row["DiaChi"]);
            mvarNhomMau_Id = Common.clsControl.IsNullOrEmpty(row["NhomMau_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhomMau_Id"]);
            mvarYeuToRH_Id = Common.clsControl.IsNullOrEmpty(row["YeuToRH_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["YeuToRH_Id"]);
            mvarTienSuDiUng = Common.clsControl.getValueInRow<string>(row["TienSuDiUng"]);
            mvarSoLuuTruNgoaiTru = Common.clsControl.getValueInRow<string>(row["SoLuuTruNgoaiTru"]);
            mvarSoLuuTruNoiTru = Common.clsControl.getValueInRow<string>(row["SoLuuTruNoiTru"]);
            mvarTuVong = Common.clsControl.getValueInRow<bool>(row["TuVong"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarQuocTich_Id = Common.clsControl.IsNullOrEmpty(row["QuocTich_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["QuocTich_Id"]);
            mvarTinhThanh_Id = Common.clsControl.IsNullOrEmpty(row["TinhThanh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TinhThanh_Id"]);
            mvarQuanHuyen_Id = Common.clsControl.IsNullOrEmpty(row["QuanHuyen_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["QuanHuyen_Id"]);
            mvarXaPhuong_Id = Common.clsControl.IsNullOrEmpty(row["XaPhuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["XaPhuong_Id"]);
            mvarDanToc_Id = Common.clsControl.IsNullOrEmpty(row["DanToc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DanToc_Id"]);
            mvarNgheNghiep_Id = Common.clsControl.IsNullOrEmpty(row["NgheNghiep_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NgheNghiep_Id"]);
            mvarCMND = Common.clsControl.getValueInRow<string>(row["CMND"]);
            mvarHoChieu = Common.clsControl.getValueInRow<string>(row["HoChieu"]);
            mvarTenKhongDau = Common.clsControl.getValueInRow<string>(row["TenKhongDau"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarSoDienThoai = Common.clsControl.getValueInRow<string>(row["SoDienThoai"]);
            mvarKetQua = Common.clsControl.getValueInRow<string>(row["KetQua"]);
            mvarNgayCapThe = Common.clsControl.IsNullOrEmpty(row["NgayCapThe"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapThe"]);
            mvarNamCapThe = Common.clsControl.IsNullOrEmpty(row["NamCapThe"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NamCapThe"]);
            mvarNhanVien_Id = Common.clsControl.IsNullOrEmpty(row["NhanVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhanVien_Id"]);
            mvarTienSuBenh = Common.clsControl.getValueInRow<string>(row["TienSuBenh"]);
            mvarTienSuHutThuocLa = Common.clsControl.getValueInRow<string>(row["TienSuHutThuocLa"]);
            mvarDonViCongTac_Id = Common.clsControl.IsNullOrEmpty(row["DonViCongTac_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DonViCongTac_Id"]);
            mvarSoDienThoai1 = Common.clsControl.getValueInRow<string>(row["SoDienThoai1"]);
            mvarNgayTiepNhanGanNhat = Common.clsControl.IsNullOrEmpty(row["NgayTiepNhanGanNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTiepNhanGanNhat"]);
            mvarThoiGianTiepNhanGanNhat = Common.clsControl.IsNullOrEmpty(row["ThoiGianTiepNhanGanNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianTiepNhanGanNhat"]);
            mvarXeploai_id = Common.clsControl.IsNullOrEmpty(row["Xeploai_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Xeploai_id"]);
            mvarbsketluan_id = Common.clsControl.IsNullOrEmpty(row["bsketluan_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["bsketluan_id"]);
            mvartinhtranghonnhan_id = Common.clsControl.IsNullOrEmpty(row["tinhtranghonnhan_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["tinhtranghonnhan_id"]);
            mvarNhomDoiTuong_Id = Common.clsControl.IsNullOrEmpty(row["NhomDoiTuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhomDoiTuong_Id"]);
            mvarChuyenChungTuID = Common.clsControl.IsNullOrEmpty(row["ChuyenChungTuID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenChungTuID"]);
            mvarChuyenChungTu_HoaDonID = Common.clsControl.IsNullOrEmpty(row["ChuyenChungTu_HoaDonID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenChungTu_HoaDonID"]);
            mvarIDChuyen = Common.clsControl.IsNullOrEmpty(row["IDChuyen"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["IDChuyen"]);
            mvarNgayHen = Common.clsControl.IsNullOrEmpty(row["NgayHen"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHen"]);
            mvarMach = Common.clsControl.IsNullOrEmpty(row["Mach"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Mach"]);
            mvarHuyetApThap = Common.clsControl.IsNullOrEmpty(row["HuyetApThap"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuyetApThap"]);
            mvarHuyetApCao = Common.clsControl.IsNullOrEmpty(row["HuyetApCao"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuyetApCao"]);
            mvarNhipTho = Common.clsControl.IsNullOrEmpty(row["NhipTho"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhipTho"]);
            mvarNhietDo = Common.clsControl.IsNullOrEmpty(row["NhietDo"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["NhietDo"]);
            mvarChieuCao = Common.clsControl.IsNullOrEmpty(row["ChieuCao"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["ChieuCao"]);
            mvarCanNang = Common.clsControl.IsNullOrEmpty(row["CanNang"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["CanNang"]);
            mvarBMI = Common.clsControl.IsNullOrEmpty(row["BMI"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["BMI"]);
            mvarMat_KhongKinh_Phai = Common.clsControl.getValueInRow<string>(row["Mat_KhongKinh_Phai"]);
            mvarMat_KhongKinh_Trai = Common.clsControl.getValueInRow<string>(row["Mat_KhongKinh_Trai"]);
            mvarMat_CoKinh_Phai = Common.clsControl.getValueInRow<string>(row["Mat_CoKinh_Phai"]);
            mvarMat_CoKinh_Trai = Common.clsControl.getValueInRow<string>(row["Mat_CoKinh_Trai"]);
            mvarMat_CacBenhVeMat = Common.clsControl.getValueInRow<string>(row["Mat_CacBenhVeMat"]);
            mvarTMH_TaiTrai_NoiThuong = Common.clsControl.getValueInRow<string>(row["TMH_TaiTrai_NoiThuong"]);
            mvarTMH_TaiTrai_NoiTham = Common.clsControl.getValueInRow<string>(row["TMH_TaiTrai_NoiTham"]);
            mvarTMH_TaiPhai_NoiThuong = Common.clsControl.getValueInRow<string>(row["TMH_TaiPhai_NoiThuong"]);
            mvarTMH_TaiPhai_NoiTham = Common.clsControl.getValueInRow<string>(row["TMH_TaiPhai_NoiTham"]);
            mvarTMH_CacBenhVeTMH = Common.clsControl.getValueInRow<string>(row["TMH_CacBenhVeTMH"]);
            mvarRHM_HamTren = Common.clsControl.getValueInRow<string>(row["RHM_HamTren"]);
            mvarRHM_HamDuoi = Common.clsControl.getValueInRow<string>(row["RHM_HamDuoi"]);
            mvarRHM_CacBenhVeRHM = Common.clsControl.getValueInRow<string>(row["RHM_CacBenhVeRHM"]);
            mvarMaNhanVien = Common.clsControl.getValueInRow<string>(row["MaNhanVien"]);
            mvarDonVi_BoPhan = Common.clsControl.getValueInRow<string>(row["DonVi_BoPhan"]);
        }
        public string Add()
        {
            string rtBenhNhan_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_id", mvarHopDong_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Benhnhan_ehos_id", mvarBenhnhan_ehos_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaYTe", mvarMaYTe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@STT", mvarSTT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhNhan", mvarTenBenhNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ho", mvarHo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ten", mvarTen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioiTinh", mvarGioiTinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgaySinh", mvarNgaySinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamSinh", mvarNamSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomMau_Id", mvarNhomMau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@YeuToRH_Id", mvarYeuToRH_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuDiUng", mvarTienSuDiUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuuTruNgoaiTru", mvarSoLuuTruNgoaiTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuuTruNoiTru", mvarSoLuuTruNoiTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuVong", mvarTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuocTich_Id", mvarQuocTich_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh_Id", mvarTinhThanh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuanHuyen_Id", mvarQuanHuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XaPhuong_Id", mvarXaPhuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DanToc_Id", mvarDanToc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgheNghiep_Id", mvarNgheNghiep_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CMND", mvarCMND);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoChieu", mvarHoChieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenKhongDau", mvarTenKhongDau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDienThoai", mvarSoDienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQua", mvarKetQua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapThe", mvarNgayCapThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamCapThe", mvarNamCapThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhanVien_Id", mvarNhanVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBenh", mvarTienSuBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuHutThuocLa", mvarTienSuHutThuocLa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViCongTac_Id", mvarDonViCongTac_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDienThoai1", mvarSoDienThoai1);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTiepNhanGanNhat", mvarNgayTiepNhanGanNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTiepNhanGanNhat", mvarThoiGianTiepNhanGanNhat);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarXeploai_id);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarbsketluan_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@tinhtranghonnhan_Id", mvartinhtranghonnhan_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomDoiTuong_Id", mvarNhomDoiTuong_Id);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarChuyenChungTuID);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarChuyenChungTu_HoaDonID);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarIDChuyen);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarNgayHen);	
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BMI", mvarBMI);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mat_KhongKinh_Phai", mvarMat_KhongKinh_Phai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mat_KhongKinh_Trai", mvarMat_KhongKinh_Trai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mat_CoKinh_Phai", mvarMat_CoKinh_Phai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mat_CoKinh_Trai", mvarMat_CoKinh_Trai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mat_CacBenhVeMat", mvarMat_CacBenhVeMat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TMH_TaiTrai_NoiThuong", mvarTMH_TaiTrai_NoiThuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TMH_TaiTrai_NoiTham", mvarTMH_TaiTrai_NoiTham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TMH_TaiPhai_NoiThuong", mvarTMH_TaiPhai_NoiThuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TMH_TaiPhai_NoiTham", mvarTMH_TaiPhai_NoiTham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TMH_CacBenhVeTMH", mvarTMH_CacBenhVeTMH);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@RHM_HamTren", mvarRHM_HamTren);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@RHM_HamDuoi", mvarRHM_HamDuoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@RHM_CacBenhVeRHM", mvarRHM_CacBenhVeRHM);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNhanVien", mvarMaNhanVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonVi_BoPhan", mvarDonVi_BoPhan);

            rtBenhNhan_Id = ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG_BENHNHAN, listPara, "@BenhNhan_Id", SqlDbType.Int, 32);
            return rtBenhNhan_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_id", mvarHopDong_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Benhnhan_ehos_id", mvarBenhnhan_ehos_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaYTe", mvarMaYTe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@STT", mvarSTT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhNhan", mvarTenBenhNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ho", mvarHo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ten", mvarTen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioiTinh", mvarGioiTinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgaySinh", mvarNgaySinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamSinh", mvarNamSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomMau_Id", mvarNhomMau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@YeuToRH_Id", mvarYeuToRH_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuDiUng", mvarTienSuDiUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuuTruNgoaiTru", mvarSoLuuTruNgoaiTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuuTruNoiTru", mvarSoLuuTruNoiTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuVong", mvarTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuocTich_Id", mvarQuocTich_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh_Id", mvarTinhThanh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuanHuyen_Id", mvarQuanHuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XaPhuong_Id", mvarXaPhuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DanToc_Id", mvarDanToc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgheNghiep_Id", mvarNgheNghiep_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CMND", mvarCMND);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoChieu", mvarHoChieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenKhongDau", mvarTenKhongDau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDienThoai", mvarSoDienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQua", mvarKetQua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapThe", mvarNgayCapThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamCapThe", mvarNamCapThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhanVien_Id", mvarNhanVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBenh", mvarTienSuBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuHutThuocLa", mvarTienSuHutThuocLa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViCongTac_Id", mvarDonViCongTac_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDienThoai1", mvarSoDienThoai1);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTiepNhanGanNhat", mvarNgayTiepNhanGanNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTiepNhanGanNhat", mvarThoiGianTiepNhanGanNhat);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarXeploai_id);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarbsketluan_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@tinhtranghonnhan_Id", mvartinhtranghonnhan_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomDoiTuong_Id", mvarNhomDoiTuong_Id);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarChuyenChungTuID);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarChuyenChungTu_HoaDonID);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarIDChuyen);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara,"",mvarNgayHen);	
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BMI", mvarBMI);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mat_KhongKinh_Phai", mvarMat_KhongKinh_Phai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mat_KhongKinh_Trai", mvarMat_KhongKinh_Trai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mat_CoKinh_Phai", mvarMat_CoKinh_Phai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mat_CoKinh_Trai", mvarMat_CoKinh_Trai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mat_CacBenhVeMat", mvarMat_CacBenhVeMat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TMH_TaiTrai_NoiThuong", mvarTMH_TaiTrai_NoiThuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TMH_TaiTrai_NoiTham", mvarTMH_TaiTrai_NoiTham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TMH_TaiPhai_NoiThuong", mvarTMH_TaiPhai_NoiThuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TMH_TaiPhai_NoiTham", mvarTMH_TaiPhai_NoiTham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TMH_CacBenhVeTMH", mvarTMH_CacBenhVeTMH);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@RHM_HamTren", mvarRHM_HamTren);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@RHM_HamDuoi", mvarRHM_HamDuoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@RHM_CacBenhVeRHM", mvarRHM_CacBenhVeRHM);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNhanVien", mvarMaNhanVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonVi_BoPhan", mvarDonVi_BoPhan);
            ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG_BENHNHAN, listPara);
            return mvarBenhNhan_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG_BENHNHAN, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public void GetListData_Benhnhan_hopdong(GridControl gr, int ID)
        {
            Common.clsControl.GridView_SP(gr, sp_KSK_HOPDONG_BENHNHAN, "GetListData_Benhnhan_hopdong", "@hopdong_id", ID.ToString());
        }

        public bool GetBN_By_MaYTe(string strMaYTe)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByMaYTe");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaYTe", strMaYTe);
                ds = ThuVien.mySQL.ExcDataSet(sp_KSK_HOPDONG_BENHNHAN, listPara);
                ReSet();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillData(ds.Tables[0].Rows[0]);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

    }
}
