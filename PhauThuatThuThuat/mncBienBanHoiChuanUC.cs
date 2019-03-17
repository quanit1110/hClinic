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
    public partial class mncBienBanHoiChuanUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncBienBanHoiChuanUC()
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

        private void mncBienBanHoiChuanUC_Load(object sender, EventArgs e)
        {
            //chua sua lai loadlookup new
            dtNgayHoiChuan.Text = DateTime.Now.ToString();
            dtNgayMo.Text = DateTime.Now.ToString();
            ThuVien.mySQL.Load_Lookup_PR(lkHinhThuc, "sp_Lst_Dictionary", "getlkHinhThucHoiChuan", "Dictionary_Id", "Dictionary_Name");
            ThuVien.mySQL.Load_Lookup_PR(lkLyDo, "sp_Lst_Dictionary", "getlkLyDoHoiChuan", "Dictionary_Id", "Dictionary_Name");
            ThuVien.mySQL.Load_Lookup_PR(lkBacSiDeXuat, "sp_NS_NhanVien", "GetAllDoctor", "NhanVien_Id", "HoTen");
            ThuVien.mySQL.Load_Lookup_PR(lkHopTai, "sp_DM_PhongBan", "getLKPhongBan", "PhongBan_Id","TenPhongBan");
            ThuVien.mySQL.Load_Lookup_PR(lkPhuongPhapVoCam, "sp_Lst_Dictionary", "getlkPhuongPhapGayMe", "Dictionary_Id", "Dictionary_Name");
            ThuVien.mySQL.Load_Lookup_PR(lkPhongMo, "sp_DM_PhongBan", "getLKPhongBan", "PhongBan_Id", "TenPhongBan");
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
                cmd.Parameters.AddWithValue("@BenhAn_Id", txtBenhAn.Text);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    lbMaYTe.Text = dr["MaYTe"].ToString();
                    lbHoTen.Text = dr["TenBenhNhan"].ToString();
                    lbNamSinh.Text = dr["NamSinh"].ToString();
                    lbGioiTinh.Text = dr["GioiTinh"].ToString();
                    lbDiaChi.Text = dr["DiaChi"].ToString();
                    lbNhomMau.Text = dr["NhomMau_Id"].ToString();
                    lbYeuToRh.Text = dr["YeuToRh_Id"].ToString();
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

        private void BenhAn()
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("sp_DM_PhongBan", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "getKhoaDieuTri");
                cmd.Parameters.AddWithValue("@BenhAn_ID", txtBenhAn.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtKhoaDieuTri.Text = dr["TenPhongBan"].ToString();

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
    }
}
