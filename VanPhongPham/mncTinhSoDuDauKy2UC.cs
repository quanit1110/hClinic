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
using DevExpress.XtraGrid.Columns;

namespace VanPhongPham
{
    public partial class mncTinhSoDuDauKy2UC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncTinhSoDuDauKy2UC()
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

        private void btnTinhSoDu_Click(object sender, EventArgs e)
        {
            ThuVien.clsTinhSoDuDauKyVPP.SoDuDauKy(gridControl1, txtThang.Text, txtNam.Text);
            try
            {
                GridColumn colReceived = gridView1.Columns["TenKho"];
                gridView1.BeginSort();
                try
                {
                    //gridView1.ClearGrouping();
                    colReceived.GroupIndex = 0;
                }
                finally
                {
                    gridView1.EndSort();
                }
                GridColumn colReceived1 = gridView1.Columns["TenVPP"];
                gridView1.BeginSort();
                try
                {
                    //gridView1.ClearGrouping();
                    colReceived1.GroupIndex =1;
                }
                finally
                {
                    gridView1.EndSort();
                }
                gridView1.ExpandAllGroups();
            }
            catch { };
        }
    }
}
