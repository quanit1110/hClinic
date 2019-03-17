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
    public class cls_Groups
    {
        #region "Constants"
        private const String spu_Sys_Group = "spu_Sys_Groups";
        #endregion
        # region "Member Variables"
        public System.Int32 mvarGroup_Id { get; set; }
        public System.String mvarGroup_Code { get; set; }
        public System.String mvarGroup_Name { get; set; }
        public System.String mvarLanguage_Id { get; set; }
        public System.Int32 mvarDomain_Id { get; set; }
        public System.Boolean mvarAdmin { get; set; }
        public System.Boolean mvarDefaultGroup { get; set; }
        public System.Int32 mvarMember { get; set; }
        public System.String mvarDescription { get; set; }
        public System.DateTime mvarCreation_Date { get; set; }
        public System.Int32 mvarCreated_By { get; set; }
        public System.DateTime mvarLast_Update_Date { get; set; }
        public System.Int32 mvarLast_Updated_By { get; set; }
        public System.String mvarLatin_Name { get; set; }
        #endregion

        private DataSet m_Dal;
        #region Contructor
        public cls_Groups()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_Groups(DataSet dal)
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
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Code", mvarGroup_Code);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Name", mvarGroup_Name);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Language_Id", mvarLanguage_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Domain_Id", mvarDomain_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Admin", mvarAdmin);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DefaultGroup", mvarDefaultGroup);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Member", mvarMember);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Description", mvarDescription);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Creation_Date", mvarCreation_Date);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Created_By", mvarCreated_By);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Update_Date", mvarLast_Update_Date);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Updated_By", mvarLast_Updated_By);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Latin_Name", mvarLatin_Name);

            rtGroups_Id = ThuVien.mySQL.ExcSP(spu_Sys_Group, listPara, "@Group_Id", SqlDbType.Int, 32);
            return rtGroups_Id;
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Id", mvarGroup_Id);
            string rt = ThuVien.mySQL.ExcSP(spu_Sys_Group, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public void Reset()
        {
            mvarGroup_Code = String.Empty;
            mvarGroup_Code = String.Empty;
            mvarGroup_Name = String.Empty;
            mvarLanguage_Id = String.Empty;
            mvarDomain_Id = int.MinValue;
            mvarAdmin = false;
            mvarDefaultGroup = false;
            mvarMember = int.MinValue;
            mvarDescription = String.Empty;
            mvarCreation_Date = DateTime.MinValue;
            mvarCreated_By = int.MinValue;
            mvarLast_Update_Date = DateTime.MinValue;
            mvarLast_Updated_By = int.MinValue;
            mvarLatin_Name = String.Empty;

        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Id", mvarGroup_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Code", mvarGroup_Code);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Name", mvarGroup_Name);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Language_Id", mvarLanguage_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Domain_Id", mvarDomain_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Admin", mvarAdmin);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DefaultGroup", mvarDefaultGroup);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Member", mvarMember);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Description", mvarDescription);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Creation_Date", mvarCreation_Date);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Created_By", mvarCreated_By);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Update_Date", mvarLast_Update_Date);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Updated_By", mvarLast_Updated_By);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Latin_Name", mvarLatin_Name);

            ThuVien.mySQL.ExcSP(spu_Sys_Group, listPara);
            return mvarGroup_Id.ToString();
        }

        public void FillData(DataRow row)
        {
            mvarGroup_Id = Common.clsControl.IsNullOrEmpty(row["Group_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Group_Id"]);
            mvarGroup_Code = Common.clsControl.getValueInRow<string>(row["Group_Code"]);
            mvarGroup_Name = Common.clsControl.getValueInRow<string>(row["Group_Name"]);
            mvarLanguage_Id = Common.clsControl.getValueInRow<string>(row["Language_Id"]);
            mvarDomain_Id = Common.clsControl.IsNullOrEmpty(row["Domain_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Domain_Id"]);
            mvarAdmin = Common.clsControl.IsNullOrEmpty(row["Admin"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Admin"]); ;
            mvarDefaultGroup = Common.clsControl.IsNullOrEmpty(row["DefaultGroup"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DefaultGroup"]);
            mvarMember = Common.clsControl.IsNullOrEmpty(row["Member"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Member"]);
            mvarDescription = Common.clsControl.getValueInRow<string>(row["Description"]);
            mvarCreation_Date = Common.clsControl.IsNullOrEmpty(row["Creation_Date"].ToString().ToArray()) ? DateTime.Now : Common.clsControl.getValueInRow<DateTime>(row["Creation_Date"]);
            mvarCreated_By = Common.clsControl.IsNullOrEmpty(row["Created_By"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Created_By"]);
            mvarLast_Update_Date = Common.clsControl.IsNullOrEmpty(row["Last_Update_Date"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Last_Update_Date"]);
            mvarLast_Updated_By = Common.clsControl.IsNullOrEmpty(row["Last_Updated_By"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Last_Updated_By"]);
            mvarLatin_Name = Common.clsControl.getValueInRow<string>(row["Latin_Name"]);
        }

        public void FillDataForGridView(DataRow row)
        {
            mvarGroup_Id = Common.clsControl.IsNullOrEmpty(row["Group_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Group_Id"]);
            mvarGroup_Code = Common.clsControl.getValueInRow<string>(row["Group_Code"]);
            mvarGroup_Name = Common.clsControl.getValueInRow<string>(row["Group_Name"]);
            mvarLanguage_Id = Common.clsControl.getValueInRow<string>(row["Language_Id"]);
            mvarDomain_Id = Common.clsControl.IsNullOrEmpty(row["Domain_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Domain_Id"]);
            mvarAdmin = Common.clsControl.IsNullOrEmpty(row["Admin"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Admin"]); ;
            mvarDefaultGroup = Common.clsControl.IsNullOrEmpty(row["DefaultGroup"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["DefaultGroup"]);
            mvarMember = Common.clsControl.IsNullOrEmpty(row["Member"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Member"]);
            mvarDescription = Common.clsControl.getValueInRow<string>(row["Description"]);
            mvarCreation_Date = Common.clsControl.IsNullOrEmpty(row["Creation_Date"].ToString().ToArray()) ? DateTime.Now : Common.clsControl.getValueInRow<DateTime>(row["Creation_Date"]);
            mvarCreated_By = Common.clsControl.IsNullOrEmpty(row["Created_By"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Created_By"]);
            mvarLast_Update_Date = Common.clsControl.IsNullOrEmpty(row["Last_Update_Date"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Last_Update_Date"]);
            mvarLast_Updated_By = Common.clsControl.IsNullOrEmpty(row["Last_Updated_By"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Last_Updated_By"]);
            mvarLatin_Name = Common.clsControl.getValueInRow<string>(row["Latin_Name"]);
        }

        public bool checkGroupCodeExists(string Group_Code)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "getGroupCode");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Code", Group_Code);
                ds = ThuVien.mySQL.ExcDataSet(spu_Sys_Group, listPara);
                Reset();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }               
            }
            catch (Exception ex)
            {        
            }
            return false;
        }

        public string getGroupId(string groupCode)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "getGroupIdByGroupCode");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Code", groupCode);
            string rtGroups_Id = ThuVien.mySQL.ExcSP(spu_Sys_Group, listPara, "@Group_Id", SqlDbType.Int, 32);
            return rtGroups_Id;
        }

        public bool Get_By_Key(string key)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "getGroupCode");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Code", key);
                ds = ThuVien.mySQL.ExcDataSet("spu_Sys_Groups", listPara);
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
    }
}
