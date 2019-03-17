using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;


namespace ThuVien.Danhmuc
{
    public static class CongTyBHTNGiaDichVuUC
    {
        public static void LoadCongTy(GridControl gv)
        {
            mySQL.LoadGirdControl(gv, "select Congty_Id,MaCongty,TenCongty from [mHIS_Hethong].[dbo].[view_CSKH_DM_CongTyBaoHiem]");
        }

        public static void GVDichVu(GridControl gv)
        {
            mySQL.LoadGirdControl(gv, "select DichVu_Id,InputCode,TenDichVu,TenNhomDichVu,TenLoaiDichVu from [mHIS_Hethong].[dbo].[view_Loai_Nhom_DichVu]");
        }
    }
}
