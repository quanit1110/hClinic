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
    public class cls_TiepNhan
    {
        # region "Constants"
       private const string SP_TiepNhan = "SP_TiepNhan";
        private const string SP_GetSoTiepNhan = "GetSoTangDan";
        #endregion
        #region "Member Variables"
        public System.String mvarLanguageId { get; set;}

        public System.Int32 mvarUserID { get; set;}

        public System.String mvarFreePara { get; set;}

        public System.Int32 mvarTiepNhan_Id { get; set;}

        public System.String mvarSoTiepNhan { get; set;}

        public System.String mvarSoThuTu { get; set;}

        public System.Boolean mvarUuTien { get; set;}

        public System.Int32 mvarBenhNhan_Id { get; set;}

        public System.Int32 mvarNoiTiepNhan_Id { get; set;}

        public System.DateTime mvarNgayTiepNhan { get; set;}

        public System.DateTime mvarThoiGianTiepNhan { get; set;}

        public System.Int16 mvarNamTiepNhan { get; set;}

        public System.Byte mvarThangTiepNhan { get; set;}

        public System.Int32 mvarDoiTuong_Id { get; set;}

        public System.String mvarNoiLamViec { get; set;}

        public System.Int32 mvarNguoiLienHe_Id { get; set;}

        public System.String mvarNguoiLienHe { get; set;}

        public System.String mvarDiaChiLienHe { get; set;}

        public System.Int32 mvarHinhThucDenKham_Id { get; set;}

        public System.Int32 mvarNoiGioiThieu_Id { get; set;}

        public System.Int32 mvarLyDoTiepNhan_Id { get; set;}

        public System.String mvarSoBHYT { get; set;}

        public System.DateTime mvarBHYTTuNgay { get; set;}

        public System.DateTime mvarBHYTDenNgay { get; set;}

        public System.Boolean mvarThuTienTruoc { get; set;}

        public System.String mvarTrangThai { get; set;}

        public System.DateTime mvarNgayTao { get; set;}

        public System.Int32 mvarNguoiTao_Id { get; set;}

        public System.DateTime mvarNgayCapNhat { get; set;}

        public System.Int32 mvarNguoiCapNhat_Id { get; set;}

        public System.String mvarChanDoanNGT { get; set;}

        public System.Boolean mvarTaiKham { get; set;}

        public System.Int32 mvarDonViCongTac_Id { get; set;}

        public System.Int32 mvarPhieuDieuTri_Id { get; set;}

        public System.Int32 mvarTuyenKhamBenh_Id { get; set;}

        public System.Int32 mvarTinhThanh_Id { get; set;}

        public System.Int32 mvarQuanHuyen_Id { get; set;}

        public System.Int32 mvarXaPhuong_Id { get; set;}

        public System.Int32 mvarLoaiBHYT { get; set;}

        public System.Int32 mvarDoiTuong_ChiTiet_Id { get; set;}

        public System.Int32 mvarBenhVien_KCB_Id { get; set;}

        public System.DateTime mvarNgayBHYT1 { get; set;}

        public System.DateTime mvarNgayBHYT2 { get; set;}

        public System.DateTime mvarNgayBHYT3 { get; set;}

        //thêm từ dtb dn
        public System.Int32 mvarCongTyBHTN_ID { get; set; }
        public System.String mvarSoTheBHTN { get; set; }
        public System.DateTime mvarBHTN_TuNgay { get; set; }
        public System.DateTime mvarBHTN_DenNgay { get; set; }
        public System.String mvarBHTN_DiaChi { get; set; }
        public System.String mvarBHTN_DienThoai { get; set; }
        public System.String mvarBHTN_Fax { get; set; }
        public System.Int32 mvarThe_Id { get; set; }
        public System.Int32 mvarLoaiKhachHang_Id { get; set; }
        #endregion
        private DataSet m_Dal;
        #region Contructor
        public cls_TiepNhan()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_TiepNhan(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_TiepNhan(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_TiepNhan(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = dal;
        }
        #endregion
        public string Add()
        {
            string rtTiepNhan_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTiepNhan", mvarSoTiepNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTu", mvarSoThuTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UuTien", mvarUuTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTiepNhan_Id", mvarNoiTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTiepNhan", mvarNgayTiepNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTiepNhan", mvarThoiGianTiepNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamTiepNhan", mvarNamTiepNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThangTiepNhan", mvarThangTiepNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiLamViec", mvarNoiLamViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLienHe_Id", mvarNguoiLienHe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLienHe", mvarNguoiLienHe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiLienHe", mvarDiaChiLienHe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhThucDenKham_Id", mvarHinhThucDenKham_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiGioiThieu_Id", mvarNoiGioiThieu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoTiepNhan_Id", mvarLyDoTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoBHYT", mvarSoBHYT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHYTTuNgay", mvarBHYTTuNgay);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHYTDenNgay", mvarBHYTDenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuTienTruoc", mvarThuTienTruoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanNGT", mvarChanDoanNGT);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiKham", mvarTaiKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViCongTac_Id", mvarDonViCongTac_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhieuDieuTri_Id", mvarPhieuDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuyenKhamBenh_Id", mvarTuyenKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh_Id", mvarTinhThanh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuanHuyen_Id", mvarQuanHuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XaPhuong_Id", mvarXaPhuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiBHYT", mvarLoaiBHYT);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_ChiTiet_Id", mvarDoiTuong_ChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhVien_KCB_Id", mvarBenhVien_KCB_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayBHYT1", mvarNgayBHYT1);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayBHYT2", mvarNgayBHYT2);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayBHYT3", mvarNgayBHYT3);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CongTyBHTN_ID", mvarCongTyBHTN_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTheBHTN", mvarSoTheBHTN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHTN_TuNgay", mvarBHTN_TuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHTN_DenNgay", mvarBHTN_DenNgay);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHTN_DiaChi", mvarBHTN_DiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHTN_DienThoai", mvarBHTN_DienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHTN_Fax", mvarBHTN_Fax);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@The_Id", mvarThe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiKhachHang_Id", mvarLoaiKhachHang_Id);
            rtTiepNhan_Id = ThuVien.mySQL.ExcSP(SP_TiepNhan, listPara, "@TiepNhan_Id", SqlDbType.Int, 32);
            return rtTiepNhan_Id;
        }
        public string Update()
        {
            string rtTiepNhan_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTiepNhan", mvarSoTiepNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTu", mvarSoThuTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UuTien", mvarUuTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTiepNhan_Id", mvarNoiTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTiepNhan", mvarNgayTiepNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTiepNhan", mvarThoiGianTiepNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamTiepNhan", mvarNamTiepNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThangTiepNhan", mvarThangTiepNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiLamViec", mvarNoiLamViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLienHe_Id", mvarNguoiLienHe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLienHe", mvarNguoiLienHe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiLienHe", mvarDiaChiLienHe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhThucDenKham_Id", mvarHinhThucDenKham_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiGioiThieu_Id", mvarNoiGioiThieu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoTiepNhan_Id", mvarLyDoTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoBHYT", mvarSoBHYT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHYTTuNgay", mvarBHYTTuNgay);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHYTDenNgay", mvarBHYTDenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuTienTruoc", mvarThuTienTruoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanNGT", mvarChanDoanNGT);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiKham", mvarTaiKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViCongTac_Id", mvarDonViCongTac_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhieuDieuTri_Id", mvarPhieuDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuyenKhamBenh_Id", mvarTuyenKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh_Id", mvarTinhThanh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuanHuyen_Id", mvarQuanHuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XaPhuong_Id", mvarXaPhuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiBHYT", mvarLoaiBHYT);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_ChiTiet_Id", mvarDoiTuong_ChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhVien_KCB_Id", mvarBenhVien_KCB_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayBHYT1", mvarNgayBHYT1);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayBHYT2", mvarNgayBHYT2);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayBHYT3", mvarNgayBHYT3);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CongTyBHTN_ID", mvarCongTyBHTN_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTheBHTN", mvarSoTheBHTN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHTN_TuNgay", mvarBHTN_TuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHTN_DenNgay", mvarBHTN_DenNgay);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHTN_DiaChi", mvarBHTN_DiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHTN_DienThoai", mvarBHTN_DienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHTN_Fax", mvarBHTN_Fax);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@The_Id", mvarThe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiKhachHang_Id", mvarLoaiKhachHang_Id);

            rtTiepNhan_Id = ThuVien.mySQL.ExcSP(SP_TiepNhan, listPara, "@TiepNhan_Id", SqlDbType.Int, 32);
            return rtTiepNhan_Id;
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_TiepNhan, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        private void Reset()
        {
            mvarTiepNhan_Id = int.MinValue;

            mvarSoTiepNhan = String.Empty;

            mvarSoThuTu = String.Empty;

            mvarUuTien = false;

            mvarBenhNhan_Id = int.MinValue;

            mvarNoiTiepNhan_Id = int.MinValue;

            mvarNgayTiepNhan = DateTime.MinValue;

            mvarThoiGianTiepNhan = DateTime.MinValue;

            mvarNamTiepNhan = short.MinValue;

            mvarThangTiepNhan = byte.MinValue;

            mvarDoiTuong_Id = int.MinValue;

            mvarNoiLamViec = String.Empty;

            mvarNguoiLienHe_Id = int.MinValue;

            mvarNguoiLienHe = String.Empty;

            mvarDiaChiLienHe = String.Empty;

            mvarHinhThucDenKham_Id = int.MinValue;

            mvarNoiGioiThieu_Id = int.MinValue;

            mvarLyDoTiepNhan_Id = int.MinValue;

            mvarSoBHYT = String.Empty;

            mvarBHYTTuNgay = DateTime.MinValue;

            mvarBHYTDenNgay = DateTime.MinValue;

            mvarThuTienTruoc = false;

            mvarTrangThai = String.Empty;

            mvarNgayTao = DateTime.MinValue;

            mvarNguoiTao_Id = int.MinValue;

            mvarNgayCapNhat = DateTime.MinValue;

            mvarNguoiCapNhat_Id = int.MinValue;

            mvarChanDoanNGT = String.Empty;

            mvarTaiKham = false;

            mvarDonViCongTac_Id = int.MinValue;

            mvarPhieuDieuTri_Id = int.MinValue;

            mvarTuyenKhamBenh_Id = int.MinValue;

            mvarTinhThanh_Id = int.MinValue;

            mvarQuanHuyen_Id = int.MinValue;

            mvarXaPhuong_Id = int.MinValue;

            mvarLoaiBHYT = int.MinValue;

            mvarDoiTuong_ChiTiet_Id = int.MinValue;

            mvarBenhVien_KCB_Id = int.MinValue;

            mvarNgayBHYT1 = DateTime.MinValue;

            mvarNgayBHYT2 = DateTime.MinValue;

            mvarNgayBHYT3 = DateTime.MinValue;

            mvarCongTyBHTN_ID = int.MinValue;

            mvarSoTheBHTN = String.Empty;

            mvarBHTN_TuNgay = DateTime.MinValue;

            mvarBHTN_DenNgay = DateTime.MinValue;

            mvarBHTN_DiaChi = String.Empty;

            mvarBHTN_DienThoai = String.Empty;

            mvarBHTN_Fax = String.Empty;

            mvarThe_Id = int.MinValue;

            mvarLoaiKhachHang_Id = int.MinValue;
        }
        public void FillData(DataRow dataRow)
        {
            mvarTiepNhan_Id = Common.clsControl.IsNullOrEmpty(dataRow["TiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["TiepNhan_Id"]);
            mvarSoTiepNhan = Common.clsControl.getValueInRow<string>(dataRow["SoTiepNhan"].ToString());
            mvarSoThuTu = Common.clsControl.getValueInRow<string>(dataRow["SoThuTu"].ToString());
            mvarUuTien = Common.clsControl.IsNullOrEmpty(dataRow["UuTien"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(dataRow["UuTien"]);
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(dataRow["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["BenhNhan_Id"]);
            mvarNoiTiepNhan_Id = Common.clsControl.IsNullOrEmpty(dataRow["NoiTiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["NoiTiepNhan_Id"]);
            mvarNgayTiepNhan = Common.clsControl.IsNullOrEmpty(dataRow["NgayTiepNhan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["NgayTiepNhan"]);
            mvarThoiGianTiepNhan = Common.clsControl.IsNullOrEmpty(dataRow["ThoiGianTiepNhan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["ThoiGianTiepNhan"]);
            mvarNamTiepNhan = Common.clsControl.IsNullOrEmpty(dataRow["NamTiepNhan"].ToString().ToArray()) ? short.MinValue : Common.clsControl.getValueInRow<short>(dataRow["NamTiepNhan"]);
            mvarThangTiepNhan = Common.clsControl.IsNullOrEmpty(dataRow["ThangTiepNhan"].ToString().ToArray()) ? byte.MinValue : Common.clsControl.getValueInRow<byte>(dataRow["ThangTiepNhan"]);
            mvarDoiTuong_Id = Common.clsControl.IsNullOrEmpty(dataRow["DoiTuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["DoiTuong_Id"]);
            mvarNoiLamViec = Common.clsControl.getValueInRow<string>(dataRow["NoiLamViec"].ToString());
            mvarNguoiLienHe_Id = Common.clsControl.IsNullOrEmpty(dataRow["NguoiLienHe_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["NguoiLienHe_Id"]);
            mvarNguoiLienHe = Common.clsControl.getValueInRow<string>(dataRow["NguoiLienHe"].ToString());
            mvarDiaChiLienHe = Common.clsControl.getValueInRow<string>(dataRow["DiaChiLienHe"].ToString());
            mvarHinhThucDenKham_Id = Common.clsControl.IsNullOrEmpty(dataRow["HinhThucDenKham_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["HinhThucDenKham_Id"]);
            mvarNoiGioiThieu_Id = Common.clsControl.IsNullOrEmpty(dataRow["NoiGioiThieu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["NoiGioiThieu_Id"]);
            mvarLyDoTiepNhan_Id = Common.clsControl.IsNullOrEmpty(dataRow["LyDoTiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["LyDoTiepNhan_Id"]);
            mvarSoBHYT = Common.clsControl.getValueInRow<string>(dataRow["SoBHYT"].ToString());
            mvarBHYTTuNgay = Common.clsControl.IsNullOrEmpty(dataRow["BHYTTuNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["BHYTTuNgay"]);
            mvarBHYTDenNgay = Common.clsControl.IsNullOrEmpty(dataRow["BHYTDenNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["BHYTDenNgay"]);
            mvarThuTienTruoc = Common.clsControl.getValueInRow<bool>(dataRow["ThuTienTruoc"].ToString());
            mvarTrangThai = Common.clsControl.getValueInRow<string>(dataRow["TrangThai"].ToString());
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(dataRow["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(dataRow["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(dataRow["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(dataRow["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["NguoiCapNhat_Id"]);
            mvarChanDoanNGT = Common.clsControl.getValueInRow<string>(dataRow["ChanDoanNGT"].ToString());
            mvarTaiKham = Common.clsControl.getValueInRow<bool>(dataRow["TaiKham"].ToString());
            mvarDonViCongTac_Id = Common.clsControl.IsNullOrEmpty(dataRow["DonViCongTac_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["DonViCongTac_Id"]);
            mvarPhieuDieuTri_Id = Common.clsControl.IsNullOrEmpty(dataRow["PhieuDieuTri_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["PhieuDieuTri_Id"]);
            mvarTuyenKhamBenh_Id = Common.clsControl.IsNullOrEmpty(dataRow["TuyenKhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["TuyenKhamBenh_Id"]);
            mvarTinhThanh_Id = Common.clsControl.IsNullOrEmpty(dataRow["TinhThanh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["TinhThanh_Id"]);
            mvarQuanHuyen_Id = Common.clsControl.IsNullOrEmpty(dataRow["QuanHuyen_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["QuanHuyen_Id"]);
            mvarXaPhuong_Id = Common.clsControl.IsNullOrEmpty(dataRow["XaPhuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["XaPhuong_Id"]);
            mvarLoaiBHYT = Common.clsControl.IsNullOrEmpty(dataRow["LoaiBHYT"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["LoaiBHYT"]);
            mvarDoiTuong_ChiTiet_Id = Common.clsControl.IsNullOrEmpty(dataRow["DoiTuong_ChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["DoiTuong_ChiTiet_Id"]);
            mvarBenhVien_KCB_Id = Common.clsControl.IsNullOrEmpty(dataRow["BenhVien_KCB_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["BenhVien_KCB_Id"]);
            mvarNgayBHYT1 = Common.clsControl.IsNullOrEmpty(dataRow["NgayBHYT1"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["NgayBHYT1"]);
            mvarNgayBHYT2 = Common.clsControl.IsNullOrEmpty(dataRow["NgayBHYT2"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["NgayBHYT2"]);
            mvarNgayBHYT3 = Common.clsControl.IsNullOrEmpty(dataRow["NgayBHYT3"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["NgayBHYT3"]);

            mvarCongTyBHTN_ID = Common.clsControl.IsNullOrEmpty(dataRow["CongTyBHTN_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["CongTyBHTN_ID"]);
            mvarSoTheBHTN = Common.clsControl.getValueInRow<string>(dataRow["SoTheBHTN"].ToString());
            mvarBHTN_TuNgay = Common.clsControl.IsNullOrEmpty(dataRow["BHTN_TuNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["BHTN_TuNgay"]);
            mvarBHTN_DenNgay = Common.clsControl.IsNullOrEmpty(dataRow["BHTN_DenNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(dataRow["BHTN_DenNgay"]);
            mvarBHTN_DiaChi = Common.clsControl.getValueInRow<string>(dataRow["BHTN_DiaChi"].ToString());
            mvarBHTN_DienThoai = Common.clsControl.getValueInRow<string>(dataRow["BHTN_DienThoai"].ToString());
            mvarBHTN_Fax = Common.clsControl.getValueInRow<string>(dataRow["BHTN_Fax"].ToString());
            mvarThe_Id = Common.clsControl.IsNullOrEmpty(dataRow["The_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["The_Id"]);
            mvarLoaiKhachHang_Id = Common.clsControl.IsNullOrEmpty(dataRow["LoaiKhachHang_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dataRow["LoaiKhachHang_Id"]);

        }
        public string getSoTiepNhan()
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;
            string sotiepnhan = "";
            DataSet dt = new DataSet();

            try
            {
                using (cmd = new SqlCommand(SP_GetSoTiepNhan, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableName", "TiepNhan");
                cmd.Parameters.AddWithValue("@String_Id", DateTime.Now.ToString("yy.MM"));
                var rs = cmd.Parameters.Add("@Values_Id", SqlDbType.Int);
                rs.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                sotiepnhan = Int32.Parse(rs.Value.ToString()).ToString(("D6"));
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
            mvarSoTiepNhan= DateTime.Now.ToString("yy.MM") + sotiepnhan;
            return mvarSoTiepNhan;
        }
        public bool Get_By_SoTiepNhan(String soTiepNhan)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_BySoTiepNhan");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTiepNhan", soTiepNhan);
                ds = ThuVien.mySQL.ExcDataSet(SP_TiepNhan, listPara);
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
        public bool Get_By_Key(int tiepNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", tiepNhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_TiepNhan, listPara);
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
        public DataRow getDoiTuong(int doiTuong_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetDoiTuong_ByKey");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", doiTuong_Id);
            return ThuVien.mySQL.RtDataRowSP(SP_TiepNhan, listPara);
        }
        public bool CheckTiepNhanTrongNgay(int benhNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Check_HasTiepNhanTrongNgay");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", benhNhan_Id);
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTiepNhan", DateTime.Now);
                ds = ThuVien.mySQL.ExcDataSet(SP_TiepNhan, listPara);
                Reset();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                
            }
            catch {}
            return false;
        }
        public bool Check_ChuaRaVien_ByBenhNhanId(int benhNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Check_ChuaRaVien_ByBenhNhanId");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", benhNhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_TiepNhan, listPara);
                Reset();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }

            }
            catch {}
            return false;
        }
        public bool Check_ChuaRaKhoaCapCuu(int benhNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Check_ChuaRaKhoaCapCuu");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", benhNhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_TiepNhan, listPara);
                Reset();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }

            }
            catch{}
            return false;
        }
    }
}
