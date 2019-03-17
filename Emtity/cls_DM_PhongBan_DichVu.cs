using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
   public class cls_DM_PhongBan_DichVu
    {
        #region "Constants"
        private const string sp_DM_PhongBan_DichVu = "sp_DM_PhongBan_DichVu";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarPhongBan_DichVu_Id { get; set; }
        public System.Int32 mvarPhongBan_Id { get; set; }
        public System.Int32 mvarDichVu_Id { get; set; }
        public System.Int32 mvarChiPhi { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_DM_PhongBan_DichVu()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_DM_PhongBan_DichVu(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_DM_PhongBan_DichVu(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_DM_PhongBan_DichVu(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarPhongBan_DichVu_Id = int.MinValue;
            mvarPhongBan_Id = int.MinValue;
            mvarDichVu_Id = int.MinValue;
            mvarChiPhi = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarPhongBan_DichVu_Id = Common.clsControl.IsNullOrEmpty(row["PhongBan_DichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhongBan_DichVu_Id"]);
            mvarPhongBan_Id = Common.clsControl.IsNullOrEmpty(row["PhongBan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhongBan_Id"]);
            mvarDichVu_Id = Common.clsControl.IsNullOrEmpty(row["DichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DichVu_Id"]);
            mvarChiPhi = Common.clsControl.IsNullOrEmpty(row["ChiPhi"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChiPhi"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
        }
        public string Add()
        {
            string rtPhongBan_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", mvarDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChiPhi", mvarChiPhi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);

            rtPhongBan_Id = ThuVien.mySQL.ExcSP(sp_DM_PhongBan_DichVu, listPara, "@PhongBan_DichVu_Id", SqlDbType.Int, 32);
            return rtPhongBan_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_DichVu_Id", mvarPhongBan_DichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", mvarDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChiPhi", mvarChiPhi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.ExcSP(sp_DM_PhongBan_DichVu, listPara);
            return mvarPhongBan_DichVu_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_DichVu_Id", mvarPhongBan_DichVu_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_DM_PhongBan_DichVu, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public DataRow Get_PhongBan_DichVu(int DV_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetPhongBan_By_DichVu");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", DV_Id);

                return ThuVien.mySQL.RtDataRowSP(sp_DM_PhongBan_DichVu, listPara);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
    }
}
