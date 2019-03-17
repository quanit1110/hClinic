using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntityClass
{
    public class cls_GhiNhanBHTN_ChiTiet
    {
        #region "Constants"
        private const string sp_GHINHANBHTNCHITIET = "sp_GHINHANBHTNCHITIET";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarGhiNhanChiTiet_Id { get; set; }
        public System.Int32 mvarGhiNhan_ID { get; set; }
        public System.Decimal mvarTyLe { get; set; }
        public System.Decimal mvarGiaTri { get; set; }
        public System.Int32 mvarIDRef { get; set; }
        public System.Decimal mvarSoLuong { get; set; }
        public System.String mvarLoai_IDRef { get; set; }
        public System.Int32 mvarNoiDung_ID { get; set; }
        public System.String mvarLoaiNoiDung { get; set; }
        public System.Decimal mvarGiaTriGhiNhan_ChenhLech { get; set; }
        public System.Decimal mvarGiaTriGhiNhan_HoTroChenhLech { get; set; }
        public System.Decimal mvarGiaTriGhiNhan_CoPhan { get; set; }
        public System.String mvarLoaiGia { get; set; }
        public System.Decimal mvarGiaTriThanhToan_ChenhLech { get; set; }
        public System.Decimal mvarGiaTriThanhToan_HoTroChenhLech { get; set; }
        public System.Decimal mvarGiaTriThanhToan_CoPhan { get; set; }
        public System.Decimal mvarDonGiaDoanhThu { get; set; }
        public System.Decimal mvarDonGiaHoTro { get; set; }
        public System.Decimal mvarDonGiaBHTN { get; set; }
        public System.Decimal mvarDonGiaThanhToan { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_GhiNhanBHTN_ChiTiet()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_GhiNhanBHTN_ChiTiet(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_GhiNhanBHTN_ChiTiet(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_GhiNhanBHTN_ChiTiet(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarGhiNhanChiTiet_Id = int.MinValue;
            mvarGhiNhan_ID = int.MinValue;
            mvarTyLe = decimal.MinValue;
            mvarGiaTri = decimal.MinValue;
            mvarIDRef = int.MinValue;
            mvarSoLuong = decimal.MinValue;
            mvarLoai_IDRef = String.Empty;
            mvarNoiDung_ID = int.MinValue;
            mvarLoaiNoiDung = String.Empty;
            mvarGiaTriGhiNhan_ChenhLech = decimal.MinValue;
            mvarGiaTriGhiNhan_HoTroChenhLech = decimal.MinValue;
            mvarGiaTriGhiNhan_CoPhan = decimal.MinValue;
            mvarLoaiGia = String.Empty;
            mvarGiaTriThanhToan_ChenhLech = decimal.MinValue;
            mvarGiaTriThanhToan_HoTroChenhLech = decimal.MinValue;
            mvarGiaTriThanhToan_CoPhan = decimal.MinValue;
            mvarDonGiaDoanhThu = decimal.MinValue;
            mvarDonGiaHoTro = decimal.MinValue;
            mvarDonGiaBHTN = decimal.MinValue;
            mvarDonGiaThanhToan = decimal.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarGhiNhanChiTiet_Id = Common.clsControl.IsNullOrEmpty(row["GhiNhanChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GhiNhanChiTiet_Id"]);
            mvarGhiNhan_ID = Common.clsControl.IsNullOrEmpty(row["GhiNhan_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GhiNhan_ID"]);
            mvarTyLe = Common.clsControl.IsNullOrEmpty(row["TyLe"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyLe"]);
            mvarGiaTri = Common.clsControl.IsNullOrEmpty(row["GiaTri"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTri"]);
            mvarIDRef = Common.clsControl.IsNullOrEmpty(row["IDRef"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["IDRef"]);
            mvarSoLuong = Common.clsControl.IsNullOrEmpty(row["SoLuong"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong"]);
            mvarLoai_IDRef = Common.clsControl.getValueInRow<string>(row["Loai_IDRef"]);
            mvarNoiDung_ID = Common.clsControl.IsNullOrEmpty(row["NoiDung_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiDung_ID"]);
            mvarLoaiNoiDung = Common.clsControl.getValueInRow<string>(row["LoaiNoiDung"]);
            mvarGiaTriGhiNhan_ChenhLech = Common.clsControl.IsNullOrEmpty(row["GiaTriGhiNhan_ChenhLech"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriGhiNhan_ChenhLech"]);
            mvarGiaTriGhiNhan_HoTroChenhLech = Common.clsControl.IsNullOrEmpty(row["GiaTriGhiNhan_HoTroChenhLech"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriGhiNhan_HoTroChenhLech"]);
            mvarGiaTriGhiNhan_CoPhan = Common.clsControl.IsNullOrEmpty(row["GiaTriGhiNhan_CoPhan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriGhiNhan_CoPhan"]);
            mvarLoaiGia = Common.clsControl.getValueInRow<string>(row["LoaiGia"]);
            mvarGiaTriThanhToan_ChenhLech = Common.clsControl.IsNullOrEmpty(row["GiaTriThanhToan_ChenhLech"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriThanhToan_ChenhLech"]);
            mvarGiaTriThanhToan_HoTroChenhLech = Common.clsControl.IsNullOrEmpty(row["GiaTriThanhToan_HoTroChenhLech"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriThanhToan_HoTroChenhLech"]);
            mvarGiaTriThanhToan_CoPhan = Common.clsControl.IsNullOrEmpty(row["GiaTriThanhToan_CoPhan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriThanhToan_CoPhan"]);
            mvarDonGiaDoanhThu = Common.clsControl.IsNullOrEmpty(row["DonGiaDoanhThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaDoanhThu"]);
            mvarDonGiaHoTro = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTro"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTro"]);
            mvarDonGiaBHTN = Common.clsControl.IsNullOrEmpty(row["DonGiaBHTN"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaBHTN"]);
            mvarDonGiaThanhToan = Common.clsControl.IsNullOrEmpty(row["DonGiaThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaThanhToan"]);
        }

        public string Add()
        {
            string rtGhiNhanChiTiet_ID = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiNhan_ID", mvarGhiNhan_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLe", mvarTyLe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri", mvarGiaTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDRef", mvarIDRef);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong", mvarSoLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Loai_IDRef", mvarLoai_IDRef);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiDung_ID", mvarNoiDung_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiNoiDung", mvarLoaiNoiDung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriGhiNhan_ChenhLech", mvarGiaTriGhiNhan_ChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriGhiNhan_HoTroChenhLech", mvarGiaTriGhiNhan_HoTroChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriGhiNhan_CoPhan", mvarGiaTriGhiNhan_CoPhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia", mvarLoaiGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThanhToan_ChenhLech", mvarGiaTriThanhToan_ChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThanhToan_HoTroChenhLech", mvarGiaTriThanhToan_HoTroChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThanhToan_CoPhan", mvarGiaTriThanhToan_CoPhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThu", mvarDonGiaDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTro", mvarDonGiaHoTro);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaBHTN", mvarDonGiaBHTN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);

            rtGhiNhanChiTiet_ID = ThuVien.mySQL.ExcSP(sp_GHINHANBHTNCHITIET, listPara, "@GhiNhanChiTiet_ID", SqlDbType.Int, 32);
            return rtGhiNhanChiTiet_ID;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiNhanChiTiet_ID", mvarGhiNhanChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiNhan_ID", mvarGhiNhan_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLe", mvarTyLe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri", mvarGiaTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDRef", mvarIDRef);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong", mvarSoLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Loai_IDRef", mvarLoai_IDRef);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiDung_ID", mvarNoiDung_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiNoiDung", mvarLoaiNoiDung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriGhiNhan_ChenhLech", mvarGiaTriGhiNhan_ChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriGhiNhan_HoTroChenhLech", mvarGiaTriGhiNhan_HoTroChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriGhiNhan_CoPhan", mvarGiaTriGhiNhan_CoPhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia", mvarLoaiGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThanhToan_ChenhLech", mvarGiaTriThanhToan_ChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThanhToan_HoTroChenhLech", mvarGiaTriThanhToan_HoTroChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThanhToan_CoPhan", mvarGiaTriThanhToan_CoPhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThu", mvarDonGiaDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTro", mvarDonGiaHoTro);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaBHTN", mvarDonGiaBHTN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);

            ThuVien.mySQL.ExcSP(sp_GHINHANBHTNCHITIET, listPara);
            return mvarGhiNhanChiTiet_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiNhanChiTiet_ID", mvarGhiNhanChiTiet_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_GHINHANBHTNCHITIET, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void GetListGhiNhan(GridControl grv, int ghiNhan_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetListData_ChiTiet");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiNhan_ID", ghiNhan_Id);

            Common.clsControl.LoadGirdControl_Y(grv, sp_GHINHANBHTNCHITIET, listPara);
        }
    }
}
