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
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using System.Drawing.Drawing2D;

namespace BaoCao
{
    public partial class mncThongKeToaThuocUC : DevExpress.XtraEditors.XtraUserControl
    {

        #region Khai báo biến
        private int status = 0;
        int daPhat;
        int tongToa;
        #endregion
        /*-----------------------------------------------*/
        #region Khởi tạo form
        public mncThongKeToaThuocUC()
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
        private void mncThongKeToaThuoc_Load(object sender, EventArgs e)
        {
            ThuVien.loadform.disableControl(this);
            Common.clsControl.LoadLookup(lkPhongBan, "PhongBan", 2, "", "", "Tên phòng ban", "Id");
            Common.clsControl.LoadLookup(lkBacSi, "BacSi_PhongKham", 2, "", "", "Bác sĩ", "Id");

        }

        #endregion
        /*-----------------------------------------------*/
        #region Hàm chức năng

        public bool editCommand()
        {
            status = 3;
            return true;
        }
        public bool saveCommand()
        {
            status = 0;
            return true;
        }
        public bool deleteCommand()
        {
            status = 2;
            return true;
        }
        public bool addCommand()
        {
            status = 1;
            return true;
        }
        #endregion
        public void GetList_By_PhongBan(GridControl grv, DateTime tuNgay,DateTime denNgay,int phongBan_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuNgay", tuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DenNgay", denNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", phongBan_Id);

            Common.clsControl.LoadGirdControl_Y(grv, "sp_ThongKeToaThuoc", listPara);
        }
        public void GetList_By_BacSi(GridControl grv, DateTime tuNgay, DateTime denNgay, int bacSi_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuNgay", tuNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DenNgay", denNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSi_Id", bacSi_Id);

            Common.clsControl.LoadGirdControl_Y(grv, "sp_ThongKeToaThuoc", listPara);
        }


        private void gridView_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            
            GridView view = sender as GridView;
         
            int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                daPhat = 0;
                tongToa = 0;
            }      
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                switch (summaryID)
                {
                    case 1:  
                       tongToa ++;
                        break;
                    case 2: 
                        Boolean isDiscontinued = Convert.ToBoolean(e.FieldValue);
                        if (isDiscontinued) daPhat++;
                        break;
                }
            }
          
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (summaryID)
                {
                    case 1:
                        e.TotalValue = tongToa;
                        break;
                    case 2:
                        e.TotalValue = daPhat;
                        break;
                }
            }
        }


        private void lkPhongBan_EditValueChanged(object sender, EventArgs e)
        {
            if (lkPhongBan.EditValue != null)
            {
                try
                {
                    GetList_By_PhongBan(gridControl1, dtTuNgay.DateTime, dtDenNgay.DateTime, int.Parse(lkPhongBan.EditValue.ToString()));
                    GridColumn colReceived = gridView1.Columns["BacSiRaToa"];
                    gridView1.BeginSort();
                    try
                    {
                        gridView1.ClearGrouping();
                        colReceived.GroupIndex = 0;
                    }
                    finally
                    {
                        gridView1.EndSort();
                    }
                    //gridView1.ExpandAllGroups();
                }
                catch { }
               
            }
        }

        private void lkBacSi_EditValueChanged(object sender, EventArgs e)
        {
            if (lkBacSi.EditValue != null)
            {
                try
                {
                    GetList_By_BacSi(gridControl1, dtTuNgay.DateTime, dtDenNgay.DateTime, int.Parse(lkBacSi.EditValue.ToString()));
                    GridColumn colReceived = gridView1.Columns["BacSiRaToa"];
                    gridView1.BeginSort();
                    try
                    {
                        gridView1.ClearGrouping();
                        colReceived.GroupIndex = 0;
                    }
                    finally
                    {
                        gridView1.EndSort();
                    }
                    //gridView1.ExpandAllGroups();
                }
                catch { }
            }
        }

       
    }
}
