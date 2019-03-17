using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
  public  class ThongTin_CapCuu
    {
        #region "Constants"
        private const string sp_THONGTINCAPCUU = "sp_THONGTINCAPCUU";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarThongTinCapCuu_Id { get; set; }
        public System.String mvarSoCapCuu { get; set; }
        public System.Int32 mvarTiepNhan_Id { get; set; }
        public System.Int32 mvarBenhAn_Id { get; set; }
        public System.Int32 mvarLuuTru_Id { get; set; }
        public System.Int32 mvarBenhNhan_Id { get; set; }
        public System.DateTime mvarNgayCapCuu { get; set; }
        public System.DateTime mvarThoiGianCapCuu { get; set; }
        public System.Int32 mvarNoiCapCuu_Id { get; set; }
        public System.Int32 mvarBacSiCapCuu_Id { get; set; }
        public System.String mvarChanDoanNGT { get; set; }
        public System.Int32 mvarICD_BenhChinh { get; set; }
        public System.Int32 mvarICD_BenhPhu { get; set; }
        public System.Int32 mvarKetQuaCapCuu_Id { get; set; }
        public System.String mvarGhiChu { get; set; }
        public System.Int32 mvarKhoaNhapVien_Id { get; set; }
        public System.DateTime mvarNgayNhapVien { get; set; }
        public System.DateTime mvarThoiGianNhapVien { get; set; }
        public System.Int32 mvarICD_NhapVien { get; set; }
        public System.String mvarChanDoanNhapVien { get; set; }
        public System.Int32 mvarChuyenVien_Id { get; set; }
        public System.DateTime mvarNgayRaVien { get; set; }
        public System.DateTime mvarThoiGianRaVien { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public ThongTin_CapCuu()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public ThongTin_CapCuu(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public ThongTin_CapCuu(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public ThongTin_CapCuu(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarThongTinCapCuu_Id = int.MinValue;
            mvarSoCapCuu = String.Empty;
            mvarTiepNhan_Id = int.MinValue;
            mvarBenhAn_Id = int.MinValue;
            mvarLuuTru_Id = int.MinValue;
            mvarBenhNhan_Id = int.MinValue;
            mvarNgayCapCuu = DateTime.MinValue;
            mvarThoiGianCapCuu = DateTime.MinValue;
            mvarNoiCapCuu_Id = int.MinValue;
            mvarBacSiCapCuu_Id = int.MinValue;
            mvarChanDoanNGT = String.Empty;
            mvarICD_BenhChinh = int.MinValue;
            mvarICD_BenhPhu = int.MinValue;
            mvarKetQuaCapCuu_Id = int.MinValue;
            mvarGhiChu = String.Empty;
            mvarKhoaNhapVien_Id = int.MinValue;
            mvarNgayNhapVien = DateTime.MinValue;
            mvarThoiGianNhapVien = DateTime.MinValue;
            mvarICD_NhapVien = int.MinValue;
            mvarChanDoanNhapVien = String.Empty;
            mvarChuyenVien_Id = int.MinValue;
            mvarNgayRaVien = DateTime.MinValue;
            mvarThoiGianRaVien = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;

        }

        public void FillData(DataRow row)
        {
            mvarThongTinCapCuu_Id = Common.clsControl.IsNullOrEmpty(row["ThongTinCapCuu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ThongTinCapCuu_Id"]);
            mvarSoCapCuu = Common.clsControl.getValueInRow<string>(row["SoCapCuu"]);
            mvarTiepNhan_Id = Common.clsControl.IsNullOrEmpty(row["TiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhan_Id"]);
            mvarBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["BenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAn_Id"]);
            mvarLuuTru_Id = Common.clsControl.IsNullOrEmpty(row["LuuTru_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LuuTru_Id"]);
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarNgayCapCuu = Common.clsControl.IsNullOrEmpty(row["NgayCapCuu"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapCuu"]);
            mvarThoiGianCapCuu = Common.clsControl.IsNullOrEmpty(row["ThoiGianCapCuu"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianCapCuu"]);
            mvarNoiCapCuu_Id = Common.clsControl.IsNullOrEmpty(row["NoiCapCuu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiCapCuu_Id"]);
            mvarBacSiCapCuu_Id = Common.clsControl.IsNullOrEmpty(row["BacSiCapCuu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiCapCuu_Id"]);
            mvarChanDoanNGT = Common.clsControl.getValueInRow<string>(row["ChanDoanNGT"]);
            mvarICD_BenhChinh = Common.clsControl.IsNullOrEmpty(row["ICD_BenhChinh"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_BenhChinh"]);
            mvarICD_BenhPhu = Common.clsControl.IsNullOrEmpty(row["ICD_BenhPhu"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_BenhPhu"]);
            mvarKetQuaCapCuu_Id = Common.clsControl.IsNullOrEmpty(row["KetQuaCapCuu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KetQuaCapCuu_Id"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarKhoaNhapVien_Id = Common.clsControl.IsNullOrEmpty(row["KhoaNhapVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoaNhapVien_Id"]);
            mvarNgayNhapVien = Common.clsControl.IsNullOrEmpty(row["NgayNhapVien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayNhapVien"]);
            mvarThoiGianNhapVien = Common.clsControl.IsNullOrEmpty(row["ThoiGianNhapVien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianNhapVien"]);
            mvarICD_NhapVien = Common.clsControl.IsNullOrEmpty(row["ICD_NhapVien"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_NhapVien"]);
            mvarChanDoanNhapVien = Common.clsControl.getValueInRow<string>(row["ChanDoanNhapVien"]);
            mvarChuyenVien_Id = Common.clsControl.IsNullOrEmpty(row["ChuyenVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChuyenVien_Id"]);
            mvarNgayRaVien = Common.clsControl.IsNullOrEmpty(row["NgayRaVien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayRaVien"]);
            mvarThoiGianRaVien = Common.clsControl.IsNullOrEmpty(row["ThoiGianRaVien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianRaVien"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
        }
        public string Add()
        {
            string rtThongTinCapCuu_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoCapCuu", mvarSoCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Id", mvarLuuTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapCuu", mvarNgayCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianCapCuu", mvarThoiGianCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiCapCuu_Id", mvarNoiCapCuu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiCapCuu_Id", mvarBacSiCapCuu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanNGT", mvarChanDoanNGT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_BenhChinh", mvarICD_BenhChinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_BenhPhu", mvarICD_BenhPhu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaCapCuu_Id", mvarKetQuaCapCuu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaNhapVien_Id", mvarKhoaNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNhapVien", mvarNgayNhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianNhapVien", mvarThoiGianNhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_NhapVien", mvarICD_NhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanNhapVien", mvarChanDoanNhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenVien_Id", mvarChuyenVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRaVien", mvarNgayRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRaVien", mvarThoiGianRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);

            rtThongTinCapCuu_Id = ThuVien.mySQL.ExcSP(sp_THONGTINCAPCUU, listPara, "@ThongTinCapCuu_Id", SqlDbType.Int, 32);
            return rtThongTinCapCuu_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThongTinCapCuu_Id", mvarThongTinCapCuu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoCapCuu", mvarSoCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Id", mvarLuuTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapCuu", mvarNgayCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianCapCuu", mvarThoiGianCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiCapCuu_Id", mvarNoiCapCuu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiCapCuu_Id", mvarBacSiCapCuu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanNGT", mvarChanDoanNGT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_BenhChinh", mvarICD_BenhChinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_BenhPhu", mvarICD_BenhPhu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQuaCapCuu_Id", mvarKetQuaCapCuu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaNhapVien_Id", mvarKhoaNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNhapVien", mvarNgayNhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianNhapVien", mvarThoiGianNhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_NhapVien", mvarICD_NhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanNhapVien", mvarChanDoanNhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChuyenVien_Id", mvarChuyenVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRaVien", mvarNgayRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRaVien", mvarThoiGianRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.ExcSP(sp_THONGTINCAPCUU, listPara);
            return mvarThongTinCapCuu_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThongTinCapCuu_Id", mvarThongTinCapCuu_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_THONGTINCAPCUU, listPara);
            if (rt == "err") { return false; }
            return true;
        }
    }
}
