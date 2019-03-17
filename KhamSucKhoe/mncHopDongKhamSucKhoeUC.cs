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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using System.Data.SqlClient;
using System.Globalization;

namespace KhamSucKhoe
{
    public partial class mncHopDongKhamSucKhoeUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai bao bien--------------------
        private int status = 0;
        private DataTable dataTb = new DataTable();
        string So_HD;
        string tam;
        string tenpb;
        string MaPB;
        Dictionary<int, int> key = new Dictionary<int, int>();
        #endregion

        public mncHopDongKhamSucKhoeUC()
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
            Common.clsControl.LoadLK(lkCongTy, "KSK_CongTy");
            Common.clsControl.LoadLK(lkThanhToan, "KSK_HinhThucThanhToan");
            Common.clsControl.LoadLK(lkTrangThai, "KSK_TrangThai");
            Common.clsControl.LoadLK(lkLoaiHopDong, "KSK_LoaiHD");
            Common.clsControl.LoadLK(lkNhomDichVu, "DM_NhomDichVu");
            lkNhomDichVu.EditValue = 6;
            KhoiTaoGrTb(gridControl1, dataTb);         
            ThuVien.loadform.disableControl(this);
            loadformHD();           
            Common.clsControl.LoadLookUpRepos(lkTenPhongBan, "DonViThucHien");
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

        #region Load Form ----------------------------
        private void loadTV(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select DichVu_Id,TenDichVu from DM_DichVu where NhomDichVu_Id = '" + lkNhomDichVu.EditValue + "'");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["TenDichVu"].ToString();
                tnParent.Tag = Convert.ToInt32(dr["DichVu_Id"]);
                tv.Nodes.Add(tnParent);
            }
        }
        private void loadformHD()
        {
            txtSoBn.Text = "1";
            txtGiaTriHD.Text = "0";
            txtTienTamUng.Text = "0";
            txtTienPhatSinh.Text = "0";
            txtChieuKhau.Text = "0";
            txtTienChieuKhau.Text = "0";
            txtTienChiNhanVien.Text = "0";
            txtSoHD.Text = "HDKT" + "/" + DateTime.Now.Month.ToString() + "/" +DateTime.Now.Year.ToString();
            dtNgayHieuLuc.Text = DateTime.Now.ToString();
            dtNgayHetHan.Text = DateTime.Now.ToString();
            dtNgayHD.Text = DateTime.Now.ToString();
            dtLayMau.Text = DateTime.Now.ToString();
            dtNgayKham.Text = DateTime.Now.ToString();
        }
        private void Getdata_bySoHopDong(string id)
        {
            EntityClass.cls_KSK_HopDong hd = new EntityClass.cls_KSK_HopDong();
            hd.GetData_BySoHopdong(id);
            if (hd.mvarHopDong_ID > 0)
            {
                txtIDHopDong.Text = hd.mvarHopDong_ID.ToString();
                lkCongTy.EditValue = hd.mvarCongty_id;
                lkThanhToan.EditValue = hd.mvarHinhThucThanhToan_PhatSinh;
                dtNgayHieuLuc.DateTime = hd.mvarNgayHieuLuc_HD;
                dtNgayHieuLuc.DateTime = hd.mvarNgayHetHieuLuc_HD;
                txtDienGiai.Text = hd.mvarDienGiai;
                dtNgayHD.DateTime = hd.mvarNgay_HD;
                txtGiaTriHD.Text = hd.mvarGiaTri_HD.ToString();
                txtSoBn.Text = hd.mvarSoluong_BN.ToString();
                txtTienTamUng.Text = hd.mvarGiaTri_TamUng.ToString();
                txtTienPhatSinh.Text = hd.mvarGiaTri_PhatSinh.ToString();
                lkTrangThai.EditValue = hd.mvarTrangThai_HD;
                lkLoaiHopDong.EditValue = hd.mvarLoai_HD;
                txtChieuKhau.Text = hd.mvarTyLeChietKhau.ToString();
                txtTienChieuKhau.Text = hd.mvarGiaTriChietKhau.ToString();
                txtTienChiNhanVien.Text = hd.mvarTienChiNhanVien.ToString();
                dtLayMau.DateTime = hd.mvarThoiGianLayMau;
                dtNgayKham.DateTime = hd.mvarThoiGiankham;
            }
            getListDichVu();
            sum();
        }
        #endregion
      

        #region Envent -----------------------
        private void btSoHD_Click(object sender, EventArgs e)
        {
            
            ThuVien.FcLoadLookup hopdong = new ThuVien.FcLoadLookup("KSK_HopDong", "HopDong_ID", "Congty_id", "So_HD", "");
            hopdong.Text = "Danh sách công ty hợp đồng ";
            hopdong.ShowDialog();
            txtSoHD.Text = hopdong.lkText;
            So_HD = hopdong.lkId;
            dataTb.Clear();
            Getdata_bySoHopDong(txtSoHD.Text);            
        }

        private void sum()
        {
            try
            {
                object sum = gridView1.Columns["DonGiaPhaiThu"].SummaryItem.SummaryValue;
                string text = sum.ToString();
                if (text.Length > 0)
                {
                    Double sl = Convert.ToDouble(text);
                    Double sobn = Convert.ToDouble(txtSoBn.Text);
                    txtTienPhatSinh.Text = (sl * sobn).ToString("##,#");
                    txtGiaTriHD.Text = txtTienPhatSinh.Text;
                    txtTienChieuKhau.Text = ((Double.Parse(txtChieuKhau.Text) / 100) * Double.Parse(txtTienPhatSinh.Text)).ToString("##,#");
                }
            }
            catch
            {

            }
        }
      
        private void lkNhomDichVu_TextChanged(object sender, EventArgs e)
        {
            loadTV(treeView1);
        }

        private void getListDichVu()
        {
            EntityClass.cls_KSK_HopDong_DichVu hd = new EntityClass.cls_KSK_HopDong_DichVu();
            hd.GetData_ByKeyHD(gridControl1, dataTb, So_HD);         
            //if (gridView1.RowCount > 0)
            //{
            //    GridColumn clo1 = gridView1.Columns["TenNhomDichVu"];
            //    gridView1.BeginSort();
            //    try
            //    {
            //        gridView1.ClearGrouping();
            //        clo1.GroupIndex = 0;
            //    }
            //    finally
            //    {
            //        gridView1.EndSort();
            //    }
            //}
            //gridView1.ExpandAllGroups();
        }
     
        private void KhoiTaoGrTb(GridControl gr, DataTable dataTb)
        {
            dataTb.Columns.Add("DichVu_ID");
            dataTb.Columns.Add("TenDichVu");
            dataTb.Columns.Add("PhongBan_Id");
            dataTb.Columns.Add("DonGia");
            dataTb.Columns.Add("DonGiaPhaiThu");
            dataTb.Columns.Add("TenNhomDichVu");
            gr.DataSource = dataTb;
        }
        private void AddDataGrv(GridControl gr, DataTable dataTb, int dichvu, String tendv,string tenPB, String dongia, String thanhtoan/*, String nhomdv*/)
        {

            DataRow dtr = dataTb.NewRow();
            dtr["DichVu_ID"] = dichvu;
            dtr["TenDichVu"] = tendv;
            dtr["PhongBan_Id"] = tenPB;
            dtr["DonGia"] = dongia;
            dtr["DonGiaPhaiThu"] = thanhtoan;
            dataTb.Rows.Add(dtr);
            gr.DataSource = dataTb;

        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            int[] rows = gridView1.GetSelectedRows();
            int Dichvu_ID;
            Dichvu_ID = int.Parse(e.Node.Tag.ToString());
            getGia_DichVu(Dichvu_ID);
            getPhongBan_DichVu(Dichvu_ID);
            if (e.Node.Checked == true)
            {                
                AddDataGrv(gridControl1, dataTb, Dichvu_ID, e.Node.Text.ToString(),MaPB,tam,tam);
                sum();
            }
            else if (e.Node.Checked == false)
            {
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);
                    string text = row[0].ToString();
                    if (text == Dichvu_ID.ToString())
                    {
                        dataTb.Rows.RemoveAt(i);
                        sum();
                    }
                }
            }
        }

        private void getGia_DichVu(int ID)
        {
            EntityClass.cls_DM_DichVu_DonGia dv = new EntityClass.cls_DM_DichVu_DonGia();
            dv.Get_By_GiaDV(ID);
            if(dv.mvarDichVu_DonGia_Id > 0)
            {
                tam = dv.mvarDonGia.ToString();
            }
        }

        private void getPhongBan_DichVu(int ID)
        {
            EntityClass.cls_DM_PhongBan_DichVu pb = new EntityClass.cls_DM_PhongBan_DichVu();
            DataRow dr =  pb.Get_PhongBan_DichVu(ID);
            tenpb = dr["TenPhongBan"].ToString();
            MaPB = dr["PhongBan_Id"].ToString();
        }
        private int LuuThongTinHopDong()
        {
            EntityClass.cls_KSK_HopDong hd = new EntityClass.cls_KSK_HopDong();
            hd = LoadThongTinHopDong(hd);
            hd.mvarHopDong_ID = int.Parse(hd.Add());
            return hd.mvarHopDong_ID;
        }
        private int SuaThongTinHopDong()
        {
            EntityClass.cls_KSK_HopDong hd = new EntityClass.cls_KSK_HopDong();
            hd = LoadThongTinHopDong(hd);
            hd.mvarHopDong_ID = int.Parse(hd.Update());
            return hd.mvarHopDong_ID;
        }
        private EntityClass.cls_KSK_HopDong LoadThongTinHopDong(EntityClass.cls_KSK_HopDong hd)
        {
            hd.mvarCongty_id = int.Parse(lkCongTy.EditValue.ToString());
            hd.mvarSo_HD = txtSoHD.Text;
            hd.mvarHinhThucThanhToan_PhatSinh = int.Parse(lkThanhToan.EditValue.ToString());
            hd.mvarNgayHieuLuc_HD = dtNgayHieuLuc.DateTime;
            hd.mvarNgayHetHieuLuc_HD = dtNgayHetHan.DateTime;
            hd.mvarDienGiai = txtDienGiai.Text;
            hd.mvarNgay_HD = dtNgayHD.DateTime;
            hd.mvarGiaTri_HD = decimal.Parse(txtGiaTriHD.Text);
            hd.mvarSoluong_BN = decimal.Parse(txtSoBn.Text);
            hd.mvarGiaTri_TamUng = decimal.Parse(txtTienTamUng.Text);
            hd.mvarGiaTri_PhatSinh = decimal.Parse(txtTienPhatSinh.Text);
            hd.mvarTrangThai_HD = int.Parse(lkTrangThai.EditValue.ToString());
            hd.mvarLoai_HD = int.Parse(lkLoaiHopDong.EditValue.ToString());
            hd.mvarTyLeChietKhau = decimal.Parse(txtChieuKhau.Text);
            hd.mvarGiaTriChietKhau = txtTienChieuKhau.Text == string.Empty ? decimal.Parse("0") : decimal.Parse(txtChieuKhau.Text);
            hd.mvarTienChiNhanVien = decimal.Parse(txtTienChiNhanVien.Text);
            hd.mvarThoiGianLayMau = dtLayMau.DateTime;
            hd.mvarThoiGiankham = dtNgayKham.DateTime;
            return hd;
        }


        private void LuuHopDong_DichVu(int HopDong_Id)
        {
            EntityClass.cls_KSK_HopDong_DichVu dv = new EntityClass.cls_KSK_HopDong_DichVu();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                dv.mvarHopDong_Id = HopDong_Id;
                dv.mvarDichVu_Id = int.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["DichVu_ID"]).ToString());
                dv.mvarDonGia = decimal.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["DonGia"]).ToString());
                dv.mvarPhongBan_Id = int.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["PhongBan_Id"]).ToString());
                dv.mvarDonGiaPhaiThu = decimal.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["DonGiaPhaiThu"]).ToString());
                dv.mvarTienTe_Id = "VND";
                dv.mvarTyGia = 1;
                dv.mvarMoTa = gridView1.GetRowCellValue(i, gridView1.Columns["TenDichVu"]).ToString();
                dv.mvarNgayTao = DateTime.Now;
                dv.Add();

            }           
        }
        
        private void SuaHopDong_DichVu()
        {
            EntityClass.cls_KSK_HopDong_DichVu dv = new EntityClass.cls_KSK_HopDong_DichVu();
            DataTable dt = new DataTable();
            dt = dv.CheckDeleteData_ByKey(int.Parse(txtIDHopDong.Text));
            foreach (DataRow row in dt.Rows)
            {
                key.Add(int.Parse(row["DichVu_ID"].ToString()), int.Parse(row["DichVu_ID"].ToString()));
            }
                for (int i = 0; i < gridView1.RowCount; i++)
            {
                dv.mvarHopDong_Id = int.Parse(txtIDHopDong.Text);
                dv.mvarDichVu_Id = int.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["DichVu_ID"]).ToString());
                dv.mvarDonGia = decimal.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["DonGia"]).ToString());
                dv.mvarPhongBan_Id = int.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["PhongBan_Id"]).ToString());
                dv.mvarDonGiaPhaiThu = decimal.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["DonGiaPhaiThu"]).ToString());
                dv.mvarTienTe_Id = "VND";
                dv.mvarTyGia = 1;
                dv.mvarMoTa = gridView1.GetRowCellValue(i, gridView1.Columns["TenDichVu"]).ToString();
                dv.mvarNgayTao = DateTime.Now;
                if(key.ContainsValue(dv.mvarDichVu_Id))
                {

                } 
                else
                {
                    dv.Add();
                }

            }
        }
        #endregion

        #region Code Insert. Edit -----------------------------
        public bool editCommand()
        {
            status = 3;
            return true;
        }
        public bool addCommand()
        {
            ThuVien.loadform.enableControl(this);
            status = 1;
            loadformHD();
            return true;
        }
        public bool saveCommand()
        {
            if (status == 1)
            {
               int hopDong_Id= LuuThongTinHopDong();
                LuuHopDong_DichVu(hopDong_Id);
            }
            else if (status == 3)
            {
                int hopDong_Id = SuaThongTinHopDong();
                SuaHopDong_DichVu();
            }
            status = 0;
            return true;
        }
        public bool deleteCommand()
        {
            status = 2;
            EntityClass.cls_KSK_HopDong hd = new EntityClass.cls_KSK_HopDong();
            if (txtIDHopDong.Text != string.Empty)
            {
                hd.mvarHopDong_ID = int.Parse(txtIDHopDong.Text);
                hd.Delete();
                EntityClass.cls_KSK_HopDong_DichVu dv = new EntityClass.cls_KSK_HopDong_DichVu();
                dv.mvarHopDong_Id = int.Parse(txtIDHopDong.Text);
                dv.DeleteHopDong();
            }
            return true;
        }
        #endregion

        #region Sự kiện trên gridview
        private void txtSoBn_TextChanged(object sender, EventArgs e)
        {
            sum();
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName != "DonGiaPhaiThu")
                e.Cancel = true;
        }

        #endregion

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            sum();
        }
    }
}
