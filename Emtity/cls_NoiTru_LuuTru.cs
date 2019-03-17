using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class cls_NoiTru_LuuTru
    {
        #region "Constants"
        private const string sp_NOITRU_LUUTRU = "sp_NOITRU_LUUTRU";
        #endregion

        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarLuuTru_Id { get; set; }
        public System.Int32 mvarBenhAn_Id { get; set; }
        public System.Int32 mvarPhongBan_Id { get; set; }
        public System.DateTime mvarNgayVao { get; set; }
        public System.DateTime mvarThoiGianVao { get; set; }
        public System.Int32 mvarLyDoVao_Id { get; set; }
        public System.String mvarLyDoVao_Code { get; set; }
        public System.Int32 mvarICD_VaoKhoa { get; set; }
        public System.DateTime mvarNgayRa { get; set; }
        public System.DateTime mvarThoiGianRa { get; set; }
        public System.Int32 mvarLyDoRa_Id { get; set; }
        public System.String mvarLyDoRa_Code { get; set; }
        public System.Int32 mvarICD_RaKhoa { get; set; }
        public System.String mvarChanDoanRaKhoa { get; set; }
        public System.Int32 mvarPhongBanChuyenDen_Id { get; set; }
        public System.Int32 mvarPhongBanChuyenDi_Id { get; set; }
        public System.Int32 mvarBacSiDieuTriChinh_Id { get; set; }
        public System.Int32 mvarBacSiDieuTri_Id { get; set; }
        public System.Int32 mvarNguoiNhap_Id { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.Int32 mvarLuuTru_Prev { get; set; }
        public System.Boolean mvarLuuTru_Current { get; set; }
        public System.Int32 mvarDoiTuong_Id { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_NoiTru_LuuTru()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_NoiTru_LuuTru(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_NoiTru_LuuTru(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_NoiTru_LuuTru(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = dal;
        }
        #endregion

        public void ReSet()
        {
            mvarLuuTru_Id = int.MinValue;
            mvarBenhAn_Id = int.MinValue;
            mvarPhongBan_Id = int.MinValue;
            mvarNgayVao = DateTime.MinValue;
            mvarThoiGianVao = DateTime.MinValue;
            mvarLyDoVao_Id = int.MinValue;
            mvarLyDoVao_Code = String.Empty;
            mvarICD_VaoKhoa = int.MinValue;
            mvarNgayRa = DateTime.MinValue;
            mvarThoiGianRa = DateTime.MinValue;
            mvarLyDoRa_Id = int.MinValue;
            mvarLyDoRa_Code = String.Empty;
            mvarICD_RaKhoa = int.MinValue;
            mvarChanDoanRaKhoa = String.Empty;
            mvarPhongBanChuyenDen_Id = int.MinValue;
            mvarPhongBanChuyenDi_Id = int.MinValue;
            mvarBacSiDieuTriChinh_Id = int.MinValue;
            mvarBacSiDieuTri_Id = int.MinValue;
            mvarNguoiNhap_Id = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarLuuTru_Prev = int.MinValue;
            mvarLuuTru_Current = false;
            mvarDoiTuong_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarLuuTru_Id = Common.clsControl.IsNullOrEmpty(row["LuuTru_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LuuTru_Id"]);
            mvarBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["BenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAn_Id"]);
            mvarPhongBan_Id = Common.clsControl.IsNullOrEmpty(row["PhongBan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhongBan_Id"]);
            mvarNgayVao = Common.clsControl.IsNullOrEmpty(row["NgayVao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayVao"]);
            mvarThoiGianVao = Common.clsControl.IsNullOrEmpty(row["ThoiGianVao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianVao"]);
            mvarLyDoVao_Id = Common.clsControl.IsNullOrEmpty(row["LyDoVao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LyDoVao_Id"]);
            mvarLyDoVao_Code = Common.clsControl.getValueInRow<string>(row["LyDoVao_Code"]);
            mvarICD_VaoKhoa = Common.clsControl.IsNullOrEmpty(row["ICD_VaoKhoa"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_VaoKhoa"]);
            mvarNgayRa = Common.clsControl.IsNullOrEmpty(row["NgayRa"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayRa"]);
            mvarThoiGianRa = Common.clsControl.IsNullOrEmpty(row["ThoiGianRa"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianRa"]);
            mvarLyDoRa_Id = Common.clsControl.IsNullOrEmpty(row["LyDoRa_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LyDoRa_Id"]);
            mvarLyDoRa_Code = Common.clsControl.getValueInRow<string>(row["LyDoRa_Code"]);
            mvarICD_RaKhoa = Common.clsControl.IsNullOrEmpty(row["ICD_RaKhoa"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_RaKhoa"]);
            mvarChanDoanRaKhoa = Common.clsControl.getValueInRow<string>(row["ChanDoanRaKhoa"]);
            mvarPhongBanChuyenDen_Id = Common.clsControl.IsNullOrEmpty(row["PhongBanChuyenDen_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhongBanChuyenDen_Id"]);
            mvarPhongBanChuyenDi_Id = Common.clsControl.IsNullOrEmpty(row["PhongBanChuyenDi_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhongBanChuyenDi_Id"]);
            mvarBacSiDieuTriChinh_Id = Common.clsControl.IsNullOrEmpty(row["BacSiDieuTriChinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiDieuTriChinh_Id"]);
            mvarBacSiDieuTri_Id = Common.clsControl.IsNullOrEmpty(row["BacSiDieuTri_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiDieuTri_Id"]);
            mvarNguoiNhap_Id = Common.clsControl.IsNullOrEmpty(row["NguoiNhap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiNhap_Id"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarLuuTru_Prev = Common.clsControl.IsNullOrEmpty(row["LuuTru_Prev"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LuuTru_Prev"]);
            mvarLuuTru_Current = Common.clsControl.getValueInRow<bool>(row["LuuTru_Current"]);
            mvarDoiTuong_Id = Common.clsControl.IsNullOrEmpty(row["DoiTuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DoiTuong_Id"]);
        }
        public string Add()
        {
            string rtLuuTru_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVao", mvarNgayVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianVao", mvarThoiGianVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoVao_Id", mvarLyDoVao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoVao_Code", mvarLyDoVao_Code);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_VaoKhoa", mvarICD_VaoKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRa", mvarNgayRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRa", mvarThoiGianRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoRa_Id", mvarLyDoRa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoRa_Code", mvarLyDoRa_Code);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_RaKhoa", mvarICD_RaKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanRaKhoa", mvarChanDoanRaKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBanChuyenDen_Id", mvarPhongBanChuyenDen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBanChuyenDi_Id", mvarPhongBanChuyenDi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiDieuTriChinh_Id", mvarBacSiDieuTriChinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiDieuTri_Id", mvarBacSiDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNhap_Id", mvarNguoiNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Prev", mvarLuuTru_Prev);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Current", mvarLuuTru_Current);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);

            rtLuuTru_Id = ThuVien.mySQL.ExcSP(sp_NOITRU_LUUTRU, listPara, "@LuuTru_Id", SqlDbType.Int, 32);
            return rtLuuTru_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Id", mvarLuuTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVao", mvarNgayVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianVao", mvarThoiGianVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoVao_Id", mvarLyDoVao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoVao_Code", mvarLyDoVao_Code);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_VaoKhoa", mvarICD_VaoKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRa", mvarNgayRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRa", mvarThoiGianRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoRa_Id", mvarLyDoRa_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoRa_Code", mvarLyDoRa_Code);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_RaKhoa", mvarICD_RaKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanRaKhoa", mvarChanDoanRaKhoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBanChuyenDen_Id", mvarPhongBanChuyenDen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBanChuyenDi_Id", mvarPhongBanChuyenDi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiDieuTriChinh_Id", mvarBacSiDieuTriChinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiDieuTri_Id", mvarBacSiDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiNhap_Id", mvarNguoiNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Prev", mvarLuuTru_Prev);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Current", mvarLuuTru_Current);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.ExcSP(sp_NOITRU_LUUTRU, listPara);
            return mvarLuuTru_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Id", mvarLuuTru_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_NOITRU_LUUTRU, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public string GetCurrent_LuuTru_Id(int benhAn_Id)
        {
            string rtLuuTru_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetCurrent_LuuTru_Id");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", benhAn_Id);
            rtLuuTru_Id = ThuVien.mySQL.ExcSP(sp_NOITRU_LUUTRU, listPara, "@LuuTru_Id", SqlDbType.Int, 32);
            return rtLuuTru_Id;
        }
    }
}
