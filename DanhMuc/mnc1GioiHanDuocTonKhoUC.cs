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
    public partial class mnc1GioiHanDuocTonKhoUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mnc1GioiHanDuocTonKhoUC()
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
            Common.clsControl.LoadLK(lkKhoDuoc, "KhoDuoc");
            Common.clsControl.LoadLK(lkNguonHang, "DuocTheoNguonHang");
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

        private void lkKhoDuoc_TextChanged(object sender, EventArgs e)
        {
            //LoadGV();
        }


        //private void LoadGV()
        //{

        //    gridControl1.DataSource = null;
        //    gridView1.Columns.Clear();

        //    if (lkNguonHang.EditValue == null)
        //    {
        //        string maKD = lkKhoDuoc.EditValue.ToString();
        //        ThuVien.DanhMuc.LoadGTDuoc_GioiHan(gridControl1, "KhoDuoc_Id = " + maKD + "");
        //    }
        //    else
        //    if (lkKhoDuoc.EditValue == null)
        //    {
        //        string maNH = lkNguonHang.EditValue.ToString();
        //        ThuVien.DanhMuc.LoadGTDuoc_GioiHan(gridControl1, "NguonDuoc_Id = " + maNH + "");
        //    }
        //    else
        //    {
        //        string maKD = lkKhoDuoc.EditValue.ToString();
        //        string maNH = lkNguonHang.EditValue.ToString();
        //        ThuVien.DanhMuc.LoadGTDuoc_GioiHan(gridControl1, "NguonDuoc_Id = " + maNH + " and KhoDuoc_Id = " + maKD + " ");
        //    }           

        //}

        //private void lkNguonHang_TextChanged(object sender, EventArgs e)
        //{
        //    LoadGV();
        //}
        
    }
}
