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
   public class cls_GiaHopDong
    {
        #region "Constants"
        private const string sp_GiaHopDong = "sp_DM_GIAHOPDONG";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarGiaHopDong_Id { get; set; }
        public System.Int32 mvarNhaCungCap_Id { get; set; }
        public System.DateTime mvarNgayHopDong { get; set; }
        public System.String mvarPhamVi { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.DateTime mvarNgayCungCap { get; set; }
        public System.DateTime mvarNgayHetHan { get; set; }
        public System.Int32 mvarGoiThau_Id { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_GiaHopDong()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_GiaHopDong(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_GiaHopDong(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_GiaHopDong(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarGiaHopDong_Id = int.MinValue;
            mvarNhaCungCap_Id = int.MinValue;
            mvarNgayHopDong = DateTime.MinValue;
            mvarPhamVi = String.Empty;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNgayCungCap = DateTime.MinValue;
            mvarNgayHetHan = DateTime.MinValue;
            mvarGoiThau_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarGiaHopDong_Id = Common.clsControl.IsNullOrEmpty(row["GiaHopDong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GiaHopDong_Id"]);
            mvarNhaCungCap_Id = Common.clsControl.IsNullOrEmpty(row["NhaCungCap_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhaCungCap_Id"]);
            mvarNgayHopDong = Common.clsControl.IsNullOrEmpty(row["NgayHopDong"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHopDong"]);
            mvarPhamVi = Common.clsControl.getValueInRow<string>(row["PhamVi"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNgayCungCap = Common.clsControl.IsNullOrEmpty(row["NgayCungCap"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCungCap"]);
            mvarNgayHetHan = Common.clsControl.IsNullOrEmpty(row["NgayHetHan"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayHetHan"]);
            mvarGoiThau_Id = Common.clsControl.IsNullOrEmpty(row["GoiThau_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["GoiThau_Id"]);
        }

        public string Add()
        {
            string rtGiaHopDong_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhaCungCap_Id", mvarNhaCungCap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHopDong", mvarNgayHopDong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhamVi", mvarPhamVi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCungCap", mvarNgayCungCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHetHan", mvarNgayHetHan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GoiThau_Id", mvarGoiThau_Id);

            rtGiaHopDong_Id = ThuVien.mySQL.ExcSP(sp_GiaHopDong, listPara, "@GiaHopDong_Id", SqlDbType.Int, 32);
            return rtGiaHopDong_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaHopDong_Id", mvarGiaHopDong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhaCungCap_Id", mvarNhaCungCap_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHopDong", mvarNgayHopDong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhamVi", mvarPhamVi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCungCap", mvarNgayCungCap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayHetHan", mvarNgayHetHan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GoiThau_Id", mvarGoiThau_Id);

            ThuVien.mySQL.ExcSP(sp_GiaHopDong, listPara);
            return mvarGiaHopDong_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaHopDong_Id", mvarGiaHopDong_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_GiaHopDong, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public DataTable GetGiaHD(int NCC, int GoiThau)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                using (cmd = new SqlCommand(sp_GiaHopDong, con))
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Get_GiaHongDong");
                cmd.Parameters.AddWithValue("@NhaCungCap_Id", NCC);
                cmd.Parameters.AddWithValue("@GoiThau_Id", GoiThau);
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
