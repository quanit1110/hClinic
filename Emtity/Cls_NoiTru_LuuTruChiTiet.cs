using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class cls_NoiTru_LuuTruChiTiet
    {
        #region "Constants"
        private const string sp_NOITRU_LUUTRUCHITIET = "sp_NOITRU_LUUTRUCHITIET";
        #endregion

        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarLuuTruChiTiet_Id { get; set; }
        public System.Int32 mvarLuuTru_Id { get; set; }
        public System.Int32 mvarPhongBan_Id { get; set; }
        public System.Int32 mvarGiuongBenh_Id { get; set; }
        public System.Int32 mvarPhongBenh_Id { get; set; }
        public System.DateTime mvarNgayVao { get; set; }
        public System.DateTime mvarThoiGianVao { get; set; }
        public System.DateTime mvarThoiGianTinhLuuTru { get; set; }
        public System.Int32 mvarLyDo_Id { get; set; }
        public System.DateTime mvarNgayRa { get; set; }
        public System.DateTime mvarThoiGianRa { get; set; }
        public System.Decimal mvarDonGiaPhaiThu { get; set; }
        public System.Decimal mvarDonGia { get; set; }
        public System.Decimal mvarTyLeVAT { get; set; }
        public System.Decimal mvarGiaTriVAT { get; set; }
        public System.String mvarTienTe_Id { get; set; }
        public System.Decimal mvarTygia { get; set; }
        public System.Int32 mvarLoaiGia_Id { get; set; }
        public System.Int32 mvarGiuongBenhChuyenDen_Id { get; set; }
        public System.Boolean mvarBaoPhong { get; set; }
        public System.Boolean mvarKhongTinhTien { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.Int32 mvarLuuTruChiTiet_Prev { get; set; }
        public System.Boolean mvarLuuTruChiTiet_Current { get; set; }
        public System.Int32 mvarDoiTuong_Id { get; set; }
        public System.Boolean mvarLuuTruChiTiet_Id_Last { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_NoiTru_LuuTruChiTiet()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_NoiTru_LuuTruChiTiet(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_NoiTru_LuuTruChiTiet(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_NoiTru_LuuTruChiTiet(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarLuuTruChiTiet_Id = int.MinValue;
            mvarLuuTru_Id = int.MinValue;
            mvarPhongBan_Id = int.MinValue;
            mvarGiuongBenh_Id = int.MinValue;
            mvarPhongBenh_Id = int.MinValue;
            mvarNgayVao = DateTime.MinValue;
            mvarThoiGianVao = DateTime.MinValue;
            mvarThoiGianTinhLuuTru = DateTime.MinValue;
            mvarLyDo_Id = int.MinValue;
            mvarNgayRa = DateTime.MinValue;
            mvarThoiGianRa = DateTime.MinValue;
            mvarDonGiaPhaiThu = decimal.MinValue;
            mvarDonGia = decimal.MinValue;
            mvarTyLeVAT = decimal.MinValue;
            mvarGiaTriVAT = decimal.MinValue;
            mvarTienTe_Id = String.Empty;
            mvarTygia = decimal.MinValue;
            mvarLoaiGia_Id = int.MinValue;
            mvarGiuongBenhChuyenDen_Id = int.MinValue;
            mvarBaoPhong = false;
            mvarKhongTinhTien = false;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarLuuTruChiTiet_Prev = int.MinValue;
            mvarLuuTruChiTiet_Current = false;
            mvarDoiTuong_Id = int.MinValue;
            mvarLuuTruChiTiet_Id_Last = false;
        }

        public void FillData(DataRow row)
        {
            mvarLuuTruChiTiet_Id = Common.clsControl.IsNullOrEmpty(row["LuuTruChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LuuTruChiTiet_Id"]);
            mvarLuuTru_Id = Common.clsControl.IsNullOrEmpty(row["LuuTru_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LuuTru_Id"]);
            mvarPhongBan_Id = Common.clsControl.IsNullOrEmpty(row["PhongBan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhongBan_Id"]);
            mvarGiuongBenh_Id = Common.clsControl.IsNullOrEmpty(row["GiuongBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiuongBenh_Id"]);
            mvarPhongBenh_Id = Common.clsControl.IsNullOrEmpty(row["PhongBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhongBenh_Id"]);
            mvarNgayVao = Common.clsControl.IsNullOrEmpty(row["NgayVao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayVao"]);
            mvarThoiGianVao = Common.clsControl.IsNullOrEmpty(row["ThoiGianVao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianVao"]);
            mvarThoiGianTinhLuuTru = Common.clsControl.IsNullOrEmpty(row["ThoiGianTinhLuuTru"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianTinhLuuTru"]);
            mvarLyDo_Id = Common.clsControl.IsNullOrEmpty(row["LyDo_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LyDo_Id"]);
            mvarNgayRa = Common.clsControl.IsNullOrEmpty(row["NgayRa"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayRa"]);
            mvarThoiGianRa = Common.clsControl.IsNullOrEmpty(row["ThoiGianRa"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianRa"]);
            mvarDonGiaPhaiThu = Common.clsControl.IsNullOrEmpty(row["DonGiaPhaiThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaPhaiThu"]);
            mvarDonGia = Common.clsControl.IsNullOrEmpty(row["DonGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGia"]);
            mvarTyLeVAT = Common.clsControl.IsNullOrEmpty(row["TyLeVAT"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyLeVAT"]);
            mvarGiaTriVAT = Common.clsControl.IsNullOrEmpty(row["GiaTriVAT"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriVAT"]);
            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);
            mvarTygia = Common.clsControl.IsNullOrEmpty(row["Tygia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["Tygia"]);
            mvarLoaiGia_Id = Common.clsControl.IsNullOrEmpty(row["LoaiGia_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiGia_Id"]);
            mvarGiuongBenhChuyenDen_Id = Common.clsControl.IsNullOrEmpty(row["GiuongBenhChuyenDen_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiuongBenhChuyenDen_Id"]);
            mvarBaoPhong = Common.clsControl.getValueInRow<bool>(row["BaoPhong"]);
            mvarKhongTinhTien = Common.clsControl.getValueInRow<bool>(row["KhongTinhTien"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarLuuTruChiTiet_Prev = Common.clsControl.IsNullOrEmpty(row["LuuTruChiTiet_Prev"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LuuTruChiTiet_Prev"]);
            mvarLuuTruChiTiet_Current = Common.clsControl.getValueInRow<bool>(row["LuuTruChiTiet_Current"]);
            mvarDoiTuong_Id = Common.clsControl.IsNullOrEmpty(row["DoiTuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DoiTuong_Id"]);
            mvarLuuTruChiTiet_Id_Last = Common.clsControl.getValueInRow<bool>(row["LuuTruChiTiet_Id_Last"]);
        }
        public string Add()
        {
            string rtLuuTruChiTiet_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Id", mvarLuuTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiuongBenh_Id", mvarGiuongBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBenh_Id", mvarPhongBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVao", mvarNgayVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianVao", mvarThoiGianVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTinhLuuTru", mvarThoiGianTinhLuuTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDo_Id", mvarLyDo_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRa", mvarNgayRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRa", mvarThoiGianRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaPhaiThu", mvarDonGiaPhaiThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGia", mvarDonGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeVAT", mvarTyLeVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVAT", mvarGiaTriVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Tygia", mvarTygia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia_Id", mvarLoaiGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiuongBenhChuyenDen_Id", mvarGiuongBenhChuyenDen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BaoPhong", mvarBaoPhong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhongTinhTien", mvarKhongTinhTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTruChiTiet_Prev", mvarLuuTruChiTiet_Prev);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTruChiTiet_Current", mvarLuuTruChiTiet_Current);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);

            rtLuuTruChiTiet_Id = ThuVien.mySQL.ExcSP(sp_NOITRU_LUUTRUCHITIET, listPara, "@LuuTruChiTiet_Id", SqlDbType.Int, 32);
            return rtLuuTruChiTiet_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTruChiTiet_Id", mvarLuuTruChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Id", mvarLuuTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiuongBenh_Id", mvarGiuongBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBenh_Id", mvarPhongBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayVao", mvarNgayVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianVao", mvarThoiGianVao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTinhLuuTru", mvarThoiGianTinhLuuTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDo_Id", mvarLyDo_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRa", mvarNgayRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianRa", mvarThoiGianRa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaPhaiThu", mvarDonGiaPhaiThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGia", mvarDonGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeVAT", mvarTyLeVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVAT", mvarGiaTriVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Tygia", mvarTygia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia_Id", mvarLoaiGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiuongBenhChuyenDen_Id", mvarGiuongBenhChuyenDen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BaoPhong", mvarBaoPhong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhongTinhTien", mvarKhongTinhTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTruChiTiet_Prev", mvarLuuTruChiTiet_Prev);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTruChiTiet_Current", mvarLuuTruChiTiet_Current);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.ExcSP(sp_NOITRU_LUUTRUCHITIET, listPara);
            return mvarLuuTruChiTiet_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTruChiTiet_Id", mvarLuuTruChiTiet_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_NOITRU_LUUTRUCHITIET, listPara);
            if (rt == "err") { return false; }
            return true;
        }
    }
}
