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

namespace DuocPham
{
    public partial class mncNhapThuocTuNCCUC : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable dataTb = new DataTable();
        public mncNhapThuocTuNCCUC()
        {
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hi?n th? theo kích thu?c c?a màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;

            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1386 là chi?u r?ng, 788 là chi?u cao Form khi thi?t k?, xem trong Properties c?a Form
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            Common.clsControl.LoadLookup(lkNCC, "DanhSachDonViGiao_NhapBenNgoai", 2);
            Common.clsControl.LoadLK(lkGoiThau, "DM_GoiThau");
            Common.clsControl.LoadLookup(lkDonViGiao, "DanhSachDonViGiao_NhapBenNgoai", 2);
            Common.clsControl.LoadLK(lkDonViNhan, "DanhSachDonViNhan_NhapBenNgoai");
            //Common.clsControl.LoadLK(lkNguoiNhan, "DanhSachNguoiNhan_NhapBenNgoai");
            Common.clsControl.LoadLK(lkTrangThai, "DanhSachTrangThai_NhapBenNgoai");
            Common.clsControl.LoadLK(lkNguonDuoc, "DanhSachNguonHang_NhapBenNgoai");
            Common.clsControl.LoadLookUpRepos(lkDuoc, "DanhMucDuoc_NhapBenNgoai");
            Common.clsControl.LoadLookUpRepos(lkDVT, "DonViTinh");
            KhoiTaoGrTb(gridControl1, dataTb);
            lkDuoc.NullText = "Chọn tên dược";

        }

        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                //g?i d? quy n?u nhu 1 control nào có ch?a các control khác n?a

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                //canh l?i to? d? x, y, chi?u r?ng, cao cho các control trên form

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }

        private void KhoiTaoGrTb(GridControl gr, DataTable dataTb)
        {
            dataTb.Columns.Add("Duoc_Id");
            dataTb.Columns.Add("DonViTinhCoBan_Id");
            dataTb.Columns.Add("SoLuong");
            dataTb.Columns.Add("DonGia");
            dataTb.Columns.Add("ThanhTien");
            dataTb.Columns.Add("GiaTriVAT");
            dataTb.Columns.Add("SoLoHang");
            dataTb.Columns.Add("HanDung");
            gr.DataSource = dataTb;
        }
        private void AddDataGrv(GridControl gr, DataTable dataTb, string duocID, String tendv, int sl, int dongia, int thanhtoan/*, String nhomdv*/)
        {

            DataRow dtr = dataTb.NewRow();
            dtr["Duoc_Id"] = duocID;
            dtr["DonViTinhCoBan_Id"] = tendv;
            dtr["SoLuong"] = sl;
            dtr["DonGia"] = dongia;
            dtr["ThanhTien"] = thanhtoan;
            dataTb.Rows.Add(dtr);
            gr.DataSource = dataTb;

        }


        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void lkDuoc_EditValueChanged(object sender, EventArgs e)
        {            
            gridView1.SetFocusedRowCellValue("SoLuong", 1);
            gridView1.SetFocusedRowCellValue("DonViTinhCoBan_Id", 949);
        }

        private void LoadGV()
        {
            EntityClass.cls_GiaHopDong ghd = new EntityClass.cls_GiaHopDong();
            DataTable dt = new DataTable();
            try
            {
                dt = ghd.GetGiaHD(int.Parse(lkNCC.EditValue.ToString()), int.Parse(lkGoiThau.EditValue.ToString()));
                int ID = int.Parse(dt.Rows[0]["GiaHopDong_Id"].ToString());
                EntityClass.cls_GiaHopDongChiTiet hdct = new EntityClass.cls_GiaHopDongChiTiet();
                hdct.GetGiaHDChiTiet(gridControl1, ID);
                for (int i = 1; i <= gridView1.SelectedRowsCount; i++)
                {
                    int giaHD = int.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["DonGiaHopDong"]).ToString());
                    int SL = int.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["SoLuongCungCap"]).ToString());
                    gridView1.SetRowCellValue(i, gridView1.Columns["SoLuongCungCap"], giaHD * SL);
                }
            }
            catch { }
            
        }

        private void lkGoiThau_TextChanged(object sender, EventArgs e)
        {
            LoadGV();
        }
    }
}
