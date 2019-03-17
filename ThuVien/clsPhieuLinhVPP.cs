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
    public static class clsPhieuLinhVPP
    {
        /* Load Lookup kho dược*/
        public static void KhoDuoc(LookUpEdit lk)
        {
            ThuVien.mySQL.Load_Lookup_2C(lk, "KhoDuoc_Id", "TenKho", "[mHIS_Hethong].[dbo].[view_KhoDuoc]", "where TamNgung='0'");
        }
        /* End */
        /* Load Lookup Nhan viên*/
        public static void NhanVien(LookUpEdit lk)
        {
            //string select = "select Dictionary_Id from[mHIS_Hethong].[dbo].[Lst_Dictionary] where Dictionary_Type_Code = 'LoaiPhongBan' and Dictionary_Code = 'KhamBenh'";
            ThuVien.mySQL.Load_Lookup_2C(lk, "NhanVien_Id", "HoTen", "[mHIS_Hethong].[dbo].[View_NhanVien]", "");
        }
        /* End */
        /* Load Lookup loaij chứng từ*/
        public static void LoaiChungTu(LookUpEdit lk)
        {
            //string select = "select Dictionary_Id from[mHIS_Hethong].[dbo].[Lst_Dictionary] where Dictionary_Type_Code = 'LoaiPhongBan' and Dictionary_Code = 'KhamBenh'";
            ThuVien.mySQL.Load_Lookup_2C(lk, "Dictionary_Code", "Dictionary_Name", "[mHIS_Hethong].[dbo].[view_Lst_Dictionary]", "where Dictionary_Type_Id = 186");
        }
        /* End */
        /* Load Lookup số lĩnh*/
        public static void SoPhieuLinh(LookUpEdit lk)
        {
            ThuVien.mySQL.Load_Lookup_2C(lk, "ChungTu_Id", "MaChungTu", "[hsvClinic].[dbo].[PhieuLinhVPP]", "where LoaiChungTu='N' and Duyet=1");
        }
        /* End */
        //Laays thoong tin phieu linh
        public static string[] ThongTinPhieuLinh(string sochungtu_id)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "Select Top 1 * from [hsvClinic].[dbo].[View_PhieuLinhVPP] where ChungTu_Id='" + sochungtu_id + "'";
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    List<string> _data = new List<string>();

                    _data.Add(dr["GiaTri"].ToString());
                    _data.Add(dr["GiaTriThanhToan"].ToString());
                    _data.Add(dr["NgayChungTu"].ToString());
                    _data.Add(dr["NguoiNhan_Id"].ToString());
                    _data.Add(dr["NguoiGiao_Id"].ToString());

                    _data.Add(dr["DienGiai"].ToString());
                    _data.Add(dr["KhoNhap_Id"].ToString());
                    _data.Add(dr["KhoXuat_Id"].ToString());
                    _data.Add(dr["LoaiChungTu"].ToString());
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
        //Load số xuất VPP
        public static void PhieuLinhVPP(GridControl grv, string sochungtu_id)
        {
            string sql = "SELECT MaVPP,TenVPP,TenDonViTinh,SoLuongYeuCau FROM [hsvClinic].[dbo].[View_PhieuLinhVPP] where ChungTu_Id='" + sochungtu_id + "'";
            ThuVien.mySQL.LoadGirdControl(grv, sql);
        }
    }
}
