using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuocPham
{
    public partial class FmTongHopYLenh : Form
    {
        private DateTime TuNgay;
        private DateTime DenNgay;
        public DataTable dtYLenh;
        public string rtvalue = "Xuất cho: ";
        public FmTongHopYLenh()
        {
            InitializeComponent();
        }
        public FmTongHopYLenh(DateTime tuNgay, DateTime denNgay) :this()
        {
            this.TuNgay = tuNgay;
            this.DenNgay = denNgay;

        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            EntityClass.cls_PhieuLinhDuoc pl = new EntityClass.cls_PhieuLinhDuoc();
            pl.GetDanhSachYLenh(gridControl1, TuNgay, DenNgay);
            GridColumn colReceived = gridView1.Columns["BenhNhan"];
            GridColumn colReceived1 = gridView1.Columns["Ngay"];
            gridView1.BeginSort();
            try
            {
                gridView1.ClearGrouping();
                colReceived.GroupIndex = 0;
                colReceived1.GroupIndex = 1;
            }
            catch { }
            try { gridView1.EndSort(); } catch { }
            gridView1.ExpandAllGroups();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            dtYLenh = (gridControl1.DataSource as DataTable).Clone();
            dtYLenh.Columns["SoLuongYeuCau"].ReadOnly = false;

            Dictionary<string, string> _dienGiai =
            new Dictionary<string, string>();
            Dictionary<string, int> _sumsoluong =
            new Dictionary<string, int>();
            int j =0;

            for (int i = gridView1.RowCount-1; i>=0 ; i--)
            {
                if (gridView1.IsRowSelected(i))
                {
                    try
                    {
                        _sumsoluong.Add(gridView1.GetDataRow(i)["MaDuoc"].ToString(),j);
                        dtYLenh.ImportRow(gridView1.GetDataRow(i));
                        j++;
                    }
                    catch
                    {
                        double vl1 = double.Parse(dtYLenh.Rows[_sumsoluong[gridView1.GetDataRow(i)["MaDuoc"].ToString()]]["SoLuongYeuCau"].ToString());
                        double vl2 = double.Parse(gridView1.GetDataRow(i)["SoLuongYeuCau"].ToString());
                        dtYLenh.Rows[_sumsoluong[gridView1.GetDataRow(i)["MaDuoc"].ToString()]]["SoLuongYeuCau"] = vl1 + vl2;
                    }
                    try
                    {
                        _dienGiai.Add(gridView1.GetDataRow(i)["BenhAn_Id"].ToString(), gridView1.GetDataRow(i)["BenhNhan"].ToString());
                    }
                    catch { }
                }
              
            }
            Dictionary<string, string>.ValueCollection valueColl =
            _dienGiai.Values;

            foreach (string s in valueColl)
            {
                rtvalue= rtvalue+s+"; ";
            }

            //var aggregatedAddresses = from DataRow row in dtYLenh.Rows
            //                          group row by row["MaDuoc"] into g
            //                          select new
            //                          {
            //                              MaDuoc = g.Key,

            //                              SoLuong = g.Sum(row => (int)row["SoLuong"])
            //                          };

            //int j = 1;
            //DataTable data = new DataTable();
            //foreach (var row in aggregatedAddresses)
            //{
            //    data.Rows.Add(j++, row.MaDuoc, row.SoLuong);
            //}
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {         
            this.Close();
        }
    }
}
