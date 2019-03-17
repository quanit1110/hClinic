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

namespace ChamSocKhachHang
{
    public partial class mnc1DanhMucCongTyBHUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mnc1DanhMucCongTyBHUC()
        {
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            this.Width = widthScreen;
            this.Height = heightScreen;

            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            getListCongTy();
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

        private void getListCongTy()
        {
            EntityClass.cls_KSK_CongTy cty = new EntityClass.cls_KSK_CongTy();
            cty.Get_By_CongTy(gridControl1);
            //GridColumn clo1 = gridView1.Columns["NhaNuoc"];
            //GridColumn clo2 = gridView1.Columns["NuocNgoai"];
            //GridColumn clo3 = gridView1.Columns["Khac"];
            //gridView1.BeginSort();
            //try
            //{
            //    gridView1.ClearGrouping();
            //    clo1.GroupIndex = 0;
            //    clo2.GroupIndex = 0;
            //    clo3.GroupIndex = 0;
            //}
            //finally
            //{
            //    gridView1.EndSort();
            //}
        }
    }
}
