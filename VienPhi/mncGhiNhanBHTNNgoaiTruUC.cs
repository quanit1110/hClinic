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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace VienPhi
{
    public partial class mncGhiNhanBHTNNgoaiTruUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai báo biến
        int status = 0;
        #endregion
        /*-----------------------------------------------*/
        #region Khởi tạo form
        public mncGhiNhanBHTNNgoaiTruUC()
        {
            InitializeComponent();
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
        private void mncGhiNhanBHTNNgoaiTruUC_Load(object sender, EventArgs e)
        {
            Common.clsControl.LoadLookup(lkCongTy, "KSK_CongTy", 2, "", "", "Công ty", "Id");
            Common.clsControl.LoadLookup(lkSoPhieu, "SoPhieuGhiNhan", 2, "", "", "Số phiếu", "Id");
            Common.clsControl.LoadLookup(lkNguoiLap, "BacSi", 2, "", "", "Người lập", "Id");
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
            status = 1;
            return true;
        }
        public bool saveCommand()
        {
            status = 0;
            return true;
        }
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí nghiệp vụ
        #endregion
        /*-----------------------------------------------*/
        #region Hàm xử lí sự kiện
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
        private void lkSoPhieu_EditValueChanged(object sender, EventArgs e)
        {
            if (lkSoPhieu.EditValue != null)
            {
                EntityClass.cls_GhiNhanBHTN gn = new EntityClass.cls_GhiNhanBHTN();
                gn.Get_By_Key(int.Parse(lkSoPhieu.EditValue.ToString()));

                EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
                bn.Get_By_Key(gn.mvarBenhNhan_Id);
                if (bn.mvarBenhNhan_Id > 0)
                {
                    txtMaYTe.Text = bn.mvarSoVaoVien;
                    txtMaYTe.Tag = bn.mvarBenhNhan_Id;
                    lbHoTen.Text = bn.mvarTenBenhNhan;
                    lbDiaChiBn.Text = bn.mvarDiaChi;
                    try
                    {
                        lbTuoi.Text = (Int32.Parse(DateTime.Now.Year.ToString()) - bn.mvarNamSinh).ToString() + " Tuổi";
                    }
                    catch { }

                    LoadTTBH_BenhNhan_Id(bn.mvarBenhNhan_Id);
                }
                dtNgayLap.DateTime = gn.mvarNgayLap;
                lkNguoiLap.EditValue = gn.mvarNguoiLap_Id;
                txtTongGhiNhan.Text = gn.mvarGiaTri.ToString();
                rtxGhiChu.Text = gn.mvarGhiChu;

                EntityClass.cls_GhiNhanBHTN_ChiTiet gnct = new EntityClass.cls_GhiNhanBHTN_ChiTiet();
                gnct.GetListGhiNhan(gridControl1, int.Parse(lkSoPhieu.EditValue.ToString()));
                GridColumn colReceived = gridView1.Columns["Group_HoTro"];
                gridView1.BeginSort();
                try
                {
                    gridView1.ClearGrouping();
                    colReceived.GroupIndex = 0;
                }
                finally
                {
                    gridView1.EndSort();
                }
                gridView1.ExpandAllGroups();


                int count = gridView1.RowCount;
                for (int i = 0; i < count; i++)
                {
                    int rowHandle = gridView1.GetVisibleRowHandle(i);
                    if (gridView1.IsGroupRow(rowHandle))
                    {
                        string vl = gridView1.GetGroupSummaryValue(rowHandle, (gridView1.GroupSummary[0] as GridGroupSummaryItem)).ToString();
                        if (gridView1.GetDataRow(rowHandle)["Group_HoTro"].ToString() == "1. Khám bệnh")
                        {
                            txtKhamBenh.Text = vl;
                        }
                        else if (gridView1.GetDataRow(rowHandle)["Group_HoTro"].ToString() == "2. Cận lâm sàng")
                        {
                            txtCanLamSang.Text = vl;
                        }
                        else if (gridView1.GetDataRow(rowHandle)["Group_HoTro"].ToString() == "2. Cận lâm sàng")
                        {
                            txtCanLamSang.Text = vl;
                        }
                        else if (gridView1.GetDataRow(rowHandle)["Group_HoTro"].ToString() == "3. Phẫu thuật/ Thủ thuật")
                        {
                            txtPTTT.Text = vl;
                        }
                        else if (gridView1.GetDataRow(rowHandle)["Group_HoTro"].ToString() == "4. Thuốc/ Vật tư y tế")
                        {
                            txtThuoc.Text = vl;
                        }
                        else if (gridView1.GetDataRow(rowHandle)["Group_HoTro"].ToString() == "5. Giường bệnh")
                        {
                            txtGiuong.Text = vl;
                        }
                        else if (gridView1.GetDataRow(rowHandle)["Group_HoTro"].ToString() == "6. Khác")
                        {
                            txtKhac.Text = vl;
                        }
                    }
                }
            }
        }
        #endregion
        /*-----------------------------------------------*/
        #region Các hàm con
        private string LoadTTBN_SoVaoVien(string sovaovien)
        {
            EntityClass.clsDM_BenhNhan bn = new EntityClass.clsDM_BenhNhan();
            bn.Get_By_MaYTe(sovaovien);
            if (bn.mvarBenhNhan_Id > 0)
            {
                txtMaYTe.Text = bn.mvarSoVaoVien;
                txtMaYTe.Tag = bn.mvarBenhNhan_Id;
                lbHoTen.Text = bn.mvarTenBenhNhan;
                lbDiaChiBn.Text = bn.mvarDiaChi;
                try
                {
                    lbTuoi.Text = (Int32.Parse(DateTime.Now.Year.ToString()) - bn.mvarNamSinh).ToString() + " Tuổi";
                }
                catch { }

                LoadTTBH_BenhNhan_Id(bn.mvarBenhNhan_Id);
            }
            return bn.mvarBenhNhan_Id.ToString();
        }
        //Load thông tin bảo hiểm của bênh nhân theo benhnhanId
        private void LoadTTBH_BenhNhan_Id(int benhnhan_Id)
        {
            EntityClass.cls_DM_BenhNhan_BHYT bnbh = new EntityClass.cls_DM_BenhNhan_BHYT();
            bnbh.Get_By_BenhNhan_Id(benhnhan_Id);
            if (bnbh.mvarBenhNhan_Id > 0)
            {
                string BHYT = bnbh.mvarSoThe;
                lkCongTy.EditValue = bnbh.mvarCongty_Id;
                txtSoThe.Text = bnbh.mvarSoThe_TN;
                EntityClass.cls_KSK_CongTy cty = new EntityClass.cls_KSK_CongTy();
                cty.Get_By_Key(bnbh.mvarCongty_Id);
                txtDiaChi.Text = cty.mvarDiaChi;
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
        #endregion
  
    }
}
