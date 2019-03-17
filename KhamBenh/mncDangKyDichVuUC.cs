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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using DevExpress.XtraTab;
using DevExpress.XtraGrid;

namespace KhamBenh
{
    public partial class mncDangKyDichVuUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai báo biến
        DataTable dataTb = new DataTable();
        int status;
        #endregion
        /*-----------------------------------------------*/
        #region Khởi tạo form
        public mncDangKyDichVuUC()
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

        private void mncDangKyDichVuUC_Load(object sender, EventArgs e)
        {
            //ThuVien.clsDangKyDichVu.LoadLkSoTiepNhan(lkSoTiepNhan);
            Common.clsControl.LoadLookup(lkSoTiepNhan, "Ds_TiepNhan_TrongNgay", 2, DateTime.Today.ToString());
            Common.clsControl.LoadLookup(lkNoiYeuCau, "KhoaKham", 2);
            Common.clsControl.LoadLookup(lkNoiThucHien, "KhoaKham", 2);
            Common.clsControl.LoadLookup(lkNhomDichVu, "NhomDichVuCapTren", 2);
            Common.clsControl.LoadLookup(lkBacSi, "BacSi", 2);
            //ThuVien.clsDangKyDichVu.LoadLoaiGia(lkLoaiGia);
            KhoiTaoGrTb(gridControl2, dataTb);
            txtSL.Text = "1";

        }

        #endregion
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
            status = 1;
            dataTb = new DataTable();
            KhoiTaoGrTb(gridControl2, dataTb);
            txtSL.Text = "1";
            return true;
        }
        public bool saveCommand()
        {
            SaveCLS(int.Parse(lkSoTiepNhan.Tag.ToString()), int.Parse(lbTenBenhNhan.Tag.ToString()), ThuVien.loadform.KhamBenh_Id_DKDV);
            status = 0;
            if ((this.Parent.Parent as XtraTabControl).SelectedTabPage.Text == "Đăng ký dịch vụ")
            {
                ThuVien.loadform.controlBar.RemoveRange((this.Parent.Parent as XtraTabControl).SelectedTabPageIndex * 4, 4);
                (this.Parent.Parent as XtraTabControl).TabPages.Remove((this.Parent.Parent as XtraTabControl).SelectedTabPage);
            }
            return true;
        }
        public void LoadThongTinKhamBenh(int tiepNhan_Id)
        {
            lkSoTiepNhan.EditValue = tiepNhan_Id;//ThuVien.loadform.TiepNhan_Id_DKDV;
            status = 1;
           // KhoiTaoGrTb(gridControl2, dataTb);
        }

        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí nghiệp vụ
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí sự kiện
        private void lkSoTiepNhan_EditValueChanged(object sender, EventArgs e)
        {
            int where = int.Parse(lkSoTiepNhan.EditValue.ToString());
            dataTb = new DataTable();
            
            EntityClass.cls_TiepNhan tn = new EntityClass.cls_TiepNhan();
            tn.Get_By_Key(where);
            EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
            bn.Get_By_Key(tn.mvarBenhNhan_Id);
            DataRow dtr = tn.getDoiTuong(tn.mvarDoiTuong_Id);

            EntityClass.cls_CLSYeuCau yc = new EntityClass.cls_CLSYeuCau();
            yc.GetListYeuCau(gridControl2, DateTime.Today, bn.mvarBenhNhan_Id);
           
            lkSoTiepNhan.Tag = tn.mvarTiepNhan_Id;
            lbTenBenhNhan.Text = bn.mvarTenBenhNhan;
            lbTenBenhNhan.Tag = bn.mvarBenhNhan_Id;
            lbDiaChi.Text = bn.mvarDiaChi;
            lbGioiTinh.Text = bn.mvarGioiTinh == "T" ? "Nam" : "Nữ";
            lbNamSinh.Text = bn.mvarNamSinh.ToString();

            lbDoiTuong.Text = dtr["TenDoiTuong"].ToString();
            lbDoiTuong.Tag = tn.mvarDoiTuong_Id;

            //txtSoPhieuYeuCau.Text = ttbn[11];
            //lkNoiYeuCau.EditValue = ttbn[12];
            //lkNhomDichVu.EditValue = ttbn[13];
            //lkMaDichVu.EditValue = ttbn[10];
            //lkNoiThucHien.EditValue = ttbn[14];
            ////lkLoaiGia.EditValue = ttbn[15];
            //txtSL.Text = ttbn[16];
            //txtDonGia.Text = ttbn[17];
            //txtChuanDoan.Text = ttbn[18];
            //txtGhiChu.Text = ttbn[19];
            //dtNgayYeuCau.Text = ttbn[21];

            try { lbTuoi.Text = (Int32.Parse(DateTime.Now.Year.ToString()) - Int32.Parse(bn.mvarNamSinh.ToString())).ToString(); }
            catch { }

            GridColumn colReceived = gridView2.Columns["TenNhomDichVu"];
            gridView2.BeginSort();
            try
            {
                gridView2.ClearGrouping();
                colReceived.GroupIndex = 0;
            }
            finally
            {
                gridView2.EndSort();
            }
            gridView2.ExpandAllGroups();
            KhoiTaoGrTb(gridControl2, dataTb);
        }
        //Tô màu grv
        private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                e.Appearance.ForeColor = Color.Blue;
            }
        }

        private void lkNhomDichVu_EditValueChanged(object sender, EventArgs e)
        {
            Common.clsControl.LoadLookup(lkMaDichVu, "DichVu_NhomDichVu", 2, lkNhomDichVu.EditValue.ToString().Trim());
        }

        private void lkMaDichVu_EditValueChanged(object sender, EventArgs e)
        {
            //ThuVien.clsDangKyDichVu.NoiThucHien(lkNoiThucHien, lkMaDichVu.EditValue.ToString());
            if (lkMaDichVu.EditValue.ToString().Length > 0)
            {
                string where = lkMaDichVu.EditValue.ToString();
                //TiepNhanBenhNhan(lkNoiThucHien, where);
                //Common.clsControl.LoadLookup(lkNoiThucHien, "Ds_PhongBan",2, where);
                string sql = "SELECT TOP 1[hsvClinic].[dbo].[View_DM_DichVu_DonGia].DonGia FROM[hsvClinic].[dbo].[View_DM_DichVu_DonGia] WHERE DichVu_Id=" + where + " and LoaiGia_Id='27' ORDER BY BangGia_Id DESC";
                txtDonGia.Text = ThuVien.mySQL.getValues(sql);
                if (txtDonGia.Text.Length > 0)
                {
                    txtThanhTien.Text = (double.Parse(txtSL.Text) * double.Parse(txtDonGia.Text)).ToString();
                }
                else { txtThanhTien.Text = ""; }
            }
        }
        private void lkLoaiGia_EditValueChanged(object sender, EventArgs e)
        {
            //if (lkMaDichVu.Text.Length > 0)
            //{
            //    string where = lkMaDichVu.EditValue.ToString();
            //    ThuVien.clsDangKyDichVu.GetDonGia(txtDonGia, "DichVu_Id='" + where + "'" + "and LoaiGia_Id='" + lkLoaiGia.EditValue.ToString() + "'");
            //    if (txtDonGia.Text.Length > 0)
            //    {
            //        txtThanhTien.Text = (double.Parse(txtSL.Text) * double.Parse(txtDonGia.Text)).ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không lấy được đơn giá.");
            //    }

            //}
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (lkMaDichVu.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ.");
            }
            else if (lkNoiThucHien.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn nơi khám.");
            }
            //else if (lkLoaiGia.Text.Length <= 0)
            //{
            //    MessageBox.Show("Vui lòng chọn loại giá.");
            //}
            else if (txtSL.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng.");
            }

            else
            {
                EntityClass.cls_CLSYeuCau ClsYc = new EntityClass.cls_CLSYeuCau();
                string sophieu = ClsYc.getSoPhieuYeuCau();

                string sql = "SELECT TOP 1[hsvClinic].[dbo].[View_DM_DichVu_DonGia].DonGia FROM[hsvClinic].[dbo].[View_DM_DichVu_DonGia] WHERE DichVu_Id=" + lkMaDichVu.EditValue.ToString() + " and LoaiGia_Id='6' ORDER BY BangGia_Id DESC";
                string donGiaHoTro = ThuVien.mySQL.getValues(sql);

                sql = "SELECT Top 1 TyLe_2 FROM [hsvClinic].[dbo].[View_DM_DoiTuong] where DoiTuong_Id ='" + lbDoiTuong.Tag.ToString() + "'";
                string tyLe = ThuVien.mySQL.getValues(sql);

                string bhThanhToan = "0";

                try
                {
                    bhThanhToan = (double.Parse(donGiaHoTro) * double.Parse(tyLe)).ToString();
                }
                catch
                {
                    donGiaHoTro = "0";
                }
                AddDataGrv(gridControl2, dataTb, lkNoiThucHien.EditValue.ToString(), "", lkMaDichVu.Text, txtSL.Text, txtDonGia.Text, txtThanhTien.Text, lkLoaiGia.Text, bhThanhToan, lkNoiThucHien.Text, "", "", lkNhomDichVu.EditValue.ToString(), lkNhomDichVu.Text.Trim(), lkMaDichVu.EditValue.ToString());
                GridColumn colReceived = gridView2.Columns["TenNhomDichVu"];
                gridView2.BeginSort();
                try
                {
                    gridView2.ClearGrouping();
                    colReceived.GroupIndex = 0;
                }
                finally
                {
                    gridView2.EndSort();
                }
            }

        }

        #endregion
        /*-----------------------------------------------*/
        #region Các hàm con
        //Lưu thông tin yêu cầu cls
        private void SaveCLS(int tiepNhan_Id, int benhNhan_Id, int khamBenh_Id)
        {
            //List<string> maNhomDichVu = new List<string>();
            Dictionary<string, int> maNhomDichVu = new Dictionary<string, int>();
            for (int i = 0; i < dataTb.Rows.Count; i++)
            {
                string NhomDichVu_Id = dataTb.Rows[i]["NhomDichVu_Id"].ToString();
                bool isSave = false;
                try
                {
                    if (maNhomDichVu[NhomDichVu_Id] > 0)
                    {
                        isSave = true;
                    }
                }
                catch { }

                if (!isSave)
                {
                    EntityClass.cls_CLSYeuCau clsYc = new EntityClass.cls_CLSYeuCau();
                    clsYc.mvarSoPhieuYeuCau = clsYc.getSoPhieuYeuCau();
                    clsYc.mvarNgayYeuCau = DateTime.Today;
                    clsYc.mvarThoiGianYeuCau = DateTime.Now;
                    clsYc.mvarNgayGioYeuCau = DateTime.Now;
                    clsYc.mvarNguoiTao_Id = ThuVien.loadform.userID;
                    clsYc.mvarNoiYeuCau_Id = ThuVien.loadform.PhongBanID;
                    clsYc.mvarNamYeuCau = short.Parse(DateTime.Now.Year.ToString());
                    clsYc.mvarThangYeuCau = byte.Parse(DateTime.Now.Month.ToString());

                    clsYc.mvarNoiThucHien_Id = Int32.Parse(dataTb.Rows[i]["NoiThucHien_Id"].ToString());
                    clsYc.mvarBenhNhan_Id = benhNhan_Id;
                    clsYc.mvarTiepNhan_Id = tiepNhan_Id;
                    clsYc.mvarNhomDichVu_Id = int.Parse(dataTb.Rows[i]["NhomDichVu_Id"].ToString());
                    clsYc.mvarCLSYeuCau_Id = int.Parse(clsYc.Add());
                    maNhomDichVu.Add(NhomDichVu_Id, clsYc.mvarCLSYeuCau_Id);
                    EntityClass.cls_CLSYeuCauChiTiet clsYcCt = new EntityClass.cls_CLSYeuCauChiTiet();
                    clsYcCt.mvarCLSYeuCau_Id = clsYc.mvarCLSYeuCau_Id;
                    clsYcCt.mvarDichVu_Id = int.Parse(dataTb.Rows[i]["DichVu_Id"].ToString());
                    clsYcCt.mvarPhongBan_Id = int.Parse(dataTb.Rows[i]["NoiThucHien_Id"].ToString());
                    clsYcCt.mvarDonGiaDoanhThu = decimal.Parse(dataTb.Rows[i]["DonGiaDoanhThu"].ToString());
                    clsYcCt.mvarDonGiaHoTroChiTra = decimal.Parse(dataTb.Rows[i]["DonGiaHoTroChiTra"].ToString());
                    //clsYcCt.mvarDonGiaHoTro = decimal.Parse(dataTb.Rows[i]["DonGiaHoTro"].ToString());
                    clsYcCt.mvarDonGiaThanhToan = decimal.Parse(dataTb.Rows[i]["DonGiaThanhToan"].ToString());
                    clsYcCt.mvarTienTe_Id = "VND";
                    clsYcCt.mvarTyGia = 1;
                    clsYcCt.mvarSoLuong = 1;
                    clsYcCt.Add();
                }
                else
                {
                    EntityClass.cls_CLSYeuCauChiTiet clsYcCt = new EntityClass.cls_CLSYeuCauChiTiet();
                    clsYcCt.mvarCLSYeuCau_Id = maNhomDichVu[NhomDichVu_Id];
                    clsYcCt.mvarDichVu_Id = int.Parse(dataTb.Rows[i]["DichVu_Id"].ToString());
                    clsYcCt.mvarPhongBan_Id = int.Parse(dataTb.Rows[i]["NoiThucHien_Id"].ToString());
                    clsYcCt.mvarDonGiaDoanhThu = decimal.Parse(dataTb.Rows[i]["DonGiaDoanhThu"].ToString());
                    clsYcCt.mvarDonGiaHoTroChiTra = decimal.Parse(dataTb.Rows[i]["DonGiaHoTroChiTra"].ToString());
                    //clsYcCt.mvarDonGiaHoTro = decimal.Parse(dataTb.Rows[i]["DonGiaHoTro"].ToString());
                    clsYcCt.mvarDonGiaThanhToan = decimal.Parse(dataTb.Rows[i]["DonGiaThanhToan"].ToString());
                    clsYcCt.mvarTienTe_Id = "VND";
                    clsYcCt.mvarTyGia = 1;
                    clsYcCt.mvarSoLuong = 1;
                    clsYcCt.Add();
                }

            }
        }

        public void KhoiTaoGrTb(GridControl gr, DataTable dataTb)
        {
            dataTb.Columns.Add("MaNhomDichVu");
            dataTb.Columns.Add("TenDichVu");
            dataTb.Columns.Add("SoLuong");
            dataTb.Columns.Add("DonGiaDoanhThu");
            dataTb.Columns.Add("TenLoaiGia");
            dataTb.Columns.Add("DonGiaHoTroChiTra");
            dataTb.Columns.Add("DonGiaThanhToan");
            dataTb.Columns.Add("TenPhongBan");
            dataTb.Columns.Add("SoPhieuYeuCau");
            dataTb.Columns.Add("TenNhomDichVu");
            dataTb.Columns.Add("LoaiGia_Id");
            dataTb.Columns.Add("NhomDichVu_Id");
            dataTb.Columns.Add("NoiThucHien_Id");
            dataTb.Columns.Add("DichVu_Id");
            //dataTb.Columns.Add("Huy");

            gr.DataSource = dataTb;
        }
        public static void AddDataGrv(GridControl gr, DataTable dataTb, String nth_Id, String MaNdv, String TenDv, String SL, String DGDT, String TTDT, String LG, String DGHTCT, String TenPb, String SoPhieu, String LD_Id, String Ndv_Id, String TenNdv, String Dv_Id)
        {

            DataRow dtr = dataTb.NewRow();
            dtr["MaNhomDichVu"] = MaNdv;
            dtr["TenDichVu"] = TenDv;
            dtr["SoLuong"] = SL;
            dtr["DonGiaDoanhThu"] = DGDT;
            //dtr["ThanhTienDanhThu"] = vl6;
            dtr["TenLoaiGia"] = LG;////
            dtr["DonGiaHoTroChiTra"] = DGHTCT;
            dtr["DonGiaThanhToan"] = (double.Parse(TTDT) - double.Parse(DGHTCT)).ToString();
            dtr["TenPhongBan"] = TenPb;
            dtr["SoPhieuYeuCau"] = SoPhieu;
            //dtr["LyDoKhongThu"] = vl11;
            //dtr["BHYTTuDongTien"] = vl12;
            dtr["TenNhomDichVu"] = TenNdv;
            dtr["LoaiGia_Id"] = LD_Id;
            dtr["NhomDichVu_Id"] = Ndv_Id;
            dtr["NoiThucHien_Id"] = nth_Id;
            dtr["DichVu_Id"] = Dv_Id;
            dataTb.Rows.Add(dtr);
            gr.DataSource = dataTb;

        }

        #endregion

    }
}