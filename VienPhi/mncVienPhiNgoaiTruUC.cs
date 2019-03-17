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
using System.Data.SqlClient;
using DevExpress.XtraTab;
using BaoCao.Fm_Report;
namespace VienPhi
{
    public partial class mncVienPhiNgoaiTruUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai báo biến
        double tongtien = 0;
        int TiepNhan_TT = 0;
        int BenhNhan_TT = 0;
        int status = 0;
        string dangKyHoaDon_Id = "";
        #endregion
        /*-----------------------------------------------*/
        #region Khởi tạo form
        public mncVienPhiNgoaiTruUC()
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
        private void mncVienPhiNgoaiTruUC_Load(object sender, EventArgs e)
        {
            Common.clsControl.LoadLookup(lkMaYTe, "List_SoVaoVien", 1);
            Common.clsControl.LoadLookup(lkHinhThucTT, "DM_HinhThucThanhToan", 2);
            Common.clsControl.LoadLookup(lkNguoiThuTien, "TenNhanVien", 2);
            Common.clsControl.LoadLookup(lkDoiTuong, "DoiTuong", 2);
            //rdHoaDon.Checked = true;
            ThuVien.loadform.disableControl(this);
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
            status = 1;
            ThuVien.loadform.enableControl(this);
            return true;
        }
        public bool saveCommand()
        {

            LuuHoaDon(BenhNhan_TT, TiepNhan_TT);

            UpdateCLSYeuCauChiTiet();
            //UpdateToaThuoc();

            status = 0;
            BenhNhan_TT = 0;
            TiepNhan_TT = 0;
            ThuVien.loadform.XoaForm(this);
            if ((this.Parent.Parent as XtraTabControl).SelectedTabPage.Text == "Thanh toán")
            {
                ThuVien.loadform.controlBar.RemoveRange((this.Parent.Parent as XtraTabControl).SelectedTabPageIndex * 4, 4);
                (this.Parent.Parent as XtraTabControl).TabPages.Remove((this.Parent.Parent as XtraTabControl).SelectedTabPage);
            }
            return true;
        }
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí nghiệp vụ
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí sự kiện
        private void rd_CheckedChanged(object sender, EventArgs e)
        {
            DataRow tthd;//= new string[0];
            EntityClass.cls_HoaDon hd = new EntityClass.cls_HoaDon();

            if (rdHoaDon.Checked)
            {
                tthd = hd.getHoaDonHienTai("HD"); //ThuVien.clsThanhToan.ThongTinHoaDon("HD");
            }
            else //(rdThuTienGoi.Checked)
            {
                tthd = hd.getHoaDonHienTai("TG");// ThuVien.clsThanhToan.ThongTinHoaDon("TG");
            }

            try
            {
                if (int.Parse(tthd["So"].ToString()) == int.Parse(tthd["Max_No"].ToString()))
                {
                    MessageBox.Show("Cập nhật số hóa đơn");
                }
                else
                {
                    txtKyHieu.Text = tthd["LoaiHoaDon"].ToString();
                    txtSoQuyen.Text = tthd["SoQuyen"].ToString();
                    txtSoThuTu.Text = tthd["So"].ToString();

                    dangKyHoaDon_Id = tthd["DangKyHoaDon_Id"].ToString();
                    txtSoHoaDon.Text = hd.getSoHoaDon(tthd["SoSeries"].ToString(), "HD");
                }
            }
            catch
            {
                txtKyHieu.Text = tthd["LoaiHoaDon"].ToString();
                txtSoQuyen.Text = tthd["SoSeries"].ToString();
                txtSoThuTu.Text = "0";
            }
        }
        private void lkMaYTe_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (lkMaYTe.Text.Trim().Length > 0)
            {
                dtNgayThuTien.DateTime = DateTime.Now;
                EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
                bn.Get_By_MaYTe(lkMaYTe.Text);
                try
                {
                    EntityClass.cls_KhamBenh kb = new EntityClass.cls_KhamBenh();
                    DataRow dtr = kb.getDoiTuong(bn.mvarBenhNhan_Id, DateTime.Today);
                    lkDoiTuong.EditValue = int.Parse(dtr["DoiTuong_Id"].ToString());

                    BenhNhan_TT = bn.mvarBenhNhan_Id;
                    TiepNhan_TT = int.Parse(dtr["TiepNhan_id"].ToString());

                    lbHoTen.Text = bn.mvarTenBenhNhan;
                    lbDiaChiBenhNhan.Text = bn.mvarDiaChi;
                    lbTuoi.Text = (int.Parse(DateTime.Now.Year.ToString()) - int.Parse(bn.mvarNamSinh.ToString())).ToString();
                    EntityClass.cls_HoaDon hd = new EntityClass.cls_HoaDon();
                    hd.GetListDichVu_Thuoc(gridControl1, bn.mvarBenhNhan_Id);
                    //ThuVien.clsThanhToan.TaoHoaDon(gridControl1, lkMaYTe.Text);
                    GridColumn colReceived = gridView1.Columns["TenNhomDichVu"];
                    gridView1.BeginSort();
                    try
                    {
                        gridView1.ClearGrouping();
                        colReceived.GroupIndex = 0;
                    }
                    finally
                    {
                        gridView1.EndSort();
                    }
                    gridView1.ExpandAllGroups();

                    if (gridView1.DataRowCount == 1)
                    {
                        txtGiaTri.Text = "150000.00";
                        lbTongTien.Text = "150000.00";
                    }
                    else
                    {
                        bool fn = false;
                        if (gridView1.DataRowCount > 0)
                        {
                            for (int i = 0; i < gridView1.DataRowCount; i++)
                            {
                                if (gridView1.GetRowCellValue(i, gridView1.Columns["TenNhomDichVu"]).ToString() == "Thuốc BHYT" || gridView1.GetRowCellValue(i, gridView1.Columns["TenNhomDichVu"]).ToString() == "Thuốc dịch vụ")
                                {
                                    fn = true;
                                    i = gridView1.DataRowCount;
                                }
                            }
                        }
                        if (fn)
                        {
                            txtGiaTri.Text = (double.Parse(gridView1.Columns["BnThanhToan"].SummaryItem.SummaryValue.ToString()) - double.Parse(gridView1.Columns["BenhNhanDaThanhToan"].SummaryItem.SummaryValue.ToString())).ToString();
                            lbTongTien.Text = txtGiaTri.Text;
                        }
                        else
                        {
                            for (int i = 0; i < gridView1.DataRowCount; i++)
                            {
                                if (gridView1.GetRowCellValue(i, gridView1.Columns["TenNhomDichVu"]).ToString() == "Khám Bệnh")
                                {
                                    txtGiaTri.Text = (double.Parse(gridView1.Columns["BnThanhToan"].SummaryItem.SummaryValue.ToString()) - double.Parse(gridView1.Columns["BenhNhanDaThanhToan"].SummaryItem.SummaryValue.ToString()) + 150000 - double.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["BnThanhToan"]).ToString())).ToString();
                                    lbTongTien.Text = txtGiaTri.Text;
                                    i = gridView1.DataRowCount;
                                }
                            }
                        }
                    }
                }
                catch { MessageBox.Show("Không xác định được đối tượng."); }

            }
        }
        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "DonGiaHoTroChiTra")
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.FillRectangle(e.Cache, e.Bounds);
                e.Info.AllowDrawBackground = false;
            }
        }
        #endregion
        /*-----------------------------------------------*/
        #region Các hàm con
        public void LoadThongTinKhamBenh(int benhNhan_Id)
        {
            dtNgayThuTien.DateTime = DateTime.Now;
            EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
            bn.Get_By_Key(benhNhan_Id);// ThuVien.loadform.BenhNhan_Id_TnTT);
            lkMaYTe.EditValue = bn.mvarSoVaoVien;
            EntityClass.cls_KhamBenh kb = new EntityClass.cls_KhamBenh();
            DataRow dtr = kb.getDoiTuong(bn.mvarBenhNhan_Id, DateTime.Today);
            lkDoiTuong.EditValue = int.Parse(dtr["DoiTuong_Id"].ToString());

            BenhNhan_TT = bn.mvarBenhNhan_Id;
            TiepNhan_TT = int.Parse(dtr["TiepNhan_id"].ToString());

            lbHoTen.Text = bn.mvarTenBenhNhan;
            lbDiaChiBenhNhan.Text = bn.mvarDiaChi;
            lbTuoi.Text = (int.Parse(DateTime.Now.Year.ToString()) - int.Parse(bn.mvarNamSinh.ToString())).ToString();
            EntityClass.cls_HoaDon hd = new EntityClass.cls_HoaDon();
            hd.GetListDichVu_Thuoc(gridControl1, benhNhan_Id);// ThuVien.loadform.BenhNhan_Id_TnTT);
                                                              //ThuVien.clsThanhToan.TaoHoaDon(gridControl1, lkMaYTe.Text);
            GridColumn colReceived = gridView1.Columns["TenNhomDichVu"];
            gridView1.BeginSort();
            try
            {
                gridView1.ClearGrouping();
                colReceived.GroupIndex = 0;
            }
            finally
            {
                gridView1.EndSort();
            }
            gridView1.ExpandAllGroups();

            if (gridView1.DataRowCount == 1)
            {
                txtGiaTri.Text = "150000.00";
                lbTongTien.Text = "150000.00";
            }
            else
            {
                bool fn = false;
                if (gridView1.DataRowCount > 0)
                {
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        if (gridView1.GetRowCellValue(i, gridView1.Columns["TenNhomDichVu"]).ToString() == "Thuốc BHYT" || gridView1.GetRowCellValue(i, gridView1.Columns["TenNhomDichVu"]).ToString() == "Thuốc dịch vụ")
                        {
                            fn = true;
                            i = gridView1.DataRowCount;
                        }
                    }
                }
                if (fn)
                {
                    txtGiaTri.Text = (double.Parse(gridView1.Columns["BnThanhToan"].SummaryItem.SummaryValue.ToString()) - double.Parse(gridView1.Columns["BenhNhanDaThanhToan"].SummaryItem.SummaryValue.ToString())).ToString();
                    lbTongTien.Text = txtGiaTri.Text;
                }
                else
                {
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        if (gridView1.GetRowCellValue(i, gridView1.Columns["TenNhomDichVu"]).ToString() == "Khám Bệnh")
                        {
                            txtGiaTri.Text = (double.Parse(gridView1.Columns["BnThanhToan"].SummaryItem.SummaryValue.ToString()) - double.Parse(gridView1.Columns["BenhNhanDaThanhToan"].SummaryItem.SummaryValue.ToString()) + 150000 - double.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["BnThanhToan"]).ToString())).ToString();
                            lbTongTien.Text = txtGiaTri.Text;
                            i = gridView1.DataRowCount;
                        }
                    }
                }
            }
            ThuVien.loadform.enableControl(this);
            status = 1;
        }
        private void LuuHoaDon(int BenhNhan_Id_TnTT, int TiepNhan_Id_Tntt)
        {
            EntityClass.cls_HoaDon hd = new EntityClass.cls_HoaDon();
            hd.mvarSoHoaDon = txtSoHoaDon.Text;
            hd.mvarLoaiHoaDon = txtKyHieu.Text;
            hd.mvarSoQuyen = txtSoQuyen.Text;
            hd.mvarSo = int.Parse(txtSoHoaDon.Text.Split('.')[1]);
            hd.mvarTiepNhan_Id = TiepNhan_Id_Tntt;// ThuVien.loadform.TiepNhan_Id_Tntt;
            hd.mvarBenhNhan_Id = BenhNhan_Id_TnTT;// ThuVien.loadform.BenhNhan_Id_TnTT;
            hd.mvarNgayPhatSinh = DateTime.Today;
            hd.mvarThoiGianPhatSinh = DateTime.Now;
            hd.mvarNoiPhatSinh_Id = ThuVien.loadform.PhongBanID;
            hd.mvarNguoiLap_Id = ThuVien.loadform.userID;
            hd.mvarNoiThuTien_Id = ThuVien.loadform.PhongBanID;
            hd.mvarNguoiThuTien_Id = ThuVien.loadform.userID;
            hd.mvarGiaTriHoaDon = decimal.Parse(lbTongTien.Text);
            hd.mvarGiaTriThucThu = decimal.Parse(lbTongTien.Text);
            try { hd.mvarHinhThucThanhToan_Id = int.Parse(lkHinhThucTT.EditValue.ToString()); } catch { }
            hd.mvarTienTe_Id = "VND";
            hd.mvarDangKyHoaDon_Id = int.Parse(dangKyHoaDon_Id);
            int hoaDon_Id = int.Parse(hd.Add());
            Fm_ThuVienPhi_Rpr pfQrcode = new Fm_ThuVienPhi_Rpr(hoaDon_Id);
            pfQrcode.ShowDialog();
        }
        private void UpdateCLSYeuCauChiTiet()
        {
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, gridView1.Columns["BenhNhanDaThanhToan"]).ToString() == "0.00" && gridView1.GetRowCellValue(i, gridView1.Columns["TenNhomDichVu"]).ToString() != "Thuốc dịch vụ" && gridView1.GetRowCellValue(i, gridView1.Columns["TenNhomDichVu"]).ToString() != "Thuốc BHYT")
                {
                    EntityClass.cls_CLSYeuCau clsYc = new EntityClass.cls_CLSYeuCau();
                    clsYc.Update_CLSYeuCau(gridView1.GetRowCellValue(i, gridView1.Columns["SoPhieuYeuCau"]).ToString());
                }
            }
        }
        #endregion
    }
}
