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
    public class cls_UserGroup
    {
        #region "Constants"
        private const String spu_Sys_saveUserGroup = "spu_Sys_UserGroup";
        #endregion

        # region "Member Variables"
        public System.Int32 mvarUser_Id { get; set; }
        public System.Int32 mvarGroup_Id { get; set; }
        #endregion

        private DataSet m_Dal;
        #region Contructor
        public cls_UserGroup()
        {
            m_Dal = new DataSet();
            Reset();
        }
        #endregion
        public void AddOrUpdate(string nameAction)
        {
            List<SqlParameter> lisPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref lisPara, "@Action", nameAction);
            ThuVien.mySQL.AddListParaWithNullValue(ref lisPara, "@User_Id", mvarUser_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref lisPara, "@Group_Id", mvarGroup_Id);

            SqlConnection SQLcon = ThuVien.mySQL.Conn();
            SqlCommand cmd;

            try
            {
                using (cmd = new SqlCommand(spu_Sys_saveUserGroup, SQLcon))
                    cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < lisPara.Count; i++) { cmd.Parameters.Add(lisPara[i]); }
                    cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SQLcon.Close();
            }

            //ThuVien.mySQL.ExcSP(spu_Sys_saveUserGroup, listPara, "@Group_Id", SqlDbType.Int, 32);
        }


        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Id", mvarUser_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Id", mvarGroup_Id);
            string rt = ThuVien.mySQL.ExcSP(spu_Sys_saveUserGroup, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void Reset()
        {
            mvarUser_Id = int.MinValue;
            mvarGroup_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarUser_Id = Common.clsControl.IsNullOrEmpty(row["User_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["User_Id"]);
            mvarGroup_Id = Common.clsControl.IsNullOrEmpty(row["Group_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Group_Id"]);
        }

        public string getGroupId(string User_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Id", User_Id);
            string rtGroups_Id = ThuVien.mySQL.ExcSP(spu_Sys_saveUserGroup, listPara, "@Group_Id", SqlDbType.Int, 32);
            return rtGroups_Id;
        }

        public DataRow getDoiTuong(string User_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Id", User_Id);
            return ThuVien.mySQL.RtDataRowSP(spu_Sys_saveUserGroup, listPara);
        }
    }
}
