using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThong
{
    public partial class mncQuanLyNhanVienUserUC : UserControl
    {
        #region "Constants"
        private const string sp_NS_NhanVien_User = "sp_NS_NhanVien_User";
        private int status = 0;
        #endregion
        public mncQuanLyNhanVienUserUC()
        {
            InitializeComponent();
            Common.clsControl.loadDataForGridView(gridControlNhanVienUser, sp_NS_NhanVien_User, "getList");
            setVisibleColumns();
            Common.clsControl.LoadLookup(lkLanguage, "getLanguage", 2);
            ThuVien.mySQL.Load_Lookup_2C(lkGroupCode, "Group_Id", "Group_Code", "[hsvClinic].[dbo].[Sys_Groups]", "");
            ThuVien.mySQL.Load_Lookup_3C(lkMaNhanVien, "MaNhanVien", "Ho", "Ten", "[hsvClinic].[dbo].[NS_NhanVien]", "");
            ThuVien.loadform.disableControl(this);
            disableGridView();
            loadDataForForm();
        }

        private void setVisibleColumns()
        {
            grdNhanVien.Columns["Group_Id"].Visible = false;
            grdNhanVien.Columns["MaNhanVien"].Visible = false;
            grdNhanVien.Columns["User_Id"].Visible = false;
            grdNhanVien.Columns["Language_Id"].Visible = false;
            grdNhanVien.Columns["User_Code"].Visible = true;
            grdNhanVien.Columns["User_Password"].Visible = true;
            grdNhanVien.Columns["Suspend"].Visible = false;
            grdNhanVien.Columns["Allow_Change_Password"].Visible = true;
            grdNhanVien.Columns["Expiration_Days"].Visible = false;
            grdNhanVien.Columns["Expiration_Date"].Visible = true;
            grdNhanVien.Columns["Encryption_Password"].Visible = false;
            grdNhanVien.Columns["EmailAddress"].Visible = true;
            grdNhanVien.Columns["PhoneNumber"].Visible = true;
            grdNhanVien.Columns["FaxNumber"].Visible = false;
            grdNhanVien.Columns["Creation_Date"].Visible = false;
            grdNhanVien.Columns["Created_By"].Visible = false;
            grdNhanVien.Columns["Last_Update_Date"].Visible = false;
            grdNhanVien.Columns["Last_Updated_By"].Visible = false;
            grdNhanVien.Columns["Login_Time"].Visible = false;
            grdNhanVien.Columns["Login_Hostname"].Visible = false;
            grdNhanVien.Columns["IsLogin"].Visible = false;
            grdNhanVien.Columns["Last_Login_Time"].Visible = false;
            grdNhanVien.Columns["Last_Login_Hostname"].Visible = false;
            grdNhanVien.Columns["MinPasswordLen"].Visible = false;
            grdNhanVien.Columns["StrongPassword"].Visible = false;
            grdNhanVien.Columns["Latin_Name"].Visible = true;

        }

        public bool saveCommand()
        {
            EntityClass.cls_UserGroup gr = new EntityClass.cls_UserGroup();
            EntityClass.cls_Users user = new EntityClass.cls_Users();
            EntityClass.cls_NSNhanVien nsNV = new EntityClass.cls_NSNhanVien();
            if (status==1)
            {
                nsNV.mvarMaNhanVien = lkMaNhanVien.EditValue.ToString();
                getThongTinNhanVien(gr,user);
                user.User_Password = Common.clsControl.EncodePasswordToBase64(user.User_Password);
                gr.mvarUser_Id = int.Parse(user.Add());
                gr.mvarGroup_Id = int.Parse(lkGroupCode.EditValue.ToString());
                gr.AddOrUpdate("AddNew");
                MessageBox.Show("Lưu thông tin nhân viên thành công!");
            } else if (status == 2)
            {
                getDataUserInform(gr, user, nsNV);
                user.User_Password = user.User_Password;
                user.Update();
                gr.mvarUser_Id = user.User_Id;
                gr.mvarGroup_Id = int.Parse(lkGroupCode.EditValue.ToString());
                gr.AddOrUpdate("Update");
                MessageBox.Show("Lưu thông tin nhân viên thành công!");
            }
            Common.clsControl.loadDataForGridView(gridControlNhanVienUser, sp_NS_NhanVien_User, "getList");
            
            return true;
        }

        public bool addCommand()
        {
            ThuVien.loadform.enableControl(this);
            lkGroupCode.EditValue = null;
            lkMaNhanVien.EditValue = null;
            lkLanguage.EditValue = null;
            status = 1;
            return true;
        }

        public bool editCommand()
        {
            status = 2;
            return true;
        }

        public bool deleteCommand()
        {
            
            EntityClass.cls_Users user = new EntityClass.cls_Users();
            EntityClass.cls_UserGroup userGroup = new EntityClass.cls_UserGroup();
            DataRow dr = grdNhanVien.GetFocusedDataRow();
            user.FillDataForGridView(dr);
            //gr.FillData(dr);
            if (String.IsNullOrEmpty(lkGroupCode.Text))
            {
                DialogResult result = MessageBox.Show("Mã group đang trống bạn không thể xóa trường này?", "Xóa thông tin user",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }else
            {
                
                user.Delete();
                userGroup.mvarUser_Id = user.User_Id;
                userGroup.mvarGroup_Id= int.Parse(lkGroupCode.EditValue.ToString());
                userGroup.Delete();
                Common.clsControl.loadDataForGridView(gridControlNhanVienUser, sp_NS_NhanVien_User, "getList");
            }
            
            return true;
        }
        private void lkMaNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            if (lkMaNhanVien.EditValue != null)
            {
                EntityClass.cls_NSNhanVien nv = new EntityClass.cls_NSNhanVien();
                nv.Get_By_Key(lkMaNhanVien.EditValue.ToString());
                txtUserName.Text = nv.mvarHo + " " + nv.mvarTen;
                lkLanguage.EditValue = "VI";
                txtEmail.Text = nv.mvarEmail;
                txtDangNhap.Text = lkMaNhanVien.EditValue.ToString();
                minPasswordLenSpinEdit.Text = "8";
                txtPassword.Text = "12345678";

                //GridColumn column = grdNhanVien.Columns["User_Code"];
                //var myColumn = grdNhanVien.Columns.FirstOrDefault((col) => col.GetCaption() == "User_Code");
            }
        }

        //private void grdNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    DataRow dr = grdNhanVien.GetFocusedDataRow();
        //    EntityClass.cls_Groups gr = new EntityClass.cls_Groups();
        //    gr.mvarGroup_Name = Common.clsControl.getValueInRow<string>(dr["Group_Name"]);
        //    EntityClass.cls_Users user = new EntityClass.cls_Users();
        //    EntityClass.cls_NSNhanVien nsNV = new EntityClass.cls_NSNhanVien();
        //    nsNV.FillData_FromGridView(dr);
        //    user.FillDataForGridView(dr);
        //    //int[] SelectedRowHandles = grdNhanVien.GetSelectedRows();
        //    //if (SelectedRowHandles.Length > 0) {
        //    lkMaNhanVien.EditValue = user.User_Code;
        //    txtUserName.Text = user.User_Name;
        //    lkLanguage.EditValue = user.Language_Id;
        //    txtDomain.Text = user.Domain_Id.ToString();
        //    txtPassword.Text = user.User_Password;
        //    user_PositionTextEdit.Text = user.User_Position;
        //    expiration_DaysSpinEdit.EditValue = user.Expiration_Days;
        //    expiration_DateDateEdit.EditValue = user.Expiration_Date;
        //    txtEmail.Text = user.EmailAddress;
        //    phoneNumberTextEdit.Text = user.PhoneNumber;
        //    faxNumberTextEdit.Text = user.FaxNumber;
        //    creation_DateDateEdit.EditValue = user.Creation_Date;
        //    minPasswordLenSpinEdit.EditValue = user.MinPasswordLen;

        //    latin_NameTextEdit.Text = user.Latin_Name;
        //    lkGroupCode.EditValue = lkGroupCode.Properties.GetKeyValueByDisplayText(gr.mvarGroup_Name.ToString());
        //    ckbSuspend.Checked = user.Suspend;
        //    allow_Change_PasswordCheckEdit.Checked = user.Allow_Change_Password;
        //    encryption_PasswordCheckEdit.Checked = user.Encryption_Password;
        //    isLoginCheckEdit.Checked = user.IsLogin;
        //    //}
            
        //}

        public void getDataUserInform(EntityClass.cls_UserGroup gr, EntityClass.cls_Users user, EntityClass.cls_NSNhanVien nsNV)
        {
            //lk= gr.mvarGroup_Name
            //nsNV.mvarMaNhanVien = Common.clsControl.getValueInRow<string>(dr["User_Code"]).ToString();
            DataRow dr = grdNhanVien.GetFocusedDataRow();
            user.User_Id = int.Parse(Common.clsControl.getValueInRow<string>(dr["User_Id"]).ToString());
            user.User_Code = Common.clsControl.getValueInRow<string>(dr["User_Code"]).ToString();
            user.User_Name = txtUserName.Text;
            user.Language_Id = lkLanguage.EditValue.ToString();
            user.Domain_Id = String.IsNullOrEmpty(txtDomain.Text) ?0:int.Parse(txtDomain.Text);
            user.User_Password = txtPassword.Text;
            user.User_Position = user_PositionTextEdit.Text;
            user.Expiration_Days = String.IsNullOrEmpty(expiration_DaysSpinEdit.Text)?0:int.Parse(expiration_DaysSpinEdit.Text);
            user.Expiration_Date = String.IsNullOrEmpty(expiration_DateDateEdit.Text) ?DateTime.Now:DateTime.Parse(expiration_DateDateEdit.Text);
            user.EmailAddress = txtEmail.Text;
            user.PhoneNumber = phoneNumberTextEdit.Text;
            user.FaxNumber = faxNumberTextEdit.Text;
            user.Creation_Date = String.IsNullOrEmpty(creation_DateDateEdit.Text)?DateTime.Now:DateTime.Parse(creation_DateDateEdit.Text);
            user.MinPasswordLen = String.IsNullOrEmpty(minPasswordLenSpinEdit.Text) ?8:int.Parse(minPasswordLenSpinEdit.Text);
            user.Latin_Name = latin_NameTextEdit.Text;
            gr.mvarGroup_Id = int.Parse(lkGroupCode.EditValue.ToString());
            user.Suspend = ckbSuspend.Checked;
            user.Allow_Change_Password = allow_Change_PasswordCheckEdit.Checked;
            user.Encryption_Password = encryption_PasswordCheckEdit.Checked;
            user.IsLogin = isLoginCheckEdit.Checked;
        }

        private void getThongTinNhanVien(EntityClass.cls_UserGroup gr, EntityClass.cls_Users user)
        {
            user.User_Code = lkMaNhanVien.EditValue.ToString();
            user.User_Name = txtUserName.Text;
            user.Language_Id = lkLanguage.EditValue.ToString();
            user.Domain_Id = String.IsNullOrEmpty(txtDomain.Text) ? 0 : int.Parse(txtDomain.Text);
            user.User_Password = txtPassword.Text;
            user.User_Position = user_PositionTextEdit.Text;
            user.Expiration_Days = String.IsNullOrEmpty(expiration_DaysSpinEdit.Text) ? 0 : int.Parse(expiration_DaysSpinEdit.Text);
            user.Expiration_Date = String.IsNullOrEmpty(expiration_DateDateEdit.Text) ? DateTime.Now : DateTime.Parse(expiration_DateDateEdit.Text);
            user.EmailAddress = txtEmail.Text;
            user.PhoneNumber = phoneNumberTextEdit.Text;
            user.FaxNumber = faxNumberTextEdit.Text;
            user.Creation_Date = String.IsNullOrEmpty(creation_DateDateEdit.Text) ? DateTime.Now : DateTime.Parse(creation_DateDateEdit.Text);
            user.MinPasswordLen = String.IsNullOrEmpty(minPasswordLenSpinEdit.Text) ? 8 : int.Parse(minPasswordLenSpinEdit.Text);
            user.Latin_Name = latin_NameTextEdit.Text;
            gr.mvarGroup_Id = int.Parse(lkGroupCode.EditValue.ToString());
            user.Suspend = ckbSuspend.Checked;
            user.Allow_Change_Password = allow_Change_PasswordCheckEdit.Checked;
            user.Encryption_Password = encryption_PasswordCheckEdit.Checked;
            user.IsLogin = isLoginCheckEdit.Checked;
        }


        public void disableGridView()
        {
            for (int i = 0; i < grdNhanVien.Columns.Count; i++)
            {
                grdNhanVien.Columns[i].OptionsColumn.AllowFocus = false;
            }
        }
        private void grdNhanVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            loadDataForForm();
            ThuVien.loadform.disableControl(this);
        }

        private void loadDataForForm()
        {
            DataRow dr = grdNhanVien.GetFocusedDataRow();
            EntityClass.cls_Groups gr = new EntityClass.cls_Groups();
            gr.mvarGroup_Id = Common.clsControl.IsNullOrEmpty(dr["Group_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(dr["Group_Id"]);
            gr.mvarGroup_Code = Common.clsControl.getValueInRow<string>(dr["Group_Code"]);
            EntityClass.cls_Users user = new EntityClass.cls_Users();
            EntityClass.cls_NSNhanVien nsNV = new EntityClass.cls_NSNhanVien();
            nsNV.FillData_FromGridView(dr);
            user.FillDataForGridView(dr);
            lkMaNhanVien.EditValue = nsNV.mvarMaNhanVien;
            txtUserName.Text = user.User_Name;
            lkLanguage.EditValue = user.Language_Id;
            txtDomain.Text = user.Domain_Id.ToString();
            txtPassword.Text = user.User_Password;
            user_PositionTextEdit.Text = user.User_Position;
            expiration_DaysSpinEdit.EditValue = user.Expiration_Days;
            expiration_DateDateEdit.EditValue = user.Expiration_Date;
            txtEmail.Text = user.EmailAddress;
            phoneNumberTextEdit.Text = user.PhoneNumber;
            faxNumberTextEdit.Text = user.FaxNumber;
            creation_DateDateEdit.EditValue = user.Creation_Date;
            minPasswordLenSpinEdit.EditValue = user.MinPasswordLen;

            latin_NameTextEdit.Text = user.Latin_Name;
            lkGroupCode.EditValue = gr.mvarGroup_Id;
            ckbSuspend.Checked = user.Suspend;
            allow_Change_PasswordCheckEdit.Checked = user.Allow_Change_Password;
            encryption_PasswordCheckEdit.Checked = user.Encryption_Password;
            isLoginCheckEdit.Checked = user.IsLogin;
        }
    }
}
