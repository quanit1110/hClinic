﻿using System;
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
    public static class PhongBanThucHienNhiemVu
    {
        /* Load Treeview PhongBan */

        public static void TVPhongBan(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select PhongBan_Id,TenPhongBan from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where TamNgung=0 and Cap = 1 ");
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
            DataSet ds1 = mySQL.PDataset("Select PhongBan_Id,TenPhongBan from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where TamNgung=0 and CapTren_Id= " + ParentId + "");
            foreach (DataRow dr1 in ds1.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 2;
                child.Text = dr1["TenPhongBan"].ToString().Trim();
                child.Tag = dr1["PhongBan_Id"].ToString().Trim();
                parent.Nodes.Add(child);
                FillChildLeverPB(child, Convert.ToInt32(child.Tag));

            }
        }
        public static void FillChildLeverPB(TreeNode parent, int ParentId)
        {
            DataSet ds2 = mySQL.PDataset("Select PhongBan_Id,TenPhongBan from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where TamNgung=0 and CapTren_Id= " + ParentId + "");
            foreach (DataRow dr2 in ds2.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 1;
                child.Text = dr2["TenPhongBan"].ToString().Trim();
                child.Tag = dr2["PhongBan_Id"].ToString().Trim();
                parent.Nodes.Add(child);
            }
        }

        /* End */

        public static void GVDichVu(GridControl gv)
        {
            ThuVien.mySQL.LoadGirdControl(gv, "select DichVu_Id,TenDichVu,TenNhomDichVu,TenLoaiDichVu from [mHIS_Hethong].[dbo].[view_Loai_Nhom_DichVu]");
        }

    }
}
