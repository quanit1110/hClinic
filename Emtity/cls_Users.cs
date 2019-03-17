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
    public class cls_Users
    {
        #region "Constants"
        private const String spu_Sys_Users = "spu_Sys_Users";
        //private const String SP_GetSoVaoVien = "GetSoTangDan";
        #endregion
        # region "Member Variables"
        public System.Int32 User_Id { get; set; }
        public System.String User_Code { get; set; }
        public System.String User_Name { get; set; }
        public System.String Language_Id { get; set; }
        public System.Int32 Domain_Id { get; set; }
        public System.String User_Password { get; set; }
        public System.Boolean Suspend { get; set; }
        public System.String User_Position { get; set; }
        public System.Boolean Allow_Change_Password { get; set; }
        public System.Int32 Expiration_Days { get; set; }
        public System.DateTime Expiration_Date { get; set; }
        public System.Boolean Encryption_Password { get; set; }
        public System.String EmailAddress { get; set; }
        public System.String PhoneNumber { get; set; }
        public System.String FaxNumber { get; set; }
        public System.DateTime Creation_Date { get; set; }
        public System.Int32 Created_By { get; set; }
        public System.DateTime Last_Update_Date { get; set; }
        public System.Int32 Last_Updated_By { get; set; }
        public System.DateTime Login_Time { get; set; }
        public System.String Login_Hostname { get; set; }
        public System.Boolean IsLogin { get; set; }
        public System.DateTime Last_Login_Time { get; set; }
        public System.String Last_Login_Hostname { get; set; }
        public System.Int32 MinPasswordLen { get; set; }
        public System.Boolean StrongPassword { get; set; }
        public System.Boolean Change_Password { get; set; }
        public System.String Latin_Name { get; set; }
        public System.String UserOption1 { get; set; }
        public System.String UserOption2 { get; set; }
        public System.String UserOption3 { get; set; }
        public System.String UserOption4 { get; set; }
        public System.String UserOption5 { get; set; }
        public System.String UserOption6 { get; set; }
        public System.String UserOption7 { get; set; }
        public System.String UserOption8 { get; set; }
        public System.String UserOption9 { get; set; }
        #endregion
        private DataSet m_Dal;
        #region Contructor
        public cls_Users()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_Users(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        
        #endregion
        public string Add()
        {
            string rtUser_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Code", User_Code);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Name", User_Name);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Language_Id", Language_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Domain_Id", Domain_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Password", User_Password);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Suspend", Suspend);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Position", User_Position);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Allow_Change_Password", Allow_Change_Password);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Expiration_Days", Expiration_Days);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Expiration_Date", Expiration_Date);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Encryption_Password", Encryption_Password);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@EmailAddress", EmailAddress);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhoneNumber", PhoneNumber);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@FaxNumber", FaxNumber);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Creation_Date", Creation_Date);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Created_By", Created_By);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Update_Date", Last_Update_Date);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Updated_By", Last_Updated_By);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Login_Time", Login_Time);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Login_Hostname", Login_Hostname);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IsLogin", IsLogin);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Login_Time", Last_Login_Time);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Login_Hostname", Last_Login_Hostname);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MinPasswordLen", MinPasswordLen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@StrongPassword", StrongPassword);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Latin_Name", Latin_Name);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Change_Password", Change_Password);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption1", UserOption1);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption2", UserOption2);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption3", UserOption3);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption4", UserOption4);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption5", UserOption5);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption6", UserOption6);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption7", UserOption7);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption8", UserOption8);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption9", UserOption9);

            rtUser_Id = ThuVien.mySQL.ExcSP(spu_Sys_Users, listPara, "@User_Id", SqlDbType.Int, 32);
            return rtUser_Id;
        }
        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Id", User_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Code", User_Code);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Name", User_Name);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Language_Id", Language_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Domain_Id", Domain_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Password", User_Password);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Suspend", Suspend);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Position", User_Position);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Allow_Change_Password", Allow_Change_Password);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Expiration_Days", Expiration_Days);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Expiration_Date", Expiration_Date);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Encryption_Password", Encryption_Password);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@EmailAddress", EmailAddress);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhoneNumber", PhoneNumber);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@FaxNumber", FaxNumber);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Creation_Date", Creation_Date);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Created_By", Created_By);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Update_Date", Last_Update_Date);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Updated_By", Last_Updated_By);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Login_Time", Login_Time);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Login_Hostname", Login_Hostname);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IsLogin", IsLogin);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Login_Time", Last_Login_Time);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Last_Login_Hostname", Last_Login_Hostname);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MinPasswordLen", MinPasswordLen);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@StrongPassword", StrongPassword);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Latin_Name", Latin_Name);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Change_Password", Change_Password);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption1", UserOption1);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption2", UserOption2);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption3", UserOption3);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption4", UserOption4);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption5", UserOption5);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption6", UserOption6);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption7", UserOption7);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption8", UserOption8);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@UserOption9", UserOption9);

            ThuVien.mySQL.ExcSP(spu_Sys_Users, listPara);
            return User_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Id", User_Id);
            string rt = ThuVien.mySQL.ExcSP(spu_Sys_Users, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void Reset()
        {
            User_Id = int.MinValue;
            User_Code = String.Empty;
            User_Name = String.Empty;
            Language_Id = String.Empty;
            Domain_Id = int.MinValue;
            User_Password = String.Empty;
            Suspend = false;
            User_Position = String.Empty;
            Allow_Change_Password = false;
            Expiration_Days = int.MinValue;
            Expiration_Date = DateTime.MinValue;
            Encryption_Password = false;
            EmailAddress = String.Empty;
            PhoneNumber = String.Empty;
            FaxNumber = String.Empty;
            Creation_Date = DateTime.MinValue;
            Created_By = int.MinValue;
            Last_Update_Date = DateTime.MinValue;
            Last_Updated_By = int.MinValue;
            Login_Time = DateTime.MinValue;
            Login_Hostname = String.Empty;
            IsLogin = false;
            Last_Login_Time = DateTime.MinValue;
            Last_Login_Hostname = String.Empty;
            MinPasswordLen = int.MinValue;
            StrongPassword = false;
            Latin_Name = String.Empty;
            Change_Password = false;
            UserOption1 = String.Empty;
            UserOption2 = String.Empty;
            UserOption3 = String.Empty;
            UserOption4 = String.Empty;
            UserOption5 = String.Empty;
            UserOption6 = String.Empty;
            UserOption7 = String.Empty;
            UserOption8 = String.Empty;
            UserOption9 = String.Empty;

        }
        public void FillData(DataRow row)
        {
            User_Id = Common.clsControl.IsNullOrEmpty(row["User_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["User_Id"]);
            User_Code = Common.clsControl.getValueInRow<string>(row["User_Code"]);
            User_Name = Common.clsControl.getValueInRow<string>(row["User_Name"]);
            Language_Id = Common.clsControl.getValueInRow<string>(row["Language_Id"]);
            Domain_Id = Common.clsControl.IsNullOrEmpty(row["Domain_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Domain_Id"]);
            User_Password = Common.clsControl.getValueInRow<string>(row["User_Password"]);
            Suspend = Common.clsControl.IsNullOrEmpty(row["Suspend"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Suspend"]);
            User_Position = Common.clsControl.getValueInRow<string>(row["User_Position"]);
            Allow_Change_Password = Common.clsControl.IsNullOrEmpty(row["Allow_Change_Password"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Allow_Change_Password"]);
            Expiration_Days = Common.clsControl.IsNullOrEmpty(row["Expiration_Days"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Expiration_Days"]);
            Expiration_Date = Common.clsControl.IsNullOrEmpty(row["Expiration_Date"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Expiration_Date"]);
            Encryption_Password = Common.clsControl.IsNullOrEmpty(row["Encryption_Password"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Encryption_Password"]);
            EmailAddress = Common.clsControl.getValueInRow<string>(row["EmailAddress"]);
            PhoneNumber = Common.clsControl.getValueInRow<string>(row["PhoneNumber"]);
            FaxNumber = Common.clsControl.getValueInRow<string>(row["FaxNumber"]);
            Creation_Date = Common.clsControl.IsNullOrEmpty(row["Creation_Date"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Creation_Date"]);
            Created_By = Common.clsControl.IsNullOrEmpty(row["Created_By"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Created_By"]);
            Last_Update_Date = Common.clsControl.IsNullOrEmpty(row["Last_Update_Date"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Last_Update_Date"]);
            Last_Updated_By = Common.clsControl.IsNullOrEmpty(row["Last_Updated_By"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Last_Updated_By"]);
            Login_Time = Common.clsControl.IsNullOrEmpty(row["Login_Time"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Login_Time"]);
            Login_Hostname = Common.clsControl.getValueInRow<string>(row["Login_Hostname"]);
            IsLogin = Common.clsControl.IsNullOrEmpty(row["IsLogin"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["IsLogin"]);
            Last_Login_Time = Common.clsControl.IsNullOrEmpty(row["Last_Login_Time"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Last_Login_Time"]);
            Last_Login_Hostname = Common.clsControl.getValueInRow<string>(row["Last_Login_Hostname"]);
            MinPasswordLen = Common.clsControl.IsNullOrEmpty(row["MinPasswordLen"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["MinPasswordLen"]);
            StrongPassword = Common.clsControl.IsNullOrEmpty(row["StrongPassword"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["StrongPassword"]);
            Latin_Name = Common.clsControl.getValueInRow<string>(row["Latin_Name"]);
            Change_Password = Common.clsControl.IsNullOrEmpty(row["Change_Password"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Change_Password"]);
            UserOption1 = Common.clsControl.getValueInRow<string>(row["UserOption1"]);
            UserOption2 = Common.clsControl.getValueInRow<string>(row["UserOption2"]);
            UserOption3 = Common.clsControl.getValueInRow<string>(row["UserOption3"]);
            UserOption4 = Common.clsControl.getValueInRow<string>(row["UserOption4"]);
            UserOption5 = Common.clsControl.getValueInRow<string>(row["UserOption5"]);
            UserOption6 = Common.clsControl.getValueInRow<string>(row["UserOption6"]);
            UserOption7 = Common.clsControl.getValueInRow<string>(row["UserOption7"]);
            UserOption8 = Common.clsControl.getValueInRow<string>(row["UserOption8"]);
            UserOption9 = Common.clsControl.getValueInRow<string>(row["UserOption9"]);
        }


        public void FillDataForGridView(DataRow row)
        {
            User_Id = Common.clsControl.IsNullOrEmpty(row["User_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["User_Id"]);
            User_Code = Common.clsControl.getValueInRow<string>(row["User_Code"]);
            User_Name = Common.clsControl.getValueInRow<string>(row["User_Name"]);
            Language_Id = Common.clsControl.getValueInRow<string>(row["Language_Id"]);
            Domain_Id = Common.clsControl.IsNullOrEmpty(row["Domain_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Domain_Id"]);
            User_Password = Common.clsControl.getValueInRow<string>(row["User_Password"]);
            Suspend = Common.clsControl.IsNullOrEmpty(row["Suspend"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Suspend"]);
            User_Position = Common.clsControl.getValueInRow<string>(row["User_Position"]);
            Allow_Change_Password = Common.clsControl.IsNullOrEmpty(row["Allow_Change_Password"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Allow_Change_Password"]);
            Expiration_Days = Common.clsControl.IsNullOrEmpty(row["Expiration_Days"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Expiration_Days"]);
            Expiration_Date = Common.clsControl.IsNullOrEmpty(row["Expiration_Date"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Expiration_Date"]);
            Encryption_Password = Common.clsControl.IsNullOrEmpty(row["Encryption_Password"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Encryption_Password"]);
            EmailAddress = Common.clsControl.getValueInRow<string>(row["EmailAddress"]);
            PhoneNumber = Common.clsControl.getValueInRow<string>(row["PhoneNumber"]);
            FaxNumber = Common.clsControl.getValueInRow<string>(row["FaxNumber"]);
            Creation_Date = Common.clsControl.IsNullOrEmpty(row["Creation_Date"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Creation_Date"]);
            IsLogin = Common.clsControl.IsNullOrEmpty(row["IsLogin"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["IsLogin"]);
            MinPasswordLen = Common.clsControl.IsNullOrEmpty(row["MinPasswordLen"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["MinPasswordLen"]);
            Latin_Name = Common.clsControl.getValueInRow<string>(row["Latin_Name"]);
        }
        public bool getUserById(int user_id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@User_Id", user_id);
                ds = ThuVien.mySQL.ExcDataSet(spu_Sys_Users, listPara);
                //Reset();
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
