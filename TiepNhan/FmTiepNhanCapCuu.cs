using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TiepNhan
{
    public partial class FmTiepNhanCapCuu : DevExpress.XtraEditors.XtraForm
    {
        private string SoTiepNhan;

        private int TiepNhan_Id;

        private int DoiTuong_Id;
       
        public FmTiepNhanCapCuu()
        {
            InitializeComponent();
            
        }

        public FmTiepNhanCapCuu(string SoTiepNhan, int TiepNhan_Id) :this()
        {
            this.SoTiepNhan = SoTiepNhan;
            this.TiepNhan_Id = TiepNhan_Id;
           
        }
        //string[] ttbn;
        private void FmTiepNhanCapCuu_Load(object sender, EventArgs e)
        {
            dtThoiGian.DateTime = DateTime.Now;
            Common.clsControl.LoadLookup(lkNoiNhapVien, "KhoaKham", 2);
            Common.clsControl.LoadLookup(lkKhoaDieuTri, "KhoaKham", 2);
            Common.clsControl.LoadLookup(lkBacSiChiDinh, "BacSi", 2);
            Common.clsControl.LoadLookup(lkLoaiBenhAn, "LoaiBenhAnCapCuu", 2);
            
            lkNoiNhapVien.EditValue = 54483;
            lkKhoaDieuTri.EditValue = 54483;
            lkLoaiBenhAn.EditValue = 903;
            EntityClass.cls_TiepNhan tn = new EntityClass.cls_TiepNhan();
            if (TiepNhan_Id > 0)
            {
                tn.Get_By_Key(TiepNhan_Id);
            }
            else { tn.Get_By_SoTiepNhan(SoTiepNhan); }
           
            EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
            bn.Get_By_Key(tn.mvarBenhNhan_Id);
            lbHoTen.Text = bn.mvarTenBenhNhan;
            lbMaYTe.Text = bn.mvarMaYTe;
            lbSoTiepNhan.Text = tn.mvarSoTiepNhan;
            lbHoTen.Tag = bn.mvarBenhNhan_Id;
            lbSoTiepNhan.Tag = tn.mvarTiepNhan_Id;
            DoiTuong_Id = tn.mvarDoiTuong_Id;
        }

        private void rdNoiTru_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNoiTru.Checked)
            {
                rdNgoaiTru.Checked = false;
            }
            else
            {
                rdNgoaiTru.Checked = true;
            }
        }

        private void rdNgoaiTru_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNgoaiTru.Checked)
            {
                rdNoiTru.Checked = false;
            }
            else
            {
                rdNoiTru.Checked = true;
            }
        }

        private void btnTaoBenhAn_Click(object sender, EventArgs e)
        {
            EntityClass.cls_BenhAn ba = new EntityClass.cls_BenhAn();
            ba.mvarSoBenhAn = ba.getSoBenhAn();
            ba.mvarLoaiBenhAn_Id = int.Parse(lkLoaiBenhAn.EditValue.ToString());
            ba.mvarTiepNhan_Id = int.Parse(lbSoTiepNhan.Tag.ToString());
            ba.mvarBenhNhan_Id = int.Parse(lbHoTen.Tag.ToString());
            ba.mvarNgayLap = DateTime.Today;
            ba.mvarThoiGianLap = DateTime.Now;
            ba.mvarNguoiTao_Id = ThuVien.loadform.userID;
            ba.mvarKhoaVao_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
            ba.mvarKhoaChuyenDen_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
            try {
                ba.mvarBacSiDieuTriChinh_Id = int.Parse(lkBacSiChiDinh.EditValue.ToString());
                ba.mvarBacSiDieuTri_Id = int.Parse(lkBacSiChiDinh.EditValue.ToString());
            } catch { }
            ba.mvarNgayVaoKhoa = DateTime.Today;
            ba.mvarThoiGianVaoKhoa = DateTime.Now;
            ba.mvarNgayVaoVien = DateTime.Today;
            ba.mvarThoiGianVaoVien = DateTime.Now;
            ba.mvarDoiTuong_Id = DoiTuong_Id;
            int benhAn_Id = int.Parse(ba.Add());
            EntityClass.cls_BenhAnChiTiet bact = new EntityClass.cls_BenhAnChiTiet();
            bact.mvarBenhAn_Id = benhAn_Id;
            bact.Add();
            EntityClass.cls_NoiTru_LuuTru nt = new EntityClass.cls_NoiTru_LuuTru();
            nt.mvarBenhAn_Id = benhAn_Id;
            nt.mvarNgayTao = DateTime.Today;
            nt.mvarThoiGianVao = DateTime.Now;
            nt.mvarDoiTuong_Id = DoiTuong_Id;
            nt.mvarPhongBan_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
            int noiTru_Id = int.Parse(nt.Add());
            EntityClass.cls_NoiTru_LuuTruChiTiet ntct = new EntityClass.cls_NoiTru_LuuTruChiTiet();
            ntct.mvarLuuTru_Id = noiTru_Id;
            ntct.mvarNgayTao = DateTime.Today;
            ntct.mvarNguoiTao_Id = ThuVien.loadform.userID;
            ntct.mvarDoiTuong_Id = DoiTuong_Id; ;
            ntct.mvarPhongBan_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
            ntct.Add();
            
            EntityClass.ThongTin_CapCuu ttcc = new EntityClass.ThongTin_CapCuu();
            ttcc.mvarTiepNhan_Id = int.Parse(lbSoTiepNhan.Tag.ToString());
            ttcc.mvarBenhAn_Id = benhAn_Id;
            ttcc.mvarBenhNhan_Id = int.Parse(lbHoTen.Tag.ToString());
            ttcc.mvarSoCapCuu = ba.mvarSoBenhAn;
            ttcc.mvarLuuTru_Id = noiTru_Id;
            ttcc.mvarNgayCapCuu = DateTime.Today;
            ttcc.mvarThoiGianCapCuu = DateTime.Now;
            ttcc.mvarNgayTao = DateTime.Today;
            ttcc.mvarNguoiTao_Id = ThuVien.loadform.userID;
            
            ttcc.Add();

            EntityClass.cls_KhamBenh_VaoVien kbvv = new EntityClass.cls_KhamBenh_VaoVien();
            kbvv.mvarTiepNhan_Id = int.Parse(lbSoTiepNhan.Tag.ToString());
           

            if (TiepNhan_Id>0)
            {
                EntityClass.cls_NoiTru_NhapVien ntnv = new EntityClass.cls_NoiTru_NhapVien();
                ntnv.mvarTiepNhan_Id = int.Parse(lbSoTiepNhan.Tag.ToString());
                ntnv.mvarNgayNhapVien = DateTime.Today;
                ntnv.mvarThoiGianNhapVien = DateTime.Now;
                ntnv.mvarNoiNhapVien_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
                ntnv.mvarKhoaDieuTri_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
                ntnv.mvarBenhAn_Id = benhAn_Id;
                ntnv.mvarLoaiBenhAn_Id = int.Parse(lkLoaiBenhAn.EditValue.ToString());
                ntnv.mvarCapCuu = true;
                ntnv.mvarNgayTao = DateTime.Today;
                ntnv.mvarNguoiTao_Id = ThuVien.loadform.userID;
                ntnv.Add();
            }
            else
            {
                EntityClass.cls_NoiTru_NhapVien ntnv = new EntityClass.cls_NoiTru_NhapVien();
                ntnv.Get_By_TiepNhan_Id(int.Parse(lbSoTiepNhan.Tag.ToString()));
                ntnv.mvarNoiNhapVien_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
                ntnv.mvarKhoaDieuTri_Id = int.Parse(lkKhoaDieuTri.EditValue.ToString());
                ntnv.mvarBenhAn_Id = benhAn_Id;
                ntnv.mvarLoaiBenhAn_Id = int.Parse(lkLoaiBenhAn.EditValue.ToString());
                ntnv.mvarCapCuu = false;
                ntnv.mvarNgayTao = DateTime.Today;
                ntnv.mvarNguoiTao_Id = ThuVien.loadform.userID;
                kbvv.mvarKhamBenh_Id = ntnv.mvarKhamBenh_Id;
                ntnv.Update();
            }
            kbvv.mvarCapCuu = TiepNhan_Id > 0 ? false : true;
            
            kbvv.mvarBenhNhan_Id = ba.mvarBenhNhan_Id;
            kbvv.mvarNguoiTao_Id = ThuVien.loadform.userID;
            kbvv.mvarNgayTao = DateTime.Now;
            kbvv.Add();
            this.Close();
           
        }

    }
}