using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CrystalDecisions.CrystalReports.Engine;

namespace BaoCao
{
    public partial class ReportToaThuoc : DevExpress.XtraEditors.XtraForm
    {
        ReportDocument cry = new ReportDocument();
        public ReportToaThuoc()
        {
            InitializeComponent();
        }


        public ReportToaThuoc(string path, string Tensp, string ID, string GTri, string dt) :this()
        {
            this.Path = path;
            this.Tensp = Tensp;
            this.ID = ID;
            this.Gtri = GTri;
            this.dt = dt;
        }
        private string Path;
        private string Tensp;
        private string ID;
        private string Gtri;
        private string dt;
        private void ReportToaThuoc_Load(object sender, EventArgs e)
        {

            LoadBCDuyetToaThuoc();
        }

        private void LoadBCDuyetToaThuoc()
        {
            cry.Load(Path);
            SqlConnection con = ThuVien.mySQL.Conntext();
            SqlCommand cmd;
            DataSet ds = new DataSet();

            try
            {
                using (cmd = new SqlCommand(Tensp, con))
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(ID, Gtri);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, dt);
                cry.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cry;
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
        }


    }
}