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
    public partial class mncThietLapBaoCaoTheoICDUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncThietLapBaoCaoTheoICDUC()
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
            ThuVien.DanhMuc.BCNhomBenh(grv1);
            Common.clsControl.LoadLK(lkPhanNhomBenh, "DM_NhomBenh");

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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int[] rows = gridView1.GetSelectedRows();
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                txtMaNhomBenh.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["MaNhomBenh"]).ToString();
                txtTenNhomBenh.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["TenNhomBenh"]).ToString();
                txtMaICD.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["MaICD"]).ToString();
                txtGhiChu.Text = gridView1.GetRowCellValue(rows[i], gridView1.Columns["GhiChu"]).ToString();

                string phannhombenh = gridView1.GetRowCellValue(rows[i], gridView1.Columns["PhanNhomBenh_ID"]).ToString();
                lkPhanNhomBenh.EditValue = phannhombenh;
                string ma = gridView1.GetRowCellValue(rows[i], gridView1.Columns["NhomBenh_Id"]).ToString();
                ThuVien.DanhMuc.DM_IDC(grv2, ma);
            }
        }
    }
}
