using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
   public class cls_KhamBenh_VaoVien
    {
        #region "Constants"
        private const string sp_KHAMBENH_VAOVIEN = "sp_KHAMBENH_VAOVIEN";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarKhamBenhVaoVien_Id { get; set; }
        public System.String mvarSoPhieu { get; set; }
        public System.Int32 mvarTiepNhan_Id { get; set; }
        public System.Int32 mvarKhamBenh_Id { get; set; }
        public System.Int32 mvarBenhNhan_Id { get; set; }
        public System.String mvarNguoiLienHe { get; set; }
        public System.String mvarDienThoaiLienHe { get; set; }
        public System.String mvarNoiLamViec { get; set; }
        public System.String mvarChanDoanNoiGioiThieu { get; set; }
        public System.DateTime mvarNgayKham { get; set; }
        public System.DateTime mvarThoiGianKham { get; set; }
        public System.String mvarLyDoVaoVien { get; set; }
        public System.String mvarQuaTrinhBenhLy { get; set; }
        public System.String mvarTienSuBanThan { get; set; }
        public System.String mvarTienSuGiaDinh { get; set; }
        public System.String mvarKhamXetToanThan { get; set; }
        public System.String mvarKhamXetCacBoPhan { get; set; }
        public System.String mvarKhamXetKQLS { get; set; }
        public System.String mvarChanDoanVao { get; set; }
        public System.Int32 mvarICDKhamXet_Id { get; set; }
        public System.String mvarDaXuLy { get; set; }
        public System.DateTime mvarNgayRa { get; set; }
        public System.DateTime mvarThoiGianRa { get; set; }
        public System.Int32 mvarNhapKhoa_Id { get; set; }
        public System.Int32 mvarChuyenVien_Id { get; set; }
        public System.String mvarChuY { get; set; }
        public System.Int32 mvarMach { get; set; }
        public System.Decimal mvarNhietDo { get; set; }
        public System.Int32 mvarHuyetApCao { get; set; }
        public System.Int32 mvarHuyetApThap { get; set; }
        public System.Int32 mvarNhipTho { get; set; }
        public System.Decimal mvarCanNang { get; set; }
        public System.Decimal mvarChieuCao { get; set; }
        public System.Int32 mvarBacSi_Id { get; set; }
        public System.Int32 mvarXuTruKhamBenh_Id { get; set; }
        public System.Boolean mvarCapCuu { get; set; }
        public System.DateTime mvarNgayTaiNan { get; set; }
        public System.DateTime mvarThoiGianTaiNan { get; set; }
        public System.Int32 mvarNoiTaiNan_TinhThanh_Id { get; set; }
        public System.Int32 mvarNoiTaiNan_QuanHuyen_Id { get; set; }
        public System.Int32 mvarNoiTaiNan_PhuongXa_Id { get; set; }
        public System.String mvarNoiTaiNan_DiaChi { get; set; }
        public System.Int32 mvarDiaDiemTaiNan_Id { get; set; }
        public System.Int32 mvarBoPhanBiThuong_Id { get; set; }
        public System.Int32 mvarMucDo_Id { get; set; }
        public System.Int32 mvarDienBienSauTN_Id { get; set; }
        public System.Int32 mvarXuTriSauTN_Id { get; set; }
        public System.Int32 mvarNguyenNhan_Id { get; set; }
        public System.Int32 mvarNguyenNhanChiTiet_Id { get; set; }
        public System.Int32 mvarICD_NguyenNhan { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_KhamBenh_VaoVien()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_KhamBenh_VaoVien(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_KhamBenh_VaoVien(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_KhamBenh_VaoVien(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarKhamBenhVaoVien_Id = int.MinValue;
            mvarSoPhieu = String.Empty;
            mvarTiepNhan_Id = int.MinValue;
            mvarKhamBenh_Id = int.MinValue;
            mvarBenhNhan_Id = int.MinValue;
            mvarNguoiLienHe = String.Empty;
            mvarDienThoaiLienHe = String.Empty;
            mvarNoiLamViec = String.Empty;
            mvarChanDoanNoiGioiThieu = String.Empty;
            mvarNgayKham = DateTime.MinValue;
            mvarThoiGianKham = DateTime.MinValue;
            mvarLyDoVaoVien = String.Empty;
            mvarQuaTrinhBenhLy = String.Empty;
            mvarTienSuBanThan = String.Empty;
            mvarTienSuGiaDinh = String.Empty;
            mvarKhamXetToanThan = String.Empty;
            mvarKhamXetCacBoPhan = String.Empty;
            mvarKhamXetKQLS = String.Empty;
            mvarChanDoanVao = String.Empty;
            mvarICDKhamXet_Id = int.MinValue;
            mvarDaXuLy = String.Empty;
            mvarNgayRa = DateTime.MinValue;
            mvarThoiGianRa = DateTime.MinValue;
            mvarNhapKhoa_Id = int.MinValue;
            mvarChuyenVien_Id = int.MinValue;
            mvarChuY = String.Empty;
            mvarMach = int.MinValue;
            mvarNhietDo = decimal.MinValue;
            mvarHuyetApCao = int.MinValue;
            mvarHuyetApThap = int.MinValue;
            mvarNhipTho = int.MinValue;
            mvarCanNang = decimal.MinValue;
            mvarChieuCao = decimal.MinValue;
            mvarBacSi_Id = int.MinValue;
            mvarXuTruKhamBenh_Id = int.MinValue;
            mvarCapCuu = false;
            mvarNgayTaiNan = DateTime.MinValue;
            mvarThoiGianTaiNan = DateTime.MinValue;
            mvarNoiTaiNan_TinhThanh_Id = int.MinValue;
            mvarNoiTaiNan_QuanHuyen_Id = int.MinValue;
            mvarNoiTaiNan_PhuongXa_Id = int.MinValue;
            mvarNoiTaiNan_DiaChi = String.Empty;
            mvarDiaDiemTaiNan_Id = int.MinValue;
            mvarBoPhanBiThuong_Id = int.MinValue;
            mvarMucDo_Id = int.MinValue;
            mvarDienBienSauTN_Id = int.MinValue;
            mvarXuTriSauTN_Id = int.MinValue;
            mvarNguyenNhan_Id = int.MinValue;
            mvarNguyenNhanChiTiet_Id = int.MinValue;
            mvarICD_NguyenNhan = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarKhamBenhVaoVien_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenhVaoVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenhVaoVien_Id"]);
            mvarSoPhieu = Common.clsControl.getValueInRow<string>(row["SoPhieu"]);
            mvarTiepNhan_Id = Common.clsControl.IsNullOrEmpty(row["TiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhan_Id"]);
            mvarKhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_Id"]);
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarNguoiLienHe = Common.clsControl.getValueInRow<string>(row["NguoiLienHe"]);
            mvarDienThoaiLienHe = Common.clsControl.getValueInRow<string>(row["DienThoaiLienHe"]);
            mvarNoiLamViec = Common.clsControl.getValueInRow<string>(row["NoiLamViec"]);
            mvarChanDoanNoiGioiThieu = Common.clsControl.getValueInRow<string>(row["ChanDoanNoiGioiThieu"]);
            mvarNgayKham = Common.clsControl.IsNullOrEmpty(row["NgayKham"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayKham"]);
            mvarThoiGianKham = Common.clsControl.IsNullOrEmpty(row["ThoiGianKham"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianKham"]);
            mvarLyDoVaoVien = Common.clsControl.getValueInRow<string>(row["LyDoVaoVien"]);
            mvarQuaTrinhBenhLy = Common.clsControl.getValueInRow<string>(row["QuaTrinhBenhLy"]);
            mvarTienSuBanThan = Common.clsControl.getValueInRow<string>(row["TienSuBanThan"]);
            mvarTienSuGiaDinh = Common.clsControl.getValueInRow<string>(row["TienSuGiaDinh"]);
            mvarKhamXetToanThan = Common.clsControl.getValueInRow<string>(row["KhamXetToanThan"]);
            mvarKhamXetCacBoPhan = Common.clsControl.getValueInRow<string>(row["KhamXetCacBoPhan"]);
            mvarKhamXetKQLS = Common.clsControl.getValueInRow<string>(row["KhamXetKQLS"]);
            mvarChanDoanVao = Common.clsControl.getValueInRow<string>(row["ChanDoanVao"]);
            mvarICDKhamXet_Id = Common.clsControl.IsNullOrEmpty(row["ICDKhamXet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICDKhamXet_Id"]);
            mvarDaXuLy = Common.clsControl.getValueInRow<string>(row["DaXuLy"]);
            mvarNgayRa = Common.clsControl.IsNullOrEmpty(row["NgayRa"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayRa"]);
            mvarThoiGianRa = Common.clsControl.IsNullOrEmpty(row["ThoiGianRa"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianRa"]);
            mvarNhapKhoa_Id = Common.clsControl.IsNullOrEmpty(row["NhapKhoa_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhapKhoa_Id"]);
            mvarChuyenVien_Id = Common.clsControl.IsNullOrEmpty(row["ChuyenVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenVien_Id"]);
            mvarChuY = Common.clsControl.getValueInRow<string>(row["ChuY"]);
            mvarMach = Common.clsControl.IsNullOrEmpty(row["Mach"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Mach"]);
            mvarNhietDo = Common.clsControl.IsNullOrEmpty(row["NhietDo"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["NhietDo"]);
            mvarHuyetApCao = Common.clsControl.IsNullOrEmpty(row["HuyetApCao"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuyetApCao"]);
            mvarHuyetApThap = Common.clsControl.IsNullOrEmpty(row["HuyetApThap"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuyetApThap"]);
            mvarNhipTho = Common.clsControl.IsNullOrEmpty(row["NhipTho"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhipTho"]);
            mvarCanNang = Common.clsControl.IsNullOrEmpty(row["CanNang"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["CanNang"]);
            mvarChieuCao = Common.clsControl.IsNullOrEmpty(row["ChieuCao"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["ChieuCao"]);
            mvarBacSi_Id = Common.clsControl.IsNullOrEmpty(row["BacSi_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSi_Id"]);
            mvarXuTruKhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["XuTruKhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["XuTruKhamBenh_Id"]);
            mvarCapCuu = Common.clsControl.getValueInRow<bool>(row["CapCuu"]);
            mvarNgayTaiNan = Common.clsControl.IsNullOrEmpty(row["NgayTaiNan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTaiNan"]);
            mvarThoiGianTaiNan = Common.clsControl.IsNullOrEmpty(row["ThoiGianTaiNan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianTaiNan"]);
            mvarNoiTaiNan_TinhThanh_Id = Common.clsControl.IsNullOrEmpty(row["NoiTaiNan_TinhThanh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiTaiNan_TinhThanh_Id"]);
            mvarNoiTaiNan_QuanHuyen_Id = Common.clsControl.IsNullOrEmpty(row["NoiTaiNan_QuanHuyen_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiTaiNan_QuanHuyen_Id"]);
            mvarNoiTaiNan_PhuongXa_Id = Common.clsControl.IsNullOrEmpty(row["NoiTaiNan_PhuongXa_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiTaiNan_PhuongXa_Id"]);
            mvarNoiTaiNan_DiaChi = Common.clsControl.getValueInRow<string>(row["NoiTaiNan_DiaChi"]);
            mvarDiaDiemTaiNan_Id = Common.clsControl.IsNullOrEmpty(row["DiaDiemTaiNan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DiaDiemTaiNan_Id"]);
            mvarBoPhanBiThuong_Id = Common.clsControl.IsNullOrEmpty(row["BoPhanBiThuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BoPhanBiThuong_Id"]);
            mvarMucDo_Id = Common.clsControl.IsNullOrEmpty(row["MucDo_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["MucDo_Id"]);
            mvarDienBienSauTN_Id = Common.clsControl.IsNullOrEmpty(row["DienBienSauTN_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DienBienSauTN_Id"]);
            mvarXuTriSauTN_Id = Common.clsControl.IsNullOrEmpty(row["XuTriSauTN_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["XuTriSauTN_Id"]);
            mvarNguyenNhan_Id = Common.clsControl.IsNullOrEmpty(row["NguyenNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguyenNhan_Id"]);
            mvarNguyenNhanChiTiet_Id = Common.clsControl.IsNullOrEmpty(row["NguyenNhanChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguyenNhanChiTiet_Id"]);
            mvarICD_NguyenNhan = Common.clsControl.IsNullOrEmpty(row["ICD_NguyenNhan"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_NguyenNhan"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);

        }

        public string Add()
        {
            string rtKhamBenhVaoVien_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhieu", mvarSoPhieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLienHe", mvarNguoiLienHe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoaiLienHe", mvarDienThoaiLienHe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiLamViec", mvarNoiLamViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanNoiGioiThieu", mvarChanDoanNoiGioiThieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKham", mvarNgayKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKham", mvarThoiGianKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoVaoVien", mvarLyDoVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuaTrinhBenhLy", mvarQuaTrinhBenhLy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBanThan", mvarTienSuBanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuGiaDinh", mvarTienSuGiaDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamXetToanThan", mvarKhamXetToanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamXetCacBoPhan", mvarKhamXetCacBoPhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamXetKQLS", mvarKhamXetKQLS);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanVao", mvarChanDoanVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICDKhamXet_Id", mvarICDKhamXet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaXuLy", mvarDaXuLy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRa", mvarNgayRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRa", mvarThoiGianRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhapKhoa_Id", mvarNhapKhoa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenVien_Id", mvarChuyenVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuY", mvarChuY);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSi_Id", mvarBacSi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XuTruKhamBenh_Id", mvarXuTruKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CapCuu", mvarCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTaiNan", mvarNgayTaiNan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTaiNan", mvarThoiGianTaiNan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTaiNan_TinhThanh_Id", mvarNoiTaiNan_TinhThanh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTaiNan_QuanHuyen_Id", mvarNoiTaiNan_QuanHuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTaiNan_PhuongXa_Id", mvarNoiTaiNan_PhuongXa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTaiNan_DiaChi", mvarNoiTaiNan_DiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaDiemTaiNan_Id", mvarDiaDiemTaiNan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BoPhanBiThuong_Id", mvarBoPhanBiThuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MucDo_Id", mvarMucDo_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienBienSauTN_Id", mvarDienBienSauTN_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XuTriSauTN_Id", mvarXuTriSauTN_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhan_Id", mvarNguyenNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhanChiTiet_Id", mvarNguyenNhanChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_NguyenNhan", mvarICD_NguyenNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);

            rtKhamBenhVaoVien_Id = ThuVien.mySQL.ExcSP(sp_KHAMBENH_VAOVIEN, listPara, "@KhamBenhVaoVien_Id", SqlDbType.Int, 32);
            return rtKhamBenhVaoVien_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhVaoVien_Id", mvarKhamBenhVaoVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhieu", mvarSoPhieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLienHe", mvarNguoiLienHe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoaiLienHe", mvarDienThoaiLienHe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiLamViec", mvarNoiLamViec);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanNoiGioiThieu", mvarChanDoanNoiGioiThieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKham", mvarNgayKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKham", mvarThoiGianKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoVaoVien", mvarLyDoVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuaTrinhBenhLy", mvarQuaTrinhBenhLy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBanThan", mvarTienSuBanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuGiaDinh", mvarTienSuGiaDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamXetToanThan", mvarKhamXetToanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamXetCacBoPhan", mvarKhamXetCacBoPhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamXetKQLS", mvarKhamXetKQLS);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanVao", mvarChanDoanVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICDKhamXet_Id", mvarICDKhamXet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaXuLy", mvarDaXuLy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRa", mvarNgayRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRa", mvarThoiGianRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhapKhoa_Id", mvarNhapKhoa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenVien_Id", mvarChuyenVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuY", mvarChuY);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChieuCao", mvarChieuCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSi_Id", mvarBacSi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XuTruKhamBenh_Id", mvarXuTruKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CapCuu", mvarCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTaiNan", mvarNgayTaiNan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTaiNan", mvarThoiGianTaiNan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTaiNan_TinhThanh_Id", mvarNoiTaiNan_TinhThanh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTaiNan_QuanHuyen_Id", mvarNoiTaiNan_QuanHuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTaiNan_PhuongXa_Id", mvarNoiTaiNan_PhuongXa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiTaiNan_DiaChi", mvarNoiTaiNan_DiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaDiemTaiNan_Id", mvarDiaDiemTaiNan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BoPhanBiThuong_Id", mvarBoPhanBiThuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MucDo_Id", mvarMucDo_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienBienSauTN_Id", mvarDienBienSauTN_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XuTriSauTN_Id", mvarXuTriSauTN_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhan_Id", mvarNguyenNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhanChiTiet_Id", mvarNguyenNhanChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_NguyenNhan", mvarICD_NguyenNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);

            ThuVien.mySQL.ExcSP(sp_KHAMBENH_VAOVIEN, listPara);
            return mvarKhamBenhVaoVien_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhVaoVien_Id", mvarKhamBenhVaoVien_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_KHAMBENH_VAOVIEN, listPara);
            if (rt == "err") { return false; }
            return true;
        }
    }
}
