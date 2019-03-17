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

namespace VanPhongPham
{
    public partial class mncDuyetPhieuLinhVPPUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncDuyetPhieuLinhVPPUC()
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
            ThuVien.clsDuyetPhieuLinhVPP.KhoDuoc(lkNoiDuyet);
            ThuVien.clsDuyetPhieuLinhVPP.LoaiChungTu(lkLoaiPhieuLinh);
            ThuVien.clsDuyetPhieuLinhVPP.NhanVien(lkNguoiLinh);
            ThuVien.clsDuyetPhieuLinhVPP.SoPhieuLinh(lkSoPhieuLinh);
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

        private void lkSoPhieuLinh_EditValueChanged(object sender, EventArgs e)
        {
            if (lkSoPhieuLinh.EditValue != null)
            {
                string where = lkSoPhieuLinh.EditValue.ToString();
                ThuVien.clsDuyetPhieuLinhVPP.DuyetPhieuLinhVPP(gridControl1, where);
                string[] ttct = ThuVien.clsDuyetPhieuLinhVPP.ThongTinPhieuLinh(where);
                if (ttct.Length > 0)
                {
                    lkNoiDuyet.EditValue = ttct[7];                   
                    lkNguoiLinh.EditValue = ttct[3];
                    lkLoaiPhieuLinh.EditValue = ttct[8];
                    txtDienGiai.Text = ttct[5];
                    try
                    {
                        dtNgay.DateTime = DateTime.Parse(ttct[2]);
                    }
                    catch { }

                }
            }
        }
    }
}
