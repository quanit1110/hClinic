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
using ThuVien;
using System.IO;
using System.Reflection;
using DevExpress.XtraBars;

namespace hClinic
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        ThuVien.AddTab_DLL clsAddTabDll = new ThuVien.AddTab_DLL();
        static int status = 0;
        private bool them = true;
        private bool xoa = true;
        private bool sua = true;
        public MainForm()
        {
            InitializeComponent();
            //lấy kích thước của màn hình
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

            string ph = (Directory.GetCurrentDirectory());
            var filePaths = Directory.GetFiles(@ph, "*.dll", SearchOption.AllDirectories);
            foreach (var f in filePaths)
            {
                Assembly.LoadFile(f);
            }
            ThuVien.loadform.controlBar = new List<bool>();
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            SetRole();

        }
        /* Resize màn hình form */
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
       
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void xtraTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            if (!btnLuu.Enabled)
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                ThuVien.loadform.controlBar.RemoveRange(xtraTabControl1.SelectedTabPageIndex * 4, 4);
                DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
                DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
                (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();
            }
            else
            {
                DialogResult res = MessageBox.Show("thoat va khong luu du lieu", "dong tab", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    btnLuu.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThem.Enabled = false;
                    ThuVien.loadform.controlBar.RemoveRange(xtraTabControl1.SelectedTabPageIndex * 4, 4);
                    DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
                    DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
                    (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();

                }
            }

        }

        private void loadUC(object sender, EventArgs e)
        {
            EntityClass.cls_PhanQuyenGroupMenu pq = new EntityClass.cls_PhanQuyenGroupMenu();
            if (ThuVien.loadform.userID > 0)
            {
                int t = 0;
                ToolStripMenuItem bt = sender as ToolStripMenuItem;
                string menuId = ThuVien.mySQL.getValues("select Id from Menu where MenuName='" + bt.Name + "'");
                string groupId = ThuVien.mySQL.getValues("select Group_Id From Sys_UserGroups where User_Id='" + ThuVien.loadform.userID.ToString() + "'");
                //getgroup

                DataRow dr = pq.getObjectGroupMenu(int.Parse(groupId), int.Parse(menuId));
                pq.FillData(dr);
                checkRole(pq, dr);
                if (bt.DropDownItems.Count == 0)
                {
                    foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                    {
                        if (tab.Text == bt.Text)
                        {
                            xtraTabControl1.SelectedTabPage = tab;
                            showcontrolBar(ThuVien.loadform.controlBar, xtraTabControl1.SelectedTabPageIndex);
                            t = 1;
                            if (bt.Text == "Tiếp nhận bệnh nhân")
                            {
                                //ShowHideBtnNghiepVu(true);
                            }
                            else
                            {
                                //ShowHideBtnNghiepVu(false);
                            }
                        }
                    }
                    if (t == 1)
                    {

                    }
                    else
                    {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào

                        var aa = bt.Name;
                        ThuVien.mySQL getPro = new ThuVien.mySQL();
                        string pro = getPro.getProject(bt.Name);
                        aa = String.Format("" + pro.Trim() + ".{0}", aa) + "UC";
                        var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro.Trim() + ".dll").SingleOrDefault();
                        //var name = assembly.GetTypes();
                        var type = assembly.GetType(aa);
                        if (aa == "TiepNhan.mncTiepNhanBenhNhanUC")
                        {
                            //ShowHideBtnNghiepVu(true);
                        }
                        else
                        {
                            //ShowHideBtnNghiepVu(false);
                        }
                        //"TiepNhan.mncTiepNhanBenhNhanUC"

                        UserControl newTab = Activator.CreateInstance(type) as UserControl;
                        clsAddTabDll.AddTab(xtraTabControl1, "", bt.Name, bt.Text, newTab);
                        ThuVien.loadform.controlBar.Add(true);
                        ThuVien.loadform.controlBar.Add(true);
                        ThuVien.loadform.controlBar.Add(true);
                        ThuVien.loadform.controlBar.Add(false);
                        showcontrolBar(ThuVien.loadform.controlBar, xtraTabControl1.SelectedTabPageIndex);
                        //ThuVien.loadform.disableControl(this.xtraTabControl1.SelectedTabPage);
                    }
                }
            }
        }

        private void checkRole(EntityClass.cls_PhanQuyenGroupMenu pq, DataRow dr)
        {
            if (pq.mvarAdd_New == false)
            {
                them = false;
            }
            if (pq.mvarDelete_Value == false)
            {
                xoa = false;
            }
            if (pq.mvarEdit_Value == false)
            {
                sua = false;
            }
        }

        private void SetRole()
        {
            bool check = false;
            string groupId = ThuVien.mySQL.getValues("select Group_Id From Sys_UserGroups where User_Id='" + ThuVien.loadform.userID.ToString() + "'");
            DataTable dt = ThuVien.mySQL.ExcDT("select * from Sys_UserGroups u join Sys_PhanQuyenGroupMenu c on u.Group_Id= c.Group_Id join Menu d on c.Menu_Id =d.Id where u.User_Id = '" + ThuVien.loadform.userID.ToString() + "'");
            foreach (ToolStripMenuItem toolItem in menuStrip1.Items)
            {
                foreach (ToolStripMenuItem sub in toolItem.DropDownItems)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (sub.Name == dt.Rows[i]["MenuName"].ToString() && Convert.ToBoolean(dt.Rows[i]["Visible"]) == false)
                        {
                            sub.Visible = false;
                        }
                        foreach (ToolStripMenuItem subitem in sub.DropDownItems)
                        {
                            if (dt.Rows[i]["MenuName"].ToString() == subitem.Name && Convert.ToBoolean(dt.Rows[i]["Visible"]) == false)
                            {
                                subitem.Visible = false;
                                break;
                            }
                        }
                    }

                }
            }
        }

        public void showcontrolBar(List<bool> lsct, int index)
        {
            btnThem.Enabled = lsct[index * 4];
            btnXoa.Enabled = lsct[index * 4 + 1];
            btnSua.Enabled = lsct[index * 4 + 2];
            btnLuu.Enabled = lsct[index * 4 + 3];
        }

        private void xtraTabControl1_CloseButtonClick_1(object sender, EventArgs e)
        {
            if (!btnLuu.Enabled)
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                ThuVien.loadform.controlBar.RemoveRange(xtraTabControl1.SelectedTabPageIndex * 4, 4);
                DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
                DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
                (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();
            }
            else
            {
                DialogResult res = MessageBox.Show("thoat va khong luu du lieu", "dong tab", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    btnLuu.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThem.Enabled = false;
                    ThuVien.loadform.controlBar.RemoveRange(xtraTabControl1.SelectedTabPageIndex * 4, 4);
                    DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
                    DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
                    (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThuVien.loadform.enableControl(this.xtraTabControl1.SelectedTabPage);
            ThuVien.loadform.clearForm(this.xtraTabControl1.SelectedTabPage);
            ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 1] = false;
            ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 2] = false;
            ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 3] = true;
            showcontrolBar(ThuVien.loadform.controlBar, xtraTabControl1.SelectedTabPageIndex);
            try
            {
                string nameTab = xtraTabControl1.SelectedTabPage.Name;  //Lay ten tabname hien tai

                ThuVien.mySQL getPro = new ThuVien.mySQL(); //Lay ten project cua doi tuong
                string pro = getPro.getProject(nameTab).Trim();

                var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro + ".dll").SingleOrDefault();
                Type t = assembly.GetType(pro + "." + nameTab + "UC");
                MethodInfo method = t.GetMethod("addCommand");

                foreach (var xx in xtraTabControl1.SelectedTabPage.Controls)
                {
                    method.Invoke(xx, null);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThuVien.loadform.enableControl(this.xtraTabControl1.SelectedTabPage);
            ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 0] = false;
            ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 1] = false;
            ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 3] = true;
            showcontrolBar(ThuVien.loadform.controlBar, xtraTabControl1.SelectedTabPageIndex);
            try
            {
                string nameTab = xtraTabControl1.SelectedTabPage.Name;  //Lay ten tabname hien tai

                ThuVien.mySQL getPro = new ThuVien.mySQL(); //Lay ten project cua doi tuong
                string pro = getPro.getProject(nameTab).Trim();

                var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro + ".dll").SingleOrDefault();
                Type t = assembly.GetType(pro + "." + nameTab + "UC");
                MethodInfo method = t.GetMethod("editCommand");

                foreach (var xx in xtraTabControl1.SelectedTabPage.Controls)
                {
                    method.Invoke(xx, null);
                }
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du lieu duoc chon se bi xoa. Ban co dong y khong?", "Xoa du lieu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                string nameTab = xtraTabControl1.SelectedTabPage.Name;  //Lay ten tabname hien tai

                ThuVien.mySQL getPro = new ThuVien.mySQL(); //Lay ten project cua doi tuong
                string pro = getPro.getProject(nameTab).Trim();

                var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro + ".dll").SingleOrDefault();
                Type t = assembly.GetType(pro + "." + nameTab + "UC");
                MethodInfo method = t.GetMethod("deleteCommand");

                foreach (var xx in xtraTabControl1.SelectedTabPage.Controls)
                {
                    method.Invoke(xx, null);
                }
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //ThuVien.loadform.disableControl(this.xtraTabControl1.SelectedTabPage);
                ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4] = true;
                ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 1] = true;
                ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 2] = true;
                ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 3] = false;
                showcontrolBar(ThuVien.loadform.controlBar, xtraTabControl1.SelectedTabPageIndex);
                //ThuVien.loadform.clearForm(this.xtraTabControl1.SelectedTabPage);
                string nameTab = xtraTabControl1.SelectedTabPage.Name;  //Lay ten tabname hien tai

                ThuVien.mySQL getPro = new ThuVien.mySQL(); //Lay ten project cua doi tuong
                string pro = getPro.getProject(nameTab).Trim();

                var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro + ".dll").SingleOrDefault();
                Type t = assembly.GetType(pro + "." + nameTab + "UC");
                MethodInfo method = t.GetMethod("saveCommand");

                foreach (var xx in xtraTabControl1.SelectedTabPage.Controls)
                {
                    method.Invoke(xx, null);
                }

            }
            catch { }

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            try
            {
                //ThuVien.loadform.disableControl(this.xtraTabControl1.SelectedTabPage);
                ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4] = true;
                ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 1] = true;
                ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 2] = true;
                ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 3] = false;
                showcontrolBar(ThuVien.loadform.controlBar, xtraTabControl1.SelectedTabPageIndex);
                //ThuVien.loadform.clearForm(this.xtraTabControl1.SelectedTabPage);
                string nameTab = xtraTabControl1.SelectedTabPage.Name;  //Lay ten tabname hien tai

                ThuVien.mySQL getPro = new ThuVien.mySQL(); //Lay ten project cua doi tuong
                string pro = getPro.getProject(nameTab).Trim();

                var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro + ".dll").SingleOrDefault();
                Type t = assembly.GetType(pro + "." + nameTab + "UC");
                MethodInfo method = t.GetMethod("backCommand");

                foreach (var xx in xtraTabControl1.SelectedTabPage.Controls)
                {
                    method.Invoke(xx, null);
                }

            }
            catch { }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                showcontrolBar(ThuVien.loadform.controlBar, xtraTabControl1.SelectedTabPageIndex);
                // ẩn hiện nút nghiệp vụ tab tiếp nhận bệnh nhân
                if (xtraTabControl1.SelectedTabPage.Text == "Tiếp nhận bệnh nhân")
                {
                    //ShowHideBtnNghiepVu(true);
                }
                else
                {
                    //ShowHideBtnNghiepVu(false);
                }
            }
            catch
            {
            }

        }

        private void mncDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "HIS", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mncDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DoiMatKhau frDMK = new DoiMatKhau();
            //frDMK.ShowDialog();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    ThuVien.loadform.enableControl(this.xtraTabControl1.SelectedTabPage);
                    ThuVien.loadform.clearForm(this.xtraTabControl1.SelectedTabPage);
                    ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 1] = false;
                    ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 2] = false;
                    ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 3] = true;
                    showcontrolBar(ThuVien.loadform.controlBar, xtraTabControl1.SelectedTabPageIndex);
                    try
                    {
                        string nameTab = xtraTabControl1.SelectedTabPage.Name;  //Lay ten tabname hien tai

                        ThuVien.mySQL getPro = new ThuVien.mySQL(); //Lay ten project cua doi tuong
                        string pro = getPro.getProject(nameTab).Trim();

                        var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro + ".dll").SingleOrDefault();
                        Type t = assembly.GetType(pro + "." + nameTab + "UC");
                        MethodInfo method = t.GetMethod("addCommand");

                        foreach (var xx in xtraTabControl1.SelectedTabPage.Controls)
                        {
                            method.Invoke(xx, null);
                        }
                    }
                    catch { }
                    return true;
                case Keys.F2:
                    ThuVien.loadform.enableControl(this.xtraTabControl1.SelectedTabPage);
                    ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 0] = false;
                    ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 1] = false;
                    ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 3] = true;
                    showcontrolBar(ThuVien.loadform.controlBar, xtraTabControl1.SelectedTabPageIndex);
                    try
                    {
                        string nameTab = xtraTabControl1.SelectedTabPage.Name;  //Lay ten tabname hien tai

                        ThuVien.mySQL getPro = new ThuVien.mySQL(); //Lay ten project cua doi tuong
                        string pro = getPro.getProject(nameTab).Trim();

                        var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro + ".dll").SingleOrDefault();
                        Type t = assembly.GetType(pro + "." + nameTab + "UC");
                        MethodInfo method = t.GetMethod("editCommand");

                        foreach (var xx in xtraTabControl1.SelectedTabPage.Controls)
                        {
                            method.Invoke(xx, null);
                        }
                    }
                    catch { }
                    return true;
                case Keys.F3:
                    try
                    {
                        ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4] = true;
                        ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 1] = true;
                        ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 2] = true;
                        ThuVien.loadform.controlBar[xtraTabControl1.SelectedTabPageIndex * 4 + 3] = false;
                        showcontrolBar(ThuVien.loadform.controlBar, xtraTabControl1.SelectedTabPageIndex);
                        string nameTab = xtraTabControl1.SelectedTabPage.Name;  //Lay ten tabname hien tai

                        ThuVien.mySQL getPro = new ThuVien.mySQL(); //Lay ten project cua doi tuong
                        string pro = getPro.getProject(nameTab).Trim();

                        var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro + ".dll").SingleOrDefault();
                        Type t = assembly.GetType(pro + "." + nameTab + "UC");
                        MethodInfo method = t.GetMethod("saveCommand");

                        foreach (var xx in xtraTabControl1.SelectedTabPage.Controls)
                        {
                            method.Invoke(xx, null);
                        }

                    }
                    catch { }
                    return true;
                case Keys.Delete:
                    MessageBox.Show("Du lieu duoc chon se bi xoa. Ban co dong y khong?", "Xoa du lieu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    try
                    {
                        string nameTab = xtraTabControl1.SelectedTabPage.Name;  //Lay ten tabname hien tai

                        ThuVien.mySQL getPro = new ThuVien.mySQL(); //Lay ten project cua doi tuong
                        string pro = getPro.getProject(nameTab).Trim();

                        var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro + ".dll").SingleOrDefault();
                        Type t = assembly.GetType(pro + "." + nameTab + "UC");
                        MethodInfo method = t.GetMethod("deleteCommand");

                        foreach (var xx in xtraTabControl1.SelectedTabPage.Controls)
                        {
                            method.Invoke(xx, null);
                        }
                    }
                    catch { }
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                string nameTab = xtraTabControl1.SelectedTabPage.Name;  //Lay ten tabname hien tai

                ThuVien.mySQL getPro = new ThuVien.mySQL(); //Lay ten project cua doi tuong
                string pro = getPro.getProject(nameTab).Trim();

                var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.ManifestModule.Name == pro + ".dll").SingleOrDefault();
                Type t = assembly.GetType(pro + "." + nameTab + "UC");
                MethodInfo method = t.GetMethod("printCommand");

                foreach (var xx in xtraTabControl1.SelectedTabPage.Controls)
                {
                    method.Invoke(xx, null);
                }
            }
            catch { }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TiepNhanToolStripMenuItem.Visible = false;
        }
    }
}