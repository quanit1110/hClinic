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
using DevExpress.XtraGrid;

namespace KhamSucKhoe
{
    public partial class mncXacNhanNoiDungKhamSucKhoeUC : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable dt = new DataTable();
        public mncXacNhanNoiDungKhamSucKhoeUC()
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
            KhoiTaoGrTb(gridControl1, dt);
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

        private void lkCongTy_EditValueChanged(object sender, EventArgs e)
        {
            if (lkCongTy.EditValue != null)
            {        
                 EntityClass.cls_KSK_HopDong_BenhNhan bn = new EntityClass.cls_KSK_HopDong_BenhNhan();
                bn.GetListData_Benhnhan_hopdong(gridControl2, int.Parse(lkCongTy.EditValue.ToString()));

                EntityClass.cls_KSK_HopDong_DichVu hd = new EntityClass.cls_KSK_HopDong_DichVu();
                //hd.GetData_By_KeyHD(gridControl1,int.Parse(lkCongTy.EditValue.ToString()));    
                  
                hd.GetData_By_KeyHD(gridControl1, lkCongTy.EditValue.ToString());
         
                if (gridView1.RowCount > 0)
                {
                    GridColumn clo1 = gridView1.Columns["TenNhomDichVu"];
                    gridView1.BeginSort();
                    try
                    {
                        gridView1.ClearGrouping();
                        clo1.GroupIndex = 0;
                    }
                    finally
                    {
                        gridView1.EndSort();
                    }
                }
                gridView1.ExpandAllGroups();

            }
        }

        private void KhoiTaoGrTb(GridControl gr, DataTable dataTb)
        {
            //dataTb.Columns.Add("Check");
            dataTb.Columns.Add("DichVu_ID");
            dataTb.Columns.Add("TenDichVu");
            dataTb.Columns.Add("TenPhongBan");
            dataTb.Columns.Add("DonGia");
            dataTb.Columns.Add("DonGiaPhaiThu");
            dataTb.Columns.Add("TenNhomDichVu");
            gr.DataSource = dataTb;
            dataTb.Reset();
        }
        private void AddDataGrv(GridControl gr, DataTable dataTb, bool sl, int dichvu, String tendv, string tenPB, String dongia, String thanhtoan/*, String nhomdv*/)
        {

            DataRow dtr = dataTb.NewRow();
            //dtr["Check"] = sl;
            dtr["DichVu_ID"] = dichvu;
            dtr["TenDichVu"] = tendv;
            dtr["TenPhongBan"] = tenPB;
            dtr["DonGia"] = dongia;
            dtr["DonGiaPhaiThu"] = thanhtoan;
            dataTb.Rows.Add(dtr);
            gr.DataSource = dataTb;

        }
    }
}
