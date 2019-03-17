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
    public static class DMDuocBacSi
    {
        public static void LoadGVDuoc(GridControl gv)
        {
            ThuVien.mySQL.LoadGirdControl(gv, "select Duoc_Id,MaDuoc,TenDuocDayDu,DonViTinh,TenLoaiDuoc from [mHIS_Hethong].[dbo].[view_Duoc_LoaiDuoc]");
        }
    }
}
