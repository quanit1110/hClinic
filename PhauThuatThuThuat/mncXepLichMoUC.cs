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
using System.Data.SqlClient;

namespace PhauThuatThuThuat
{
    public partial class mncXepLichMoUC : DevExpress.XtraEditors.XtraUserControl
    {
        string BenhNhan_Id;
        public mncXepLichMoUC()
        {
            InitializeComponent();
            //l?y kích thu?c c?a màn hình
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hi?n th? theo kích thu?c c?a màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;

            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1386 là chi?u r?ng, 788 là chi?u cao Form khi thi?t k?, xem trong Properties c?a Form
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
        }
        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                //g?i d? quy n?u nhu 1 control nào có ch?a các control khác n?a

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                //canh l?i to? d? x, y, chi?u r?ng, cao cho các control trên form

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }

        private void BTSoPhieu_Click(object sender, EventArgs e)
        {
            //XtraForm xt = new ThuVien.TimKiem("sp_clsYeuCau", "getSoPhieu");
            //xt.ShowDialog();
            //txtSoPhieu.Text = ThuVien.loadform.lkId;
            //BenhNhan_Id = ThuVien.loadform.lkText;
            //Sukien();
        }

        private void Sukien()
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sp_DM_BenhNhan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "GetThongTinBenhNhan");
                cmd.Parameters.AddWithValue("@BenhAn_Id", BenhNhan_Id);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbMaYTe.Text = dr["MaYTe"].ToString();
                    lbHoTen.Text = dr["TenBenhNhan"].ToString();
                    lbNamSinh.Text = dr["NamSinh"].ToString();
                    lbGioiTinh.Text = dr["GioiTinh"].ToString();
                    lbDiaChi.Text = dr["DiaChi"].ToString();
                    lbDoiTuong.Text = dr["TenDoiTuong"].ToString();
                    lbQuocTich.Text = dr["name1"].ToString();
                    lbDanToc.Text = dr["name2"].ToString();
                    lbSoBaoHiem.Text = dr["SoThe"].ToString();
                    lbHieuLuc.Text = dr["NgayHieuLuc"].ToString();

                    int nam = int.Parse(DateTime.Now.Year.ToString());
                    int ns = int.Parse(lbNamSinh.Text);
                    lbTuoi.Text = (nam - ns).ToString();
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

        }

        private void mncXepLichMoUC_Load(object sender, EventArgs e)
        {
            dtDenNgay.Text = DateTime.Now.ToString();
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            DateTime dt = new DateTime(nam, thang, 1);
            dtTuNgay.Text = dt.ToString();
            ThuVien.mySQL.Load_Lookup_PR(lkBS1, "sp_NS_NhanVien", "GetAllDoctor", "NhanVien_Id", "HoTen");
            ThuVien.mySQL.Load_Lookup_PR(lkBS2, "sp_NS_NhanVien", "GetAllDoctor", "NhanVien_Id", "HoTen");
            ThuVien.mySQL.Load_Lookup_PR(lkBS3, "sp_NS_NhanVien", "GetAllDoctor", "NhanVien_Id", "HoTen");
            ThuVien.mySQL.Load_Lookup_PR(lkBS4, "sp_NS_NhanVien", "GetAllDoctor", "NhanVien_Id", "HoTen");
            ThuVien.mySQL.Load_Lookup_PR(lkPhongBan, "sp_DM_PhongBan", "getLKPhongBan", "PhongBan_Id", "TenPhongBan");
            ThuVien.mySQL.Load_Lookup_PR(lkPhuongPhapVoCam, "sp_Lst_Dictionary", "getlkPhuongPhapGayMe", "Dictionary_Id", "Dictionary_Name");            
        }
    }
}
