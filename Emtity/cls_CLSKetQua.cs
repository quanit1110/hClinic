using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class cls_CLSKetQua
    {
        #region "Constants"
        private const string sp_CLSKETQUA = "sp_CLSKETQUA";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarCLSKetQua_Id { get; set; }
        public System.Int32 mvarCLSYeuCau_Id { get; set; }
        public System.DateTime mvarNgayThucHien { get; set; }
        public System.DateTime mvarThoiGianThucHien { get; set; }
        public System.DateTime mvarNgayGioThucHien { get; set; }
        public System.Int32 mvarGioThucHien { get; set; }
        public System.Int32 mvarNamThucHien { get; set; }
        public System.Int32 mvarThangThucHien { get; set; }
        public System.Int32 mvarNoiThucHien_Id { get; set; }
        public System.Int32 mvarBacSiThucHien_Id { get; set; }

        //public System.String mvarKyThuat { get; set; }
        public System.Int32 mvarKyThuatVien01_Id { get; set; }
        public System.Int32 mvarKyThuatVien02_Id { get; set; }
        public System.Int32 mvarBacSiKetLuan_Id { get; set; }
        public System.Boolean mvarThucHienBenNgoai { get; set; }
        public System.Int32 mvarBenhVienThucHien_Id { get; set; }
        public System.String mvarTenBacSiBenNgoai { get; set; }
        public System.String mvarVungKhaoSat { get; set; }
        public System.String mvarMoTa { get; set; }
        public System.String mvarMoTa_Text { get; set; }
        public System.String mvarKetLuan { get; set; }
        public System.String mvarGhiChu { get; set; }
        public System.Int32 mvarNhomDichVu_Id { get; set; }
        public System.String mvarMaPhim { get; set; }
        public System.Boolean mvarTiemCanQuang { get; set; }
        public System.Decimal mvarSoPhimSuDung { get; set; }
        public System.Decimal mvarSoThuocSuDung { get; set; }
        public System.Boolean mvarSinhThiet { get; set; }
        public System.Boolean mvarClotest { get; set; }
        public System.Boolean mvarPhoto { get; set; }
        public System.Boolean mvarVideo { get; set; }
        public System.String mvarMach { get; set; }
        public System.String mvarHuyetAp { get; set; }
        public System.String mvarNhipTho { get; set; }
        public System.String mvarNhietDo { get; set; }
        public System.Decimal mvarChieuCao { get; set; }
        public System.Decimal mvarCanNang { get; set; }
        public System.Decimal mvarBSA { get; set; }
        public System.Int32 mvarThietBi_Id { get; set; }
        public System.Int32 mvarPhanLoaiKetQua_Id { get; set; }
        public System.Boolean mvarKhoaDuLieu { get; set; }
        public System.DateTime mvarNgayKhoaDuLieu { get; set; }
        public System.DateTime mvarThoiGianKhoaDuLieu { get; set; }
        public System.Int32 mvarNguoiKhoa_Id { get; set; }
        public System.Int32 mvarMaNguoiKhoa { get; set; }
        public System.String mvarTenNguoiKhoa { get; set; }
        public System.String mvarTrangThai { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.String mvarTinhTrangDienNao { get; set; }
        public System.String mvarGPB_AmSo { get; set; }
        public System.Int32 mvarGPB_PhanLoaiKetQua_Id { get; set; }
        public System.Int32 mvarGPB_PhuongPhapLayBenhPham_Id { get; set; }
        public System.String mvarGPB_SoMau { get; set; }
        public System.Int32 mvarGPB_SoLuongMau { get; set; }
        public System.Int32 mvarGPB_Topo_Id { get; set; }
        public System.Int32 mvarGPB_TopoRegions_Id { get; set; }
        public System.Int32 mvarGPB_Morpho_Id { get; set; }
        public System.Int32 mvarGPB_Etio_Id { get; set; }
        public System.String mvarGPB_DaiThe { get; set; }
        public System.String mvarGPB_ViThe { get; set; }
        public System.Boolean mvarGPB_Nhuom_HE { get; set; }
        public System.Boolean mvarGPB_Nhuom_PAS { get; set; }
        public System.Boolean mvarGPB_Nhuom_Tri { get; set; }
        public System.Boolean mvarGPB_Nhuom_AFB { get; set; }
        public System.Boolean mvarGPB_Nhuom_Giemsa { get; set; }
        public System.Boolean mvarGPB_Nhuom_Other { get; set; }
        public System.Boolean mvarGPB_HoaMienDich { get; set; }
        public System.Boolean mvarGPB_HoaMienDichHuynhQuang { get; set; }
        public System.Boolean mvarGPB_HoiChan { get; set; }
        public System.String mvarSoVaoVien { get; set; }
        public System.String mvarMaYTe { get; set; }
        public System.String mvarTenBenhNhan { get; set; }
        public System.Int32 mvarNamSinh { get; set; }
        public System.String mvarGioiTinh { get; set; }
        public System.String mvarDiaChi { get; set; }
        public System.Int32 mvarNoiChiDinh_Id { get; set; }
        public System.String mvarBacSiChiDinh { get; set; }
        public System.DateTime mvarNgayChiDinh { get; set; }
        public System.Int32 mvarMauThu_Id { get; set; }
        public System.DateTime mvarThoiGiannhan { get; set; }
        public System.String mvarMau { get; set; }
        public System.String mvarDeNghi { get; set; }
        public System.Int32 mvarLoaiFilm_Id { get; set; }
        public System.Int32 mvarLoaiThuocCanQuang_Id { get; set; }
        public System.String mvarMa { get; set; }
        public System.String mvarIDHinh { get; set; }
        public System.Int32 mvarBacSiChiDinh_Id { get; set; }
        public System.Decimal mvarSoPhimHu { get; set; }
        public System.Int32 mvarLoaiPhimHu_Id { get; set; }
        public System.String mvarDoSoi { get; set; }
        public System.Int32 mvarDoSoi_Id { get; set; }
        public System.Decimal mvarBanKinhSoi { get; set; }
        public System.String mvarChanDoanLamSang { get; set; }
        public System.String mvarSoDT { get; set; }
        //public System.String mvarMaPhongQLXN { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_CLSKetQua()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_CLSKetQua(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_CLSKetQua(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_CLSKetQua(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarCLSKetQua_Id = int.MinValue;
            mvarCLSYeuCau_Id = int.MinValue;
            mvarNgayThucHien = DateTime.MinValue;
            mvarThoiGianThucHien = DateTime.MinValue;
            mvarNgayGioThucHien = DateTime.MinValue;
            mvarGioThucHien = int.MinValue;
            mvarNamThucHien = int.MinValue;
            mvarThangThucHien = int.MinValue;
            mvarNoiThucHien_Id = int.MinValue;
            mvarBacSiThucHien_Id = int.MinValue;
            //mvarKyThuat = String.Empty;
            mvarKyThuatVien01_Id = int.MinValue;
            mvarKyThuatVien02_Id = int.MinValue;
            mvarBacSiKetLuan_Id = int.MinValue;
            mvarThucHienBenNgoai = false;
            mvarBenhVienThucHien_Id = int.MinValue;
            mvarTenBacSiBenNgoai = String.Empty;
            mvarVungKhaoSat = String.Empty;
            mvarMoTa = String.Empty;
            mvarMoTa_Text = String.Empty;
            mvarKetLuan = String.Empty;
            mvarGhiChu = String.Empty;
            mvarNhomDichVu_Id = int.MinValue;
            mvarMaPhim = String.Empty;
            mvarTiemCanQuang = false;
            mvarSoPhimSuDung = decimal.MinValue;
            mvarSoThuocSuDung = decimal.MinValue;
            mvarSinhThiet = false;
            mvarClotest = false;
            mvarPhoto = false;
            mvarVideo = false;
            mvarMach = String.Empty;
            mvarHuyetAp = String.Empty;
            mvarNhipTho = String.Empty;
            mvarNhietDo = String.Empty;
            mvarChieuCao = decimal.MinValue;
            mvarCanNang = decimal.MinValue;
            mvarBSA = decimal.MinValue;
            mvarThietBi_Id = int.MinValue;
            mvarPhanLoaiKetQua_Id = int.MinValue;
            mvarKhoaDuLieu = false;
            mvarNgayKhoaDuLieu = DateTime.MinValue;
            mvarThoiGianKhoaDuLieu = DateTime.MinValue;
            mvarNguoiKhoa_Id = int.MinValue;
            mvarMaNguoiKhoa = int.MinValue;
            mvarTenNguoiKhoa = String.Empty;
            mvarTrangThai = String.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarTinhTrangDienNao = String.Empty;
            mvarGPB_AmSo = String.Empty;
            mvarGPB_PhanLoaiKetQua_Id = int.MinValue;
            mvarGPB_PhuongPhapLayBenhPham_Id = int.MinValue;
            mvarGPB_SoMau = String.Empty;
            mvarGPB_SoLuongMau = int.MinValue;
            mvarGPB_Topo_Id = int.MinValue;
            mvarGPB_TopoRegions_Id = int.MinValue;
            mvarGPB_Morpho_Id = int.MinValue;
            mvarGPB_Etio_Id = int.MinValue;
            mvarGPB_DaiThe = String.Empty;
            mvarGPB_ViThe = String.Empty;
            mvarGPB_Nhuom_HE = false;
            mvarGPB_Nhuom_PAS = false;
            mvarGPB_Nhuom_Tri = false;
            mvarGPB_Nhuom_AFB = false;
            mvarGPB_Nhuom_Giemsa = false;
            mvarGPB_Nhuom_Other = false;
            mvarGPB_HoaMienDich = false;
            mvarGPB_HoaMienDichHuynhQuang = false;
            mvarGPB_HoiChan = false;
            mvarSoVaoVien = String.Empty;
            mvarMaYTe = String.Empty;
            mvarTenBenhNhan = String.Empty;
            mvarNamSinh = int.MinValue;
            mvarGioiTinh = String.Empty;
            mvarDiaChi = String.Empty;
            mvarNoiChiDinh_Id = int.MinValue;
            mvarBacSiChiDinh = String.Empty;
            mvarNgayChiDinh = DateTime.MinValue;
            mvarMauThu_Id = int.MinValue;
            mvarThoiGiannhan = DateTime.MinValue;
            mvarMau = String.Empty;
            mvarDeNghi = String.Empty;
            mvarLoaiFilm_Id = int.MinValue;
            mvarLoaiThuocCanQuang_Id = int.MinValue;
            mvarMa = String.Empty;
            mvarIDHinh = String.Empty;
            mvarBacSiChiDinh_Id = int.MinValue;
            mvarSoPhimHu = decimal.MinValue;
            mvarLoaiPhimHu_Id = int.MinValue;
            mvarDoSoi = String.Empty;
            mvarDoSoi_Id = int.MinValue;
            mvarBanKinhSoi = decimal.MinValue;
            mvarChanDoanLamSang = String.Empty;
            mvarSoDT = String.Empty;
            //mvarMaPhongQLXN = String.Empty;
        }

        public void FillData(DataRow row)
        {
            mvarCLSKetQua_Id = Common.clsControl.IsNullOrEmpty(row["CLSKetQua_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CLSKetQua_Id"]);
            mvarCLSYeuCau_Id = Common.clsControl.IsNullOrEmpty(row["CLSYeuCau_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CLSYeuCau_Id"]);
            mvarNgayThucHien = Common.clsControl.IsNullOrEmpty(row["NgayThucHien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayThucHien"]);
            mvarThoiGianThucHien = Common.clsControl.IsNullOrEmpty(row["ThoiGianThucHien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianThucHien"]);
            mvarNgayGioThucHien = Common.clsControl.IsNullOrEmpty(row["NgayGioThucHien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayGioThucHien"]);
            mvarGioThucHien = Common.clsControl.IsNullOrEmpty(row["GioThucHien"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GioThucHien"]);
            mvarNamThucHien = Common.clsControl.IsNullOrEmpty(row["NamThucHien"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NamThucHien"]);
            mvarThangThucHien = Common.clsControl.IsNullOrEmpty(row["ThangThucHien"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ThangThucHien"]);
            mvarNoiThucHien_Id = Common.clsControl.IsNullOrEmpty(row["NoiThucHien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiThucHien_Id"]);
            mvarBacSiThucHien_Id = Common.clsControl.IsNullOrEmpty(row["BacSiThucHien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiThucHien_Id"]);
            //mvarKyThuat = Common.clsControl.getValueInRow<string>(row["KyThuat"]);
            mvarKyThuatVien01_Id = Common.clsControl.IsNullOrEmpty(row["KyThuatVien01_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KyThuatVien01_Id"]);
            mvarKyThuatVien02_Id = Common.clsControl.IsNullOrEmpty(row["KyThuatVien02_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KyThuatVien02_Id"]);
            mvarBacSiKetLuan_Id = Common.clsControl.IsNullOrEmpty(row["BacSiKetLuan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiKetLuan_Id"]);
            mvarThucHienBenNgoai = Common.clsControl.getValueInRow<bool>(row["ThucHienBenNgoai"]);
            mvarBenhVienThucHien_Id = Common.clsControl.IsNullOrEmpty(row["BenhVienThucHien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhVienThucHien_Id"]);
            mvarTenBacSiBenNgoai = Common.clsControl.getValueInRow<string>(row["TenBacSiBenNgoai"]);
            mvarVungKhaoSat = Common.clsControl.getValueInRow<string>(row["VungKhaoSat"]);
            mvarMoTa = Common.clsControl.getValueInRow<string>(row["MoTa"]);
            mvarMoTa_Text = Common.clsControl.getValueInRow<string>(row["MoTa_Text"]);
            mvarKetLuan = Common.clsControl.getValueInRow<string>(row["KetLuan"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarNhomDichVu_Id = Common.clsControl.IsNullOrEmpty(row["NhomDichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhomDichVu_Id"]);
            mvarMaPhim = Common.clsControl.getValueInRow<string>(row["MaPhim"]);
            mvarTiemCanQuang = Common.clsControl.IsNullOrEmpty(row["TiemCanQuang"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["TiemCanQuang"]);
            mvarSoPhimSuDung = Common.clsControl.IsNullOrEmpty(row["SoPhimSuDung"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoPhimSuDung"]);
            mvarSoThuocSuDung = Common.clsControl.IsNullOrEmpty(row["SoThuocSuDung"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoThuocSuDung"]);
            mvarSinhThiet = Common.clsControl.IsNullOrEmpty(row["SinhThiet"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["SinhThiet"]);
            mvarClotest = Common.clsControl.IsNullOrEmpty(row["Clotest"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Clotest"]);
            mvarPhoto = Common.clsControl.IsNullOrEmpty(row["Photo"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Photo"]);
            mvarVideo = Common.clsControl.IsNullOrEmpty(row["Video"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Video"]);
            mvarMach = Common.clsControl.getValueInRow<string>(row["Mach"]);
            mvarHuyetAp = Common.clsControl.getValueInRow<string>(row["HuyetAp"]);
            mvarNhipTho = Common.clsControl.getValueInRow<string>(row["NhipTho"]);
            mvarNhietDo = Common.clsControl.getValueInRow<string>(row["NhietDo"]);
            mvarChieuCao = Common.clsControl.IsNullOrEmpty(row["ChieuCao"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["ChieuCao"]);
            mvarCanNang = Common.clsControl.IsNullOrEmpty(row["CanNang"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["CanNang"]);
            mvarBSA = Common.clsControl.IsNullOrEmpty(row["BSA"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["BSA"]);
            mvarThietBi_Id = Common.clsControl.IsNullOrEmpty(row["ThietBi_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ThietBi_Id"]);
            mvarPhanLoaiKetQua_Id = Common.clsControl.IsNullOrEmpty(row["PhanLoaiKetQua_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhanLoaiKetQua_Id"]);
            mvarKhoaDuLieu = Common.clsControl.IsNullOrEmpty(row["KhoaDuLieu"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["KhoaDuLieu"]);
            mvarNgayKhoaDuLieu = Common.clsControl.IsNullOrEmpty(row["NgayKhoaDuLieu"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayKhoaDuLieu"]);
            mvarThoiGianKhoaDuLieu = Common.clsControl.IsNullOrEmpty(row["ThoiGianKhoaDuLieu"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianKhoaDuLieu"]);
            mvarNguoiKhoa_Id = Common.clsControl.IsNullOrEmpty(row["NguoiKhoa_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiKhoa_Id"]);
            mvarMaNguoiKhoa = Common.clsControl.IsNullOrEmpty(row["MaNguoiKhoa"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["MaNguoiKhoa"]);
            mvarTenNguoiKhoa = Common.clsControl.getValueInRow<string>(row["TenNguoiKhoa"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarTinhTrangDienNao = Common.clsControl.getValueInRow<string>(row["TinhTrangDienNao"]);
            mvarGPB_AmSo = Common.clsControl.getValueInRow<string>(row["GPB_AmSo"]);
            mvarGPB_PhanLoaiKetQua_Id = Common.clsControl.IsNullOrEmpty(row["GPB_PhanLoaiKetQua_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GPB_PhanLoaiKetQua_Id"]);
            mvarGPB_PhuongPhapLayBenhPham_Id = Common.clsControl.IsNullOrEmpty(row["GPB_PhuongPhapLayBenhPham_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GPB_PhuongPhapLayBenhPham_Id"]);
            mvarGPB_SoMau = Common.clsControl.getValueInRow<string>(row["GPB_SoMau"]);
            mvarGPB_SoLuongMau = Common.clsControl.IsNullOrEmpty(row["GPB_SoLuongMau"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GPB_SoLuongMau"]);
            mvarGPB_Topo_Id = Common.clsControl.IsNullOrEmpty(row["GPB_Topo_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GPB_Topo_Id"]);
            mvarGPB_TopoRegions_Id = Common.clsControl.IsNullOrEmpty(row["GPB_TopoRegions_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GPB_TopoRegions_Id"]);
            mvarGPB_Morpho_Id = Common.clsControl.IsNullOrEmpty(row["GPB_Morpho_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GPB_Morpho_Id"]);
            mvarGPB_Etio_Id = Common.clsControl.IsNullOrEmpty(row["GPB_Etio_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GPB_Etio_Id"]);
            mvarGPB_DaiThe = Common.clsControl.getValueInRow<string>(row["GPB_DaiThe"]);
            mvarGPB_ViThe = Common.clsControl.getValueInRow<string>(row["GPB_ViThe"]);
            mvarGPB_Nhuom_HE = Common.clsControl.getValueInRow<bool>(row["GPB_Nhuom_HE"]);
            mvarGPB_Nhuom_PAS = Common.clsControl.getValueInRow<bool>(row["GPB_Nhuom_PAS"]);
            mvarGPB_Nhuom_Tri = Common.clsControl.getValueInRow<bool>(row["GPB_Nhuom_Tri"]);
            mvarGPB_Nhuom_AFB = Common.clsControl.getValueInRow<bool>(row["GPB_Nhuom_AFB"]);
            mvarGPB_Nhuom_Giemsa = Common.clsControl.getValueInRow<bool>(row["GPB_Nhuom_Giemsa"]);
            mvarGPB_Nhuom_Other = Common.clsControl.getValueInRow<bool>(row["GPB_Nhuom_Other"]);
            mvarGPB_HoaMienDich = Common.clsControl.getValueInRow<bool>(row["GPB_HoaMienDich"]);
            mvarGPB_HoaMienDichHuynhQuang = Common.clsControl.getValueInRow<bool>(row["GPB_HoaMienDichHuynhQuang"]);
            mvarGPB_HoiChan = Common.clsControl.getValueInRow<bool>(row["GPB_HoiChan"]);
            mvarSoVaoVien = Common.clsControl.getValueInRow<string>(row["SoVaoVien"]);
            mvarMaYTe = Common.clsControl.getValueInRow<string>(row["MaYTe"]);
            mvarTenBenhNhan = Common.clsControl.getValueInRow<string>(row["TenBenhNhan"]);
            mvarNamSinh = Common.clsControl.IsNullOrEmpty(row["NamSinh"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NamSinh"]);
            mvarGioiTinh = Common.clsControl.getValueInRow<string>(row["GioiTinh"]);
            mvarDiaChi = Common.clsControl.getValueInRow<string>(row["DiaChi"]);
            mvarNoiChiDinh_Id = Common.clsControl.IsNullOrEmpty(row["NoiChiDinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiChiDinh_Id"]);
            mvarBacSiChiDinh = Common.clsControl.getValueInRow<string>(row["BacSiChiDinh"]);
            mvarNgayChiDinh = Common.clsControl.IsNullOrEmpty(row["NgayChiDinh"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayChiDinh"]);
            mvarMauThu_Id = Common.clsControl.IsNullOrEmpty(row["MauThu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["MauThu_Id"]);
            mvarThoiGiannhan = Common.clsControl.IsNullOrEmpty(row["ThoiGiannhan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGiannhan"]);
            mvarMau = Common.clsControl.getValueInRow<string>(row["Mau"]);
            mvarDeNghi = Common.clsControl.getValueInRow<string>(row["DeNghi"]);
            mvarLoaiFilm_Id = Common.clsControl.IsNullOrEmpty(row["LoaiFilm_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiFilm_Id"]);
            mvarLoaiThuocCanQuang_Id = Common.clsControl.IsNullOrEmpty(row["LoaiThuocCanQuang_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiThuocCanQuang_Id"]);
            mvarMa = Common.clsControl.getValueInRow<string>(row["Ma"]);
            mvarIDHinh = Common.clsControl.getValueInRow<string>(row["IDHinh"]);
            mvarBacSiChiDinh_Id = Common.clsControl.IsNullOrEmpty(row["BacSiChiDinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiChiDinh_Id"]);
            mvarSoPhimHu = Common.clsControl.IsNullOrEmpty(row["SoPhimHu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoPhimHu"]);
            mvarLoaiPhimHu_Id = Common.clsControl.IsNullOrEmpty(row["LoaiPhimHu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiPhimHu_Id"]);
            mvarDoSoi = Common.clsControl.getValueInRow<string>(row["DoSoi"]);
            mvarDoSoi_Id = Common.clsControl.IsNullOrEmpty(row["DoSoi_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DoSoi_Id"]);
            mvarBanKinhSoi = Common.clsControl.IsNullOrEmpty(row["BanKinhSoi"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["BanKinhSoi"]);
            mvarChanDoanLamSang = Common.clsControl.getValueInRow<string>(row["ChanDoanLamSang"]);
            mvarSoDT = Common.clsControl.getValueInRow<string>(row["SoDT"]);
            //mvarMaPhongQLXN = Common.clsControl.getValueInRow<string>(row["MaPhongQLXN"]);
        }

        public string Add()
        {
            string rtCLSKetQua_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSYeuCau_Id", mvarCLSYeuCau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThucHien", mvarNgayThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianThucHien", mvarThoiGianThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayGioThucHien", mvarNgayGioThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioThucHien", mvarGioThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamThucHien", mvarNamThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThangThucHien", mvarThangThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiThucHien_Id", mvarNoiThucHien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiThucHien_Id", mvarBacSiThucHien_Id);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KyThuat", mvarKyThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KyThuatVien01_Id", mvarKyThuatVien01_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KyThuatVien02_Id", mvarKyThuatVien02_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiKetLuan_Id", mvarBacSiKetLuan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThucHienBenNgoai", mvarThucHienBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhVienThucHien_Id", mvarBenhVienThucHien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBacSiBenNgoai", mvarTenBacSiBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@VungKhaoSat", mvarVungKhaoSat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTa", mvarMoTa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTa_Text", mvarMoTa_Text);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetLuan", mvarKetLuan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomDichVu_Id", mvarNhomDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaPhim", mvarMaPhim);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiemCanQuang", mvarTiemCanQuang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhimSuDung", mvarSoPhimSuDung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuocSuDung", mvarSoThuocSuDung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SinhThiet", mvarSinhThiet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Clotest", mvarClotest);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Photo", mvarPhoto);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Video", mvarVideo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetAp", mvarHuyetAp);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BSA", mvarBSA);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThietBi_Id", mvarThietBi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhanLoaiKetQua_Id", mvarPhanLoaiKetQua_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaDuLieu", mvarKhoaDuLieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKhoaDuLieu", mvarNgayKhoaDuLieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKhoaDuLieu", mvarThoiGianKhoaDuLieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiKhoa_Id", mvarNguoiKhoa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNguoiKhoa", mvarMaNguoiKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenNguoiKhoa", mvarTenNguoiKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhTrangDienNao", mvarTinhTrangDienNao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_AmSo", mvarGPB_AmSo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_PhanLoaiKetQua_Id", mvarGPB_PhanLoaiKetQua_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_PhuongPhapLayBenhPham_Id", mvarGPB_PhuongPhapLayBenhPham_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_SoMau", mvarGPB_SoMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_SoLuongMau", mvarGPB_SoLuongMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Topo_Id", mvarGPB_Topo_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_TopoRegions_Id", mvarGPB_TopoRegions_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Morpho_Id", mvarGPB_Morpho_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Etio_Id", mvarGPB_Etio_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_DaiThe", mvarGPB_DaiThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_ViThe", mvarGPB_ViThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_HE", mvarGPB_Nhuom_HE);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_PAS", mvarGPB_Nhuom_PAS);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_Tri", mvarGPB_Nhuom_Tri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_AFB", mvarGPB_Nhuom_AFB);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_Giemsa", mvarGPB_Nhuom_Giemsa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_Other", mvarGPB_Nhuom_Other);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_HoaMienDich", mvarGPB_HoaMienDich);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_HoaMienDichHuynhQuang", mvarGPB_HoaMienDichHuynhQuang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_HoiChan", mvarGPB_HoiChan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoVaoVien", mvarSoVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaYTe", mvarMaYTe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhNhan", mvarTenBenhNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamSinh", mvarNamSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioiTinh", mvarGioiTinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiChiDinh_Id", mvarNoiChiDinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiChiDinh", mvarBacSiChiDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayChiDinh", mvarNgayChiDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MauThu_Id", mvarMauThu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGiannhan", mvarThoiGiannhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mau", mvarMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DeNghi", mvarDeNghi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiFilm_Id", mvarLoaiFilm_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiThuocCanQuang_Id", mvarLoaiThuocCanQuang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ma", mvarMa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDhinh", mvarIDHinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiChiDinh_Id", mvarBacSiChiDinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhimHu", mvarSoPhimHu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiPhimHu_Id", mvarLoaiPhimHu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoSoi", mvarDoSoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoSoi_Id", mvarDoSoi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BanKinhSoi", mvarBanKinhSoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanLamSang", mvarChanDoanLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDT", mvarSoDT);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaPhongQLXN", mvarMaPhongQLXN);

            rtCLSKetQua_Id = ThuVien.mySQL.ExcSP(sp_CLSKETQUA, listPara, "@CLSKetQua_Id", SqlDbType.Int, 32);
            return rtCLSKetQua_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSKetQua_Id", mvarCLSKetQua_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSYeuCau_Id", mvarCLSYeuCau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThucHien", mvarNgayThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianThucHien", mvarThoiGianThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayGioThucHien", mvarNgayGioThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioThucHien", mvarGioThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamThucHien", mvarNamThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThangThucHien", mvarThangThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiThucHien_Id", mvarNoiThucHien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiThucHien_Id", mvarBacSiThucHien_Id);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KyThuat", mvarKyThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KyThuatVien01_Id", mvarKyThuatVien01_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KyThuatVien02_Id", mvarKyThuatVien02_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiKetLuan_Id", mvarBacSiKetLuan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThucHienBenNgoai", mvarThucHienBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhVienThucHien_Id", mvarBenhVienThucHien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBacSiBenNgoai", mvarTenBacSiBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@VungKhaoSat", mvarVungKhaoSat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTa", mvarMoTa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTa_Text", mvarMoTa_Text);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetLuan", mvarKetLuan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomDichVu_Id", mvarNhomDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaPhim", mvarMaPhim);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiemCanQuang", mvarTiemCanQuang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhimSuDung", mvarSoPhimSuDung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuocSuDung", mvarSoThuocSuDung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SinhThiet", mvarSinhThiet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Clotest", mvarClotest);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Photo", mvarPhoto);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Video", mvarVideo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetAp", mvarHuyetAp);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BSA", mvarBSA);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThietBi_Id", mvarThietBi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhanLoaiKetQua_Id", mvarPhanLoaiKetQua_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaDuLieu", mvarKhoaDuLieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKhoaDuLieu", mvarNgayKhoaDuLieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKhoaDuLieu", mvarThoiGianKhoaDuLieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiKhoa_Id", mvarNguoiKhoa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNguoiKhoa", mvarMaNguoiKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenNguoiKhoa", mvarTenNguoiKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhTrangDienNao", mvarTinhTrangDienNao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_AmSo", mvarGPB_AmSo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_PhanLoaiKetQua_Id", mvarGPB_PhanLoaiKetQua_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_PhuongPhapLayBenhPham_Id", mvarGPB_PhuongPhapLayBenhPham_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_SoMau", mvarGPB_SoMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_SoLuongMau", mvarGPB_SoLuongMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Topo_Id", mvarGPB_Topo_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_TopoRegions_Id", mvarGPB_TopoRegions_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Morpho_Id", mvarGPB_Morpho_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Etio_Id", mvarGPB_Etio_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_DaiThe", mvarGPB_DaiThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_ViThe", mvarGPB_ViThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_HE", mvarGPB_Nhuom_HE);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_PAS", mvarGPB_Nhuom_PAS);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_Tri", mvarGPB_Nhuom_Tri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_AFB", mvarGPB_Nhuom_AFB);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_Giemsa", mvarGPB_Nhuom_Giemsa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_Nhuom_Other", mvarGPB_Nhuom_Other);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_HoaMienDich", mvarGPB_HoaMienDich);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_HoaMienDichHuynhQuang", mvarGPB_HoaMienDichHuynhQuang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GPB_HoiChan", mvarGPB_HoiChan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoVaoVien", mvarSoVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaYTe", mvarMaYTe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhNhan", mvarTenBenhNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamSinh", mvarNamSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioiTinh", mvarGioiTinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiChiDinh_Id", mvarNoiChiDinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiChiDinh", mvarBacSiChiDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayChiDinh", mvarNgayChiDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MauThu_Id", mvarMauThu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGiannhan", mvarThoiGiannhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mau", mvarMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DeNghi", mvarDeNghi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiFilm_Id", mvarLoaiFilm_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiThuocCanQuang_Id", mvarLoaiThuocCanQuang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ma", mvarMa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDhinh", mvarIDHinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiChiDinh_Id", mvarBacSiChiDinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhimHu", mvarSoPhimHu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiPhimHu_Id", mvarLoaiPhimHu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoSoi", mvarDoSoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoSoi_Id", mvarDoSoi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BanKinhSoi", mvarBanKinhSoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanLamSang", mvarChanDoanLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDT", mvarSoDT);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaPhongQLXN", mvarMaPhongQLXN);

            ThuVien.mySQL.ExcSP(sp_CLSKETQUA, listPara);
            return mvarCLSKetQua_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSKetQua_Id", mvarCLSKetQua_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_CLSKETQUA, listPara);
            if (rt == "err") { return false; }
            return true;
        }
    }
}
