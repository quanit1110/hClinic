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

namespace TiepNhan
{
    public partial class FcQrCode : DevExpress.XtraEditors.XtraForm
    {
        public FcQrCode()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrQrCode rpt = new CrQrCode();    
            DataSet ds = new DataSet();
            ds = ThuVien.loadform.DataSet_Img;
            rpt.SetDataSource(ds.Tables["table1"]);
            this.crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}