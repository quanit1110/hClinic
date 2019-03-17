using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class cls_DangKyHoaDon
    {
        #region "Constants"
        private const string SP_DangKyHoaDonVAT = "SP_DangKyHoaDonVAT";
        #endregion

        # region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarDangKyHoaDon_Id { get; set; }

        public System.String mvarMachineName { get; set; }

        public System.String mvarLoaiHoaDon { get; set; }

        public System.DateTime mvarNgayPhatHanh { get; set; }

        public System.String mvarSoSeries { get; set; }

        public System.Int32 mvarMax_No { get; set; }

        public System.Int32 mvarNo_ { get; set; }

        public System.Boolean mvarHieuLuc { get; set; }

        public System.Boolean mvarTamNgung { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayTao { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_DangKyHoaDon()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_DangKyHoaDon(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_DangKyHoaDon(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_DangKyHoaDon(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = dal;
        }
        #endregion

        public string Add()
        {
            string rtDangKyHoaDon_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MachineName", mvarMachineName);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiHoaDon", mvarLoaiHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayPhatHanh", mvarNgayPhatHanh);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoSeries", mvarSoSeries);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Max_No", mvarMax_No);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@No_", mvarNo_);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HieuLuc", mvarHieuLuc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TamNgung", mvarTamNgung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);

            rtDangKyHoaDon_Id = ThuVien.mySQL.ExcSP(SP_DangKyHoaDonVAT, listPara, "@DangKyHoaDon_Id", SqlDbType.Int, 32);
            return rtDangKyHoaDon_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MachineName", mvarMachineName);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiHoaDon", mvarLoaiHoaDon);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayPhatHanh", mvarNgayPhatHanh);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoSeries", mvarSoSeries);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Max_No", mvarMax_No);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@No_", mvarNo_);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HieuLuc", mvarHieuLuc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TamNgung", mvarTamNgung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);

            ThuVien.mySQL.ExcSP(SP_DangKyHoaDonVAT, listPara);
            return mvarDangKyHoaDon_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DangKyHoaDon_Id", mvarDangKyHoaDon_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_DangKyHoaDonVAT, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public void Reset()
        {
            mvarLanguageId = String.Empty;

            mvarUserID = int.MinValue;

            mvarFreePara = String.Empty;

            mvarDangKyHoaDon_Id = int.MinValue;

            mvarMachineName = String.Empty;

            mvarLoaiHoaDon = String.Empty;

            mvarNgayPhatHanh = DateTime.MinValue;

            mvarSoSeries = String.Empty;

            mvarMax_No = int.MinValue;

            mvarNo_ = int.MinValue;

            mvarHieuLuc = false;

            mvarTamNgung = false;

            mvarNguoiTao_Id = int.MinValue;

            mvarNgayTao = DateTime.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarDangKyHoaDon_Id = Common.clsControl.IsNullOrEmpty(row["DangKyHoaDon_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DangKyHoaDon_Id"]);

            mvarMachineName = Common.clsControl.getValueInRow<string>(row["MachineName"]);

            mvarLoaiHoaDon = Common.clsControl.getValueInRow<string>(row["LoaiHoaDon"]);

            mvarNgayPhatHanh = Common.clsControl.IsNullOrEmpty(row["NgayPhatHanh"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayPhatHanh"]);

            mvarSoSeries = Common.clsControl.getValueInRow<string>(row["SoSeries"]);

            mvarMax_No = Common.clsControl.IsNullOrEmpty(row["Max_No"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Max_No"]);

            mvarNo_ = Common.clsControl.IsNullOrEmpty(row["No_"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["No_"]);

            mvarHieuLuc = Common.clsControl.IsNullOrEmpty(row["HieuLuc"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["HieuLuc"]);

            mvarTamNgung = Common.clsControl.IsNullOrEmpty(row["TamNgung"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["TamNgung"]);

            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);

            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
        }

    }
}
