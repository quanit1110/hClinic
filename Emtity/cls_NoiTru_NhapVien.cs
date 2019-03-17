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
    public class cls_NoiTru_NhapVien
    {
        #region "Constants"
        private const string sp_NOITRU_NHAPVIEN = "sp_NOITRU_NHAPVIEN";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarNhapVien_Id { get; set; }
        public System.Int32 mvarTiepNhan_Id { get; set; }
        public System.DateTime mvarNgayNhapVien { get; set; }
        public System.DateTime mvarThoiGianNhapVien { get; set; }
        public System.Int32 mvarNoiNhapVien_Id { get; set; }
        public System.Int32 mvarBacSiChiDinh_Id { get; set; }
        public System.Int32 mvarLyDoNhapVien_Id { get; set; }
        public System.Int32 mvarKhoaDieuTri_Id { get; set; }
        public System.Int32 mvarBenhAn_Id { get; set; }
        public System.String mvarChanDoan { get; set; }
        public System.Int32 mvarICD_ChanDoan { get; set; }
        public System.String mvarTrangThai { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.Int32 mvarKhamBenh_Id { get; set; }
        public System.Boolean mvarCapCuu { get; set; }
        public System.Int32 mvarLoaiBenhAn_Id { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_NoiTru_NhapVien()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_NoiTru_NhapVien(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_NoiTru_NhapVien(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_NoiTru_NhapVien(DataSet dal, string pLanguageId, Int32 pUserId)
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

            mvarNhapVien_Id = int.MinValue;
            mvarTiepNhan_Id = int.MinValue;
            mvarNgayNhapVien = DateTime.MinValue;
            mvarThoiGianNhapVien = DateTime.MinValue;
            mvarNoiNhapVien_Id = int.MinValue;
            mvarBacSiChiDinh_Id = int.MinValue;
            mvarLyDoNhapVien_Id = int.MinValue;
            mvarKhoaDieuTri_Id = int.MinValue;
            mvarBenhAn_Id = int.MinValue;
            mvarChanDoan = String.Empty;
            mvarICD_ChanDoan = int.MinValue;
            mvarTrangThai = String.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarKhamBenh_Id = int.MinValue;
            mvarCapCuu = false;
            mvarLoaiBenhAn_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarNhapVien_Id = Common.clsControl.IsNullOrEmpty(row["NhapVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhapVien_Id"]);
            mvarTiepNhan_Id = Common.clsControl.IsNullOrEmpty(row["TiepNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TiepNhan_Id"]);
            mvarNgayNhapVien = Common.clsControl.IsNullOrEmpty(row["NgayNhapVien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayNhapVien"]);
            mvarThoiGianNhapVien = Common.clsControl.IsNullOrEmpty(row["ThoiGianNhapVien"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianNhapVien"]);
            mvarNoiNhapVien_Id = Common.clsControl.IsNullOrEmpty(row["NoiNhapVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NoiNhapVien_Id"]);
            mvarBacSiChiDinh_Id = Common.clsControl.IsNullOrEmpty(row["BacSiChiDinh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BacSiChiDinh_Id"]);
            mvarLyDoNhapVien_Id = Common.clsControl.IsNullOrEmpty(row["LyDoNhapVien_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LyDoNhapVien_Id"]);
            mvarKhoaDieuTri_Id = Common.clsControl.IsNullOrEmpty(row["KhoaDieuTri_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoaDieuTri_Id"]);
            mvarBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["BenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAn_Id"]);
            mvarChanDoan = Common.clsControl.getValueInRow<string>(row["ChanDoan"]);
            mvarICD_ChanDoan = Common.clsControl.IsNullOrEmpty(row["ICD_ChanDoan"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ICD_ChanDoan"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarKhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_Id"]);
            mvarCapCuu = Common.clsControl.getValueInRow<bool>(row["CapCuu"]);
            mvarLoaiBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["LoaiBenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LoaiBenhAn_Id"]);
        }
        public string Add()
        {
            string rtNhapVien_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNhapVien", mvarNgayNhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianNhapVien", mvarThoiGianNhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiNhapVien_Id", mvarNoiNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiChiDinh_Id", mvarBacSiChiDinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoNhapVien_Id", mvarLyDoNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaDieuTri_Id", mvarKhoaDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoan", mvarChanDoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_ChanDoan", mvarICD_ChanDoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CapCuu", mvarCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiBenhAn_Id", mvarLoaiBenhAn_Id);

            rtNhapVien_Id = ThuVien.mySQL.ExcSP(sp_NOITRU_NHAPVIEN, listPara, "@NhapVien_Id", SqlDbType.Int, 32);
            return rtNhapVien_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhapVien_Id", mvarNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", mvarTiepNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayNhapVien", mvarNgayNhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianNhapVien", mvarThoiGianNhapVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NoiNhapVien_Id", mvarNoiNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BacSiChiDinh_Id", mvarBacSiChiDinh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoNhapVien_Id", mvarLyDoNhapVien_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaDieuTri_Id", mvarKhoaDieuTri_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoan", mvarChanDoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ICD_ChanDoan", mvarICD_ChanDoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CapCuu", mvarCapCuu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiBenhAn_Id", mvarLoaiBenhAn_Id);

            ThuVien.mySQL.ExcSP(sp_NOITRU_NHAPVIEN, listPara);
            return mvarNhapVien_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhapVien_Id", mvarNhapVien_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_NOITRU_NHAPVIEN, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public bool Get_By_TiepNhan_Id(int tiepnhan_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetBy_TiepNhan_Id");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TiepNhan_Id", tiepnhan_Id);
                ds = ThuVien.mySQL.ExcDataSet(sp_NOITRU_NHAPVIEN, listPara);
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
