using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace ThuVien
{
    public partial class FcLoadLookup : DevExpress.XtraEditors.XtraForm
    {
        private string table = "";
        private string colum1 = "";
        private string colum2 = "";
        private string colum3 = "";
        private string where = "";
        private string _MyString = "";
       
        public string lkText { get; set; } = "";
        public string lkId { get; set; } = "";
        public string lkInt { get; set; } = "";
        public bool lkChange { get; set; } = false;

        public FcLoadLookup()
        {
            InitializeComponent();
        }
        public FcLoadLookup(string table, string colum1, string colum2, string colum3, string where) : this()
        {
            this.table = table;
            this.colum1 = colum1;
            this.colum2 = colum2;
            this.colum3 = colum3;
            this.where = where;
        }


        private void FcLoadLookup_Load(object sender, EventArgs e)
        {
            string sql = "Select " + colum1 + "," + colum2 + "," + colum3 + " from " + table + " " + where + "";
            ThuVien.mySQL.LoadGirdControl(gridControl1, sql);
            for(int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsColumn.AllowFocus = false;
            }           
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridHitInfo info = gridView1.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                DataRow dtr = gridView1.GetDataRow(info.RowHandle);
                lkId = dtr[colum1].ToString();
                lkInt = dtr[colum2].ToString();
                lkText = dtr[colum3].ToString();
                lkChange = true;
                this.Close();
            }
        }
     
    }
}