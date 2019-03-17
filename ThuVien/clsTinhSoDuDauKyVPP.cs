using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public static class clsTinhSoDuDauKyVPP
    {
        //Load sốdư đầu kì
        public static void SoDuDauKy(GridControl grv, string thang,string nam)
        {try
            {
                if (Int32.Parse(thang) > 1)
                {
                    string denngay = nam + "-" + Int32.Parse(thang).ToString(("D2")) + "-01 00:00:00.000";
                    string tungay = nam + "-" + (Int32.Parse(thang) - 1).ToString(("D2")) + "-01 00:00:00.000";
                    string sql = "SELECT TenKho,TenVPP,SoLoNhap_Id,SoLuong,TenDonViTinh,DonGiaMua FROM [hsvClinic].[dbo].[View_SoDuDauKy] where  NgayCapNhat>='"+tungay+"' and NgayCapNhat<'"+denngay+"'";
                    ThuVien.mySQL.LoadGirdControl(grv, sql);

                }
                else if (Int32.Parse(thang) == 1)
                {
                    string denngay = nam + "-" + Int32.Parse(thang).ToString(("D2")) + "-01 00:00:00.000";
                    string tungay = (Int32.Parse(nam) - 1).ToString() + "-12-01 00:00:00.000";
                    string sql = "SELECT TenKho,TenVPP,SoLoNhap_Id,SoLuong,TenDonViTinh,DonGiaMua FROM FROM [hsvClinic].[dbo].[View_SoDuDauKy] where NgayCapNhat>='" + tungay + "' and NgayCapNhat<'" + denngay + "'";
                    ThuVien.mySQL.LoadGirdControl(grv, sql);
                }
            }
            catch { }
        }
    }
}
