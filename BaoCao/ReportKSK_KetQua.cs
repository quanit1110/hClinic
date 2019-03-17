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
    public partial class ReportKSK_KetQua : DevExpress.XtraEditors.XtraForm
    {
        ReportDocument cry = new ReportDocument();
        public ReportKSK_KetQua()
        {
            InitializeComponent();
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
        public ReportKSK_KetQua(string path, string Tensp, string ID, string GTri, string ID1, string GTri1, string dt) :this()
        {
            this.Path = path;
            this.Tensp = Tensp;
            this.ID = ID;
            this.Gtri = GTri;
            this.dt = dt;
            this.ID1 = ID1;
            this.GT1 = GTri1;
        }
        private string Path;
        private string Tensp;
        private string ID;
        private string Gtri;
        private string dt;
        private string ID1;
        private string GT1;

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
                cmd.Parameters.AddWithValue(ID1, GT1);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                SqlCommand cmd1 = new SqlCommand("sp_BCKSK_012_PhieuKetQua_CLS", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue(ID, Gtri);
                cmd1.Parameters.AddWithValue(ID1, GT1);
                cmd1.ExecuteNonQuery();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(ds, "dtKSKCLS");

                SqlCommand cmd2 = new SqlCommand("sp_BCKSK_012_PhieuKetQua_KhamBenh", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue(ID, Gtri);
                cmd2.Parameters.AddWithValue(ID1, GT1);
                cmd2.ExecuteNonQuery();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(ds, "KhamBenh");




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

        private void ReportKSK_KetQua_Load(object sender, EventArgs e)
        {
            LoadBCDuyetToaThuoc();
        }
    }
}