using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class cls_ToaThuoc
    {
        #region "Constants"
        private const string SP_ToaThuoc = "SP_ToaThuoc";
        #endregion

        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarToaThuoc_Id { get; set; }

        public System.Int32 mvarKhamBenh_ToaThuoc_Id { get; set; }

        public System.String mvarSoThuTuToa { get; set; }

        public System.Int32 mvarKhamBenh_Id { get; set; }

        public System.Int32 mvarDuoc_Id { get; set; }

        public System.Decimal mvarSoLuong { get; set; }

        public System.Byte mvarSoNgay { get; set; }

        public System.Int16 mvarSoLanTrenNgay { get; set; }

        public System.Decimal mvarSoLuongTrenLan { get; set; }

        public System.Decimal mvarSoLuong_BuoiSang { get; set; }

        public System.Decimal mvarSoLuong_BuoiTrua { get; set; }

        public System.Decimal mvarSoLuong_BuoiChieu { get; set; }

        public System.Decimal mvarSoLuong_BuoiToi { get; set; }

        public System.Int32 mvarDuongDung_Id { get; set; }

        public System.Decimal mvarDonGiaDoanhThu { get; set; }

        public System.Decimal mvarDonGiaHoTro { get; set; }

        public System.Decimal mvarDonGiaHoTroChiTra { get; set; }

        public System.Decimal mvarDonGiaThanhToan { get; set; }

        public System.String mvarTienTe_Id { get; set; }

        public System.Decimal mvarTyGia { get; set; }

        public System.Boolean mvarHuyToaThuoc { get; set; }

        public System.Boolean mvarPhatSinhHoaDon { get; set; }

        public System.String mvarGhiChu { get; set; }

        public System.String mvarTrangThai { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }

        public System.Int32 mvaridx { get; set; }

        public System.Int32 mvarLoaiGia_Id { get; set; }

        public System.Int32 mvarNguonHang_id { get; set; }

        public System.Boolean mvarTinhTien { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_ToaThuoc()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_ToaThuoc(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_ToaThuoc(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_ToaThuoc(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = dal;
        }
        #endregion

        public void Reset()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarToaThuoc_Id = int.MinValue;
            mvarKhamBenh_ToaThuoc_Id = int.MinValue;
            mvarSoThuTuToa = String.Empty;
            mvarKhamBenh_Id = int.MinValue;
            mvarDuoc_Id = int.MinValue;
            mvarSoLuong = decimal.MinValue;
            mvarSoNgay = Byte.MinValue;
            mvarSoLanTrenNgay = Int16.MinValue;
            mvarSoLuongTrenLan = decimal.MinValue;
            mvarSoLuong_BuoiSang = decimal.MinValue;
            mvarSoLuong_BuoiTrua = decimal.MinValue;
            mvarSoLuong_BuoiChieu = decimal.MinValue;
            mvarSoLuong_BuoiToi = decimal.MinValue;
            mvarDuongDung_Id = int.MinValue;
            mvarDonGiaDoanhThu = decimal.MinValue;
            mvarDonGiaHoTro = decimal.MinValue;
            mvarDonGiaHoTroChiTra = decimal.MinValue;
            mvarDonGiaThanhToan = decimal.MinValue;
            mvarTienTe_Id = String.Empty;
            mvarTyGia = decimal.MinValue;
            mvarHuyToaThuoc = false;
            mvarPhatSinhHoaDon = false;
            mvarGhiChu = String.Empty;
            mvarTrangThai = String.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvaridx = int.MinValue;
            mvarLoaiGia_Id = int.MinValue;
            mvarNguonHang_id = int.MinValue;
            mvarTinhTien = false;


        }

        public void FillData(DataRow row)
        {
            mvarToaThuoc_Id = Common.clsControl.IsNullOrEmpty(row["ToaThuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ToaThuoc_Id"]);
            mvarKhamBenh_ToaThuoc_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_ToaThuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_ToaThuoc_Id"]);
            mvarSoThuTuToa = Common.clsControl.getValueInRow<string>(row["SoThuTuToa"]);
            mvarKhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_Id"]);
            mvarDuoc_Id = Common.clsControl.IsNullOrEmpty(row["Duoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Duoc_Id"]);
            mvarSoLuong = Common.clsControl.IsNullOrEmpty(row["SoLuong"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong"]);
            mvarSoNgay = Common.clsControl.IsNullOrEmpty(row["SoNgay"].ToString().ToArray()) ? byte.MinValue : Common.clsControl.getValueInRow<byte>(row["SoNgay"]);
            mvarSoLanTrenNgay = Common.clsControl.IsNullOrEmpty(row["SoLanTrenNgay"].ToString().ToArray()) ? Int16.MinValue : Common.clsControl.getValueInRow<Int16>(row["SoLanTrenNgay"]);
            mvarSoLuongTrenLan = Common.clsControl.IsNullOrEmpty(row["SoLuongTrenLan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuongTrenLan"]);
            mvarSoLuong_BuoiSang = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiSang"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong_BuoiSang"]);
            mvarSoLuong_BuoiTrua = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiTrua"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong_BuoiTrua"]);
            mvarSoLuong_BuoiChieu = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiChieu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong_BuoiChieu"]);
            mvarSoLuong_BuoiToi = Common.clsControl.IsNullOrEmpty(row["SoLuong_BuoiToi"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong_BuoiToi"]);
            mvarDuongDung_Id = Common.clsControl.IsNullOrEmpty(row["DuongDung_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DuongDung_Id"]);
            mvarDonGiaDoanhThu = Common.clsControl.IsNullOrEmpty(row["DonGiaDoanhThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaDoanhThu"]);
            mvarDonGiaHoTro = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTro"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTro"]);
            mvarDonGiaHoTroChiTra = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTroChiTra"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTroChiTra"]);
            mvarDonGiaThanhToan = Common.clsControl.IsNullOrEmpty(row["DonGiaThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaThanhToan"]);
            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);
            mvarTyGia = Common.clsControl.IsNullOrEmpty(row["TyGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyGia"]);
            mvarHuyToaThuoc = Common.clsControl.getValueInRow<bool>(row["HuyToaThuoc"]);
            mvarPhatSinhHoaDon = Common.clsControl.getValueInRow<bool>(row["PhatSinhHoaDon"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvaridx = Common.clsControl.IsNullOrEmpty(row["idx"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["idx"]);
            mvarLoaiGia_Id = Common.clsControl.IsNullOrEmpty(row["LoaiGia_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiGia_Id"]);
            mvarNguonHang_id = Common.clsControl.IsNullOrEmpty(row["NguonHang_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguonHang_id"]);
            mvarTinhTien = Common.clsControl.getValueInRow<bool>(row["TinhTien"]);
        }

        public string Add()
        {
            string rtToaThuoc_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_ToaThuoc_Id", mvarKhamBenh_ToaThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTuToa", mvarSoThuTuToa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong", mvarSoLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgay", mvarSoNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLanTrenNgay", mvarSoLanTrenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongTrenLan", mvarSoLuongTrenLan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiSang", mvarSoLuong_BuoiSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiTrua", mvarSoLuong_BuoiTrua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiChieu", mvarSoLuong_BuoiChieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiToi", mvarSoLuong_BuoiToi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuongDung_Id", mvarDuongDung_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThu", mvarDonGiaDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTro", mvarDonGiaHoTro);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChiTra", mvarDonGiaHoTroChiTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyToaThuoc", mvarHuyToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhatSinhHoaDon", mvarPhatSinhHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@idx", mvaridx );
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia_Id", mvarLoaiGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonHang_id", mvarNguonHang_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhTien", mvarTinhTien);
            rtToaThuoc_Id = ThuVien.mySQL.ExcSP(SP_ToaThuoc, listPara, "@ToaThuoc_Id", SqlDbType.Int, 32);
            return rtToaThuoc_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuoc_Id", mvarToaThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_ToaThuoc_Id", mvarKhamBenh_ToaThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTuToa", mvarSoThuTuToa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong", mvarSoLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgay", mvarSoNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLanTrenNgay", mvarSoLanTrenNgay);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongTrenLan", mvarSoLuongTrenLan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiSang", mvarSoLuong_BuoiSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiTrua", mvarSoLuong_BuoiTrua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiChieu", mvarSoLuong_BuoiChieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong_BuoiToi", mvarSoLuong_BuoiToi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuongDung_Id", mvarDuongDung_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThu", mvarDonGiaDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTro", mvarDonGiaHoTro);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChiTra", mvarDonGiaHoTroChiTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyToaThuoc", mvarHuyToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhatSinhHoaDon", mvarPhatSinhHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@idx", mvaridx);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia_Id", mvarLoaiGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonHang_id", mvarNguonHang_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhTien", mvarTinhTien);
            ThuVien.mySQL.ExcSP(SP_ToaThuoc, listPara);
            return mvarToaThuoc_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@mvarToaThuoc_Id", mvarToaThuoc_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_ToaThuoc, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void GetToaThuoc(GridControl grv, String _toaThuoc)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_ToaThuoc_By_SoThuTuToa");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTuToa", _toaThuoc);

            Common.clsControl.LoadGirdControl_Y(grv, "sp_TOATHUOC", listPara);
        }
    }
}
