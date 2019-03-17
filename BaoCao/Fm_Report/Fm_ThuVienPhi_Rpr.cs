using BaoCao.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao.Fm_Report
{
    public partial class Fm_ThuVienPhi_Rpr : Form
    {
        public Fm_ThuVienPhi_Rpr()
        {
            InitializeComponent();
        }
        public Fm_ThuVienPhi_Rpr( int hoaDon_Id) :this()
        {
            this.HoaDon_Id = hoaDon_Id;       
        }

        private int HoaDon_Id;

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            BCVP_060_PhieuThu rpt = new BCVP_060_PhieuThu();
            DataTable dt = ThuVien.mySQL.ExcDT("Select * from [hsvClinic].[dbo].[View_HoaDon_VAT] where HoaDon_Id='"+HoaDon_Id+"'");
            rpt.SetDataSource(dt);
            this.crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
