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
    public class Cls_ChungTu_ChiTiet
    {
        #region "Constants"
        private const string sp_CHUNGTUCHITIET = "sp_CHUNGTUCHITIET";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarChungTuChiTiet_Id { get; set; }
        public System.Int32 mvarChungTu_Id { get; set; }
        public System.Int32 mvarDuoc_Id { get; set; }
        public System.Int32 mvarSoLoNhap_Id { get; set; }
        public System.String mvarSoKiemSoat { get; set; }
        public System.String mvarSoVisa { get; set; }
        public System.Int32 mvarDonViTinh_Id { get; set; }
        public System.Decimal mvarSoLuongYeuCau { get; set; }
        public System.Decimal mvarSoLuongThucTe { get; set; }
        public System.Decimal mvarSoLuongDaXuat { get; set; }
        public System.String mvarTienTe_Id { get; set; }
        public System.Decimal mvarTyGia { get; set; }
        public System.Decimal mvarDonGiaMua { get; set; }
        public System.Decimal mvarDonGiaBan { get; set; }
        public System.Decimal mvarDonGiaVon { get; set; }
        public System.Decimal mvarDonGiaThanhToan { get; set; }
        public System.String mvarSoQuyen { get; set; }
        public System.String mvarSoHoaDonVAT { get; set; }
        public System.Decimal mvarTyLeVAT { get; set; }
        public System.Decimal mvarGiaTriVAT { get; set; }
        public System.Boolean mvarMienPhi { get; set; }
        public System.Int32 mvarLyDoMienPhi_Id { get; set; }
        public System.String mvarSoChungTuKeToan { get; set; }
        public System.String mvarSoChungTuTienMat { get; set; }
        public System.String mvarTrangThai { get; set; }
        public System.Boolean mvarDaPhatSinhPhieuXuat { get; set; }
        public System.Boolean mvarDaPhatSinhPhieuHoanTra { get; set; }
        public System.Boolean mvarKhuyenMai { get; set; }
        public System.Int32 mvarDonDatHang_Id { get; set; }
        public System.String mvarGhiChuChiTiet { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.Int32 mvarNguonHang_Id { get; set; }
        public System.Decimal mvarDonGiaVonVAT { get; set; }
        public System.Decimal mvarThanhTienMua { get; set; }
        public System.Decimal mvarThanhTienVon { get; set; }
        public System.Boolean mvarIsTachLo { get; set; }
        public System.Int32 mvarDonViTinhBanDau_Id { get; set; }
        public System.Decimal mvarSoLuongBanDau { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public Cls_ChungTu_ChiTiet()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public Cls_ChungTu_ChiTiet(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public Cls_ChungTu_ChiTiet(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public Cls_ChungTu_ChiTiet(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarChungTuChiTiet_Id = int.MinValue;
            mvarChungTu_Id = int.MinValue;
            mvarDuoc_Id = int.MinValue;
            mvarSoLoNhap_Id = int.MinValue;
            mvarSoKiemSoat = String.Empty;
            mvarSoVisa = String.Empty;
            mvarDonViTinh_Id = int.MinValue;
            mvarSoLuongYeuCau = decimal.MinValue;
            mvarSoLuongThucTe = decimal.MinValue;
            mvarSoLuongDaXuat = decimal.MinValue;
            mvarTienTe_Id = String.Empty;
            mvarTyGia = decimal.MinValue;
            mvarDonGiaMua = decimal.MinValue;
            mvarDonGiaBan = decimal.MinValue;
            mvarDonGiaVon = decimal.MinValue;
            mvarDonGiaThanhToan = decimal.MinValue;
            mvarSoQuyen = String.Empty;
            mvarSoHoaDonVAT = String.Empty;
            mvarTyLeVAT = decimal.MinValue;
            mvarGiaTriVAT = decimal.MinValue;
            mvarMienPhi = false;
            mvarLyDoMienPhi_Id = int.MinValue;
            mvarSoChungTuKeToan = String.Empty;
            mvarSoChungTuTienMat = String.Empty;
            mvarTrangThai = String.Empty;
            mvarDaPhatSinhPhieuXuat = false;
            mvarDaPhatSinhPhieuHoanTra = false;
            mvarKhuyenMai = false;
            mvarDonDatHang_Id = int.MinValue;
            mvarGhiChuChiTiet = String.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarNguonHang_Id = int.MinValue;
            mvarDonGiaVonVAT = decimal.MinValue;
            mvarThanhTienMua = decimal.MinValue;
            mvarThanhTienVon = decimal.MinValue;
            mvarIsTachLo = false;
            mvarDonViTinhBanDau_Id = int.MinValue;
            mvarSoLuongBanDau = decimal.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarChungTuChiTiet_Id = Common.clsControl.IsNullOrEmpty(row["ChungTuChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTuChiTiet_Id"]);
            mvarChungTu_Id = Common.clsControl.IsNullOrEmpty(row["ChungTu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTu_Id"]);
            mvarDuoc_Id = Common.clsControl.IsNullOrEmpty(row["Duoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Duoc_Id"]);
            mvarSoLoNhap_Id = Common.clsControl.IsNullOrEmpty(row["SoLoNhap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoLoNhap_Id"]);
            mvarSoKiemSoat = Common.clsControl.getValueInRow<string>(row["SoKiemSoat"]);
            mvarSoVisa = Common.clsControl.getValueInRow<string>(row["SoVisa"]);
            mvarDonViTinh_Id = Common.clsControl.IsNullOrEmpty(row["DonViTinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DonViTinh_Id"]);
            mvarSoLuongYeuCau = Common.clsControl.IsNullOrEmpty(row["SoLuongYeuCau"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuongYeuCau"]);
            mvarSoLuongThucTe = Common.clsControl.IsNullOrEmpty(row["SoLuongThucTe"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuongThucTe"]);
            mvarSoLuongDaXuat = Common.clsControl.IsNullOrEmpty(row["SoLuongDaXuat"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuongDaXuat"]);
            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);
            mvarTyGia = Common.clsControl.IsNullOrEmpty(row["TyGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyGia"]);
            mvarDonGiaMua = Common.clsControl.IsNullOrEmpty(row["DonGiaMua"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaMua"]);
            mvarDonGiaBan = Common.clsControl.IsNullOrEmpty(row["DonGiaBan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaBan"]);
            mvarDonGiaVon = Common.clsControl.IsNullOrEmpty(row["DonGiaVon"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaVon"]);
            mvarDonGiaThanhToan = Common.clsControl.IsNullOrEmpty(row["DonGiaThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaThanhToan"]);
            mvarSoQuyen = Common.clsControl.getValueInRow<string>(row["SoQuyen"]);
            mvarSoHoaDonVAT = Common.clsControl.getValueInRow<string>(row["SoHoaDonVAT"]);
            mvarTyLeVAT = Common.clsControl.IsNullOrEmpty(row["TyLeVAT"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyLeVAT"]);
            mvarGiaTriVAT = Common.clsControl.IsNullOrEmpty(row["GiaTriVAT"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriVAT"]);
            mvarMienPhi = Common.clsControl.getValueInRow<bool>(row["MienPhi"]);
            mvarLyDoMienPhi_Id = Common.clsControl.IsNullOrEmpty(row["LyDoMienPhi_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LyDoMienPhi_Id"]);
            mvarSoChungTuKeToan = Common.clsControl.getValueInRow<string>(row["SoChungTuKeToan"]);
            mvarSoChungTuTienMat = Common.clsControl.getValueInRow<string>(row["SoChungTuTienMat"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarDaPhatSinhPhieuXuat = Common.clsControl.getValueInRow<bool>(row["DaPhatSinhPhieuXuat"]);
            mvarDaPhatSinhPhieuHoanTra = Common.clsControl.getValueInRow<bool>(row["DaPhatSinhPhieuHoanTra"]);
            mvarKhuyenMai = Common.clsControl.getValueInRow<bool>(row["KhuyenMai"]);
            mvarDonDatHang_Id = Common.clsControl.IsNullOrEmpty(row["DonDatHang_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DonDatHang_Id"]);
            mvarGhiChuChiTiet = Common.clsControl.getValueInRow<string>(row["GhiChuChiTiet"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarNguonHang_Id = Common.clsControl.IsNullOrEmpty(row["NguonHang_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguonHang_Id"]);
            mvarDonGiaVonVAT = Common.clsControl.IsNullOrEmpty(row["DonGiaVonVAT"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaVonVAT"]);
            mvarThanhTienMua = Common.clsControl.IsNullOrEmpty(row["ThanhTienMua"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["ThanhTienMua"]);
            mvarThanhTienVon = Common.clsControl.IsNullOrEmpty(row["ThanhTienVon"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["ThanhTienVon"]);
            mvarIsTachLo = Common.clsControl.getValueInRow<bool>(row["IsTachLo"]);
            mvarDonViTinhBanDau_Id = Common.clsControl.IsNullOrEmpty(row["DonViTinhBanDau_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DonViTinhBanDau_Id"]);
            mvarSoLuongBanDau = Common.clsControl.IsNullOrEmpty(row["SoLuongBanDau"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuongBanDau"]);

        }
        public string Add()
        {
            string rtChungTuChiTiet_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", mvarChungTu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLoNhap_Id", mvarSoLoNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoKiemSoat", mvarSoKiemSoat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoVisa", mvarSoVisa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViTinh_Id", mvarDonViTinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongYeuCau", mvarSoLuongYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongThucTe", mvarSoLuongThucTe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongDaXuat", mvarSoLuongDaXuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaMua", mvarDonGiaMua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaBan", mvarDonGiaBan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaVon", mvarDonGiaVon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoQuyen", mvarSoQuyen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoHoaDonVAT", mvarSoHoaDonVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeVAT", mvarTyLeVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVAT", mvarGiaTriVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MienPhi", mvarMienPhi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoMienPhi_Id", mvarLyDoMienPhi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoChungTuKeToan", mvarSoChungTuKeToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoChungTuTienMat", mvarSoChungTuTienMat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaPhatSinhPhieuXuat", mvarDaPhatSinhPhieuXuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaPhatSinhPhieuHoanTra", mvarDaPhatSinhPhieuHoanTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhuyenMai", mvarKhuyenMai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonDatHang_Id", mvarDonDatHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChuChiTiet", mvarGhiChuChiTiet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonHang_Id", mvarNguonHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaVonVAT", mvarDonGiaVonVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThanhTienMua", mvarThanhTienMua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThanhTienVon", mvarThanhTienVon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IsTachLo", mvarIsTachLo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViTinhBanDau_Id", mvarDonViTinhBanDau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongBanDau", mvarSoLuongBanDau);

            rtChungTuChiTiet_Id = ThuVien.mySQL.ExcSP(sp_CHUNGTUCHITIET, listPara, "@ChungTuChiTiet_Id", SqlDbType.Int, 32);
            return rtChungTuChiTiet_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuChiTiet_Id", mvarChungTuChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", mvarChungTu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLoNhap_Id", mvarSoLoNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoKiemSoat", mvarSoKiemSoat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoVisa", mvarSoVisa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViTinh_Id", mvarDonViTinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongYeuCau", mvarSoLuongYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongThucTe", mvarSoLuongThucTe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongDaXuat", mvarSoLuongDaXuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaMua", mvarDonGiaMua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaBan", mvarDonGiaBan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaVon", mvarDonGiaVon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoQuyen", mvarSoQuyen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoHoaDonVAT", mvarSoHoaDonVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeVAT", mvarTyLeVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVAT", mvarGiaTriVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MienPhi", mvarMienPhi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoMienPhi_Id", mvarLyDoMienPhi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoChungTuKeToan", mvarSoChungTuKeToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoChungTuTienMat", mvarSoChungTuTienMat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaPhatSinhPhieuXuat", mvarDaPhatSinhPhieuXuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaPhatSinhPhieuHoanTra", mvarDaPhatSinhPhieuHoanTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhuyenMai", mvarKhuyenMai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonDatHang_Id", mvarDonDatHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChuChiTiet", mvarGhiChuChiTiet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonHang_Id", mvarNguonHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaVonVAT", mvarDonGiaVonVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThanhTienMua", mvarThanhTienMua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThanhTienVon", mvarThanhTienVon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IsTachLo", mvarIsTachLo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViTinhBanDau_Id", mvarDonViTinhBanDau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongBanDau", mvarSoLuongBanDau);

            ThuVien.mySQL.ExcSP(sp_CHUNGTUCHITIET, listPara);
            return mvarChungTuChiTiet_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuChiTiet_Id", mvarChungTuChiTiet_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_CHUNGTUCHITIET, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public bool Get_By_Key(int chungTuChiTiet_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuChiTiet_Id", chungTuChiTiet_Id);
                ds = ThuVien.mySQL.ExcDataSet(sp_CHUNGTUCHITIET, listPara);
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
        public DataRow Get_By_ChungTu_Id(int chungTu_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_ChungTuChiTiet");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", chungTu_Id);
                ds = ThuVien.mySQL.ExcDataSet(sp_CHUNGTUCHITIET, listPara);
                ReSet();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillData(ds.Tables[0].Rows[0]);
                    return ds.Tables[0].Rows[0];
                }
               
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());              
            }
            DataTable dt = new DataTable();
            DataRow dtr = dt.NewRow();
            return dtr;
        }
        public void GetListChiTiet(GridControl grv, int chungTu_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_ChungTuChiTiet");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", chungTu_Id);

            Common.clsControl.LoadGirdControl_Y(grv, sp_CHUNGTUCHITIET, listPara);
        }
        public DataTable GetThongtinChungTu(int MaChungTu)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetChiTietNhap_ByChungTuId");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_ID", MaChungTu);

                ds = ThuVien.mySQL.ExcDataSet(sp_CHUNGTUCHITIET, listPara);
                ReSet();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable GetThongtinChungTuHoanTra(int MaChungTu)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetChiTietHoanTra_ByChungTuId");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_ID", MaChungTu);

                ds = ThuVien.mySQL.ExcDataSet(sp_CHUNGTUCHITIET, listPara);
                ReSet();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0];
                }
            }
            catch
            {

            }
            return null;
        }

    }
}
