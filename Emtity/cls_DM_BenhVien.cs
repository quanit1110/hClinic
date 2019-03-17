using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class cls_DM_BenhVien
    {
        #region "Constants"
        private const String SP_DM_BenhVien = "SP_DM_BenhVien";
        #endregion
        #region "Member Variable"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarBenhVien_Id { get; set; }

        public System.String mvarMaBenhVien { get; set; }

        public System.String mvarTenBenhVien { get; set; }

        public System.String mvarTenBenhVien_En { get; set; }

        public System.String mvarTenBenhVien_Ru { get; set; }

        public System.String mvarDiaChi { get; set; }

        public System.Int32 mvarHang_Id { get; set; }

        public System.Int32 mvarLoai_Id { get; set; }

        public System.Int32 mvarTuyen_Id { get; set; }

        public System.Int32 mvarCapQuanLy_Id { get; set; }

        public System.Int32 mvarTinhThanhPho_Id { get; set; }

        public System.Boolean mvarTamNgung { get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        #endregion
        private DataSet m_Dal;
        #region Contructor
        public cls_DM_BenhVien()
        {
            m_Dal = new DataSet();
            Reset();
        }
        public cls_DM_BenhVien(DataSet dal)
        {
            m_Dal = dal;
            Reset();
        }
        public cls_DM_BenhVien(string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = new DataSet();
        }
        public cls_DM_BenhVien(DataSet dal, string pLanguageId, Int32 pUserId)
        {
            Reset();
            mvarLanguageId = pLanguageId;
            mvarUserID = pUserId;
            m_Dal = dal;
        }
        #endregion
        public string Add()
        {
            string rtBenhVien_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaBenhVien", mvarMaBenhVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhVien", mvarTenBenhVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhVien_En", mvarTenBenhVien_En);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhVien_Ru", mvarTenBenhVien_Ru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Hang_Id", mvarHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Loai_Id", mvarLoai_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Tuyen_Id", mvarTuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CapQuanLy_Id", mvarCapQuanLy_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanhPho_Id", mvarTinhThanhPho_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TamNgung", mvarTamNgung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            rtBenhVien_Id= ThuVien.mySQL.ExcSP(SP_DM_BenhVien, listPara, "@BenhVien_Id", SqlDbType.Int, 32);
            return rtBenhVien_Id;
        }
        public string Update()
        {
            string rtBenhVien_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaBenhVien", mvarMaBenhVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhVien", mvarTenBenhVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhVien_En", mvarTenBenhVien_En);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenBenhVien_Ru", mvarTenBenhVien_Ru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Hang_Id", mvarHang_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Loai_Id", mvarLoai_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Tuyen_Id", mvarTuyen_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CapQuanLy_Id", mvarCapQuanLy_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhThanhPho_Id", mvarTinhThanhPho_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TamNgung", mvarTamNgung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            rtBenhVien_Id = ThuVien.mySQL.ExcSP(SP_DM_BenhVien, listPara, "@BenhVien_Id", SqlDbType.Int, 32);
            return rtBenhVien_Id;
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhVien_Id", mvarBenhVien_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_DM_BenhVien, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void Reset()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarBenhVien_Id = int.MinValue;
            mvarMaBenhVien = String.Empty;
            mvarTenBenhVien = String.Empty;
            mvarTenBenhVien_En = String.Empty;
            mvarTenBenhVien_Ru = String.Empty;
            mvarDiaChi = String.Empty;
            mvarHang_Id = int.MinValue;
            mvarLoai_Id = int.MinValue;
            mvarTuyen_Id = int.MinValue;
            mvarCapQuanLy_Id = int.MinValue;
            mvarTinhThanhPho_Id = int.MinValue;
            mvarTamNgung = false;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
        }
        public void FillData(DataRow row)
        {
            mvarBenhVien_Id = Common.clsControl.IsNullOrEmpty(row["BenhVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhNhan_Id"]);
            mvarMaBenhVien = Common.clsControl.getValueInRow<string>(row["MaBenhVien"]);
            mvarTenBenhVien = Common.clsControl.getValueInRow<string>(row["TenBenhVien"]);
            mvarTenBenhVien_En = Common.clsControl.getValueInRow<string>(row["TenBenhVien_En"]);
            mvarTenBenhVien_Ru = Common.clsControl.getValueInRow<string>(row["TenBenhVien_Ru"]);
            mvarDiaChi = Common.clsControl.getValueInRow<string>(row["DiaChi"]);
            mvarHang_Id = Common.clsControl.IsNullOrEmpty(row["Hang_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhomMau_Id"]);
            mvarLoai_Id = Common.clsControl.IsNullOrEmpty(row["Loai_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["YeuToRh_Id"]);
            mvarTuyen_Id = Common.clsControl.IsNullOrEmpty(row["Tuyen_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["QuocTich_Id"]);
            mvarCapQuanLy_Id = Common.clsControl.IsNullOrEmpty(row["CapQuanLy_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TinhThanh_Id"]);
            mvarTinhThanhPho_Id = Common.clsControl.IsNullOrEmpty(row["TinhThanhPho_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["QuanHuyen_Id"]);
            mvarTamNgung = Common.clsControl.getValueInRow<bool>(row["TamNgung"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
        }
        public Boolean GetByKey(Int32 BenhVien_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhVien_Id", BenhVien_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_DM_BenhVien, listPara);
                Reset();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FillData(ds.Tables[0].Rows[0]);
                    return true;
                }
            }
            catch { return false; }
            return false;
        }

    }
}
