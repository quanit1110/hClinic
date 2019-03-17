using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    class cls_TiepNhanCapCuu
    {
        #region "Constants"
        private const string SP_TiepNhanCapCuu = "SP_TiepNhanCapCuu";
        #endregion

        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarTiepNhanCapCuu_Id { get; set; }

        public System.Int32 mvarTiepNhan_Id { get; set; }

        public System.Int32 mvarBenhNhan_Id { get; set; }

        public System.String mvarNoiLamViec { get; set; }

        public System.String mvarDienThoaiNLV { get; set; }

        public System.String mvarNguoiThan { get; set; }

        public System.String mvarDienThoaiNT { get; set; }

        public System.String mvarNoiDuaDen { get; set; }

        public System.String mvarDienThoaiNDD { get; set; }

        public System.DateTime mvarNgayTaiNan { get; set; }

        public System.DateTime mvarThoiGianTaiNan { get; set; }

        public System.DateTime mvarNgayCapCuu { get; set; }

        public System.DateTime mvarThoiGianCapCuu { get; set; }

        public System.DateTime mvarNgayKhamBenh { get; set; }

        public System.DateTime mvarThoiGianKhamBenh { get; set; }

        public System.Int32 mvarNoiBiTaiNan_ID { get; set; }

        public System.Int32 mvarTinhThanh_Id { get; set; }

        public System.Int32 mvarQuanHuyen_Id { get; set; }

        public System.Int32 mvarPhuongXa_Id { get; set; }

        public System.String mvarDiaChi { get; set; }

        public System.Int32 mvarDienBienSauTN_Id { get; set; }

        public System.Int32 mvarNguyenNhan_Id { get; set; }

        public System.Int32 mvarNguyenNhan_ICD { get; set; }

        public System.Int32 mvarNguyenNhanChiTiet_Id { get; set; }

        public System.Int32 mvarThuongTich_Id { get; set; }

        public System.Int32 mvarMucDo_Id { get; set; }

        public System.String mvarChiTietCapCuu { get; set; }

        public System.DateTime mvarNgayRa { get; set; }

        public System.DateTime mvarThoiGianRa { get; set; }

        public System.String mvarHoiChan { get; set; }

        public System.String mvarTinhHinhXuat { get; set; }

        public System.Int32 mvarSoNgayNghi { get; set; }

        public System.Int32 mvarMatSuc { get; set; }

        public System.Int32 mvarKhoaNhap_Id { get; set; }

        public System.Int32 mvarChuyenVien_Id { get; set; }

        public System.String mvarBenhSu { get; set; }

        public System.Int16 mvarMach { get; set; }

        public System.Int16 mvarNhipTho { get; set; }

        public System.Decimal mvarNhietDo { get; set; }

        public System.Decimal mvarCanNang { get; set; }

        public System.String mvarHuyetAp { get; set; }

        public System.Int32 mvarHuyetApCao { get; set; }

        public System.Int32 mvarHuyetApThap { get; set; }

        public System.Decimal mvarChieuCao { get; set; }

        public System.Int32 mvarKetQuaDieuTri_Id { get; set; }

        public System.Int32 mvarNhapKhoa_Id { get; set; }

        public System.String mvarTienSuBenh { get; set; }

        public System.String mvarCanLamSang { get; set; }

        public System.String mvarChanDoanLucVao { get; set; }

        public System.Int32 mvarICD_Vao_Id { get; set; }

        public System.String mvarChanDoanLucRa { get; set; }

        public System.Int32 mvarICD_Ra_Id { get; set; }

        public System.String mvarXuTri { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }

        public System.Boolean mvarTuVong { get; set; }

        public System.DateTime mvarNgayTuVong { get; set; }

        public System.DateTime mvarThoiGianTuVong { get; set; }

        public System.DateTime mvarThoiGianKhamNghiem { get; set; }

        public System.DateTime mvarThoiGianNhanTuThi { get; set; }

        public System.String mvarKetQuaKhamNghiem { get; set; }

        public System.String mvarGhiChu { get; set; }

        public System.Int32 mvarICD_TuVong_Id { get; set; }

        public System.Int32 mvarBacSiGhiNhanTuVong_Id { get; set; }

        public System.Int32 mvarBacSiKhamNghiem_Id { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_TiepNhanCapCuu()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_TiepNhanCapCuu(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_TiepNhanCapCuu(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_TiepNhanCapCuu(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarTiepNhanCapCuu_Id = int.MinValue;
            mvarTiepNhan_Id = int.MinValue;
            mvarBenhNhan_Id = int.MinValue;
            mvarNoiLamViec = String.Empty;
            mvarDienThoaiNLV = String.Empty;
            mvarNguoiThan = String.Empty;
            mvarDienThoaiNT = String.Empty;
            mvarNoiDuaDen = String.Empty;
            mvarDienThoaiNDD = String.Empty;
            mvarNgayTaiNan = DateTime.MinValue;
            mvarThoiGianTaiNan = DateTime.MinValue;
            mvarNgayCapCuu = DateTime.MinValue;
            mvarThoiGianCapCuu = DateTime.MinValue;
            mvarNgayKhamBenh = DateTime.MinValue;
            mvarThoiGianKhamBenh = DateTime.MinValue;
            mvarNoiBiTaiNan_ID = int.MinValue;
            mvarTinhThanh_Id = int.MinValue;
            mvarQuanHuyen_Id = int.MinValue;
            mvarPhuongXa_Id = int.MinValue;
            mvarDiaChi = String.Empty;
            mvarDienBienSauTN_Id = int.MinValue;
            mvarNguyenNhan_Id = int.MinValue;
            mvarNguyenNhan_ICD = int.MinValue;
            mvarNguyenNhanChiTiet_Id = int.MinValue;
            mvarThuongTich_Id = int.MinValue;
            mvarMucDo_Id = int.MinValue;
            mvarChiTietCapCuu = String.Empty;
            mvarNgayRa = DateTime.MinValue;
            mvarThoiGianRa = DateTime.MinValue;
            mvarHoiChan = String.Empty;
            mvarTinhHinhXuat = String.Empty;
            mvarSoNgayNghi = int.MinValue;
            mvarMatSuc = int.MinValue;
            mvarKhoaNhap_Id = int.MinValue;
            mvarChuyenVien_Id = int.MinValue;
            mvarBenhSu = String.Empty;
            mvarMach = Int16.MinValue;
            mvarNhipTho = Int16.MinValue;
            mvarNhietDo = decimal.MinValue;
            mvarCanNang = decimal.MinValue;
            mvarHuyetAp = String.Empty;
            mvarHuyetApCao = int.MinValue;
            mvarHuyetApThap = int.MinValue;
            mvarChieuCao = decimal.MinValue;
            mvarKetQuaDieuTri_Id = int.MinValue;
            mvarNhapKhoa_Id = int.MinValue;
            mvarTienSuBenh = String.Empty;
            mvarCanLamSang = String.Empty;
            mvarChanDoanLucVao = String.Empty;
            mvarICD_Vao_Id = int.MinValue;
            mvarChanDoanLucRa = String.Empty;
            mvarICD_Ra_Id = int.MinValue;
            mvarXuTri = String.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarTuVong = false;
            mvarNgayTuVong = DateTime.MinValue;
            mvarThoiGianTuVong = DateTime.MinValue;
            mvarThoiGianKhamNghiem = DateTime.MinValue;
            mvarThoiGianNhanTuThi = DateTime.MinValue;
            mvarKetQuaKhamNghiem = String.Empty;
            mvarGhiChu = String.Empty;
            mvarICD_TuVong_Id = int.MinValue;
            mvarBacSiGhiNhanTuVong_Id = int.MinValue;
            mvarBacSiKhamNghiem_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarTiepNhanCapCuu_Id = Common.clsControl.IsNullOrEmpty(row["TiepNhanCapCuu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhanCapCuu_Id"]);
            mvarTiepNhan_Id = Common.clsControl.IsNullOrEmpty(row["TiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhan_Id"]);
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarNoiLamViec = Common.clsControl.getValueInRow<string>(row["NoiLamViec"]);
            mvarDienThoaiNLV = Common.clsControl.getValueInRow<string>(row["DienThoaiNLV"]);
            mvarNguoiThan = Common.clsControl.getValueInRow<string>(row["NguoiThan"]);
            mvarDienThoaiNT = Common.clsControl.getValueInRow<string>(row["DienThoaiNT"]);
            mvarNoiDuaDen = Common.clsControl.getValueInRow<string>(row["NoiDuaDen"]);
            mvarDienThoaiNDD = Common.clsControl.getValueInRow<string>(row["DienThoaiNDD"]);
            mvarNgayTaiNan = Common.clsControl.IsNullOrEmpty(row["NgayTaiNan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTaiNan"]);
            mvarThoiGianTaiNan = Common.clsControl.IsNullOrEmpty(row["ThoiGianTaiNan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianTaiNan"]);
            mvarNgayCapCuu = Common.clsControl.IsNullOrEmpty(row["NgayCapCuu"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapCuu"]);
            mvarThoiGianCapCuu = Common.clsControl.IsNullOrEmpty(row["ThoiGianCapCuu"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianCapCuu"]);
            mvarNgayKhamBenh = Common.clsControl.IsNullOrEmpty(row["NgayKhamBenh"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayKhamBenh"]);
            mvarThoiGianKhamBenh = Common.clsControl.IsNullOrEmpty(row["ThoiGianKhamBenh"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianKhamBenh"]);
            mvarNoiBiTaiNan_ID = Common.clsControl.IsNullOrEmpty(row["NoiBiTaiNan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiBiTaiNan_Id"]);
            mvarTinhThanh_Id = Common.clsControl.IsNullOrEmpty(row["TinhThanh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TinhThanh_Id"]);
            mvarQuanHuyen_Id = Common.clsControl.IsNullOrEmpty(row["QuanHuyen_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["QuanHuyen_Id"]);
            mvarPhuongXa_Id = Common.clsControl.IsNullOrEmpty(row["PhuongXa_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhuongXa_Id"]);
            mvarDiaChi = Common.clsControl.getValueInRow<string>(row["DiaChi"]);
            mvarDienBienSauTN_Id = Common.clsControl.IsNullOrEmpty(row["DienBienSauTN_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DienBienSauTN_Id"]);
            mvarNguyenNhan_Id = Common.clsControl.IsNullOrEmpty(row["NguyenNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguyenNhan_Id"]);
            mvarNguyenNhan_ICD = Common.clsControl.IsNullOrEmpty(row["NguyenNhan_ICD"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguyenNhan_ICD"]);
            mvarNguyenNhanChiTiet_Id = Common.clsControl.IsNullOrEmpty(row["NguyenNhanChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguyenNhanChiTiet_Id"]);
            mvarThuongTich_Id = Common.clsControl.IsNullOrEmpty(row["ThuongTich_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ThuongTich_Id"]);
            mvarMucDo_Id = Common.clsControl.IsNullOrEmpty(row["MucDo_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["MucDo_Id"]);
            mvarChiTietCapCuu = Common.clsControl.getValueInRow<string>(row["ChiTietCapCuu"]);
            mvarNgayRa = Common.clsControl.IsNullOrEmpty(row["NgayRa"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayRa"]);
            mvarThoiGianRa = Common.clsControl.IsNullOrEmpty(row["ThoiGianRa"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianRa"]);
            mvarHoiChan = Common.clsControl.getValueInRow<string>(row["HoiChan"]);
            mvarTinhHinhXuat = Common.clsControl.getValueInRow<string>(row["TinhHinhXuat"]);
            mvarSoNgayNghi = Common.clsControl.IsNullOrEmpty(row["SoNgayNghi"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoNgayNghi"]);
            mvarMatSuc = Common.clsControl.IsNullOrEmpty(row["MatSuc"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["MatSuc"]);
            mvarKhoaNhap_Id = Common.clsControl.IsNullOrEmpty(row["KhoaNhap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoaNhap_Id"]);
            mvarChuyenVien_Id = Common.clsControl.IsNullOrEmpty(row["ChuyenVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenVien_Id"]);
            mvarBenhSu = Common.clsControl.getValueInRow<string>(row["BenhSu"]);
            mvarMach = Common.clsControl.IsNullOrEmpty(row["Mach"].ToString().ToArray()) ? Int16.MinValue : Common.clsControl.getValueInRow<Int16>(row["Mach"]);
            mvarNhipTho = Common.clsControl.IsNullOrEmpty(row["NhipTho"].ToString().ToArray()) ? Int16.MinValue : Common.clsControl.getValueInRow<Int16>(row["NhipTho"]);
            mvarNhietDo = Common.clsControl.IsNullOrEmpty(row["NhietDo"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["NhietDo"]);
            mvarCanNang = Common.clsControl.IsNullOrEmpty(row["CanNang"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["CanNang"]);
            mvarHuyetAp = Common.clsControl.getValueInRow<string>(row["HuyetAp"]);
            mvarHuyetApCao = Common.clsControl.IsNullOrEmpty(row["HuyetApCao"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuyetApCao"]);
            mvarHuyetApThap = Common.clsControl.IsNullOrEmpty(row["HuyetApThap"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuyetApThap"]);
            mvarChieuCao = Common.clsControl.IsNullOrEmpty(row["ChieuCao"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["ChieuCao"]);
            mvarKetQuaDieuTri_Id = Common.clsControl.IsNullOrEmpty(row["KetQuaDieuTri_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KetQuaDieuTri_Id"]);
            mvarNhapKhoa_Id = Common.clsControl.IsNullOrEmpty(row["NhapKhoa_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhapKhoa_Id"]);
            mvarTienSuBenh = Common.clsControl.getValueInRow<string>(row["TienSuBenh"]);
            mvarCanLamSang = Common.clsControl.getValueInRow<string>(row["CanLamSang"]);
            mvarChanDoanLucVao = Common.clsControl.getValueInRow<string>(row["ChanDoanLucVao"]);
            mvarICD_Vao_Id = Common.clsControl.IsNullOrEmpty(row["ICD_Vao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_Vao_Id"]);
            mvarChanDoanLucRa = Common.clsControl.getValueInRow<string>(row["ChanDoanLucRa"]);
            mvarICD_Ra_Id = Common.clsControl.IsNullOrEmpty(row["ICD_Ra_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_Ra_Id"]);
            mvarXuTri = Common.clsControl.getValueInRow<string>(row["XuTri"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarTuVong = Common.clsControl.getValueInRow<bool>(row["TuVong"]);
            mvarNgayTuVong = Common.clsControl.IsNullOrEmpty(row["NgayTuVong"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTuVong"]);
            mvarThoiGianTuVong = Common.clsControl.IsNullOrEmpty(row["ThoiGianTuVong"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianTuVong"]);
            mvarThoiGianKhamNghiem = Common.clsControl.IsNullOrEmpty(row["ThoiGianKhamNghiem"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianKhamNghiem"]);
            mvarThoiGianNhanTuThi = Common.clsControl.IsNullOrEmpty(row["ThoiGianNhanTuThi"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianNhanTuThi"]);
            mvarKetQuaKhamNghiem = Common.clsControl.getValueInRow<string>(row["KetQuaKhamNghiem"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarICD_TuVong_Id = Common.clsControl.IsNullOrEmpty(row["ICD_TuVong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_TuVong_Id"]);
            mvarBacSiGhiNhanTuVong_Id = Common.clsControl.IsNullOrEmpty(row["BacSiGhiNhanTuVong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiGhiNhanTuVong_Id"]);
            mvarBacSiKhamNghiem_Id = Common.clsControl.IsNullOrEmpty(row["BacSiKhamNghiem_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiKhamNghiem_Id"]);
        }

        public string Add()
        {
            string rtTiepNhanCapCuu_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiLamViec", mvarNoiLamViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoaiNLV", mvarDienThoaiNLV);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiThan", mvarNguoiThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoaiNT", mvarDienThoaiNT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiDuaDen", mvarNoiDuaDen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoaiNDD", mvarDienThoaiNDD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTaiNan", mvarNgayTaiNan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTaiNan", mvarThoiGianTaiNan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapCuu", mvarNgayCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianCapcuu", mvarThoiGianCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKhamBenh", mvarNgayKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKhamBenh", mvarThoiGianKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiBiTaiNan_ID", mvarNoiBiTaiNan_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh_Id", mvarTinhThanh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuanHuyen_Id", mvarQuanHuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhuongXa_Id", mvarPhuongXa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienBienSauTN_Id", mvarDienBienSauTN_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhan_Id", mvarNguyenNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhan_ICD", mvarNguyenNhan_ICD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhanChitiet_Id", mvarNguyenNhanChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuongTich_Id", mvarThuongTich_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MucDo_Id", mvarMucDo_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChiTietCapCuu", mvarChiTietCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRa", mvarNgayRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRa", mvarThoiGianRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Hoichan", mvarHoiChan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhHinhXuat", mvarTinhHinhXuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgayNghi", mvarSoNgayNghi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MatSuc", mvarMatSuc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaNhap_Id", mvarKhoaNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenVien_Id", mvarChuyenVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhSu", mvarBenhSu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetAp", mvarHuyetAp);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaDieuTri_Id", mvarKetQuaDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhapKhoa_Id", mvarNhapKhoa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBenh", mvarTienSuBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanLamSang", mvarCanLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanLucVao", mvarChanDoanLucVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_Vao_Id", mvarICD_Vao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanLucRa", mvarChanDoanLucRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_Ra_Id", mvarICD_Ra_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XuTri", mvarXuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuVong", mvarTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTuVong", mvarNgayTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTuVong", mvarThoiGianTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKhamNghiem", mvarThoiGianKhamNghiem);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianNHanTuThi", mvarThoiGianNhanTuThi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaKhamNghiem", mvarKetQuaKhamNghiem);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_TuVong_Id", mvarICD_TuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiGhiNhanTuVong_Id", mvarBacSiGhiNhanTuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiKhamNghiem_Id", mvarBacSiKhamNghiem_Id);

            rtTiepNhanCapCuu_Id = ThuVien.mySQL.ExcSP(SP_TiepNhanCapCuu, listPara, "@TiepNhanCapCuu_Id", SqlDbType.Int, 32);
            return rtTiepNhanCapCuu_Id;
        }
        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhanCapCuu_Id", mvarTiepNhanCapCuu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiLamViec", mvarNoiLamViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoaiNLV", mvarDienThoaiNLV);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiThan", mvarNguoiThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoaiNT", mvarDienThoaiNT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiDuaDen", mvarNoiDuaDen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoaiNDD", mvarDienThoaiNDD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTaiNan", mvarNgayTaiNan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTaiNan", mvarThoiGianTaiNan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapCuu", mvarNgayCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianCapcuu", mvarThoiGianCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKhamBenh", mvarNgayKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKhamBenh", mvarThoiGianKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiBiTaiNan_ID", mvarNoiBiTaiNan_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh_Id", mvarTinhThanh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuanHuyen_Id", mvarQuanHuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhuongXa_Id", mvarPhuongXa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienBienSauTN_Id", mvarDienBienSauTN_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhan_Id", mvarNguyenNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhan_ICD", mvarNguyenNhan_ICD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhanChitiet_Id", mvarNguyenNhanChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuongTich_Id", mvarThuongTich_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MucDo_Id", mvarMucDo_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChiTietCapCuu", mvarChiTietCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRa", mvarNgayRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRa", mvarThoiGianRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Hoichan", mvarHoiChan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhHinhXuat", mvarTinhHinhXuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgayNghi", mvarSoNgayNghi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MatSuc", mvarMatSuc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaNhap_Id", mvarKhoaNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenVien_Id", mvarChuyenVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhSu", mvarBenhSu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetAp", mvarHuyetAp);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaDieuTri_Id", mvarKetQuaDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhapKhoa_Id", mvarNhapKhoa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBenh", mvarTienSuBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanLamSang", mvarCanLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanLucVao", mvarChanDoanLucVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_Vao_Id", mvarICD_Vao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanLucRa", mvarChanDoanLucRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_Ra_Id", mvarICD_Ra_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XuTri", mvarXuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuVong", mvarTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTuVong", mvarNgayTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTuVong", mvarThoiGianTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKhamNghiem", mvarThoiGianKhamNghiem);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianNHanTuThi", mvarThoiGianNhanTuThi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaKhamNghiem", mvarKetQuaKhamNghiem);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_TuVong_Id", mvarICD_TuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiGhiNhanTuVong_Id", mvarBacSiGhiNhanTuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiKhamNghiem_Id", mvarBacSiKhamNghiem_Id);
            ThuVien.mySQL.ExcSP(SP_TiepNhanCapCuu, listPara);
            return mvarTiepNhanCapCuu_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhanCapCuu_Id", mvarTiepNhanCapCuu_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_TiepNhanCapCuu, listPara);
            if (rt == "err") { return false; }
            return true;
        }


    }
}
