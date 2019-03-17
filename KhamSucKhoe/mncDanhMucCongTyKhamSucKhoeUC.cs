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
using DevExpress.XtraGrid.Views.Grid;

namespace KhamSucKhoe
{
    public partial class mncDanhMucCongTyKhamSucKhoeUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncDanhMucCongTyKhamSucKhoeUC()
        {
            InitializeComponent();
            //lấy kích thước của màn hình
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
            getListCongTy();
            ThuVien.loadform.disableControl(this);
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
        private void getListCongTy()
        {
            EntityClass.cls_KSK_CongTy cty = new EntityClass.cls_KSK_CongTy();
            cty.Get_By_CongTy(gridControl1);
        }

        public bool addCommand()
        {
            ThuVien.loadform.enableControl(this);
            //gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            //gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            gridView1.NewItemRowText = "Click để thêm...";
            return true;
         
        }
        public bool saveCommand()
        {
            loadThongtin();
            getListCongTy();           
            return true;
        }
        public bool deleteCommand()
        {
            EntityClass.cls_KSK_CongTy cty = new EntityClass.cls_KSK_CongTy();
            cty.mvarCongty_Id = int.Parse(gridView1.GetDataRow(gridView1.FocusedRowHandle)["Congty_Id"].ToString());
            cty.Delete();
            getListCongTy();
            return true;
        }


        private void loadThongtin()
        {
            EntityClass.cls_KSK_CongTy cty = new EntityClass.cls_KSK_CongTy();
            int[] selectedRows = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRows.Length; i++)
            {
                cty.mvarMaCongty  = gridView1.GetRowCellValue(selectedRows[i], "MaCongty").ToString();
                cty.mvarTenCongty = gridView1.GetRowCellValue(selectedRows[i], "TenCongty").ToString();
                cty.mvarDiaChi = gridView1.GetRowCellValue(selectedRows[i], "DiaChi").ToString(); 
                cty.mvarDienThoai = gridView1.GetRowCellValue(selectedRows[i], "DienThoai").ToString();
                cty.mvarFax = gridView1.GetRowCellValue(selectedRows[i], "Fax").ToString();
                cty.mvarMaSoThue = gridView1.GetRowCellValue(selectedRows[i], "MaSoThue").ToString();
                cty.mvarGiamDoc =gridView1.GetRowCellValue(selectedRows[i], "GiamDoc").ToString();
                cty.mvarNguoiLienHe = gridView1.GetRowCellValue(selectedRows[i], "NguoiLienHe").ToString();
                cty.mvarNuocNgoai = gridView1.GetRowCellValue(selectedRows[i], "NuocNgoai").ToString()== "True" ? true:false;
                cty.mvarNhaNuoc = gridView1.GetRowCellValue(selectedRows[i], "NhaNuoc").ToString() == "True" ? true : false;
                cty.mvarTamNgung = gridView1.GetRowCellValue(selectedRows[i], "TamNgung").ToString() == "True" ? true : false;
            }
            cty.Add();
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            if (e.RowHandle == -2147483647)
            {
                gridView1.SetRowCellValue(-2147483647, gridView1.Columns["NuocNgoai"],1);
                gridView1.SetRowCellValue(-2147483647, gridView1.Columns["NhaNuoc"], 0);
                gridView1.SetRowCellValue(-2147483647, gridView1.Columns["TamNgung"], 0);
            }
        }
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            EntityClass.cls_KSK_CongTy cty = new EntityClass.cls_KSK_CongTy();
            cty.Delete();
            try
            { 
                cty.mvarCongty_Id = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "Congty_Id").ToString());
            }
            catch { }
        }
    }
}
