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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Reflection;

namespace KhamSucKhoe
{
    public partial class mncDanhSachKhamSucKhoeUC : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable dt = new DataTable();
        public mncDanhSachKhamSucKhoeUC()
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
            loadLookUp();

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


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtHoTen.Text = gridView1.GetRowCellValue(e.RowHandle, "TenBenhNhan").ToString();
            txtSTT.Text = gridView1.GetRowCellValue(e.RowHandle, "STT").ToString();
            string MaYTe = gridView1.GetRowCellValue(e.RowHandle, "MaYTe").ToString();
            if(MaYTe.Length >0)
            {
                txtMaYTe.Text = MaYTe.Split('.')[1].ToString();
                txtMaBV.Text = MaYTe.Split('.')[0].ToString();
            }

            txtNgaySinh.Text = gridView1.GetRowCellValue(e.RowHandle, "NgaySinh").ToString();
            txtNamSinh.Text = gridView1.GetRowCellValue(e.RowHandle, "NamSinh").ToString();
            string gioitinh = gridView1.GetRowCellValue(e.RowHandle, "GioiTinh").ToString();
              if(gioitinh == "T")
            {
                rdNam.Checked = true;
                rdNu.Checked = false;
            }
              else
            {
                rdNam.Checked = false;
                rdNu.Checked = true;
            }
            lkNhomMau.EditValue = gridView1.GetRowCellValue(e.RowHandle, "NhomMau_Id").ToString();
            lkQuocTich.EditValue= int.Parse(gridView1.GetRowCellValue(e.RowHandle, "QuocTich_Id").ToString());
            lkDanToc.EditValue = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "DanToc_Id").ToString());
            lkTinhThanh.EditValue = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "TinhThanh_Id").ToString());
            lkQuanHuyen.EditValue = int.Parse(gridView1.GetRowCellValue(e.RowHandle, "QuanHuyen_Id").ToString());
            rtxtSoNha.Text = gridView1.GetRowCellValue(e.RowHandle, "DiaChi").ToString();
            txtCMND.Text = gridView1.GetRowCellValue(e.RowHandle, "CMND").ToString();
            txtTuoi.Text = (Int32.Parse(DateTime.Now.Year.ToString()) - Int32.Parse(txtNamSinh.Text)).ToString();
        }
        private void loadLookUp()
        {
            Common.clsControl.LoadLookup(lkTinhThanh, "TinhThanhPho", 2);
            Common.clsControl.LoadLookup(lkQuocTich, "Lib_DanhMucQuocTich", 2);
            Common.clsControl.LoadLookup(lkDanToc, "Lib_DanToc", 2);
            Common.clsControl.LoadLookup(lkNgheNgiep, "Lib_NgheNghiep", 2);
            Common.clsControl.LoadLookup(lkCongTy, "KSK_CongTy", 2);
            Common.clsControl.LoadLK(lkHonNhan, "TinhTrangHonNhan");
            Common.clsControl.LoadLookup(lkNhomMau, "NhomMau", 2);

        }


        private void lkTinhThanh_EditValueChanged(object sender, EventArgs e)
        {
            Common.clsControl.LoadLookup(lkQuanHuyen, "DonViHanhChinh_MaCapTren", 2, lkTinhThanh.EditValue.ToString());
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {            
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "(Tất cả các tiệp) |*.*|(Các tiệp excel) | *.xlsx";
            open.ShowDialog();
            if (open.FileName != "")
            {
                string Path = open.FileName;
                TestExcel(Path);
                //Excel.Application app = new Excel.Application();
                //Excel.Workbook wb = app.Workbooks.Open(Path);

                //    // mo sheet
                //    Excel.Worksheet sheet = wb.Sheets[1];
                //    Excel.Range range = sheet.UsedRange;
                //    //doc du lieu
                //    int rows = range.Rows.Count;
                //    int col = range.Columns.Count;
                //      DataTable dt = new DataTable();
                //    for (int i = 1; i <= col; i++)
                //    {
                //        object[,] values = (object[,])range.Value;
                //        dt.Columns.Add(values[1, i].ToString());
                //    }

                //gridControl1.DataSource = dt;
             }
        
         }
        private void TestExcel(string path)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook book = null;
            Excel.Range range = null;

            try
            {
                app.Visible = false;
                app.ScreenUpdating = false;
                app.DisplayAlerts = false;

                string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

                book = app.Workbooks.Open(path, Missing.Value, Missing.Value, Missing.Value
                                                  , Missing.Value, Missing.Value, Missing.Value, Missing.Value
                                                 , Missing.Value, Missing.Value, Missing.Value, Missing.Value
                                                , Missing.Value, Missing.Value, Missing.Value);
                foreach (Excel.Worksheet sheet in book.Worksheets)
                {

                    //Console.WriteLine(@"Values for Sheet " + sheet.Index);

                    // get a range to work with
                    range = sheet.get_Range("A1", Missing.Value);
                    // get the end of values to the right (will stop at the first empty cell)
                    range = range.get_End(Excel.XlDirection.xlToRight);
                    // get the end of values toward the bottom, looking in the last column (will stop at first empty cell)
                    range = range.get_End(Excel.XlDirection.xlDown);

                    // get the address of the bottom, right cell
                    string downAddress = range.get_Address(
                        false, false, Excel.XlReferenceStyle.xlA1,
                        Type.Missing, Type.Missing);

                    // Get the range, then values from a1
                    range = sheet.get_Range("A1", downAddress);
                    object[,] values = (object[,])range.Value2;
                    DataTable dt = new DataTable();
                    //add colum cho datatable;
                    for (int j = 1; j <= values.GetLength(1); j++)
                    {
                        //Console.Write("{0}\t", values[1, j]);
                        // dt.Rows.Add()
                       dt.Columns.Add(values[1, j].ToString());
                    }
                    
                    // View the values
                    for (int i = 2; i <= values.GetLength(0); i++)
                    {
                        DataRow dtr = dt.NewRow();
                        for (int j = 1; j <= values.GetLength(1); j++)
                        {
                            //Console.Write("{0}\t", values[i, j]);
                            // dt.Rows.Add()
                            dtr[j-1] = values[i, j];
                        }
                        dt.Rows.Add(dtr);
                        Console.WriteLine();
                    }
                    gridControl1.DataSource = dt;
                    for (int i = 0; i < gridView1.Columns.Count; i++)
                    {
                        gridView1.Columns[i].OptionsColumn.AllowFocus = false;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                range = null;
                if (book != null)
                    book.Close(false, Missing.Value, Missing.Value);
                book = null;
                if (app != null)
                    app.Quit();
                app = null;
            }
        }


    }
 }

