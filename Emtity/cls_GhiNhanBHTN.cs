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
    public class cls_GhiNhanBHTN
    {
        #region "Constants"
        private const string sp_GhiNhanBHTN = "sp_GhiNhanBHTN";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarGhiNhan_Id { get; set; }
        public System.String mvarSoPhieuGhiNhan { get; set; }
        public System.Int32 mvarTiepNhan_ID { get; set; }
        public System.Int32 mvarBenhNhan_Id { get; set; }
        public System.Int32 mvarCongTy_ID { get; set; }
        public System.String mvarSoTheBHTN { get; set; }
        public System.Decimal mvarGiaTri { get; set; }
        public System.DateTime mvarNgayLap { get; set; }
        public System.Int32 mvarNguoiLap_Id { get; set; }
        public System.String mvarGhiChu { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.DateTime mvarThoiGianLap { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_GhiNhanBHTN()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_GhiNhanBHTN(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_GhiNhanBHTN(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_GhiNhanBHTN(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarGhiNhan_Id = int.MinValue;
            mvarSoPhieuGhiNhan = String.Empty;
           
            mvarTiepNhan_ID = int.MinValue;
            mvarBenhNhan_Id = int.MinValue;
            mvarCongTy_ID = int.MinValue;
            mvarSoTheBHTN = String.Empty;
            mvarGiaTri = decimal.MinValue;
            mvarNgayLap = DateTime.MinValue;
            mvarNguoiLap_Id = int.MinValue;
            mvarGhiChu = String.Empty;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarThoiGianLap = DateTime.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarGhiNhan_Id = Common.clsControl.IsNullOrEmpty(row["GhiNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GhiNhan_Id"]);
            mvarSoPhieuGhiNhan = Common.clsControl.getValueInRow<string>(row["SoPhieuGhiNhan"]);
            mvarTiepNhan_ID = Common.clsControl.IsNullOrEmpty(row["TiepNhan_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhan_ID"]);
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarCongTy_ID = Common.clsControl.IsNullOrEmpty(row["CongTy_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CongTy_ID"]);
            mvarSoTheBHTN = Common.clsControl.getValueInRow<string>(row["SoTheBHTN"]);
            mvarGiaTri = Common.clsControl.IsNullOrEmpty(row["GiaTri"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTri"]);
            mvarNgayLap = Common.clsControl.IsNullOrEmpty(row["NgayLap"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayLap"]);
            mvarNguoiLap_Id = Common.clsControl.IsNullOrEmpty(row["NguoiLap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiLap_Id"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarThoiGianLap = Common.clsControl.IsNullOrEmpty(row["ThoiGianLap"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianLap"]);
        }

        public string Add()
        {
            string rtGhiNhan_ID = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhieuGhiNhan", mvarSoPhieuGhiNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CongTy_ID", mvarCongTy_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTheBHTN", mvarSoTheBHTN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri", mvarGiaTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayLap", mvarNgayLap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLap_Id", mvarNguoiLap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianLap", mvarThoiGianLap);

            rtGhiNhan_ID = ThuVien.mySQL.ExcSP(sp_GhiNhanBHTN, listPara, "@GhiNhan_ID", SqlDbType.Int, 32);
            return rtGhiNhan_ID;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiNhan_ID", mvarGhiNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhieuGhiNhan", mvarSoPhieuGhiNhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CongTy_ID", mvarCongTy_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoTheBHTN", mvarSoTheBHTN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri", mvarGiaTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayLap", mvarNgayLap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLap_Id", mvarNguoiLap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianLap", mvarThoiGianLap);

            ThuVien.mySQL.ExcSP(sp_GhiNhanBHTN, listPara);
            return mvarGhiNhan_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiNhan_ID", mvarGhiNhan_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_GhiNhanBHTN, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public bool Get_By_Key(int ghiNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiNhan_Id", ghiNhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(sp_GhiNhanBHTN, listPara);
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
    }
}
