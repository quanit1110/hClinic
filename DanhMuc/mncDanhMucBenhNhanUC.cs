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

namespace DanhMuc
{
    public partial class mncDanhMucBenhNhanUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncDanhMucBenhNhanUC()
        {
            InitializeComponent();
            Common.clsControl.LoadLK(lkQuocTich, "Lib_DanhMucQuocTich");
            Common.clsControl.LoadLK(lkDanToc, "Lib_DanToc");
            Common.clsControl.LoadLK(lkNgheNghiep, "NgheNghiep");
           // Common.clsControl.LoadLookUp(lkTinhThanh, "TinhThanhPho");
            Common.clsControl.LoadLK(lkNhomMau, "NhomMau");
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

        private void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            ThuVien.DanhMuc.LoadGV(gridControl1, txtHoTen.Text, txtNamSinh.Text);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            click();
        }
        private void click()
        {
            int[] rows = gridView1.GetSelectedRows();
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                try
                {
                    tthcTxtMaYte.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["MaYTe"]).ToString();
                    tthcTxtHoten.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["TenBenhNhan"]).ToString();
                    tthcTxtNgaySinh.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["NgaySinh"]).ToString();
                    tthcTxtNamSinh.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["NamSinh"]).ToString();
                    string GT = gridView1.GetRowCellValue(rows[i], gridView1.Columns["GioiTinh"]).ToString();
                    if (GT.Trim() == "T")
                    {
                        rdbGtNam.Checked = true;
                        rdbGtNu.Checked = false;
                    }
                    else
                    {
                        rdbGtNam.Checked = false;
                        rdbGtNu.Checked = true;
                    }                   
                    lkNhomMau.Properties.NullText = gridView1.GetRowCellValue(rows[i], gridView1.Columns["NhomMau_Id"]).ToString();
                    lkYeuTo.Properties.NullText = gridView1.GetRowCellValue(rows[i], gridView1.Columns["YeuToRh_Id"]).ToString();
                    lkQuocTich.Properties.NullText = gridView1.GetRowCellValue(rows[i], gridView1.Columns["QuocTich_Id"]).ToString();
                    lkDanToc.Properties.NullText = gridView1.GetRowCellValue(rows[i], gridView1.Columns["DanToc_Id"]).ToString();
                    lkNgheNghiep.Properties.NullText = gridView1.GetRowCellValue(rows[i], gridView1.Columns["NgheNghiep_Id"]).ToString();
                    lkTinhThanh.Properties.NullText = gridView1.GetRowCellValue(rows[i], gridView1.Columns["TinhThanh_Id"]).ToString();
                    lkQuanHuyen.Properties.NullText = gridView1.GetRowCellValue(rows[i], gridView1.Columns["QuanHuyen_Id"]).ToString();
                    lkPhuongXa.Properties.NullText = gridView1.GetRowCellValue(rows[i], gridView1.Columns["XaPhuong_Id"]).ToString();
                    txtSoNha.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["SoNha"]).ToString();
                    txtSoDienThoai.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["SoDienThoai"]).ToString();
                    txtTienSuBenh.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["TienSuBenh"]).ToString();
                    txtDiUng.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["TienSuDiUng"]).ToString();
                    txtGhiChu.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["GhiChu"]).ToString();
                    txtCMND.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["CMND"]).ToString();
                    txtHoChieu.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["HoChieu"]).ToString();
                    txtNoiTru.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["SoLuuTruNoiTru"]).ToString();
                    txtNgoaiTru.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["SoLuuTruNgoaiTru"]).ToString();
                    string TV = gridView1.GetRowCellValue(rows[i], gridView1.Columns["TuVong"]).ToString();
                    if (TV.Trim() == "False")
                    {
                        rdoTuVong.Checked = false;
                    }
                    else
                    {
                        rdoTuVong.Checked = true;
                    }
                    string nn = gridView1.GetRowCellValue(rows[i], gridView1.Columns["VietKieu"]).ToString();
                    string nn1 = gridView1.GetRowCellValue(rows[i], gridView1.Columns["NguoiNuocNgoai"]).ToString();
                    if (nn.Trim() == "False" & nn1.Trim()=="False" )
                    {
                        rdbVN.Checked = true;
                        rdbNN.Checked = false;
                        rdbVK.Checked = false;
                    }
                    else

                    if (nn.Trim() == "True")
                    {
                        rdbNN.Checked = true;
                        rdbVK.Checked = false;
                        rdbVN.Checked = false;
                    }
                    else
                    {
                        rdbNN.Checked = false;
                        rdbVK.Checked = true;
                        rdbVN.Checked = false;
                    }
                }
                catch
                {

                }
            }
        }

        private void lkTinhThanh_TextChanged(object sender, EventArgs e)
        {
            string where = lkTinhThanh.EditValue.ToString();
            Common.clsControl.LoadLookUp(lkQuanHuyen, "DonViHanhChinh_MaCapTren", where);
        }

        private void lkQuanHuyen_EditValueChanged(object sender, EventArgs e)
        {
            string where = lkQuanHuyen.EditValue.ToString();
            Common.clsControl.LoadLookUp(lkPhuongXa, "DonViHanhChinh_MaCapTren", where);
        }
    }
}
