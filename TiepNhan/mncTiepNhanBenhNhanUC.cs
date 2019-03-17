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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using ThuVien;
using System.Data.SqlClient;
using System.Globalization;
using ZXing;
using ZXing.Common;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTab;
using VienPhi;
using DevExpress.XtraEditors.Repository;
using BaoCao.Fm_Report;

namespace TiepNhan
{
    public partial class mncTiepNhanBenhNhanUC : DevExpress.XtraEditors.XtraUserControl
    {

        #region Khai báo biến
        double tongtien = 0;
        string dangKyHoaDon_Id = "";

        private string mabenhvien = "713303";
        private int dungtuyen = 1156;
        private int traituyen = 1157;
        ThuVien.AddTab_DLL clsAddTabDll = new ThuVien.AddTab_DLL();
        //EntityClass.clsDM_BenhNhan bn=new EntityClass.clsDM_BenhNhan();


        public const Char cGioiTinhNam = 'T';
        public const Char cGioiTinhNu = 'G';

       
        DataTable dataTb = new DataTable();
        
        private int status = 0;
        int benhnhanid = 0;
        private readonly IBarcodeReader barcodeReader;
        DataTable dt = new DataTable();


        #endregion
        /*-----------------------------------------------*/
        #region Khởi tạo from

        public mncTiepNhanBenhNhanUC()
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
            barcodeReader = new BarcodeReader();
        }
        private void mncTiepNhanBenhNhanUC_Load(object sender, EventArgs e)
        {
            Common.clsControl.LoadLookup_RepositoryItem(lkNoiThucHien, "KhoaKham", 2, "", "", "Tên phòng ban", "Id");
            Common.clsControl.LoadLookup(lkTinhThanh, "TinhThanhPho", 2, "", "", "Tỉnh thành", "Id");
            Common.clsControl.LoadLookup(lkQuocTich, "Lib_DanhMucQuocTich", 2, "", "", "Quốc tịch", "Id");
            Common.clsControl.LoadLookup(lkDanToc, "Lib_DanToc", 2, "", "", "Dân tộc", "Id");
            Common.clsControl.LoadLookup(lkHinhThucDen, "HinhThucDenKhamBenh", 2, "", "", "Hình thức đến", "Id");
            Common.clsControl.LoadLookup(lkLyDoTiepNhan, "LyDoTiepNhan", 2, "", "", "Lý do tiếp nhận", "Id");
            Common.clsControl.LoadLookup(lkNgheNghiep, "Lib_NgheNghiep", 2, "", "", "Nghề nghiệp", "Id");
            Common.clsControl.LoadLookup(lkTuyenKB, "TuyenKhamChuaBenh", 2, "", "", "Tuyến khám bệnh", "Id");
            Common.clsControl.LoadLookup_RepositoryItem(lkNhomDichVu, "NhomDichVuCapTren", 2, "", "", "Nhóm dịch vụ", "Id");//NhomDichVu_InTiepNhan
            Common.clsControl.LoadLookup(lkNoiDangKy, "NoiDangKiKhamChuaBenh", 3, "", "mabenhviendangky", "Nơi đăng ký", "Id", "Mã bệnh viện");
            Common.clsControl.LoadLookup(lkTuyenChuyen, "NoiGioiThieu", 2, "", "", "Tuyến chuyển", "Id");
            Common.clsControl.LoadLookup(lkNoiGioiThieu, "NoiGioiThieu", 2, "", "", "Nơi giới thiệu", "Id");
            Common.clsControl.LoadLookup(lkDoiTuong, "DoiTuong", 2, "", "", "Đối tượng", "Id");
            Common.clsControl.LoadLookup(lkCongTy, "KSK_CongTy", 2, "", "", "Công ty", "Id");
            loadGridView(gridControl2);


            KhoiTaoGrTb(gridControl3, dataTb);
            ThuVien.loadform.disableControl(this);

            //ThuVien.clsTiepNhan.MaYTe(lkMaYTe);
            //ThuVien.clsTiepNhan.LoadLoaiGia(lkLoaiGia);


            txtMaYTe.Enabled = true;
            txtHoTen.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtHoTen.Focus();

            //xtraTabControl2.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.Default;
            //Màn hình thanh toán
            Common.clsControl.LoadLookup(lkHinhThucTT, "DM_HinhThucThanhToan", 2);
            Common.clsControl.LoadLookup(lkNguoiThuTien, "TenNhanVien", 2);
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
        #endregion
        /*-----------------------------------------------*/
        #region Hàm chức năng

        public bool editCommand()
        {
            status = 3;
            return true;
        }
        public bool printCommand()
        {
            if (string.IsNullOrEmpty(txtMaYTe.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần mã hóa",
                    "QR Code Generator");
                return true;
            }

            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 150,
                    Width = 150,
                    Margin = 0
                }
            };
            createnewrow();
            DataTable dt = ThuVien.loadform.DataSet_Img.Tables["table1"];
            DataRow dtr = dt.Rows[0];
            string content = Common.clsQrCode.HamTaoChuoi_QRCODE(txtMaYTe.Text, dtr[1].ToString(), dtr[3].ToString(), dtr[2].ToString(), dtr[4].ToString(), dtr[5].ToString());

            using (var bitmap = barcodeWriter.Write(content))
            {
                using (var stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Png);
                    var image = Image.FromStream(stream);

                }
                bitmap.Save(@"C:\Windows\Temp\qrcode.png");
            }

            FcQrCode pfQrcode = new FcQrCode();
            pfQrcode.ShowDialog();
            
            return true;
        }
        public bool deleteCommand()
        {
            //bn.Delete();
            status = 2;         
            return true;
        }
        public bool addCommand()
        {
            ThuVien.loadform.enableControl(this);

            lkLyDoTiepNhan.EditValue = 556;
            lkHinhThucDen.EditValue = 461;
            lkNgheNghiep.EditValue = 374;
            lkDanToc.EditValue = 332;
            lkQuocTich.EditValue = 291;
            //lkNhomDichVu.EditValue =6;
            lkTinhThanh.EditValue = null;
            lkQuanHuyen.EditValue = null;
            lkPhuongXa.EditValue = null;
            lkNoiDangKy.EditValue = null;
            status = 1;
            dtTiepNhanLuc.DateTime = DateTime.Now;
            return true;
        }
        public bool saveCommand()
        {

          
            string bhyt = txtSo1.Text.Trim() + txtSo2.Text.Trim() + txtSo3.Text.Trim() + txtSo4.Text.Trim() + txtSo5.Text.Trim() + txtSo6.Text.Trim() + txtSo7.Text.Trim();
            bool bool_BHYT = true;
            if (bhyt.Trim().Length == 0)
            {
                bool_BHYT = false;
                bhyt = txtSoThe.Text.Trim();
            }
            if (status == 1)
            {
                //Check thong tin benh nhan

                int _BenhNhan_Id = SaveBenhNhan();

                //Check thong tin yeu cau
                //Check thong tin tiep nhan
                EntityClass.cls_TiepNhan tn = new EntityClass.cls_TiepNhan();
                if (tn.CheckTiepNhanTrongNgay(_BenhNhan_Id))
                {
                    MessageBox.Show("Bệnh nhân đã được tiếp nhận trong ngày!!!");
                }
                else if (tn.Check_ChuaRaKhoaCapCuu(_BenhNhan_Id))
                {
                    MessageBox.Show("Bệnh nhân chưa ra khoa cấp cứu!!!");
                }
                else if (tn.Check_ChuaRaVien_ByBenhNhanId(_BenhNhan_Id))
                {
                    MessageBox.Show("Bệnh nhân chưa ra viện!!!");
                }
                else
                {      
                    txtHoTen.Tag = _BenhNhan_Id;
                    int _TiepNhan_Id = SaveTiepNhan(_BenhNhan_Id);
                    txtSoTiepNhan.Tag = _TiepNhan_Id;
                    SaveCLS(_TiepNhan_Id, _BenhNhan_Id);

                    if (lkLyDoTiepNhan.EditValue.ToString() == "1330" || lkLyDoTiepNhan.EditValue.ToString() == "556")
                    {
                        xtraTabControl2.SelectedTabPage = xtraTabPage4;
                        LoadThongTinThanhToan();

                    }
                    if (lkLyDoTiepNhan.EditValue.ToString() == "557")
                    {
                        FmTiepNhanCapCuu tncc = new FmTiepNhanCapCuu("", int.Parse(txtSoTiepNhan.Tag.ToString()));// ThuVien.loadform.TiepNhan_Id_Tntt);
                        tncc.ShowDialog();
                    }
                }
                
            }
            //ThuVien.loadform.XoaForm(this);   
            txtMaYTe.Enabled = true;
            txtHoTen.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtHoTen.Focus();
            dataTb.Clear();
            gridControl3.DataSource = dataTb;
            status = 0;
            lkTinhThanh.EditValue = null;
            lkQuanHuyen.EditValue = null;
            lkPhuongXa.EditValue = null;
            lkNoiDangKy.EditValue = null;
            ThuVien.loadform.XoaForm(this);
            ThuVien.loadform.disableControl(this);                 
            return true;
        }
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lý sự kiện
        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTuoi.Text = (Int32.Parse(DateTime.Now.Year.ToString()) - Int32.Parse(DateTime.ParseExact(txtNgaySinh.Text, "d/M/yyyy", CultureInfo.InvariantCulture).Year.ToString())).ToString() + " Tuổi";
            }
            catch { }
        }
        private void txtTuoi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtTuoi.Text.Split(' ')[0]) < 6) { lkDoiTuong.EditValue = 16; }
            }
            catch { }
        }
        private void lkCongTy_EditValueChanged(object sender, EventArgs e)
        {
            if (lkCongTy.EditValue != null)
            {
                EntityClass.cls_KSK_CongTy cty = new EntityClass.cls_KSK_CongTy();
                cty.Get_By_Key(int.Parse(lkCongTy.EditValue.ToString()));
                txtDiaChi1.Text = cty.mvarDiaChi;
                txtDienThoai1.Text = cty.mvarDienThoai;
                txtFax1.Text = cty.mvarFax;
            }
        }
        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String chuoi = (sender as TextEdit).Text.ToString();// txtHoTen.Text;

                if (chuoi.Length >= 8 && chuoi.Length < 15)
                {
                    txtMaYTe.Tag = LoadTTBN_SoVaoVien(chuoi);
                }
                else if (chuoi.Length > 15)
                {
                    txtMaYTe.Tag = LoadTTBN_QrCode(chuoi);
                }
            }
        }
        private void lkLoaiGia_TextChanged(object sender, EventArgs e)
        {
            //if (lkMaDichVu.Text.Length > 0)
            //{
            //    string where = lkMaDichVu.EditValue.ToString();
            //    ThuVien.clsTiepNhan.GetDonGia(txtDonGia, "DichVu_Id='" + where + "'" + "and LoaiGia_Id='" + lkLoaiGia.EditValue.ToString() + "'");
            //    if (txtDonGia.Text.Length > 0)
            //    {
            //        txtThanhTien.Text = (double.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text)).ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không lấy được đơn giá.");
            //    }

            //}
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThuVien.FcLoadLookup mayte = new ThuVien.FcLoadLookup("[hsvClinic].[dbo].[DM_BenhNhan]", "BenhNhan_Id", "TenBenhNhan", "SoVaoVien", "");
            mayte.ShowDialog();
            if (mayte.lkChange)
            {
                txtMaYTe.Text = mayte.lkText;
                txtMaYTe.Tag = mayte.lkId;
                LoadTTBN_SoVaoVien(txtMaYTe.Text);
            }
            mayte.Dispose();

            //bn.mvarBenhNhan_Id = int.Parse(txtMaYTe.Tag.ToString());
        }
        private void lkTinhThanh_EditValueChanged(object sender, EventArgs e)
        {
            if (lkTinhThanh.EditValue != null)
            {
                Common.clsControl.LoadLookup(lkQuanHuyen, "DonViHanhChinh_MaCapTren", 2, lkTinhThanh.EditValue.ToString(), "", "Quận huyện", "Id");
            }
        }
        private void lkQuanHuyen_EditValueChanged(object sender, EventArgs e)
        {
            if (lkQuanHuyen.EditValue != null)
            {
                Common.clsControl.LoadLookup(lkPhuongXa, "DonViHanhChinh_MaCapTren", 2, lkQuanHuyen.EditValue.ToString(), "", "Phường xã", "Id");
            }
        }
        private void txtSo2_TextChanged(object sender, EventArgs e)
        {
            if (txtSo2.Text.Length > 0)// && lkNoiDangKy.EditValue != null)
            {
                try
                {
                    int _doituong = int.Parse(txtSo2.Text);
                    switch (_doituong)
                    {
                        case 1:
                            lkDoiTuong.EditValue = 25;
                            break;
                        case 2:
                            lkDoiTuong.EditValue = 26;
                            break;
                        case 3:
                            lkDoiTuong.EditValue = 27;
                            break;
                        case 4:
                            lkDoiTuong.EditValue = 28;
                            break;
                        case 5:
                            lkDoiTuong.EditValue = 29;
                            break;
                    }

                }
                catch { }
            }
            if (txtSo2.Text.Length == 1)
            {
                txtSo3.Focus();
            }
            if (txtSo2.Text.Length > 1)
            {
                txtSo2.Text = "";
            }
        }
        private void lkNoiDangKy_EditValueChanged(object sender, EventArgs e)
        {
            //if (lkNoiDangKy.EditValue != null)
            //{
            //    //string ndk = lkNoiDangKy.GetColumnValue("BenhVien_Id").ToString();
            //    //if (ndk == mabenhvien) { lkTuyenKB.EditValue = dungtuyen; }
            //    //else { lkTuyenKB.EditValue = traituyen; }
            //    if (txtSo2.Text.Length > 0)
            //    {
            //        try
            //        {
            //            int _doituong = int.Parse(txtSo2.Text);

            //            switch (_doituong)
            //            {
            //                case 1:
            //                    lkDoiTuong.EditValue = 38;
            //                    break;
            //                case 2:
            //                    lkDoiTuong.EditValue = 1054;
            //                    break;
            //                case 3:
            //                    lkDoiTuong.EditValue = 1043;
            //                    break;
            //                case 4:
            //                    lkDoiTuong.EditValue = 1044;
            //                    break;
            //                case 5:
            //                    lkDoiTuong.EditValue = 1045;
            //                    break;
            //            }

            //        }
            //        catch { }
            //    }
            //}
        }
        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            if (txtSo1.Text.Length == 2)
            {
                txtSo2.Focus();
            }
            if (txtSo1.Text.Length > 2)
            {
                txtSo1.Text = "";
            }
        }
        private void txtSo3_TextChanged(object sender, EventArgs e)
        {
            if (txtSo3.Text.Length == 2)
            {
                txtSo4.Focus();
            }
            if (txtSo3.Text.Length > 2)
            {
                txtSo3.Text = "";
            }
        }
        private void txtSo4_TextChanged(object sender, EventArgs e)
        {
            if (txtSo4.Text.Length == 3)
            {
                txtSo5.Focus();
            }
            if (txtSo4.Text.Length >3)
            {
                txtSo4.Text = "";
            }
        }
        private void txtSo5_TextChanged(object sender, EventArgs e)
        {
            if (txtSo5.Text.Length == 3)
            {
                txtSo6.Focus();
            }
            if (txtSo5.Text.Length > 3)
            {
                txtSo5.Text = "";
            }
        }
        private void txtSo6_TextChanged(object sender, EventArgs e)
        {
            if (txtSo6.Text.Length == 4)
            {
                txtSo7.Focus();
            }
            if (txtSo6.Text.Length > 4)
            {
                txtSo6.Text = "";
            }
        }
        private void lkNhomDichVu_EditValueChanged(object sender, EventArgs e)
        {
            if (gridView3.FocusedRowHandle == -2147483647 && (sender as BaseEdit).EditValue != null)
            {
                gridView3.SetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["DichVu_Id"], null);
                gridView3.SetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["NoiThucHien_Id"], null);
                Common.clsControl.LoadLookup_RepositoryItem(lkDichVu, "DichVu_NhomDichVu", 2, (sender as BaseEdit).EditValue.ToString().Trim(), "", "Dịch vụ", "Id");
                gridView3.SetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["NhomDichVu_Id"], int.Parse((sender as BaseEdit).EditValue.ToString()));

            }
        }
        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -2147483647)
            {
                try
                {
                    if (gridView3.GetRowCellValue(e.FocusedRowHandle, gridView3.Columns["DichVu_Id"]).ToString().Length <= 0)
                    {
                        gridView3.DeleteSelectedRows();
                        MessageBox.Show("Vui lòng chọn dịch vụ.");
                    }
                    else if (gridView3.GetRowCellValue(e.FocusedRowHandle, gridView3.Columns["NoiThucHien_Id"]).ToString().Length <= 0)
                    {
                        gridView3.DeleteSelectedRows();
                        MessageBox.Show("Vui lòng chọn nơi khám.");
                    }
                    else if (lkDoiTuong.Text.Length <= 0)
                    {
                        gridView3.DeleteSelectedRows();
                        MessageBox.Show("Vui lòng chọn đối tượng.");
                    }
                    else
                    {
                        if (gridView3.GetRowCellValue(e.FocusedRowHandle, gridView3.Columns["SoPhieuYeuCau"]).ToString().Length == 0)
                        {
                            for (int i = 0; i < gridView3.RowCount; i++)
                            {
                                if (gridView3.GetRowCellValue(e.FocusedRowHandle, gridView3.Columns["NhomDichVu_Id"]).ToString() == gridView3.GetDataRow(i)["NhomDichVu_Id"].ToString() && e.FocusedRowHandle > i)
                                {
                                    gridView3.SetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["SoPhieuYeuCau"], gridView3.GetDataRow(i)["SoPhieuYeuCau"].ToString());
                                    i = gridView3.RowCount + 2;
                                }
                            }
                            if (gridView3.GetRowCellValue(e.FocusedRowHandle, gridView3.Columns["SoPhieuYeuCau"]).ToString().Length == 0)
                            {
                                EntityClass.cls_CLSYeuCau ClsYc = new EntityClass.cls_CLSYeuCau();
                                string sophieu = ClsYc.getSoPhieuYeuCau();
                                gridView3.SetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["SoPhieuYeuCau"], sophieu);
                            }
                            //GridColumn colReceived = gridView3.Columns["NhomDichVu_Id"];
                            //gridView3.BeginSort();
                            //try
                            //{
                            //    gridView3.ClearGrouping();
                            //    colReceived.GroupIndex = 0;
                            //}
                            //catch { }
                            //try { gridView3.EndSort(); } catch { }
                            //gridView3.ExpandAllGroups();
                        }

                    }
                }
                catch  {  }//gridView3.DeleteSelectedRows(); }
            }
        }
        private void lkDichVu_EditValueChanged(object sender, EventArgs e)
        {
            if (gridView3.FocusedRowHandle == -2147483647)
            {
                if (lkDoiTuong.Text.Length <= 0)
                {
                    MessageBox.Show("Vui lòng chọn đối tượng.");
                }
                else if ((sender as BaseEdit).EditValue != null)
                {
                    string where = (sender as BaseEdit).EditValue.ToString();

                    string sql = "SELECT TOP 1[hsvClinic].[dbo].[View_DM_DichVu_DonGia].DonGia FROM[hsvClinic].[dbo].[View_DM_DichVu_DonGia] WHERE DichVu_Id=" + where + " and LoaiGia_Id='27' ORDER BY BangGia_Id DESC";
                    string donGia = ThuVien.mySQL.getValues(sql);
                    gridView3.SetRowCellValue(-2147483647, gridView3.Columns["DonGiaDoanhThu"], donGia);

                    sql = "SELECT TOP 1[hsvClinic].[dbo].[View_DM_DichVu_DonGia].DonGia FROM[hsvClinic].[dbo].[View_DM_DichVu_DonGia] WHERE DichVu_Id=" + (sender as BaseEdit).EditValue.ToString() + " and LoaiGia_Id='6' ORDER BY BangGia_Id DESC";
                    string donGiaHoTro = ThuVien.mySQL.getValues(sql);

                    sql = "SELECT Top 1 TyLe_2 FROM [hsvClinic].[dbo].[View_DM_DoiTuong] where DoiTuong_Id ='" + lkDoiTuong.EditValue.ToString() + "'";
                    string tyLe = ThuVien.mySQL.getValues(sql);

                    string bhThanhToan = "0";
                    if (gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["NhomDichVu_Id"]).ToString() == "6")
                    {
                        //bhThanhToan = "0";
                    }

                    try
                    {
                        bhThanhToan = (double.Parse(donGiaHoTro) * double.Parse(tyLe)).ToString();
                    }
                    catch
                    {
                        donGiaHoTro = "0";
                    }
                    gridView3.SetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["DonGiaHoTro"], donGiaHoTro);
                    gridView3.SetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["DonGiaHoTroChiTra"], bhThanhToan);
                    gridView3.SetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["DonGiaThanhToan"], (double.Parse(gridView3.GetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns["DonGiaDoanhThu"]).ToString()) - double.Parse(bhThanhToan)).ToString());

                }
            }
        }
        private void btnLuuThanhToan_Click(object sender, EventArgs e)
        {
            LuuHoaDon(int.Parse(txtHoTen.Tag.ToString()), int.Parse(txtSoTiepNhan.Tag.ToString()));

            UpdateCLSYeuCauChiTiet();


            txtMaYTe.Enabled = true;
            txtHoTen.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtHoTen.Focus();
            dataTb.Clear();           
            gridControl3.DataSource = dataTb;
            gridControl1.DataSource = new DataTable();
            status = 0;
            lkTinhThanh.EditValue = null;
            lkQuanHuyen.EditValue = null;
            lkPhuongXa.EditValue = null;
            lkNoiDangKy.EditValue = null;
            xtraTabControl2.SelectedTabPage = xtraTabPage5;
            ThuVien.loadform.XoaForm(this);
            ThuVien.loadform.disableControl(this);

        }
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

        #endregion
        /*-----------------------------------------------*/
        #region "Các hàm con"
        public void createnewrow()
        {
            string gioitinh = rdNam.Checked == true ? "Nam" : "Nữ";
            string bhyt = txtSo1.Text.Trim() + txtSo2.Text.Trim() + txtSo3.Text.Trim() + txtSo4.Text.Trim() + txtSo5.Text.Trim() + txtSo6.Text.Trim() + txtSo7.Text.Trim();

            if (dt.Rows.Count <= 0)
            {

                DataColumn dc = new DataColumn("SoVaoVien", typeof(string));
                dt.Columns.Add(dc);
                dc = new DataColumn("HoTen", typeof(string));
                dt.Columns.Add(dc);
                dc = new DataColumn("GioiTinh", typeof(string));
                dt.Columns.Add(dc);
                dc = new DataColumn("NgaySinh", typeof(string));
                dt.Columns.Add(dc);
                dc = new DataColumn("DiaChi", typeof(string));
                dt.Columns.Add(dc);
                dc = new DataColumn("BHYT", typeof(string));
                dt.Columns.Add(dc);
                dc = new DataColumn("QRCODE", typeof(string));
                dt.Columns.Add(dc);
                dt.Rows.Add(txtMaYTe.Text, txtHoTen.Text, gioitinh, txtNgaySinh.Text, txtDiaChi.Text, bhyt, "qrcode.png");
                ThuVien.loadform.DataSet_Img.Tables.Add(dt);

            }
            else
            {
                ThuVien.loadform.DataSet_Img.Tables["table1"].Clear();
                ThuVien.loadform.DataSet_Img.Tables["table1"].Rows.Add(txtMaYTe.Text, txtHoTen.Text, gioitinh, txtNgaySinh.Text, txtDiaChi.Text, bhyt, "qrcode.png");
            }
        }

        //Load thông tin bệnh nhân theo số vào viện
        private string LoadTTBN_SoVaoVien(string sovaovien)
        {
            EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
            bn.Get_By_MaYTe(sovaovien);
            if (bn.mvarBenhNhan_Id > 0)
            {
                txtMaYTe.Text = bn.mvarSoVaoVien;
                txtMaYTe.Tag = bn.mvarBenhNhan_Id;
                txtHoTen.Text = bn.mvarTenBenhNhan;
                txtNgaySinh.Text = bn.mvarNgaySinh.ToString("dd/MM/yyyy");
                txtSoNha.Text = bn.mvarSoNha;
                txtDiaChi.Text = bn.mvarDiaChi;
                txtSoNha.Text = bn.mvarSoNha;
                if (bn.mvarGioiTinh == "T")
                {
                    rdNam.Checked = true;
                    rdNu.Checked = false;
                }
                else
                {
                    rdNu.Checked = true;
                    rdNam.Checked = false;
                }
                lkQuocTich.EditValue = bn.mvarQuocTich_Id;
                lkDanToc.EditValue = bn.mvarDanToc_Id;
                lkTinhThanh.EditValue = bn.mvarTinhThanh_Id;
                lkQuanHuyen.EditValue = bn.mvarQuanHuyen_Id;
                lkPhuongXa.EditValue = bn.mvarXaPhuong_Id;
                txtSoDT.Text = bn.mvarSoDienThoai;
                lkNgheNghiep.EditValue = bn.mvarNgheNghiep_Id;
                txtTienSuBenh.Text = bn.mvarTienSuBenh;

                LoadTTBH_BenhNhan_Id(bn.mvarBenhNhan_Id);
            }
            return bn.mvarBenhNhan_Id.ToString();
        }


        //Load thông tin bảo hiểm của bênh nhân theo benhnhanId
        private void LoadTTBH_BenhNhan_Id(int benhnhan_Id)
        {
            EntityClass.cls_DM_BenhNhan_BHYT bnbh = new EntityClass.cls_DM_BenhNhan_BHYT();
            bnbh.Get_By_BenhNhan_Id(benhnhan_Id);
            if (bnbh.mvarBenhNhan_Id > 0)
            {
                string BHYT = bnbh.mvarSoThe;
                try
                {
                    String sql = "select MaBenhVien from hsvClinic.dbo.DM_BenhVien where BenhVien_Id='" + bnbh.mvarBenhVien_KCB_Id + "'";
                    lkNoiDangKy.EditValue = ThuVien.mySQL.getValues(sql);
                }
                catch { }
                try
                {
                    txtSo1.Text = BHYT.Substring(0, 2);
                    txtSo2.Text = BHYT.Substring(2, 1);
                    txtSo3.Text = BHYT.Substring(3, 2);
                    txtSo4.Text = BHYT.Substring(5, 3);
                    txtSo5.Text = BHYT.Substring(8, 3);
                    txtSo6.Text = BHYT.Substring(11, 4);
                }
                catch { }
                txtTuNgay.Text = bnbh.mvarNgayHieuLuc.ToString("dd/MM/yyyy");
                txtDenNgay.Text = bnbh.mvarNgayHetHieuLuc.ToString("dd/MM/yyyy");
                dtTuNgay1.DateTime = bnbh.mvarNgayHieuLuc_TN;
                dtDenNgay1.DateTime = bnbh.mvarNgayHetHieuLuc_TN;
                lkCongTy.EditValue = bnbh.mvarCongty_Id;
                txtSoThe.Text = bnbh.mvarSoThe_TN;


            }
        }


        //Load thông tin bệnh nhân theo qrcode
        private string LoadTTBN_QrCode(string qr_Code)
        {
            int rs = Common.clsQrCode.HamTachChuoi_QRCODE(qr_Code);
            if (rs == 1 || rs == 2)
            {
                txtTuoi.Text = (Int32.Parse(DateTime.Now.Year.ToString()) - Int32.Parse(Common.clsQrCode.Nam)).ToString() + " Tuổi";
                txtHoTen.Text = Common.clsQrCode.HoTen;
                txtNgaySinh.Text = Common.clsQrCode.NgaySinh;
                string gioitinh = Common.clsQrCode.GioiTinh;

                if (gioitinh.Trim() == "1")
                {
                    rdNam.Checked = true;
                    rdNu.Checked = false;
                }
                else
                {
                    rdNu.Checked = true;
                    rdNam.Checked = false;
                }
                txtDiaChi.Text = Common.clsQrCode.Diachi;
                lkNoiDangKy.EditValue = Common.clsQrCode.NoiDangKy;

                txtTuNgay.Text = Common.clsQrCode.TuNgay;
                txtDenNgay.Text = Common.clsQrCode.DenNgay;
                txtSo1.Text = Common.clsQrCode.So1;
                txtSo2.Text = Common.clsQrCode.So2;
                txtSo3.Text = Common.clsQrCode.So3;
                txtSo4.Text = Common.clsQrCode.So4;
                txtSo5.Text = Common.clsQrCode.So5;
                txtSo6.Text = Common.clsQrCode.So6;
                EntityClass.cls_DM_BenhNhan_BHYT BnBh = new EntityClass.cls_DM_BenhNhan_BHYT();
                BnBh.Get_By_BHYT(Common.clsQrCode.BHYT);
                if (BnBh.mvarBenhNhan_Id > 0)
                {
                    return LoadTTBN_SoVaoVien(BnBh.mvarFreePara);
                }

                if (rs == 1) //Tách được quận huyện
                {
                    txtSoNha.Text = Common.clsQrCode.SoNha;
                    lkTinhThanh.EditValue = Common.clsQrCode.TinhThanh;
                    lkQuanHuyen.EditValue = Common.clsQrCode.QuanHuyen;
                    lkPhuongXa.EditValue = Common.clsQrCode.PhuongXa;
                }
            }
            else if (rs == 3)
            {
                return LoadTTBN_SoVaoVien(Common.clsQrCode.SoVaoVien);
            }

            return "";
        }

        //Fill data bệnh nhân từ form
        private EntityClass.clsDM_BenhNhan LoadBenhNhanInForm(EntityClass.clsDM_BenhNhan bn, bool addNew)
        {
            bn.mvarTenBenhNhan = txtHoTen.Text;
            bn.mvarNgaySinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            bn.mvarNgheNghiep_Id = Int32.Parse(lkNgheNghiep.EditValue.ToString());
            bn.mvarGioiTinh = rdNam.Checked == true ? "T" : "N";
            bn.mvarDiaChi = txtDiaChi.Text;
            bn.mvarDanToc_Id = Int32.Parse(lkDanToc.EditValue.ToString());
            bn.mvarQuocTich_Id = Int32.Parse(lkQuocTich.EditValue.ToString());
            bn.mvarTinhThanh_Id = Int32.Parse(lkTinhThanh.EditValue.ToString());
            bn.mvarQuanHuyen_Id = Int32.Parse(lkQuanHuyen.EditValue.ToString());
            bn.mvarXaPhuong_Id = Int32.Parse(lkPhuongXa.EditValue.ToString());
            bn.mvarTienSuBenh = txtTienSuBenh.Text;
            bn.mvarSoDienThoai = txtSoDT.Text;
            bn.mvarNguoiLienHe = txtNguoiLienHe.Text;
            if (addNew)
            {
                bn.mvarSoVaoVien = bn.getSoVaoVien();
                bn.mvarMaBenhVien = "713303";
                bn.mvarMaYTe = bn.mvarMaBenhVien + "." + bn.mvarSoVaoVien;
                bn.mvarNguoiTao_Id = ThuVien.loadform.userID;
                bn.mvarNgayTao = DateTime.Now;
            }
            else
            {
                bn.mvarSoVaoVien = txtMaYTe.Text;
                bn.mvarMaBenhVien = "713303";
                bn.mvarMaYTe = bn.mvarMaBenhVien + "." + bn.mvarSoVaoVien;
                bn.mvarNgayCapNhat = DateTime.Now;
                bn.mvarNguoiCapNhat_Id = ThuVien.loadform.userID;
            }

            return bn;
        }
        //Fill data BHYT từ form
        private EntityClass.cls_DM_BenhNhan_BHYT LoadBHYTInForm(EntityClass.cls_DM_BenhNhan_BHYT bhyt)
        {
            try
            {
                bhyt.mvarSoThe = txtSo1.Text.Trim() + txtSo2.Text.Trim() + txtSo3.Text.Trim() + txtSo4.Text.Trim() + txtSo5.Text.Trim() + txtSo6.Text.Trim() + txtSo7.Text.Trim();
                bhyt.mvarNgayHieuLuc = DateTime.ParseExact(txtTuNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                bhyt.mvarNgayHetHieuLuc = DateTime.ParseExact(txtDenNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                bhyt.mvarBenhVien_KCB_Id = int.Parse(lkNoiDangKy.EditValue.ToString());
                bhyt.mvarSoThe_TN = txtSoThe.Text;
                bhyt.mvarNgayHieuLuc_TN = dtTuNgay1.DateTime;
                bhyt.mvarNgayHetHieuLuc_TN = dtDenNgay1.DateTime;
                bhyt.mvarCongty_Id = int.Parse(lkCongTy.EditValue.ToString());
                bhyt.mvarNguoiTao_Id = ThuVien.loadform.userID;

            }
            catch { }
            return bhyt;
        }
        //Fill data tiếp nhận từ form
        private EntityClass.cls_TiepNhan LoadTiepNhanInForm(EntityClass.cls_TiepNhan tn)
        {
            tn.getSoTiepNhan();
            tn.mvarUuTien = cbUuTien.Checked == true ? true : false;
            tn.mvarNgayTiepNhan = DateTime.Today;
            tn.mvarThoiGianTiepNhan = DateTime.Now;
            tn.mvarNamTiepNhan = short.Parse(DateTime.Now.Year.ToString());
            tn.mvarThangTiepNhan = byte.Parse(DateTime.Now.Month.ToString());
            tn.mvarDoiTuong_Id = int.Parse(lkDoiTuong.EditValue.ToString());
            tn.mvarNguoiLienHe = txtNguoiLienHe.Text;
            tn.mvarDiaChiLienHe = txtDiaChi.Text;
            tn.mvarHinhThucDenKham_Id = int.Parse(lkHinhThucDen.EditValue.ToString());
            tn.mvarLyDoTiepNhan_Id = int.Parse(lkLyDoTiepNhan.EditValue.ToString());
            tn.mvarSoBHYT = txtSo1.Text.Trim() + txtSo2.Text.Trim() + txtSo3.Text.Trim() + txtSo4.Text.Trim() + txtSo5.Text.Trim() + txtSo6.Text.Trim() + txtSo7.Text.Trim();
            try
            {
                tn.mvarBHYTTuNgay = DateTime.ParseExact(txtTuNgay.Text.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture);
                tn.mvarBHYTDenNgay = DateTime.ParseExact(txtDenNgay.Text.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture);
            }
            catch { }
            tn.mvarNgayTao = DateTime.Now;
            tn.mvarNguoiTao_Id = ThuVien.loadform.userID;
            tn.mvarNoiTiepNhan_Id = ThuVien.loadform.PhongBanID;
            //tn.mvarChanDoanNGT = rtxtChuanDoan.Text;
            tn.mvarTinhThanh_Id = int.Parse(lkTinhThanh.EditValue.ToString());
            tn.mvarQuanHuyen_Id = int.Parse(lkQuanHuyen.EditValue.ToString());
            tn.mvarXaPhuong_Id = int.Parse(lkPhuongXa.EditValue.ToString());
            tn.mvarTrangThai = "ChuaDongTien";
            //tn.mvarThuTienTruoc = cbThuTienSau.Checked == true ? false : true;
            return tn;
        }
        //Lưu hoặc update thông tin bệnh nhân
        private int SaveBenhNhan()
        {
            EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
            bn.Get_By_MaYTe(txtMaYTe.Text);
            if (bn.mvarBenhNhan_Id > 0)        //Bệnh nhân đã tồn tại, cập nhật thông tin
            {
                bn = LoadBenhNhanInForm(bn, false);
                bn.Update();
                if (txtSoThe.Text.Length > 0)
                {
                    EntityClass.cls_DM_BenhNhan_BHYT bnbh = new EntityClass.cls_DM_BenhNhan_BHYT();
                    bnbh.Get_By_BenhNhan_Id(bn.mvarBenhNhan_Id);
                    bnbh = LoadBHYTInForm(bnbh);
                    if (bnbh.mvarBenhNhan_Id > 0)
                    {
                        bnbh.Update();
                    }
                    else
                    {
                        bnbh.mvarBenhNhan_Id = bn.mvarBenhNhan_Id;
                        bnbh.Add();
                    }
                }
            }
            else                  //Bệnh nhân chưa tồn tại, lưu bệnh nhân mới
            {
                bn = LoadBenhNhanInForm(bn, true);
                bn.mvarBenhNhan_Id = int.Parse(bn.Add());
                if (txtSoThe.Text.Length > 0)
                {
                    EntityClass.cls_DM_BenhNhan_BHYT bnbh = new EntityClass.cls_DM_BenhNhan_BHYT();
                    bnbh = LoadBHYTInForm(bnbh);
                    bnbh.mvarBenhNhan_Id = bn.mvarBenhNhan_Id;
                    bnbh.Add();
                }
            }
            txtMaYTe.Text = bn.mvarSoVaoVien;
            return bn.mvarBenhNhan_Id;
        }
        //Lưu hoặc update thông tin tiếp nhận
        private int SaveTiepNhan(int benhNhan_Id)
        {
            EntityClass.cls_TiepNhan tn = new EntityClass.cls_TiepNhan();
            tn = LoadTiepNhanInForm(tn);
            tn.mvarBenhNhan_Id = benhNhan_Id;
            tn.mvarSoThuTu = "0";
            tn.mvarTiepNhan_Id = Int32.Parse(tn.Add());
            txtSoTiepNhan.Text = tn.mvarSoTiepNhan;
            return tn.mvarTiepNhan_Id;
        }
        //Lưu thông tin yêu cầu cls
        private void SaveCLS(int tiepNhan_Id, int benhNhan_Id)
        {
            List<string> maNhomDichVu = new List<string>();
            for (int i = 0; i < gridView3.RowCount; i++)
            {
                string NhomDichVu_Id = gridView3.GetDataRow(i)["NhomDichVu_Id"].ToString();
                bool isSave = false;
                for (int j = 0; j < maNhomDichVu.Count; j++)
                {
                    if (maNhomDichVu[j] == NhomDichVu_Id)
                    {
                        isSave = true;
                    }
                }
                if (!isSave)
                {
                    EntityClass.cls_CLSYeuCau clsYc = new EntityClass.cls_CLSYeuCau();
                    clsYc.mvarSoPhieuYeuCau = gridView3.GetDataRow(i)["SoPhieuYeuCau"].ToString().Trim();
                    clsYc.mvarNgayYeuCau = DateTime.Today;
                    clsYc.mvarThoiGianYeuCau = DateTime.Now;
                    clsYc.mvarNgayGioYeuCau = DateTime.Now;
                    clsYc.mvarNguoiTao_Id = ThuVien.loadform.userID;
                    clsYc.mvarNoiYeuCau_Id = ThuVien.loadform.PhongBanID;
                    clsYc.mvarNamYeuCau = short.Parse(DateTime.Now.Year.ToString());
                    clsYc.mvarThangYeuCau = byte.Parse(DateTime.Now.Month.ToString());

                    clsYc.mvarNoiThucHien_Id = Int32.Parse(gridView3.GetDataRow(i)["NoiThucHien_Id"].ToString());
                    clsYc.mvarBenhNhan_Id = benhNhan_Id;
                    clsYc.mvarTiepNhan_Id = tiepNhan_Id;
                    clsYc.mvarNhomDichVu_Id = int.Parse(gridView3.GetDataRow(i)["NhomDichVu_Id"].ToString());
                    clsYc.mvarCLSYeuCau_Id = int.Parse(clsYc.Add());
                    EntityClass.cls_CLSYeuCauChiTiet clsYcCt = new EntityClass.cls_CLSYeuCauChiTiet();
                    clsYcCt.mvarCLSYeuCau_Id = clsYc.mvarCLSYeuCau_Id;
                    clsYcCt.mvarDichVu_Id = int.Parse(gridView3.GetDataRow(i)["DichVu_Id"].ToString());
                    clsYcCt.mvarPhongBan_Id = int.Parse(gridView3.GetDataRow(i)["NoiThucHien_Id"].ToString());
                    clsYcCt.mvarDonGiaDoanhThu = decimal.Parse(gridView3.GetDataRow(i)["DonGiaDoanhThu"].ToString());
                    clsYcCt.mvarDonGiaHoTroChiTra = decimal.Parse(gridView3.GetDataRow(i)["DonGiaHoTroChiTra"].ToString());
                    clsYcCt.mvarDonGiaHoTro = decimal.Parse(gridView3.GetDataRow(i)["DonGiaHoTro"].ToString());
                    clsYcCt.mvarDonGiaThanhToan = decimal.Parse(gridView3.GetDataRow(i)["DonGiaThanhToan"].ToString());
                    clsYcCt.mvarTienTe_Id = "VND";
                    clsYcCt.mvarTyGia = 1;
                    clsYcCt.mvarSoLuong = 1;
                    clsYcCt.Add();
                }
                else
                {
                    //String sqlString = "Select ([hsvClinic].[dbo].[CLSYeuCau].CLSYeuCau_Id) from [hsvClinic].[dbo].[CLSYeuCau] where SoPhieuYeuCau='" + dataTb.Rows[i]["SoPhieuYeuCau"].ToString().Trim() + "'";
                    //String clsYCau_Id = ThuVien.mySQL.getValues(sqlString);
                    EntityClass.cls_CLSYeuCau yc = new EntityClass.cls_CLSYeuCau();
                    yc.GetData_BySoPhieuYeuCau(gridView3.GetDataRow(i)["SoPhieuYeuCau"].ToString().Trim());
                    EntityClass.cls_CLSYeuCauChiTiet clsYcCt = new EntityClass.cls_CLSYeuCauChiTiet();
                    clsYcCt.mvarCLSYeuCau_Id = yc.mvarCLSYeuCau_Id;// int.Parse(clsYCau_Id);
                    clsYcCt.Add();
                }

            }
        }

        private void loadGridView(GridControl gv)
        {
            ThuVien.mySQL.LoadGirdControl(gv, "select TenPhongBan from [mHIS_Hethong].[dbo].[DM_PhongBan] where LoaiPhongBan_Id = '566' ");
        }

        //private void TiepNhanBenhNhan(LookUpEdit cb, string where)
        //{
        //    mySQL.Load_Lookup_2C(cb, "PhongBan_Id", "TenPhongBan", "[mHIS_Hethong].[dbo].[View_TiepNhan]", "where DichVu_Id='" + where + "'");
        //}
        /* End */
        //chèn dữ liệu vào grv dịch vụ
        //private void AddDataGrv(GridControl gr, DataTable dataTb, String vl1, String vl2, String vl3, String vl4, String vl5, String vl6, String vl8, String vl9, String vl10)
        //{
        //    DataRow dtr = dataTb.NewRow();
        //    dtr["NhomDichVu"] = vl2;
        //    dtr["TenDichVu"] = vl3;
        //    dtr["SL"] = vl4;
        //    dtr["DonGia"] = vl5;
        //    dtr["ThanhTien"] = vl6;
        //    //dtr["LoaiGia"] = vl7;
        //    dtr["BHThanhToan"] = vl8;
        //    dtr["BenhNhanTT"] = (double.Parse(vl6) - double.Parse(vl8)).ToString();
        //    dtr["NoiThucHien"] = vl9;
        //    dtr["SoPhieu"] = vl10;
        //    dataTb.Rows.Add(dtr);
        //    gr.DataSource = dataTb;
        //}
        private void KhoiTaoGrTb(GridControl gr, DataTable dataTb)
        {
            //dataTb.Columns.Add("TenDichVu");
            dataTb.Columns.Add("DonGiaDoanhThu");
            dataTb.Columns.Add("DonGiaHoTroChiTra");
            dataTb.Columns.Add("DonGiaThanhToan");
            //dataTb.Columns.Add("TenPhongBan");
            dataTb.Columns.Add("SoPhieuYeuCau");
            dataTb.Columns.Add("BHThanhToan");
            //dataTb.Columns.Add("TenNhomDichVu");
            dataTb.Columns.Add("NhomDichVu_Id");
            dataTb.Columns.Add("NoiThucHien_Id");
            dataTb.Columns.Add("DichVu_Id");
            dataTb.Columns.Add("DonGiaHoTro");
            //dataTb.Columns.Add("Huy");
            gr.DataSource = dataTb;
        }

        private void AddDataGrv(GridControl gr, DataTable dataTb, String phongBan_Id, String DV, String danhThu, String giaHoTro, String tenPhongBan, String soPhieu, String nhomId, String tenNhom, String DV_id, string bhThanhtoan)
        {

            DataRow dtr = dataTb.NewRow();
            //dtr["MaNhomDichVu"] = maNhom;
            dtr["TenDichVu"] = DV;
            //dtr["SoLuong"] = vl4;
            dtr["DonGiaDoanhThu"] = danhThu;
            //dtr["ThanhTienDanhThu"] = vl6;
            //dtr["TenLoaiGia"] = vl7;////
            dtr["DonGiaHoTroChiTra"] = bhThanhtoan;
            dtr["DonGiaHoTro"] = giaHoTro;
            dtr["DonGiaThanhToan"] = (double.Parse(danhThu) - double.Parse(bhThanhtoan)).ToString();
            dtr["TenPhongBan"] = tenPhongBan;
            dtr["SoPhieuYeuCau"] = soPhieu;
            dtr["BHThanhToan"] = bhThanhtoan;
            //dtr["BHYTTuDongTien"] = vl12;
            dtr["TenNhomDichVu"] = tenNhom;
            //dtr["LoaiGia_Id"] = vl11;
            dtr["NhomDichVu_Id"] = nhomId;
            dtr["NoiThucHien_Id"] = phongBan_Id;
            dtr["DichVu_Id"] = DV_id;
            dataTb.Rows.Add(dtr);
            //gr.DataSource = dataTb;

        }


        //Load thông tin thanh toán
        public void LoadThongTinThanhToan()
        {
            dtNgayThu.DateTime = DateTime.Now;     
               
            EntityClass.cls_HoaDon hd = new EntityClass.cls_HoaDon();
            hd.GetListDichVu_Thuoc(gridControl1, int.Parse(txtHoTen.Tag.ToString()));
                                                             
            GridColumn colReceived = gridView4.Columns["TenNhomDichVu"];
            gridView4.BeginSort();
            try
            {
                gridView4.ClearGrouping();
                colReceived.GroupIndex = 0;
            }
            finally
            {
                gridView4.EndSort();
            }
            gridView4.ExpandAllGroups();

            if (gridView4.DataRowCount == 1)
            {
                txtGiaTriHopDong.Text = "150000.00";
                lbTongTien.Text = "150000.00";
            }
            else
            {
                bool fn = false;
                if (gridView4.DataRowCount > 0)
                {
                    for (int i = 0; i < gridView4.DataRowCount; i++)
                    {
                        if (gridView4.GetRowCellValue(i, gridView4.Columns["TenNhomDichVu"]).ToString() == "Thuốc BHYT" || gridView4.GetRowCellValue(i, gridView4.Columns["TenNhomDichVu"]).ToString() == "Thuốc dịch vụ")
                        {
                            fn = true;
                            i = gridView4.DataRowCount;
                        }
                    }
                }
                if (fn)
                {
                    txtGiaTriHopDong.Text = (double.Parse(gridView4.Columns["BnThanhToan"].SummaryItem.SummaryValue.ToString()) - double.Parse(gridView4.Columns["BenhNhanDaThanhToan"].SummaryItem.SummaryValue.ToString())).ToString();
                    lbTongTien.Text = txtGiaTriHopDong.Text;
                }
                else
                {
                    for (int i = 0; i < gridView4.DataRowCount; i++)
                    {
                        if (gridView4.GetRowCellValue(i, gridView4.Columns["TenNhomDichVu"]).ToString() == "Khám Bệnh")
                        {
                            txtGiaTriHopDong.Text = (double.Parse(gridView4.Columns["BnThanhToan"].SummaryItem.SummaryValue.ToString()) - double.Parse(gridView4.Columns["BenhNhanDaThanhToan"].SummaryItem.SummaryValue.ToString()) + 150000 - double.Parse(gridView4.GetRowCellValue(i, gridView4.Columns["BnThanhToan"]).ToString())).ToString();
                            lbTongTien.Text = txtGiaTriHopDong.Text;
                            i = gridView4.DataRowCount;
                        }
                    }
                }
            }
            
        }
        //Lưu hóa đơn
        private void LuuHoaDon(int BenhNhan_Id_TnTT, int TiepNhan_Id_Tntt)
        {
            EntityClass.cls_HoaDon hd = new EntityClass.cls_HoaDon();
            hd.mvarSoHoaDon = txtSoHoaDon.Text;
            hd.mvarLoaiHoaDon = txtKyHieu.Text;
            hd.mvarSoQuyen = txtSoQuyen.Text;
            hd.mvarSo = int.Parse(txtSoHoaDon.Text.Split('.')[1]);
            hd.mvarTiepNhan_Id = TiepNhan_Id_Tntt;
            hd.mvarBenhNhan_Id = BenhNhan_Id_TnTT;
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
        //Update thông tin thanh toán cho CLS yêu cầu
        private void UpdateCLSYeuCauChiTiet()
        {
            for (int i = 0; i < gridView4.DataRowCount; i++)
            {
                if (gridView4.GetRowCellValue(i, gridView4.Columns["BenhNhanDaThanhToan"]).ToString() == "0.00" && gridView4.GetRowCellValue(i, gridView4.Columns["TenNhomDichVu"]).ToString() != "Thuốc dịch vụ" && gridView4.GetRowCellValue(i, gridView4.Columns["TenNhomDichVu"]).ToString() != "Thuốc BHYT")
                {
                    EntityClass.cls_CLSYeuCau clsYc = new EntityClass.cls_CLSYeuCau();
                    clsYc.Update_CLSYeuCau(gridView4.GetRowCellValue(i, gridView4.Columns["SoPhieuYeuCau"]).ToString());
                }
            }
        }

        #endregion

    }
}
