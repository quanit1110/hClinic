using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    class Cls_ChungTu_PhieuLinhDuoc
    {
        #region "Constants"
        private const string sp_ChungTu_PhieuLinhDuoc = "sp_ChungTu_PhieuLinhDuoc";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarChungTu_Id { get; set; }
        public System.Int32 mvarPhieuLinh_Id { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public Cls_ChungTu_PhieuLinhDuoc()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public Cls_ChungTu_PhieuLinhDuoc(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public Cls_ChungTu_PhieuLinhDuoc(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public Cls_ChungTu_PhieuLinhDuoc(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarChungTu_Id = int.MinValue;
            mvarPhieuLinh_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarChungTu_Id = Common.clsControl.IsNullOrEmpty(row["ChungTu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTu_Id"]);
            mvarPhieuLinh_Id = Common.clsControl.IsNullOrEmpty(row["PhieuLinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhieuLinh_Id"]);
        }
        public string Add()
        {
            string rtChungTu_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhieuLinh_Id", mvarPhieuLinh_Id);

            rtChungTu_Id = ThuVien.mySQL.ExcSP(sp_ChungTu_PhieuLinhDuoc, listPara, "@ChungTu_Id", SqlDbType.Int, 32);
            return rtChungTu_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", mvarChungTu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhieuLinh_Id", mvarPhieuLinh_Id);

            ThuVien.mySQL.ExcSP(sp_ChungTu_PhieuLinhDuoc, listPara);
            return mvarChungTu_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTu_Id", mvarChungTu_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_ChungTu_PhieuLinhDuoc, listPara);
            if (rt == "err") { return false; }
            return true;
        }
    }
}
