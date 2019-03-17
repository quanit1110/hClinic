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
    public class cls_PhieuLinhDuoc
    {
        #region "Constants"
        private const string sp_PHIEULINHDUOC = "sp_PHIEULINHDUOC";
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
        public System.String mvarNguoiKiemTra { get; set; }
        public System.String mvarNguoiDuyet { get; set; }
        public System.String mvarKeToanTruong { get; set; }
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
        public System.Int32 mvarToaThuoc_Id { get; set; }
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
        public System.DateTime mvarTongHop_TuNgay { get; set; }
        public System.DateTime mvarTongHop_DenNgay { get; set; }
        public System.Boolean mvarCoSo { get; set; }
        public System.Boolean mvarTongHop { get; set; }
        public System.String mvarPhanloaiphieulinh { get; set; }

        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_PhieuLinhDuoc()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_PhieuLinhDuoc(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_PhieuLinhDuoc(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_PhieuLinhDuoc(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarNguoiKiemTra = String.Empty;
            mvarNguoiDuyet = String.Empty;
            mvarKeToanTruong = String.Empty;
            mvarThuKho = String.Empty;
            mvarSoSeri = String.Empty;
            mvarSoHoaDon = String.Empty;
            mvarDienGiai = String.Empty;
            mvarGiaTri = decimal.MinValue;
            mvarGiaTriThanhToan = decimal.MinValue;
            mvarTyLeVat = decimal.MinValue;
            mvarGiaTriVat = decimal.MinValue;
            mvarThueSuat = decimal.MinValue;
            mvarGiaTriThue = decimal.MinValue;
            mvarTyleChietKhau = decimal.MinValue;
            mvarGiaTriChietKhau = decimal.MinValue;
            mvarTienTe_Id = String.Empty;
            mvarTyGia = decimal.MinValue;
            mvarSoChungTuGoc = String.Empty;
            mvarNgayChungTuGoc = DateTime.MinValue;
            mvarNhaCungCap_Id = int.MinValue;
            mvarHinhThucThanhToan_Id = int.MinValue;
            mvarNguonDuoc_Id = int.MinValue;
            mvarChungTuLienQuan_Id = int.MinValue;
            mvarToaThuoc_Id = int.MinValue;
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
            mvarTongHop_TuNgay = DateTime.MinValue;
            mvarTongHop_DenNgay = DateTime.MinValue;
            mvarCoSo = false;
            mvarTongHop = false;
            mvarPhanloaiphieulinh = String.Empty;
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
            mvarNguoiKiemTra = Common.clsControl.getValueInRow<string>(row["NguoiKiemTra"]);
            mvarNguoiDuyet = Common.clsControl.getValueInRow<string>(row["NguoiDuyet"]);
            mvarKeToanTruong = Common.clsControl.getValueInRow<string>(row["KeToanTruong"]);
            mvarThuKho = Common.clsControl.getValueInRow<string>(row["ThuKho"]);
            mvarSoSeri = Common.clsControl.getValueInRow<string>(row["SoSeri"]);
            mvarSoHoaDon = Common.clsControl.getValueInRow<string>(row["SoHoaDon"]);
            mvarDienGiai = Common.clsControl.getValueInRow<string>(row["DienGiai"]);
            mvarGiaTri = Common.clsControl.IsNullOrEmpty(row["GiaTri"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTri"]);
            mvarGiaTriThanhToan = Common.clsControl.IsNullOrEmpty(row["GiaTriThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriThanhToan"]);
            mvarTyLeVat = Common.clsControl.IsNullOrEmpty(row["TyLeVat"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyLeVat"]);
            mvarGiaTriVat = Common.clsControl.IsNullOrEmpty(row["GiaTriVat"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriVat"]);
            mvarThueSuat = Common.clsControl.IsNullOrEmpty(row["ThueSuat"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["ThueSuat"]);
            mvarGiaTriThue = Common.clsControl.IsNullOrEmpty(row["GiaTriThue"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriThue"]);
            mvarTyleChietKhau = Common.clsControl.IsNullOrEmpty(row["TyleChietKhau"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyleChietKhau"]);
            mvarGiaTriChietKhau = Common.clsControl.IsNullOrEmpty(row["GiaTriChietKhau"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriChietKhau"]);
            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);
            mvarTyGia = Common.clsControl.IsNullOrEmpty(row["TyGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyGia"]);
            mvarSoChungTuGoc = Common.clsControl.getValueInRow<string>(row["SoChungTuGoc"]);
            mvarNgayChungTuGoc = Common.clsControl.IsNullOrEmpty(row["NgayChungTuGoc"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayChungTuGoc"]);
            mvarNhaCungCap_Id = Common.clsControl.IsNullOrEmpty(row["NhaCungCap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhaCungCap_Id"]);
            mvarHinhThucThanhToan_Id = Common.clsControl.IsNullOrEmpty(row["HinhThucThanhToan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HinhThucThanhToan_Id"]);
            mvarNguonDuoc_Id = Common.clsControl.IsNullOrEmpty(row["NguonDuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguonDuoc_Id"]);
            mvarChungTuLienQuan_Id = Common.clsControl.IsNullOrEmpty(row["ChungTuLienQuan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTuLienQuan_Id"]);
            mvarToaThuoc_Id = Common.clsControl.IsNullOrEmpty(row["ToaThuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ToaThuoc_Id"]);
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
            mvarTongHop_TuNgay = Common.clsControl.IsNullOrEmpty(row["TongHop_TuNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["TongHop_TuNgay"]);
            mvarTongHop_DenNgay = Common.clsControl.IsNullOrEmpty(row["TongHop_DenNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["TongHop_DenNgay"]);
            mvarCoSo = Common.clsControl.getValueInRow<bool>(row["CoSo"]);
            mvarTongHop = Common.clsControl.getValueInRow<bool>(row["TongHop"]);
            mvarPhanloaiphieulinh = Common.clsControl.getValueInRow<string>(row["Phanloaiphieulinh"]);

        }

        public string Add()
        {
            string rtChungTu_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaChungTu", mvarMaChungTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoChungTu", mvarSoChungTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayChungTu", mvarNgayChungTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiChungTu", mvarLoaiChungTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MucDichChungTu_Id", mvarMucDichChungTu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoXuat_Id", mvarKhoXuat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiGiao_Id", mvarNguoiGiao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiGiao", mvarNguoiGiao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoNhap_Id", mvarKhoNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNhan_Id", mvarNguoiNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNhan", mvarNguoiNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiKiemTra", mvarNguoiKiemTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiDuyet", mvarNguoiDuyet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KeToanTruong", mvarKeToanTruong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuKho", mvarThuKho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoSeri", mvarSoSeri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoHoaDon", mvarSoHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienGiai", mvarDienGiai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri", mvarGiaTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThanhToan", mvarGiaTriThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeVat", mvarTyLeVat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVat", mvarGiaTriVat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThueSuat", mvarThueSuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThue", mvarGiaTriThue);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyleChietKhau", mvarTyleChietKhau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriChietKhau", mvarGiaTriChietKhau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoChungTuGoc", mvarSoChungTuGoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayChungTuGoc", mvarNgayChungTuGoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhaCungCap_Id", mvarNhaCungCap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhThucThanhToan_Id", mvarHinhThucThanhToan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonDuoc_Id", mvarNguonDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuLienQuan_Id", mvarChungTuLienQuan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuoc_Id", mvarToaThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuocNoiTru_Id", mvarToaThuocNoiTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaNhanThuoc", mvarDaNhanThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNhap_Id", mvarNguoiNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNhap", mvarNgayNhap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhieuLinh_Id", mvarPhieuLinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienGiaiNghiepVuPhatSinh", mvarDienGiaiNghiepVuPhatSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TongHop_TuNgay", mvarTongHop_TuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TongHop_DenNgay", mvarTongHop_DenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CoSo", mvarCoSo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TongHop", mvarTongHop);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhanLoaiPhieuLinh", mvarPhanloaiphieulinh);

            rtChungTu_Id = ThuVien.mySQL.ExcSP(sp_PHIEULINHDUOC, listPara, "@ChungTu_Id", SqlDbType.Int, 32);
            return rtChungTu_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", mvarChungTu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaChungTu", mvarMaChungTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoChungTu", mvarSoChungTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayChungTu", mvarNgayChungTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiChungTu", mvarLoaiChungTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MucDichChungTu_Id", mvarMucDichChungTu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoXuat_Id", mvarKhoXuat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiGiao_Id", mvarNguoiGiao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiGiao", mvarNguoiGiao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoNhap_Id", mvarKhoNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNhan_Id", mvarNguoiNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNhan", mvarNguoiNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiKiemTra", mvarNguoiKiemTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiDuyet", mvarNguoiDuyet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KeToanTruong", mvarKeToanTruong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuKho", mvarThuKho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoSeri", mvarSoSeri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoHoaDon", mvarSoHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienGiai", mvarDienGiai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri", mvarGiaTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThanhToan", mvarGiaTriThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeVat", mvarTyLeVat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVat", mvarGiaTriVat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThueSuat", mvarThueSuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThue", mvarGiaTriThue);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyleChietKhau", mvarTyleChietKhau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriChietKhau", mvarGiaTriChietKhau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoChungTuGoc", mvarSoChungTuGoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayChungTuGoc", mvarNgayChungTuGoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhaCungCap_Id", mvarNhaCungCap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhThucThanhToan_Id", mvarHinhThucThanhToan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonDuoc_Id", mvarNguonDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuLienQuan_Id", mvarChungTuLienQuan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuoc_Id", mvarToaThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuocNoiTru_Id", mvarToaThuocNoiTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaNhanThuoc", mvarDaNhanThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNhap_Id", mvarNguoiNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNhap", mvarNgayNhap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhieuLinh_Id", mvarPhieuLinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienGiaiNghiepVuPhatSinh", mvarDienGiaiNghiepVuPhatSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TongHop_TuNgay", mvarTongHop_TuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TongHop_DenNgay", mvarTongHop_DenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CoSo", mvarCoSo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TongHop", mvarTongHop);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhanLoaiPhieuLinh", mvarPhanloaiphieulinh);

            ThuVien.mySQL.ExcSP(sp_PHIEULINHDUOC, listPara);
            return mvarChungTu_Id.ToString();
        }
        
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", mvarChungTu_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_PHIEULINHDUOC, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public bool Get_By_Key(int chungTu_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", chungTu_Id);
                ds = ThuVien.mySQL.ExcDataSet(sp_PHIEULINHDUOC, listPara);
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
        public void GetDanhSachYLenh(GridControl grv, DateTime tuNgay,DateTime denNgay)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetDuocYLenh");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", tuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", denNgay);

            Common.clsControl.LoadGirdControl_Y(grv, sp_PHIEULINHDUOC, listPara);
        }
    }
}
