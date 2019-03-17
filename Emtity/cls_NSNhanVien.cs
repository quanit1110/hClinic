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
    public class cls_NSNhanVien
    {
        #region "Constants"
        private const string sp_NS_NHANVIEN = "sp_NS_NHANVIEN";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.String mvarMaNhanVien { get; set; }
        public System.String mvarHo { get; set; }
        public System.String mvarTen { get; set; }
        public System.String mvarHinhAnh { get; set; }
        public System.DateTime mvarNgaySinh { get; set; }
        public System.String mvarNoiSinh { get; set; }
        public System.String mvarGioiTinh { get; set; }
        public System.String mvarMaDanToc { get; set; }
        public System.String mvarMaQuocTich { get; set; }
        public System.String mvarMaTonGiao { get; set; }
        public System.String mvarQuequan { get; set; }
        public System.String mvarDiaChihokhau { get; set; }
        public System.String mvarDiaChiLienhe { get; set; }
        public System.String mvarPassport { get; set; }
        public System.String mvarSoTaikhoan { get; set; }
        public System.String mvarNganhang { get; set; }
        public System.String mvarSoBHXH { get; set; }
        public System.DateTime mvarBHXHTuNgay { get; set; }
        public System.DateTime mvarBHXHDenNgay { get; set; }
        public System.String mvarSoBHYT { get; set; }
        public System.DateTime mvarBHYTTuNgay { get; set; }
        public System.DateTime mvarBHYTDenNgay { get; set; }
        public System.String mvarMaUngvien { get; set; }
        public System.String mvarMaTrinhDo { get; set; }
        public System.String mvarChuyenMon { get; set; }
        public System.DateTime mvarNgayThuViec { get; set; }
        public System.DateTime mvarNgayHetThuViec { get; set; }
        public System.DateTime mvarNgayThamGiaCM { get; set; }
        public System.DateTime mvarNgayVaoDoan { get; set; }
        public System.DateTime mvarNgayVaoDang { get; set; }
        public System.String mvarMaChucVu { get; set; }
        public System.String mvarMaChucDanh { get; set; }
        public System.String mvarSucKhoe { get; set; }
        public System.Double mvarChieuCao { get; set; }
        public System.Double mvarCanNang { get; set; }
        public System.String mvarNhomMau { get; set; }
        public System.String mvarDienThoai { get; set; }
        public System.String mvarEmail { get; set; }
        public System.String mvarCMND { get; set; }
        public System.String mvarNoiCap { get; set; }
        public System.DateTime mvarNgayCap { get; set; }
        public System.String mvarHonNhan { get; set; }
        public System.DateTime mvarNgayVaoLam { get; set; }
        public System.DateTime mvarNgayNghiViec { get; set; }
        public System.String mvarMaPhongBan { get; set; }
        public System.String mvarDangLamViec { get; set; }
        public System.String mvarMaNhom { get; set; }
        public System.String mvarDidong { get; set; }
        public System.String mvarNangkhieu { get; set; }
        public System.String mvarGhichu { get; set; }
        public System.String mvarCongviec { get; set; }
        public System.Decimal mvarID { get; set; }
        public System.String mvarSoSLD { get; set; }
        public System.DateTime mvarSLDCapNgay { get; set; }
        public System.String mvarSoQuyetDinh { get; set; }
        public System.Decimal mvarTienTroCap { get; set; }
        public System.String mvarLyDoNghi { get; set; }
        public System.String mvarDutru1 { get; set; }
        public System.String mvarDutru2 { get; set; }
        public System.String mvarDutru3 { get; set; }
        public System.String mvarDutru4 { get; set; }
        public System.String mvarDutru5 { get; set; }
        public System.String mvarMaSoThue { get; set; }
        public System.Int32 mvarNamVaoNganhDauKhi { get; set; }
        public System.String mvarChungChiTinHoc { get; set; }
        public System.String mvarTinhThanh { get; set; }
        public System.Int32 mvarSapXep { get; set; }
        public System.String mvarMaHopDong { get; set; }
        public System.String mvarMaTrinhDoQuanLyNN { get; set; }
        public System.DateTime mvarNgayQuyetDinhNghiViec { get; set; }
        public System.Boolean mvarDangVien { get; set; }
        public System.String mvarMaTrinhDoChinhTri { get; set; }
        public System.String mvarMaChucVu_BaoCao { get; set; }
        public System.Int32 mvarNhanVien_Id { get; set; }
        public System.DateTime mvarMocTinhPhep { get; set; }
        public System.String mvarTenKhongDau { get; set; }
        public System.Int32 mvarTrai_Id { get; set; }
        public System.Int32 mvarSapXep_Trai { get; set; }
        public System.Int32 mvarNganHang_ID { get; set; }
        public System.DateTime mvarNgayVaoBienChe { get; set; }
        public System.String mvarMaSoThueTNCN { get; set; }
        public System.Int32 mvarLoaiLuong_Id { get; set; }

        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_NSNhanVien()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_NSNhanVien(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_NSNhanVien(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_NSNhanVien(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarMaNhanVien = String.Empty;
            mvarHo = String.Empty;
            mvarTen = String.Empty;
            mvarHinhAnh = String.Empty;
            mvarNgaySinh = DateTime.MinValue;
            mvarNoiSinh = String.Empty;
            mvarGioiTinh = String.Empty;
            mvarMaDanToc = String.Empty;
            mvarMaQuocTich = String.Empty;
            mvarMaTonGiao = String.Empty;
            mvarQuequan = String.Empty;
            mvarDiaChihokhau = String.Empty;
            mvarDiaChiLienhe = String.Empty;
            mvarPassport = String.Empty;
            mvarSoTaikhoan = String.Empty;
            mvarNganhang = String.Empty;
            mvarSoBHXH = String.Empty;
            mvarBHXHTuNgay = DateTime.MinValue;
            mvarBHXHDenNgay = DateTime.MinValue;
            mvarSoBHYT = String.Empty;
            mvarBHYTTuNgay = DateTime.MinValue;
            mvarBHYTDenNgay = DateTime.MinValue;
            mvarMaUngvien = String.Empty;
            mvarMaTrinhDo = String.Empty;
            mvarChuyenMon = String.Empty;
            mvarNgayThuViec = DateTime.MinValue;
            mvarNgayHetThuViec = DateTime.MinValue;
            mvarNgayThamGiaCM = DateTime.MinValue;
            mvarNgayVaoDoan = DateTime.MinValue;
            mvarNgayVaoDang = DateTime.MinValue;
            mvarMaChucVu = String.Empty;
            mvarMaChucDanh = String.Empty;
            mvarSucKhoe = String.Empty;
            mvarChieuCao = double.MinValue;
            mvarCanNang = double.MinValue;
            mvarNhomMau = String.Empty;
            mvarDienThoai = String.Empty;
            mvarEmail = String.Empty;
            mvarCMND = String.Empty;
            mvarNoiCap = String.Empty;
            mvarNgayCap = DateTime.MinValue;
            mvarHonNhan = String.Empty;
            mvarNgayVaoLam = DateTime.MinValue;
            mvarNgayNghiViec = DateTime.MinValue;
            mvarMaPhongBan = String.Empty;
            mvarDangLamViec = String.Empty;
            mvarMaNhom = String.Empty;
            mvarDidong = String.Empty;
            mvarNangkhieu = String.Empty;
            mvarGhichu = String.Empty;
            mvarCongviec = String.Empty;
            mvarID = decimal.MinValue;
            mvarSoSLD = String.Empty;
            mvarSLDCapNgay = DateTime.MinValue;
            mvarSoQuyetDinh = String.Empty;
            mvarTienTroCap = decimal.MinValue;
            mvarLyDoNghi = String.Empty;
            mvarDutru1 = String.Empty;
            mvarDutru2 = String.Empty;
            mvarDutru3 = String.Empty;
            mvarDutru4 = String.Empty;
            mvarDutru5 = String.Empty;
            mvarMaSoThue = String.Empty;
            mvarNamVaoNganhDauKhi = int.MinValue;
            mvarChungChiTinHoc = String.Empty;
            mvarTinhThanh = String.Empty;
            mvarSapXep = int.MinValue;
            mvarMaHopDong = String.Empty;
            mvarMaTrinhDoQuanLyNN = String.Empty;
            mvarNgayQuyetDinhNghiViec = DateTime.MinValue;
            mvarDangVien = false;
            mvarMaTrinhDoChinhTri = String.Empty;
            mvarMaChucVu_BaoCao = String.Empty;
            mvarNhanVien_Id = int.MinValue;
            mvarMocTinhPhep = DateTime.MinValue;
            mvarTenKhongDau = String.Empty;
            mvarTrai_Id = int.MinValue;
            mvarSapXep_Trai = int.MinValue;
            mvarNganHang_ID = int.MinValue;

        }

        public void FillData_FromGridView(DataRow row)
        {
            mvarMaNhanVien = Common.clsControl.getValueInRow<string>(row["MaNhanVien"]);
            mvarHo = Common.clsControl.getValueInRow<string>(row["Ho"]);
            mvarTen = Common.clsControl.getValueInRow<string>(row["Ten"]);
            mvarNgaySinh = Common.clsControl.IsNullOrEmpty(row["NgaySinh"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgaySinh"]);
            mvarGioiTinh = Common.clsControl.getValueInRow<string>(row["GioiTinh"]);
            mvarDiaChihokhau = Common.clsControl.getValueInRow<string>(row["DiaChihokhau"]);
        }
        public void FillData(DataRow row)
        {
            mvarMaNhanVien = Common.clsControl.getValueInRow<string>(row["MaNhanVien"]);
            mvarHo = Common.clsControl.getValueInRow<string>(row["Ho"]);
            mvarTen = Common.clsControl.getValueInRow<string>(row["Ten"]);
            mvarHinhAnh = Common.clsControl.getValueInRow<string>(row["HinhAnh"]);
            mvarNgaySinh = Common.clsControl.IsNullOrEmpty(row["NgaySinh"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgaySinh"]);
            mvarNoiSinh = Common.clsControl.getValueInRow<string>(row["NoiSinh"]);
            mvarGioiTinh = Common.clsControl.getValueInRow<string>(row["GioiTinh"]);
            mvarMaDanToc = Common.clsControl.getValueInRow<string>(row["MaDanToc"]);
            mvarMaQuocTich = Common.clsControl.getValueInRow<string>(row["MaQuocTich"]);
            mvarMaTonGiao = Common.clsControl.getValueInRow<string>(row["MaTonGiao"]);
            mvarQuequan = Common.clsControl.getValueInRow<string>(row["Quequan"]);
            mvarDiaChihokhau = Common.clsControl.getValueInRow<string>(row["DiaChihokhau"]);
            mvarDiaChiLienhe = Common.clsControl.getValueInRow<string>(row["DiaChiLienhe"]);
            mvarPassport = Common.clsControl.getValueInRow<string>(row["Passport"]);
            mvarSoTaikhoan = Common.clsControl.getValueInRow<string>(row["SoTaikhoan"]);
            mvarNganhang = Common.clsControl.getValueInRow<string>(row["Nganhang"]);
            mvarSoBHXH = Common.clsControl.getValueInRow<string>(row["SoBHXH"]);
            mvarBHXHTuNgay = Common.clsControl.IsNullOrEmpty(row["BHXHTuNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["BHXHTuNgay"]);
            mvarBHXHDenNgay = Common.clsControl.IsNullOrEmpty(row["BHXHDenNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["BHXHDenNgay"]);
            mvarSoBHYT = Common.clsControl.getValueInRow<string>(row["SoBHYT"]);
            mvarBHYTTuNgay = Common.clsControl.IsNullOrEmpty(row["BHYTTuNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["BHYTTuNgay"]);
            mvarBHYTDenNgay = Common.clsControl.IsNullOrEmpty(row["BHYTDenNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["BHYTDenNgay"]);
            mvarMaUngvien = Common.clsControl.getValueInRow<string>(row["MaUngvien"]);
            mvarMaTrinhDo = Common.clsControl.getValueInRow<string>(row["MaTrinhDo"]);
            mvarChuyenMon = Common.clsControl.getValueInRow<string>(row["ChuyenMon"]);
            mvarNgayThuViec = Common.clsControl.IsNullOrEmpty(row["NgayThuViec"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayThuViec"]);
            mvarNgayHetThuViec = Common.clsControl.IsNullOrEmpty(row["NgayHetThuViec"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHetThuViec"]);
            mvarNgayThamGiaCM = Common.clsControl.IsNullOrEmpty(row["NgayThamGiaCM"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayThamGiaCM"]);
            mvarNgayVaoDoan = Common.clsControl.IsNullOrEmpty(row["NgayVaoDoan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayVaoDoan"]);
            mvarNgayVaoDang = Common.clsControl.IsNullOrEmpty(row["NgayVaoDang"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayVaoDang"]);
            mvarMaChucVu = Common.clsControl.getValueInRow<string>(row["MaChucVu"]);
            mvarMaChucDanh = Common.clsControl.getValueInRow<string>(row["MaChucDanh"]);
            mvarSucKhoe = Common.clsControl.getValueInRow<string>(row["SucKhoe"]);
            mvarChieuCao = Common.clsControl.IsNullOrEmpty(row["ChieuCao"].ToString().ToArray()) ? double.MinValue : Common.clsControl.getValueInRow<double>(row["ChieuCao"]);
            mvarCanNang = Common.clsControl.IsNullOrEmpty(row["CanNang"].ToString().ToArray()) ? double.MinValue : Common.clsControl.getValueInRow<double>(row["CanNang"]);
            mvarNhomMau = Common.clsControl.getValueInRow<string>(row["NhomMau"]);
            mvarDienThoai = Common.clsControl.getValueInRow<string>(row["DienThoai"]);
            mvarEmail = Common.clsControl.getValueInRow<string>(row["Email"]);
            mvarCMND = Common.clsControl.getValueInRow<string>(row["CMND"]);
            mvarNoiCap = Common.clsControl.getValueInRow<string>(row["NoiCap"]);
            mvarNgayCap = Common.clsControl.IsNullOrEmpty(row["NgayCap"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCap"]);
            mvarHonNhan = Common.clsControl.getValueInRow<string>(row["HonNhan"]);
            mvarNgayVaoLam = Common.clsControl.IsNullOrEmpty(row["NgayVaoLam"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayVaoLam"]);
            mvarNgayNghiViec = Common.clsControl.IsNullOrEmpty(row["NgayNghiViec"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayNghiViec"]);
            mvarMaPhongBan = Common.clsControl.getValueInRow<string>(row["MaPhongBan"]);
            mvarDangLamViec = Common.clsControl.getValueInRow<string>(row["DangLamViec"]);
            mvarMaNhom = Common.clsControl.getValueInRow<string>(row["MaNhom"]);
            mvarDidong = Common.clsControl.getValueInRow<string>(row["Didong"]);
            mvarNangkhieu = Common.clsControl.getValueInRow<string>(row["Nangkhieu"]);
            mvarGhichu = Common.clsControl.getValueInRow<string>(row["Ghichu"]);
            mvarCongviec = Common.clsControl.getValueInRow<string>(row["Congviec"]);
            mvarID = Common.clsControl.IsNullOrEmpty(row["ID"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["ID"]);
            mvarSoSLD = Common.clsControl.getValueInRow<string>(row["SoSLD"]);
            mvarSLDCapNgay = Common.clsControl.IsNullOrEmpty(row["SLDCapNgay"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["SLDCapNgay"]);
            mvarSoQuyetDinh = Common.clsControl.getValueInRow<string>(row["SoQuyetDinh"]);
            mvarTienTroCap = Common.clsControl.IsNullOrEmpty(row["TienTroCap"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TienTroCap"]);
            mvarLyDoNghi = Common.clsControl.getValueInRow<string>(row["LyDoNghi"]);
            mvarDutru1 = Common.clsControl.getValueInRow<string>(row["Dutru1"]);
            mvarDutru2 = Common.clsControl.getValueInRow<string>(row["Dutru2"]);
            mvarDutru3 = Common.clsControl.getValueInRow<string>(row["Dutru3"]);
            mvarDutru4 = Common.clsControl.getValueInRow<string>(row["Dutru4"]);
            mvarDutru5 = Common.clsControl.getValueInRow<string>(row["Dutru5"]);
            mvarMaSoThue = Common.clsControl.getValueInRow<string>(row["MaSoThue"]);
            mvarNamVaoNganhDauKhi = Common.clsControl.IsNullOrEmpty(row["NamVaoNganhDauKhi"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NamVaoNganhDauKhi"]);
            mvarChungChiTinHoc = Common.clsControl.getValueInRow<string>(row["ChungChiTinHoc"]);
            mvarTinhThanh = Common.clsControl.getValueInRow<string>(row["TinhThanh"]);
            mvarSapXep = Common.clsControl.IsNullOrEmpty(row["SapXep"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SapXep"]);
            mvarMaHopDong = Common.clsControl.getValueInRow<string>(row["MaHopDong"]);
            mvarMaTrinhDoQuanLyNN = Common.clsControl.getValueInRow<string>(row["MaTrinhDoQuanLyNN"]);
            mvarNgayQuyetDinhNghiViec = Common.clsControl.IsNullOrEmpty(row["NgayQuyetDinhNghiViec"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayQuyetDinhNghiViec"]);
            mvarDangVien = Common.clsControl.getValueInRow<bool>(row["DangVien"]);
            mvarMaTrinhDoChinhTri = Common.clsControl.getValueInRow<string>(row["MaTrinhDoChinhTri"]);
            mvarMaChucVu_BaoCao = Common.clsControl.getValueInRow<string>(row["MaChucVu_BaoCao"]);
            mvarNhanVien_Id = Common.clsControl.IsNullOrEmpty(row["NhanVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhanVien_Id"]);
            mvarMocTinhPhep = Common.clsControl.IsNullOrEmpty(row["MocTinhPhep"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["MocTinhPhep"]);
            mvarTenKhongDau = Common.clsControl.getValueInRow<string>(row["TenKhongDau"]);
            mvarTrai_Id = Common.clsControl.IsNullOrEmpty(row["Trai_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Trai_Id"]);
            mvarSapXep_Trai = Common.clsControl.IsNullOrEmpty(row["SapXep_Trai"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SapXep_Trai"]);
            mvarNganHang_ID = Common.clsControl.IsNullOrEmpty(row["NganHang_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NganHang_ID"]);
        }
        public string Add()
        {   
            string rtNhanVien_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNhanVien", mvarMaNhanVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ho", mvarHo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ten", mvarTen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhAnh", mvarHinhAnh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgaySinh", mvarNgaySinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiSinh", mvarNoiSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioiTinh", mvarGioiTinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaDanToc", mvarMaDanToc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaQuocTich", mvarMaQuocTich);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaTonGiao", mvarMaTonGiao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Quequan", mvarQuequan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChihokhau", mvarDiaChihokhau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiLienhe", mvarDiaChiLienhe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Passport", mvarPassport);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTaikhoan", mvarSoTaikhoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Nganhang", mvarNganhang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoBHXH", mvarSoBHXH);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHXHTuNgay", mvarBHXHTuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHXHDenNgay", mvarBHXHDenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoBHYT", mvarSoBHYT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHYTTuNgay", mvarBHYTTuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHYTDenNgay", mvarBHYTDenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaUngvien", mvarMaUngvien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaTrinhDo", mvarMaTrinhDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenMon", mvarChuyenMon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThuViec", mvarNgayThuViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHetThuViec", mvarNgayHetThuViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThamGiaCM", mvarNgayThamGiaCM);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVaoDoan", mvarNgayVaoDoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVaoDang", mvarNgayVaoDang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaChucVu", mvarMaChucVu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaChucDanh", mvarMaChucDanh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SucKhoe", mvarSucKhoe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomMau", mvarNhomMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoai", mvarDienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Email", mvarEmail);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CMND", mvarCMND);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiCap", mvarNoiCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCap", mvarNgayCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HonNhan", mvarHonNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVaoLam", mvarNgayVaoLam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNghiViec", mvarNgayNghiViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaPhongBan", mvarMaPhongBan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DangLamViec", mvarDangLamViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNhom", mvarMaNhom);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Didong", mvarDidong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Nangkhieu", mvarNangkhieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ghichu", mvarGhichu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Congviec", mvarCongviec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ID", mvarID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoSLD", mvarSoSLD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SLDCapNgay", mvarSLDCapNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoQuyetDinh", mvarSoQuyetDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTroCap", mvarTienTroCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoNghi", mvarLyDoNghi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Dutru1", mvarDutru1);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Dutru2", mvarDutru2);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Dutru3", mvarDutru3);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Dutru4", mvarDutru4);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Dutru5", mvarDutru5);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaSoThue", mvarMaSoThue);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamVaoNganhDauKhi", mvarNamVaoNganhDauKhi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungChiTinHoc", mvarChungChiTinHoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh", mvarTinhThanh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SapXep", mvarSapXep);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaHopDong", mvarMaHopDong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaTrinhDoQuanLyNN", mvarMaTrinhDoQuanLyNN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayQuyetDinhNghiViec", mvarNgayQuyetDinhNghiViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DangVien", mvarDangVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaTrinhDoChinhTri", mvarMaTrinhDoChinhTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaChucVu_BaoCao", mvarMaChucVu_BaoCao);
            //ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhanVien_Id", mvarNhanVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MocTinhPhep", mvarMocTinhPhep);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenKhongDau", mvarTenKhongDau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Trai_Id", mvarTrai_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SapXep_Trai", mvarSapXep_Trai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NganHang_ID", mvarNganHang_ID);

            rtNhanVien_Id = ThuVien.mySQL.ExcSP(sp_NS_NHANVIEN, listPara, "@NhanVien_Id", SqlDbType.VarChar, 20);
            return rtNhanVien_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNhanVien", mvarMaNhanVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ho", mvarHo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ten", mvarTen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhAnh", mvarHinhAnh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgaySinh", mvarNgaySinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiSinh", mvarNoiSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioiTinh", mvarGioiTinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaDanToc", mvarMaDanToc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaQuocTich", mvarMaQuocTich);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaTonGiao", mvarMaTonGiao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Quequan", mvarQuequan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChihokhau", mvarDiaChihokhau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiLienhe", mvarDiaChiLienhe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Passport", mvarPassport);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTaikhoan", mvarSoTaikhoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Nganhang", mvarNganhang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoBHXH", mvarSoBHXH);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHXHTuNgay", mvarBHXHTuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHXHDenNgay", mvarBHXHDenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoBHYT", mvarSoBHYT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHYTTuNgay", mvarBHYTTuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BHYTDenNgay", mvarBHYTDenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaUngvien", mvarMaUngvien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaTrinhDo", mvarMaTrinhDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenMon", mvarChuyenMon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThuViec", mvarNgayThuViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHetThuViec", mvarNgayHetThuViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThamGiaCM", mvarNgayThamGiaCM);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVaoDoan", mvarNgayVaoDoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVaoDang", mvarNgayVaoDang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaChucVu", mvarMaChucVu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaChucDanh", mvarMaChucDanh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SucKhoe", mvarSucKhoe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomMau", mvarNhomMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoai", mvarDienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Email", mvarEmail);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CMND", mvarCMND);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiCap", mvarNoiCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCap", mvarNgayCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HonNhan", mvarHonNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVaoLam", mvarNgayVaoLam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNghiViec", mvarNgayNghiViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaPhongBan", mvarMaPhongBan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DangLamViec", mvarDangLamViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNhom", mvarMaNhom);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Didong", mvarDidong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Nangkhieu", mvarNangkhieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ghichu", mvarGhichu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Congviec", mvarCongviec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ID", mvarID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoSLD", mvarSoSLD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SLDCapNgay", mvarSLDCapNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoQuyetDinh", mvarSoQuyetDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTroCap", mvarTienTroCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoNghi", mvarLyDoNghi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Dutru1", mvarDutru1);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Dutru2", mvarDutru2);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Dutru3", mvarDutru3);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Dutru4", mvarDutru4);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Dutru5", mvarDutru5);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaSoThue", mvarMaSoThue);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamVaoNganhDauKhi", mvarNamVaoNganhDauKhi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungChiTinHoc", mvarChungChiTinHoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh", mvarTinhThanh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SapXep", mvarSapXep);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaHopDong", mvarMaHopDong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaTrinhDoQuanLyNN", mvarMaTrinhDoQuanLyNN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayQuyetDinhNghiViec", mvarNgayQuyetDinhNghiViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DangVien", mvarDangVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaTrinhDoChinhTri", mvarMaTrinhDoChinhTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaChucVu_BaoCao", mvarMaChucVu_BaoCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhanVien_Id", mvarNhanVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MocTinhPhep", mvarMocTinhPhep);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenKhongDau", mvarTenKhongDau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Trai_Id", mvarTrai_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SapXep_Trai", mvarSapXep_Trai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NganHang_ID", mvarNganHang_ID);

            ThuVien.mySQL.ExcSP(sp_NS_NHANVIEN, listPara);
            return mvarMaNhanVien.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNhanVien", mvarMaNhanVien);
            string rt = ThuVien.mySQL.ExcSP(sp_NS_NHANVIEN, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void GetListNhanVien(GridControl grv, string nameAction)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", nameAction); 
            Common.clsControl.LoadGirdControl_Y(grv, sp_NS_NHANVIEN, listPara);
        }
        public bool Get_By_Key(string maNhanVien)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaNhanVien", maNhanVien);
                ds = ThuVien.mySQL.ExcDataSet(sp_NS_NHANVIEN, listPara);
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
        //public string getNhanVienById(string maNhanVien)
        //{
        //    SqlConnection con = ThuVien.mySQL.Connection();
        //    SqlCommand cmd;
        //    string soVaoVien = "";
        //    DataSet dt = new DataSet();
        //    DataRow dr = new DataRow();
        //    try
        //    {
        //        using (cmd = new SqlCommand(SP_GetSoVaoVien, con))
        //            cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@TableName", "NS_NhanVien");
        //        cmd.Parameters.AddWithValue("@Action", "getNhanVienById");
        //        var rs = cmd.Parameters.Add("@Values_Id", SqlDbType.Int);
        //        rs.Direction = ParameterDirection.Output;
        //        cmd.ExecuteNonQuery();
        //        soVaoVien = Int32.Parse(rs.Value.ToString()).ToString(("D6"));
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        con.Close();
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //    return DateTime.Now.ToString("yy") + soVaoVien;
        //}
    }
}

