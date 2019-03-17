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
   public static class DMGiuongBenh
    {
        /* Load GirdControl DM_DoiTuong */
        public static void GiuongBenh(GridControl gv)
        {
            mySQL.LoadGirdControl(gv, "select * from [mHIS_Hethong].[dbo].[view_DM_GiuongBenh]");
        }
        /* End */

    }
}
