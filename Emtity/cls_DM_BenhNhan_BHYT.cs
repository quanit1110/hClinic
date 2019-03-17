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
    public class cls_DM_BenhNhan_BHYT
    {
        #region "Constants"
        private const String SP_DM_BenhNhan_BHYT = "SP_DM_BenhNhan_BHYT";
        #endregion
        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarBenhNhan_BHYT_Id { get; set; }

        public System.Int32 mvarBenhNhan_Id { get; set; }

        public System.String mvarSoThe { get; set; }

        public System.String mvarSoThe_TN { get; set; }

        public System.Int32 mvarLoaiBHYT { get; set; }

        public System.DateTime mvarNgayCap { get; set; }

        public System.DateTime mvarNgayHieuLuc { get; set; }

        public System.DateTime mvarNgayHetHieuLuc { get; set; }

        public System.DateTime mvarNgayCap_TN { get; set; }

        public System.DateTime mvarNgayHieuLuc_TN { get; set; }

        public System.DateTime mvarNgayHetHieuLuc_TN { get; set; }

        public System.Int32 mvarTinhThanh_CapThe_Id { get; set; }

        public System.Int32 mvarBenhVien_KCB_Id { get; set; }

        public System.Boolean mvarTamNgung { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarBenhVien_KCB_Id_TN { get; set; }

        public System.Int32 mvarCongty_Id { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }

        public System.Boolean mvarTren3Nam { get; set; }
        public System.Boolean mvarTren6Thang { get; set; }
        #endregion
        private DataSet m_Dal;
        #region Contructor
        public cls_DM_BenhNhan_BHYT()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_DM_BenhNhan_BHYT(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_DM_BenhNhan_BHYT(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_DM_BenhNhan_BHYT(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = dal;
        }
        #endregion
        public string Add()
        {
            string rtBenhNhanBHYT_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThe", mvarSoThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThe_TN", mvarSoThe_TN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiBHYT", mvarLoaiBHYT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCap", mvarNgayCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHieuLuc", mvarNgayHieuLuc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHetHieuLuc", mvarNgayHetHieuLuc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCap_TN", mvarNgayCap_TN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHieuLuc_TN", mvarNgayHieuLuc_TN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHetHieuLuc_TN", mvarNgayHetHieuLuc_TN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh_CapThe_Id", mvarTinhThanh_CapThe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhVien_KCB_Id", mvarBenhVien_KCB_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TamNgung", mvarTamNgung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhVien_KCB_Id_TN", mvarBenhVien_KCB_Id_TN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Congty_Id", mvarCongty_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Tren3Nam", mvarTren3Nam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Tren6Thang", mvarTren6Thang);

            rtBenhNhanBHYT_Id = ThuVien.mySQL.ExcSP(SP_DM_BenhNhan_BHYT, listPara, "@BenhNhan_BHYT_Id", SqlDbType.Int, 32);
            return rtBenhNhanBHYT_Id;
        }
        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_BHYT_Id", mvarBenhNhan_BHYT_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", mvarBenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThe", mvarSoThe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThe_TN", mvarSoThe_TN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiBHYT", mvarLoaiBHYT);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCap", mvarNgayCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHieuLuc", mvarNgayHieuLuc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHetHieuLuc", mvarNgayHetHieuLuc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCap_TN", mvarNgayCap_TN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHieuLuc_TN", mvarNgayHieuLuc_TN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHetHieuLuc_TN", mvarNgayHetHieuLuc_TN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanh_CapThe_Id", mvarTinhThanh_CapThe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhVien_KCB_Id", mvarBenhVien_KCB_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TamNgung", mvarTamNgung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhVien_KCB_Id_TN", mvarBenhVien_KCB_Id_TN);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Congty_Id", mvarCongty_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Tren3Nam", mvarTren3Nam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Tren6Thang", mvarTren6Thang);

            ThuVien.mySQL.ExcSP(SP_DM_BenhNhan_BHYT, listPara);
            return mvarBenhNhan_BHYT_Id.ToString() ;
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_BHYT_Id", mvarBenhNhan_BHYT_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_DM_BenhNhan_BHYT, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void Reset()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarBenhNhan_BHYT_Id = int.MinValue;
            mvarBenhNhan_Id = int.MinValue;
            mvarSoThe = String.Empty;
            mvarLoaiBHYT = int.MinValue;
            mvarNgayCap = DateTime.MinValue;
            mvarNgayHieuLuc = DateTime.MinValue;
            mvarNgayHetHieuLuc = DateTime.MinValue;
            mvarTinhThanh_CapThe_Id = int.MinValue;
            mvarBenhVien_KCB_Id = int.MinValue;
            mvarTamNgung = false;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarTren3Nam = false;
            mvarTren6Thang = false;
            mvarNgayCap_TN = DateTime.MinValue;
            mvarNgayHieuLuc_TN = DateTime.MinValue;
            mvarNgayHetHieuLuc_TN = DateTime.MinValue;
            mvarSoThe_TN = String.Empty;
            mvarBenhVien_KCB_Id_TN = int.MinValue;
            mvarCongty_Id = int.MinValue;
        }
        public void FillData(DataRow row)
        {
            mvarBenhNhan_BHYT_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_BHYT_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_BHYT_Id"]);
            mvarBenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarSoThe = Common.clsControl.getValueInRow<string>(row["SoThe"]);
            mvarLoaiBHYT = Common.clsControl.IsNullOrEmpty(row["LoaiBHYT"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiBHYT"]);
            mvarNgayCap = Common.clsControl.IsNullOrEmpty(row["NgayCap"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCap"]);
            mvarNgayHieuLuc = Common.clsControl.IsNullOrEmpty(row["NgayHieuLuc"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHieuLuc"]);
            mvarNgayHetHieuLuc = Common.clsControl.IsNullOrEmpty(row["NgayHetHieuLuc"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHetHieuLuc"]);
            mvarTinhThanh_CapThe_Id = Common.clsControl.IsNullOrEmpty(row["TinhThanh_CapThe_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TinhThanh_CapThe_Id"]);
            mvarBenhVien_KCB_Id = Common.clsControl.IsNullOrEmpty(row["BenhVien_KCB_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhVien_KCB_Id"]);
            mvarTamNgung = Common.clsControl.IsNullOrEmpty(row["TamNgung"].ToString().ToArray()) ? false: Common.clsControl.getValueInRow<bool>(row["TamNgung"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarTren3Nam = Common.clsControl.IsNullOrEmpty(row["Tren3Nam"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Tren3Nam"]);
            mvarTren6Thang = Common.clsControl.IsNullOrEmpty(row["Tren6Thang"].ToString().ToArray()) ? false : Common.clsControl.getValueInRow<bool>(row["Tren6Thang"]);
            mvarCongty_Id = Common.clsControl.IsNullOrEmpty(row["Congty_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Congty_Id"]);
            mvarSoThe_TN = Common.clsControl.getValueInRow<string>(row["SoThe_TN"]);
            
            mvarBenhVien_KCB_Id_TN = Common.clsControl.IsNullOrEmpty(row["BenhVien_KCB_Id_TN"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhVien_KCB_Id_TN"]);
            mvarNgayCap_TN = Common.clsControl.IsNullOrEmpty(row["NgayCap_TN"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCap_TN"]);
            mvarNgayHieuLuc_TN = Common.clsControl.IsNullOrEmpty(row["NgayHieuLuc_TN"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHieuLuc_TN"]);
            mvarNgayHetHieuLuc_TN = Common.clsControl.IsNullOrEmpty(row["NgayHetHieuLuc_TN"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHetHieuLuc_TN"]);
            try { mvarFreePara = Common.clsControl.getValueInRow<string>(row["FreePara"]); } catch { };
        }
        public bool Get_By_BHYT(string strBH)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByBHYT");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@FreePara", strBH);
                ds = ThuVien.mySQL.ExcDataSet(SP_DM_BenhNhan_BHYT, listPara);
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
        public bool Get_By_BenhNhan_Id(int BenhNhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetByBenhNhan_Id");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhNhan_Id", BenhNhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_DM_BenhNhan_BHYT, listPara);
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
