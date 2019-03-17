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

namespace PhauThuatThuThuat
{
    public partial class mncDanhSachBenhNhanKhamHoiChuanUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncDanhSachBenhNhanKhamHoiChuanUC()
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string ma = string.Empty;
            if(ckChuaKham.Checked == true)
            {
                ckDaKham.Checked = false;
                ma = "ChuaThucHien";
            }
            else
            {
                ckDaKham.Checked = true;
                ckChuaKham.Checked = false;
                ma = "DaThucHien";
            }
            
            //ThuVien.mySQL.GridView_SPr(gridControl1, "sp_clsYeuCau", "getDanhSachChoHoiChuan", "TrangThai", ma);
        }

        private void mncDanhSachBenhNhanKhamHoiChuanUC_Load(object sender, EventArgs e)
        {
            dtDenNgay.Text = DateTime.Now.ToString();
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            DateTime dt = new DateTime(nam, thang, 1);
            dtTuNgay.Text = dt.ToString();
        }
    }
}
