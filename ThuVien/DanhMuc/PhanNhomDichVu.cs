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
   public static class PhanNhomDichVu
    {

        /* Load Treeview */
        public static void loadTV(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select [LoaiDichVu_Id],[TenLoaiDichVu] from [mHIS_Hethong].[dbo].[view_DM_LoaiDichVu] where TamNgung=0");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["TenLoaiDichVu"].ToString();
                tnParent.Tag = Convert.ToInt32(dr["LoaiDichVu_Id"]);
                tv.Nodes.Add(tnParent);
                FillChild(tnParent, Convert.ToInt32(tnParent.Tag));
            }
        }
        public static void FillChild(TreeNode parent, int ParentId)
        {
            DataSet ds1 = mySQL.PDataset("Select [NhomDichVu_Id],[TenNhomDichVu] from [mHIS_Hethong].[dbo].[view_DM_NhomDichVu] where TamNgung=0 and LoaiDichVu_Id=" + ParentId);
            foreach (DataRow dr1 in ds1.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 1;
                child.Text = dr1["TenNhomDichVu"].ToString().Trim();
                child.Tag = dr1["NhomDichVu_Id"].ToString().Trim();
                parent.Nodes.Add(child);
                FillChildLever2(child, Convert.ToInt32(child.Tag));

            }
        }
        public static void FillChildLever2(TreeNode parent, int ParentId)
        {
            DataSet ds2 = mySQL.PDataset("Select [DichVu_Id],[TenDichVu] from [mHIS_Hethong].[dbo].[view_DM_DichVu] where Cap = 1 and TamNgung=0 and CoGiaDichVu = 1 and NhomDichVu_Id=" + ParentId);
            foreach (DataRow dr2 in ds2.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 2;
                child.Text = dr2["TenDichVu"].ToString().Trim();
                child.Tag = dr2["DichVu_Id"].ToString().Trim();
                parent.Nodes.Add(child);
                FillChildLever3(child, Convert.ToInt32(child.Tag));
            }
        }
        public static void FillChildLever3(TreeNode parent, int ParentId)
        {
            DataSet ds2 = mySQL.PDataset("Select [DichVu_Id],[TenDichVu] from [mHIS_Hethong].[dbo].[view_DM_DichVu] where TamNgung=0 and CapTren_Id=" + ParentId + "");
            foreach (DataRow dr2 in ds2.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 3;
                child.Text = dr2["TenDichVu"].ToString().Trim();
                child.Tag = dr2["DichVu_Id"].ToString().Trim();
                parent.Nodes.Add(child);
            }
        }

        /* End */
    }
}
