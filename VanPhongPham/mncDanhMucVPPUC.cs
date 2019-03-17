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
    public partial class mncDanhMucVPPUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncDanhMucVPPUC()
        {

            InitializeComponent();

            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            Common.clsControl.LoadLookUp(lkLoaiVatTu, "LoaiVPP");
            
           
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

        private void lkLoaiVatTu_TextChanged(object sender, EventArgs e)
        {
            string ma = lkLoaiVatTu.EditValue.ToString();
            Common.clsControl.GridView_SP(gridControl1, "sp_DM_VPP", "getDM_VPP", "@Loaivattu", ma); 
        }
    }
}
