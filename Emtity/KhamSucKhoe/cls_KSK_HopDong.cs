using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityClass
{
    public class cls_KSK_HopDong
    {
        #region "Constants"
        private const string sp_KSK_HOPDONG = "sp_KSK_HOPDONG";
        #endregion
        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarHopDong_ID { get; set; }
        public System.Int32 mvarCongty_id { get; set; }
        public System.String mvarSo_HD { get; set; }
        public System.DateTime mvarNgay_HD { get; set; }
        public System.Decimal mvarGiaTri_HD { get; set; }
        public System.DateTime mvarNgayHieuLuc_HD { get; set; }
        public System.DateTime mvarNgayHetHieuLuc_HD { get; set; }
        public System.Int32 mvarTrangThai_HD { get; set; }
        public System.Decimal mvarSoluong_BN { get; set; }
        public System.Int32 mvarLoai_HD { get; set; }
        public System.Int32 mvarHinhThucThanhToan_PhatSinh { get; set; }
        public System.Decimal mvarGiaTri_TamUng { get; set; }
        public System.Decimal mvarGiaTri_PhatSinh { get; set; }
        public System.String mvarDienGiai { get; set; }
        public System.DateTime mvarThoiGiankham { get; set; }
        public System.DateTime mvarThoiGianLayMau { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.Decimal mvarTyLeChietKhau { get; set; }
        public System.Decimal mvarGiaTriChietKhau { get; set; }
        public System.Decimal mvarTienChiNhanVien { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_KSK_HopDong()
        {
            m_Dal = new DataSet();
            ReSet();
        }

        #endregion
        public void ReSet()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarHopDong_ID = int.MinValue;
            mvarCongty_id = int.MinValue;
            mvarSo_HD = String.Empty;
            mvarNgay_HD = DateTime.MinValue;
            mvarGiaTri_HD = decimal.MinValue;
            mvarNgayHieuLuc_HD = DateTime.MinValue;
            mvarNgayHetHieuLuc_HD = DateTime.MinValue;
            mvarTrangThai_HD = int.MinValue;
            mvarSoluong_BN = decimal.MinValue;
            mvarLoai_HD = int.MinValue;
            mvarHinhThucThanhToan_PhatSinh = int.MinValue;
            mvarGiaTri_TamUng = decimal.MinValue;
            mvarGiaTri_PhatSinh = decimal.MinValue;
            mvarDienGiai = String.Empty;
            mvarThoiGiankham = DateTime.MinValue;
            mvarThoiGianLayMau = DateTime.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarTyLeChietKhau = decimal.MinValue;
            mvarGiaTriChietKhau = decimal.MinValue;
            mvarTienChiNhanVien = decimal.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarHopDong_ID = Common.clsControl.IsNullOrEmpty(row["HopDong_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HopDong_ID"]);
            mvarCongty_id = Common.clsControl.IsNullOrEmpty(row["Congty_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Congty_id"]);
            mvarSo_HD = Common.clsControl.getValueInRow<string>(row["So_HD"]);
            mvarNgay_HD = Common.clsControl.IsNullOrEmpty(row["Ngay_HD"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["Ngay_HD"]);
            mvarGiaTri_HD = Common.clsControl.IsNullOrEmpty(row["GiaTri_HD"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTri_HD"]);
            mvarNgayHieuLuc_HD = Common.clsControl.IsNullOrEmpty(row["NgayHieuLuc_HD"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHieuLuc_HD"]);
            mvarNgayHetHieuLuc_HD = Common.clsControl.IsNullOrEmpty(row["NgayHetHieuLuc_HD"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHetHieuLuc_HD"]);
            mvarTrangThai_HD = Common.clsControl.IsNullOrEmpty(row["TrangThai_HD"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TrangThai_HD"]);
            mvarSoluong_BN = Common.clsControl.IsNullOrEmpty(row["Soluong_BN"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["Soluong_BN"]);
            mvarLoai_HD = Common.clsControl.IsNullOrEmpty(row["Loai_HD"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Loai_HD"]);
            mvarHinhThucThanhToan_PhatSinh = Common.clsControl.IsNullOrEmpty(row["HinhThucThanhToan_PhatSinh"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HinhThucThanhToan_PhatSinh"]);
            mvarGiaTri_TamUng = Common.clsControl.IsNullOrEmpty(row["GiaTri_TamUng"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTri_TamUng"]);
            mvarGiaTri_PhatSinh = Common.clsControl.IsNullOrEmpty(row["GiaTri_PhatSinh"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTri_PhatSinh"]);
            mvarDienGiai = Common.clsControl.getValueInRow<string>(row["DienGiai"]);
            mvarThoiGiankham = Common.clsControl.IsNullOrEmpty(row["ThoiGiankham"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGiankham"]);
            mvarThoiGianLayMau = Common.clsControl.IsNullOrEmpty(row["ThoiGianLayMau"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianLayMau"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarTyLeChietKhau = Common.clsControl.IsNullOrEmpty(row["TyLeChietKhau"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyLeChietKhau"]);
            mvarGiaTriChietKhau = Common.clsControl.IsNullOrEmpty(row["GiaTriChietKhau"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriChietKhau"]);
            mvarTienChiNhanVien = Common.clsControl.IsNullOrEmpty(row["TienChiNhanVien"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TienChiNhanVien"]);

        }

        public string Add()
        {
            string rtHopDong_ID = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Congty_id", mvarCongty_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@So_HD", mvarSo_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ngay_HD", mvarNgay_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri_HD", mvarGiaTri_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHieuLuc_HD", mvarNgayHieuLuc_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHetHieuLuc_HD", mvarNgayHetHieuLuc_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai_HD", mvarTrangThai_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Soluong_BN", mvarSoluong_BN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Loai_HD", mvarLoai_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhThucThanhToan_PhatSinh", mvarHinhThucThanhToan_PhatSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri_TamUng", mvarGiaTri_TamUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri_PhatSinh", mvarGiaTri_PhatSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienGiai", mvarDienGiai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGiankham", mvarThoiGiankham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianLayMau", mvarThoiGianLayMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeChietKhau", mvarTyLeChietKhau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriChietKhau", mvarGiaTriChietKhau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienChiNhanVien", mvarTienChiNhanVien);
            rtHopDong_ID = ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG, listPara, "@HopDong_ID", SqlDbType.Int, 32);
            return rtHopDong_ID;
        }
        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_ID", mvarHopDong_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Congty_id", mvarCongty_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@So_HD", mvarSo_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Ngay_HD", mvarNgay_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri_HD", mvarGiaTri_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHieuLuc_HD", mvarNgayHieuLuc_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHetHieuLuc_HD", mvarNgayHetHieuLuc_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai_HD", mvarTrangThai_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Soluong_BN", mvarSoluong_BN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Loai_HD", mvarLoai_HD);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhThucThanhToan_PhatSinh", mvarHinhThucThanhToan_PhatSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri_TamUng", mvarGiaTri_TamUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTri_PhatSinh", mvarGiaTri_PhatSinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienGiai", mvarDienGiai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGiankham", mvarThoiGiankham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianLayMau", mvarThoiGianLayMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeChietKhau", mvarTyLeChietKhau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriChietKhau", mvarGiaTriChietKhau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienChiNhanVien", mvarTienChiNhanVien);
            ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG, listPara);
            return mvarHopDong_ID.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_ID", mvarHopDong_ID);
            string rt = ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public bool GetData_BySoHopdong(string soHD)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_BySoHopdong");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@So_HD", soHD);
                ds = ThuVien.mySQL.ExcDataSet(sp_KSK_HOPDONG, listPara);
                ReSet();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillData(ds.Tables[0].Rows[0]);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool GetData_ByKey(string HD_ID)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_ID", HD_ID);
                ds = ThuVien.mySQL.ExcDataSet(sp_KSK_HOPDONG, listPara);
                ReSet();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillData(ds.Tables[0].Rows[0]);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
