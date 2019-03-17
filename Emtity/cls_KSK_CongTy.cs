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
   public class cls_KSK_CongTy
    {
        #region "Constants"
        private const string SP_KSK_CongTy = "sp_KSK_CONGTY";
        #endregion

        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }

        public System.Int32 mvarCongty_Id { get; set; }

        public System.String mvarMaCongty { get; set; }

        public System.String mvarTenCongty { get; set; }

        public System.String mvarTenCongty_En { get; set; }

        public System.String mvarTenCongty_Ru { get; set; }

        public System.String mvarDiaChi { get; set; }

        public System.String mvarDienThoai { get; set; }

        public System.String mvarFax { get; set; }

        public System.String mvarEmail { get; set; }

        public System.String mvarMaSoThue { get; set; }

        public System.String mvarGiamDoc { get; set; }

        public System.String mvarNguoiLienHe { get; set; }

        public System.Boolean mvarNuocNgoai { get; set; }

        public System.Boolean mvarNhaNuoc { get; set; }

        public System.Boolean mvarTamNgung { get; set; }
        public System.String mvarTenKhongDau{ get; set; }

        public System.DateTime mvarNgayTao { get; set; }

        public System.Int32 mvarNguoiTao_Id { get; set; }

        public System.DateTime mvarNgayCapNhat { get; set; }

        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.Int32 mvarHeSo { get; set; }
        #endregion
        private DataSet m_Dal;

        #region "Constructors"

        public cls_KSK_CongTy()
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
            mvarCongty_Id = int.MinValue;
            mvarMaCongty = String.Empty;
            mvarTenCongty = String.Empty;
            mvarTenCongty_En = String.Empty;
            mvarTenCongty_Ru = string.Empty;
            mvarDiaChi = String.Empty;
            mvarDienThoai = String.Empty;
            mvarFax = String.Empty;
            mvarEmail = String.Empty;
            mvarMaSoThue = String.Empty;
            mvarGiamDoc = String.Empty;
            mvarNguoiLienHe = String.Empty;
            mvarNuocNgoai = false;
            mvarNhaNuoc = false;
            mvarTamNgung = false;
            mvarTenKhongDau = string.Empty;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarHeSo = int.MinValue;
        }

        public void FillData(DataRow row)
        {
            mvarCongty_Id = Common.clsControl.IsNullOrEmpty(row["Congty_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Congty_Id"]);
            mvarMaCongty = Common.clsControl.getValueInRow<string>(row["MaCongty"]);
            mvarTenCongty = Common.clsControl.getValueInRow<string>(row["TenCongty"]);
            mvarTenCongty_En = Common.clsControl.getValueInRow<string>(row["TenCongty_En"]);
            mvarTenCongty_Ru = Common.clsControl.getValueInRow<string>(row["TenCongty_Ru"]);
            mvarDiaChi = Common.clsControl.getValueInRow<string>(row["DiaChi"]);
            mvarDienThoai = Common.clsControl.getValueInRow<string>(row["DienThoai"]);
            mvarFax = Common.clsControl.getValueInRow<string>(row["Fax"]);
            mvarEmail = Common.clsControl.getValueInRow<string>(row["Email"]);
            mvarMaSoThue = Common.clsControl.getValueInRow<string>(row["MaSoThue"]);
            mvarGiamDoc = Common.clsControl.getValueInRow<string>(row["GiamDoc"]);
            mvarNguoiLienHe = Common.clsControl.getValueInRow<string>(row["NguoiLienHe"]);
            mvarNhaNuoc = Common.clsControl.getValueInRow<bool>(row["NhaNuoc"]);
            mvarNuocNgoai = Common.clsControl.getValueInRow<bool>(row["NuocNgoai"]);
            mvarTamNgung = Common.clsControl.getValueInRow<bool>(row["TamNgung"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarHeSo = Common.clsControl.IsNullOrEmpty(row["HeSo"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HeSo"]);
        }

        public string Add()
        {
            string rtCongty_Id = "";

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaCongty", mvarMaCongty);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenCongty", mvarTenCongty);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenCongty_En", mvarTenCongty_En);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenCongty_Ru", mvarTenCongty_Ru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoai", mvarDienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Fax", mvarFax);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Email", mvarEmail);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaSoThue", mvarMaSoThue);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiamDoc", mvarGiamDoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLienHe", mvarNguoiLienHe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhaNuoc", mvarNhaNuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NuocNgoai", mvarNuocNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TamNgung", mvarTamNgung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HeSo", mvarHeSo);

            rtCongty_Id = ThuVien.mySQL.ExcSP(SP_KSK_CongTy, listPara, "@Congty_Id", SqlDbType.Int, 32);
            return rtCongty_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaCongty", mvarMaCongty);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenCongty", mvarTenCongty);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenCongty_En", mvarTenCongty_En);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TenCongty_Ru", mvarTenCongty_Ru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiaChi", mvarDiaChi);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienThoai", mvarDienThoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Fax", mvarFax);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Email", mvarEmail);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaSoThue", mvarMaSoThue);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiamDoc", mvarGiamDoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiLienHe", mvarNguoiLienHe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhaNuoc", mvarNhaNuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NuocNgoai", mvarNuocNgoai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TamNgung", mvarTamNgung);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HeSo", mvarHeSo);
            ThuVien.mySQL.ExcSP(SP_KSK_CongTy, listPara);
            return mvarCongty_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Congty_Id", mvarCongty_Id);
            string rt = ThuVien.mySQL.ExcSP(SP_KSK_CongTy, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public void Get_By_CongTy(GridControl grv)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetListData");
            Common.clsControl.LoadGirdControl_Y(grv, SP_KSK_CongTy, listPara);
        }
        public bool Get_By_Key(int congty_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Congty_Id", congty_Id);
                ds = ThuVien.mySQL.ExcDataSet(SP_KSK_CongTy, listPara);
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
