using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class cls_Menu
    {

        #region "Constants"
        private const String spu_Sys_Menu = "spu_Sys_Menu";
        #endregion

        #region "Member Variables"
        public System.Int32 mvarId { get; set; }
        public System.String mvarMenuName { get; set; }
        public System.Int32 mvarParentID { get; set; }
        public System.String mvarDescription { get; set; }
        public System.String mvarURL { get; set; }
        public System.Int32 mvarIsEnable { get; set; }
        public System.Int32 mvarIsVisible { get; set; }
        public System.Int32 mvarSeparator { get; set; }
        public System.String mvarProject { get; set; }
        #endregion

        private DataSet m_Dal;
        #region Contructor
        public cls_Menu()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_Menu(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        #endregion

        public string Add()
        {
            string rtGroups_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MenuName", mvarMenuName);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ParentID", mvarParentID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Description", mvarDescription);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@URL", mvarURL);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IsEnable", mvarIsEnable);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IsVisible", mvarIsVisible);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Separator", mvarSeparator);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Project", mvarProject);

            rtGroups_Id = ThuVien.mySQL.ExcSP(spu_Sys_Menu, listPara, "@Id", SqlDbType.Int, 32);
            return rtGroups_Id;
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Id", mvarId);
            string rt = ThuVien.mySQL.ExcSP(spu_Sys_Menu, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public void Reset()
        {
            mvarId = int.MinValue;
            mvarMenuName = String.Empty;
            mvarParentID = int.MinValue;
            mvarDescription = String.Empty;
            mvarURL = String.Empty;
            mvarIsEnable = int.MinValue;
            mvarIsVisible = int.MinValue;
            mvarSeparator = int.MinValue;
            mvarProject = String.Empty;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Id", mvarId);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MenuName", mvarMenuName);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ParentID", mvarParentID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Description", mvarDescription);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@URL", mvarURL);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IsEnable", mvarIsEnable);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IsVisible", mvarIsVisible);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Separator", mvarSeparator);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Project", mvarProject);

            ThuVien.mySQL.ExcSP(spu_Sys_Menu, listPara);
            return mvarId.ToString();
        }

        public void FillData(DataRow row)
        {
            mvarId = Common.clsControl.IsNullOrEmpty(row["Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Id"]);
            mvarMenuName = Common.clsControl.getValueInRow<string>(row["MenuName"]);
            mvarParentID = Common.clsControl.IsNullOrEmpty(row["ParentID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ParentID"]);
            mvarDescription = Common.clsControl.getValueInRow<string>(row["Description"]);
            mvarURL = Common.clsControl.getValueInRow<string>(row["URL"]);
            mvarIsEnable = Common.clsControl.IsNullOrEmpty(row["IsEnable"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["IsEnable"]);
            mvarIsVisible = Common.clsControl.IsNullOrEmpty(row["IsVisible"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["IsVisible"]);
            mvarSeparator = Common.clsControl.IsNullOrEmpty(row["Separator"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Separator"]);
            mvarProject = Common.clsControl.getValueInRow<string>(row["Project"]);
        }

        public DataRow getDoiTuong(string MenuName)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MenuName", MenuName);
            return ThuVien.mySQL.RtDataRowSP(spu_Sys_Menu, listPara);
        }
    }
}
