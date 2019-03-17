using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System.Data;

namespace ThuVien.Danhmuc
{
    public static class DanhMucNoiDungNhomBenh
    {
        public static void GVDichVu(GridControl gv)
        {
            ThuVien.mySQL.LoadGirdControl(gv, "select DichVu_Id,InputCode,TenDichVu,TenNhomDichVu,TenLoaiDichVu from [mHIS_Hethong].[dbo].[view_Loai_Nhom_DichVu]");
        }

        /* Load Treeview DM_NhomBenh */
        public static void TreeVNhomBenh(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select NhomBenh_Id,TenNhomBenh from [mHIS_Hethong].[dbo].[view_DM_NhomBenh]");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["TenNhomBenh"].ToString();
                tnParent.Tag = dr["NhomBenh_Id"].ToString();
                tv.Nodes.Add(tnParent);
            }
        }
        /* End */

    }
}
