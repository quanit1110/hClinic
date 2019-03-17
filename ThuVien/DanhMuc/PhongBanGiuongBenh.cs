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
    public static class PhongBanGiuongBenh
    {
        public static void TVPhongBan(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select PhongBan_Id,TenPhongBan from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where TamNgung=0 and Cap = 1 and LoaiPhongBan_Id = 568 ");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["TenPhongBan"].ToString();
                tnParent.Tag = Convert.ToInt32(dr["PhongBan_Id"]);
                tv.Nodes.Add(tnParent);
                FillChildPB(tnParent, Convert.ToInt32(tnParent.Tag));
            }
        }
        public static void FillChildPB(TreeNode parent, int ParentId)
        {
            DataSet ds1 = mySQL.PDataset("Select PhongBan_Id,TenPhongBan from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where TamNgung=0 and LoaiPhongBan_Id = 568 and CapTren_Id= " + ParentId + "");
            foreach (DataRow dr1 in ds1.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 2;
                child.Text = dr1["TenPhongBan"].ToString().Trim();
                child.Tag = dr1["PhongBan_Id"].ToString().Trim();
                parent.Nodes.Add(child);

            }
        }

        /* Load GirdControl GiuongBenh */
        public static void LoadNhanVien(GridControl gv)
        {
            ThuVien.mySQL.LoadGirdControl(gv, "select * from [mHIS_Hethong].[dbo].[view_PhongBan_GiuongBenh]");
        }
        /* End */
    }
}
