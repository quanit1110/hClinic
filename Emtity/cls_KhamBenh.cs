using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
   public class cls_KhamBenh
    {
        #region "Constants"
        private const string SP_KhamBenh = "SP_KhamBenh";
        
        #endregion
        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarKhamBenh_Id { get; set; }

        public System.Int32 mvarBenhNhan_Id { get; set; }

        public System.Int32 mvarTiepNhan_Id { get; set; }

        public System.Int32 mvarDichVu_Id { get; set; }

        public System.Int32 mvarPhongBan_Id { get; set; }

        public System.DateTime mvarNgayKham { get; set; }

        public System.DateTime mvarThoiGianKham { get; set; }

        public System.Int32 mvarBacSiKham_Id { get; set; }

        public System.String mvarChanDoanKhoaKham { get; set; }

        public System.Int32 mvarChanDoanICD_Id { get; set; }

        public System.Int32 mvarChanDoanPhuICD_Id { get; set; }

        public System.Int32 mvarHuongGiaiQuyet_Id { get; set; }

        public System.String mvarGhiChu { get; set; }

        public System.Int16 mvarSoNgayHenTaiKham { get; set; }

        public System.Int32 mvarNhapKhoa_Id { get; set; }

        public System.Int32 mvarChuyenDenBenhVien_Id { get; set; }

        public System.Int32 mvarCheDoAnUong_Id { get; set; }

        public System.Int32 mvarCheDoChamSoc_Id { get; set; }

        public System.Boolean mvarKhamCapCuu { get; set; }

        public System.Int32 mvarKhamBenhLanDau_Id { get; set; }

        public System.Int32 mvarLyDoNhapVien_Id { get; set; }

        public System.Int16 mvarMach { get; set; }

        public System.Int16 mvarHuyetApThap { get; set; }

        public System.Int16 mvarHuyetApCao { get; set; }

        public System.Int16 mvarNhipTho { get; set; }

        public System.Decimal mvarNhietDo { get; set; }

        public System.Decimal mvarChieuCao { get; set; }

        public System.Decimal mvarCanNang { get; set; }

        public System.String mvarTrieuChungLamSang { get; set; }

        public System.Int32 mvarDichVu_KhamBenh_Id { get; set; }

        public System.String mvarChanDoanSoBo { get; set; }

        public System.Int32 mvarYeuCauChiTiet_Id { get; set; }

        public System.Int32 mvarKhamBenh_ChuyenKhoa_Id { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }

        public System.String mvarToaThuocMuaNgoai { get; set; }

        public System.String mvarChanDoanICD { get; set; }

        public System.String mvarGiaiDoanBenh { get; set; }

        public System.String mvarTacDungPhu { get; set; }

        public System.String mvarTuanThuCuaBN { get; set; }

        public System.Int32 mvarHuongDieuTri_Id { get; set; }

        public System.String mvarSoNgayDieuTri { get; set; }

        public System.String mvarGhiChu2 { get; set; }

        public System.Int32 mvarSoBenhAnNgoaiTru_Id { get; set; }

        public System.String mvarDieuTriDuPhong { get; set; }

        public System.Int32 mvarDoiTuong_Id { get; set; }

        public System.Decimal mvarBMI { get; set; }

        public System.String mvarTrangThai { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_KhamBenh()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_KhamBenh(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_KhamBenh(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_KhamBenh(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarKhamBenh_Id = int.MinValue;
            mvarBenhNhan_Id = int.MinValue;
            mvarTiepNhan_Id = int.MinValue;
            mvarDichVu_Id = int.MinValue;
            mvarPhongBan_Id = int.MinValue;
            mvarNgayKham = DateTime.MinValue;
            mvarThoiGianKham = DateTime.MinValue;
            mvarBacSiKham_Id = int.MinValue;
            mvarChanDoanKhoaKham = String.Empty;
            mvarChanDoanICD_Id = int.MinValue;
            mvarChanDoanPhuICD_Id = int.MinValue;
            mvarHuongGiaiQuyet_Id = int.MinValue;
            mvarGhiChu = String.Empty;
            mvarSoNgayHenTaiKham = Int16.MinValue;
            mvarNhapKhoa_Id = int.MinValue;
            mvarChuyenDenBenhVien_Id = int.MinValue;
            mvarCheDoAnUong_Id = int.MinValue;
            mvarCheDoChamSoc_Id = int.MinValue;
            mvarKhamCapCuu = false;
            mvarKhamBenhLanDau_Id = int.MinValue;
            mvarLyDoNhapVien_Id = int.MinValue;
            mvarMach = Int16.MinValue;
            mvarHuyetApThap = Int16.MinValue;
            mvarHuyetApCao = Int16.MinValue;
            mvarNhipTho = Int16.MinValue;
            mvarNhietDo = decimal.MinValue;
            mvarChieuCao = decimal.MinValue;
            mvarCanNang = decimal.MinValue;
            mvarTrieuChungLamSang = String.Empty;
            mvarDichVu_KhamBenh_Id = int.MinValue;
            mvarChanDoanSoBo = String.Empty;
            mvarYeuCauChiTiet_Id = int.MinValue;
            mvarKhamBenh_ChuyenKhoa_Id = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarToaThuocMuaNgoai = String.Empty;
            mvarChanDoanICD = String.Empty;

            mvarGiaiDoanBenh = String.Empty;
            mvarTacDungPhu = String.Empty;
            mvarTuanThuCuaBN = String.Empty;
            mvarHuongDieuTri_Id = int.MinValue;
            mvarSoNgayDieuTri = String.Empty;
            mvarGhiChu2 = String.Empty;
            mvarSoBenhAnNgoaiTru_Id = int.MinValue;
            mvarDieuTriDuPhong = String.Empty;
            mvarBMI = int.MinValue;
            mvarDoiTuong_Id = int.MinValue;
        }
        public void FillData(DataRow row)
        {
            mvarKhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_Id"]);
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarTiepNhan_Id = Common.clsControl.IsNullOrEmpty(row["TiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhan_Id"]);
            mvarDichVu_Id = Common.clsControl.IsNullOrEmpty(row["DichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DichVu_Id"]);
            mvarPhongBan_Id = Common.clsControl.IsNullOrEmpty(row["PhongBan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhongBan_Id"]);
            mvarNgayKham = Common.clsControl.IsNullOrEmpty(row["NgayKham"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayKham"]);
            mvarThoiGianKham = Common.clsControl.IsNullOrEmpty(row["ThoiGianKham"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianKham"]);
            mvarBacSiKham_Id = Common.clsControl.IsNullOrEmpty(row["BacSiKham_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiKham_Id"]);
            mvarChanDoanKhoaKham = Common.clsControl.getValueInRow<string>(row["ChanDoanKhoaKham"]);
            mvarChanDoanICD_Id = Common.clsControl.IsNullOrEmpty(row["ChanDoanICD_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChanDoanICD_Id"]);
            mvarChanDoanPhuICD_Id = Common.clsControl.IsNullOrEmpty(row["ChanDoanPhuICD_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChanDoanPhuICD_Id"]);
            mvarHuongGiaiQuyet_Id = Common.clsControl.IsNullOrEmpty(row["HuongGiaiQuyet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuongGiaiQuyet_Id"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarSoNgayHenTaiKham = Common.clsControl.IsNullOrEmpty(row["SoNgayHenTaiKham"].ToString().ToArray()) ? Int16.MinValue : Common.clsControl.getValueInRow<Int16>(row["SoNgayHenTaiKham"]);
            mvarNhapKhoa_Id = Common.clsControl.IsNullOrEmpty(row["NhapKhoa_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhapKhoa_Id"]);
            mvarChuyenDenBenhVien_Id = Common.clsControl.IsNullOrEmpty(row["ChuyenDenBenhVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenDenBenhVien_Id"]);
            mvarCheDoAnUong_Id = Common.clsControl.IsNullOrEmpty(row["CheDoAnUong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CheDoAnUong_Id"]);
            mvarCheDoChamSoc_Id = Common.clsControl.IsNullOrEmpty(row["CheDoChamSoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CheDoChamSoc_Id"]);
            mvarKhamCapCuu = Common.clsControl.getValueInRow<bool>(row["KhamCapCuu"]);
            mvarKhamBenhLanDau_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenhLanDau_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenhLanDau_Id"]);
            mvarLyDoNhapVien_Id = Common.clsControl.IsNullOrEmpty(row["LyDoNhapVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LyDoNhapVien_Id"]);
            mvarMach = Common.clsControl.IsNullOrEmpty(row["Mach"].ToString().ToArray()) ? Int16.MinValue : Common.clsControl.getValueInRow<Int16>(row["Mach"]);
            mvarHuyetApThap = Common.clsControl.IsNullOrEmpty(row["HuyetApThap"].ToString().ToArray()) ? Int16.MinValue : Common.clsControl.getValueInRow<Int16>(row["HuyetApThap"]);
            mvarHuyetApCao = Common.clsControl.IsNullOrEmpty(row["HuyetApCao"].ToString().ToArray()) ? Int16.MinValue : Common.clsControl.getValueInRow<Int16>(row["HuyetApCao"]);
            mvarNhipTho = Common.clsControl.IsNullOrEmpty(row["NhipTho"].ToString().ToArray()) ? Int16.MinValue : Common.clsControl.getValueInRow<Int16>(row["NhipTho"]);
            mvarNhietDo = Common.clsControl.IsNullOrEmpty(row["NhietDo"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["NhietDo"]);
            mvarChieuCao = Common.clsControl.IsNullOrEmpty(row["ChieuCao"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["ChieuCao"]);
            mvarCanNang = Common.clsControl.IsNullOrEmpty(row["CanNang"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["CanNang"]);
            mvarTrieuChungLamSang = Common.clsControl.getValueInRow<string>(row["TrieuChungLamSang"]);
            mvarDichVu_KhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["DichVu_KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DichVu_KhamBenh_Id"]);
            mvarChanDoanSoBo = Common.clsControl.getValueInRow<string>(row["ChanDoanSoBo"]);
            mvarYeuCauChiTiet_Id = Common.clsControl.IsNullOrEmpty(row["YeuCauChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["YeuCauChiTiet_Id"]);
            mvarKhamBenh_ChuyenKhoa_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_ChuyenKhoa_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_ChuyenKhoa_Id"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarToaThuocMuaNgoai = Common.clsControl.getValueInRow<string>(row["ToaThuocMuaNgoai"]);
            mvarChanDoanICD = Common.clsControl.getValueInRow<string>(row["ChanDoanICD"]);

            mvarGiaiDoanBenh = Common.clsControl.getValueInRow<string>(row["GiaiDoanBenh"]);
            mvarTacDungPhu = Common.clsControl.getValueInRow<string>(row["TacDungPhu"]);
            mvarTuanThuCuaBN = Common.clsControl.getValueInRow<string>(row["TuanThuCuaBN"]);
            mvarHuongDieuTri_Id = Common.clsControl.IsNullOrEmpty(row["HuongDieuTri_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuongDieuTri_Id"]);
            mvarSoNgayDieuTri = Common.clsControl.getValueInRow<string>(row["SoNgayDieuTri"]);
            mvarGhiChu2 = Common.clsControl.getValueInRow<string>(row["GhiChu2"]);
            mvarSoBenhAnNgoaiTru_Id = Common.clsControl.IsNullOrEmpty(row["SoBenhAnNgoaiTru_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoBenhAnNgoaiTru_Id"]);
            mvarDieuTriDuPhong = Common.clsControl.getValueInRow<string>(row["DieuTriDuPhong"]);
            mvarDoiTuong_Id = Common.clsControl.IsNullOrEmpty(row["DoiTuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DoiTuong_Id"]);
            mvarBMI = Common.clsControl.IsNullOrEmpty(row["BMI"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BMI"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
        }

        public string Add()
        {
            string rtKhamBenh_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", mvarDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKham", mvarNgayKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKham", mvarThoiGianKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiKham_Id", mvarBacSiKham_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanKhoaKham", mvarChanDoanKhoaKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanICD_Id", mvarChanDoanICD_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanPhuICD_Id", mvarChanDoanPhuICD_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuongGiaiQuyet_Id", mvarHuongGiaiQuyet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgayHenTaiKham", mvarSoNgayHenTaiKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhapKhoa_Id", mvarNhapKhoa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenDenBenhVien_Id", mvarChuyenDenBenhVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CheDoAnUong_Id", mvarCheDoAnUong_Id );
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CheDoChamSoc_Id", mvarCheDoChamSoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamCapCuu", mvarKhamCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhLanDau_Id", mvarKhamBenhLanDau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoNhapVien_Id", mvarLyDoNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrieuChungLamSang", mvarTrieuChungLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_KhamBenh_Id", mvarDichVu_KhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanSoBo", mvarChanDoanSoBo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@YeuCauChiTiet_Id", mvarYeuCauChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_ChuyenKhoa_Id", mvarKhamBenh_ChuyenKhoa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);      
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuocMuaNgoai", mvarToaThuocMuaNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanICD", mvarChanDoanICD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaiDoanBenh", mvarGiaiDoanBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TacDungPhu", mvarTacDungPhu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuanThuCuaBN", mvarTuanThuCuaBN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuongDieuTri_Id", mvarHuongDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgayDieuTri", mvarSoNgayDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu2", mvarGhiChu2);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoBenhAnNgoaiTru_Id", mvarSoBenhAnNgoaiTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DieuTriDuPhong", mvarDieuTriDuPhong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BMI", mvarBMI);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            rtKhamBenh_Id = ThuVien.mySQL.ExcSP(SP_KhamBenh, listPara, "@KhamBenh_Id", SqlDbType.Int, 32);
            return rtKhamBenh_Id;

            }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", mvarDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKham", mvarNgayKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKham", mvarThoiGianKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiKham_Id", mvarBacSiKham_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanKhoaKham", mvarChanDoanKhoaKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanICD_Id", mvarChanDoanICD_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanPhuICD_Id", mvarChanDoanPhuICD_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuongGiaiQuyet_Id", mvarHuongGiaiQuyet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgayHenTaiKham", mvarSoNgayHenTaiKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhapKhoa_Id", mvarNhapKhoa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenDenBenhVien_Id", mvarChuyenDenBenhVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CheDoAnUong_Id", mvarCheDoAnUong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CheDoChamSoc_Id", mvarCheDoChamSoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamCapCuu", mvarKhamCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhLanDau_Id", mvarKhamBenhLanDau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoNhapVien_Id", mvarLyDoNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrieuChungLamSang", mvarTrieuChungLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_KhamBenh_Id", mvarDichVu_KhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanSoBo", mvarChanDoanSoBo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@YeuCauChiTiet_Id", mvarYeuCauChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_ChuyenKhoa_Id", mvarKhamBenh_ChuyenKhoa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuocMuaNgoai", mvarToaThuocMuaNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanICD", mvarChanDoanICD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaiDoanBenh", mvarGiaiDoanBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TacDungPhu", mvarTacDungPhu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuanThuCuaBN", mvarTuanThuCuaBN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuongDieuTri_Id", mvarHuongDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgayDieuTri", mvarSoNgayDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu2", mvarGhiChu2);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoBenhAnNgoaiTru_Id", mvarSoBenhAnNgoaiTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DieuTriDuPhong", mvarDieuTriDuPhong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BMI", mvarBMI);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.ExcSP(SP_KhamBenh, listPara);
            return mvarKhamBenh_Id.ToString();
        }

        public bool Delete() {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@mvarKhamBenh_Id", mvarKhamBenh_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_KhamBenh, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void GetListKhamBenh(GridControl grv,DateTime dt)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
           
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_ThongTinBenhNhanChoKham");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKham", dt);

            Common.clsControl.LoadGirdControl_Y(grv, "sp_KHAMBENH" , listPara);
        }
        public DataRow getDoiTuong(int BenhNhanId, DateTime dt)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_DoiTuong");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", BenhNhanId);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKham", dt);
            return ThuVien.mySQL.RtDataRowSP("sp_KHAMBENH", listPara);
        }

        public bool Get_By_Key(int khamBenh_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", khamBenh_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_KhamBenh, listPara);
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
        public bool Get_By_BenhNhan_Id(int benhNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetBy_BenhNhan_Id");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", benhNhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_KhamBenh, listPara);
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
        public bool Get_By_TiepNhan_Id(int tiepNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetByTiepNhan_Id");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", tiepNhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_KhamBenh, listPara);
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
        
        public void GetTTBNChoNhanThuocBHYT(GridControl grv, int benhNhan_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetTongTinBenhNhan_BenhNhan_Id");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", benhNhan_Id);
         
            Common.clsControl.LoadGirdControl_Y(grv, SP_KhamBenh, listPara);
        }
    }
}
