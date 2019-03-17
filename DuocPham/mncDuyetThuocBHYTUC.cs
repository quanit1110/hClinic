using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using DevExpress.XtraGrid.Views.Grid;


namespace DuocPham
{
    public partial class mncDuyetThuocBHYTUC : DevExpress.XtraEditors.XtraUserControl
    {
       
        #region Khai báo biến    
        DataTable dt = new DataTable();
        int status = 0;
        List<TT> listName = new List<TT>();
        #endregion
        /*-----------------------------------------------*/
        #region Khởi tạo from

        public mncDuyetThuocBHYTUC()
        {
            InitializeComponent();
            //lấy kích thước của màn hình
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hiển thị theo kích thước của màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;
            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1386 là chiều rộng, 788 là chiều cao Form khi thiết kế, xem trong Properties của Form
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);

        }
        private void mncDuyetThuocBHYTUC_Load(object sender, EventArgs e)
        {
            Common.clsControl.LoadLookup(lkNguonDuoc, "DanhSachKhoDuoc", 2, "", "", "Kho dược", "Id");
            Common.clsControl.LoadLookup(lkNoiGiao, "DanhSachDonViGiao_ThanhLy", 2, "", "", "Nơi giao", "Id");
            Common.clsControl.LoadLookup(lkNguoiGiao, "NhanVien", 2, "", "", "Nhân viên", "Id");
            Common.clsControl.LoadLookup(lkDuoc, "Get_Dm_Duoc", 2, "", "", "Tên dược", "Id");
            Common.clsControl.LoadLookup(lkSoLo, "getAll_SoLoNhap", 2, "", "", "Số lô", "Id");//SoLoNhap_ByKhoa_Id
            Common.clsControl.LoadLookup(lkDoiTuong, "DoiTuong", 2, "", "", "Đối tượng", "Id");
            EntityClass.cls_KhamBenh_ToaThuoc tt = new EntityClass.cls_KhamBenh_ToaThuoc();
            tt.GetListBNChoNhanThuocBHYT(gridControl1, DateTime.Now);
        }
        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                //gọi đệ quy nếu như 1 control nào có chứa các control khác nữa

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                //canh lại toạ độ x, y, chiều rộng, cao cho các control trên form

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }
        #endregion
        /*-----------------------------------------------*/
        #region Hàm chức năng

        public bool editCommand()
        {
            status = 3;
            return true;
        }

        public bool deleteCommand()
        {

            status = 2;

            return true;
        }
        public bool addCommand()
        {
            ThuVien.loadform.enableControl(this);
            status = 1;
            return true;
        }
        public bool saveCommand()
        {
            status = 0;
            return true;
        }

        private void dtNgayGiao_DateTimeChanged(object sender, EventArgs e)
        {

        }

      

        #endregion
        /*-----------------------------------------------*/
        private void btnMaYTe_Click(object sender, EventArgs e)
        {
            ThuVien.FcLoadLookup mayte = new ThuVien.FcLoadLookup("[hsvClinic].[dbo].[DM_BenhNhan]", "BenhNhan_Id", "TenBenhNhan", "SoVaoVien", "");
            mayte.ShowDialog();
            if (mayte.lkChange)
            {
                txtMaYTe.Text = mayte.lkText;
                txtMaYTe.Tag = mayte.lkId;
                LoadTTBN_SoVaoVien(txtMaYTe.Text);
            }
            mayte.Dispose();
        }
        private string LoadTTBN_SoVaoVien(string sovaovien)
        {
            EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
            bn.Get_By_MaYTe(sovaovien);
            if (bn.mvarBenhNhan_Id > 0)
            {
                txtMaYTe.Text = bn.mvarSoVaoVien;
                txtMaYTe.Tag = bn.mvarBenhNhan_Id;
                txtDiaChi.Text = bn.mvarDiaChi;
                txtTenBenhNhan.Text = bn.mvarTenBenhNhan;
                txtNamSinh.Text = bn.mvarNamSinh.ToString();
                if (bn.mvarGioiTinh == "T")
                {
                    rdNam.Checked = true;
                    rdNu.Checked = false;
                }
                else
                {
                    rdNu.Checked = true;
                    rdNam.Checked = false;
                }
            }
            return bn.mvarBenhNhan_Id.ToString();
        }

        private void txtMaYTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String chuoi = (sender as TextEdit).Text.ToString();// txtHoTen.Text;

                if (chuoi.Length >= 8 && chuoi.Length < 15)
                {
                    txtMaYTe.Tag = LoadTTBN_SoVaoVien(chuoi);
                }
                else if (chuoi.Length > 15)
                {
                    txtMaYTe.Tag = LoadTTBN_QrCode(chuoi);
                }
            }
        }
        //Load thông tin bệnh nhân theo qrcode
        private string LoadTTBN_QrCode(string qr_Code)
        {
            int rs = Common.clsQrCode.HamTachChuoi_QRCODE(qr_Code);
            if (rs == 3)
            {
                return LoadTTBN_SoVaoVien(Common.clsQrCode.SoVaoVien);
            }
            return "";
        }


        private void btnSoPhieu_Click(object sender, EventArgs e)
        {

            ThuVien.FcLoadLookup chungtu = new ThuVien.FcLoadLookup("[hsvClinic].[dbo].[ChungTu]", "ChungTu_Id", "SoChungTu", "MaChungTu", "");
            chungtu.ShowDialog();
            if (chungtu.lkChange)
            {
                txtSoPhieu.Text = chungtu.lkText;
                txtSoPhieu.Tag = chungtu.lkId;
                LoadTTChungTu(int.Parse(chungtu.lkId));
            }
            chungtu.Dispose();
        }

        private void LoadTTChungTu(int chungTu_Id)
        {
            EntityClass.Cls_ChungTu chungTu = new EntityClass.Cls_ChungTu();
            chungTu.Get_By_Key(chungTu_Id);
            if (chungTu.mvarChungTu_Id > 0)
            {
                txtTenBenhNhan.Text = chungTu.mvarTenBenhNhan;
                txtDienGiai.Text = chungTu.mvarDienGiaiNghiepVuPhatSinh;
                dtNgayGiao.DateTime = chungTu.mvarNgayChungTu;
                lkNguoiGiao.EditValue = chungTu.mvarNguoiGiao;
                lkNoiGiao.EditValue = chungTu.mvarKhoXuat_Id;
                EntityClass.Cls_ChungTu_ChiTiet ctct = new EntityClass.Cls_ChungTu_ChiTiet();
                ctct.GetListChiTiet(gridControl3, chungTu.mvarChungTu_Id);
                if (chungTu.mvarGioiTinh == "T")
                {
                    rdNam.Checked = true;
                    rdNu.Checked = false;
                }
                else if (chungTu.mvarGioiTinh == "G")
                {
                    rdNam.Checked = false;
                    rdNu.Checked = true;
                }
                txtNamSinh.Text = chungTu.mvarNamSinh == int.MinValue ? "" : chungTu.mvarNamSinh.ToString();
                txtDiaChi.Text = chungTu.mvarDiaChi;
                if (chungTu.mvarDoiTuong_Id > 0) { lkDoiTuong.EditValue = chungTu.mvarDoiTuong_Id; }
                if (chungTu.mvarBenhNhan_Id > 0)
                {
                    EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
                    bn.Get_By_Key(chungTu.mvarBenhNhan_Id);
                    if (bn.mvarBenhNhan_Id > 0)
                    {
                        txtMaYTe.Text = bn.mvarSoVaoVien;
                        txtMaYTe.Tag = bn.mvarBenhNhan_Id;
                        txtDiaChi.Text = bn.mvarDiaChi;
                        txtTenBenhNhan.Text = bn.mvarTenBenhNhan;
                        txtNamSinh.Text = bn.mvarNamSinh.ToString();
                        if (bn.mvarGioiTinh == "T")
                        {
                            rdNam.Checked = true;
                            rdNu.Checked = false;
                        }
                        else
                        {
                            rdNu.Checked = true;
                            rdNam.Checked = false;
                        }
                    }
                }

            }
        }

        private void gridView3_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //lbThanhToan.Text = gridView3.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string benhNhan_Id = LoadTTBN_SoVaoVien(gridView1.GetDataRow(e.RowHandle)["FieldCode"].ToString());
            EntityClass.cls_KhamBenh kb = new EntityClass.cls_KhamBenh();
            kb.Get_By_BenhNhan_Id(int.Parse(benhNhan_Id));
            if (kb.mvarKhamBenh_Id > 0)
            {
                lkDoiTuong.EditValue = kb.mvarDoiTuong_Id;
                EntityClass.cls_KhamBenh_ToaThuoc kbtt = new EntityClass.cls_KhamBenh_ToaThuoc();
                kbtt.Get_By_KhamBenh_Id(kb.mvarKhamBenh_Id);
                if (kbtt.mvarKhamBenh_ToaThuoc_Id > 0)
                {
                    txtSoToa.Text = kbtt.mvarSoThuTuToa;
                    EntityClass.cls_ToaThuoc tt = new EntityClass.cls_ToaThuoc();          
                    tt.GetToaThuoc(gridControl3, kbtt.mvarSoThuTuToa);

                    DataTable dt = new DataTable();                   
                    dt = kbtt.GetToaThuoc_By_KBTT(kbtt.mvarKhamBenh_ToaThuoc_Id);
                    listName.Clear();
                    foreach(DataRow row in dt.Rows)
                    {
                        TT t = new TT();
                        t.STT = Common.clsControl.IsNullOrEmpty(row["STT"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["STT"]);
                        t.TenDuocDayDu = Common.clsControl.getValueInRow<string>(row["TenDuocDayDu"]);
                        t.DonViTinh = Common.clsControl.getValueInRow<string>(row["DonViTinh"]);
                        t.SoLuong_BuoiSang = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiSang"].ToString().ToArray()) ? 0 : Common.clsControl.getValueInRow<int>(row["SoLuong_BuoiSang"]);
                        t.SoLuong_BuoiTrua = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiTrua"].ToString().ToArray()) ? 0 : Common.clsControl.getValueInRow<int>(row["SoLuong_BuoiTrua"]);
                        t.SoLuong_BuoiChieu = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiChieu"].ToString().ToArray()) ?0 : Common.clsControl.getValueInRow<int>(row["SoLuong_BuoiChieu"]);
                        t.SoLuong_BuoiToi = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiToi"].ToString().ToArray()) ? 0 : Common.clsControl.getValueInRow<int>(row["SoLuong_BuoiToi"]);
                        t.SoLuong = Common.clsControl.IsNullOrEmpty(row["SoLuong"].ToString().ToArray()) ? 0 : Common.clsControl.getValueInRow<int>(row["SoLuong"]);
                        t.SoNgay = Common.clsControl.IsNullOrEmpty(row["SoNgay"].ToString().ToArray()) ? 0 : Common.clsControl.getValueInRow<int>(row["SoNgay"]);
                        t.GhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
                        listName.Add(t);
                    }
                }
            }
            kb.GetTTBNChoNhanThuocBHYT(gridControl2, int.Parse(benhNhan_Id));
            //gridControl1.ForceInitialize()        
            grvBenhNhan.ExpandMasterRow(0);
               
        }

        private void grvBenhNhan_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.RowCount > 0)
            {
                e.IsEmpty = false;
            }
        }

        private void grvBenhNhan_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {  
            e.ChildList= listName.ToList();
        }
       
        private void grvBenhNhan_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvBenhNhan_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }
        class TT
        {
            public int STT { get; set; }
            public string TenDuocDayDu { get; set; }
            public string DonViTinh { get; set; }
            public int SoLuong_BuoiSang { get; set; }
            public int SoLuong_BuoiTrua { get; set; }
            public int SoLuong_BuoiChieu { get; set; }
            public int SoLuong_BuoiToi { get; set; }
            public int SoNgay { get; set; }
            public int SoLuong { get; set; }
            public string GhiChu { get; set; }

        }
    }
}
