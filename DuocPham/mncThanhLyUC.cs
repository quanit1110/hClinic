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

namespace DuocPham
{
    public partial class mncThanhLyUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncThanhLyUC()
        {
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            LoadForm();
        }
        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {
            foreach (Control control in recussiveControl.Controls)
            {
                if (control.Controls.Count != 0)

                ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);
            }
        }

        private void LoadForm()
        {
            Common.clsControl.LoadLookup(lkNoiXuat, "DanhSachDonViGiao_ThanhLy", 2);
            Common.clsControl.LoadLookup(lkNguonDuoc, "DanhSachNguonDuoc_NhapBenNgoai", 2);
            Common.clsControl.LoadLookup(lkLoaiPhieu, "LoaiPhieuDuoc_ThanhLy", 2);
            Common.clsControl.LoadLookup(lkDuocPham, "DanhMucDuoc_TonKho_ByKhoa_Id_NguonDuoc_Id", 2);
            Common.clsControl.LoadLookup(lkTrangThai, "DanhSachTrangThai_ThanhLy", 2);

        }


    }
}
