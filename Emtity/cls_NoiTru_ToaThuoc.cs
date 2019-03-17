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
    public class cls_NoiTru_ToaThuoc
    {
        #region "Constants"
        private const string sp_NOITRU_TOATHUOC = "sp_NOITRU_TOATHUOC";
        #endregion

        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarToaThuoc_Id { get; set; }
        public System.String mvarSoThuTuToa { get; set; }
        public System.Int32 mvarKhamBenh_Id { get; set; }
        public System.Int32 mvarDuoc_Id { get; set; }
        public System.Decimal mvarSoLuong { get; set; }
        public System.Int32 mvarSoNgay { get; set; }
        public System.Int32 mvarSoLanTrenNgay { get; set; }
        public System.Decimal mvarSoLuongTrenLan { get; set; }
        public System.Decimal mvarSoLuong_BuoiSang { get; set; }
        public System.Decimal mvarSoLuong_BuoiTrua { get; set; }
        public System.Decimal mvarSoLuong_BuoiChieu { get; set; }
        public System.Decimal mvarSoLuong_BuoiToi { get; set; }
        public System.Int32 mvarDuongDung_Id { get; set; }
        public System.Int32 mvarBangGia_Id { get; set; }
        public System.Int32 mvarLoaiGia_Id { get; set; }
        public System.String mvarTienTe_Id { get; set; }
        public System.Decimal mvarTyGia { get; set; }
        public System.Decimal mvarDonGiaDoanhThu { get; set; }
        public System.Decimal mvarDonGiaHoTro { get; set; }
        public System.Decimal mvarDonGiaHoTroChiTra { get; set; }
        public System.Decimal mvarDonGiaThanhToan { get; set; }
        public System.Decimal mvarTyLeVAT { get; set; }
        public System.Decimal mvarGiaTriVAT { get; set; }
        public System.String mvarGhiChu { get; set; }
        public System.Int32 mvarNguonDuoc_Id { get; set; }
        public System.Int32 mvarNguonHang_Id { get; set; }
        public System.Int32 mvarPhieuLinh_Id { get; set; }
        public System.Int32 mvarChungTu_Id { get; set; }
        public System.Decimal mvarDonGiaDoanhThuTam { get; set; }
        public System.Decimal mvarDonGiaHoTroTam { get; set; }
        public System.Decimal mvarDonGiaThanhToanTam { get; set; }
        public System.Decimal mvarSoTienThucTe { get; set; }
        public System.Decimal mvarSoTienMienGiam { get; set; }
        public System.Decimal mvarSoTienThatThu { get; set; }
        public System.Decimal mvarSoTienThanhToan { get; set; }
        public System.Decimal mvarSoTienDaThanhToan { get; set; }
        public System.Boolean mvarMienPhi { get; set; }
        public System.String mvarTrangThai { get; set; }
        public System.String mvarNguonLayThuoc { get; set; }
        public System.Boolean mvarHuyToaThuoc { get; set; }
        public System.Boolean mvarMuaNgoai { get; set; }
        public System.Boolean mvarPhatThuocTaiQuay { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.Int32 mvarKhoPhat_Id { get; set; }
        public System.Boolean mvarTinhTien { get; set; }
        public System.Decimal mvarDonGiaChenhLech { get; set; }
        public System.Decimal mvarDonGiaHoTroChenhLech { get; set; }

        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_NoiTru_ToaThuoc()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_NoiTru_ToaThuoc(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_NoiTru_ToaThuoc(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_NoiTru_ToaThuoc(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarToaThuoc_Id = int.MinValue;
            mvarSoThuTuToa = String.Empty;
            mvarKhamBenh_Id = int.MinValue;
            mvarDuoc_Id = int.MinValue;
            mvarSoLuong = decimal.MinValue;
            mvarSoNgay = int.MinValue;
            mvarSoLanTrenNgay = int.MinValue;
            mvarSoLuongTrenLan = decimal.MinValue;
            mvarSoLuong_BuoiSang = decimal.MinValue;
            mvarSoLuong_BuoiTrua = decimal.MinValue;
            mvarSoLuong_BuoiChieu = decimal.MinValue;
            mvarSoLuong_BuoiToi = decimal.MinValue;
            mvarDuongDung_Id = int.MinValue;
            mvarBangGia_Id = int.MinValue;
            mvarLoaiGia_Id = int.MinValue;
            mvarTienTe_Id = String.Empty;
            mvarTyGia = decimal.MinValue;
            mvarDonGiaDoanhThu = decimal.MinValue;
            mvarDonGiaHoTro = decimal.MinValue;
            mvarDonGiaHoTroChiTra = decimal.MinValue;
            mvarDonGiaThanhToan = decimal.MinValue;
            mvarTyLeVAT = decimal.MinValue;
            mvarGiaTriVAT = decimal.MinValue;
            mvarGhiChu = String.Empty;
            mvarNguonDuoc_Id = int.MinValue;
            mvarNguonHang_Id = int.MinValue;
            mvarPhieuLinh_Id = int.MinValue;
            mvarChungTu_Id = int.MinValue;
            mvarDonGiaDoanhThuTam = decimal.MinValue;
            mvarDonGiaHoTroTam = decimal.MinValue;
            mvarDonGiaThanhToanTam = decimal.MinValue;
            mvarSoTienThucTe = decimal.MinValue;
            mvarSoTienMienGiam = decimal.MinValue;
            mvarSoTienThatThu = decimal.MinValue;
            mvarSoTienThanhToan = decimal.MinValue;
            mvarSoTienDaThanhToan = decimal.MinValue;
            mvarMienPhi = false;
            mvarTrangThai = String.Empty;
            mvarNguonLayThuoc = String.Empty;
            mvarHuyToaThuoc = false;
            mvarMuaNgoai = false;
            mvarPhatThuocTaiQuay = false;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarKhoPhat_Id = int.MinValue;
            mvarTinhTien = false;
            mvarDonGiaChenhLech = decimal.MinValue;
            mvarDonGiaHoTroChenhLech = decimal.MinValue;
        }


        public void FillData(DataRow row)
        {
            mvarToaThuoc_Id = Common.clsControl.IsNullOrEmpty(row["ToaThuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ToaThuoc_Id"]);
            mvarSoThuTuToa = Common.clsControl.getValueInRow<string>(row["SoThuTuToa"]);
            mvarKhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_Id"]);
            mvarDuoc_Id = Common.clsControl.IsNullOrEmpty(row["Duoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Duoc_Id"]);
            mvarSoLuong = Common.clsControl.IsNullOrEmpty(row["SoLuong"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong"]);
            mvarSoNgay = Common.clsControl.IsNullOrEmpty(row["SoNgay"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoNgay"]);
            mvarSoLanTrenNgay = Common.clsControl.IsNullOrEmpty(row["SoLanTrenNgay"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoLanTrenNgay"]);
            mvarSoLuongTrenLan = Common.clsControl.IsNullOrEmpty(row["SoLuongTrenLan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuongTrenLan"]);
            mvarSoLuong_BuoiSang = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiSang"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong_BuoiSang"]);
            mvarSoLuong_BuoiTrua = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiTrua"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong_BuoiTrua"]);
            mvarSoLuong_BuoiChieu = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiChieu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong_BuoiChieu"]);
            mvarSoLuong_BuoiToi = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiToi"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong_BuoiToi"]);
            mvarDuongDung_Id = Common.clsControl.IsNullOrEmpty(row["DuongDung_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DuongDung_Id"]);
            mvarBangGia_Id = Common.clsControl.IsNullOrEmpty(row["BangGia_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BangGia_Id"]);
            mvarLoaiGia_Id = Common.clsControl.IsNullOrEmpty(row["LoaiGia_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiGia_Id"]);
            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);
            mvarTyGia = Common.clsControl.IsNullOrEmpty(row["TyGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyGia"]);
            mvarDonGiaDoanhThu = Common.clsControl.IsNullOrEmpty(row["DonGiaDoanhThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaDoanhThu"]);
            mvarDonGiaHoTro = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTro"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTro"]);
            mvarDonGiaHoTroChiTra = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTroChiTra"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTroChiTra"]);
            mvarDonGiaThanhToan = Common.clsControl.IsNullOrEmpty(row["DonGiaThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaThanhToan"]);
            mvarTyLeVAT = Common.clsControl.IsNullOrEmpty(row["TyLeVAT"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyLeVAT"]);
            mvarGiaTriVAT = Common.clsControl.IsNullOrEmpty(row["GiaTriVAT"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriVAT"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarNguonDuoc_Id = Common.clsControl.IsNullOrEmpty(row["NguonDuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguonDuoc_Id"]);
            mvarNguonHang_Id = Common.clsControl.IsNullOrEmpty(row["NguonHang_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguonHang_Id"]);
            mvarPhieuLinh_Id = Common.clsControl.IsNullOrEmpty(row["PhieuLinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhieuLinh_Id"]);
            mvarChungTu_Id = Common.clsControl.IsNullOrEmpty(row["ChungTu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTu_Id"]);
            mvarDonGiaDoanhThuTam = Common.clsControl.IsNullOrEmpty(row["DonGiaDoanhThuTam"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaDoanhThuTam"]);
            mvarDonGiaHoTroTam = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTroTam"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTroTam"]);
            mvarDonGiaThanhToanTam = Common.clsControl.IsNullOrEmpty(row["DonGiaThanhToanTam"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaThanhToanTam"]);
            mvarSoTienThucTe = Common.clsControl.IsNullOrEmpty(row["SoTienThucTe"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoTienThucTe"]);
            mvarSoTienMienGiam = Common.clsControl.IsNullOrEmpty(row["SoTienMienGiam"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoTienMienGiam"]);
            mvarSoTienThatThu = Common.clsControl.IsNullOrEmpty(row["SoTienThatThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoTienThatThu"]);
            mvarSoTienThanhToan = Common.clsControl.IsNullOrEmpty(row["SoTienThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoTienThanhToan"]);
            mvarSoTienDaThanhToan = Common.clsControl.IsNullOrEmpty(row["SoTienDaThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoTienDaThanhToan"]);
            mvarMienPhi = Common.clsControl.getValueInRow<bool>(row["MienPhi"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarNguonLayThuoc = Common.clsControl.getValueInRow<string>(row["NguonLayThuoc"]);
            mvarHuyToaThuoc = Common.clsControl.getValueInRow<bool>(row["HuyToaThuoc"]);
            mvarMuaNgoai = Common.clsControl.getValueInRow<bool>(row["MuaNgoai"]);
            mvarPhatThuocTaiQuay = Common.clsControl.getValueInRow<bool>(row["PhatThuocTaiQuay"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarKhoPhat_Id = Common.clsControl.IsNullOrEmpty(row["KhoPhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoPhat_Id"]);
            mvarTinhTien = Common.clsControl.getValueInRow<bool>(row["TinhTien"]);
            mvarDonGiaChenhLech = Common.clsControl.IsNullOrEmpty(row["DonGiaChenhLech"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaChenhLech"]);
            mvarDonGiaHoTroChenhLech = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTroChenhLech"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTroChenhLech"]);

        }
        public string Add()
        {
            string rtToaThuoc_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTuToa", mvarSoThuTuToa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong", mvarSoLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgay", mvarSoNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLanTrenNgay", mvarSoLanTrenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongTrenLan", mvarSoLuongTrenLan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiSang", mvarSoLuong_BuoiSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiTrua", mvarSoLuong_BuoiTrua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiChieu", mvarSoLuong_BuoiChieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiToi", mvarSoLuong_BuoiToi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuongDung_Id", mvarDuongDung_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BangGia_Id", mvarBangGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia_Id", mvarLoaiGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThu", mvarDonGiaDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTro", mvarDonGiaHoTro);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChiTra", mvarDonGiaHoTroChiTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeVAT", mvarTyLeVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVAT", mvarGiaTriVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonDuoc_Id", mvarNguonDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonHang_Id", mvarNguonHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhieuLinh_Id", mvarPhieuLinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", mvarChungTu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThuTam", mvarDonGiaDoanhThuTam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroTam", mvarDonGiaHoTroTam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToanTam", mvarDonGiaThanhToanTam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTienThucTe", mvarSoTienThucTe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTienMienGiam", mvarSoTienMienGiam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTienThatThu", mvarSoTienThatThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTienThanhToan", mvarSoTienThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTienDaThanhToan", mvarSoTienDaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MienPhi", mvarMienPhi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonLayThuoc", mvarNguonLayThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyToaThuoc", mvarHuyToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MuaNgoai", mvarMuaNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhatThuocTaiQuay", mvarPhatThuocTaiQuay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoPhat_Id", mvarKhoPhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhTien", mvarTinhTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaChenhLech", mvarDonGiaChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChenhLech", mvarDonGiaHoTroChenhLech);

            rtToaThuoc_Id = ThuVien.mySQL.ExcSP(sp_NOITRU_TOATHUOC, listPara, "@ToaThuoc_Id", SqlDbType.Int, 32);
            return rtToaThuoc_Id;

        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuoc_Id", mvarToaThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTuToa", mvarSoThuTuToa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong", mvarSoLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgay", mvarSoNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLanTrenNgay", mvarSoLanTrenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongTrenLan", mvarSoLuongTrenLan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiSang", mvarSoLuong_BuoiSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiTrua", mvarSoLuong_BuoiTrua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiChieu", mvarSoLuong_BuoiChieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiToi", mvarSoLuong_BuoiToi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuongDung_Id", mvarDuongDung_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BangGia_Id", mvarBangGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia_Id", mvarLoaiGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThu", mvarDonGiaDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTro", mvarDonGiaHoTro);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChiTra", mvarDonGiaHoTroChiTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeVAT", mvarTyLeVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVAT", mvarGiaTriVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonDuoc_Id", mvarNguonDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonHang_Id", mvarNguonHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhieuLinh_Id", mvarPhieuLinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", mvarChungTu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThuTam", mvarDonGiaDoanhThuTam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroTam", mvarDonGiaHoTroTam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToanTam", mvarDonGiaThanhToanTam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTienThucTe", mvarSoTienThucTe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTienMienGiam", mvarSoTienMienGiam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTienThatThu", mvarSoTienThatThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTienThanhToan", mvarSoTienThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTienDaThanhToan", mvarSoTienDaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MienPhi", mvarMienPhi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonLayThuoc", mvarNguonLayThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyToaThuoc", mvarHuyToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MuaNgoai", mvarMuaNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhatThuocTaiQuay", mvarPhatThuocTaiQuay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoPhat_Id", mvarKhoPhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhTien", mvarTinhTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaChenhLech", mvarDonGiaChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChenhLech", mvarDonGiaHoTroChenhLech);

            ThuVien.mySQL.ExcSP(sp_NOITRU_TOATHUOC, listPara);
            return mvarToaThuoc_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuoc_Id", mvarToaThuoc_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_NOITRU_TOATHUOC, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public bool Get_By_Key(int toaThuoc_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuoc_Id", toaThuoc_Id);
                ds = ThuVien.mySQL.ExcDataSet(sp_NOITRU_TOATHUOC, listPara);
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
        public void GetToaThuoc_By_KhamBenh_Id(GridControl grv, int _khamBenh_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetThuoc_By_khamBenh_Id");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", _khamBenh_Id);

            Common.clsControl.LoadGirdControl_Y(grv, sp_NOITRU_TOATHUOC, listPara);
        }
    }
}
