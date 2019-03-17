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
    public partial class mnc1CanhBaoThieuSoLuongUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mnc1CanhBaoThieuSoLuongUC()
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
            loadngay();
            LoadNguonDuoc();
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

        private void loadngay()
        {
            dtDenNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            DateTime dt = new DateTime(nam, thang, 1);
            dtTungay.Text = dt.ToString("dd/MM/yyyy");
        }

        string ma;
        private void loaDuoc()
        {
            if (rdThuoc.Checked == true)
            {
                ma = "T";
            }
            else 
            if (rdVatTu.Checked == true)
            {
                ma = "V";
            }
            else
                if (rdHoatChat.Checked == true)
            {
                ma = "H";
            }
            else
                if (rdTatCa.Checked == true)
            {
                ma = string.Empty;
            }
            //ThuVien.mySQL.Load_Lookup_SP(lkLoaiDuoc, "sp_DM_LoaiDuoc", "getLoaiDuoc", "LoaiDuoc_Id", "TenLoaiDuoc",ma);
        }

        private void rdThuoc_CheckedChanged(object sender, EventArgs e)
        {
            loaDuoc();
        }

        private void rdHoatChat_CheckedChanged(object sender, EventArgs e)
        {
            loaDuoc();
        }

        private void rdVatTu_CheckedChanged(object sender, EventArgs e)
        {
            loaDuoc();
        }

        private void rdTatCa_CheckedChanged(object sender, EventArgs e)
        {
            loaDuoc();
        }

        private void LoadNguonDuoc()
        {
            ThuVien.mySQL.Load_Lookup_PR(lkNguonDuoc, "sp_DM_NguonHang", "GetNguonHang", "NguonDuoc_Id", "TenNguonDuoc");
        }

    }
}
