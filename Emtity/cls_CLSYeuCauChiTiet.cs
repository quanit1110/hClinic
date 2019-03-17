using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class cls_CLSYeuCauChiTiet
    {
        #region "Constants"
        private const String SP_CLSYeuCauChiTiet = "sp_CLSYEUCAUCHITIET";
        #endregion
        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarYeuCauChiTiet_Id { get; set; }

        public System.Int32 mvarCLSYeuCau_Id { get; set; }

        public System.Int32 mvarDichVu_Id { get; set; }

        public System.Int32 mvarPhongBan_Id { get; set; }

        public System.Int32 mvarLoaiGia_Id { get; set; }

        public System.Decimal mvarDonGiaDoanhThu { get; set; }

        public System.Decimal mvarDonGiaHoTro { get; set; }

        public System.Decimal mvarDonGiaHoTroChiTra { get; set; }

        public System.Decimal mvarDonGiaThanhToan { get; set; }

        public System.String mvarTienTe_Id { get; set; }

        public System.Decimal mvarTyGia { get; set; }

        public System.String mvarMoTa { get; set; }

        public System.String mvarTrangThai { get; set; }

        public System.Boolean mvarThucHienBenNgoai { get; set; }

        public System.Boolean mvarDaThuTien { get; set; }

        public System.Int32 mvarSoLuong { get; set; }

        public System.Decimal mvarGiaTriMienGiam { get; set; }

        public System.Decimal mvarGiaTriThatThu { get; set; }

        public System.Decimal mvarGiaTriDaThanhToan { get; set; }

        public System.Boolean mvarDaThanhToan_MotPhan { get; set; }

        public System.Boolean mvarDaThanhToan_HoanTat { get; set; }

        public System.Boolean mvarDuocPhepThucHien { get; set; }

        public System.Boolean mvarHuy { get; set; }

        public System.DateTime mvarNgayHuy { get; set; }

        public System.DateTime mvarThoiGianHuy { get; set; }

        public System.Int32 mvarNguoiHuy_Id { get; set; }

        public System.Boolean mvarKhongThuTien { get; set; }

        public System.String mvarLyDoKhongThuTien { get; set; }

        public System.Boolean mvarDaXepLichMo { get; set; }

        public System.Boolean mvarBHYTDongTien { get; set; }

        public System.Boolean mvarPTDiKem { get; set; }

        public System.Int32 mvarDoiTuong_Id { get; set; }



        public System.Boolean mvarDaTaoBienBanHoiChan { get; set; }

        public System.Boolean mvarDaLayBenhPham { get; set; }

        public System.Boolean mvarDichVuKemTheo { get; set; }

        public System.Decimal mvarTyLeGiam { get; set; }

        public System.Int32 mvarHenTaiKham_ID { get; set; }

        public System.Int32 mvarHoaDonTamUng_Id { get; set; }

        public System.Decimal mvarDonGia { get; set; }

        public System.Decimal mvarDonGiaPhaiThu { get; set; }

        public System.Int32 mvarGoidichVu_Id { get; set; }

        public System.Int32 mvarBenhNhanGoiDichVu_Id { get; set; }
        public System.Decimal mvarDonGiadichVuTRongGoi { get; set; }

        public System.Decimal mvarPhanTram { get; set; }

        public System.Boolean mvarFollowUp { get; set; }

        public System.Boolean mvarMienPhi_GoiKham { get; set; }

        public System.Int32 mvarThe_Id { get; set; }

        public System.Int32 mvarLoaiKhachHang_Id { get; set; }

        public System.Boolean mvarMienPhi_The { get; set; }

        public System.Decimal mvarDonGiaThe { get; set; }

        public System.Decimal mvarDonGiaTheChiTra { get; set; }

        public System.Boolean mvarThucHienDichVu { get; set; }
        #endregion
        private DataSet m_Dal;
        #region Contructor
        public cls_CLSYeuCauChiTiet()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_CLSYeuCauChiTiet(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_CLSYeuCauChiTiet(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_CLSYeuCauChiTiet(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = dal;
        }
        #endregion
        public string Add()
        {
            string rtCLSYeuCauChiTiet_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSYeuCau_Id", mvarCLSYeuCau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", mvarDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia_Id", mvarLoaiGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThu", mvarDonGiaDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTro", mvarDonGiaHoTro);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChiTra", mvarDonGiaHoTroChiTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTa", mvarMoTa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThucHienBenNgoai", mvarThucHienBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThuTien", mvarDaThuTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong", mvarSoLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriMienGiam", mvarGiaTriMienGiam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThatThu", mvarGiaTriThatThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriDaThanhToan", mvarGiaTriDaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan_MotPhan", mvarDaThanhToan_MotPhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan_HoanTat", mvarDaThanhToan_HoanTat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuocPhepThucHien", mvarDuocPhepThucHien);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Huy", mvarHuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHuy", mvarNgayHuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianHuy", mvarThoiGianHuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiHuy_Id", mvarNguoiHuy_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhongThuTien", mvarKhongThuTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoKhongThuTien", mvarLyDoKhongThuTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaXepLichMo", mvarDaXepLichMo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHYTDongTien", mvarBHYTDongTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PTDiKem", mvarPTDiKem);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuocPhepThucHien", mvarDuocPhepThucHien);


            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaTaoBienBanHoiChan", mvarDaTaoBienBanHoiChan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaLayBenhPham", mvarDaLayBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVuKemTheo", mvarDichVuKemTheo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeGiam", mvarTyLeGiam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HenTaiKham_ID", mvarHenTaiKham_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoaDonTamUng_Id", mvarHoaDonTamUng_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGia", mvarDonGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaPhaiThu", mvarDonGiaPhaiThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GoidichVu_Id", mvarGoidichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhanGoiDichVu_Id", mvarBenhNhanGoiDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiadichVuTRongGoi", mvarDonGiadichVuTRongGoi);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhanTram", mvarPhanTram);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@FollowUp", mvarFollowUp);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MienPhi_GoiKham", mvarMienPhi_GoiKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@The_Id", mvarThe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiKhachHang_Id", mvarLoaiKhachHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MienPhi_The", mvarMienPhi_The);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThe", mvarDonGiaThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaTheChiTra", mvarDonGiaTheChiTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThucHienDichVu", mvarThucHienDichVu);


            rtCLSYeuCauChiTiet_Id = ThuVien.mySQL.ExcSP(SP_CLSYeuCauChiTiet, listPara, "@YeuCauChiTiet_Id", SqlDbType.Int, 32);
            return rtCLSYeuCauChiTiet_Id;
        }
        public string Update()
        {
            string rtCLSYeuCauChiTiet_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSYeuCau_Id", mvarCLSYeuCau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", mvarDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia_Id", mvarLoaiGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThu", mvarDonGiaDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTro", mvarDonGiaHoTro);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChiTra", mvarDonGiaHoTroChiTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTa", mvarMoTa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThucHienBenNgoai", mvarThucHienBenNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThuTien", mvarDaThuTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong", mvarSoLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriMienGiam", mvarGiaTriMienGiam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThatThu", mvarGiaTriThatThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriDaThanhToan", mvarGiaTriDaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan_MotPhan", mvarDaThanhToan_MotPhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan_HoanTat", mvarDaThanhToan_HoanTat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuocPhepThucHien", mvarDuocPhepThucHien);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Huy", mvarHuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHuy", mvarNgayHuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianHuy", mvarThoiGianHuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiHuy_Id", mvarNguoiHuy_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhongThuTien", mvarKhongThuTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoKhongThuTien", mvarLyDoKhongThuTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaXepLichMo", mvarDaXepLichMo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHYTDongTien", mvarBHYTDongTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PTDiKem", mvarPTDiKem);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuocPhepThucHien", mvarDuocPhepThucHien);


            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaTaoBienBanHoiChan", mvarDaTaoBienBanHoiChan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaLayBenhPham", mvarDaLayBenhPham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVuKemTheo", mvarDichVuKemTheo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeGiam", mvarTyLeGiam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HenTaiKham_ID", mvarHenTaiKham_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoaDonTamUng_Id", mvarHoaDonTamUng_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGia", mvarDonGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaPhaiThu", mvarDonGiaPhaiThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GoidichVu_Id", mvarGoidichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhanGoiDichVu_Id", mvarBenhNhanGoiDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiadichVuTRongGoi", mvarDonGiadichVuTRongGoi);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhanTram", mvarPhanTram);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@FollowUp", mvarFollowUp);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MienPhi_GoiKham", mvarMienPhi_GoiKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@The_Id", mvarThe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiKhachHang_Id", mvarLoaiKhachHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MienPhi_The", mvarMienPhi_The);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThe", mvarDonGiaThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaTheChiTra", mvarDonGiaTheChiTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThucHienDichVu", mvarThucHienDichVu);

            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaChenhLech", mvarDonGiaChenhLech);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChenhLech", mvarDonGiaHoTroChenhLech);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriPhaiThanhToan", mvarGiaTriPhaiThanhToan);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriDaThanhToan_ChenhLech", mvarGiaTriDaThanhToan_ChenhLech);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriDaThanhToan_HoTroChenhLech", mvarGiaTriDaThanhToan_HoTroChenhLech);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuHoaDon", mvarThuHoaDon);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuBienLai", mvarThuBienLai);

            rtCLSYeuCauChiTiet_Id = ThuVien.mySQL.ExcSP(SP_CLSYeuCauChiTiet, listPara, "@YeuCauChiTiet_Id", SqlDbType.Int, 32);
            return rtCLSYeuCauChiTiet_Id;
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@YeuCauChiTiet_Id", mvarYeuCauChiTiet_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_CLSYeuCauChiTiet, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void Reset()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarYeuCauChiTiet_Id = int.MinValue;
            mvarCLSYeuCau_Id = int.MinValue;
            mvarDichVu_Id = int.MinValue;
            mvarPhongBan_Id = int.MinValue;
            mvarLoaiGia_Id = int.MinValue;
            mvarDonGiaDoanhThu = decimal.MinValue;
            mvarDonGiaHoTro = decimal.MinValue;
            mvarDonGiaHoTroChiTra = decimal.MinValue;
            mvarDonGiaThanhToan = decimal.MinValue;
            mvarTienTe_Id = String.Empty;
            mvarTyGia = decimal.MinValue;
            mvarMoTa = String.Empty;
            mvarTrangThai = String.Empty;
            mvarThucHienBenNgoai = false;
            mvarDaThuTien = false;
            mvarSoLuong = int.MinValue;
            mvarGiaTriMienGiam = decimal.MinValue;
            mvarGiaTriThatThu = decimal.MinValue;
            mvarGiaTriDaThanhToan = decimal.MinValue;
            mvarDaThanhToan_MotPhan = false;
            mvarDaThanhToan_HoanTat = false;
            mvarDuocPhepThucHien = false;
            mvarHuy = false;

            mvarNgayHuy = DateTime.MinValue;
            mvarThoiGianHuy = DateTime.MinValue;
            mvarNguoiHuy_Id = int.MinValue;
            mvarKhongThuTien = false;
            mvarLyDoKhongThuTien = String.Empty;
            mvarDaXepLichMo = false;
            mvarBHYTDongTien = false;
            mvarPTDiKem = false;
            mvarDaTaoBienBanHoiChan = false;
            mvarDaLayBenhPham = false;
            mvarDichVuKemTheo = false;
            mvarTyLeGiam = decimal.MinValue;
            mvarHenTaiKham_ID = int.MinValue;
            mvarHoaDonTamUng_Id = int.MinValue;
            mvarDonGia = decimal.MinValue;
            mvarDonGiaPhaiThu = decimal.MinValue;
            mvarGoidichVu_Id = int.MinValue;
            mvarBenhNhanGoiDichVu_Id = int.MinValue;
            mvarDonGiadichVuTRongGoi = decimal.MinValue;
            mvarPhanTram = decimal.MinValue;

            mvarFollowUp = false;
            
            mvarThe_Id = int.MinValue;
            mvarLoaiKhachHang_Id = int.MinValue;
            mvarMienPhi_The = false;
            mvarDonGiaThe = decimal.MinValue;
            mvarDonGiaTheChiTra = decimal.MinValue;
            mvarThucHienDichVu = false;
            

        }
        public void FillData(DataRow row)
        {
            mvarYeuCauChiTiet_Id = Common.clsControl.IsNullOrEmpty(row["CLSYeuCauChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CLSYeuCauChiTiet_Id"]);
            mvarCLSYeuCau_Id = Common.clsControl.IsNullOrEmpty(row["CLSYeuCau_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CLSYeuCau_Id"]);
            mvarDichVu_Id = Common.clsControl.IsNullOrEmpty(row["DichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DichVu_Id"]);
            mvarPhongBan_Id = Common.clsControl.IsNullOrEmpty(row["PhongBan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhongBan_Id"]);
            mvarLoaiGia_Id = Common.clsControl.IsNullOrEmpty(row["LoaiGia_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiGia_Id"]);
            mvarDonGiaDoanhThu = Common.clsControl.IsNullOrEmpty(row["DonGiaDoanhThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaDoanhThu"]);
            mvarDonGiaHoTro = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTro"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTro"]);
            mvarDonGiaHoTroChiTra = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTroChiTra"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTroChiTra"]);
            mvarDonGiaThanhToan = Common.clsControl.IsNullOrEmpty(row["DonGiaThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaThanhToan"]);
            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);
            mvarTyGia = Common.clsControl.IsNullOrEmpty(row["TyGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyGia"]);
            mvarMoTa = Common.clsControl.getValueInRow<string>(row["MoTa"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarThucHienBenNgoai = Common.clsControl.IsNullOrEmpty(row["ThucHienBenNgoai"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["ThucHienBenNgoai"]);
            mvarDaThuTien = Common.clsControl.IsNullOrEmpty(row["DaThuTien"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DaThuTien"]);
            mvarSoLuong = Common.clsControl.IsNullOrEmpty(row["SoLuong"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoLuong"]);
            mvarGiaTriMienGiam = Common.clsControl.IsNullOrEmpty(row["GiaTriMienGiam"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriMienGiam"]);
            mvarGiaTriThatThu = Common.clsControl.IsNullOrEmpty(row["GiaTriThatThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriThatThu"]);
            mvarGiaTriDaThanhToan = Common.clsControl.IsNullOrEmpty(row["GiaTriDaThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriDaThanhToan"]);
            mvarDaThanhToan_MotPhan = Common.clsControl.IsNullOrEmpty(row["DaThanhToan_MotPhan"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DaThanhToan_MotPhan"]);
            mvarDaThanhToan_HoanTat = Common.clsControl.IsNullOrEmpty(row["DaThanhToan_HoanTat"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DaThanhToan_HoanTat"]);
            mvarDuocPhepThucHien = Common.clsControl.IsNullOrEmpty(row["DuocPhepThucHien"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DuocPhepThucHien"]);

            mvarHuy = Common.clsControl.IsNullOrEmpty(row["Huy"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Huy"]);
            mvarNgayHuy = Common.clsControl.IsNullOrEmpty(row["NgayHuy"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHuy"]);
            mvarThoiGianHuy = Common.clsControl.IsNullOrEmpty(row["ThoiGianHuy"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianHuy"]);
            mvarNguoiHuy_Id = Common.clsControl.IsNullOrEmpty(row["NguoiHuy_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiHuy_Id"]);
            mvarKhongThuTien = Common.clsControl.IsNullOrEmpty(row["KhongThuTien"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["KhongThuTien"]);
            mvarLyDoKhongThuTien = Common.clsControl.getValueInRow<string>(row["LyDoKhongThuTien"]);
            mvarDaXepLichMo = Common.clsControl.IsNullOrEmpty(row["DaXepLichMo"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DaXepLichMo"]);
            mvarBHYTDongTien = Common.clsControl.IsNullOrEmpty(row["BHYTDongTien"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["BHYTDongTien"]);
            mvarPTDiKem = Common.clsControl.IsNullOrEmpty(row["PTDiKem"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["PTDiKem"]);
            mvarDaTaoBienBanHoiChan = Common.clsControl.IsNullOrEmpty(row["DaTaoBienBanHoiChan"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DaTaoBienBanHoiChan"]);
            mvarDaLayBenhPham = Common.clsControl.IsNullOrEmpty(row["DaLayBenhPham"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DaLayBenhPham"]);
            mvarDichVuKemTheo = Common.clsControl.IsNullOrEmpty(row["DichVuKemTheo"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DichVuKemTheo"]);
            mvarTyLeGiam = Common.clsControl.IsNullOrEmpty(row["TyLeGiam"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyLeGiam"]);
            mvarHenTaiKham_ID = Common.clsControl.IsNullOrEmpty(row["HenTaiKham_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HenTaiKham_ID"]);
            mvarHoaDonTamUng_Id = Common.clsControl.IsNullOrEmpty(row["HoaDonTamUng_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HoaDonTamUng_Id"]);
            mvarDonGia = Common.clsControl.IsNullOrEmpty(row["DonGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGia"]);
            mvarDonGiaPhaiThu = Common.clsControl.IsNullOrEmpty(row["DonGiaPhaiThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaPhaiThu"]);
            mvarGoidichVu_Id = Common.clsControl.IsNullOrEmpty(row["GoidichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GoidichVu_Id"]);
            mvarBenhNhanGoiDichVu_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhanGoiDichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhanGoiDichVu_Id"]);
            mvarDonGiadichVuTRongGoi = Common.clsControl.IsNullOrEmpty(row["DonGiadichVuTRongGoi"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiadichVuTRongGoi"]);

            mvarPhanTram = Common.clsControl.IsNullOrEmpty(row["PhanTram"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["PhanTram"]);
            mvarFollowUp = Common.clsControl.IsNullOrEmpty(row["FollowUp"].ToString().ToArray()) ? false: Common.clsControl.getValueInRow<bool>(row["FollowUp"]);
            mvarThe_Id = Common.clsControl.IsNullOrEmpty(row["The_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["The_Id"]);
            mvarLoaiKhachHang_Id = Common.clsControl.IsNullOrEmpty(row["LoaiKhachHang_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiKhachHang_Id"]);
            mvarMienPhi_The = Common.clsControl.IsNullOrEmpty(row["MienPhi_The"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["MienPhi_The"]); 
            mvarDonGiaThe = Common.clsControl.IsNullOrEmpty(row["DonGiaThe"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaThe"]); ;
            mvarDonGiaTheChiTra = Common.clsControl.IsNullOrEmpty(row["DonGiaTheChiTra"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaTheChiTra"]);
            mvarThucHienDichVu = Common.clsControl.IsNullOrEmpty(row["ThucHienDichVu"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["ThucHienDichVu"]);
            }
    }
}
