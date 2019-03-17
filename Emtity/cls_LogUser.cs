using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class cls_LogUser
    {
        #region "Constants"
        private const String spu_Sys_LogUser = "spu_Sys_LogUser";
        #endregion

        #region "Member Variables"
        public System.Int32 mvarLog_Id { get; set; }
        public System.Int32 mvarUser_Id { get; set; }
        public System.Int32 mvarMenu_Id { get; set; }
        public System.String mvarNameMenu { get; set; }
        public System.DateTime mvarTime_Login { get; set; }
        public System.DateTime mvarTime_logout { get; set; }
        public System.Boolean mvarAdd_New { get; set; }
        public System.Boolean mvarDelete_Value { get; set; }
        public System.Boolean mvarEdit_Value { get; set; }
        #endregion

        private DataSet m_Dal;
        #region Contructor
        public cls_LogUser()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_LogUser(DataSet dal)
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
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Id", mvarUser_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Menu_Id", mvarMenu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NameMenu", mvarNameMenu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Time_Login", mvarTime_Login);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Time_logout", mvarTime_logout);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Add_New", mvarAdd_New);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Delete_Value", mvarDelete_Value);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Edit_Value", mvarEdit_Value);

            rtGroups_Id = ThuVien.mySQL.ExcSP(spu_Sys_LogUser, listPara, "@Log_Id", SqlDbType.Int, 32);
            return rtGroups_Id;
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Log_Id", mvarLog_Id);
            string rt = ThuVien.mySQL.ExcSP(spu_Sys_LogUser, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public void Reset()
        {
            mvarLog_Id =	int.MinValue;
            mvarUser_Id	= int.MinValue;
            mvarMenu_Id =	int.MinValue;
            mvarNameMenu  = String.Empty;
            mvarTime_Login= DateTime.MinValue;
            mvarTime_logout= DateTime.MinValue;
            mvarAdd_New = false;
            mvarDelete_Value = false;
            mvarEdit_Value = false;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Log_Id", mvarLog_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Id", mvarUser_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Menu_Id", mvarMenu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NameMenu", mvarNameMenu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Time_Login", mvarTime_Login);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Time_logout", mvarTime_logout);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Add_New", mvarAdd_New);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Delete_Value", mvarDelete_Value);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Edit_Value", mvarEdit_Value);

            ThuVien.mySQL.ExcSP(spu_Sys_LogUser, listPara);
            return mvarLog_Id.ToString();
        }

        public void FillData(DataRow row)
        {
            mvarLog_Id = Common.clsControl.IsNullOrEmpty(row["Log_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Log_Id"]);
            mvarUser_Id = Common.clsControl.IsNullOrEmpty(row["User_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["User_Id"]);
            mvarMenu_Id = Common.clsControl.IsNullOrEmpty(row["Menu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Menu_Id"]);
            mvarNameMenu = Common.clsControl.getValueInRow<string>(row["NameMenu"]);
            mvarTime_Login = Common.clsControl.IsNullOrEmpty(row["Time_Login"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Time_Login"]);
            mvarTime_logout = Common.clsControl.IsNullOrEmpty(row["Time_logout"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Time_logout"]);
            mvarAdd_New = Common.clsControl.IsNullOrEmpty(row["Add_New"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Add_New"]);
            mvarDelete_Value = Common.clsControl.IsNullOrEmpty(row["Delete_Value"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Delete_Value"]);
            mvarEdit_Value = Common.clsControl.IsNullOrEmpty(row["Edit_Value"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Edit_Value"]);
        }

    }
}
