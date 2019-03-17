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
   public class cls_GiaHopDongChiTiet
    {
        #region "Constants"
        private const string sp_DM_GIAHOPDONGCHITIET = "sp_DM_GIAHOPDONGCHITIET";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarGiaHopDongChiTiet_Id { get; set; }
        public System.Int32 mvarGiaHopDong_Id { get; set; }
        public System.Int32 mvarDuoc_Id { get; set; }
        public System.Decimal mvarDonGiaHopDong { get; set; }
        public System.Decimal mvarDonGiaDuTru { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Decimal mvarSoLuongCungCap { get; set; }
        public System.Decimal mvarSoLuongDaNhap { get; set; }
        public System.String mvarMaThongTu { get; set; }
        public System.String mvarSoViSa { get; set; }
        public System.String mvarMaQuyetDinh { get; set; }
        public System.String mvarSoNamHopDong { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_GiaHopDongChiTiet()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_GiaHopDongChiTiet(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_GiaHopDongChiTiet(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_GiaHopDongChiTiet(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarGiaHopDongChiTiet_Id = int.MinValue;
            mvarGiaHopDong_Id = int.MinValue;
            mvarDuoc_Id = int.MinValue;
            mvarDonGiaHopDong = decimal.MinValue;
            mvarDonGiaDuTru = decimal.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarSoLuongCungCap = decimal.MinValue;
            mvarSoLuongDaNhap = decimal.MinValue;
            mvarMaThongTu = String.Empty;
            mvarSoViSa = String.Empty;
            mvarMaQuyetDinh = String.Empty;
            mvarSoNamHopDong = String.Empty;
        }

        public void FillData(DataRow row)
        {
            mvarGiaHopDongChiTiet_Id = Common.clsControl.IsNullOrEmpty(row["GiaHopDongChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiaHopDongChiTiet_Id"]);
            mvarGiaHopDong_Id = Common.clsControl.IsNullOrEmpty(row["GiaHopDong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiaHopDong_Id"]);
            mvarDuoc_Id = Common.clsControl.IsNullOrEmpty(row["Duoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Duoc_Id"]);
            mvarDonGiaHopDong = Common.clsControl.IsNullOrEmpty(row["DonGiaHopDong"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaHopDong"]);
            mvarDonGiaDuTru = Common.clsControl.IsNullOrEmpty(row["DonGiaDuTru"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaDuTru"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarSoLuongCungCap = Common.clsControl.IsNullOrEmpty(row["SoLuongCungCap"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuongCungCap"]);
            mvarSoLuongDaNhap = Common.clsControl.IsNullOrEmpty(row["SoLuongDaNhap"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["SoLuongDaNhap"]);
            mvarMaThongTu = Common.clsControl.getValueInRow<string>(row["MaThongTu"]);
            mvarSoViSa = Common.clsControl.getValueInRow<string>(row["SoViSa"]);
            mvarMaQuyetDinh = Common.clsControl.getValueInRow<string>(row["MaQuyetDinh"]);
            mvarSoNamHopDong = Common.clsControl.getValueInRow<string>(row["SoNamHopDong"]);
        }

        public string Add()
        {
            string rtGiaHopDongChiTiet_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaHopDong_Id", mvarGiaHopDong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHopDong", mvarDonGiaHopDong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDuTru", mvarDonGiaDuTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongCungCap", mvarSoLuongCungCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongDaNhap", mvarSoLuongDaNhap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaThongTu", mvarMaThongTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoViSa", mvarSoViSa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaQuyetDinh", mvarMaQuyetDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNamHopDong", mvarSoNamHopDong);

            rtGiaHopDongChiTiet_Id = ThuVien.mySQL.ExcSP(sp_DM_GIAHOPDONGCHITIET, listPara, "@GiaHopDongChiTiet_Id", SqlDbType.Int, 32);
            return rtGiaHopDongChiTiet_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaHopDongChiTiet_Id", mvarGiaHopDongChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaHopDong_Id", mvarGiaHopDong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Duoc_Id", mvarDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaHopDong", mvarDonGiaHopDong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaDuTru", mvarDonGiaDuTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongCungCap", mvarSoLuongCungCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoLuongDaNhap", mvarSoLuongDaNhap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaThongTu", mvarMaThongTu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoViSa", mvarSoViSa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaQuyetDinh", mvarMaQuyetDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNamHopDong", mvarSoNamHopDong);

            ThuVien.mySQL.ExcSP(sp_DM_GIAHOPDONGCHITIET, listPara);
            return mvarGiaHopDongChiTiet_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaHopDongChiTiet_Id", mvarGiaHopDongChiTiet_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_DM_GIAHOPDONGCHITIET, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public void GetGiaHDChiTiet(GridControl gr, int GiaHD)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                using (cmd = new SqlCommand(sp_DM_GIAHOPDONGCHITIET, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Get_DMGiaHopDongChiTiet");
                cmd.Parameters.AddWithValue("@GiaHopDong_Id", GiaHD);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gr.DataSource = dt;

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
        }
    }
}
