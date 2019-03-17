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
   public class ChungTuSoLoNhap
    {
        #region "Constants"
        private const string sp_CHUNGTUSOLONHAP = "sp_CHUNGTUSOLONHAP";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarSoLoNhap_Id { get; set; }
        public System.String mvarSoLoNhap { get; set; }
        public System.Int32 mvarDuoc_Id { get; set; }
        public System.DateTime mvarNgayNhap { get; set; }
        public System.DateTime mvarHanSuDung { get; set; }
        public System.Int32 mvarNguonDuoc_Id { get; set; }
        public System.Decimal mvarDonGiaMua { get; set; }
        public System.Decimal mvarDonGiaVon { get; set; }
        public System.String mvarTienTe_Id { get; set; }
        public System.Decimal mvarTyGia { get; set; }
        public System.Int32 mvarThang { get; set; }
        public System.Int32 mvarNam { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.String mvarSoKiemSoat { get; set; }
        public System.String mvarSoVisa { get; set; }
        public System.Int32 mvarNguonHang_Id { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public ChungTuSoLoNhap()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public ChungTuSoLoNhap(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public ChungTuSoLoNhap(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public ChungTuSoLoNhap(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarSoLoNhap_Id = int.MinValue;
            mvarSoLoNhap = String.Empty;
            mvarDuoc_Id = int.MinValue;
            mvarNgayNhap = DateTime.MinValue;
            mvarHanSuDung = DateTime.MinValue;
            mvarNguonDuoc_Id = int.MinValue;
            mvarDonGiaMua = decimal.MinValue;
            mvarDonGiaVon = decimal.MinValue;
            mvarTienTe_Id = String.Empty;
            mvarTyGia = decimal.MinValue;
            mvarThang = int.MinValue;
            mvarNam = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarSoKiemSoat = String.Empty;
            mvarSoVisa = String.Empty;
            mvarNguonHang_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarSoLoNhap_Id = Common.clsControl.IsNullOrEmpty(row["SoLoNhap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoLoNhap_Id"]);
            mvarSoLoNhap = Common.clsControl.getValueInRow<string>(row["SoLoNhap"]);
            mvarDuoc_Id = Common.clsControl.IsNullOrEmpty(row["Duoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Duoc_Id"]);
            mvarNgayNhap = Common.clsControl.IsNullOrEmpty(row["NgayNhap"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayNhap"]);
            mvarHanSuDung = Common.clsControl.IsNullOrEmpty(row["HanSuDung"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["HanSuDung"]);
            mvarNguonDuoc_Id = Common.clsControl.IsNullOrEmpty(row["NguonDuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguonDuoc_Id"]);
            mvarDonGiaMua = Common.clsControl.IsNullOrEmpty(row["DonGiaMua"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaMua"]);
            mvarDonGiaVon = Common.clsControl.IsNullOrEmpty(row["DonGiaVon"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaVon"]);
            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);
            mvarTyGia = Common.clsControl.IsNullOrEmpty(row["TyGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyGia"]);
            mvarThang = Common.clsControl.IsNullOrEmpty(row["Thang"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Thang"]);
            mvarNam = Common.clsControl.IsNullOrEmpty(row["Nam"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Nam"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarSoKiemSoat = Common.clsControl.getValueInRow<string>(row["SoKiemSoat"]);
            mvarSoVisa = Common.clsControl.getValueInRow<string>(row["SoVisa"]);
            mvarNguonHang_Id = Common.clsControl.IsNullOrEmpty(row["NguonHang_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguonHang_Id"]);
        }
        public string Add()
        {
            string rtSoLoNhap_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLoNhap", mvarSoLoNhap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNhap", mvarNgayNhap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HanSuDung", mvarHanSuDung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonDuoc_Id", mvarNguonDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaMua", mvarDonGiaMua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaVon", mvarDonGiaVon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Thang", mvarThang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Nam", mvarNam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoKiemSoat", mvarSoKiemSoat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoVisa", mvarSoVisa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonHang_Id", mvarNguonHang_Id);

            rtSoLoNhap_Id = ThuVien.mySQL.ExcSP(sp_CHUNGTUSOLONHAP, listPara, "@SoLoNhap_Id", SqlDbType.Int, 32);
            return rtSoLoNhap_Id;
        }
        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLoNhap_Id", mvarSoLoNhap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLoNhap", mvarSoLoNhap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNhap", mvarNgayNhap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HanSuDung", mvarHanSuDung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonDuoc_Id", mvarNguonDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaMua", mvarDonGiaMua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaVon", mvarDonGiaVon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Thang", mvarThang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Nam", mvarNam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoKiemSoat", mvarSoKiemSoat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoVisa", mvarSoVisa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguonHang_Id", mvarNguonHang_Id);

            ThuVien.mySQL.ExcSP(sp_CHUNGTUSOLONHAP, listPara);
            return mvarSoLoNhap_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLoNhap_Id", mvarSoLoNhap_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_CHUNGTUSOLONHAP, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public bool Get_By_Key(int soLo_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLoNhap_Id", soLo_Id);
                ds = ThuVien.mySQL.ExcDataSet(sp_CHUNGTUSOLONHAP, listPara);
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
