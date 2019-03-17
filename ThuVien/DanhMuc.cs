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


namespace ThuVien
{
    public static class DanhMuc
    {
        /* Load Girdcontrol DM_BenhNhan */
        public static void LoadGV(GridControl gv,string hoten,string namsinh)
        {
            if (hoten != "" & namsinh == "")
            {
                ThuVien.mySQL.LoadGirdControl(gv, "select * from [mHIS_Hethong].[dbo].[view_DM_BenhNhan] where TenBenhNhan like N'%" + hoten + "%'");
            }
            else
                if (hoten == "" & namsinh != "")
            {
                ThuVien.mySQL.LoadGirdControl(gv, "select * from [mHIS_Hethong].[dbo].[view_DM_BenhNhan] where NamSinh = '" + namsinh + "'");
            }
            else
            {
                ThuVien.mySQL.LoadGirdControl(gv, "select * from [mHIS_Hethong].[dbo].[view_DM_BenhNhan] where TenBenhNhan like N'%" + hoten + "%'and NamSinh = '" + namsinh + "'");
            }
        }

        /* End */

   


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
                child.Text = dr2["TenDichVu"].ToString().Trim();
                child.Tag = dr2["DichVu_Id"].ToString().Trim();
                parent.Nodes.Add(child);
            }
        }

        /* End */


        public static void BCNhomBenh(GridControl gv)
        {
            ThuVien.mySQL.LoadGirdControl(gv, "select * from [mHIS_Hethong].[dbo].[view_DM_BCNhomBenh]");
        }
        /* End */

        /* Load GridControl DM_ID */
        public static void DM_IDC(GridControl gv,string where)
        {
            ThuVien.mySQL.LoadGirdControl(gv, "select * from [mHIS_Hethong].[dbo].[view_DM_NhomICD] where NhomBenh_Id = " + where+"" );
        }
        /* End */


    

        /* Load Treeview PhongBan */

        public static void loadTVPB(TreeView tv)
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
            DataSet ds1 = mySQL.PDataset("Select PhongBan_Id,TenPhongBan from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where TamNgung=0 and CapTren_Id= " + ParentId+"");
            foreach (DataRow dr1 in ds1.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 1;
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
                child.ImageIndex = 2;
                child.Text = dr2["TenPhongBan"].ToString().Trim();
                child.Tag = dr2["PhongBan_Id"].ToString().Trim();
                parent.Nodes.Add(child);
            }
        }

        /* End */
     
        /* Load Treeview TimPhongBan */
        public static void TimloadTVPB(TreeView tv,string where)
        {
            DataSet PrSet = mySQL.PDataset("Select PhongBan_Id,TenPhongBan from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where LoaiPhongBan_Id = "+where+"");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["TenPhongBan"].ToString();
                tnParent.Tag = Convert.ToInt32(dr["PhongBan_Id"]);
                tv.Nodes.Add(tnParent);
                TimFillChildPB(tnParent, Convert.ToInt32(tnParent.Tag));
            }
        }
        public static void TimFillChildPB(TreeNode parent, int ParentId)
        {
            DataSet ds1 = mySQL.PDataset("Select PhongBan_Id,TenPhongBan from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where TamNgung=0 and CapTren_Id= " + ParentId + "");
            foreach (DataRow dr1 in ds1.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 1;
                child.Text = dr1["TenPhongBan"].ToString().Trim();
                child.Tag = dr1["PhongBan_Id"].ToString().Trim();
                parent.Nodes.Add(child);
                TimFillChildLeverPB(child, Convert.ToInt32(child.Tag));

            }
        }
        public static void TimFillChildLeverPB(TreeNode parent, int ParentId)
        {
            DataSet ds2 = mySQL.PDataset("Select PhongBan_Id,TenPhongBan from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where TamNgung=0 and CapTren_Id= " + ParentId + "");
            foreach (DataRow dr2 in ds2.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 2;
                child.Text = dr2["TenPhongBan"].ToString().Trim();
                child.Tag = dr2["PhongBan_Id"].ToString().Trim();
                parent.Nodes.Add(child);
            }
        }

        /* End */

        /* Load Treeview DanhMucHoatChat */
        public static void TreeDMHC(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select LoaiVatTu_Id,TenLoaiVatTu from [mHIS_Hethong].[dbo].[view_DM_LoaiVatTu]");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["TenLoaiVatTu"].ToString();
                tnParent.Tag = dr["LoaiVatTu_Id"].ToString();
                tv.Nodes.Add(tnParent);
                TreeDMHC1(tnParent,tnParent.Tag.ToString());
            }
        }
        public static void TreeDMHC1(TreeNode parent, string ParentId)
        {
            DataSet ds1 = mySQL.PDataset("Select HoatChat_Id,TenHoatChat from [mHIS_Hethong].[dbo].[view_DM_Duoc_HoatChat] where Cap= 1 and LoaiVatTu_Id= '" + ParentId + "'");
            foreach (DataRow dr1 in ds1.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 1;
                child.Text = dr1["TenHoatChat"].ToString().Trim();
                child.Tag = dr1["HoatChat_Id"].ToString().Trim();
                parent.Nodes.Add(child);
                TreeDMHC2(child, Convert.ToInt32(child.Tag));

            }
        }
        public static void TreeDMHC2(TreeNode parent, int ParentId)
        {
            DataSet ds2 = mySQL.PDataset("Select HoatChat_Id,TenHoatChat from [mHIS_Hethong].[dbo].[view_DM_Duoc_HoatChat] where CapTren_Id= " + ParentId + "");
            foreach (DataRow dr2 in ds2.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 2;
                child.Text = dr2["TenHoatChat"].ToString().Trim();
                child.Tag = dr2["HoatChat_Id"].ToString().Trim();
                parent.Nodes.Add(child);
                TreeDMHC3(child, Convert.ToInt32(child.Tag));
            }
        }
        public static void TreeDMHC3(TreeNode parent, int ParentId)
        {
            DataSet ds2 = mySQL.PDataset("Select HoatChat_Id,TenHoatChat from [mHIS_Hethong].[dbo].[view_DM_Duoc_HoatChat] where CapTren_Id= " + ParentId + "");
            foreach (DataRow dr2 in ds2.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.Text = dr2["TenHoatChat"].ToString().Trim();
                child.Tag = dr2["HoatChat_Id"].ToString().Trim();
                parent.Nodes.Add(child);
            }
        }

        /* End */

   

   
        /* Load Treeview NhaCungCap */
        public static void TVNCC(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select NhaCungCap_Id,TenNhaCungCap from [mHIS_Hethong].[dbo].[view_DM_NhaCungCap]");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["TenNhaCungCap"].ToString();
                tnParent.Tag = dr["NhaCungCap_Id"].ToString();
                tv.Nodes.Add(tnParent);
                TVNCC1(tnParent, tnParent.Tag.ToString());
            }
        }
        public static void TVNCC1(TreeNode parent, string ParentId)
        {
            DataSet ds1 = mySQL.PDataset("Select GiaHopDong_Id,Dictionary_Name from [mHIS_Hethong].[dbo].[view_GiaHopDong_Dictionary] where NhaCungCap_Id = '" + ParentId + "'");
            foreach (DataRow dr1 in ds1.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 1;
                child.Text = dr1["Dictionary_Name"].ToString().Trim();
                child.Tag = dr1["GiaHopDong_Id"].ToString().Trim();
                parent.Nodes.Add(child);
                TreeDMHC2(child, Convert.ToInt32(child.Tag));
            }
        }
        /* End */

        /* Load GirdControl GiaHopDongChiTiet */
        public static void LoadGiaHopDong(GridControl gv, string where)
        {
            mySQL.LoadGirdControl(gv, "select Duoc_Id,DonGiaHopDong,DonGiaDuTru,SoLuongCungCap,SoLuongDaNhap,MaThongTu,SoViSa,MaQuyetDinh,SoNamHopDong from [mHIS_Hethong].[dbo].[view_GiaHopDongChiTiet] where " + where + " ");
        }
        /* End */

        /* Load Treeview DoiTuong */
        public static void TreeVDoiTuong(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select DoiTuong_Id,TenDoiTuong from [mHIS_Hethong].[dbo].[view_DM_DoiTuong] where TamNgung = 0");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["TenDoiTuong"].ToString();
                tnParent.Tag = dr["DoiTuong_Id"].ToString();
                tv.Nodes.Add(tnParent);               
            }
        }
        /* End */

        /* Load GirdControl Duoc_Nguonhang */
        public static void GVDuoc_NguonHang(GridControl gv, string where)
        {
            mySQL.LoadGirdControl(gv, "select MaDuoc,TenDuocDayDu,LoaiDuoc_Id,DonViTinh,HamLuong,TenHang,QuocGia from [mHIS_Hethong].[dbo].[viewDuocTheoNguonHang] where " + where + " ");
        }
        /* End */

        /* Load Treeview Kho */
        public static void TreeVKho(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select KhoDuoc_Id,TenKho from [mHIS_Hethong].[dbo].[view_KhoDuoc] where TamNgung = 0");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["TenKho"].ToString();
                tnParent.Tag = dr["KhoDuoc_Id"].ToString();
                tv.Nodes.Add(tnParent);
            }
        }
        /* End */

        /* Load GirdControl DM_NoiLinhDuoc */
        public static void GVNoiLinhDuoc(GridControl gv)
        {
            mySQL.LoadGirdControl(gv, "select TenNhomLoaiDuoc from [mHIS_Hethong].[dbo].[view_DM_NhomLoaiDuoc]");
        }
        /* End */
        /* Load GirdControl KhoDuoc_Center */
        public static void LoadGVKhoDuoc(GridControl gv)
        {
            mySQL.LoadGirdControl(gv, "select TenKho from [mHIS_Hethong].[dbo].[view_KhoDuoc_Center]");
        }
        /* End */
            /* Load GirdControl Duoc_CanhBao */
        public static void GVDuoc_CanhBao(GridControl gv)
        {
            mySQL.LoadGirdControl(gv, "select * from [mHIS_Hethong].[dbo].[view_KhoDuoc_Center]");
        }
        /* End */

        /* Load Treeview DM_MaBaoCao */
        public static void TreeDMMauBaoCao(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select ID,MoTa from [mHIS_Hethong].[dbo].[view_DM_MauBaoCao] where CapTren_Id is null");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["MoTa"].ToString();
                tnParent.Tag = dr["ID"].ToString();
                tv.Nodes.Add(tnParent);
                TreeDMMauCaoCao1(tnParent, tnParent.Tag.ToString());
            }
        }
        public static void TreeDMMauCaoCao1(TreeNode parent, string ParentId)
        {
            DataSet ds1 = mySQL.PDataset("Select ID,MoTa from [mHIS_Hethong].[dbo].[view_DM_MauBaoCao] where CapTren_Id = '" + ParentId + "'");
            foreach (DataRow dr1 in ds1.Tables[0].Rows)
            {
                TreeNode child = new TreeNode();
                child.ImageIndex = 1;
                child.Text = dr1["MoTa"].ToString().Trim();
                child.Tag = dr1["ID"].ToString().Trim();
                parent.Nodes.Add(child);
                TreeDMHC2(child, Convert.ToInt32(child.Tag));

            }
        }
        /* End */

           /* Load GirdControl DM_DoiTuong */
        public static void DoiTuong(GridControl gv)
        {
            mySQL.LoadGirdControl(gv, "select TenDoiTuong,MaDoiTuong from [mHIS_Hethong].[dbo].[view_DM_DoiTuong] where TamNgung = 0");
        }
        /* End */

        /* Load Treeview ChuyenKHoa */
        public static void TVChuyenKhoa(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select ChuyenKhoa_Id,TenChuyenKhoa from [mHIS_Hethong].[dbo].[view_DM_ChuyenKhoa]");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 0;
                tnParent.Text = dr["TenChuyenKhoa"].ToString();
                tnParent.Tag = dr["ChuyenKhoa_Id"].ToString();
                tv.Nodes.Add(tnParent);
                TreeDMMauCaoCao1(tnParent, tnParent.Tag.ToString());
            }
        }
        /* End */

        /* Load Treeview PhongKham */
        public static void TVPhongKham(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select PhongBan_Id,TenPhongBan from [mHIS_Hethong].[dbo].[view_DM_PhongBan] where LoaiPhongBan_Id = 566");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 2;
                tnParent.Text = dr["TenPhongBan"].ToString();
                tnParent.Tag = dr["PhongBan_Id"].ToString();
                tv.Nodes.Add(tnParent);
                TreeDMMauCaoCao1(tnParent, tnParent.Tag.ToString());
            }
        }
        /* End */

        public static void GVKHoDuoc(GridControl gv)
        {
            mySQL.LoadGirdControl(gv, "Select KhoDuoc_Id,TenKho from [mHIS_Hethong].[dbo].[view_KhoDuoc] where TamNgung = 0");
        }


        /* Load Treeview Kho */
        public static void TVNguonHang(TreeView tv)
        {
            DataSet PrSet = mySQL.PDataset("Select NguonDuoc_Id,TenNguonDuoc from [mHIS_Hethong].[dbo].[DM_NguonHang] where TamNgung = 0");
            tv.Nodes.Clear();
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode tnParent = new TreeNode();
                tnParent.ImageIndex = 1;
                tnParent.Text = dr["TenNguonDuoc"].ToString();
                tnParent.Tag = dr["NguonDuoc_Id"].ToString();
                tv.Nodes.Add(tnParent);
            }
        }
        /* End */

    }
}

