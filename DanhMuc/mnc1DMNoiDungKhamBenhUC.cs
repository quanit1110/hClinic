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
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data;

namespace DanhMuc
{
    public partial class mnc1DMNoiDungKhamBenhUC : DevExpress.XtraEditors.XtraUserControl
    {
        string ma;
        Dictionary<int, Boolean> unboundData;
        public mnc1DMNoiDungKhamBenhUC()
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
            tvNhomBenh.ImageList = imageList1;
            ThuVien.Danhmuc.DanhMucNoiDungNhomBenh.TreeVNhomBenh(tvNhomBenh);
            //ThuVien.loadform.disableControl(this);

            loadGV();
            GridColumn unboundColumn = gridView1.Columns["Chon"];
            unboundColumn.UnboundType = UnboundColumnType.Boolean;
            unboundColumn.Visible = true;
            // Handling the CustomUnboundColumnData event 
            unboundData = new Dictionary<int, Boolean>();
            gridView1.CustomUnboundColumnData += GridView1_CustomUnboundColumnData;
            
        }
      
        private void GridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //throw new NotImplementedException();
           
                if (e.Column.FieldName == "Chon")
                {
                    // Populate columns 
                    if (e.IsGetData)
                    {
                        if (unboundData.ContainsKey(e.ListSourceRowIndex))
                            e.Value = unboundData[e.ListSourceRowIndex];
                    }
                    // Post edits back to the source 
                    if (e.IsSetData && e.Value != null)
                    {
                        unboundData[e.ListSourceRowIndex] = (Boolean)e.Value;
                    }
                }           
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

        private void tvNhomBenh_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int[] rows = gridView1.GetSelectedRows();
            ma = e.Node.Tag.ToString();
            DataTable dttb = new DataTable();
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "select DichVu_Id from [mHIS_Hethong].[dbo].[view_DM_NhomBenh_DichVu] where NhomBenh_id = " + ma + "";
            SqlCommand cmd = new SqlCommand(select, con);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dttb.Load(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
            for (int i = 0; i <= gridView1.DataRowCount - 1; i++)
            {
                string madv = gridView1.GetDataRow(i)["DichVu_Id"].ToString();
                foreach (DataRow row in dttb.Rows)
                {
                    string text = row["DichVu_Id"].ToString();
                        if(madv == text)
                    {
                        unboundData[0] = true;
                    }
                        else
                    {
                        string abcd = unboundData[1].ToString();
                    }
                }               
            }
            loadGV();
            //gridView1.RefreshData();
        }

        private void loadGV()
        {
            ThuVien.Danhmuc.DanhMucNoiDungNhomBenh.GVDichVu(gridControl1);
            GridColumn colReceived = gridView1.Columns["TenLoaiDichVu"];
            GridColumn colRead = gridView1.Columns["TenNhomDichVu"];
            gridView1.BeginSort();
            try
            {
                gridView1.ClearGrouping();
                colReceived.GroupIndex = 0;
                colRead.GroupIndex = 1;
            }
            finally
            {
                gridView1.EndSort();
            }
        }

    }
}
