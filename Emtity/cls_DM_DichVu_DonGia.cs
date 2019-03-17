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
   public class cls_DM_DichVu_DonGia
    {
        #region "Constants"
        private const string SP_DM_DichVu_DonGia = "sp_DM_DICHVU_DONGIA";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarDichVu_DonGia_Id { get; set; }

        public System.Int32 mvarBangGia_Id { get; set; }

        public System.Int32 mvarDichVu_Id { get; set; }

        public System.Int32 mvarLoaiGia_Id { get; set; }

        public System.String mvarTienTe_Id { get; set; }

        public System.Decimal mvarDonGia { get; set; }

        public System.Decimal mvarDonGiaThapNhat { get; set; }

        public System.Decimal mvarDonGiaCaoNhat { get; set; }

        public System.Decimal mvarTyLeVAT { get; set; }

        public System.Decimal mvarGiaTriVAT { get; set; }

        public System.String mvarTrangThai { get; set; }

        public System.Boolean mvarTamNgung { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        #endregion

        private DataSet m_Dal;

        #region Contructor
        public cls_DM_DichVu_DonGia()
        {
            m_Dal = new DataSet();
            Reset();
        }

        #endregion

        public void Reset()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarDichVu_DonGia_Id = int.MinValue;
            mvarBangGia_Id = int.MinValue;
            mvarDichVu_Id = int.MinValue;
            mvarLoaiGia_Id = int.MinValue;
            mvarTienTe_Id = String.Empty;
            mvarDonGia = decimal.MinValue;
            mvarDonGiaThapNhat = decimal.MinValue;
            mvarDonGiaCaoNhat = decimal.MinValue;
            mvarTyLeVAT = decimal.MinValue;
            mvarGiaTriVAT = decimal.MinValue;
            mvarTrangThai = String.Empty;
            mvarTamNgung = false;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
        }
        public void FillData(DataRow row)
        {
            mvarDichVu_DonGia_Id = Common.clsControl.IsNullOrEmpty(row["DichVu_DonGia_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DichVu_DonGia_Id"]);
            mvarBangGia_Id = Common.clsControl.IsNullOrEmpty(row["BangGia_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BangGia_Id"]);
            mvarDichVu_Id = Common.clsControl.IsNullOrEmpty(row["DichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DichVu_Id"]);
            mvarLoaiGia_Id = Common.clsControl.IsNullOrEmpty(row["LoaiGia_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiGia_Id"]);
            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);
            mvarDonGia = Common.clsControl.IsNullOrEmpty(row["DonGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGia"]);
            mvarDonGiaThapNhat = Common.clsControl.IsNullOrEmpty(row["DonGiaThapNhat"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaThapNhat"]);
            mvarDonGiaCaoNhat = Common.clsControl.IsNullOrEmpty(row["DonGiaCaoNhat"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaCaoNhat"]);
            mvarTyLeVAT = Common.clsControl.IsNullOrEmpty(row["TyLeVAT"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyLeVAT"]);
            mvarGiaTriVAT = Common.clsControl.IsNullOrEmpty(row["GiaTriVAT"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["GiaTriVAT"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarTamNgung = Common.clsControl.getValueInRow<bool>(row["TamNgung"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
        }

        public string Add()
        {
            string rtDichVu_DonGia_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BangGia_Id", mvarBangGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", mvarDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia_Id", mvarLoaiGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGia", mvarDonGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThapNhat", mvarDonGiaThapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaCaoNhat", mvarDonGiaCaoNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeVAT", mvarTyLeVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVAT", mvarGiaTriVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TamNgung", mvarTamNgung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);

            rtDichVu_DonGia_Id = ThuVien.mySQL.ExcSP(SP_DM_DichVu_DonGia, listPara, "@DichVu_DonGia_Id", SqlDbType.Int, 32);
            return rtDichVu_DonGia_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_DonGia_Id", mvarDichVu_DonGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BangGia_Id", mvarBangGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", mvarDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiGia_Id", mvarLoaiGia_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGia", mvarDonGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaThapNhat", mvarDonGiaThapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaCaoNhat", mvarDonGiaCaoNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyLeVAT", mvarTyLeVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaTriVAT", mvarGiaTriVAT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TamNgung", mvarTamNgung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);

            ThuVien.mySQL.ExcSP(SP_DM_DichVu_DonGia, listPara);
            return mvarDichVu_DonGia_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_DonGia_Id", mvarDichVu_DonGia_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_DM_DichVu_DonGia, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public bool Get_By_GiaDV(int ID)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetGia_ByDichVu_Id");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", ID);
                ds = ThuVien.mySQL.ExcDataSet(SP_DM_DichVu_DonGia, listPara);
                Reset();
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
