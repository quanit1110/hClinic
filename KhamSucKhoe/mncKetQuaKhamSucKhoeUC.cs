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

namespace KhamSucKhoe
{
    public partial class mncKetQuaKhamSucKhoeUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncKetQuaKhamSucKhoeUC()
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
            Common.clsControl.LoadLK(lkXepLoai, "KSK_XepLoai");
            Common.clsControl.LoadLookUp(lkCongTy, "DSHopDongCongty");
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

        #region Hàm sự kiện -------------------------------
        private void lkCongTy_TextChanged(object sender, EventArgs e)
        {
            if (lkCongTy.EditValue != null)
            {
                EntityClass.cls_KSK_HopDong_BenhNhan bn = new EntityClass.cls_KSK_HopDong_BenhNhan();
                bn.GetListData_Benhnhan_hopdong(gridControl1, int.Parse(lkCongTy.EditValue.ToString()));           

            }
        }
       
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle >0)
            {
                string MaYTe = gridView1.GetDataRow(gridView1.FocusedRowHandle)["MaYTe"].ToString();
                EntityClass.cls_KSK_HopDong_BenhNhan hd = new EntityClass.cls_KSK_HopDong_BenhNhan();
                hd.GetBN_By_MaYTe(MaYTe);
                if (hd.mvarBenhNhan_Id > 0)
                {
                    txtMach.Text = hd.mvarMach.ToString();
                    txtNhipTho.Text = hd.mvarNhipTho.ToString();
                    txtChieuCao.Text = hd.mvarChieuCao.ToString();
                    txtCanNang.Text = hd.mvarCanNang.ToString();
                    txtNhietDo.Text = hd.mvarNhietDo.ToString();
                    txtBMI.Text = hd.mvarBMI.ToString();
                    txtHACao.Text = hd.mvarHuyetApCao.ToString();
                    txtHAThap.Text = hd.mvarHuyetApThap.ToString();
                    txtMatTraiKhongKinh.Text = hd.mvarMat_KhongKinh_Trai.ToString();
                    txtMatPhaiKhongKinh.Text = hd.mvarMat_KhongKinh_Phai.ToString();
                    txtMatTraiCoKinh.Text = hd.mvarMat_CoKinh_Trai.ToString();
                    txtMatPhaiCoKinh.Text = hd.mvarMat_CoKinh_Phai.ToString();
                    rtxtBenhVeMat.Text = hd.mvarMat_CacBenhVeMat;
                    txtTaiTraiNoiThuong.Text = hd.mvarTMH_TaiTrai_NoiThuong;
                    txtTaiTraiNoiThiTham.Text = hd.mvarTMH_TaiTrai_NoiTham;
                    txtTaiPhaiNoiThiTham.Text = hd.mvarTMH_TaiPhai_NoiTham;
                    txtTaiPhaiNoiThuong.Text = hd.mvarTMH_TaiPhai_NoiThuong;
                    txtRHMHamTren.Text = hd.mvarRHM_HamTren;
                    txtRHMHamDuoi.Text = hd.mvarRHM_HamDuoi;
                }
            }

            int ID = int.Parse(gridView1.GetDataRow(gridView1.FocusedRowHandle)["benhnhan_id"].ToString());
            EntityClass.cls_KSK_HopDong_BenhNhan_DichVu dv = new EntityClass.cls_KSK_HopDong_BenhNhan_DichVu();
            dv.GetListData_Benhnhan_hopdong_dichvu(gridControl2, ID);
        }

        private void LoadBenhNhan()
        {
            if (gridView1.FocusedRowHandle > 0)
            {
                EntityClass.cls_KSK_HopDong_BenhNhan hd = new EntityClass.cls_KSK_HopDong_BenhNhan();
                    hd.mvarMach = int.Parse(txtMach.Text);
                    //hd.mvarNhipTho = txtNhipTho.Text;
                    txtChieuCao.Text = hd.mvarChieuCao.ToString();
                    txtCanNang.Text = hd.mvarCanNang.ToString();
                    txtNhietDo.Text = hd.mvarNhietDo.ToString();
                    txtBMI.Text = hd.mvarBMI.ToString();
                    txtHACao.Text = hd.mvarHuyetApCao.ToString();
                    txtHAThap.Text = hd.mvarHuyetApThap.ToString();
                    txtMatTraiKhongKinh.Text = hd.mvarMat_KhongKinh_Trai.ToString();
                    txtMatPhaiKhongKinh.Text = hd.mvarMat_KhongKinh_Phai.ToString();
                    txtMatTraiCoKinh.Text = hd.mvarMat_CoKinh_Trai.ToString();
                    txtMatPhaiCoKinh.Text = hd.mvarMat_CoKinh_Phai.ToString();
                    rtxtBenhVeMat.Text = hd.mvarMat_CacBenhVeMat;
                    txtTaiTraiNoiThuong.Text = hd.mvarTMH_TaiTrai_NoiThuong;
                    txtTaiTraiNoiThiTham.Text = hd.mvarTMH_TaiTrai_NoiTham;
                    txtTaiPhaiNoiThiTham.Text = hd.mvarTMH_TaiPhai_NoiTham;
                    txtTaiPhaiNoiThuong.Text = hd.mvarTMH_TaiPhai_NoiThuong;
                    txtRHMHamTren.Text = hd.mvarRHM_HamTren;
                    txtRHMHamDuoi.Text = hd.mvarRHM_HamDuoi;
                }
            }
        #endregion

        #region Hàm chức năng --------------------------------
        public bool printCommand()
        {
            string Path = @"D:\hsv PhanMem\hClinic_3.2019\hClinic\BaoCao\Report\BCKSK_012_PhieuKetQua0808.rpt";
            BaoCao.ReportKSK_KetQua fm = new BaoCao.ReportKSK_KetQua(Path, "sp_BCKSK_012_PhieuKetQua", "@HopDong_Id", "16", "@BenhNhan_Id","276", "dtKQKSK");
            fm.ShowDialog();
            return true;
        }
        #endregion

    }
}
