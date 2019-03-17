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
using DevExpress.XtraEditors.Repository;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Globalization;

namespace KhamBenh
{
    public partial class mncPhieuDieuTriYLenhUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai báo biến
        private int status = 0;
        #endregion

        /*-----------------------------------------------*/
        #region Khởi tạo form
        public mncPhieuDieuTriYLenhUC()
        {
            InitializeComponent();
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
        private void mncPhieuDieuTriYLenhUC_Load(object sender, EventArgs e)
        {
            //lbMaYTe.Text = "713303.14000027";
            //lbHoTen.Text = "Nguyễn Văn Út";
            Common.clsControl.LoadLookup(lkDoiTuong, "DoiTuong", 2, "", "", "Tên đối tượng", "Id");
            Common.clsControl.LoadLookup(lkBacSi, "BacSi", 2, "", "", "Bác sĩ", "Id");
            Common.clsControl.LoadLookup(lkCapHoLy, "BacSi", 2, "", "", "Hộ lý", "Id");
            Common.clsControl.LoadLookup(lkDieuDuong, "BacSi", 2, "", "", "Điều dưỡng", "Id");
            Common.clsControl.LoadLookup(lkBenhAn, "BenhAnNoiTru", 2, "", "", "Số bệnh án", "Id");
            DataTable dt = new DataTable();
            KhoiTaoGrTb(gridControl3, dt);

            Load_Lookup(repositoryItemLookUpEdit1, "Duoc_Id", "TenDuocDayDu", "[hsvClinic].[dbo].[View_Duoc_GiaBan]", "TamNgung = '0'");
            Load_Lookup(repositoryItemLookUpEdit2, "Dictionary_Id", "Dictionary_Name", "[hsvClinic].[dbo].[view_Lst_Dictionary]", "Dictionary_Type_Code = 'duongdung'");
            Load_Lookup(repositoryItemLookUpEdit3, "DonViTinh_Id", "TenDonViTinh", "[hsvClinic].[dbo].[DM_DonViTinh]", "TamNgung != 1");
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
            ThuVien.loadform.enableControl(this);
            status = 1;
            return true;
        }
        public bool saveCommand()
        {
            int khamBenh_Id= SaveKhamBenh();
            SaveToaThuoc(khamBenh_Id);
            status = 0;
            ThuVien.loadform.disableControl(this);
            return true;
        }
        #endregion

        /*-----------------------------------------------*/

        #region Hàm xử lí sự kiện
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {

            try
            {
                DateTime? dt = gridView1.GetDataRow(e.RowHandle)["ThoiGianKham"] as DateTime?;
                EntityClass.cls_NoiTru_KhamBenh ntkb = new EntityClass.cls_NoiTru_KhamBenh();
                ntkb.Get_By_NgayKham(int.Parse(lkBenhAn.EditValue.ToString()), dt);
                dtNgayKham.DateTime = dt ?? DateTime.Now;
                lkDoiTuong.EditValue = ntkb.mvarDoiTuong_Id;
                lkBacSi.EditValue = ntkb.mvarBasSiKham_Id;
                lkDieuDuong.EditValue = ntkb.mvarDieuDuong_Id;
                lkCapHoLy.EditValue = ntkb.mvarCapHoLy_Id;
                txtChuanDoan.Text = ntkb.mvarDinhBenh;
                rtxDienBien.Text = ntkb.mvarDienBien;
                rtxYLenhKhac.Text = ntkb.mvarLoiDan;
                ckTaiKham.Checked = ntkb.mvarNgayTaiKham == DateTime.MinValue ? false : true;
                if (ntkb.mvarNgayTaiKham != DateTime.MinValue) { dtNgayTaiKham.DateTime = ntkb.mvarNgayTaiKham; }
                else { dtNgayTaiKham.EditValue = null; }
                ckThuocDacTri.Checked = ntkb.mvarThuocDacTri;
                ckRaVien.Checked = ntkb.mvarRavien;
                ckKhamNgoaiTru.Checked = ntkb.mvarKhamNgoaiTru;
                rdCapThuoc.Checked = ntkb.mvarLoaiToaThuoc == "BV" ? true : false;
                rdMuaNgoai.Checked = ntkb.mvarLoaiToaThuoc == "BV" ? false : true;
                EntityClass.cls_NoiTru_ToaThuoc tt = new EntityClass.cls_NoiTru_ToaThuoc();
                tt.GetToaThuoc_By_KhamBenh_Id(gridControl3, ntkb.mvarKhamBenh_Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lkBenhAn_EditValueChanged(object sender, EventArgs e)
        {
            if (lkBenhAn.EditValue != null)
            {
                EntityClass.cls_BenhAn ba = new EntityClass.cls_BenhAn();
                ba.Get_By_Key(int.Parse(lkBenhAn.EditValue.ToString()));
                EntityClass.cls_BenhAnChiTiet bact = new EntityClass.cls_BenhAnChiTiet();
                bact.Get_By_Key(ba.mvarBenhAn_Id);
                if (ba.mvarBenhAn_Id > 0)
                {
                    EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
                    DataRow dtr = bn.Get_By_Key_AllCol(ba.mvarBenhNhan_Id);

                    lbHoTen.Text = bn.mvarTenBenhNhan;
                    lbMaYTe.Text = bn.mvarMaYTe.ToString();
                    lkDoiTuong.EditValue = ba.mvarDoiTuong_Id;
                    lkBacSi.EditValue = ba.mvarBacSiDieuTriChinh_Id;
                    EntityClass.cls_NoiTru_KhamBenh ntkb = new EntityClass.cls_NoiTru_KhamBenh();
                    ntkb.GetListKhamBenh(gridControl1, ba.mvarBenhAn_Id);
                }
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            gridView3.DeleteSelectedRows();
        }

        private void repositoryItemLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            String duoc_id = (sender as BaseEdit).EditValue.ToString();
            string[] thongtinduoc = GetTenHoatChat(duoc_id);
            if (thongtinduoc.Length > 0)
            {
                gridView3.SetRowCellValue(-2147483647, gridView3.Columns["TenHoatChat"], thongtinduoc[0]);
                gridView3.SetRowCellValue(-2147483647, gridView3.Columns["DuongDung_Id"], thongtinduoc[1]);
                gridView3.SetRowCellValue(-2147483647, gridView3.Columns["DonViTinh_Id"], thongtinduoc[2]);
                gridView3.SetRowCellValue(-2147483647, gridView3.Columns["DonGiaThanhToan"], thongtinduoc[3]);
            }
        }

        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle == -2147483647 && e.Column.FieldName == "SoNgay")
            {
                int soluong = 0, sang = 0, trua = 0, chieu = 0, toi = 0, tong = 0;
                double thanhtien = 0;
                try
                { tong = int.Parse(gridView3.GetRowCellValue(-2147483647, gridView3.Columns["SoLuong_BuoiSang"]).ToString()); }
                catch { }
                try { tong = tong + int.Parse(gridView3.GetRowCellValue(-2147483647, gridView3.Columns["SoLuong_BuoiTrua"]).ToString()); }
                catch { }
                try { tong = tong + int.Parse(gridView3.GetRowCellValue(-2147483647, gridView3.Columns["SoLuong_BuoiChieu"]).ToString()); }
                catch { }
                try { tong = tong + int.Parse(gridView3.GetRowCellValue(-2147483647, gridView3.Columns["SoLuong_BuoiToi"]).ToString()); }
                catch { }
                try { soluong = int.Parse(e.Value.ToString()) * tong; }
                catch { }
                try { thanhtien = soluong * double.Parse(gridView3.GetRowCellValue(-2147483647, gridView3.Columns["DonGiaThanhToan"]).ToString()); }
                catch { }
                if (soluong > 0 && thanhtien > 0)
                {
                    gridView3.SetRowCellValue(-2147483647, gridView3.Columns["SoLuong"], soluong);
                    gridView3.SetRowCellValue(-2147483647, gridView3.Columns["SoTienThucTe"], thanhtien);
                }
            }
        }

        private void gridView3_KeyDown(object sender, KeyEventArgs e)
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

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle != -2147483647)
            {
                try
                {
                    if (gridView3.GetRowCellValue(e.FocusedRowHandle, gridView3.Columns["Duoc_Id"]).ToString().Length <= 0)
                    {
                        gridView3.DeleteSelectedRows();
                    }
                }
                catch { gridView3.DeleteSelectedRows(); }
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
            dataTb.Columns.Add("DonGiaThanhToan");
            dataTb.Columns.Add("SoTienThucTe");
            dataTb.Columns.Add("ChungTu_Id");
            //dataTb.Columns.Add("Huy");
            gr.DataSource = dataTb;
        }
        #endregion
        //Lưu hoặc update khám bệnh
        private int SaveKhamBenh()
        {
            EntityClass.cls_NoiTru_KhamBenh ntkb = new EntityClass.cls_NoiTru_KhamBenh();

            ntkb.mvarBasSiKham_Id =lkBacSi.EditValue==null?int.MinValue: int.Parse(lkBacSi.EditValue.ToString());
            ntkb.mvarDieuDuong_Id =lkDieuDuong.EditValue==null?int.MinValue:int.Parse( lkDieuDuong.EditValue.ToString());
            ntkb.mvarCapHoLy_Id = lkCapHoLy.EditValue==null?int.MinValue:int.Parse(lkCapHoLy.EditValue.ToString());
            ntkb.mvarThoiGianKham = DateTime.Now;
            ntkb.mvarNgayKham = DateTime.Today;
            ntkb.mvarDinhBenh = txtChuanDoan.Text;
            ntkb.mvarDienBien = rtxDienBien.Text;
            ntkb.mvarLoiDan = rtxYLenhKhac.Text;
            ntkb.mvarNgayTaiKham = ckTaiKham.Checked == true ? dtNgayTaiKham.DateTime : DateTime.MinValue;
            ntkb.mvarThuocDacTri = ckThuocDacTri.Checked;
            ntkb.mvarRavien = ckRaVien.Checked;
            ntkb.mvarKhamNgoaiTru = ckKhamNgoaiTru.Checked;
            ntkb.mvarNgayTao = DateTime.Today;
            ntkb.mvarNguoiTao_Id = ThuVien.loadform.userID;
            ntkb.mvarBenhAn_Id = int.Parse(lkBenhAn.EditValue.ToString());
            ntkb.mvarLanKham = 1;
            EntityClass.cls_NoiTru_LuuTru ntlt = new EntityClass.cls_NoiTru_LuuTru();
            ntkb.mvarLuuTru_Id=int.Parse(ntlt.GetCurrent_LuuTru_Id(ntkb.mvarBenhAn_Id));
            ntkb.mvarKhamBenh_Id = int.Parse(ntkb.Add());
            return ntkb.mvarKhamBenh_Id;
        }
        private void SaveToaThuoc(int khambenh_id)
        {
            try
            {
                for (int i = 0; i < gridView3.RowCount; i++)
                {
                    DataRow dt = gridView3.GetDataRow(i);

                    EntityClass.cls_NoiTru_ToaThuoc tt = new EntityClass.cls_NoiTru_ToaThuoc();
                    
                    tt.mvarKhamBenh_Id = khambenh_id;

                    tt.mvarDuoc_Id = int.Parse(gridView3.GetRowCellValue(i, gridView3.Columns["Duoc_Id"]).ToString());
                    tt.mvarSoLuong = int.Parse(gridView3.GetRowCellValue(i, gridView3.Columns["SoLuong"]).ToString());
                    tt.mvarSoNgay = byte.Parse(gridView3.GetRowCellValue(i, gridView3.Columns["SoNgay"]).ToString());
                    tt.mvarGhiChu = gridView3.GetRowCellValue(i, gridView3.Columns["GhiChu"]).ToString();
                    tt.mvarTienTe_Id = "VND";
                    tt.mvarNguonLayThuoc = "D";
                    tt.mvarLoaiGia_Id = 25;
                    tt.mvarNgayTao = DateTime.Today;
                    tt.mvarNguoiTao_Id = ThuVien.loadform.userID;
                    try
                    {
                        tt.mvarSoLuong_BuoiSang = int.Parse(gridView3.GetRowCellValue(i, gridView3.Columns["SoLuong_BuoiSang"]).ToString());
                    }
                    catch { }
                    try
                    {
                        tt.mvarSoLuong_BuoiTrua = int.Parse(gridView3.GetRowCellValue(i, gridView3.Columns["SoLuong_BuoiTrua"]).ToString());
                    }
                    catch { }
                    try
                    {
                        tt.mvarSoLuong_BuoiChieu = int.Parse(gridView3.GetRowCellValue(i, gridView3.Columns["SoLuong_BuoiChieu"]).ToString());
                    }
                    catch { }
                    try
                    {
                        tt.mvarSoLuong_BuoiToi = int.Parse(gridView3.GetRowCellValue(i, gridView3.Columns["SoLuong_BuoiToi"]).ToString());
                    }
                    catch { }
                    try
                    {
                        tt.mvarDuongDung_Id = int.Parse(gridView3.GetRowCellValue(i, gridView3.Columns["DuongDung_Id"]).ToString());
                    }
                    catch { }
                    tt.mvarDonGiaThanhToan = decimal.Parse(gridView3.GetRowCellValue(i, gridView3.Columns["DonGiaThanhToan"]).ToString());
                    tt.mvarSoTienThucTe = decimal.Parse(gridView3.GetRowCellValue(i, gridView3.Columns["SoTienThucTe"]).ToString());
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
    }
}
