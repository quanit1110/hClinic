using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ThuVien;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Win;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.XtraTab;

namespace KhamBenh
{
    public partial class mncKhamBenhUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai báo biến
        System.Timers.Timer refresh = new System.Timers.Timer(10000);
        Timer tmr = new Timer();
        int status;
        int HuongGiaiQuyet_Id=int.MinValue,DichVu_Id = int.MinValue, BenhNhan_Id = int.MinValue, TiepNhan_Id =int.MinValue;
        ThuVien.AddTab_DLL clsAddTabDll = new ThuVien.AddTab_DLL();
        string CachGQ_NhapVien = "457";
        string CachGQ_ChoCLS = "460";
        string CachGQ_CapToa = "454";
        string CachGQ_DTNT = "455";
        string CachGQ_CapToaTaiKham = "456";
        string CachGQ_KhongToa = "1331";
        string CachGQ_ChuyenTuyen = "458";
        #endregion
        /*-----------------------------------------------*/
        #region Khởi tạo form
        public mncKhamBenhUC()
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
        private void mncKhamBenhUC_Load(object sender, EventArgs e)
        {
            ThuVien.loadform.disableControl(this);
            this.txtMaYTe2.Focus();
            DataTable dt = new DataTable();

            Common.clsControl.LoadLookup(lkPhongKham, "KhoaKham", 2);
            Common.clsControl.LoadLookup(lkBacSiKham, "BacSi", 2);
            lkBacSiKham.EditValue = 10806;
            lkPhongKham.EditValue = 5063;
            ThuVien.loadform.PhongBanID = int.Parse("5063");

            EntityClass.cls_KhamBenh kb = new EntityClass.cls_KhamBenh();
            kb.GetListKhamBenh(grcBenhNhan, DateTime.Today);

            KhoiTaoGrTb(gridControl2, dt);
            Common.clsControl.LoadLookup(lkMaICD, "DsICD", 3, "", "ICD_Id");
            Common.clsControl.LoadLookup(lkCachGiaiQuyet, "CachGiaiQuyet", 2);
            Common.clsControl.LoadLookup(lkBenhManTinh, "DM_BenhManTinh", 2);
            //Common.clsControl.LoadLookup(lkKhoPhat, "KhamBenh_KhoPhatThuoc", 2);

            Load_Lookup(repositoryItemLookUpEdit1, "Duoc_Id", "TenDuocDayDu", "[hsvClinic].[dbo].[View_Duoc_GiaBan]", "TamNgung = '0'");
            Load_Lookup(repositoryItemLookUpEdit2, "Dictionary_Id", "Dictionary_Name", "[hsvClinic].[dbo].[view_Lst_Dictionary]", "Dictionary_Type_Code = 'duongdung'");
            Load_Lookup(repositoryItemLookUpEdit3, "DonViTinh_Id", "TenDonViTinh", "[hsvClinic].[dbo].[DM_DonViTinh]", "TamNgung != 1");

            //ThuVien.clsKhamBenh.loadTxtChuanDoan(txtChuanDoan);

        }

        #endregion
                    /*-----------------------------------------------*/
        #region Hàm chức năng
        public bool editCommand()
        {
            status = 3;
            return true;
        }

        public bool deleteCommand()
        {
            status = 2;
            return true;
        }
        public bool addCommand()
        {
            for (int i = 0; i < gridView2.RowCount;)
                gridView2.DeleteRow(i);
            status = 1;
            return true;
        }
        public bool saveCommand()
        {
            if (lkCachGiaiQuyet.EditValue != null)
            {
                int khamBenh_Id= LuuKhamBenhData();
                if (lkCachGiaiQuyet.EditValue.ToString() == CachGQ_NhapVien)
                {
                    EntityClass.cls_NoiTru_NhapVien ntnv = new EntityClass.cls_NoiTru_NhapVien();
                    ntnv.mvarTiepNhan_Id = TiepNhan_Id;
                    ntnv.mvarNgayNhapVien = DateTime.Today;
                    ntnv.mvarThoiGianNhapVien = DateTime.Now;
                    ntnv.mvarNoiNhapVien_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
                    ntnv.mvarKhoaDieuTri_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
                    ntnv.mvarCapCuu = false;
                    ntnv.mvarLyDoNhapVien_Id = lkLyDo.EditValue != null ? int.Parse(lkLyDo.EditValue.ToString()) : int.MinValue;
                    ntnv.mvarKhamBenh_Id = khamBenh_Id;
                    ntnv.Add();
                }
                updateCLSYeuCau(TiepNhan_Id, khamBenh_Id);
                if (lkCachGiaiQuyet.EditValue.ToString() == CachGQ_CapToa || lkCachGiaiQuyet.EditValue.ToString() == CachGQ_CapToaTaiKham || lkCachGiaiQuyet.EditValue.ToString() == CachGQ_DTNT)
                {
                    EntityClass.cls_KhamBenh_ToaThuoc kbtt = new EntityClass.cls_KhamBenh_ToaThuoc();
                    kbtt.mvarSoThuTuToa = kbtt.getSoThuTuToa();
                    kbtt.mvarKhamBenh_Id = khamBenh_Id;

                    int khamBenhToaThuoc_Id= LuuKhamBenhToaThuoc(kbtt);

                    LuuToaThuoc(khamBenh_Id, kbtt.mvarSoThuTuToa, khamBenhToaThuoc_Id);
                    

                }
                if (lkCachGiaiQuyet.EditValue.ToString() == CachGQ_ChoCLS)
                {
                    int t = 0;
                    ThuVien.loadform.TiepNhan_Id_DKDV = TiepNhan_Id;
                    ThuVien.loadform.KhamBenh_Id_DKDV = khamBenh_Id;
                    foreach (DevExpress.XtraTab.XtraTabPage tab in (this.Parent.Parent as XtraTabControl).TabPages)
                    {
                        if (tab.Text == "Đăng ký dịch vụ")
                        {
                            foreach (Control a in tab.Controls)
                            {
                                (a as mncDangKyDichVuUC).LoadThongTinKhamBenh(TiepNhan_Id);
                            }
                            (this.Parent.Parent as XtraTabControl).SelectedTabPage = tab;

                            t = 1;
                        }
                    }
                    if (t == 1)
                    {

                    }
                    else
                    {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào

                        mncDangKyDichVuUC newTab = new KhamBenh.mncDangKyDichVuUC();
                        ThuVien.loadform.controlBar.Add(true);
                        ThuVien.loadform.controlBar.Add(true);
                        ThuVien.loadform.controlBar.Add(true);
                        ThuVien.loadform.controlBar.Add(false);
                        clsAddTabDll.AddTab((this.Parent.Parent as XtraTabControl), "", "mncDangKyDichVu", "Đăng ký dịch vụ", newTab);
                        newTab.LoadThongTinKhamBenh(TiepNhan_Id);
                    }
                }
                status = 0;
                lkCachGiaiQuyet.EditValue = null;
                lkMaICD.EditValue = null;
                clearForm();
                ThuVien.loadform.disableControl(this);
                EntityClass.cls_KhamBenh kb = new EntityClass.cls_KhamBenh();
                kb.GetListKhamBenh(grcBenhNhan, DateTime.Today);
                TiepNhan_Id = int.MinValue;
                DichVu_Id = int.MinValue;
                HuongGiaiQuyet_Id = int.MinValue;
                BenhNhan_Id = int.MinValue;
                for (int i = 0; i < gridView2.RowCount;)
                    gridView2.DeleteRow(i);
            }
            return true;
        }
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí nghiệp vụ
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí sự kiện
        private void lkCachGiaiQuyet_EditValueChanged(object sender, EventArgs e)
        {
            if(lkCachGiaiQuyet.EditValue != null)
            {
                if(lkCachGiaiQuyet.EditValue.ToString()== CachGQ_NhapVien)
                {
                    lbKhoa.Visible = true;
                    lbLyDo.Visible = true;
                    lkKhoaDieuTri.Visible = true;
                    lkLyDo.Visible = true;
                    Common.clsControl.LoadLookup(lkKhoaDieuTri, "KhoaKham", 2);
                    Common.clsControl.LoadLookup(lkLyDo, "LyDoNhapVien", 2);
                    lkKhoaDieuTri.EditValue = 0;
                    lkLyDo.EditValue = 0;
                }
                else
                {
                    lbKhoa.Visible = false;
                    lbLyDo.Visible = false;
                    lkKhoaDieuTri.Visible = false;
                    lkLyDo.Visible = false;
                }
            }
        }
        private void txtMaYTe1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string sovaovien = (sender as TextEdit).Text.ToString();
                if (sovaovien.Trim().Length > 0)
                {
                    EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
                    bn.Get_By_MaYTe(sovaovien);

                    if (bn.mvarBenhNhan_Id > 0)
                    {
                        lbTenBenhNhan.Text = bn.mvarTenBenhNhan;
                        lbTenBenhNhan.Tag = bn.mvarBenhNhan_Id;
                        BenhNhan_Id= bn.mvarBenhNhan_Id;
                        if (bn.mvarGioiTinh == "T") { lbGioiTinh.Text = "Nam"; }
                        else { lbGioiTinh.Text = "Nữ"; }
                        lbNgaySinh.Text = bn.mvarNgaySinh.ToString("dd/MM/yyyy");
                        lbTuoi.Text = (Int32.Parse(DateTime.Now.ToString("yyyy")) - Int32.Parse(lbNgaySinh.Text.Split('/')[2])).ToString();
                        lbDiaChi.Text = bn.mvarDiaChi;
                        txtMaYTe1.Text = bn.mvarMaBenhVien;
                        txtMaYTe2.Text = bn.mvarSoVaoVien;

                        EntityClass.cls_KhamBenh kb = new EntityClass.cls_KhamBenh();
                        DataRow dtr = kb.getDoiTuong(bn.mvarBenhNhan_Id, DateTime.Today);
                        try
                        {
                            TiepNhan_Id = int.Parse(dtr["TiepNhan_Id"].ToString());
                            DichVu_Id = int.Parse(dtr["DichVu_Id"].ToString());
                            lbDoiTuong.Text = dtr["TenDoiTuong"].ToString();
                            lbDoiTuong.Tag = dtr["DoiTuong_Id"].ToString();
                            if (dtr["MaDoiTuong"].ToString() == "DV" || dtr["MaDoiTuong"].ToString() == "BHTN")
                            {
                                checkEdit1.Checked = true;
                                checkEdit2.Checked = false;
                            }
                            else
                            {
                                checkEdit2.Checked = true;
                                checkEdit1.Checked = false;
                            }
                        }
                        catch { }
                        dtKhamLuc.DateTime = DateTime.Now;
                    }
                }

            }
        }
        //Too mauf gridview
        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (sender is GridView)
            {
                GridView gView = (GridView)sender;
                if (!gView.IsValidRowHandle(e.RowHandle)) return;
                int parent = gView.GetParentRowHandle(e.RowHandle);
                if (gView.IsGroupRow(parent))
                {
                    for (int i = 0; i < gView.GetChildRowCount(parent); i++)
                    {
                        if (gView.GetChildRowHandle(parent, i) == e.RowHandle)
                        {
                            e.Appearance.BackColor = i % 2 == 0 ? Color.LightCyan : Color.White;
                        }
                    }
                }
                else
                {
                    e.Appearance.BackColor = e.RowHandle % 2 == 0 ? Color.LightCyan : Color.White;
                }
            }

            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string pro = view.GetRowCellDisplayText(e.RowHandle, view.Columns["TrangThai"]);
                string a = pro.Trim();
                if (a == "ChuaKham")
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Blue);
                    e.Appearance.BackColor2 = Color.White;
                }
                if (a == "ChoThucHienCLS")
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Pink);
                    e.Appearance.BackColor2 = Color.White;
                }

            }
        }
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.RowHandle < 0)
            { }
            else
            {
                GridView gView = (GridView)sender;
                DataRow _data = gView.GetDataRow(e.RowHandle);
                txtMaYTe1.Text = _data["MaYTe"].ToString().Split('.')[0];
                txtMaYTe2.Text = _data["MaYTe"].ToString().Split('.')[1];

                EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
                bn.Get_By_MaYTe(txtMaYTe2.Text);
                BenhNhan_Id = bn.mvarBenhNhan_Id;
                lbTenBenhNhan.Text = bn.mvarTenBenhNhan;
                lbGioiTinh.Text = bn.mvarGioiTinh == "T" ? "Nam" : "Nữ";
                lbNgaySinh.Text = bn.mvarNgaySinh.ToString("dd/MM/yyyy");
                lbTuoi.Text = (Int32.Parse(DateTime.Now.ToString("yyyy")) - Int32.Parse(lbNgaySinh.Text.Split('/')[2])).ToString();
                lbDiaChi.Text = bn.mvarDiaChi;

                EntityClass.cls_KhamBenh kb = new EntityClass.cls_KhamBenh();
                DataRow dtr = kb.getDoiTuong(bn.mvarBenhNhan_Id, DateTime.Today);
                try
                {

                    TiepNhan_Id = int.Parse(dtr["TiepNhan_Id"].ToString());
                    
                    lbDoiTuong.Text = dtr["TenDoiTuong"].ToString();
                    lbDoiTuong.Tag = dtr["DoiTuong_Id"].ToString();
                    if (dtr["MaDoiTuong"].ToString() == "DV" || dtr["MaDoiTuong"].ToString() == "BHTN")
                    {
                        checkEdit1.Checked = true;
                        checkEdit2.Checked = false;
                    }
                    else
                    {
                        checkEdit2.Checked = true;
                        checkEdit1.Checked = false;
                    }
                    DichVu_Id = int.Parse(dtr["DichVu_Id"].ToString());
                }
                catch { }

                dtKhamLuc.DateTime = DateTime.Now;
                Common.clsControl.LoadLookup(lkToaThuoc, "ToaThuoc_BenhNhan", 1);
       
                lkCachGiaiQuyet.EditValue = null;
                lkMaICD.EditValue = null;
                txtChuanDoanBenh.Text = "";
            }

        }
        //Set Size Lookup
        private void lkCachGiaiQuyet_Popup(object sender, EventArgs e)
        {
            PopupLookUpEditForm popupForm = (sender as IPopupControl).PopupWindow as PopupLookUpEditForm;
            popupForm.Size = new Size(480, 250);
        }
        private void lkToaThuoc_EditValueChanged(object sender, EventArgs e)
        {
            EntityClass.cls_ToaThuoc tt = new EntityClass.cls_ToaThuoc();
            tt.GetToaThuoc(gridControl2, lkToaThuoc.Text);
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                gridView2.SetRowCellValue(i, "ToaThuoc_Id", (i + 1));
            }
            gridView2.OptionsBehavior.ReadOnly = true;
        }
        private void repositoryItemLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            String duoc_id = (sender as BaseEdit).EditValue.ToString();
            string[] thongtinduoc = GetTenHoatChat(duoc_id);
            if (thongtinduoc.Length > 0)
            {
                gridView2.SetRowCellValue(-2147483647, gridView2.Columns["TenHoatChat"], thongtinduoc[0]);
                gridView2.SetRowCellValue(-2147483647, gridView2.Columns["DuongDung_Id"], thongtinduoc[1]);
                gridView2.SetRowCellValue(-2147483647, gridView2.Columns["DonViTinh_Id"], thongtinduoc[2]);
                gridView2.SetRowCellValue(-2147483647, gridView2.Columns["DonGiaDoanhThu"], thongtinduoc[3]);
            }
        }
        //Đổi màu text tokenedit
        private void txtChuanDoan_CustomDrawTokenText(object sender, TokenEditCustomDrawTokenTextEventArgs e)
        {
            e.Info.PaintAppearance.ForeColor = Color.Red;
            //e.Graphics.FillRectangle(Brushes.LightGreen, e.Info.Bounds);
            e.Info.PaintAppearance.DrawString(e.Cache, e.Description + ";", e.Bounds);
            e.Handled = true;
            //MessageBox.Show(e.Value.ToString());

        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            gridView2.OptionsBehavior.ReadOnly = false;
            DataTable dt = new DataTable();
            KhoiTaoGrTb(gridControl2, dt);
            repositoryItemButtonEdit1.ReadOnly = false;
        }
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridView2.DeleteSelectedRows();
        }
        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.Enter))
            {
                GridView gridView = sender as GridView;
                int rowHandle = gridView.FocusedRowHandle;
                GridColumn column = gridView.FocusedColumn;
                switch (column.FieldName)
                {
                    case "Duoc_Id":
                        column = gridView.Columns["SoLuong_BuoiSang"];
                        break;
                    case "SoLuong_BuoiSang":
                        column = gridView.Columns["SoLuong_BuoiTrua"];
                        break;
                    case "SoLuong_BuoiTrua":
                        column = gridView.Columns["SoLuong_BuoiChieu"];
                        break;
                    case "SoLuong_BuoiChieu":
                        column = gridView.Columns["SoLuong_BuoiToi"];
                        break;
                    case "SoLuong_BuoiToi":
                        column = gridView.Columns["SoNgay"];
                        break;
                    case "SoNgay":
                        column = gridView.Columns["GhiChu"];
                        break;
                    case "GhiChu":
                        column = gridView.Columns["Duoc_Id"];
                        gridView.AddNewRow();
                        break;
                }

                gridView.FocusedColumn = column;
                gridView.FocusedRowHandle = rowHandle;
                e.Handled = true;
            }
        }
        private void lkMaICD_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (lkMaICD.Text.Length > 0)
            {
                txtChuanDoanBenh.Text = txtChuanDoanBenh.Text + lkMaICD.Text + "; ";
            }
        }
        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle == -2147483647 && e.Column.FieldName == "SoNgay")
            {
                int soluong = 0, sang = 0, trua = 0, chieu = 0, toi = 0, tong = 0;
                double thanhtien = 0;
                try
                { tong = int.Parse(gridView2.GetRowCellValue(-2147483647, gridView2.Columns["SoLuong_BuoiSang"]).ToString()); }
                catch { }
                try { tong = tong + int.Parse(gridView2.GetRowCellValue(-2147483647, gridView2.Columns["SoLuong_BuoiTrua"]).ToString()); }
                catch { }
                try { tong = tong + int.Parse(gridView2.GetRowCellValue(-2147483647, gridView2.Columns["SoLuong_BuoiChieu"]).ToString()); }
                catch { }
                try { tong = tong + int.Parse(gridView2.GetRowCellValue(-2147483647, gridView2.Columns["SoLuong_BuoiToi"]).ToString()); }
                catch { }
                try { soluong = int.Parse(e.Value.ToString()) * tong; }
                catch { }
                try { thanhtien = soluong * double.Parse(gridView2.GetRowCellValue(-2147483647, gridView2.Columns["DonGiaDoanhThu"]).ToString()); }
                catch { }
                if (soluong > 0 && thanhtien > 0)
                {
                    gridView2.SetRowCellValue(-2147483647, gridView2.Columns["SoLuong"], soluong);
                    gridView2.SetRowCellValue(-2147483647, gridView2.Columns["ThanhTien"], thanhtien);
                }
            }
        }

        #endregion
                    /*-----------------------------------------------*/
        #region Các hàm con
        //Load RepositoryItemLoockupEdit
        public void Load_Lookup(RepositoryItemLookUpEdit cbo, string value1, string value2, string table, string where)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "Select distinct " + value1 + "," + value2 + " from " + table + " where " + where + "";
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("" + value1 + "", typeof(string));
                dt.Columns.Add("" + value2 + "", typeof(string));
                dt.Load(dr);
                cbo.DataSource = dt;
                cbo.ValueMember = "" + value1 + "";
                cbo.DisplayMember = "" + value2 + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }

        /* end */
        private void clearForm()
        {
            ThuVien.loadform.XoaForm(this);
            lbTenBenhNhan.Text = "";
            lbNgaySinh.Text = "";
            lbGioiTinh.Text = "";
            lbDoiTuong.Text = "";
            lbDiaChi.Text = "";
            lbTuoi.Text = "";
        }
        public void KhoiTaoGrTb(GridControl gr, DataTable dataTb)
        {
            dataTb.Columns.Add("Duoc_Id");
            dataTb.Columns.Add("TenHoatChat");
            dataTb.Columns.Add("DonViTinh_Id");
            dataTb.Columns.Add("SoLuong_BuoiSang");
            dataTb.Columns.Add("SoLuong_BuoiTrua");
            dataTb.Columns.Add("SoLuong_BuoiChieu");
            dataTb.Columns.Add("SoLuong_BuoiToi");
            dataTb.Columns.Add("SoNgay");
            dataTb.Columns.Add("SoLuong");
            dataTb.Columns.Add("DuongDung_Id");
            dataTb.Columns.Add("GhiChu");
            dataTb.Columns.Add("DonGiaDoanhThu");
            dataTb.Columns.Add("ThanhTien");
            dataTb.Columns.Add("DaChon");
            //dataTb.Columns.Add("Huy");
            gr.DataSource = dataTb;
        }
        public String[] GetTenHoatChat(string duoc_id)
        {
            List<string> _data = new List<string>();

            SqlConnection con = ThuVien.mySQL.Conn();
            try
            {
                string select = "Select Top 1 TenHoatChat,DuongDung_Id,DonViTinh_Id,DonGiaBan FROM [hsvClinic].[dbo].[View_Duoc_GiaBan] where Duoc_Id='" + duoc_id + "' Order by SoLoNhap_id Desc";
                DataRow dtr = ThuVien.mySQL.RtDataRow(select);

                _data.Add(dtr["TenHoatChat"].ToString());
                _data.Add(dtr["DuongDung_Id"].ToString());
                _data.Add(dtr["DonViTinh_Id"].ToString());
                _data.Add(dtr["DonGiaBan"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return new string[0];
            }

            return _data.ToArray();
        }
        private int LuuKhamBenhToaThuoc(EntityClass.cls_KhamBenh_ToaThuoc kbtt)
        {
            kbtt.mvarLoaiToaThuoc = "BV";
            kbtt.mvarBacSi_Id = int.Parse(lkBacSiKham.EditValue.ToString());
            kbtt.mvarNgayToaThuoc = DateTime.Today;
            kbtt.mvarThoiGianToaThuoc = DateTime.Now;
            kbtt.mvarGhiChu = txtLoiDan.Text;
            return int.Parse(kbtt.Add());
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -2147483647)
            {
                try
                {
                    if (gridView2.GetRowCellValue(e.FocusedRowHandle, gridView2.Columns["Duoc_Id"]).ToString().Length <= 0)
                    {
                        gridView2.DeleteSelectedRows();
                    }
                }
                catch { gridView2.DeleteSelectedRows(); }
            }
        }

        private void LuuToaThuoc(int khambenh_id, string sothututoa, int khambenhtoathuoc_Id)
        {
            try
            {
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRow dt = gridView2.GetDataRow(i);

                    EntityClass.cls_ToaThuoc tt = new EntityClass.cls_ToaThuoc();

                    tt.mvarKhamBenh_ToaThuoc_Id = khambenhtoathuoc_Id;
                    tt.mvarSoThuTuToa = sothututoa;
                    tt.mvarKhamBenh_Id = khambenh_id;

                    tt.mvarDuoc_Id = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["Duoc_Id"]).ToString());
                    tt.mvarSoLuong = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoLuong"]).ToString());
                    tt.mvarSoNgay = byte.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoNgay"]).ToString());
                    tt.mvarGhiChu = gridView2.GetRowCellValue(i, gridView2.Columns["GhiChu"]).ToString();
                    tt.mvarTienTe_Id = "VND";
                    tt.mvarNgayTao = DateTime.Today;
                    tt.mvarNguoiTao_Id = int.Parse(lkBacSiKham.EditValue.ToString());
                    try
                    {
                        tt.mvarSoLuong_BuoiSang = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoLuong_BuoiSang"]).ToString());
                    }
                    catch { }
                    try
                    {
                        tt.mvarSoLuong_BuoiTrua = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoLuong_BuoiTrua"]).ToString());
                    }
                    catch { }
                    try
                    {
                        tt.mvarSoLuong_BuoiChieu = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoLuong_BuoiChieu"]).ToString());
                    }
                    catch { }
                    try
                    {
                        tt.mvarSoLuong_BuoiToi = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["SoLuong_BuoiToi"]).ToString());
                    }
                    catch { }
                    try
                    {
                        tt.mvarDuongDung_Id = int.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["DuongDung_Id"]).ToString());
                    }
                    catch { }

                    tt.mvarDonGiaDoanhThu = decimal.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["DonGiaDoanhThu"]).ToString());
                    tt.mvarDonGiaThanhToan = decimal.Parse(gridView2.GetRowCellValue(i, gridView2.Columns["DonGiaDoanhThu"]).ToString());
                    tt.Add();
                    //cmd.Parameters.AddWithValue("@DonGiaDoanhThu", khambenhtoathuoc_Id);@DonGiaDoanhThu,@DonGiaHoTroChiTra,@DonGiaThanhToan,
                    //cmd.Parameters.AddWithValue("@DonGiaHoTroChiTra", sothututoa);DonGiaDoanhThu,DonGiaHoTroChiTra,DonGiaThanhToan,
                    //cmd.Parameters.AddWithValue("@DonGiaThanhToan", khambenh_id);
                }
            }
            catch
            {

            }


        }
        private int LuuKhamBenhData()
        {

            EntityClass.cls_KhamBenh kb = new EntityClass.cls_KhamBenh();
            kb.Get_By_TiepNhan_Id(TiepNhan_Id);
            if (kb.mvarKhamBenh_Id > 0)
            {
                kb.mvarBenhNhan_Id = BenhNhan_Id;
                kb.mvarTiepNhan_Id = TiepNhan_Id;

                kb.mvarNgayCapNhat = DateTime.Now;
                kb.mvarNguoiCapNhat_Id = int.Parse(lkBacSiKham.EditValue.ToString());

                kb.mvarChanDoanKhoaKham = txtChuanDoanBenh.Text;
                kb.mvarTrieuChungLamSang = txtTrieuChungLS.Text;

                kb.mvarHuongGiaiQuyet_Id = int.Parse(lkCachGiaiQuyet.EditValue.ToString());
                kb.mvarGhiChu = txtLoiDan.Text;
                kb.mvarDoiTuong_Id = int.Parse(lbDoiTuong.Tag.ToString());
                try
                {
                    kb.mvarChanDoanICD = lkMaICD.Text;
                    kb.mvarChanDoanICD_Id = int.Parse(lkMaICD.EditValue.ToString());
                }
                catch { }
                try { HuongGiaiQuyet_Id = int.Parse(lkCachGiaiQuyet.EditValue.ToString()); }
                catch { HuongGiaiQuyet_Id = int.MinValue; }

                if (HuongGiaiQuyet_Id == int.Parse(CachGQ_CapToaTaiKham))
                {
                    short songay = Convert.ToInt16(gridView2.GetRowCellValue(0, gridView2.Columns["SoNgay"]));
                    for (int i = 1; i < gridView2.RowCount; i++)
                    {
                        try
                        {
                            if (songay < Convert.ToInt16(gridView2.GetRowCellValue(i, gridView2.Columns["SoNgay"])))
                            {
                                songay = Convert.ToInt16(gridView2.GetRowCellValue(0, gridView2.Columns["SoNgay"]));
                            }
                        }
                        catch (Exception e) { MessageBox.Show(e.ToString()); }
                    }
                    kb.mvarSoNgayHenTaiKham = songay;
                }
                if (HuongGiaiQuyet_Id == int.Parse(CachGQ_NhapVien))
                {
                    try
                    {
                        kb.mvarNhapKhoa_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
                        kb.mvarLyDoNhapVien_Id = int.Parse(lkLyDo.EditValue.ToString());
                    }
                    catch { }
                }

                if (HuongGiaiQuyet_Id != int.Parse(CachGQ_ChoCLS))
                {
                    kb.mvarTrangThai = "DaKham";
                }
                else
                {
                    kb.mvarTrangThai = "ChoThucHienCLS";
                }
                return int.Parse(kb.Update());
            }
            else
            {
                kb.mvarBenhNhan_Id = BenhNhan_Id;
                kb.mvarTiepNhan_Id = TiepNhan_Id;
                kb.mvarDichVu_Id = DichVu_Id;
                kb.mvarPhongBan_Id = int.Parse(lkPhongKham.EditValue.ToString());
                kb.mvarNgayKham = DateTime.Today;
                kb.mvarNgayTao = DateTime.Today;
                kb.mvarNguoiTao_Id = int.Parse(lkBacSiKham.EditValue.ToString());
                kb.mvarThoiGianKham = DateTime.Now;
                kb.mvarBacSiKham_Id = int.Parse(lkBacSiKham.EditValue.ToString());
                kb.mvarChanDoanKhoaKham = txtChuanDoanBenh.Text;
                kb.mvarTrieuChungLamSang = txtTrieuChungLS.Text;

                kb.mvarHuongGiaiQuyet_Id = int.Parse(lkCachGiaiQuyet.EditValue.ToString());
                kb.mvarGhiChu = txtLoiDan.Text;
                kb.mvarDoiTuong_Id = int.Parse(lbDoiTuong.Tag.ToString());
                try
                {
                    kb.mvarChanDoanICD = lkMaICD.Text;
                    kb.mvarChanDoanICD_Id = int.Parse(lkMaICD.EditValue.ToString());
                }
                catch { }
                try { HuongGiaiQuyet_Id = int.Parse(lkCachGiaiQuyet.EditValue.ToString()); }
                catch { HuongGiaiQuyet_Id = int.MinValue; }

                //string chuandoan = "";
                //foreach (var item in txtChuanDoan.GetTokenList())
                //{
                //    chuandoan = chuandoan + item.ToString() + ",";
                //}

                if (HuongGiaiQuyet_Id == int.Parse(CachGQ_CapToaTaiKham))
                {
                    short songay = Convert.ToInt16(gridView2.GetRowCellValue(0, gridView2.Columns["SoNgay"]));
                    for (int i = 1; i < gridView2.RowCount; i++)
                    {
                        try
                        {
                            if (songay < Convert.ToInt16(gridView2.GetRowCellValue(i, gridView2.Columns["SoNgay"])))
                            {
                                songay = Convert.ToInt16(gridView2.GetRowCellValue(0, gridView2.Columns["SoNgay"]));
                            }
                        }
                        catch (Exception e) { MessageBox.Show(e.ToString()); }
                    }
                    kb.mvarSoNgayHenTaiKham = songay;
                }
                if (HuongGiaiQuyet_Id == int.Parse(CachGQ_NhapVien))
                {
                    try
                    {
                        kb.mvarNhapKhoa_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
                        kb.mvarLyDoNhapVien_Id = int.Parse(lkLyDo.EditValue.ToString());
                    }
                    catch { }
                }

                if (HuongGiaiQuyet_Id != int.Parse(CachGQ_ChoCLS))
                {
                    kb.mvarTrangThai = "DaKham";
                }
                else
                {
                    kb.mvarTrangThai = "ChoThucHienCLS";
                }
                return int.Parse(kb.Add());
            }
           
        }
        private void updateCLSYeuCau(int TiepNhan_Id, int khamBenh_Id)
        {
            EntityClass.cls_CLSYeuCau clsYc = new EntityClass.cls_CLSYeuCau();
            clsYc.Get_By_TiepNhan_Id(TiepNhan_Id);
            clsYc.mvarKhamBenh_Id = khamBenh_Id;
            clsYc.Update_KhamBenh_Id();
        }

        #endregion

    }
}
