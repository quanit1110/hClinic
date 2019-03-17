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

namespace CanLamSang
{
    public partial class mncGiaiPhauBenhUC : DevExpress.XtraEditors.XtraUserControl
    {
        string BenhNhanID;
        public mncGiaiPhauBenhUC()
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
            LoadLookUp();
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

        private void btSoPhieu_Click(object sender, EventArgs e)
        {
            ThuVien.FcLoadLookup mayte = new ThuVien.FcLoadLookup("[hsvClinic].[dbo].[CLSYeuCau]", "CLSYeuCau_Id", "SoPhieuYeuCau", "BenhNhan_Id", "");
            mayte.ShowDialog();
            string ID = mayte.lkId;
            if (mayte.lkChange)
            {
                txtSoPhieu.Text = mayte.lkInt;
                EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
                DataRow dr = bn.Get_ThongTinBenhNhan_For_CanLamSang(mayte.lkText);
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
                txtLamSang.Text = cls.mvarChanDoan;
                lkBSChiDinh.EditValue = cls.mvarBacSiChiDinh_Id;
                lkDVThucHien.EditValue = cls.mvarNoiThucHien_Id;
            }
        }
        private void LoadLookUp()
        {
            Common.clsControl.LoadLK(lkNoiChiDinh, "NoiYeuCauCLS");
            Common.clsControl.LoadLK(lkBSChiDinh, "BacSi_CanLamSan");
            Common.clsControl.LoadLK(lkDVThucHien, "DonViThucHien");
            Common.clsControl.LoadLK(lkBSKetLuan, "BacSi_CanLamSan");
            Common.clsControl.LoadLK(lkKyThuatVien, "KyThuatVien");
            Common.clsControl.LoadLK(lkThietBi, "ThietBi");
            Common.clsControl.LoadLK(lkNhanXet, "NhanXet_CLS");
        }
    }
}
