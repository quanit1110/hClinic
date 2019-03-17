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
    public partial class mncNhapKhoVPPUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncNhapKhoVPPUC()
        {
            InitializeComponent();
            //lấy kích thước của màn hình
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            Common.clsControl.LoadLookUp(lkDonViNhan, "getKhoNhanVPP");
            Common.clsControl.LoadLookUp(lkNCC, "VPP_KhachHang");
            Common.clsControl.LoadLookUp(lkNguoiNhan, "getnguoinhanVPP");
            Common.clsControl.LoadLookUp(lkTrangThai, "getTrangThaiDonHang");

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

        private void btSoPhieu_Click(object sender, EventArgs e)
        {
            ThuVien.FcLoadLookup nhapkho = new ThuVien.FcLoadLookup("VPP_ChungTu", "ChungTu_Id", "MaChungTu", "SoChungTu", "where LoaiChungTu = 'N' ");
            nhapkho.ShowDialog();
            string ID = nhapkho.lkInt;
            if (nhapkho.lkChange)
            {
                txtSoPhieu.Text = nhapkho.lkInt;
                EntityClass.clsVPP_ChungTu vpp = new EntityClass.clsVPP_ChungTu();
                vpp.getData_ByMaChungTu(txtSoPhieu.Text);
                if (vpp.mvarChungTu_Id > 0)
                {
                    txtSoChungTu.Text = vpp.mvarSoChungTu;
                    lkNCC.EditValue = vpp.mvarNhaCungCap_Id;
                    lkDonViNhan.EditValue = vpp.mvarKhoNhap_Id;
                    lkNguoiNhan.EditValue = vpp.mvarNguoiNhan_Id;
                    lkTrangThai.EditValue = vpp.mvarTrangThai;
                    txtHD1.Text = vpp.mvarSoHoaDon;
                    txtHD2.Text = vpp.mvarSoSeri;
                    txtNgayHD.Text = vpp.mvarNgayChungTuGoc.ToString();
                    txtNguoiGiao.Text = vpp.mvarNguoiGiao;
                    rtxtDienGiai.Text = vpp.mvarDienGiai;
                }
            }
        }
    }
 }

