using DevExpress.XtraGrid;
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
    public class cls_KhamBenh_ToaThuoc
    {
        #region "Constants"
        private const string SP_KhamBenh_ToaThuoc = "SP_KhamBenh_ToaThuoc";
        private const String SP_GetSoThuTuToa = "GetSoTangDan";
       
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarKhamBenh_ToaThuoc_Id { get; set; }

        public System.String mvarSoThuTuToa { get; set; }

        public System.String mvarLoaiToaThuoc { get; set; }

        public System.Int32 mvarKhamBenh_Id { get; set; }

        public System.Int32 mvarBacSi_Id { get; set; }

        public System.DateTime mvarNgayToaThuoc { get; set; }

        public System.DateTime mvarThoiGianToaThuoc { get; set; }

        public System.Boolean mvarHuyToaThuoc { get; set; }

        public System.String mvarGhiChu { get; set; }

        public System.Int32 mvarChungTuPhatThuoc_Id { get; set; }

        public System.String mvarTrangThai { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }

        public System.Int32 mvarKhoXuat_Id { get; set; }

        public System.String mvarDuyet { get; set; }

        public System.DateTime mvarNgayDuyet { get; set; }

        public System.DateTime mvarThoiGianDuyet { get; set; }

        public System.Int32 mvarNguoiDuyet_Id { get; set; }

        public System.DateTime mvarThoiGianTao { get; set; }
        #endregion
        private DataSet m_Dal;
        #region Contructor
        public cls_KhamBenh_ToaThuoc()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_KhamBenh_ToaThuoc(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_KhamBenh_ToaThuoc(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_KhamBenh_ToaThuoc(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarKhamBenh_ToaThuoc_Id = int.MinValue;
            mvarSoThuTuToa = String.Empty;
            mvarLoaiToaThuoc = String.Empty;
            mvarKhamBenh_Id = int.MinValue;
            mvarBacSi_Id = int.MinValue;
            mvarNgayToaThuoc = DateTime.MinValue;
            mvarThoiGianToaThuoc = DateTime.MinValue;
            mvarHuyToaThuoc = false;
            mvarGhiChu = String.Empty;
            mvarChungTuPhatThuoc_Id = int.MinValue;
            mvarTrangThai = String.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarKhoXuat_Id = int.MinValue;
            mvarDuyet = String.Empty;
            mvarNgayDuyet = DateTime.MinValue;
            mvarThoiGianDuyet = DateTime.MinValue;
            mvarNguoiDuyet_Id = int.MinValue;
            mvarThoiGianTao = DateTime.MinValue;
        }
        public void FillData(DataRow row)
        {
            mvarKhamBenh_ToaThuoc_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_ToaThuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_ToaThuoc_Id"]);
            mvarSoThuTuToa = Common.clsControl.getValueInRow<string>(row["SoThuTuToa"]);
            mvarLoaiToaThuoc = Common.clsControl.getValueInRow<string>(row["LoaiToaThuoc"]);
            mvarKhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_Id"]);
            mvarBacSi_Id = Common.clsControl.IsNullOrEmpty(row["BacSi_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSi_Id"]);
            mvarNgayToaThuoc = Common.clsControl.IsNullOrEmpty(row["NgayToaThuoc"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayToaThuoc"]);
            mvarThoiGianToaThuoc = Common.clsControl.IsNullOrEmpty(row["ThoiGianToaThuoc"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianToaThuoc"]);
            mvarHuyToaThuoc = Common.clsControl.getValueInRow<bool>(row["HuyToaThuoc"]);
            mvarGhiChu = Common.clsControl.getValueInRow<string>(row["GhiChu"]);
            mvarChungTuPhatThuoc_Id = Common.clsControl.IsNullOrEmpty(row["ChungTuPhatThuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTuPhatThuoc_Id"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarKhoXuat_Id = Common.clsControl.IsNullOrEmpty(row["KhoXuat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoXuat_Id"]);
            mvarDuyet = Common.clsControl.getValueInRow<string>(row["Duyet"]);
            mvarNgayDuyet = Common.clsControl.IsNullOrEmpty(row["NgayDuyet"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayDuyet"]);
            mvarThoiGianDuyet = Common.clsControl.IsNullOrEmpty(row["ThoiGianDuyet"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianDuyet"]);
            mvarNguoiDuyet_Id = Common.clsControl.IsNullOrEmpty(row["NguoiDuyet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiDuyet_Id"]);
            mvarThoiGianTao = Common.clsControl.IsNullOrEmpty(row["ThoiGianTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianTao"]);
        }

        public string Add() {
            string rtKhamBenh_ToaThuoc_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTuToa", mvarSoThuTuToa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiToaThuoc", mvarLoaiToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSi_Id", mvarBacSi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayToaThuoc", mvarNgayToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianToaThuoc", mvarThoiGianToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyToaThuoc", mvarHuyToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuPhatThuoc_Id", mvarChungTuPhatThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoXuat_Id", mvarKhoXuat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duyet", mvarDuyet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayDuyet", mvarNgayDuyet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianDuyet", mvarThoiGianDuyet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiDuyet_Id", mvarNguoiDuyet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTao", mvarThoiGianTao);
            rtKhamBenh_ToaThuoc_Id = ThuVien.mySQL.ExcSP(SP_KhamBenh_ToaThuoc, listPara, "@KhamBenh_ToaThuoc_Id", SqlDbType.Int, 32);
            return rtKhamBenh_ToaThuoc_Id;
        }
        public string Update()
        {

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_ToaThuoc_Id", mvarKhamBenh_ToaThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoThuTuToa", mvarSoThuTuToa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiToaThuoc", mvarLoaiToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSi_Id", mvarBacSi_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayToaThuoc", mvarNgayToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianToaThuoc", mvarThoiGianToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyToaThuoc", mvarHuyToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GhiChu", mvarGhiChu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChungTuPhatThuoc_Id", mvarChungTuPhatThuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoXuat_Id", mvarKhoXuat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duyet", mvarDuyet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayDuyet", mvarNgayDuyet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianDuyet", mvarThoiGianDuyet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiDuyet_Id", mvarNguoiDuyet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianTao", mvarThoiGianTao);

            ThuVien.mySQL.ExcSP(SP_KhamBenh_ToaThuoc, listPara);
            return mvarKhamBenh_ToaThuoc_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@mvarKhamBenh_ToaThuoc_Id", mvarKhamBenh_ToaThuoc_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_KhamBenh_ToaThuoc, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public string getSoThuTuToa()
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;
            string soThuTuToa = "";
            DataSet dt = new DataSet();

            try
            {
                using (cmd = new SqlCommand(SP_GetSoThuTuToa, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableName", "KhamBenh_ToaThuoc");
                cmd.Parameters.AddWithValue("@String_Id", DateTime.Now.ToString("yyMMdd"));
                var rs = cmd.Parameters.Add("@Values_Id", SqlDbType.Int);
                rs.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                soThuTuToa = Int32.Parse(rs.Value.ToString()).ToString(("D4"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }

            return DateTime.Now.ToString("yyMMdd") + soThuTuToa;
        }
        public void GetListBNChoNhanThuocBHYT(GridControl grv, DateTime dt)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_DSBenhNhanDuyetThuoc");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayToaThuoc", dt);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiToaThuoc","BV");
            Common.clsControl.LoadGirdControl_Y(grv, SP_KhamBenh_ToaThuoc, listPara);
        }
       
        public bool Get_By_Key(int khamBenhToaThuoc_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhToaThuoc_Id", khamBenhToaThuoc_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_KhamBenh_ToaThuoc, listPara);
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
        public bool Get_By_KhamBenh_Id(int khamBenh_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_By_KhamBenh_Id");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", khamBenh_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_KhamBenh_ToaThuoc, listPara);
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

        public DataTable GetToaThuoc_By_KBTT(int khamBenhToaThuoc_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Get_ToaThuoc_By_KhamBenh_ToaThuoc_Id");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_ToaThuoc_Id", khamBenhToaThuoc_Id);
            DataTable dt = new DataTable();
            return ThuVien.mySQL.ExcDataTable(SP_KhamBenh_ToaThuoc, listPara, dt);
        }
    }
}
