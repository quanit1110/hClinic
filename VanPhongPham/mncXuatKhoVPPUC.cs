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
    public partial class mncXuatKhoVPPUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncXuatKhoVPPUC()
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
            ThuVien.clsXuatKhoVPP.KhoDuoc(lkNoiGiao);
            ThuVien.clsXuatKhoVPP.KhoDuoc(lkNoiNhan);
            ThuVien.clsXuatKhoVPP.NhanVien(lkNguoiNhan);
            ThuVien.clsXuatKhoVPP.NhanVien(lkNguoiGiao);
            
            ThuVien.clsXuatKhoVPP.SoChungTu(lkSoPhieu);
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

        private void lkSoPhieu_EditValueChanged(object sender, EventArgs e)
        {
            if (lkSoPhieu.EditValue != null)
            {
                string where = lkSoPhieu.EditValue.ToString();
                ThuVien.clsXuatKhoVPP.XuatKhoVPP(gridControl1, where);
                string[] ttct = ThuVien.clsXuatKhoVPP.ThongTinChungTu(where);
                if (ttct.Length > 0)
                {
                    lkNguoiNhan.EditValue = ttct[8];
                    lkNoiNhan.EditValue = ttct[11];
                    lkNoiGiao.EditValue = ttct[14];
                    lkNguoiGiao.Text = ttct[9];
                    txtDienGiai.Text = ttct[10];
                    
                    txtThanhTien.Text = ttct[6];
                    txtSoPhieuLinh.Text = ttct[13];
                    try
                    {
                        dtNgay.DateTime = DateTime.Parse(ttct[7]);
                        dtNgayPhieuLinh.DateTime = DateTime.Parse(ttct[12]);
                    }
                    catch { }

                }
            }
        }
    }
}
