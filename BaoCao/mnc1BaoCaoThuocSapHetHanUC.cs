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

namespace BaoCao
{
    public partial class mnc1BaoCaoThuocSapHetHanUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mnc1BaoCaoThuocSapHetHanUC()
        {
            InitializeComponent();
            //l?y kích thu?c c?a màn hình
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
            loadLookup_khoDuoc();
            loadLookup_NguonDuoc();
            dtTungay.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

        private void loadLookup_khoDuoc()
        {
            ThuVien.mySQL.Load_Lookup_PR(lkKhoDuoc, "sp_DM_KhoDuoc", "GetKhoDuoc", "KhoDuoc_Id", "TenKho");
        }

        private void loadLookup_NguonDuoc()
        {
            ThuVien.mySQL.Load_Lookup_PR(lkNguonDuoc, "sp_DM_NguonHang", "GetNguonHang", "NguonDuoc_Id","TenNguonDuoc");
        }

        private void txtSoNgayHetHan_TextChanged(object sender, EventArgs e)
        {
            if (txtSoNgayHetHan.Text != string.Empty)
            {
                int ngay = int.Parse(txtSoNgayHetHan.Text);
                DateTime dt = DateTime.Now.AddDays(ngay);
                dtDenNgay.Text = dt.ToString("dd/MM/yyyy");
            } 
        }

        private void txtSoNgayHetHan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
