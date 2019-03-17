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
using ThuVien;

namespace CanLamSang
{
    public partial class mncDienTimDienNaoDienCoHoHapKyUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncDienTimDienNaoDienCoHoHapKyUC()
        {
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            
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
            ThuVien.FcLoadLookup mayte = new ThuVien.FcLoadLookup("[hsvClinic].[dbo].[CLSYeuCau]", "CLSYeuCau_Id", "SoPhieuYeuCau", "BenhNhan_Id", "");
            mayte.ShowDialog();
            string ID = mayte.lkId;
            if (mayte.lkChange)
            {
                txtSoPhieu.Text = mayte.lkInt;
                EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();             
                DataRow dr= bn.Get_ThongTinBenhNhan_For_CanLamSang(mayte.lkText); 
                if (dr.Table.Rows[0]["BenhNhan_Id"].ToString().Length > 0)
                {
                    txtMaYTe.Text = dr.Table.Rows[0]["MaYTe"].ToString();
                    txtSoVaoVien.Text = dr.Table.Rows[0]["SoVaoVien"].ToString();
                    lbHoTen.Text = dr.Table.Rows[0]["TenBenhNhan"].ToString();
                    lbGioiTinh.Text = dr.Table.Rows[0]["GioiTinh"].ToString();
                    lbNamSinh.Text = dr.Table.Rows[0]["NamSinh"].ToString(); ;
                    lbDiaChi.Text = dr.Table.Rows[0]["DiaChi"].ToString();
                    lbDoiTuong.Text = dr.Table.Rows[0]["TenDoiTuong"].ToString();
                    lbTuoi.Text = dr.Table.Rows[0]["Tuoi"].ToString();
                }
            }
            GetSoPhieuCLS(txtSoPhieu.Text);
        }

        private void GetSoPhieuCLS(string ID)
        {
            EntityClass.cls_CLSYeuCau cls = new EntityClass.cls_CLSYeuCau();
            cls.GetData_BySoPhieuYeuCau(ID);
            if (cls.mvarCLSYeuCau_Id > 0)
            {
                dtNgayChiDinh.Text = cls.mvarNgayYeuCau.ToString("dd/M/yyyy");
                lkNoiChiDinh.EditValue = cls.mvarNoiYeuCau_Id;
                txtLanSang.Text = cls.mvarChanDoan;
                lkBSChiDinh.EditValue = cls.mvarBacSiChiDinh_Id;
                LkDVThucHien.EditValue = cls.mvarNoiThucHien_Id;
            }
        }

        private void mncDienTimDienNaoDienCoHoHapKyUC_Load(object sender, EventArgs e)
        {
            LoadLookUp();
        }

        private void LoadLookUp()
        {
            Common.clsControl.LoadLK(lkNoiChiDinh, "NoiChiDinh");
            Common.clsControl.LoadLK(lkBSChiDinh, "BacSi_CanLamSan");
            Common.clsControl.LoadLK(LkDVThucHien, "DonViThucHien");
            Common.clsControl.LoadLK(lkBacSiKetLuan, "BacSi_CanLamSan");
            Common.clsControl.LoadLK(lkKyThuatVien, "KyThuatVien");
            Common.clsControl.LoadLK(lkThietBi, "ThietBi");
            Common.clsControl.LoadLK(lkNhanXet, "NhanXet_CLS");
        }
    }
}
