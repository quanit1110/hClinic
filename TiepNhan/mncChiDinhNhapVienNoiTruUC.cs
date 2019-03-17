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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace TiepNhan
{
    public partial class mncChiDinhNhapVienNoiTruUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncChiDinhNhapVienNoiTruUC()
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

        private void mncChiDinhNhapVienNoiTruUC_Load(object sender, EventArgs e)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DataGroup", "DanhSachPhongBan_Kham");
            Common.clsControl.LoadGirdControl_Y(gridControl1, "sp_Sys_ListOfValues", listPara);
            for(int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsColumn.AllowFocus = false;
            }

            //ThuVien.mySQL.LoadGirdControl(gridControl1, "select PhongBan_Id,TenPhongBan from hsvClinic.dbo.DM_PhongBan");
            //DataTable dt = new DataTable();
            //KhoiTaoGrTb(gridControl2, dt);
        }
        //public void KhoiTaoGrTb(GridControl gr, DataTable dataTb)
        //{
        //    dataTb.Columns.Add("KhoaDieuTri");
        //    dataTb.Columns.Add("SoTiepNhan");
        //    dataTb.Columns.Add("MaYTe");
        //    dataTb.Columns.Add("BenhNhan");
        //    dataTb.Columns.Add("ThoiGianTiepNhan");
        //    dataTb.Columns.Add("KhoaChiDinh");
        //    dataTb.Columns.Add("ThoiGianNhap");
        //    dataTb.Columns.Add("ChanDoan");
        //    dataTb.Columns.Add("DoiTuong");

        //    DataRow dtr = dataTb.NewRow();
        //    dtr["KhoaDieuTri"] ="KHOA CẤP CỨU - B24";
        //    dtr["SoTiepNhan"] = "2226";
        //    dtr["MaYTe"] = "703302.12003255";
        //    dtr["BenhNhan"] = "Cơ Liêng Bang";
        //    dtr["ThoiGianTiepNhan"] = "2019-02-21 09:15:23.000";
        //    dtr["KhoaChiDinh"] = "Phòng khám 04 - Tầng 01";
        //    dtr["ThoiGianNhap"] = "2019-02-21 09:25:23.000";
        //    dtr["ChanDoan"] = "Nhịp tim nhanh, Không xác định";
        //    dtr["DoiTuong"] = "BHYT 4 (80%)";

        //    dataTb.Rows.Add(dtr);


        //    //dataTb.Columns.Add("Huy");
        //    gr.DataSource = dataTb;
        //    GridColumn colReceived = gridView2.Columns["KhoaDieuTri"];
        //    gridView2.BeginSort();
        //    try
        //    {
        //        gridView2.ClearGrouping();
        //        colReceived.GroupIndex = 0;
        //    }
        //    finally
        //    {
        //        gridView2.EndSort();
        //    }
        //}

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle < 0)
            { }
            else
            {
                GridView gView = (GridView)sender;
                DataRow _data = gView.GetDataRow(e.RowHandle);
                try
                {
                    string phongBan_Id = _data["FieldCode"].ToString();
                    List<SqlParameter> listPara = new List<SqlParameter>();

                    ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DataGroup", "DanhSachNhapVien_ByKhoaDieuTri");
                    ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@AdditionPara", phongBan_Id);
                    Common.clsControl.LoadGirdControl_Y(gridControl2, "sp_Sys_ListOfValues", listPara);
                    for (int i = 0; i < gridView2.Columns.Count; i++)
                    {
                        gridView2.Columns[i].OptionsColumn.AllowFocus = false;
                    }
                }
                catch { }
            }
        }

        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
            GridView gView = (GridView)sender;
            DataRow _data = gView.GetDataRow(e.RowHandle);        
            TiepNhan.FmTiepNhanCapCuu fm = new FmTiepNhanCapCuu(_data["SoTiepNhan"].ToString(), 0);
            fm.ShowDialog(); 
            try
            {
                string phongBan_Id = gridView1.GetDataRow(gridView1.FocusedRowHandle)["FieldCode"].ToString();
                List<SqlParameter> listPara = new List<SqlParameter>();

                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DataGroup", "DanhSachNhapVien_ByKhoaDieuTri");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@AdditionPara", phongBan_Id);
                Common.clsControl.LoadGirdControl_Y(gridControl2, "sp_Sys_ListOfValues", listPara);
                for (int i = 0; i < gridView2.Columns.Count; i++)
                {
                    gridView2.Columns[i].OptionsColumn.AllowFocus = false;
                }
            }
            catch { }
        }
    }
}
