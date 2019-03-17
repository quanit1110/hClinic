using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityClass
{
    public class clsVPP_ChungTu
    {
        #region "Constants"
        private const String SP_VPP_ChungTu = "SP_VPP_ChungTu";
        #endregion

        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarChungTu_Id { get; set; }

        public System.String mvarMaChungTu { get; set; }

        public System.String mvarSoChungTu { get; set; }

        public System.DateTime mvarNgayChungTu { get; set; }

        public System.String mvarLoaiChungTu { get; set; }

        public System.Int32 mvarMucDichChungTu_Id { get; set; }

        public System.Int32 mvarKhoXuat_Id { get; set; }

        public System.Int32 mvarNguoiGiao_Id { get; set; }

        public System.String mvarNguoiGiao { get; set; }

        public System.Int32 mvarKhoNhap_Id { get; set; }

        public System.Int32 mvarNguoiNhan_Id { get; set; }

        public System.String mvarNguoiNhan { get; set; }

        public System.Int32 mvarNguoiKiemTra_Id { get; set; }

        public System.String mvarNguoiKiemTra { get; set; }

        public System.Int32 mvarNguoiDuyet_Id { get; set; }

        public System.String mvarNguoiDuyet { get; set; }

        public System.Int32 mvarKeToanTruong_Id { get; set; }

        public System.String mvarKeToanTruong { get; set; }

        public System.Int32 mvarThuKho_Id { get; set; }

        public System.String mvarThuKho { get; set; }

        public System.String mvarSoSeri { get; set; }

        public System.String mvarSoHoaDon { get; set; }

        public System.String mvarDienGiai { get; set; }

        public System.Decimal mvarGiaTri { get; set; }

        public System.Decimal mvarGiaTriThanhToan { get; set; }

        public System.Decimal mvarTyLeVat { get; set; }

        public System.Decimal mvarGiaTriVat { get; set; }

        public System.Decimal mvarThueSuat { get; set; }

        public System.Decimal mvarGiaTriThue { get; set; }

        public System.Decimal mvarTyleChietKhau { get; set; }

        public System.Decimal mvarGiaTriChietKhau { get; set; }

        public System.String mvarTienTe_Id { get; set; }

        public System.Decimal mvarTyGia { get; set; }

        public System.String mvarSoChungTuGoc { get; set; }

        public System.DateTime mvarNgayChungTuGoc { get; set; }

        public System.Int32 mvarNhaCungCap_Id { get; set; }

        public System.Int32 mvarHinhThucThanhToan_Id { get; set; }

        public System.Int32 mvarNguonDuoc_Id { get; set; }

        public System.Int32 mvarChungTuLienQuan_Id { get; set; }

        public System.Int32 mvarKhamBenh_Id { get; set; }

        public System.Int32 mvarToaThuocNoiTru_Id { get; set; }

        public System.Int32 mvarBenhAn_Id { get; set; }

        public System.Boolean mvarDaNhanThuoc { get; set; }

        public System.Int32 mvarNguoiNhap_Id { get; set; }

        public System.DateTime mvarNgayNhap { get; set; }

        public System.String mvarTrangThai { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }

        public System.Int32 mvarPhieuLinh_Id { get; set; }

        public System.String mvarDienGiaiNghiepVuPhatSinh { get; set; }

        public System.Int32 mvarDonViGiao_Id { get; set; }

        public System.Decimal mvarTyLeVATNhapKhau { get; set; }

        public System.Decimal mvarGiaTriVATNhapKhau { get; set; }

        public System.String mvarSoSeriNuocNgoai { get; set; }

        public System.String mvarSoHoaDonNuocNgoai { get; set; }

        public System.DateTime mvarNgayHoaDonNuocNgoai { get; set; }

        public System.Int32 mvarKhoSuDung_Id { get; set; }

        public System.String mvarVPP_LoaiVatTu_Id { get; set; }

        public System.Int32 mvarBenhNhan_Id { get; set; }

        public System.String mvarTenBenhNhan { get; set; }

        public System.String mvarGioiTinh { get; set; }

        public System.Int16 mvarNamSinh { get; set; }

        public System.String mvarDiaChi { get; set; }

        public System.String mvarSoDienThoai { get; set; }

        public System.Int32 mvarBacSiGioiThieu_Id { get; set; }

        public System.Int32 mvarDoiTuong_Id { get; set; }

        #endregion
        private DataSet m_Dal;
        #region "Constructors"
            public clsVPP_ChungTu()
            {
                m_Dal = new DataSet();
                Reset();
            }

        #endregion

        #region Public Methods
        public void Reset()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarChungTu_Id = int.MinValue;
            mvarMaChungTu = String.Empty;
            mvarSoChungTu = String.Empty;
            mvarNgayChungTu = DateTime.MinValue;
            mvarLoaiChungTu = String.Empty;
            mvarMucDichChungTu_Id = int.MinValue;
            mvarKhoXuat_Id = int.MinValue;
            mvarNguoiGiao_Id = int.MinValue;
            mvarNguoiGiao = String.Empty;
            mvarKhoNhap_Id = int.MinValue;
            mvarNguoiNhan_Id = int.MinValue;
            mvarNguoiNhan = String.Empty;
            mvarNguoiKiemTra_Id = int.MinValue;
            mvarNguoiKiemTra = String.Empty;
            mvarNguoiDuyet_Id = int.MinValue;
            mvarNguoiDuyet = String.Empty;
            mvarKeToanTruong_Id = int.MinValue;
            mvarKeToanTruong = String.Empty;
            mvarThuKho_Id = int.MinValue;
            mvarThuKho = String.Empty;
            mvarSoSeri = String.Empty;
            mvarSoHoaDon = String.Empty;
            mvarDienGiai = String.Empty;
            mvarGiaTri = int.MinValue;
            mvarGiaTriThanhToan = int.MinValue;
            mvarTyLeVat = int.MinValue;
            mvarGiaTriVat = int.MinValue;
            mvarThueSuat = int.MinValue;
            mvarGiaTriThue = int.MinValue;
            mvarTyleChietKhau = int.MinValue;
            mvarGiaTriChietKhau = int.MinValue;
            mvarTienTe_Id = String.Empty;
            mvarTyGia = int.MinValue;
            mvarSoChungTuGoc = String.Empty;
            mvarNgayChungTuGoc = DateTime.MinValue;
            mvarNhaCungCap_Id = int.MinValue;
            mvarHinhThucThanhToan_Id = int.MinValue;
            mvarNguonDuoc_Id = int.MinValue;
            mvarChungTuLienQuan_Id = int.MinValue;
            mvarKhamBenh_Id = int.MinValue;
            mvarToaThuocNoiTru_Id = int.MinValue;
            mvarBenhAn_Id = int.MinValue;
            mvarDaNhanThuoc = false;
            mvarNguoiNhap_Id = int.MinValue;
            mvarNgayNhap = DateTime.MinValue;
            mvarTrangThai = String.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarPhieuLinh_Id = int.MinValue;
            mvarDienGiaiNghiepVuPhatSinh = String.Empty;
            mvarDonViGiao_Id = int.MinValue;
            mvarTyLeVATNhapKhau = int.MinValue;
            mvarGiaTriVATNhapKhau = int.MinValue;
            mvarSoSeriNuocNgoai = String.Empty;
            mvarSoHoaDonNuocNgoai = String.Empty;
            mvarNgayHoaDonNuocNgoai = DateTime.MinValue;
            mvarKhoSuDung_Id = int.MinValue;
            mvarVPP_LoaiVatTu_Id = String.Empty;
            mvarBenhNhan_Id = int.MinValue;
            mvarTenBenhNhan = String.Empty;
            mvarGioiTinh = String.Empty;
            mvarNamSinh = Int16.MinValue;
            mvarDiaChi = String.Empty;
            mvarSoDienThoai = String.Empty;
            mvarBacSiGioiThieu_Id = int.MinValue;
            mvarDoiTuong_Id = int.MinValue;
        }
        public void FillData(DataRow row)
        {
            mvarChungTu_Id = Common.clsControl.IsNullOrEmpty(row["ChungTu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTu_Id"]);
            mvarMaChungTu = Common.clsControl.getValueInRow<string>(row["MaChungTu"]);
            mvarSoChungTu = Common.clsControl.getValueInRow<string>(row["SoChungTu"]);
            mvarNgayChungTu = Common.clsControl.IsNullOrEmpty(row["NgayChungTu"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayChungTu"]);
            mvarLoaiChungTu = Common.clsControl.getValueInRow<string>(row["LoaiChungTu"]);
            mvarMucDichChungTu_Id = Common.clsControl.IsNullOrEmpty(row["MucDichChungTu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["MucDichChungTu_Id"]);
            mvarKhoXuat_Id = Common.clsControl.IsNullOrEmpty(row["KhoXuat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoXuat_Id"]);
            mvarNguoiGiao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiGiao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiGiao_Id"]);
            mvarNguoiGiao = Common.clsControl.getValueInRow<string>(row["NguoiGiao"]);
            mvarKhoNhap_Id = Common.clsControl.IsNullOrEmpty(row["KhoNhap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoNhap_Id"]);
            mvarNguoiNhan_Id = Common.clsControl.IsNullOrEmpty(row["NguoiNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiNhan_Id"]);
            mvarNguoiNhan = Common.clsControl.getValueInRow<string>(row["NguoiNhan"]);
            mvarNguoiKiemTra_Id = Common.clsControl.IsNullOrEmpty(row["NguoiKiemTra_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiKiemTra_Id"]);
            mvarNguoiKiemTra = Common.clsControl.getValueInRow<string>(row["NguoiKiemTra"]);
            mvarNguoiDuyet_Id = Common.clsControl.IsNullOrEmpty(row["NguoiDuyet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiDuyet_Id"]);
            mvarNguoiDuyet = Common.clsControl.getValueInRow<string>(row["NguoiDuyet"]);
            mvarKeToanTruong_Id = Common.clsControl.IsNullOrEmpty(row["KeToanTruong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KeToanTruong_Id"]);
            mvarKeToanTruong = Common.clsControl.getValueInRow<string>(row["KeToanTruong"]);
            mvarThuKho_Id = Common.clsControl.IsNullOrEmpty(row["ThuKho_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ThuKho_Id"]);
            mvarThuKho = Common.clsControl.getValueInRow<string>(row["ThuKho"]);
            mvarSoSeri = Common.clsControl.getValueInRow<string>(row["SoSeri"]);
            mvarSoHoaDon = Common.clsControl.getValueInRow<string>(row["SoHoaDon"]);
            mvarDienGiai = Common.clsControl.getValueInRow<string>(row["DienGiai"]);
            mvarGiaTri = Common.clsControl.IsNullOrEmpty(row["GiaTri"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiaTri"]);
            mvarGiaTriThanhToan = Common.clsControl.IsNullOrEmpty(row["GiaTriThanhToan"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiaTriThanhToan"]);
            mvarTyLeVat = Common.clsControl.IsNullOrEmpty(row["TyLeVat"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TyLeVat"]);
            mvarGiaTriVat = Common.clsControl.IsNullOrEmpty(row["GiaTriVat"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiaTriVat"]);
            mvarThueSuat = Common.clsControl.IsNullOrEmpty(row["ThueSuat"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ThueSuat"]);
            mvarGiaTriThue = Common.clsControl.IsNullOrEmpty(row["GiaTriThue"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiaTriThue"]);
            mvarTyleChietKhau = Common.clsControl.IsNullOrEmpty(row["TyleChietKhau"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TyleChietKhau"]);
            mvarGiaTriChietKhau = Common.clsControl.IsNullOrEmpty(row["GiaTriChietKhau"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiaTriChietKhau"]);
            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);
            mvarTyGia = Common.clsControl.IsNullOrEmpty(row["TyGia"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TyGia"]);
            mvarSoChungTuGoc = Common.clsControl.getValueInRow<string>(row["SoChungTuGoc"]);
            mvarNgayChungTuGoc = Common.clsControl.IsNullOrEmpty(row["NgayChungTuGoc"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayChungTuGoc"]);
            mvarNhaCungCap_Id = Common.clsControl.IsNullOrEmpty(row["NhaCungCap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhaCungCap_Id"]);
            mvarHinhThucThanhToan_Id = Common.clsControl.IsNullOrEmpty(row["HinhThucThanhToan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HinhThucThanhToan_Id"]);
            mvarNguonDuoc_Id = Common.clsControl.IsNullOrEmpty(row["NguonDuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguonDuoc_Id"]);
            mvarChungTuLienQuan_Id = Common.clsControl.IsNullOrEmpty(row["ChungTuLienQuan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTuLienQuan_Id"]);
            mvarKhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_Id"]);
            mvarToaThuocNoiTru_Id = Common.clsControl.IsNullOrEmpty(row["ToaThuocNoiTru_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ToaThuocNoiTru_Id"]);
            mvarBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["BenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAn_Id"]);
            mvarDaNhanThuoc = Common.clsControl.getValueInRow<bool>(row["DaNhanThuoc"]);
            mvarNguoiNhap_Id = Common.clsControl.IsNullOrEmpty(row["NguoiNhap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiNhap_Id"]);
            mvarNgayNhap = Common.clsControl.IsNullOrEmpty(row["NgayNhap"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayNhap"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarPhieuLinh_Id = Common.clsControl.IsNullOrEmpty(row["PhieuLinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhieuLinh_Id"]);
            mvarDienGiaiNghiepVuPhatSinh = Common.clsControl.getValueInRow<string>(row["DienGiaiNghiepVuPhatSinh"]);
            mvarDonViGiao_Id = Common.clsControl.IsNullOrEmpty(row["DonViGiao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DonViGiao_Id"]);
            mvarTyLeVATNhapKhau = Common.clsControl.IsNullOrEmpty(row["TyLeVATNhapKhau"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TyLeVATNhapKhau"]);
            mvarGiaTriVATNhapKhau = Common.clsControl.IsNullOrEmpty(row["GiaTriVATNhapKhau"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiaTriVATNhapKhau"]);
            mvarSoSeriNuocNgoai = Common.clsControl.getValueInRow<string>(row["SoSeriNuocNgoai"]);
            mvarSoHoaDonNuocNgoai = Common.clsControl.getValueInRow<string>(row["SoHoaDonNuocNgoai"]);
            mvarNgayHoaDonNuocNgoai = Common.clsControl.IsNullOrEmpty(row["NgayHoaDonNuocNgoai"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHoaDonNuocNgoai"]);
            mvarKhoSuDung_Id = Common.clsControl.IsNullOrEmpty(row["KhoSuDung_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoSuDung_Id"]);
            mvarVPP_LoaiVatTu_Id = Common.clsControl.getValueInRow<string>(row["VPP_LoaiVatTu_Id"]);
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarTenBenhNhan = Common.clsControl.getValueInRow<string>(row["TenBenhNhan"]);
            mvarGioiTinh = Common.clsControl.getValueInRow<string>(row["GioiTinh"]);
            mvarNamSinh = Common.clsControl.IsNullOrEmpty(row["NamSinh"].ToString().ToArray()) ? Int16.MinValue : Common.clsControl.getValueInRow<Int16>(row["NamSinh"]);
            mvarDiaChi = Common.clsControl.getValueInRow<string>(row["DiaChi"]);
            mvarSoDienThoai = Common.clsControl.getValueInRow<string>(row["SoDienThoai"]);
            mvarBacSiGioiThieu_Id = Common.clsControl.IsNullOrEmpty(row["BacSiGioiThieu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiGioiThieu_Id"]);
            mvarDoiTuong_Id = Common.clsControl.IsNullOrEmpty(row["DoiTuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DoiTuong_Id"]);
        }
        public bool getData_ByMaChungTu(string ma)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByMaChungTu");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaCHUNGTU", ma);

                ds = ThuVien.mySQL.ExcDataSet(SP_VPP_ChungTu, listPara);
                Reset();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillData(ds.Tables[0].Rows[0]);
                }
                return true;
            }
            catch { return false; }
        }
        #endregion
    }
}
