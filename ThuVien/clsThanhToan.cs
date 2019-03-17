using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public static class clsThanhToan
    {
        /* Load Lookup Ma Y Te */
        public static void MaYTe(LookUpEdit cb)
        {
            mySQL.Load_Lookup_1C(cb, "SoVaoVien", "[hsvClinic].[dbo].[View_DM_BenhNhan]","");
        }
        /* End */
        /* Load Lookup hình thức thanh toán*/
        public static void HinhThucThanhToan(LookUpEdit lk)
        {
            ThuVien.mySQL.Load_Lookup_2C(lk, "Dictionary_Id", "Dictionary_Name", "[mHIS_Hethong].[dbo].[view_Lst_Dictionary]", "where Dictionary_Type_Id=74 and Enabled=1");
        }
        /* End */
        /* Load Lookup người thu tiền*/
        public static void NguoiThuTien(LookUpEdit lk)
        {
            ThuVien.mySQL.Load_Lookup_2C(lk, "NhanVien_Id", "HoTen", "[mHIS_Hethong].[dbo].[View_NhanVien]", "where PhongBan_Id=5028 and DangLamViec=1");
        }
        /* End */
        /* Lấy số hóa đơn lớn nhât theo số quyển*/
        public static string SoHoaDon(string soquyen)
        {
            String sohoadon = "";
            string sqlString = "Select Max([hsvClinic].[dbo].[HoaDon].So) from [hsvClinic].[dbo].[HoaDon] where SoQuyen='" + soquyen + "'";
            sohoadon = ThuVien.mySQL.getValues(sqlString);
            if (sohoadon.Trim().Length > 0)
            {
                return sohoadon;
            }
            return "0";
        }
        /* End */
        //Lấy thông tin sô hóa đơn
        public static string[] ThongTinHoaDon(string LoaiHoaDon)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "Select Top 1 * from [hsvClinic].[dbo].[DangKyHoaDon] where LoaiHoaDon='" + LoaiHoaDon + "' and TamNgung=0 order by DangKyHoaDon_Id Desc";
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
                    _data.Add(dr["SoSeries"].ToString());
                    _data.Add(dr["Max_No"].ToString());
                    _data.Add(dr["No_"].ToString());
                    _data.Add(dr["NgayPhatHanh"].ToString());
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
        //Tạo hóa đơn từ mã y tế
        public static void TaoHoaDon(GridControl gr, string sovaovien)
        {
            string dt = DateTime.Now.Date.ToString("yyyy-MM-dd") + " 00:00:00";
            ThuVien.mySQL.LoadGirdControl(gr, "select * from [hsvClinic].[dbo].[View_BenhNhan_CLSYeuCau] where  SoVaoVien='" + sovaovien + "' and DaThanhToan_HoanTat=0 and NgayTao>='"+dt+"'");
        }
        /* Load Lookup doi tuong */
        public static void DoiTuong(LookUpEdit cb)
        {
            mySQL.Load_Lookup_2C(cb, "DoiTuong_Id", "TenDoiTuong", "[mHIS_Hethong].[dbo].[view_DM_DoiTuong]", "where TamNgung =0");
        }
        /* End */
        //Laays thoong tin benh nhan
        public static string[] LoadThongTinBenhNhan(string sovaovien)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "Select Top 1 * from [hsvClinic].[dbo].[View_DangKyDichVu] where SoVaoVien='" + sovaovien + "' order by CLSYeuCau_Id Desc";
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    List<string> _data = new List<string>();

                    _data.Add(dr["BenhNhan_Id"].ToString());
                    _data.Add(dr["NgayHieuLuc"].ToString());
                    _data.Add(dr["NgayHetHieuLuc"].ToString());
                    _data.Add(dr["TenBenhNhan"].ToString());
                    _data.Add(dr["GioiTinh"].ToString());


                    _data.Add(dr["NamSinh"].ToString());
                    _data.Add(dr["DiaChi"].ToString());
                    _data.Add(dr["TenDoiTuong"].ToString());
                    _data.Add(dr["DoiTuong_Id"].ToString());
                    _data.Add(dr["TiepNhan_Id"].ToString());
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
    }
}
