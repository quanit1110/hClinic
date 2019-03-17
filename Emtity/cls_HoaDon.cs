using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace EntityClass
{
    public class cls_HoaDon
    {
        #region "Constants"
        private const string SP_HoaDon = "SP_HoaDon";
        private const String SP_GetSoHoaDon = "GetSoTangDan";
        #endregion

        # region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarHoaDon_Id { get; set; }

        public System.String mvarSoHoaDon { get; set; }

        public System.String mvarLoaiHoaDon { get; set; }

        public System.String mvarSoQuyen { get; set; }

        public System.Int32 mvarSo { get; set; }

        public System.Int32 mvarTiepNhan_Id { get; set; }

        public System.Int32 mvarBenhNhan_Id { get; set; }

        public System.DateTime mvarNgayPhatSinh { get; set; }

        public System.DateTime mvarThoiGianPhatSinh { get; set; }

        public System.Int32 mvarNoiPhatSinh_Id { get; set; }

        public System.Int32 mvarNguoiLap_Id { get; set; }

        public System.DateTime mvarNgayTra { get; set; }

        public System.DateTime mvarThoiGianTra { get; set; }

        public System.Int32 mvarNguoiTra_Id { get; set; }

        public System.Int32 mvarNoiTra_Id { get; set; }

        public System.DateTime mvarNgayHoaDon { get; set; }

        public System.DateTime mvarThoiGianHoaDon { get; set; }

        public System.Int32 mvarNoiThuTien_Id { get; set; }

        public System.Int32 mvarNguoiThuTien_Id { get; set; }

        public System.Decimal mvarGiaTriHoaDon { get; set; }

        public System.Decimal mvarGiaTriVAT { get; set; }

        public System.Decimal mvarGiaTriThucThu { get; set; }

        public System.Int32 mvarHinhThucThanhToan_Id { get; set; }

        public System.String mvarTienTe_Id { get; set; }

        public System.Decimal mvarTyGia { get; set; }

        public System.Decimal mvarGiaTriVND { get; set; }

        public System.Boolean mvarDaThanhToan { get; set; }

        public System.Boolean mvarNgoaiGio { get; set; }

        public System.Boolean mvarHuyHoaDon { get; set; }

        public System.Boolean mvarHoanTra { get; set; }

        public System.Int32 mvarHoaDonLienQuan_Id { get; set; }

        public System.String mvarGhiChu { get; set; }

        public System.String mvarTrangThai { get; set; }

        public System.Int32 mvarDangKyHoaDon_Id { get; set; }

        public System.String mvarSoSerieVAT { get; set; }

        public System.Int32 mvarSoHoaDonVAT { get; set; }

        public System.String mvarKH_MaSoThue { get; set; }

        public System.String mvarKH_TenCongTy { get; set; }

        public System.String mvarKH_DiaChi { get; set; }

        public System.String mvarKH_NguoiDaiDien { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }

        public System.Int32 mvarIDChuyen { get; set; }

        public System.Int32 mvarStatus { get; set; }

        public System.Int32 mvarTransfer_VienPhi_Id { get; set; }

        public System.Int32 mvarDoiTuong_Id { get; set; }

        public System.Int32 mvarInLai { get; set; }

        public System.Int32 mvarInLai_User_Id { get; set; }

        public System.Int32 mvarIDChuyenHuy { get; set; }

        public System.Int32 mvarIDChuyenHoan { get; set; }

        public System.String mvarThuHD_BL { get; set; }

        public System.DateTime mvarNgayKhoaGoi { get; set; }

        public System.String mvarTenCongTy { get; set; }

        public System.String mvarMaSoThue { get; set; }

        public System.String mvarDiaChiCongTy { get; set; }

        public System.Int32 mvarNhomThanhToan_ID { get; set; }

        public System.String mvarHoaDonDoiUng { get; set; }

        public System.Int32 mvarChuyenChungTuID { get; set; }

        public System.Int32 mvarChuyenChungTuHoanID { get; set; }

        public System.Int32 mvarChuyenChungTuHuyID { get; set; }

        public System.Int32 mvarChuyenDoanhThuID { get; set; }

        public System.Int32 mvarChuyenDoanhThuHoanID { get; set; }

        public System.Int32 mvarChuyenDoanhThuHuyID { get; set; }

        public System.Int32 mvarNganHang_ID { get; set; }

        public System.Int32 mvarVAT_Id { get; set; }

        public System.Int32 mvarThe_Id { get; set; }

        public System.Int32 mvarLoaiKhachHang_Id { get; set; }
        #endregion

        private DataSet m_Dal;

        #region Contructor
        public cls_HoaDon()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_HoaDon(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_HoaDon(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_HoaDon(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = dal;
        }
        #endregion

        public string Add()
        {
            string rtHoaDon_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoHoaDon", mvarSoHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiHoaDon", mvarLoaiHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoQuyen", mvarSoQuyen);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@So", mvarSo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayPhatSinh", mvarNgayPhatSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianPhatSinh", mvarThoiGianPhatSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiPhatSinh_Id", mvarNoiPhatSinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLap_Id", mvarNguoiLap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTra", mvarNgayTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTra", mvarThoiGianTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTra_Id", mvarNguoiTra_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTra_Id", mvarNoiTra_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHoaDon", mvarNgayHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianHoaDon", mvarThoiGianHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiThuTien_Id", mvarNoiThuTien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiThuTien_Id", mvarNguoiThuTien_Id);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriHoaDon", mvarGiaTriHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVAT", mvarGiaTriVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThucThu", mvarGiaTriThucThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhThucThanhToan_Id", mvarHinhThucThanhToan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVND", mvarGiaTriVND);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan", mvarDaThanhToan);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgoaiGio", mvarNgoaiGio);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyHoaDon", mvarHuyHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoanTra", mvarHoanTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoaDonLienQuan_Id", mvarHoaDonLienQuan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DangKyHoaDon_Id", mvarDangKyHoaDon_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoSerieVAT", mvarSoSerieVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoHoaDonVAT", mvarSoHoaDonVAT);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KH_MaSoThue", mvarKH_MaSoThue);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KH_TenCongTy", mvarKH_TenCongTy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KH_DiaChi", mvarKH_DiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KH_NguoiDaiDien", mvarKH_NguoiDaiDien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDChuyen", mvarIDChuyen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Status", mvarStatus);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Transfer_VienPhi_Id", mvarTransfer_VienPhi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@InLai", mvarInLai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@InLai_User_Id", mvarInLai_User_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDChuyenHuy", mvarIDChuyenHuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDChuyenHoan", mvarIDChuyenHoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuHD_BL", mvarThuHD_BL);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKhoaGoi", mvarNgayKhoaGoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenCongTy", mvarTenCongTy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaSoThue", mvarMaSoThue);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiCongTy", mvarDiaChiCongTy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomThanhToan_ID", mvarNhomThanhToan_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoaDonDoiUng", mvarHoaDonDoiUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenChungTuID", mvarChuyenChungTuID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenChungTuHoanID", mvarChuyenChungTuHoanID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenChungTuHuyID", mvarChuyenChungTuHuyID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenDoanhThuID", mvarChuyenDoanhThuID);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenDoanhThuHoanID", mvarChuyenDoanhThuHoanID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenDoanhThuHuyID", mvarChuyenDoanhThuHuyID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NganHang_ID", mvarNganHang_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@VAT_Id", mvarVAT_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@The_Id", mvarThe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiKhachHang_Id", mvarLoaiKhachHang_Id);

            rtHoaDon_Id = ThuVien.mySQL.ExcSP(SP_HoaDon, listPara, "@HoaDon_Id", SqlDbType.Int, 32);
            return rtHoaDon_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoHoaDon", mvarSoHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiHoaDon", mvarLoaiHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoQuyen", mvarSoQuyen);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@So", mvarSo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayPhatSinh", mvarNgayPhatSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianPhatSinh", mvarThoiGianPhatSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiPhatSinh_Id", mvarNoiPhatSinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLap_Id", mvarNguoiLap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTra", mvarNgayTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTra", mvarThoiGianTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTra_Id", mvarNguoiTra_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTra_Id", mvarNoiTra_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHoaDon", mvarNgayHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianHoaDon", mvarThoiGianHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiThuTien_Id", mvarNoiThuTien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiThuTien_Id", mvarNguoiThuTien_Id);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriHoaDon", mvarGiaTriHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVAT", mvarGiaTriVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThucThu", mvarGiaTriThucThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhThucThanhToan_Id", mvarHinhThucThanhToan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVND", mvarGiaTriVND);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan", mvarDaThanhToan);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgoaiGio", mvarNgoaiGio);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyHoaDon", mvarHuyHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoanTra", mvarHoanTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoaDonLienQuan_Id", mvarHoaDonLienQuan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoSerieVAT", mvarSoSerieVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoHoaDonVAT", mvarSoHoaDonVAT);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KH_MaSoThue", mvarKH_MaSoThue);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KH_TenCongTy", mvarKH_TenCongTy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KH_DiaChi", mvarKH_DiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KH_NguoiDaiDien", mvarKH_NguoiDaiDien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDChuyen", mvarIDChuyen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Status", mvarStatus);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Transfer_VienPhi_Id", mvarTransfer_VienPhi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@InLai", mvarInLai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@InLai_User_Id", mvarInLai_User_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDChuyenHuy", mvarIDChuyenHuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDChuyenHoan", mvarIDChuyenHoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuHD_BL", mvarThuHD_BL);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKhoaGoi", mvarNgayKhoaGoi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenCongTy", mvarTenCongTy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaSoThue", mvarMaSoThue);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiCongTy", mvarDiaChiCongTy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomThanhToan_ID", mvarNhomThanhToan_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoaDonDoiUng", mvarHoaDonDoiUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenChungTuID", mvarChuyenChungTuID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenChungTuHoanID", mvarChuyenChungTuHoanID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenChungTuHuyID", mvarChuyenChungTuHuyID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenDoanhThuID", mvarChuyenDoanhThuID);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenDoanhThuHoanID", mvarChuyenDoanhThuHoanID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenDoanhThuHuyID", mvarChuyenDoanhThuHuyID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NganHang_ID", mvarNganHang_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@VAT_Id", mvarVAT_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@The_Id", mvarThe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiKhachHang_Id", mvarLoaiKhachHang_Id);

            ThuVien.mySQL.ExcSP(SP_HoaDon, listPara);
            return mvarHoaDon_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoaDon_Id", mvarHoaDon_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_HoaDon, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public void Reset()
        {
            mvarLanguageId = String.Empty;

            mvarUserID = int.MinValue;

            mvarFreePara = String.Empty;

            mvarHoaDon_Id = int.MinValue;

            mvarSoHoaDon = String.Empty;

            mvarLoaiHoaDon = String.Empty;

            mvarSoQuyen = String.Empty;

            mvarSo = int.MinValue;

            mvarTiepNhan_Id = int.MinValue;

            mvarBenhNhan_Id = int.MinValue;

            mvarNgayPhatSinh = DateTime.MinValue;

            mvarThoiGianPhatSinh = DateTime.MinValue;

            mvarNoiPhatSinh_Id = int.MinValue;

            mvarNguoiLap_Id = int.MinValue;

            mvarNgayTra = DateTime.MinValue;

            mvarThoiGianTra = DateTime.MinValue;

            mvarNguoiTra_Id = int.MinValue;

            mvarNoiTra_Id = int.MinValue;

            mvarNgayHoaDon = DateTime.MinValue;

            mvarThoiGianHoaDon = DateTime.MinValue;

            mvarNoiThuTien_Id = int.MinValue;

            mvarNguoiThuTien_Id = int.MinValue;

            mvarGiaTriHoaDon = Decimal.MinValue;

            mvarGiaTriVAT = Decimal.MinValue;

            mvarGiaTriThucThu = Decimal.MinValue;

            mvarHinhThucThanhToan_Id = int.MinValue;

            mvarTienTe_Id = String.Empty;

            mvarTyGia = Decimal.MinValue;

            mvarGiaTriVND = Decimal.MinValue;

            mvarDaThanhToan = false;

            mvarNgoaiGio = false;

            mvarHuyHoaDon = false;

            mvarHoanTra = false;

            mvarHoaDonLienQuan_Id = int.MinValue;

            mvarGhiChu = String.Empty;

            mvarTrangThai = String.Empty;

            mvarDangKyHoaDon_Id = int.MinValue;

            mvarSoSerieVAT = String.Empty;

            mvarSoHoaDonVAT = int.MinValue;

            mvarKH_MaSoThue = String.Empty;

            mvarKH_TenCongTy = String.Empty;

            mvarKH_DiaChi = String.Empty;

            mvarKH_NguoiDaiDien = String.Empty;

            mvarNgayTao = DateTime.MinValue;

            mvarNguoiTao_Id = int.MinValue;

            mvarNgayCapNhat = DateTime.MinValue;

            mvarNguoiCapNhat_Id = int.MinValue;

            mvarIDChuyen = int.MinValue;

            mvarStatus = int.MinValue;

            mvarTransfer_VienPhi_Id = int.MinValue;

            mvarDoiTuong_Id = int.MinValue;

            mvarInLai = int.MinValue;

            mvarInLai_User_Id = int.MinValue;

            mvarIDChuyenHuy = int.MinValue;

            mvarIDChuyenHoan = int.MinValue;

            mvarThuHD_BL = String.Empty;

            mvarNgayKhoaGoi = DateTime.MinValue;

            mvarTenCongTy = String.Empty;

            mvarMaSoThue = String.Empty;

            mvarDiaChiCongTy = String.Empty;

            mvarNhomThanhToan_ID = int.MinValue;

            mvarHoaDonDoiUng = String.Empty;

            mvarChuyenChungTuID = int.MinValue;

            mvarChuyenChungTuHoanID = int.MinValue;

            mvarChuyenChungTuHuyID = int.MinValue;

            mvarChuyenDoanhThuID = int.MinValue;

            mvarChuyenDoanhThuHoanID = int.MinValue;

            mvarChuyenDoanhThuHuyID = int.MinValue;

            mvarNganHang_ID = int.MinValue;

            mvarVAT_Id = int.MinValue;

            mvarThe_Id = int.MinValue;

            mvarLoaiKhachHang_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarHoaDon_Id = Common.clsControl.IsNullOrEmpty(row["HoaDon_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HoaDon_Id"]);

            mvarSoHoaDon = Common.clsControl.getValueInRow<string>(row["SoHoaDon"]);

            mvarLoaiHoaDon = Common.clsControl.getValueInRow<string>(row["LoaiHoaDon"]);

            mvarSoQuyen = Common.clsControl.getValueInRow<string>(row["SoQuyen"]);

            mvarSo = Common.clsControl.IsNullOrEmpty(row["So"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["So"]);

            mvarTiepNhan_Id = Common.clsControl.IsNullOrEmpty(row["TiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhan_Id"]);

            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);

            mvarNgayPhatSinh = Common.clsControl.IsNullOrEmpty(row["NgayPhatSinh"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayPhatSinh"]);

            mvarThoiGianPhatSinh = Common.clsControl.IsNullOrEmpty(row["ThoiGianPhatSinh"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianPhatSinh"]);

            mvarNoiPhatSinh_Id = Common.clsControl.IsNullOrEmpty(row["NoiPhatSinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiPhatSinh_Id"]);

            mvarNguoiLap_Id = Common.clsControl.IsNullOrEmpty(row["NguoiLap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiLap_Id"]);

            mvarNgayTra = Common.clsControl.IsNullOrEmpty(row["NgayTra"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTra"]);

            mvarThoiGianTra = Common.clsControl.IsNullOrEmpty(row["ThoiGianTra"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianTra"]);

            mvarNguoiTra_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTra_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTra_Id"]);

            mvarNoiTra_Id = Common.clsControl.IsNullOrEmpty(row["NoiTra_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiTra_Id"]);

            mvarNgayHoaDon = Common.clsControl.IsNullOrEmpty(row["NgayHoaDon"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHoaDon"]);

            mvarThoiGianHoaDon = Common.clsControl.IsNullOrEmpty(row["ThoiGianHoaDon"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianHoaDon"]);

            mvarNoiThuTien_Id = Common.clsControl.IsNullOrEmpty(row["NoiThuTien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiThuTien_Id"]);

            mvarNguoiThuTien_Id = Common.clsControl.IsNullOrEmpty(row["NguoiThuTien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiThuTien_Id"]);

            mvarGiaTriHoaDon = Common.clsControl.IsNullOrEmpty(row["GiaTriHoaDon"].ToString().ToArray()) ? Decimal.MinValue : Common.clsControl.getValueInRow<Decimal>(row["GiaTriHoaDon"]);

            mvarGiaTriVAT = Common.clsControl.IsNullOrEmpty(row["GiaTriVAT"].ToString().ToArray()) ? Decimal.MinValue : Common.clsControl.getValueInRow<Decimal>(row["GiaTriVAT"]);

            mvarGiaTriThucThu = Common.clsControl.IsNullOrEmpty(row["GiaTriThucThu"].ToString().ToArray()) ? Decimal.MinValue : Common.clsControl.getValueInRow<Decimal>(row["GiaTriThucThu"]);

            mvarHinhThucThanhToan_Id = Common.clsControl.IsNullOrEmpty(row["HinhThucThanhToan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HinhThucThanhToan_Id"]);

            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);

            mvarTyGia = Common.clsControl.IsNullOrEmpty(row["TyGia"].ToString().ToArray()) ? Decimal.MinValue : Common.clsControl.getValueInRow<Decimal>(row["TyGia"]);

            mvarGiaTriVND = Common.clsControl.IsNullOrEmpty(row["GiaTriVND"].ToString().ToArray()) ? Decimal.MinValue : Common.clsControl.getValueInRow<Decimal>(row["GiaTriVND"]);

            mvarDaThanhToan = Common.clsControl.IsNullOrEmpty(row["DaThanhToan"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DaThanhToan"]);

            mvarNgoaiGio = Common.clsControl.IsNullOrEmpty(row["NgoaiGio"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["NgoaiGio"]);

            mvarHuyHoaDon = Common.clsControl.IsNullOrEmpty(row["HuyHoaDon"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["HuyHoaDon"]);

            mvarHoanTra = Common.clsControl.IsNullOrEmpty(row["HoanTra"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["HoanTra"]);

            mvarHoaDonLienQuan_Id = Common.clsControl.IsNullOrEmpty(row["HoaDonLienQuan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HoaDonLienQuan_Id"]);

            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);

            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);

            mvarDangKyHoaDon_Id = Common.clsControl.IsNullOrEmpty(row["DangKyHoaDon_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DangKyHoaDon_Id"]);

            mvarSoSerieVAT = Common.clsControl.getValueInRow<string>(row["SoSerieVAT"]);

            mvarSoHoaDonVAT = Common.clsControl.IsNullOrEmpty(row["SoHoaDonVAT"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoHoaDonVAT"]);

            mvarKH_MaSoThue = Common.clsControl.getValueInRow<string>(row["KH_MaSoThue"]);

            mvarKH_TenCongTy = Common.clsControl.getValueInRow<string>(row["KH_TenCongTy"]);

            mvarKH_DiaChi = Common.clsControl.getValueInRow<string>(row["KH_DiaChi"]);

            mvarKH_NguoiDaiDien = Common.clsControl.getValueInRow<string>(row["KH_NguoiDaiDien"]);

            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);

            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);

            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);

            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);

            mvarIDChuyen = Common.clsControl.IsNullOrEmpty(row["IDChuyen"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["IDChuyen"]);

            mvarStatus = Common.clsControl.IsNullOrEmpty(row["Status"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Status"]);

            mvarTransfer_VienPhi_Id = Common.clsControl.IsNullOrEmpty(row["Transfer_VienPhi_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Transfer_VienPhi_Id"]);

            mvarDoiTuong_Id = Common.clsControl.IsNullOrEmpty(row["DoiTuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DoiTuong_Id"]);

            mvarInLai = Common.clsControl.IsNullOrEmpty(row["InLai"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["InLai"]);

            mvarInLai_User_Id = Common.clsControl.IsNullOrEmpty(row["InLai_User_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["InLai_User_Id"]);

            mvarIDChuyenHuy = Common.clsControl.IsNullOrEmpty(row["IDChuyenHuy"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["IDChuyenHuy"]);

            mvarIDChuyenHoan = Common.clsControl.IsNullOrEmpty(row["IDChuyenHoan"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["IDChuyenHoan"]);

            mvarThuHD_BL = Common.clsControl.getValueInRow<string>(row["ThuHD_BL"]);

            mvarNgayKhoaGoi = Common.clsControl.IsNullOrEmpty(row["NgayKhoaGoi"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayKhoaGoi"]);

            mvarTenCongTy = Common.clsControl.getValueInRow<string>(row["TenCongTy"]);

            mvarMaSoThue = Common.clsControl.getValueInRow<string>(row["MaSoThue"]);

            mvarDiaChiCongTy = Common.clsControl.getValueInRow<string>(row["DiaChiCongTy"]);

            mvarNhomThanhToan_ID = Common.clsControl.IsNullOrEmpty(row["NhomThanhToan_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhomThanhToan_ID"]);

            mvarHoaDonDoiUng = Common.clsControl.getValueInRow<string>(row["HoaDonDoiUng"]);

            mvarChuyenChungTuID = Common.clsControl.IsNullOrEmpty(row["ChuyenChungTuID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenChungTuID"]);

            mvarChuyenChungTuHoanID = Common.clsControl.IsNullOrEmpty(row["ChuyenChungTuHoanID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenChungTuHoanID"]);

            mvarChuyenChungTuHuyID = Common.clsControl.IsNullOrEmpty(row["ChuyenChungTuHuyID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenChungTuHuyID"]);

            mvarChuyenDoanhThuID = Common.clsControl.IsNullOrEmpty(row["ChuyenDoanhThuID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenDoanhThuID"]);

            mvarChuyenDoanhThuHoanID = Common.clsControl.IsNullOrEmpty(row["ChuyenDoanhThuHoanID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenDoanhThuHoanID"]);

            mvarChuyenDoanhThuHuyID = Common.clsControl.IsNullOrEmpty(row["ChuyenDoanhThuHuyID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenDoanhThuHuyID"]);

            mvarNganHang_ID = Common.clsControl.IsNullOrEmpty(row["NganHang_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NganHang_ID"]);

            mvarVAT_Id = Common.clsControl.IsNullOrEmpty(row["VAT_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["VAT_Id"]);

            mvarThe_Id = Common.clsControl.IsNullOrEmpty(row["The_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["The_Id"]);

            mvarLoaiKhachHang_Id = Common.clsControl.IsNullOrEmpty(row["ChuyenChungTuID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenChungTuID"]);
        }
        public DataRow getHoaDonHienTai(string loaiHoaDon)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_SoHoaDon");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiHoaDon", loaiHoaDon);
        
            return ThuVien.mySQL.RtDataRowSP(SP_HoaDon, listPara);
        }
        public string getSoHoaDon(string soQuyen,string loaiHd)
        {
            if (loaiHd == "HD")
            {
                SqlConnection con = ThuVien.mySQL.Conn();
                SqlCommand cmd;
                string SoHd = "";
                DataSet dt = new DataSet();

                try
                {
                    using (cmd = new SqlCommand(SP_GetSoHoaDon, con))
                        cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TableName", "HoaDon");
                    cmd.Parameters.AddWithValue("@String_Id", soQuyen);
                    var rs = cmd.Parameters.Add("@Values_Id", SqlDbType.Int);
                    rs.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    SoHd = Int32.Parse(rs.Value.ToString()).ToString(("D6"));
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

                return soQuyen+"." + SoHd;
            }
            return "";
        }
        public void GetListDichVu_Thuoc(GridControl grv, int benhNhan_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_DsDichVu_ToaThuoc");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", benhNhan_Id);

            Common.clsControl.LoadGirdControl_Y(grv, SP_HoaDon, listPara);
        }
        
    }
}
