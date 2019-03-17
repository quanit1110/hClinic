using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using DevExpress.XtraBars;

namespace HeThong
{
    public partial class mncQuanLyGroupUC : DevExpress.XtraEditors.XtraUserControl
    {
        private int status=0;
        public mncQuanLyGroupUC()
        {
            InitializeComponent();

            //lấy kích thước của màn hình
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hiển thị theo kích thước của màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;
            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1386 là chiều rộng, 788 là chiều cao Form khi thiết kế, xem trong Properties của Form
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);

            //Common.clsControl.LoadLookup(lkGroup, "getGroup", 2);
            
            fillTree();
            Common.clsControl.loadDataForGridView(gridCUser, "spu_Sys_Users", "GetUserAndGroup");
            disableGridView(gridVUser);
            ThuVien.loadform.disableControl(this);
            //radioGroup.Enabled = true;
            //radioGroup.Checked = true;
            //radioGroupUser.Enabled = true;
            visibleColumn();
        }

        private void disableGridView(GridView gridView1)
        {
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsColumn.AllowFocus = false;
            }
        }

        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                //gọi đệ quy nếu như 1 control nào có chứa các control khác nữa

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                //canh lại toạ độ x, y, chiều rộng, cao cho các control trên form

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }

        public void visibleColumn()
        {
            gridVUser.Columns["User_Id"].Visible = false;
            gridVUser.Columns["User_Code"].Visible = true;
            gridVUser.Columns["Language_Id"].Visible = false;
            gridVUser.Columns["User_Password"].Visible = false;
            gridVUser.Columns["Suspend"].Visible = false;
            gridVUser.Columns["Allow_Change_Password"].Visible = false;
            gridVUser.Columns["Expiration_Days"].Visible = false;
            gridVUser.Columns["Expiration_Date"].Visible = false;
            gridVUser.Columns["Encryption_Password"].Visible = false;
            gridVUser.Columns["EmailAddress"].Visible = false;
            gridVUser.Columns["PhoneNumber"].Visible = false;
            gridVUser.Columns["FaxNumber"].Visible = false;
            gridVUser.Columns["Creation_Date"].Visible = false;
            gridVUser.Columns["Created_By"].Visible = false;
            gridVUser.Columns["Last_Update_Date"].Visible = false;
            gridVUser.Columns["Last_Updated_By"].Visible = false;
            gridVUser.Columns["Login_Time"].Visible = false;
            gridVUser.Columns["Login_Hostname"].Visible = false;
            gridVUser.Columns["IsLogin"].Visible = false;
            gridVUser.Columns["Last_Login_Time"].Visible = false;
            gridVUser.Columns["Last_Login_Hostname"].Visible = false;
            gridVUser.Columns["MinPasswordLen"].Visible = false;
            gridVUser.Columns["StrongPassword"].Visible = false;
            gridVUser.Columns["Latin_Name"].Visible = false;
            gridVUser.Columns["UserOption1"].Visible = false;
            gridVUser.Columns["UserOption2"].Visible = false;
            gridVUser.Columns["UserOption3"].Visible = false;
            gridVUser.Columns["UserOption4"].Visible = false;
            gridVUser.Columns["UserOption5"].Visible = false;
            gridVUser.Columns["UserOption6"].Visible = false;
            gridVUser.Columns["UserOption7"].Visible = false;
            gridVUser.Columns["UserOption8"].Visible = false;
            gridVUser.Columns["UserOption9"].Visible = false;
        }

        private void btnThemGroups_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThuVien.loadform.enableControl(this);
            ThuVien.loadform.clearForm(this);
            frmQuanLyGroups gr = new frmQuanLyGroups();
            gr.ShowDialog();
            status = 1;
            fillTree();
        }

        private void btnSuaGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThuVien.loadform.enableControl(this);
            EntityClass.cls_Groups group = new EntityClass.cls_Groups();
            
            if (treeView1.SelectedNode != null)
            {
                string id = group.getGroupId(treeView1.SelectedNode.Text);
                frmQuanLyGroups gr = new frmQuanLyGroups(treeView1.SelectedNode.Text, id);
                gr.ShowDialog();
                
                fillTree();
            }
            
            
            status = 2;
        }
        public bool addCommand()
        {
            ThuVien.loadform.enableControl(this);
            frmQuanLyGroups gr = new frmQuanLyGroups();
            gr.ShowDialog();
            fillTree();
            if (gr.actionForm== 2)
            {
                return false;
            }
            return true;
        }

        public bool editCommand()
        {
            //if (radioGroup.Checked == true)
            //{
                if (treeView1.SelectedNode==null)
                {
                    MessageBox.Show("Bạn vui lòng chọn một group để sửa!");
                }
                else
                {
                    EntityClass.cls_Groups group = new EntityClass.cls_Groups();
                    string id = group.getGroupId(treeView1.SelectedNode.Text);
                    ThuVien.loadform.enableControl(this);
                    frmQuanLyGroups gr = new frmQuanLyGroups(treeView1.SelectedNode.Text,id);
                    gr.ShowDialog();
                }
                
            //}
            //else if (radioGroupUser.Checked == true)
            //{
            //    lkGroup.Enabled = true;
            //}
            //else
            //{
            //    MessageBox.Show("Bạn vui lòng chọn sửa user hoặc user-group?");
            //}
            status = 3;
            return true;
        }

        public bool saveCommand()
        {/*
            int[] dr = gridVUser.GetSelectedRows();
            if (dr.Length < 1)
            {
                MessageBox.Show("Vui lòng chọn một user để sửa group!");
            }else if (lkGroup.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn group cho user!");
                lkGroup.Enabled = true;
                lkGroup.Focus();
            }
            else
            {
                for (int i = 0; i < dr.Length; i++)
                {
                    DataRowView selRow = (DataRowView)(((GridView)gridCUser.MainView).GetRow(dr[i]));
                    EntityClass.cls_UserGroup usergroup = new EntityClass.cls_UserGroup();
                    EntityClass.cls_Groups group = new EntityClass.cls_Groups();
                    DataRow dtr = gridVUser.GetDataRow(i);
                    usergroup.mvarUser_Id = int.Parse(selRow["User_Id"].ToString());
                    string grName = lkGroup.EditValue.ToString();
                    usergroup.mvarGroup_Id = int.Parse(grName);

                    usergroup.AddOrUpdate("Update");

                }
                Common.clsControl.loadDataForGridView(gridCUser, "spu_Sys_Users", "GetUserAndGroup");


            }*/
            return false;
        }
        

        private void btnReset_Click(object sender, EventArgs e)
        {
            ThuVien.loadform.clearForm(this);
            ThuVien.loadform.enableControl(this);
            status = 4;
        }

        private void btnXoaGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa trường này?", "Xóa thông tin group",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                EntityClass.cls_Groups group = new EntityClass.cls_Groups();
                EntityClass.cls_UserGroup userGroup = new EntityClass.cls_UserGroup();
                string node = treeView1.SelectedNode.Text;
               
                group.mvarGroup_Id = int.Parse(group.getGroupId(node));
                group.Delete();
                userGroup.Delete();
                fillTree();
            }
            status = 3;
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu2.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            }
        }


        private void gridControl2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            }
        }

        
        private void fillTree()
        {
            List<SqlParameter> lisPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref lisPara,"@Action", "getListGroup");
            DataSet ds = ThuVien.mySQL.ExcDataSet("spu_Sys_Groups", lisPara);
            treeView1.Nodes.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.Text = dr["Group_Code"].ToString();
                treeView1.Nodes.Add(tnParent);
            }
        }

        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
                }
            }
            
        }

        private void gridCUser_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    popupMenu2.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            //}
        }


        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            loadGridViewInGroup(e);
            //radioGroup.Checked = true;
        }

        private void loadGridViewInGroup(TreeNodeMouseClickEventArgs e)
        {
            int countRow = gridVUser.DataRowCount;
            gridVUser.ClearSelection();
            for (int i=0; i<countRow;i++)
            {
                DataRow dr = gridVUser.GetDataRow(i);
                dr["Group_Code"].ToString().Equals(e.Node.Text);
                if (dr["Group_Code"].ToString().Equals(e.Node.Text))
                {
                    gridVUser.SelectRow(i);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode= e.Node;
            }
        }

        private void btiThem_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void radioGroupUser_CheckedChanged(object sender, EventArgs e)
        {
            //lkGroup.Visible = true;
            //lkGroup.Enabled = false;
            gridCUser.Enabled = true;
            gridVUser.OptionsBehavior.ReadOnly = false;
        }

        private void radioGroup_CheckedChanged(object sender, EventArgs e)
        {
            //lkGroup.Visible = false;
            gridVUser.ClearSelection();
            gridVUser.OptionsBehavior.ReadOnly = true;
        }

        private void gridVUser_RowClick(object sender, RowClickEventArgs e)
        {
            //radioGroupUser.Checked = true;
        }
    }
}
