using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using System.Text.RegularExpressions;
using EntityClass;
using DevExpress.Utils.Drawing;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Data;
using DevExpress.Utils;

namespace HeThong
{
    public partial class frmQuanLyGroups : DevExpress.XtraEditors.XtraForm
    {
        HashSet<EntityClass.cls_PhanQuyenGroupMenu> pqUpdate = new HashSet<EntityClass.cls_PhanQuyenGroupMenu>();
        HashSet<EntityClass.cls_PhanQuyenGroupMenu> pqNew = new HashSet<EntityClass.cls_PhanQuyenGroupMenu>();
        int status = 0;
        public int actionForm = 0;
        private const string ColumnEnable = "Enable";
        private const string ColumnVisible = "Visible";
        private const string ColumnAddNew = "Add_New";
        private const string ColumnDeleteValue = "Delete_Value";
        private const string ColumnEditValue = "Edit_Value";

        Dictionary<int, Boolean> unboundData1 = new Dictionary<int, Boolean>();
        Dictionary<int, Boolean> unboundData2 = new Dictionary<int, Boolean>();
        Dictionary<int, Boolean> unboundData3 = new Dictionary<int, Boolean>();
        Dictionary<int, Boolean> unboundData4 = new Dictionary<int, Boolean>();
        Dictionary<int, Boolean> unboundData5 = new Dictionary<int, Boolean>();

        public frmQuanLyGroups()
        {
            InitializeComponent();
            //lấy kích thước của màn hình
            //int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            //int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hiển thị theo kích thước của màn hình
            //this.Width = widthScreen;
            //this.Height = heightScreen;
            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1386 là chiều rộng, 788 là chiều cao Form khi thiết kế, xem trong Properties của Form
            //float WidthPerscpective = (float)Width / 1024;
            //float HeightPerscpective = (float)Height / 768;
            //ResizeAllControls(this, WidthPerscpective, HeightPerscpective);

            Common.clsControl.LoadLookup(lkLanguage, "getLanguage", 2);
            Common.clsControl.LoadLookup(txtGroupCode, "getGroup", 2);
            ThuVien.loadform.clearForm(this);
            ThuVien.mySQL.LoadGirdControl(gridControl2, "select * from menu mn");
            gridView1.OptionsBehavior.ReadOnly = false;
            visibleColumn();
            txtGroupCode.Enabled = true;
            createColumn();
            status = 1;
        }

        private void visibleColumn()
        {
            //gridView1.Columns["Id"].Visible = false;
            //gridView1.Columns["ParentID"].Visible = false;
            //gridView1.Columns["URL"].Visible = false;
            //gridView1.Columns["IsEnable"].Visible = false;
            //gridView1.Columns["IsVisible"].Visible = false;
            //gridView1.Columns["Separator"].Visible = false;
            //gridView1.Columns["Project"].Visible = false;
            //gridView1.Columns["Group_Id"].Visible = false;
            //gridView1.Columns["Menu_Id"].Visible = false;
            gridView1.Columns["MenuName"].Visible = false;
        }

        public frmQuanLyGroups(string name, string name2)
        {
            InitializeComponent();
            Common.clsControl.LoadLookup(txtGroupCode, "getGroup", 2);
            txtGroupCode.EditValue = name2;
            Common.clsControl.LoadLookup(lkLanguage, "getLanguage", 2);
            List<SqlParameter> lisPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref lisPara, "@Action", "getGroupCode");
            ThuVien.mySQL.AddListParaWithNullValue(ref lisPara, "@Group_Code", name);
            DataRow dr = ThuVien.mySQL.RtDataRowSP("spu_Sys_Groups", lisPara);
            EntityClass.cls_Groups gr = new EntityClass.cls_Groups();
            gr.FillData(dr);
            FillDataForForm(gr);
            ThuVien.loadform.enableControl(this);
            btnLuuGroup.Enabled = true;
            txtGroupCode.Enabled = true;
            createColumn();
            visibleColumn();
            ThuVien.mySQL.LoadGirdControl(gridControl2, "select * from menu mn left join Sys_PhanQuyenGroupMenu pq on pq.Menu_Id = mn.Id where Group_Id = "+name2);
            
            status = 2;
        }

        private void FillDataForForm(EntityClass.cls_Groups gr)
        {
            txtGroupCode.EditValue = gr.mvarGroup_Id;
            txtGroupName.Text = gr.mvarGroup_Name;
            txtDescription.Text = gr.mvarDescription;
            txtLatinName.Text = gr.mvarLatin_Name;
            txtDomain.Text = gr.mvarDomain_Id.ToString();
            txtMember.Text = gr.mvarMember.ToString();
            lkLanguage.EditValue = gr.mvarLanguage_Id;
            chbAdmin.Checked = gr.mvarAdmin;
            chbDefaultGroup.Checked = gr.mvarDefaultGroup;
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
        

        private void frmQuanLyGroups_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            actionForm = 2;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThuVien.loadform.enableControl(this);
            ThuVien.loadform.clearForm(this);
            lkLanguage.EditValue = null;
            txtGroupCode.EditValue=null;
            txtGroupCode.Enabled = false;
            btnLuuGroup.Enabled = true;
            status = 1;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThuVien.loadform.enableControl(this);
            txtGroupCode.Focus();
            btnLuuGroup.Enabled = true;
            status = 2;
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            ThuVien.loadform.clearForm(this);
            //lkcreation_Date.EditValue = null;
            lkLanguage.EditValue = null;
            ThuVien.loadform.enableControl(this);
            btnLuuGroup.Enabled = true;
            txtGroupCode.Enabled = true;
            txtGroupCode.EditValue = null;
        }
        public void getDataInForm(EntityClass.cls_Groups group)
        {
            //group.mvarGroup_Code = txtGroupCode.EditValue.ToString();
            group.mvarGroup_Code = Common.clsControl.ConvertToUnSign(txtGroupName.Text).Replace(" ", "");
            group.mvarGroup_Name = txtGroupName.Text;
            group.mvarLanguage_Id = lkLanguage.EditValue.ToString();
            group.mvarDomain_Id = String.IsNullOrEmpty(txtDomain.Text) ? 0 : int.Parse(txtDomain.Text);
            group.mvarAdmin = chbAdmin.Checked;
            group.mvarDefaultGroup = chbDefaultGroup.Checked;
            group.mvarMember = String.IsNullOrEmpty(txtMember.Text) ? 0 : int.Parse(txtMember.Text);
            group.mvarDescription = txtDescription.Text;
            //group.mvarCreation_Date = DateTime.Now;
            //group.mvarCreated_By = String.IsNullOrEmpty(txtCreated_By.Text) ? 0 : int.Parse(txtCreated_By.Text);
            //group.mvarLast_Update_Date = DateTime.Now;
            //get id cua user hien tai dang login 
            //group.mvarLast_Updated_By = ;
            group.mvarLatin_Name = txtLatinName.Text;
            for (int i=0;i<gridView1.RowCount;i++)
            {
                EntityClass.cls_PhanQuyenGroupMenu grMenu = new EntityClass.cls_PhanQuyenGroupMenu();
                grMenu.mvarMenu_Id = int.Parse(gridView1.GetRowCellValue(i, "Id").ToString());
                grMenu.mvarEnable = Convert.ToBoolean(gridView1.GetRowCellValue(i, "Enable"));
                grMenu.mvarVisible = Convert.ToBoolean(gridView1.GetRowCellValue(i, "Visible"));
                grMenu.mvarAdd_New = Convert.ToBoolean(gridView1.GetRowCellValue(i, "Add_New"));
                grMenu.mvarDelete_Value = Convert.ToBoolean(gridView1.GetRowCellValue(i, "Delete_Value"));
                grMenu.mvarEdit_Value = Convert.ToBoolean(gridView1.GetRowCellValue(i, "Edit_Value"));
                pqUpdate.Add(grMenu);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa trường này?", "Xóa thông tin group",
            //MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if(result == DialogResult.Yes)
            //{
            //    EntityClass.cls_Groups group = new EntityClass.cls_Groups();
            //    EntityClass.cls_UserGroup userGroup = new EntityClass.cls_UserGroup();
            //    int[] selectionRow = gvGroup.GetSelectedRows();
            //    group.mvarGroup_Id = int.Parse(gvGroup.GetRowCellValue(selectionRow[0], gvGroup.Columns[0]).ToString());
            //    group.Delete();
            //    userGroup.Delete();
            //    loadDataForGridView(gridControl1, "spu_Sys_Groups", "getAll");
            //}
            
        }
        
        private void btnLuuGroup_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            for (int i=0;i<gridView1.RowCount;i++)
            {
                bool a= Convert.ToBoolean(gridView1.GetRowCellValue(i,"Enable"));
                if (Convert.ToBoolean(gridView1.GetRowCellValue(i, "Enable")) == false
                    && Convert.ToBoolean(gridView1.GetRowCellValue(i, "Visible")) == false
                    && Convert.ToBoolean(gridView1.GetRowCellValue(i, "Add_New")) == false
                    && Convert.ToBoolean(gridView1.GetRowCellValue(i, "Edit_Value")) == false
                    && Convert.ToBoolean(gridView1.GetRowCellValue(i, "Delete_Value")) == false)
                {
                    count = count + 1;
                }
            }
            if (gridView1.RowCount== count)
            {
                MessageBox.Show("Bạn phải chọn một quyền cho group!");
            }
            else
            {
                EntityClass.cls_Groups group = new EntityClass.cls_Groups();
                EntityClass.cls_PhanQuyenGroupMenu pq = null;
                if (status == 2)
                {
                    try
                    {
                        pq = new EntityClass.cls_PhanQuyenGroupMenu();
                        group.mvarGroup_Id = int.Parse(group.getGroupId(txtGroupCode.Text));
                        getDataInForm(group);
                        foreach (EntityClass.cls_PhanQuyenGroupMenu p in pqUpdate)
                        {
                            p.mvarGroup_Id = group.mvarGroup_Id;
                            p.AddOrUpdate("Update");
                        }
                        ThuVien.mySQL.LoadGirdControl(gridControl2, "select * from menu mn left join Sys_PhanQuyenGroupMenu pq on pq.Menu_Id = mn.Id where Group_Id = " + group.mvarGroup_Id);
                        ThuVien.loadform.disableControl(this);
                        MessageBox.Show("Update group thành công!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update group không thành công!");
                    }
                }
                else if (status == 1)
                {
                    pq = new EntityClass.cls_PhanQuyenGroupMenu();
                    getDataInForm(group);
                    string id = group.Add();
                    foreach (EntityClass.cls_PhanQuyenGroupMenu p in pqUpdate)
                    {
                        p.mvarGroup_Id = int.Parse(id);
                        p.AddOrUpdate("AddNew");
                    }
                    ThuVien.loadform.disableControl(this);
                    MessageBox.Show("Lưu group thành công!");
                    this.Close();
                }
                //loadDataForGridView(gridControl1, "spu_Sys_Groups", "getAll");
                Common.clsControl.LoadLookup(txtGroupCode, "getGroup", 2);
            }
            actionForm = 1;
        }

        private void txtGroupCode_EditValueChanged_1(object sender, EventArgs e)
        {
            ThuVien.mySQL.LoadGirdControl(gridControl2, "select * from menu mn left join Sys_PhanQuyenGroupMenu pq on pq.Menu_Id = mn.Id where Group_Id = " + txtGroupCode.EditValue);
            EntityClass.cls_Groups gr = new EntityClass.cls_Groups();
            gr.Get_By_Key(txtGroupCode.Text);
            txtGroupName.Text = gr.mvarGroup_Name;
            txtDomain.Text = gr.mvarDomain_Id.ToString();
            txtLatinName.Text = gr.mvarLatin_Name;
            txtMember.Text = gr.mvarMember.ToString();
            txtDescription.Text = gr.mvarDescription;
            chbAdmin.Checked = gr.mvarAdmin;
            chbDefaultGroup.Checked = gr.mvarDefaultGroup;
        }
        /*
 - load gridview by GroupId
 - Lưu/ Sửa Group
 */
        
        private void createColumn()
        {
            GridColumn unboundColumn = gridView1.Columns[ColumnEnable];
            unboundColumn.UnboundType = UnboundColumnType.Boolean;
            unboundColumn.Visible = true;

            GridColumn unboundColumn1 = gridView1.Columns[ColumnVisible];
            unboundColumn1.UnboundType = UnboundColumnType.Boolean;
            unboundColumn1.Visible = true;

            GridColumn unboundColumn2 = gridView1.Columns[ColumnAddNew];
            unboundColumn2.UnboundType = UnboundColumnType.Boolean;
            unboundColumn2.Visible = true;

            GridColumn unboundColumn3 = gridView1.Columns[ColumnEditValue];
            unboundColumn3.UnboundType = UnboundColumnType.Boolean;
            unboundColumn3.Visible = true;

            GridColumn unboundColumn4 = gridView1.Columns[ColumnDeleteValue];
            unboundColumn4.UnboundType = UnboundColumnType.Boolean;
            unboundColumn4.Visible = true;

            Common.CheckAllColumn c1 = new Common.CheckAllColumn(gridView1, unboundColumn);
            Common.CheckAllColumn c2 = new Common.CheckAllColumn(gridView1, unboundColumn1);
            Common.CheckAllColumn c3 = new Common.CheckAllColumn(gridView1, unboundColumn2);
            Common.CheckAllColumn c4 = new Common.CheckAllColumn(gridView1, unboundColumn3);
            Common.CheckAllColumn c5 = new Common.CheckAllColumn(gridView1, unboundColumn4);
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            var a = gridView1.GetDataRow(e.RowHandle);
            DevExpress.XtraGrid.Columns.GridColumn b = gridView1.FocusedColumn;
            if (b.FieldName == ColumnEnable)
            {
                RepositoryItemCheckEdit ri = gridView1.Columns[ColumnEnable].RealColumnEdit as RepositoryItemCheckEdit;
                ri.ValueChecked = true;
                gridView1.Columns[ColumnEnable].ColumnEdit = ri;
                gridView1.UpdateCurrentRow();
            }
            else if (b.FieldName == ColumnVisible)
            {
                RepositoryItemCheckEdit ri = gridView1.Columns[ColumnVisible].RealColumnEdit as RepositoryItemCheckEdit;
                ri.ValueChecked = true;
                gridView1.Columns[ColumnVisible].ColumnEdit = ri;
                gridView1.UpdateCurrentRow();
            }
            else if (b.FieldName == ColumnAddNew)
            {
                RepositoryItemCheckEdit ri = gridView1.Columns[ColumnAddNew].RealColumnEdit as RepositoryItemCheckEdit;
                ri.ValueChecked = true;
                gridView1.Columns[ColumnAddNew].ColumnEdit = ri;
                gridView1.UpdateCurrentRow();
            }
            else if (b.FieldName == ColumnEditValue)
            {
                RepositoryItemCheckEdit ri = gridView1.Columns[ColumnEditValue].RealColumnEdit as RepositoryItemCheckEdit;
                ri.ValueChecked = true;
                gridView1.Columns[ColumnEditValue].ColumnEdit = ri;
                gridView1.UpdateCurrentRow();
            }
            else if (b.FieldName == ColumnDeleteValue)
            {
                RepositoryItemCheckEdit ri = gridView1.Columns[ColumnDeleteValue].RealColumnEdit as RepositoryItemCheckEdit;
                ri.ValueChecked = true;
                gridView1.Columns[ColumnDeleteValue].ColumnEdit = ri;
                gridView1.UpdateCurrentRow();
            }
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == ColumnEnable)
            {
                // Populate columns 
                if (e.IsGetData)
                {
                    if (unboundData1.ContainsKey(e.ListSourceRowIndex))
                        e.Value = unboundData1[e.ListSourceRowIndex];
                }
                // Post edits back to the source 
                if (e.IsSetData && e.Value != null)
                {
                    unboundData1[e.ListSourceRowIndex] = (Boolean)e.Value;
                }
            }
            else if (e.Column.FieldName == ColumnVisible)
            {
                // Populate columns 
                if (e.IsGetData)
                {
                    if (unboundData2.ContainsKey(e.ListSourceRowIndex))
                        e.Value = unboundData2[e.ListSourceRowIndex];
                }
                // Post edits back to the source 
                if (e.IsSetData && e.Value != null)
                {
                    unboundData2[e.ListSourceRowIndex] = (Boolean)e.Value;
                }
            }
            else if (e.Column.FieldName == ColumnAddNew)
            {
                // Populate columns 
                if (e.IsGetData)
                {
                    if (unboundData3.ContainsKey(e.ListSourceRowIndex))
                        e.Value = unboundData3[e.ListSourceRowIndex];
                }
                // Post edits back to the source 
                if (e.IsSetData && e.Value != null)
                {
                    unboundData3[e.ListSourceRowIndex] = (Boolean)e.Value;
                }
            }
            else if (e.Column.FieldName == ColumnEditValue)
            {
                // Populate columns 
                if (e.IsGetData)
                {
                    if (unboundData4.ContainsKey(e.ListSourceRowIndex))
                        e.Value = unboundData4[e.ListSourceRowIndex];
                }
                // Post edits back to the source 
                if (e.IsSetData && e.Value != null)
                {
                    unboundData4[e.ListSourceRowIndex] = (Boolean)e.Value;
                }
            }
            else if (e.Column.FieldName == ColumnDeleteValue)
            {
                // Populate columns 
                if (e.IsGetData)
                {
                    if (unboundData5.ContainsKey(e.ListSourceRowIndex))
                        e.Value = unboundData5[e.ListSourceRowIndex];
                }
                // Post edits back to the source 
                if (e.IsSetData && e.Value != null)
                {
                    unboundData5[e.ListSourceRowIndex] = (Boolean)e.Value;
                }
            }
        }
    }
}