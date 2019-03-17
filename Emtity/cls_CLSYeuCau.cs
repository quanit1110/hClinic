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
    public class cls_CLSYeuCau
    {

        #region "Constants"
        private const String SP_CLSYeuCau = "sp_clsYeuCau";
        private const String SP_GetSoPhieu = "GetSoTangDan";
        #endregion
        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarCLSYeuCau_Id { get; set; }

        public System.String mvarSoPhieuYeuCau { get; set; }

        public System.DateTime mvarNgayYeuCau { get; set; }

        public System.DateTime mvarThoiGianYeuCau { get; set; }

        public System.Int16 mvarNamYeuCau { get; set; }

        public System.Byte mvarThangYeuCau { get; set; }

        public System.Int32 mvarNoiYeuCau_Id { get; set; }

        public System.Int32 mvarBacSiChiDinh_Id { get; set; }

        public System.Int32 mvarNoiThucHien_Id { get; set; }

        public System.Int32 mvarBenhNhan_Id { get; set; }

        public System.Int32 mvarTiepNhan_Id { get; set; }

        public System.Int32 mvarBenhAn_Id { get; set; }

        public System.Int32 mvarLuuTru_Id { get; set; }

        public System.Int32 mvarNhomDichVu_Id { get; set; }

        public System.Boolean mvarThucHienBenNgoai { get; set; }

        public System.Boolean mvarYeuCauBenNgoai { get; set; }

        public System.Int32 mvarDonViBenNgoai_Id { get; set; }

        public System.String mvarTenBacSiBenNgoai { get; set; }

        public System.Boolean mvarTiemCanQuang { get; set; }

        public System.Boolean mvarSinhThiet { get; set; }

        public System.Boolean mvarClotest { get; set; }

        public System.String mvarTrieuChung { get; set; }

        public System.String mvarKetQuaXNKhac { get; set; }

        public System.String mvarDaiThe { get; set; }

        public System.String mvarViThe { get; set; }

        public System.String mvarChanDoan { get; set; }

        public System.String mvarGhiChu { get; set; }

        public System.Boolean mvarKhan { get; set; }

        public System.Boolean mvarThanhToanTruoc { get; set; }

        public System.Int16 mvarSoDichVuYeuCau { get; set; }

        public System.Int16 mvarSoDichVuDongTien { get; set; }

        public System.Boolean mvarDuocPhepThucHien { get; set; }

        public System.Boolean mvarHuyYeuCau { get; set; }

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

        public System.Int32 mvarDichVu_KhamBenh_Id { get; set; }

        public System.Int32 mvarKhamBenh_Id { get; set; }

        public System.Int32 mvarBacSiBenNgoai_Id { get; set; }

        public System.String mvarNoiDungChiTiet { get; set; }

        public System.Int32 mvarNoiThucHienThayDoi_Id { get; set; }

        public System.DateTime mvarNgayGioYeuCau { get; set; }

        public System.Byte mvarGioYeuCau { get; set; }

        public System.Boolean mvarDaNhanBenhPham { get; set; }

        public System.String mvarBenhPham { get; set; }

        public System.DateTime mvarNgayNhanBenhPham { get; set; }

        public System.DateTime mvarThoiGianNhanBenhPham { get; set; }

        public System.Int32 mvarNguoiNhanBenhPham_Id { get; set; }

        public System.Int32 mvarMaNguoiNhapBenhPham { get; set; }

        public System.String mvarTenNguoiNhapBenhPham { get; set; }

        public System.Int32 mvarSoThuTu { get; set; }

        public System.Int32 mvarDoiTuong_Id { get; set; }
        #endregion
        private DataSet m_Dal;
        #region Contructor
        public cls_CLSYeuCau()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_CLSYeuCau(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_CLSYeuCau(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_CLSYeuCau(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = dal;
        }
        #endregion
        public string Add()
        {
            string rtCLSYeuCau_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhieuYeuCau", mvarSoPhieuYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayYeuCau", mvarNgayYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianYeuCau", mvarThoiGianYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamYeuCau", mvarNamYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThangYeuCau", mvarThangYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiYeuCau_Id", mvarNoiYeuCau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiChiDinh_Id", mvarBacSiChiDinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiThucHien_Id", mvarNoiThucHien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Id", mvarLuuTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomDichVu_Id", mvarNhomDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThucHienBenNgoai", mvarThucHienBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@YeuCauBenNgoai", mvarYeuCauBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViBenNgoai_Id", mvarDonViBenNgoai_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBacSiBenNgoai", mvarTenBacSiBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiemCanQuang", mvarTiemCanQuang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SinhThiet", mvarSinhThiet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Clotest", mvarClotest);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrieuChung", mvarTrieuChung);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaXNKhac", mvarKetQuaXNKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaiThe", mvarDaiThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ViThe", mvarViThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoan", mvarChanDoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Khan", mvarKhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThanhToanTruoc", mvarThanhToanTruoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDichVuYeuCau", mvarSoDichVuYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDichVuDongTien", mvarSoDichVuDongTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuocPhepThucHien", mvarDuocPhepThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyYeuCau", mvarHuyYeuCau);
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
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_KhamBenh_Id", mvarDichVu_KhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiBenNgoai_Id", mvarBacSiBenNgoai_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiDungChiTiet", mvarNoiDungChiTiet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiThucHienThayDoi_Id", mvarNoiThucHienThayDoi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayGioYeuCau", mvarNgayGioYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioYeuCau", mvarGioYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaNhanBenhPham", mvarDaNhanBenhPham);


            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhPham", mvarBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNhanBenhPham", mvarNgayNhanBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianNhanBenhPham", mvarThoiGianNhanBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNhanBenhPham_Id", mvarNguoiNhanBenhPham_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNguoiNhapBenhPham", mvarMaNguoiNhapBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenNguoiNhapBenhPham", mvarTenNguoiNhapBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTu", mvarSoThuTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);


            rtCLSYeuCau_Id = ThuVien.mySQL.ExcSP(SP_CLSYeuCau, listPara, "@CLSYeuCau_Id", SqlDbType.Int, 32);
            return rtCLSYeuCau_Id;
        }
        public string Update()
        {
           
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update"); 
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSYeuCau_Id", mvarCLSYeuCau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhieuYeuCau", mvarSoPhieuYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayYeuCau", mvarNgayYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianYeuCau", mvarThoiGianYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamYeuCau", mvarNamYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThangYeuCau", mvarThangYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiYeuCau_Id", mvarNoiYeuCau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiChiDinh_Id", mvarBacSiChiDinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiThucHien_Id", mvarNoiThucHien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Id", mvarLuuTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomDichVu_Id", mvarNhomDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThucHienBenNgoai", mvarThucHienBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@YeuCauBenNgoai", mvarYeuCauBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViBenNgoai_Id", mvarDonViBenNgoai_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBacSiBenNgoai", mvarTenBacSiBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiemCanQuang", mvarTiemCanQuang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SinhThiet", mvarSinhThiet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Clotest", mvarClotest);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrieuChung", mvarTrieuChung);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaXNKhac", mvarKetQuaXNKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaiThe", mvarDaiThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ViThe", mvarViThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoan", mvarChanDoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Khan", mvarKhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThanhToanTruoc", mvarThanhToanTruoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDichVuYeuCau", mvarSoDichVuYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDichVuDongTien", mvarSoDichVuDongTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuocPhepThucHien", mvarDuocPhepThucHien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyYeuCau", mvarHuyYeuCau);
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
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_KhamBenh_Id", mvarDichVu_KhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiBenNgoai_Id", mvarBacSiBenNgoai_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiDungChiTiet", mvarNoiDungChiTiet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiThucHienThayDoi_Id", mvarNoiThucHienThayDoi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayGioYeuCau", mvarNgayGioYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioYeuCau", mvarGioYeuCau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaNhanBenhPham", mvarDaNhanBenhPham);


            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhPham", mvarBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNhanBenhPham", mvarNgayNhanBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianNhanBenhPham", mvarThoiGianNhanBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNhanBenhPham_Id", mvarNguoiNhanBenhPham_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNguoiNhapBenhPham", mvarMaNguoiNhapBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenNguoiNhapBenhPham", mvarTenNguoiNhapBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTu", mvarSoThuTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);


            ThuVien.mySQL.ExcSP(SP_CLSYeuCau, listPara);
            return mvarCLSYeuCau_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSYeuCau_Id", mvarCLSYeuCau_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_CLSYeuCau, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void Reset()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarCLSYeuCau_Id = int.MinValue;
            mvarSoPhieuYeuCau = String.Empty;
            mvarNgayYeuCau = DateTime.MinValue;
            mvarThoiGianYeuCau = DateTime.MinValue;
            mvarNamYeuCau = short.MinValue;
            mvarThangYeuCau = byte.MinValue;
            mvarNoiYeuCau_Id = int.MinValue;
            mvarBacSiChiDinh_Id = int.MinValue;
            mvarNoiThucHien_Id = int.MinValue;
            mvarBenhNhan_Id = int.MinValue;
            mvarTiepNhan_Id = int.MinValue;
            mvarBenhAn_Id = int.MinValue;
            mvarLuuTru_Id = int.MinValue;
            mvarNhomDichVu_Id = int.MinValue;
            mvarThucHienBenNgoai = false;
            mvarYeuCauBenNgoai = false;
            mvarDonViBenNgoai_Id = int.MinValue;
            mvarTenBacSiBenNgoai = String.Empty;
            mvarTiemCanQuang = false;
            mvarSinhThiet = false;
            mvarClotest = false;
            mvarTrieuChung = String.Empty;

            mvarKetQuaXNKhac = String.Empty;
            mvarDaiThe = String.Empty;
            mvarViThe = String.Empty;
            mvarChanDoan = String.Empty;
            mvarGhiChu = String.Empty;
            mvarKhan = false;
            mvarThanhToanTruoc = false;
            mvarSoDichVuYeuCau = short.MinValue;
            mvarSoDichVuDongTien = short.MinValue;
            mvarDuocPhepThucHien = false;
            mvarHuyYeuCau = false;
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
            mvarDichVu_KhamBenh_Id = int.MinValue;
            mvarKhamBenh_Id = int.MinValue;
            mvarBacSiBenNgoai_Id = int.MinValue;
            mvarNoiDungChiTiet = String.Empty;
            mvarNoiThucHienThayDoi_Id = int.MinValue;
            mvarNgayGioYeuCau = DateTime.MinValue;
            mvarGioYeuCau = byte.MinValue;
            mvarDaNhanBenhPham =false;
            mvarBenhPham = String.Empty;
            mvarNgayNhanBenhPham = DateTime.MinValue;
            mvarThoiGianNhanBenhPham = DateTime.MinValue;
            mvarNguoiNhanBenhPham_Id = int.MinValue;
            mvarMaNguoiNhapBenhPham = short.MinValue;
            mvarTenNguoiNhapBenhPham = String.Empty;
            mvarSoThuTu = int.MinValue;
            mvarDoiTuong_Id = int.MinValue;

        }
        public void FillData(DataRow row)
        {
            mvarCLSYeuCau_Id = Common.clsControl.IsNullOrEmpty(row["CLSYeuCau_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CLSYeuCau_Id"]);
            mvarSoPhieuYeuCau = Common.clsControl.getValueInRow<string>(row["SoPhieuYeuCau"]);
            mvarNgayYeuCau = Common.clsControl.IsNullOrEmpty(row["NgayYeuCau"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayYeuCau"]);
            mvarThoiGianYeuCau = Common.clsControl.IsNullOrEmpty(row["ThoiGianYeuCau"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianYeuCau"]);
            mvarNamYeuCau = Common.clsControl.IsNullOrEmpty(row["NamYeuCau"].ToString().ToArray()) ? short.MinValue : Common.clsControl.getValueInRow<short>(row["NamYeuCau"]);
            mvarThangYeuCau = Common.clsControl.IsNullOrEmpty(row["ThangYeuCau"].ToString().ToArray()) ? byte.MinValue : Common.clsControl.getValueInRow<byte>(row["ThangYeuCau"]);
            mvarNoiYeuCau_Id = Common.clsControl.IsNullOrEmpty(row["NoiYeuCau_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiYeuCau_Id"]);
            mvarBacSiChiDinh_Id = Common.clsControl.IsNullOrEmpty(row["BacSiChiDinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiChiDinh_Id"]);
            mvarNoiThucHien_Id = Common.clsControl.IsNullOrEmpty(row["NoiThucHien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiThucHien_Id"]);
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarTiepNhan_Id = Common.clsControl.IsNullOrEmpty(row["TiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhan_Id"]);
            mvarBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["BenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAn_Id"]);
            mvarLuuTru_Id = Common.clsControl.IsNullOrEmpty(row["LuuTru_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LuuTru_Id"]);
            mvarNhomDichVu_Id = Common.clsControl.IsNullOrEmpty(row["NhomDichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhomDichVu_Id"]);
            mvarThucHienBenNgoai = Common.clsControl.IsNullOrEmpty(row["ThucHienBenNgoai"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["ThucHienBenNgoai"]);
            mvarYeuCauBenNgoai = Common.clsControl.IsNullOrEmpty(row["YeuCauBenNgoai"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["YeuCauBenNgoai"]);
            mvarDonViBenNgoai_Id = Common.clsControl.IsNullOrEmpty(row["DonViBenNgoai_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DonViBenNgoai_Id"]);
            mvarTenBacSiBenNgoai = Common.clsControl.getValueInRow<string>(row["TenBacSiBenNgoai"]);
            mvarTiemCanQuang = Common.clsControl.IsNullOrEmpty(row["TiemCanQuang"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["TiemCanQuang"]);
            mvarSinhThiet = Common.clsControl.IsNullOrEmpty(row["SinhThiet"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["SinhThiet"]);
            mvarClotest = Common.clsControl.IsNullOrEmpty(row["Clotest"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Clotest"]);
            mvarTrieuChung = Common.clsControl.getValueInRow<string>(row["TrieuChung"]);

            mvarKetQuaXNKhac = Common.clsControl.getValueInRow<string>(row["KetQuaXNKhac"]);
            mvarDaiThe = Common.clsControl.getValueInRow<string>(row["DaiThe"]);
            mvarViThe = Common.clsControl.getValueInRow<string>(row["ViThe"]);
            mvarChanDoan = Common.clsControl.getValueInRow<string>(row["ChanDoan"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarKhan = Common.clsControl.IsNullOrEmpty(row["Khan"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Khan"]);
            mvarThanhToanTruoc = Common.clsControl.IsNullOrEmpty(row["ThanhToanTruoc"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["ThanhToanTruoc"]);
            mvarSoDichVuYeuCau = Common.clsControl.IsNullOrEmpty(row["SoDichVuYeuCau"].ToString().ToArray()) ? short.MinValue : Common.clsControl.getValueInRow<short>(row["SoDichVuYeuCau"]);
            mvarSoDichVuDongTien = Common.clsControl.IsNullOrEmpty(row["SoDichVuDongTien"].ToString().ToArray()) ? short.MinValue : Common.clsControl.getValueInRow<short>(row["SoDichVuDongTien"]);
            mvarDuocPhepThucHien = Common.clsControl.IsNullOrEmpty(row["DuocPhepThucHien"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DuocPhepThucHien"]);
            mvarHuyYeuCau = Common.clsControl.IsNullOrEmpty(row["HuyYeuCau"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["HuyYeuCau"]);
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
            mvarDichVu_KhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["DichVu_KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DichVu_KhamBenh_Id"]);
            mvarKhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_Id"]);
            mvarBacSiBenNgoai_Id = Common.clsControl.IsNullOrEmpty(row["BacSiBenNgoai_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiBenNgoai_Id"]); ;
            mvarNoiDungChiTiet = Common.clsControl.getValueInRow<string>(row["NoiDungChiTiet"]);
            mvarNoiThucHienThayDoi_Id = Common.clsControl.IsNullOrEmpty(row["NoiThucHienThayDoi_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiThucHienThayDoi_Id"]);
            mvarNgayGioYeuCau = Common.clsControl.IsNullOrEmpty(row["NgayGioYeuCau"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayGioYeuCau"]);
            mvarGioYeuCau = Common.clsControl.IsNullOrEmpty(row["GioYeuCau"].ToString().ToArray()) ? byte.MinValue : Common.clsControl.getValueInRow<byte>(row["GioYeuCau"]);
            mvarDaNhanBenhPham = Common.clsControl.IsNullOrEmpty(row["DaNhanBenhPham"].ToString().ToArray()) ? false: Common.clsControl.getValueInRow<bool>(row["DaNhanBenhPham"]);
            mvarBenhPham = Common.clsControl.getValueInRow<string>(row["BenhPham"]);
            mvarNgayNhanBenhPham = Common.clsControl.IsNullOrEmpty(row["NgayNhanBenhPham"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayNhanBenhPham"]);
            mvarThoiGianNhanBenhPham = Common.clsControl.IsNullOrEmpty(row["ThoiGianNhanBenhPham"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianNhanBenhPham"]);
            mvarNguoiNhanBenhPham_Id = Common.clsControl.IsNullOrEmpty(row["NguoiNhanBenhPham_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiNhanBenhPham_Id"]);
            mvarMaNguoiNhapBenhPham = Common.clsControl.IsNullOrEmpty(row["MaNguoiNhapBenhPham"].ToString().ToArray()) ? short.MinValue : Common.clsControl.getValueInRow<short>(row["MaNguoiNhapBenhPham"]);
            mvarTenNguoiNhapBenhPham = Common.clsControl.getValueInRow<string>(row["TenNguoiNhapBenhPham"]);
            mvarSoThuTu = Common.clsControl.IsNullOrEmpty(row["SoThuTu"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoThuTu"]);
            mvarDoiTuong_Id = Common.clsControl.IsNullOrEmpty(row["DoiTuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DoiTuong_Id"]);
        }
        public string getSoPhieuYeuCau()
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;
            string SoPhieuYc = "";
            DataSet dt = new DataSet();

            try
            {
                using (cmd = new SqlCommand(SP_GetSoPhieu, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableName", "CLSYeuCau");
                cmd.Parameters.AddWithValue("@String_Id", DateTime.Now.ToString("yy.MM"));
                var rs = cmd.Parameters.Add("@Values_Id", SqlDbType.Int);
                rs.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                SoPhieuYc = Int32.Parse(rs.Value.ToString()).ToString(("D6"));
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

            return DateTime.Now.ToString("yy.MM.") + SoPhieuYc;
        }
        public bool Get_By_TiepNhan_Id(int tiepNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetByTiepNhan_Id");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", tiepNhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_CLSYeuCau, listPara);
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
        public bool Update_KhamBenh_Id()
        {

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "update_KhamBenh_Id");          
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSYeuCau_Id", mvarCLSYeuCau_Id);
            ThuVien.mySQL.ExcSP(SP_CLSYeuCau, listPara);
            return true;
        }
        public void GetListYeuCau(GridControl grv, DateTime dt,int benhNhan_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_DsYeuCau");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayYeuCau", dt);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", benhNhan_Id);

            Common.clsControl.LoadGirdControl_Y(grv,SP_CLSYeuCau, listPara);
        }
        public void Update_CLSYeuCau(string soPhieuYeuCau)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update_CLSYeuCau");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhieuYeuCau", soPhieuYeuCau);
            ThuVien.mySQL.ExcSP(SP_CLSYeuCau, listPara);
        }
        public bool GetData_BySoPhieuYeuCau(string soPhieuYeuCau)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_BySoPhieuYeuCau");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhieuYeuCau ", soPhieuYeuCau);
                ds = ThuVien.mySQL.ExcDataSet(SP_CLSYeuCau, listPara);
                Reset();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillData(ds.Tables[0].Rows[0]);
                }
                return true;
            }
            catch { return false; }
        }

        public string getIdBySoPhieu(string soPhieu, params string[] param)
        {
            
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, param[0], param[1]);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, param[2], soPhieu);
            DataTable dt = new DataTable();
            dt = ThuVien.mySQL.ExcDataTable(SP_CLSYeuCau, listPara, dt);
            return dt.Rows[0].ItemArray[0].ToString(); ;
        }
    }
}
