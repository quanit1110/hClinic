using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    class ChungTuXuatBenhNhan
    {
        #region "Constants"
        private const string sp_CHUNGTUXUATBENHNHAN = "sp_CHUNGTUXUATBENHNHAN";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarChungTuXuatBN_Id { get; set; }
        public System.Int32 mvarChungTuChiTiet_Id { get; set; }
        public System.Int32 mvarBenhAnPhauThuat_VTYT_ID { get; set; }
        public System.Int32 mvarToaThuoc_Id { get; set; }
        public System.Int32 mvarBenhAn_Id { get; set; }
        public System.Int32 mvarDuoc_Id { get; set; }
        public System.Int32 mvarSoLoNhap_Id { get; set; }
        public System.Int32 mvarNguonHang_Id { get; set; }
        public System.Decimal mvarSoLuong { get; set; }
        public System.Decimal mvarDonGiaVon { get; set; }
        public System.Decimal mvarDonGiaMua { get; set; }
        public System.Decimal mvarDonGiaHoTro { get; set; }
        public System.Decimal mvarDonGiaHoTroChiTra { get; set; }
        public System.Decimal mvarDonGiaThanhToan { get; set; }
        public System.Decimal mvarDonGiaDoanhThu { get; set; }
        public System.Int32 mvarToaThuocNgoaiTru_id { get; set; }
        public System.Int32 mvarTiepNhan_id { get; set; }
        public System.Int32 mvarToaThuocTra_Id { get; set; }
        public System.Int32 mvarCLSHoaChat_VTYT_Id { get; set; }
        public System.Boolean mvarPhatSinhHoaDon { get; set; }
        public System.String mvarLoai_IDRef { get; set; }
        public System.Int32 mvarIDRef { get; set; }
        public System.Decimal mvarGiaTriMienGiam { get; set; }
        public System.Decimal mvarGiaTriThatThu { get; set; }
        public System.Decimal mvarGiaTriDaThanhToan { get; set; }
        public System.Boolean mvarDaThanhToan_MotPhan { get; set; }
        public System.Boolean mvarDaThanhToan_HoanTat { get; set; }
        public System.Decimal mvarDonGiaChenhLech { get; set; }
        public System.Decimal mvarDonGiaHoTroChenhLech { get; set; }
        public System.Decimal mvarGiaTriDaThanhToan_ChenhLech { get; set; }
        public System.Decimal mvarGiaTriDaThanhToan_HoTroChenhLech { get; set; }

        #endregion
        private DataSet m_Dal;

        #region Contructor
        public ChungTuXuatBenhNhan()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public ChungTuXuatBenhNhan(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public ChungTuXuatBenhNhan(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public ChungTuXuatBenhNhan(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = dal;
        }

        #endregion

        public void ReSet()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarChungTuXuatBN_Id = int.MinValue;
            mvarChungTuChiTiet_Id = int.MinValue;
            mvarBenhAnPhauThuat_VTYT_ID = int.MinValue;
            mvarToaThuoc_Id = int.MinValue;
            mvarBenhAn_Id = int.MinValue;
            mvarDuoc_Id = int.MinValue;
            mvarSoLoNhap_Id = int.MinValue;
            mvarNguonHang_Id = int.MinValue;
            mvarSoLuong = decimal.MinValue;
            mvarDonGiaVon = decimal.MinValue;
            mvarDonGiaMua = decimal.MinValue;
            mvarDonGiaHoTro = decimal.MinValue;
            mvarDonGiaHoTroChiTra = decimal.MinValue;
            mvarDonGiaThanhToan = decimal.MinValue;
            mvarDonGiaDoanhThu = decimal.MinValue;
            mvarToaThuocNgoaiTru_id = int.MinValue;
            mvarTiepNhan_id = int.MinValue;
            mvarToaThuocTra_Id = int.MinValue;
            mvarCLSHoaChat_VTYT_Id = int.MinValue;
            mvarPhatSinhHoaDon = false;
            mvarLoai_IDRef = String.Empty;
            mvarIDRef = int.MinValue;
            mvarGiaTriMienGiam = decimal.MinValue;
            mvarGiaTriThatThu = decimal.MinValue;
            mvarGiaTriDaThanhToan = decimal.MinValue;
            mvarDaThanhToan_MotPhan = false;
            mvarDaThanhToan_HoanTat = false;
            mvarDonGiaChenhLech = decimal.MinValue;
            mvarDonGiaHoTroChenhLech = decimal.MinValue;
            mvarGiaTriDaThanhToan_ChenhLech = decimal.MinValue;
            mvarGiaTriDaThanhToan_HoTroChenhLech = decimal.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarChungTuXuatBN_Id = Common.clsControl.IsNullOrEmpty(row["ChungTuXuatBN_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTuXuatBN_Id"]);
            mvarChungTuChiTiet_Id = Common.clsControl.IsNullOrEmpty(row["ChungTuChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTuChiTiet_Id"]);
            mvarBenhAnPhauThuat_VTYT_ID = Common.clsControl.IsNullOrEmpty(row["BenhAnPhauThuat_VTYT_ID"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAnPhauThuat_VTYT_ID"]);
            mvarToaThuoc_Id = Common.clsControl.IsNullOrEmpty(row["ToaThuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ToaThuoc_Id"]);
            mvarBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["BenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAn_Id"]);
            mvarDuoc_Id = Common.clsControl.IsNullOrEmpty(row["Duoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Duoc_Id"]);
            mvarSoLoNhap_Id = Common.clsControl.IsNullOrEmpty(row["SoLoNhap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoLoNhap_Id"]);
            mvarNguonHang_Id = Common.clsControl.IsNullOrEmpty(row["NguonHang_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguonHang_Id"]);
            mvarSoLuong = Common.clsControl.IsNullOrEmpty(row["SoLuong"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuong"]);
            mvarDonGiaVon = Common.clsControl.IsNullOrEmpty(row["DonGiaVon"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaVon"]);
            mvarDonGiaMua = Common.clsControl.IsNullOrEmpty(row["DonGiaMua"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaMua"]);
            mvarDonGiaHoTro = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTro"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTro"]);
            mvarDonGiaHoTroChiTra = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTroChiTra"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTroChiTra"]);
            mvarDonGiaThanhToan = Common.clsControl.IsNullOrEmpty(row["DonGiaThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaThanhToan"]);
            mvarDonGiaDoanhThu = Common.clsControl.IsNullOrEmpty(row["DonGiaDoanhThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaDoanhThu"]);
            mvarToaThuocNgoaiTru_id = Common.clsControl.IsNullOrEmpty(row["ToaThuocNgoaiTru_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ToaThuocNgoaiTru_id"]);
            mvarTiepNhan_id = Common.clsControl.IsNullOrEmpty(row["TiepNhan_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhan_id"]);
            mvarToaThuocTra_Id = Common.clsControl.IsNullOrEmpty(row["ToaThuocTra_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ToaThuocTra_Id"]);
            mvarCLSHoaChat_VTYT_Id = Common.clsControl.IsNullOrEmpty(row["CLSHoaChat_VTYT_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CLSHoaChat_VTYT_Id"]);
            mvarPhatSinhHoaDon = Common.clsControl.getValueInRow<bool>(row["PhatSinhHoaDon"]);
            mvarLoai_IDRef = Common.clsControl.getValueInRow<string>(row["Loai_IDRef"]);
            mvarIDRef = Common.clsControl.IsNullOrEmpty(row["IDRef"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["IDRef"]);
            mvarGiaTriMienGiam = Common.clsControl.IsNullOrEmpty(row["GiaTriMienGiam"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriMienGiam"]);
            mvarGiaTriThatThu = Common.clsControl.IsNullOrEmpty(row["GiaTriThatThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriThatThu"]);
            mvarGiaTriDaThanhToan = Common.clsControl.IsNullOrEmpty(row["GiaTriDaThanhToan"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriDaThanhToan"]);
            mvarDaThanhToan_MotPhan = Common.clsControl.getValueInRow<bool>(row["DaThanhToan_MotPhan"]);
            mvarDaThanhToan_HoanTat = Common.clsControl.getValueInRow<bool>(row["DaThanhToan_HoanTat"]);
            mvarDonGiaChenhLech = Common.clsControl.IsNullOrEmpty(row["DonGiaChenhLech"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaChenhLech"]);
            mvarDonGiaHoTroChenhLech = Common.clsControl.IsNullOrEmpty(row["DonGiaHoTroChenhLech"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHoTroChenhLech"]);
            mvarGiaTriDaThanhToan_ChenhLech = Common.clsControl.IsNullOrEmpty(row["GiaTriDaThanhToan_ChenhLech"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriDaThanhToan_ChenhLech"]);
            mvarGiaTriDaThanhToan_HoTroChenhLech = Common.clsControl.IsNullOrEmpty(row["GiaTriDaThanhToan_HoTroChenhLech"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriDaThanhToan_HoTroChenhLech"]);


        }
        public string Add()
        {
            string rtQD_HoTroChiPhiNoiTru_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuChiTiet_Id", mvarChungTuChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAnPhauThuat_VTYT_ID", mvarBenhAnPhauThuat_VTYT_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuoc_Id", mvarToaThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLoNhap_Id", mvarSoLoNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonHang_Id", mvarNguonHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong", mvarSoLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaVon", mvarDonGiaVon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaMua", mvarDonGiaMua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTro", mvarDonGiaHoTro);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChiTra", mvarDonGiaHoTroChiTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThu", mvarDonGiaDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuocNgoaiTru_id", mvarToaThuocNgoaiTru_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_id", mvarTiepNhan_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuocTra_Id", mvarToaThuocTra_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSHoaChat_VTYT_Id", mvarCLSHoaChat_VTYT_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhatSinhHoaDon", mvarPhatSinhHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Loai_IDRef", mvarLoai_IDRef);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDRef", mvarIDRef);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriMienGiam", mvarGiaTriMienGiam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThatThu", mvarGiaTriThatThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriDaThanhToan", mvarGiaTriDaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan_MotPhan", mvarDaThanhToan_MotPhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan_HoanTat", mvarDaThanhToan_HoanTat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaChenhLech", mvarDonGiaChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChenhLech", mvarDonGiaHoTroChenhLech);

            rtQD_HoTroChiPhiNoiTru_Id = ThuVien.mySQL.ExcSP(sp_CHUNGTUXUATBENHNHAN, listPara, "@ChungTuXuatBN_Id", SqlDbType.Int, 32);
            return rtQD_HoTroChiPhiNoiTru_Id;
        }
        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuXuatBN_Id", mvarChungTuXuatBN_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuChiTiet_Id", mvarChungTuChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAnPhauThuat_VTYT_ID", mvarBenhAnPhauThuat_VTYT_ID);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuoc_Id", mvarToaThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLoNhap_Id", mvarSoLoNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonHang_Id", mvarNguonHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuong", mvarSoLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaVon", mvarDonGiaVon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaMua", mvarDonGiaMua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTro", mvarDonGiaHoTro);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChiTra", mvarDonGiaHoTroChiTra);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThanhToan", mvarDonGiaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDoanhThu", mvarDonGiaDoanhThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuocNgoaiTru_id", mvarToaThuocNgoaiTru_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_id", mvarTiepNhan_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ToaThuocTra_Id", mvarToaThuocTra_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSHoaChat_VTYT_Id", mvarCLSHoaChat_VTYT_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhatSinhHoaDon", mvarPhatSinhHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Loai_IDRef", mvarLoai_IDRef);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@IDRef", mvarIDRef);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriMienGiam", mvarGiaTriMienGiam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriThatThu", mvarGiaTriThatThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriDaThanhToan", mvarGiaTriDaThanhToan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan_MotPhan", mvarDaThanhToan_MotPhan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThanhToan_HoanTat", mvarDaThanhToan_HoanTat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaChenhLech", mvarDonGiaChenhLech);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHoTroChenhLech", mvarDonGiaHoTroChenhLech);
            ThuVien.mySQL.ExcSP(sp_CHUNGTUXUATBENHNHAN, listPara);
            return mvarChungTuXuatBN_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuXuatBN_Id", mvarChungTuXuatBN_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_CHUNGTUXUATBENHNHAN, listPara);
            if (rt == "err") { return false; }
            return true;
        }
    }
}
