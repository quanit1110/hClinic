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
using System;
using ThuVien;

namespace VienPhi
{
    public partial class mncCapNhatSoHoaDonUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai báo biến
        int status = 0;
        #endregion
        /*-----------------------------------------------*/
        #region Khởi tạo form
        public mncCapNhatSoHoaDonUC()
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


            DanhSach(lkDanhSach);
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
        #endregion
        /*-----------------------------------------------*/
        #region Hàm chức năng
        public bool editCommand()
        {
            status = 3;
            return true;
        }

        public bool deleteCommand()
        {
            status = 2;
            return true;
        }
        public bool addCommand()
        {
            status = 1;
            return true;
        }
        public bool saveCommand()
        {
            if (lkDanhSach.EditValue != null)
            {
                if (txtSoQuyenMoi.Text.Length > 0 && txtSoMoi.Text.Length > 0)
                {
                    CapNhatHoaDon(lkDanhSach.EditValue.ToString());
                    DangKyHoaDon();
                }
                status = 0;
                ThuVien.loadform.XoaForm(this);
            }
            return true;
        }
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí nghiệp vụ
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí sự kiện
        private void lkDanhSach_EditValueChanged(object sender, EventArgs e)
        {
            if (lkDanhSach.EditValue != null)
            {
                string where = lkDanhSach.Text;
                string[] tthd = ThongTinHoaDon(where);
                if (tthd.Length > 0)
                {
                    txtKiHieuCu.Text = tthd[0];
                    txtKyHieuMoi.Text = tthd[0];
                    txtSoCu.Text = tthd[1];
                    txtSoQuyenCu.Text = where;
                    switch (tthd[0])
                    {
                        case "HD":
                            txtLoaiHoaDon.Text = "Hóa đơn";
                            break;
                        case "TD":
                            txtLoaiHoaDon.Text = "Tạm ứng";
                            break;
                        case "HU":
                            txtLoaiHoaDon.Text = "Hoàn ứng";
                            break;
                        case "TG":
                            txtLoaiHoaDon.Text = "Tiền gói";
                            break;
                    }
                }
            }
        }
        #endregion
        /*-----------------------------------------------*/
        #region Các hàm con
        private void CapNhatHoaDon(string dangkyhoadon_id)
        {
            SqlConnection con = ThuVien.mySQL.Conn();

            string select = @"UPDATE [hsvClinic].[dbo].[DangKyHoaDon] SET
                   TamNgung=@TamNgung
                    WHERE DangKyHoaDon_Id=@DangKyHoaDon_Id";
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);

                cmd.Parameters.AddWithValue("@TamNgung", 1);
                cmd.Parameters.AddWithValue("@DangKyHoaDon_Id", Int32.Parse(dangkyhoadon_id));

                cmd.ExecuteNonQuery();
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
        private void DangKyHoaDon()
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = @"INSERT INTO [hsvClinic].[dbo].[DangKyHoaDon]
                  (MachineName,LoaiHoaDon,NgayPhatHanh,SoSeries,Max_No,No_,HieuLuc,
                    NguoiTao_Id,NgayTao)

                    VALUES 
                 (@MachineName,@LoaiHoaDon,@NgayPhatHanh,@SoSeries,@Max_No,@No_,@HieuLuc,
                   @NguoiTao_Id,@NgayTao)";

            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);

                ThuVien.mySQL.AddWithNullableValue(cmd.Parameters, "@MachineName", "MC001");
                ThuVien.mySQL.AddWithNullableValue(cmd.Parameters, "@LoaiHoaDon", txtLoaiHoaDon.Text);
                ThuVien.mySQL.AddWithNullableValue(cmd.Parameters, "@NgayPhatHanh", DateTime.Now);
                ThuVien.mySQL.AddWithNullableValue(cmd.Parameters, "@SoSeries", txtSoQuyenMoi.Text);
                ThuVien.mySQL.AddWithNullableValue(cmd.Parameters, "@Max_No", 999999);
                ThuVien.mySQL.AddWithNullableValue(cmd.Parameters, "@No_", Int32.Parse(txtSoMoi.Text));

                ThuVien.mySQL.AddWithNullableValue(cmd.Parameters, "@HieuLuc", 1);
                ThuVien.mySQL.AddWithNullableValue(cmd.Parameters, "@NguoiTao_Id", ThuVien.loadform.userID);
                ThuVien.mySQL.AddWithNullableValue(cmd.Parameters, "@NgayTao", DateTime.Now);

                cmd.ExecuteNonQuery();
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
        /////////
        /* Load Lookup Danh sách */
        private void DanhSach(LookUpEdit cb)
        {
            mySQL.Load_Lookup_2C(cb, "DangKyHoaDon_Id", "SoSeries", "[hsvClinic].[dbo].[DangKyHoaDon]", "where TamNgung=0");
        }
        /* End */
        //Laays thoong tin hóa đơn
        private string[] ThongTinHoaDon(string soquyen)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "Select Top 1 * from [hsvClinic].[dbo].[HoaDon] where SoQuyen='" + soquyen + "' order by So Desc";
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    List<string> _data = new List<string>();

                    _data.Add(dr["LoaiHoaDon"].ToString());
                    _data.Add(dr["So"].ToString());
                    _data.Add(dr["SoHoaDon"].ToString());

                    return _data.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return new string[0];
            }
            return new string[0];
        }
        #endregion
    }
}
