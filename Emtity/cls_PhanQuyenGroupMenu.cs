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
    public class cls_PhanQuyenGroupMenu
    {
        #region "Constants"
        private const String spu_Sys_GroupMenu = "spu_Sys_GroupMenu";
        #endregion
        # region "Member Variables"
        public System.Int32 mvarGroup_Id { get; set; }
        public System.Int32 mvarMenu_Id { get; set; }
        public System.Boolean mvarEnable { get; set; }
        public System.Boolean mvarVisible { get; set; }
        public System.Boolean mvarAdd_New { get; set; }
        public System.Boolean mvarDelete_Value { get; set; }
        public System.Boolean mvarEdit_Value { get; set; }
        #endregion


        private DataSet m_Dal;

        public cls_PhanQuyenGroupMenu()
        {
            m_Dal = new DataSet();
            Reset();
        }

        public cls_PhanQuyenGroupMenu(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }

        public void AddOrUpdate(string nameAction)
        {

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", nameAction);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Id",       mvarGroup_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Menu_Id",        mvarMenu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Enable",         mvarEnable);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Visible",        mvarVisible);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Add_New",        mvarAdd_New);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Delete_Value",   mvarDelete_Value);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Edit_Value",     mvarEdit_Value);


            SqlConnection SQLcon = ThuVien.mySQL.Conn();
            SqlCommand cmd;

            try
            {
                using (cmd = new SqlCommand(spu_Sys_GroupMenu, SQLcon))
                    cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < listPara.Count; i++) { cmd.Parameters.Add(listPara[i]); }
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
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Id", mvarGroup_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Menu_Id", mvarMenu_Id);
            string rt = ThuVien.mySQL.ExcSP(spu_Sys_GroupMenu, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public void Reset()
        {
            mvarGroup_Id = int.MinValue;
            mvarMenu_Id = int.MinValue;
            mvarEnable = false;
            mvarVisible = true;
            mvarAdd_New = false;
            mvarDelete_Value = false;
            mvarEdit_Value = false;

        }

        //public void Update()
        //{
        //    List<SqlParameter> listPara = new List<SqlParameter>();
        //    ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            
        //    ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Id", mvarGroup_Id);
        //    ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Menu_Id", mvarMenu_Id);
        //    ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Enable", mvarEnable);
        //    ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Visible", mvarVisible);
        //    ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Add_New", mvarAdd_New);
        //    ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Delete_Value", mvarDelete_Value);
        //    ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Edit_Value", mvarEdit_Value);

        //    ThuVien.mySQL.ExcSP(spu_Sys_GroupMenu, listPara);
        //    //return mvarGroup_Id.ToString();
        //}

        public void FillData(DataRow row)
        {
            mvarGroup_Id = Common.clsControl.IsNullOrEmpty(row["Group_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Group_Id"]);
            mvarMenu_Id = Common.clsControl.IsNullOrEmpty(row["Menu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Menu_Id"]);
            mvarEnable = Common.clsControl.IsNullOrEmpty(row["Enable"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Enable"]);
            mvarVisible = Common.clsControl.IsNullOrEmpty(row["Visible"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Visible"]);
            mvarAdd_New = Common.clsControl.IsNullOrEmpty(row["Add_New"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Add_New"]);
            mvarDelete_Value = Common.clsControl.IsNullOrEmpty(row["Delete_Value"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Delete_Value"]);
            mvarEdit_Value = Common.clsControl.IsNullOrEmpty(row["Edit_Value"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Edit_Value"]);
        }

        public void FillDataCheck(DataRow row)
        {
            //mvarGroup_Id = Common.clsControl.IsNullOrEmpty(row["Group_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Group_Id"]);
            //mvarMenu_Id = Common.clsControl.IsNullOrEmpty(row["Menu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Menu_Id"]);
            mvarEnable = Common.clsControl.IsNullOrEmpty(row["Enable"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Enable"]);
            mvarVisible = Common.clsControl.IsNullOrEmpty(row["Visible"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Visible"]);
            mvarAdd_New = Common.clsControl.IsNullOrEmpty(row["Add_New"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Add_New"]);
            mvarDelete_Value = Common.clsControl.IsNullOrEmpty(row["Delete_Value"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Delete_Value"]);
            mvarEdit_Value = Common.clsControl.IsNullOrEmpty(row["Edit_Value"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Edit_Value"]);
        }

        public string getMenuByGroupId(string groupId)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "getMenuGroupById");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Id", groupId);
            string rtGroups_Id = ThuVien.mySQL.ExcSP(spu_Sys_GroupMenu, listPara, "@Group_Id", SqlDbType.Int, 32);
            return rtGroups_Id;
        }

        public DataRow getDoiTuong(int groupId)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "getMenuGroupById");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Id", groupId);
            return ThuVien.mySQL.RtDataRowSP(spu_Sys_GroupMenu, listPara);
        }

        public DataRow getObjectGroupMenu(int groupId, int menuId)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "getAllByGroupIdAndMenuId");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Group_Id", groupId);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Menu_Id", menuId);
            return ThuVien.mySQL.RtDataRowSP(spu_Sys_GroupMenu, listPara);
        }
    }
}
