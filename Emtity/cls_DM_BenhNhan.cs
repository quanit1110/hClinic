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
    public class clsDM_BenhNhan
    {
        #region "Constants"
        private const String SP_DM_BenhNhan = "SP_DM_BenhNhan"; 
        private const String SP_GetSoVaoVien = "GetSoTangDan";
        #endregion
        # region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarBenhNhan_Id { get; set; }

        public System.String mvarMaYTe { get; set; }

        public System.String mvarMaBenhVien { get; set; }

        public System.String mvarSoVaoVien { get; set; }

        public System.String mvarTenBenhNhan { get; set; }

        public System.String mvarHo { get; set; }

        public System.String mvarTen { get; set; }

        public System.String mvarGioiTinh { get; set; }

        public System.DateTime mvarNgaySinh { get; set; }

        public System.Int16 mvarNamSinh { get; set; }

        public System.String mvarSoNha { get; set; }

        public System.String mvarDiaChi { get; set; }

        public System.Int32 mvarNhomMau_Id { get; set; }

        public System.Int32 mvarYeuToRh_Id { get; set; }

        public System.String mvarTienSuDiUng { get; set; }

        public System.String mvarSoLuuTruNgoaiTru { get; set; }

        public System.String mvarSoLuuTruNoiTru { get; set; }

        public System.Int32 mvarQuocTich_Id { get; set; }

        public System.Int32 mvarTinhThanh_Id { get; set; }

        public System.Int32 mvarQuanHuyen_Id { get; set; }

        public System.Int32 mvarXaPhuong_Id { get; set; }

        public System.Int32 mvarDanToc_Id { get; set; }

        public System.Int32 mvarNgheNghiep_Id { get; set; }

        public System.Boolean mvarVietKieu { get; set; }

        public System.Boolean mvarNguoiNuocNgoai { get; set; }

        public System.String mvarCMND { get; set; }

        public System.String mvarHoChieu { get; set; }

        public System.String mvarTenKhongDau { get; set; }

        public System.String mvarGhiChu { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }

        public System.DateTime mvarNgayCapThe { get; set; }

        public System.Int16 mvarNamCapThe { get; set; }

        public System.DateTime mvarThoiGianCapThe { get; set; }

        public System.Int32 mvarNhanVien_Id { get; set; }

        public System.String mvarTienSuBenh { get; set; }

        public System.String mvarTienSuHutThuocLa { get; set; }

        public System.Int32 mvarDonViCongTac_Id { get; set; }

        public System.String mvarSoDienThoai { get; set; }

        public System.String mvarDiaChiThuongTru { get; set; }

        public System.String mvarDiaChiLienLac { get; set; }

        public System.String mvarEmail { get; set; }

        public System.String mvarDiaChiCoQuan { get; set; }

        public System.Boolean mvarTuVong { get; set; }

        public System.DateTime mvarNgayTuVong { get; set; }

        public System.DateTime mvarThoiGianTuVong { get; set; }

        public System.Int32 mvarNguyenNhanTuVong_Id { get; set; }

        public System.Int32 mvarNguoiGhiNhanTuVong_Id { get; set; }

        public System.DateTime mvarThoiGianGhiNhanTuVong { get; set; }

        public System.Int32 mvarCountNotes { get; set; }

        public System.String mvarNguoiLienHe { get; set; }
        #endregion
        private DataSet m_Dal;
        #region Contructor
        public clsDM_BenhNhan()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public clsDM_BenhNhan(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public clsDM_BenhNhan(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public clsDM_BenhNhan(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = dal;
        }
        #endregion
        public string Add()
        {
            string rtBenhNhan_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaYTe", mvarMaYTe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaBenhVien", mvarMaBenhVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoVaoVien", mvarSoVaoVien);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhNhan", mvarTenBenhNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ho", mvarHo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ten", mvarTen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioiTinh", mvarGioiTinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgaySinh", mvarNgaySinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamSinh", mvarNamSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNha", mvarSoNha);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomMau_Id", mvarNhomMau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@YeuToRh_Id", mvarYeuToRh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuDiUng", mvarTienSuDiUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuuTruNgoaiTru", mvarSoLuuTruNgoaiTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuuTruNoiTru", mvarSoLuuTruNoiTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuocTich_Id", mvarQuocTich_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh_Id", mvarTinhThanh_Id);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuanHuyen_Id", mvarQuanHuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XaPhuong_Id", mvarXaPhuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DanToc_Id", mvarDanToc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgheNghiep_Id", mvarNgheNghiep_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@VietKieu", mvarVietKieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNuocNgoai", mvarNguoiNuocNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CMND", mvarCMND);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoChieu", mvarHoChieu);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenKhongDau", mvarTenKhongDau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapThe", mvarNgayCapThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamCapThe", mvarNamCapThe);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianCapThe", mvarThoiGianCapThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhanVien_Id", mvarNhanVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBenh", mvarTienSuBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuHutThuocLa", mvarTienSuHutThuocLa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViCongTac_Id", mvarDonViCongTac_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDienThoai", mvarSoDienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiThuongTru", mvarDiaChiThuongTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiLienLac", mvarDiaChiLienLac);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Email", mvarEmail);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiCoQuan", mvarDiaChiCoQuan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuVong", mvarTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTuVong", mvarNgayTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTuVong", mvarThoiGianTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhanTuVong_Id", mvarNguyenNhanTuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiGhiNhanTuVong_Id", mvarNguoiGhiNhanTuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianGhiNhanTuVong", mvarThoiGianGhiNhanTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLienHe", mvarNguoiLienHe);

            rtBenhNhan_Id = ThuVien.mySQL.ExcSP(SP_DM_BenhNhan, listPara, "@BenhNhan_Id", SqlDbType.Int, 32);
            return rtBenhNhan_Id;
        }
        public string Update()
        {
           
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaYTe", mvarMaYTe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaBenhVien", mvarMaBenhVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoVaoVien", mvarSoVaoVien);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhNhan", mvarTenBenhNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ho", mvarHo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ten", mvarTen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GioiTinh", mvarGioiTinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgaySinh", mvarNgaySinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamSinh", mvarNamSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNha", mvarSoNha);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhomMau_Id", mvarNhomMau_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@YeuToRh_Id", mvarYeuToRh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuDiUng", mvarTienSuDiUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuuTruNgoaiTru", mvarSoLuuTruNgoaiTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuuTruNoiTru", mvarSoLuuTruNoiTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuocTich_Id", mvarQuocTich_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh_Id", mvarTinhThanh_Id);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuanHuyen_Id", mvarQuanHuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XaPhuong_Id", mvarXaPhuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DanToc_Id", mvarDanToc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgheNghiep_Id", mvarNgheNghiep_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@VietKieu", mvarVietKieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNuocNgoai", mvarNguoiNuocNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CMND", mvarCMND);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoChieu", mvarHoChieu);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenKhongDau", mvarTenKhongDau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapThe", mvarNgayCapThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NamCapThe", mvarNamCapThe);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianCapThe", mvarThoiGianCapThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhanVien_Id", mvarNhanVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBenh", mvarTienSuBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuHutThuocLa", mvarTienSuHutThuocLa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonViCongTac_Id", mvarDonViCongTac_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoDienThoai", mvarSoDienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiThuongTru", mvarDiaChiThuongTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiLienLac", mvarDiaChiLienLac);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Email", mvarEmail);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChiCoQuan", mvarDiaChiCoQuan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuVong", mvarTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTuVong", mvarNgayTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTuVong", mvarThoiGianTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguyenNhanTuVong_Id", mvarNguyenNhanTuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiGhiNhanTuVong_Id", mvarNguoiGhiNhanTuVong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianGhiNhanTuVong", mvarThoiGianGhiNhanTuVong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLienHe", mvarNguoiLienHe);

            ThuVien.mySQL.ExcSP(SP_DM_BenhNhan, listPara);
            return mvarBenhNhan_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id",mvarBenhNhan_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_DM_BenhNhan, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void Reset()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarBenhNhan_Id = int.MinValue;
            mvarMaYTe = String.Empty;
            mvarMaBenhVien = String.Empty;
            mvarSoVaoVien = String.Empty;
            mvarTenBenhNhan = String.Empty;
            mvarHo = String.Empty;
            mvarTen = String.Empty;
            mvarGioiTinh = String.Empty;
            mvarNgaySinh = DateTime.MinValue;
            mvarNamSinh = short.MinValue;
            mvarSoNha = String.Empty;
            mvarDiaChi = String.Empty;
            mvarNhomMau_Id = int.MinValue;
            mvarYeuToRh_Id = int.MinValue;
            mvarTienSuDiUng = String.Empty;
            mvarSoLuuTruNgoaiTru = String.Empty;
            mvarSoLuuTruNoiTru = String.Empty;
            mvarQuocTich_Id = int.MinValue;
            mvarTinhThanh_Id = int.MinValue;
            mvarQuanHuyen_Id = int.MinValue;
            mvarXaPhuong_Id = int.MinValue;
            mvarDanToc_Id = int.MinValue;
            mvarNgheNghiep_Id = int.MinValue;
            mvarVietKieu = false;
            mvarNguoiNuocNgoai = false;
            mvarCMND = String.Empty;
            mvarHoChieu = String.Empty;
            mvarTenKhongDau = String.Empty;
            mvarGhiChu = String.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarNgayCapThe = DateTime.MinValue;
            mvarNamCapThe = short.MinValue;
            mvarThoiGianCapThe = DateTime.MinValue;
            mvarNhanVien_Id = int.MinValue;
            mvarTienSuBenh = String.Empty;
            mvarTienSuHutThuocLa = String.Empty;
            mvarDonViCongTac_Id = int.MinValue;
            mvarSoDienThoai = String.Empty;
            mvarDiaChiThuongTru = String.Empty;
            mvarDiaChiLienLac = String.Empty;
            mvarEmail = String.Empty;
            mvarDiaChiCoQuan = String.Empty;
            mvarTuVong = false;
            mvarNgayTuVong = DateTime.MinValue;
            mvarThoiGianTuVong = DateTime.MinValue;
            mvarNguyenNhanTuVong_Id = int.MinValue;
            mvarNguoiGhiNhanTuVong_Id = int.MinValue;
            mvarThoiGianGhiNhanTuVong = DateTime.MinValue;
            mvarCountNotes = int.MinValue;
        }
        public void FillData(DataRow row)
        {
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarMaYTe = Common.clsControl.getValueInRow<string>(row["MaYTe"]);
            mvarMaBenhVien = Common.clsControl.getValueInRow<string>(row["MaBenhVien"]);
            mvarSoVaoVien = Common.clsControl.getValueInRow<string>(row["SoVaoVien"]);
            mvarTenBenhNhan = Common.clsControl.getValueInRow<string>(row["TenBenhNhan"]);
            mvarHo = Common.clsControl.getValueInRow<string>(row["Ho"]);
            mvarTen = Common.clsControl.getValueInRow<string>(row["Ten"]);
            mvarGioiTinh = Common.clsControl.getValueInRow<string>(row["GioiTinh"]);
            mvarNgaySinh = Common.clsControl.IsNullOrEmpty(row["NgaySinh"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgaySinh"]);
            mvarNamSinh = Common.clsControl.IsNullOrEmpty(row["NamSinh"].ToString().ToArray()) ? short.MinValue : Common.clsControl.getValueInRow<short>(row["NamSinh"]);
            mvarSoNha = Common.clsControl.getValueInRow<string>(row["SoNha"]);
            mvarDiaChi = Common.clsControl.getValueInRow<string>(row["DiaChi"]);
            mvarNhomMau_Id = Common.clsControl.IsNullOrEmpty(row["NhomMau_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhomMau_Id"]);
            mvarYeuToRh_Id = Common.clsControl.IsNullOrEmpty(row["YeuToRh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["YeuToRh_Id"]);
            mvarTienSuDiUng = Common.clsControl.getValueInRow<string>(row["TienSuDiUng"]);
            mvarSoLuuTruNgoaiTru = Common.clsControl.getValueInRow<string>(row["SoLuuTruNgoaiTru"]);
            mvarSoLuuTruNoiTru = Common.clsControl.getValueInRow<string>(row["SoLuuTruNoiTru"]);
            mvarQuocTich_Id = Common.clsControl.IsNullOrEmpty(row["QuocTich_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["QuocTich_Id"]);
            mvarTinhThanh_Id = Common.clsControl.IsNullOrEmpty(row["TinhThanh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TinhThanh_Id"]);
            mvarQuanHuyen_Id = Common.clsControl.IsNullOrEmpty(row["QuanHuyen_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["QuanHuyen_Id"]);
            mvarXaPhuong_Id = Common.clsControl.IsNullOrEmpty(row["XaPhuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["XaPhuong_Id"]);
            mvarDanToc_Id = Common.clsControl.IsNullOrEmpty(row["DanToc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DanToc_Id"]);
            mvarNgheNghiep_Id = Common.clsControl.IsNullOrEmpty(row["NgheNghiep_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NgheNghiep_Id"]);
            mvarVietKieu = Common.clsControl.IsNullOrEmpty(row["VietKieu"].ToString().ToArray()) ? false: Common.clsControl.getValueInRow<bool>(row["VietKieu"]);
            mvarNguoiNuocNgoai = Common.clsControl.IsNullOrEmpty(row["NguoiNuocNgoai"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["NguoiNuocNgoai"]);
            mvarCMND = Common.clsControl.getValueInRow<string>(row["CMND"]);
            mvarHoChieu = Common.clsControl.getValueInRow<string>(row["HoChieu"]);
            mvarTenKhongDau = Common.clsControl.getValueInRow<string>(row["TenKhongDau"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarNgayCapThe = Common.clsControl.IsNullOrEmpty(row["NgayCapThe"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapThe"]);
            mvarNamCapThe = Common.clsControl.IsNullOrEmpty(row["NamCapThe"].ToString().ToArray()) ? short.MinValue : Common.clsControl.getValueInRow<short>(row["NamCapThe"]);
            mvarThoiGianCapThe = Common.clsControl.IsNullOrEmpty(row["ThoiGianCapThe"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianCapThe"]);
            mvarNhanVien_Id = Common.clsControl.IsNullOrEmpty(row["NhanVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhanVien_Id"]);
            mvarTienSuBenh = Common.clsControl.getValueInRow<string>(row["TienSuBenh"]);
            mvarTienSuHutThuocLa = Common.clsControl.getValueInRow<string>(row["TienSuHutThuocLa"]);
            mvarDonViCongTac_Id = Common.clsControl.IsNullOrEmpty(row["DonViCongTac_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DonViCongTac_Id"]);
            mvarSoDienThoai = Common.clsControl.getValueInRow<string>(row["SoDienThoai"]);
            mvarDiaChiThuongTru = Common.clsControl.getValueInRow<string>(row["DiaChiThuongTru"]);
            mvarDiaChiLienLac = Common.clsControl.getValueInRow<string>(row["DiaChiLienLac"]);
            mvarEmail = Common.clsControl.getValueInRow<string>(row["Email"]);
            mvarDiaChiCoQuan = Common.clsControl.getValueInRow<string>(row["DiaChiCoQuan"]);
            mvarTuVong = Common.clsControl.IsNullOrEmpty(row["TuVong"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["TuVong"]);
            mvarNgayTuVong = Common.clsControl.IsNullOrEmpty(row["NgayTuVong"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTuVong"]);
            mvarThoiGianTuVong = Common.clsControl.IsNullOrEmpty(row["ThoiGianTuVong"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianTuVong"]);
            mvarNguyenNhanTuVong_Id = Common.clsControl.IsNullOrEmpty(row["NguyenNhanTuVong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguyenNhanTuVong_Id"]);
            mvarNguoiGhiNhanTuVong_Id = Common.clsControl.IsNullOrEmpty(row["NguoiGhiNhanTuVong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiGhiNhanTuVong_Id"]);
            mvarThoiGianGhiNhanTuVong = Common.clsControl.IsNullOrEmpty(row["ThoiGianGhiNhanTuVong"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianGhiNhanTuVong"]);
            mvarCountNotes = Common.clsControl.IsNullOrEmpty(row["CountNotes"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CountNotes"]);
        }
        public bool Get_By_MaYTe(string strMaYTe)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByMaYTe");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoVaoVien", strMaYTe);
                ds = ThuVien.mySQL.ExcDataSet(SP_DM_BenhNhan, listPara);
                Reset();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillData(ds.Tables[0].Rows[0]);
                }
                return true;
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
                return false; }

        }
        public bool Get_By_Key(int benhNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", benhNhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_DM_BenhNhan, listPara);
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
        public DataRow Get_By_Key_AllCol(int benhNhan_Id)
        {
            DataSet ds = new DataSet();
            try
            {
                
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetAllCollumn_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", benhNhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_DM_BenhNhan, listPara);
                Reset();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillData(ds.Tables[0].Rows[0]);
                }
                return ds.Tables[0].Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DataRow dtr=new DataTable().NewRow();
                return dtr;
            }

        }
        public string getSoVaoVien()
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;
            string soVaoVien = "";
            DataSet dt = new DataSet();

            try
            {
                using (cmd = new SqlCommand(SP_GetSoVaoVien, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableName", "DM_BenhNhan");
                cmd.Parameters.AddWithValue("@String_Id", DateTime.Now.ToString("yy"));
                var rs = cmd.Parameters.Add("@Values_Id", SqlDbType.Int);
                rs.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                soVaoVien = Int32.Parse(rs.Value.ToString()).ToString(("D6"));
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

            return DateTime.Now.ToString("yy") + soVaoVien;
        }
        public DataRow Get_ThongTinBenhNhan_For_CanLamSang(string BenhNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_ThongTinBenhNhan_For_CanLamSang");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", BenhNhan_Id);

                ds = ThuVien.mySQL.ExcDataSet(SP_DM_BenhNhan, listPara);
                Reset();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
    }
}
