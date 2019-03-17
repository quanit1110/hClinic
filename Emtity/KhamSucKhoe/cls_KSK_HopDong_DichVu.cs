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
    public class cls_KSK_HopDong_DichVu
    {
        #region "Constants"
        private const string sp_KSK_HOPDONG_DICHVU = "sp_KSK_HOPDONG_DICHVU";
        #endregion
        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarHopDong_DichVu_Id { get; set; }
        public System.Int32 mvarHopDong_Id { get; set; }
        public System.Int32 mvarDichVu_Id { get; set; }
        public System.Int32 mvarPhongBan_Id { get; set; }
        public System.Decimal mvarDonGiaPhaiThu { get; set; }
        public System.Decimal mvarDonGia { get; set; }
        public System.String mvarTienTe_Id { get; set; }
        public System.Decimal mvarTyGia { get; set; }
        public System.String mvarMoTa { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.Int32 mvarIdx { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_KSK_HopDong_DichVu()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        #endregion

        public void ReSet()
        {
            mvarLanguageId = String.Empty;
            mvarUserID = int.MinValue;
            mvarFreePara = String.Empty;
            mvarHopDong_DichVu_Id = int.MinValue;
            mvarHopDong_Id = int.MinValue;
            mvarDichVu_Id = int.MinValue;
            mvarPhongBan_Id = int.MinValue;
            mvarDonGiaPhaiThu = decimal.MinValue;
            mvarDonGia = decimal.MinValue;
            mvarTienTe_Id = String.Empty;
            mvarTyGia = decimal.MinValue;
            mvarMoTa = String.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarIdx = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarHopDong_DichVu_Id = Common.clsControl.IsNullOrEmpty(row["HopDong_DichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HopDong_DichVu_Id"]);
            mvarHopDong_Id = Common.clsControl.IsNullOrEmpty(row["HopDong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HopDong_Id"]);
            mvarDichVu_Id = Common.clsControl.IsNullOrEmpty(row["DichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DichVu_Id"]);
            mvarPhongBan_Id = Common.clsControl.IsNullOrEmpty(row["PhongBan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["PhongBan_Id"]);
            mvarDonGiaPhaiThu = Common.clsControl.IsNullOrEmpty(row["DonGiaPhaiThu"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGiaPhaiThu"]);
            mvarDonGia = Common.clsControl.IsNullOrEmpty(row["DonGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["DonGia"]);
            mvarTienTe_Id = Common.clsControl.getValueInRow<string>(row["TienTe_Id"]);
            mvarTyGia = Common.clsControl.IsNullOrEmpty(row["TyGia"].ToString().ToArray()) ? decimal.MinValue : Common.clsControl.getValueInRow<decimal>(row["TyGia"]);
            mvarMoTa = Common.clsControl.getValueInRow<string>(row["MoTa"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarIdx = Common.clsControl.IsNullOrEmpty(row["Idx"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Idx"]);
        }
        public string Add()
        {
            string rtHopDong_DichVu_Idd = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_Id", mvarHopDong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", mvarDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaPhaiThu", mvarDonGiaPhaiThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGia", mvarDonGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTa", mvarMoTa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Idx", mvarIdx);

            rtHopDong_DichVu_Idd = ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG_DICHVU, listPara, "@HopDong_DichVu_Id", SqlDbType.Int, 32);
            return rtHopDong_DichVu_Idd;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_DichVu_Id", mvarHopDong_DichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_Id", mvarHopDong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DichVu_Id", mvarDichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhongBan_Id", mvarPhongBan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGiaPhaiThu", mvarDonGiaPhaiThu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DonGia", mvarDonGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienTe_Id", mvarTienTe_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TyGia", mvarTyGia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTa", mvarMoTa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Idx", mvarIdx);

            ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG_DICHVU, listPara);
            return mvarHopDong_DichVu_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_DichVu_Id", mvarHopDong_DichVu_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG_DICHVU, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public bool DeleteHopDong()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "DeleteData_ByKeyHD");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_Id", mvarHopDong_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG_DICHVU, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public DataTable GetData_ByKeyHD(GridControl grv, DataTable dt, string id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKeyHD");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_Id", id);
            return Common.clsControl.LoadGirdControl_RtDt(grv, dt, sp_KSK_HOPDONG_DICHVU, listPara);
        }
        public void GetData_By_KeyHD(GridControl grv, string id)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                using (cmd = new SqlCommand(sp_KSK_HOPDONG_DICHVU, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "GetData_ByKeyHD");
                cmd.Parameters.AddWithValue("@HopDong_ID", id);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                grv.DataSource = dt;
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

        public void GetData_By_KeyHD(GridControl grv, int id)
        {
            Common.clsControl.GridView_SP(grv, sp_KSK_HOPDONG_DICHVU, "GetData_ByKeyHD", "@HopDong_Id", id.ToString());
        }
        public DataTable CheckDeleteData_ByKey(int ID)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                using (cmd = new SqlCommand(sp_KSK_HOPDONG_DICHVU, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "CheckData_ByHD");
                cmd.Parameters.AddWithValue("@HopDong_ID", ID);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

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
            return dt;
        }
    }
}

