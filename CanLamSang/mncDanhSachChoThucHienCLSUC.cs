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

namespace CanLamSang
{
    public partial class mncDanhSachChoThucHienCLSUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncDanhSachChoThucHienCLSUC()
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
            //ThuVien.CanLamSang.CamLamSang.NhomDichVu(lkNhomDichVu);
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

        //private void btTimKiem_Click(object sender, EventArgs e)
        //{
            
        //    if (lkNhomDichVu.Text != string.Empty)
        //    {
        //        string ID = lkNhomDichVu.EditValue.ToString();
        //        ThuVien.CanLamSang.CamLamSang.DSThucHienCLS(gridControl1, ID);
        //        ThuVien.CanLamSang.CamLamSang.DSDaThucHienCLS(gridControl2, ID);
        //    }
        //}
    }
}
