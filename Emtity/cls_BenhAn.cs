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
    public class cls_BenhAn
    {
        #region "Constants"
        private const string SP_BenhAn = "SP_BenhAn";
        private const String SP_GetSoBenhAn = "GetSoTangDan";
        #endregion

        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarBenhAn_Id { get; set; }

        public System.String mvarSoBenhAn { get; set; }

        public System.String mvarSoLuuTru { get; set; }

        public System.Int32 mvarLoaiBenhAn_Id { get; set; }

        public System.Int32 mvarTiepNhan_Id { get; set; }

        public System.Int32 mvarBenhNhan_Id { get; set; }

        public System.DateTime mvarNgayLap { get; set; }

        public System.DateTime mvarThoiGianLap { get; set; }

        public System.Int32 mvarNoiLap_Id { get; set; }

        public System.Int32 mvarNguoiLap_Id { get; set; }

        public System.Int32 mvarBacSiDieuTriChinh_Id { get; set; }

        public System.Int32 mvarBacSiDieuTri_Id { get; set; }

        public System.Int32 mvarKhoaChuyenDen_Id { get; set; }

        public System.Int32 mvarKhoaVao_Id { get; set; }

        public System.DateTime mvarNgayVaoKhoa { get; set; }

        public System.DateTime mvarThoiGianVaoKhoa { get; set; }

        public System.Int32 mvarKhoaRa_Id { get; set; }

        public System.DateTime mvarNgayVaoVien { get; set; }

        public System.DateTime mvarThoiGianVaoVien { get; set; }

        public System.DateTime mvarNgayRaVien { get; set; }

        public System.DateTime mvarThoiGianRaVien { get; set; }

        public System.Decimal mvarSoNgayDieuTri { get; set; }

        public System.Int32 mvarLyDoNhapVien_Id { get; set; }

        public System.Int32 mvarLyDoXuatVien_Id { get; set; }

        public System.Int32 mvarChuyenDenBenhVien_Id { get; set; }

        public System.String mvarChanDoanTuyenDuoi { get; set; }

        public System.Int32 mvarICD_TuyenDuoi { get; set; }

        public System.String mvarChanDoanKhamBenh { get; set; }

        public System.Int32 mvarICD_KhamBenh { get; set; }

        public System.String mvarChanDoanVaoKhoa { get; set; }

        public System.Int32 mvarICD_VaoKhoa { get; set; }

        public System.String mvarChanDoanRaVien { get; set; }

        public System.Int32 mvarICD_BenhChinh { get; set; }

        public System.Int32 mvarICD_BenhPhu { get; set; }

        public System.Int32 mvarKetQuaDieuTri_Id { get; set; }

        public System.String mvarMoTaTinhTrangRaVien { get; set; }

        public System.String mvarTienSuBanThan { get; set; }

        public System.String mvarTienSuGiaDinh { get; set; }

        public System.String mvarQuaTrinhBenhLy { get; set; }

        public System.Int32 mvarMach { get; set; }

        public System.Int32 mvarHuyetApThap { get; set; }

        public System.Int32 mvarHuyetApCao { get; set; }

        public System.Int32 mvarNhipTho { get; set; }

        public System.Decimal mvarNhietDo { get; set; }

        public System.Decimal mvarChieuCao { get; set; }

        public System.Decimal mvarCanNang { get; set; }

        public System.String mvarKhamToanThan { get; set; }

        public System.String mvarTienLuong { get; set; }

        public System.String mvarKeHoachDieuTri { get; set; }

        public System.String mvarCanLamSang { get; set; }

        public System.String mvarLamSang { get; set; }

        public System.Boolean mvarTaiBienDieuTri { get; set; }

        public System.Int32 mvarNguyenNhanTaiBien_Id { get; set; }

        public System.Boolean mvarGiaiPhauBenh { get; set; }

        public System.Int32 mvarTinhTrangGiaiPhauBenh_Id { get; set; }

        public System.String mvarTrangThai { get; set; }

        public System.Boolean mvarKhoaBenhAn { get; set; }

        public System.DateTime mvarNgayKhoaBenhAn { get; set; }

        public System.DateTime mvarThoiGianKhoaBenhAn { get; set; }

        public System.Int32 mvarNguoiKhoaBenhAn_Id { get; set; }

        public System.Boolean mvarDaThanhToan { get; set; }

        public System.DateTime mvarNgayThanhToan { get; set; }

        public System.DateTime mvarThoiGianThanhToan { get; set; }

        public System.Int32 mvarNguoiThanhToan_Id { get; set; }

        public System.Boolean mvarDaXacNhanDoanhThu { get; set; }

        public System.DateTime mvarNgayXacNhanDoanhThu { get; set; }

        public System.DateTime mvarThoiGianXacNhanDoanhThu { get; set; }

        public System.Int32 mvarNguoiXacNhanDoanhThu_Id { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }

        public System.Boolean mvarTuVong { get; set; }

        public System.DateTime mvarNgayTuVong { get; set; }

        public System.DateTime mvarThoiGianTuVong { get; set; }

        public System.DateTime mvarThoiGianKhamNghiem { get; set; }

        public System.DateTime mvarThoiGianNhanTuThi { get; set; }

        public System.String mvarKetQuaKhamNghiem { get; set; }

        public System.String mvarGhiChu { get; set; }

        public System.Int32 mvarICD_TuVong_Id { get; set; }

        public System.Int32 mvarBacSiGhiNhanTuVong_Id { get; set; }

        public System.Int32 mvarBacSiKhamNghiem_Id { get; set; }

        public System.String mvarSoDienThoai { get; set; }

        public System.Int32 mvarLanVaoVien { get; set; }

        public System.Int32 mvarChuyenVien_Id { get; set; }

        public System.Boolean mvarThuThuat { get; set; }

        public System.Boolean mvarPhauThuat { get; set; }

        public System.Boolean mvarBienChung { get; set; }

        public System.Int32 mvarNguyenNhanTuVong_Id { get; set; }

        public System.Int32 mvarICD_GiaiPhauTuThi_Id { get; set; }

        public System.String mvarSoCapCuu { get; set; }

        public System.Int32 mvarDoiTuong_Id { get; set; }

        public System.Int32 mvarICD_NguyenNhanXuatVien { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor

        public cls_BenhAn()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_BenhAn(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_BenhAn(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_BenhAn(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = dal;
        }

        #endregion
        public void Reset()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarBenhAn_Id = int.MinValue;
            mvarSoBenhAn = String.Empty;
            mvarSoLuuTru = String.Empty;
            mvarLoaiBenhAn_Id = int.MinValue;
            mvarTiepNhan_Id = int.MinValue;
            mvarBenhNhan_Id = int.MinValue;
            mvarNgayLap = DateTime.MinValue;
            mvarThoiGianLap = DateTime.MinValue;
            mvarNoiLap_Id = int.MinValue;
            mvarNguoiLap_Id = int.MinValue;
            mvarBacSiDieuTriChinh_Id = int.MinValue;
            mvarBacSiDieuTri_Id = int.MinValue;
            mvarKhoaChuyenDen_Id = int.MinValue;
            mvarKhoaVao_Id = int.MinValue;
            mvarNgayVaoKhoa = DateTime.MinValue;
            mvarThoiGianVaoKhoa = DateTime.MinValue;
            mvarKhoaRa_Id = int.MinValue;
            mvarNgayVaoVien = DateTime.MinValue;
            mvarThoiGianVaoVien = DateTime.MinValue;
            mvarNgayRaVien = DateTime.MinValue;
            mvarThoiGianRaVien = DateTime.MinValue;
            mvarSoNgayDieuTri = decimal.MinValue;
            mvarLyDoNhapVien_Id = int.MinValue;
            mvarLyDoXuatVien_Id = int.MinValue;
            mvarChuyenDenBenhVien_Id = int.MinValue;
            mvarChanDoanTuyenDuoi = String.Empty;
            mvarICD_TuyenDuoi = int.MinValue;
            mvarChanDoanKhamBenh = String.Empty;
            mvarICD_KhamBenh = int.MinValue;
            mvarChanDoanVaoKhoa = String.Empty;
            mvarICD_VaoKhoa = int.MinValue;
            mvarChanDoanRaVien = String.Empty;
            mvarICD_BenhChinh = int.MinValue;
            mvarICD_BenhPhu = int.MinValue;
            mvarKetQuaDieuTri_Id = int.MinValue;
            mvarMoTaTinhTrangRaVien = String.Empty;
            mvarTienSuBanThan = String.Empty;
            mvarTienSuGiaDinh = String.Empty;
            mvarQuaTrinhBenhLy = String.Empty;
            mvarMach = int.MinValue;
            mvarHuyetApThap = int.MinValue;
            mvarHuyetApCao = int.MinValue;
            mvarNhipTho = int.MinValue;
            mvarNhietDo = decimal.MinValue;
            mvarChieuCao = decimal.MinValue;
            mvarCanNang = decimal.MinValue;
            mvarKhamToanThan = String.Empty;
            mvarTienLuong = String.Empty;
            mvarKeHoachDieuTri = String.Empty;
            mvarCanLamSang = String.Empty;
            mvarLamSang = String.Empty;
            mvarTaiBienDieuTri = false;
            mvarNguyenNhanTaiBien_Id = int.MinValue;
            mvarGiaiPhauBenh = false;
            mvarTinhTrangGiaiPhauBenh_Id = int.MinValue;
            mvarTrangThai = String.Empty;
            mvarKhoaBenhAn = false;
            mvarNgayKhoaBenhAn = DateTime.MinValue;
            mvarThoiGianKhoaBenhAn = DateTime.MinValue;
            mvarNguoiKhoaBenhAn_Id = int.MinValue;
            mvarDaThanhToan = false;
            mvarNgayThanhToan = DateTime.MinValue;
            mvarThoiGianThanhToan = DateTime.MinValue;
            mvarNguoiThanhToan_Id = int.MinValue;
            mvarDaXacNhanDoanhThu = false;
            mvarNgayXacNhanDoanhThu = DateTime.MinValue;
            mvarThoiGianXacNhanDoanhThu = DateTime.MinValue;
            mvarNguoiXacNhanDoanhThu_Id = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarTuVong = false;
            mvarNgayTuVong = DateTime.MinValue;
            mvarThoiGianTuVong = DateTime.MinValue;
            mvarThoiGianKhamNghiem = DateTime.MinValue;
            mvarThoiGianNhanTuThi = DateTime.MinValue;
            mvarKetQuaKhamNghiem = String.Empty;
            mvarGhiChu = String.Empty;
            mvarICD_TuVong_Id = int.MinValue;
            mvarBacSiGhiNhanTuVong_Id = int.MinValue;
            mvarBacSiKhamNghiem_Id = int.MinValue;
            mvarSoDienThoai = String.Empty;
            mvarLanVaoVien = int.MinValue;
            mvarChuyenVien_Id = int.MinValue;
            mvarThuThuat = false;
            mvarPhauThuat = false;
            mvarBienChung = false;
            mvarNguyenNhanTuVong_Id = int.MinValue;
            mvarICD_GiaiPhauTuThi_Id = int.MinValue;
            mvarSoCapCuu = String.Empty;
            mvarDoiTuong_Id = int.MinValue;

            mvarICD_NguyenNhanXuatVien = int.MinValue;
        }
        public void FillData(DataRow row)
        {
            mvarBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["BenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAn_Id"]);
            mvarSoBenhAn = Common.clsControl.getValueInRow<string>(row["SoBenhAn"]);
            mvarSoLuuTru = Common.clsControl.getValueInRow<string>(row["SoLuuTru"]);
            mvarLoaiBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["LoaiBenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiBenhAn_Id"]);
            mvarTiepNhan_Id = Common.clsControl.IsNullOrEmpty(row["TiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhan_Id"]);
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarNgayLap = Common.clsControl.IsNullOrEmpty(row["NgayLap"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayLap"]);
            mvarThoiGianLap = Common.clsControl.IsNullOrEmpty(row["ThoiGianLap"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianLap"]);
            mvarNoiLap_Id = Common.clsControl.IsNullOrEmpty(row["NoiLap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiLap_Id"]);
            mvarNguoiLap_Id = Common.clsControl.IsNullOrEmpty(row["NguoiLap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiLap_Id"]);
            mvarBacSiDieuTriChinh_Id = Common.clsControl.IsNullOrEmpty(row["BacSiDieuTriChinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiDieuTriChinh_Id"]);
            mvarBacSiDieuTri_Id = Common.clsControl.IsNullOrEmpty(row["BacSiDieuTri_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiDieuTri_Id"]);
            mvarKhoaChuyenDen_Id = Common.clsControl.IsNullOrEmpty(row["KhoaChuyenDen_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoaChuyenDen_Id"]);
            mvarKhoaVao_Id = Common.clsControl.IsNullOrEmpty(row["KhoaVao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoaVao_Id"]);
            mvarNgayVaoKhoa = Common.clsControl.IsNullOrEmpty(row["NgayVaoKhoa"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayVaoKhoa"]);
            mvarThoiGianVaoKhoa = Common.clsControl.IsNullOrEmpty(row["ThoiGianVaoKhoa"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianVaoKhoa"]);
            mvarKhoaRa_Id = Common.clsControl.IsNullOrEmpty(row["KhoaRa_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoaRa_Id"]);
            mvarNgayVaoVien = Common.clsControl.IsNullOrEmpty(row["NgayVaoVien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayVaoVien"]);
            mvarThoiGianVaoVien = Common.clsControl.IsNullOrEmpty(row["ThoiGianVaoVien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianVaoVien"]);
            mvarNgayRaVien = Common.clsControl.IsNullOrEmpty(row["NgayRaVien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayRaVien"]);
            mvarThoiGianRaVien = Common.clsControl.IsNullOrEmpty(row["ThoiGianRaVien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianRaVien"]);
            mvarSoNgayDieuTri = Common.clsControl.IsNullOrEmpty(row["SoNgayDieuTri"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoNgayDieuTri"]);
            mvarLyDoNhapVien_Id = Common.clsControl.IsNullOrEmpty(row["LyDoNhapVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LyDoNhapVien_Id"]);
            mvarLyDoXuatVien_Id = Common.clsControl.IsNullOrEmpty(row["LyDoXuatVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LyDoXuatVien_Id"]);
            mvarChuyenDenBenhVien_Id = Common.clsControl.IsNullOrEmpty(row["ChuyenDenBenhVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenDenBenhVien_Id"]);
            mvarChanDoanTuyenDuoi = Common.clsControl.getValueInRow<string>(row["ChanDoanTuyenDuoi"]);
            mvarICD_TuyenDuoi = Common.clsControl.IsNullOrEmpty(row["ICD_TuyenDuoi"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_TuyenDuoi"]);
            mvarChanDoanKhamBenh = Common.clsControl.getValueInRow<string>(row["ChanDoanKhamBenh"]);
            mvarICD_KhamBenh = Common.clsControl.IsNullOrEmpty(row["ICD_KhamBenh"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_KhamBenh"]);
            mvarChanDoanVaoKhoa = Common.clsControl.getValueInRow<string>(row["ChanDoanVaoKhoa"]);
            mvarICD_VaoKhoa = Common.clsControl.IsNullOrEmpty(row["ICD_VaoKhoa"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_VaoKhoa"]);
            mvarChanDoanRaVien = Common.clsControl.getValueInRow<string>(row["ChanDoanRaVien"]);
            mvarICD_BenhChinh = Common.clsControl.IsNullOrEmpty(row["ICD_BenhChinh"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_BenhChinh"]);
            mvarICD_BenhPhu = Common.clsControl.IsNullOrEmpty(row["ICD_BenhPhu"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_BenhPhu"]);
            mvarKetQuaDieuTri_Id = Common.clsControl.IsNullOrEmpty(row["KetQuaDieuTri_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KetQuaDieuTri_Id"]);
            mvarMoTaTinhTrangRaVien = Common.clsControl.getValueInRow<string>(row["MoTaTinhTrangRaVien"]);
            mvarTienSuBanThan = Common.clsControl.getValueInRow<string>(row["TienSuBanThan"]);
            mvarTienSuGiaDinh = Common.clsControl.getValueInRow<string>(row["TienSuGiaDinh"]);
            mvarQuaTrinhBenhLy = Common.clsControl.getValueInRow<string>(row["QuaTrinhBenhLy"]);
            mvarMach = Common.clsControl.IsNullOrEmpty(row["Mach"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Mach"]);
            mvarHuyetApThap = Common.clsControl.IsNullOrEmpty(row["HuyetApThap"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuyetApThap"]);
            mvarHuyetApCao = Common.clsControl.IsNullOrEmpty(row["HuyetApCao"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuyetApCao"]);
            mvarNhipTho = Common.clsControl.IsNullOrEmpty(row["NhipTho"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhipTho"]);
            mvarNhietDo = Common.clsControl.IsNullOrEmpty(row["NhietDo"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["NhietDo"]);
            mvarChieuCao = Common.clsControl.IsNullOrEmpty(row["ChieuCao"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["ChieuCao"]);
            mvarCanNang = Common.clsControl.IsNullOrEmpty(row["CanNang"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["CanNang"]);
            mvarKhamToanThan = Common.clsControl.getValueInRow<string>(row["KhamToanThan"]);
            mvarTienLuong = Common.clsControl.getValueInRow<string>(row["TienLuong"]);
            mvarKeHoachDieuTri = Common.clsControl.getValueInRow<string>(row["KeHoachDieuTri"]);
            mvarCanLamSang = Common.clsControl.getValueInRow<string>(row["CanLamSang"]);
            mvarLamSang = Common.clsControl.getValueInRow<string>(row["LamSang"]);
            mvarTaiBienDieuTri = Common.clsControl.getValueInRow<bool>(row["TaiBienDieuTri"]);
            mvarNguyenNhanTaiBien_Id = Common.clsControl.IsNullOrEmpty(row["NguyenNhanTaiBien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguyenNhanTaiBien_Id"]);
            mvarGiaiPhauBenh = Common.clsControl.getValueInRow<bool>(row["GiaiPhauBenh"]);
            mvarTinhTrangGiaiPhauBenh_Id = Common.clsControl.IsNullOrEmpty(row["TinhTrangGiaiPhauBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TinhTrangGiaiPhauBenh_Id"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarKhoaBenhAn = Common.clsControl.IsNullOrEmpty(row["KhoaBenhAn"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["KhoaBenhAn"]);
            mvarNgayKhoaBenhAn = Common.clsControl.IsNullOrEmpty(row["NgayKhoaBenhAn"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayKhoaBenhAn"]);
            mvarThoiGianKhoaBenhAn = Common.clsControl.IsNullOrEmpty(row["ThoiGianKhoaBenhAn"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianKhoaBenhAn"]);
            mvarNguoiKhoaBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["NguoiKhoaBenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiKhoaBenhAn_Id"]);
            mvarDaThanhToan = Common.clsControl.getValueInRow<bool>(row["DaThanhToan"]);
            mvarNgayThanhToan = Common.clsControl.IsNullOrEmpty(row["NgayThanhToan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayThanhToan"]);
            mvarThoiGianThanhToan = Common.clsControl.IsNullOrEmpty(row["ThoiGianThanhToan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianThanhToan"]);
            mvarNguoiThanhToan_Id = Common.clsControl.IsNullOrEmpty(row["NguoiThanhToan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiThanhToan_Id"]);
            mvarDaXacNhanDoanhThu = Common.clsControl.getValueInRow<bool>(row["DaXacNhanDoanhThu"]);
            mvarNgayXacNhanDoanhThu = Common.clsControl.IsNullOrEmpty(row["NgayXacNhanDoanhThu"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayXacNhanDoanhThu"]);
            mvarThoiGianXacNhanDoanhThu = Common.clsControl.IsNullOrEmpty(row["ThoiGianXacNhanDoanhThu"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianXacNhanDoanhThu"]);
            mvarNguoiXacNhanDoanhThu_Id = Common.clsControl.IsNullOrEmpty(row["NguoiXacNhanDoanhThu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiXacNhanDoanhThu_Id"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarTuVong = Common.clsControl.getValueInRow<bool>(row["TuVong"]);
            mvarNgayTuVong = Common.clsControl.IsNullOrEmpty(row["NgayTuVong"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTuVong"]);
            mvarThoiGianTuVong = Common.clsControl.IsNullOrEmpty(row["ThoiGianTuVong"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianTuVong"]);
            mvarThoiGianKhamNghiem = Common.clsControl.IsNullOrEmpty(row["ThoiGianKhamNghiem"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianKhamNghiem"]);
            mvarThoiGianNhanTuThi = Common.clsControl.IsNullOrEmpty(row["ThoiGianNhanTuThi"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianNhanTuThi"]);
            mvarKetQuaKhamNghiem = Common.clsControl.getValueInRow<string>(row["KetQuaKhamNghiem"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarICD_TuVong_Id = Common.clsControl.IsNullOrEmpty(row["ICD_TuVong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_TuVong_Id"]);
            mvarBacSiGhiNhanTuVong_Id = Common.clsControl.IsNullOrEmpty(row["BacSiGhiNhanTuVong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiGhiNhanTuVong_Id"]);
            mvarBacSiKhamNghiem_Id = Common.clsControl.IsNullOrEmpty(row["BacSiKhamNghiem_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiKhamNghiem_Id"]);
            mvarSoDienThoai = Common.clsControl.getValueInRow<string>(row["SoDienThoai"]);
            mvarLanVaoVien = Common.clsControl.IsNullOrEmpty(row["LanVaoVien"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LanVaoVien"]);
            mvarChuyenVien_Id = Common.clsControl.IsNullOrEmpty(row["ChuyenVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenVien_Id"]);
            mvarThuThuat = Common.clsControl.IsNullOrEmpty(row["ThuThuat"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["ThuThuat"]);
            mvarPhauThuat = Common.clsControl.IsNullOrEmpty(row["PhauThuat"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["PhauThuat"]);
            mvarBienChung = Common.clsControl.IsNullOrEmpty(row["BienChung"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["BienChung"]);
            mvarNguyenNhanTuVong_Id = Common.clsControl.IsNullOrEmpty(row["NguyenNhanTuVong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguyenNhanTuVong_Id"]);
            mvarICD_GiaiPhauTuThi_Id = Common.clsControl.IsNullOrEmpty(row["ICD_GiaiPhauTuThi_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_GiaiPhauTuThi_Id"]);
            mvarSoCapCuu = Common.clsControl.getValueInRow<string>(row["SoCapCuu"]);
            mvarDoiTuong_Id = Common.clsControl.IsNullOrEmpty(row["DoiTuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DoiTuong_Id"]);

            mvarICD_NguyenNhanXuatVien = Common.clsControl.IsNullOrEmpty(row["ICD_NguyenNhanXuatVien"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_NguyenNhanXuatVien"]);
        }

        public string Add()
        {
            string rtBenhAn_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoBenhAn", mvarSoBenhAn);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuuTru", mvarSoLuuTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiBenhAn_Id", mvarLoaiBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayLap", mvarNgayLap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianLap", mvarThoiGianLap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiLap_Id", mvarNoiLap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLap_Id", mvarNguoiLap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiDieuTriChinh_Id", mvarBacSiDieuTriChinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiDieuTri_Id", mvarBacSiDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaChuyenDen_Id", mvarKhoaChuyenDen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaVao_Id", mvarKhoaVao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVaoKhoa", mvarNgayVaoKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianVaoKhoa", mvarThoiGianVaoKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaRa_Id", mvarKhoaRa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVaoVien", mvarNgayVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianVaoVien", mvarThoiGianVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRaVien", mvarNgayRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRaVien", mvarThoiGianRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgayDieuTri", mvarSoNgayDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoNhapVien_Id", mvarLyDoNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoXuatVien_Id", mvarLyDoXuatVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenDenBenhVien_Id", mvarChuyenDenBenhVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanTuyenDuoi", mvarChanDoanTuyenDuoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_TuyenDuoi", mvarICD_TuyenDuoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanKhamBenh", mvarChanDoanKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_KhamBenh", mvarICD_KhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanVaoKhoa", mvarChanDoanVaoKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_VaoKhoa", mvarICD_VaoKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanRaVien", mvarChanDoanRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_BenhChinh", mvarICD_BenhChinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_BenhPhu", mvarICD_BenhPhu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaDieuTri_Id", mvarKetQuaDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTaTinhTrangRaVien", mvarMoTaTinhTrangRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBanThan", mvarTienSuBanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuGiaDinh", mvarTienSuGiaDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuaTrinhBenhLy", mvarQuaTrinhBenhLy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamToanThan", mvarKhamToanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienLuong", mvarTienLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KeHoachDieuTri", mvarKeHoachDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanLamSang", mvarCanLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LamSang", mvarLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiBienDieuTri", mvarTaiBienDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhanTaiBien_Id", mvarNguyenNhanTaiBien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaiPhauBenh", mvarGiaiPhauBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhTrangGiaiPhauBenh_Id", mvarTinhTrangGiaiPhauBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaBenhAn", mvarKhoaBenhAn);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKhoaBenhAn", mvarNgayKhoaBenhAn);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKhoaBenhAn", mvarThoiGianKhoaBenhAn);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiKhoaBenhAn_Id", mvarNguoiKhoaBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan", mvarDaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThanhToan", mvarNgayThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianThanhToan", mvarThoiGianThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiThanhToan_Id", mvarNguoiThanhToan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaXacNhanDoanhThu", mvarDaXacNhanDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayXacNhanDoanhThu", mvarNgayXacNhanDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianXacNhanDoanhThu", mvarThoiGianXacNhanDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiXacNhanDoanhThu_Id", mvarNguoiXacNhanDoanhThu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuVong", mvarTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTuVong", mvarNgayTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTuVong", mvarThoiGianTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKhamNghiem", mvarThoiGianKhamNghiem);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianNhanTuThi", mvarThoiGianNhanTuThi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaKhamNghiem", mvarKetQuaKhamNghiem);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_TuVong_Id", mvarICD_TuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiGhiNhanTuVong_Id", mvarBacSiGhiNhanTuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiKhamNghiem_Id", mvarBacSiKhamNghiem_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDienThoai", mvarSoDienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LanVaoVien", mvarLanVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenVien_Id", mvarChuyenVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuThuat", mvarThuThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhauThuat", mvarPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BienChung", mvarBienChung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhanTuVong_Id", mvarNguyenNhanTuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_GiaiPhauTuThi_Id", mvarICD_GiaiPhauTuThi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoCapCuu", mvarSoCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_NguyenNhanXuatVien", mvarICD_NguyenNhanXuatVien);

            rtBenhAn_Id = ThuVien.mySQL.ExcSP(SP_BenhAn, listPara, "@BenhAn_Id", SqlDbType.Int, 32);
            return rtBenhAn_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoBenhAn", mvarSoBenhAn);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuuTru", mvarSoLuuTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiBenhAn_Id", mvarLoaiBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayLap", mvarNgayLap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianLap", mvarThoiGianLap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiLap_Id", mvarNoiLap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLap_Id", mvarNguoiLap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiDieuTriChinh_Id", mvarBacSiDieuTriChinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiDieuTri_Id", mvarBacSiDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaChuyenDen_Id", mvarKhoaChuyenDen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaVao_Id", mvarKhoaVao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVaoKhoa", mvarNgayVaoKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianVaoKhoa", mvarThoiGianVaoKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaRa_Id", mvarKhoaRa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVaoVien", mvarNgayVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianVaoVien", mvarThoiGianVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRaVien", mvarNgayRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRaVien", mvarThoiGianRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgayDieuTri", mvarSoNgayDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoNhapVien_Id", mvarLyDoNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoXuatVien_Id", mvarLyDoXuatVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenDenBenhVien_Id", mvarChuyenDenBenhVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanTuyenDuoi", mvarChanDoanTuyenDuoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_TuyenDuoi", mvarICD_TuyenDuoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanKhamBenh", mvarChanDoanKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_KhamBenh", mvarICD_KhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanVaoKhoa", mvarChanDoanVaoKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_VaoKhoa", mvarICD_VaoKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanRaVien", mvarChanDoanRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_BenhChinh", mvarICD_BenhChinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_BenhPhu", mvarICD_BenhPhu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaDieuTri_Id", mvarKetQuaDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTaTinhTrangRaVien", mvarMoTaTinhTrangRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBanThan", mvarTienSuBanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuGiaDinh", mvarTienSuGiaDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuaTrinhBenhLy", mvarQuaTrinhBenhLy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamToanThan", mvarKhamToanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienLuong", mvarTienLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KeHoachDieuTri", mvarKeHoachDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanLamSang", mvarCanLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LamSang", mvarLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiBienDieuTri", mvarTaiBienDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhanTaiBien_Id", mvarNguyenNhanTaiBien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaiPhauBenh", mvarGiaiPhauBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhTrangGiaiPhauBenh_Id", mvarTinhTrangGiaiPhauBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaBenhAn", mvarKhoaBenhAn);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKhoaBenhAn", mvarNgayKhoaBenhAn);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKhoaBenhAn", mvarThoiGianKhoaBenhAn);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiKhoaBenhAn_Id", mvarNguoiKhoaBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan", mvarDaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThanhToan", mvarNgayThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianThanhToan", mvarThoiGianThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiThanhToan_Id", mvarNguoiThanhToan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaXacNhanDoanhThu", mvarDaXacNhanDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayXacNhanDoanhThu", mvarNgayXacNhanDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianXacNhanDoanhThu", mvarThoiGianXacNhanDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiXacNhanDoanhThu_Id", mvarNguoiXacNhanDoanhThu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuVong", mvarTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTuVong", mvarNgayTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTuVong", mvarThoiGianTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKhamNghiem", mvarThoiGianKhamNghiem);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianNhanTuThi", mvarThoiGianNhanTuThi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaKhamNghiem", mvarKetQuaKhamNghiem);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_TuVong_Id", mvarICD_TuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiGhiNhanTuVong_Id", mvarBacSiGhiNhanTuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiKhamNghiem_Id", mvarBacSiKhamNghiem_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDienThoai", mvarSoDienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LanVaoVien", mvarLanVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenVien_Id", mvarChuyenVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuThuat", mvarThuThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhauThuat", mvarPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BienChung", mvarBienChung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhanTuVong_Id", mvarNguyenNhanTuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_GiaiPhauTuThi_Id", mvarICD_GiaiPhauTuThi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoCapCuu", mvarSoCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_NguyenNhanXuatVien", mvarICD_NguyenNhanXuatVien);
            ThuVien.mySQL.ExcSP(SP_BenhAn, listPara);
            return mvarBenhAn_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_BenhAn, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public bool Get_By_Key(int benhAn_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", benhAn_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_BenhAn, listPara);
                Reset();
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
        public string getSoBenhAn()
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;
            string soBenhAn = "";
            DataSet dt = new DataSet();

            try
            {
                using (cmd = new SqlCommand(SP_GetSoBenhAn, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableName", "BenhAn");
                cmd.Parameters.AddWithValue("@String_Id", DateTime.Now.ToString("yy"));
                var rs = cmd.Parameters.Add("@Values_Id", SqlDbType.Int);
                rs.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                soBenhAn = Int32.Parse(rs.Value.ToString()).ToString(("D6"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }

            return DateTime.Now.ToString("yy") + soBenhAn;
        }

    }
}
