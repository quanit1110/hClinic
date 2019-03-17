using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    class DuocKhoaSoChungTu
    {
        #region "Constants"
        private const string sp_DUOCKHOASOCHUNGTU = "sp_DUOCKHOASOCHUNGTU";
        #endregion
        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarDuocKhoaSoChungTu_Id { get; set; }
        public System.Int32 mvarDuocKyTonKho_Id { get; set; }
        public System.Int32 mvarKhoDuoc_Id { get; set; }
        public System.Boolean mvarKhoaSo { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public DuocKhoaSoChungTu()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public DuocKhoaSoChungTu(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public DuocKhoaSoChungTu(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public DuocKhoaSoChungTu(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarDuocKhoaSoChungTu_Id = int.MinValue;
            mvarDuocKyTonKho_Id = int.MinValue;
            mvarKhoDuoc_Id = int.MinValue;
            mvarKhoaSo = false;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarDuocKhoaSoChungTu_Id = Common.clsControl.IsNullOrEmpty(row["DuocKhoaSoChungTu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DuocKhoaSoChungTu_Id"]);
            mvarDuocKyTonKho_Id = Common.clsControl.IsNullOrEmpty(row["DuocKyTonKho_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DuocKyTonKho_Id"]);
            mvarKhoDuoc_Id = Common.clsControl.IsNullOrEmpty(row["KhoDuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoDuoc_Id"]);
            mvarKhoaSo = Common.clsControl.getValueInRow<bool>(row["KhoaSo"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
        }
        public string Add()
        {
            string rtQD_HoTroChiPhiNoiTru_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuocKyTonKho_Id", mvarDuocKyTonKho_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoDuoc_Id", mvarKhoDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaSo", mvarKhoaSo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);

            rtQD_HoTroChiPhiNoiTru_Id = ThuVien.mySQL.ExcSP(sp_DUOCKHOASOCHUNGTU, listPara, "@DuocKhoaSoChungTu_Id", SqlDbType.Int, 32);
            return rtQD_HoTroChiPhiNoiTru_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuocKhoaSoChungTu_Id", mvarDuocKhoaSoChungTu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuocKyTonKho_Id", mvarDuocKyTonKho_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoDuoc_Id", mvarKhoDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoaSo", mvarKhoaSo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);

            ThuVien.mySQL.ExcSP(sp_DUOCKHOASOCHUNGTU, listPara);
            return mvarDuocKhoaSoChungTu_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DuocKhoaSoChungTu_Id", mvarDuocKhoaSoChungTu_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_DUOCKHOASOCHUNGTU, listPara);
            if (rt == "err") { return false; }
            return true;
        }
    }
}
