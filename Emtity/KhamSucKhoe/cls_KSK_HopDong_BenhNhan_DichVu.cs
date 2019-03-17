using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
   public class cls_KSK_HopDong_BenhNhan_DichVu
    {
        #region "Constants"
        private const string sp_KSK_HOPDONG_BENHNHAN_DICHVU = "sp_KSK_HOPDONG_BENHNHAN_DICHVU";
        #endregion
        #region "Member Variables"
        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarHopDong_DichVu_BenhNhan_id { get; set; }
        public System.Int32 mvarHopDong_id { get; set; }
        public System.Int32 mvarHopDong_DichVu_Id { get; set; }
        public System.Int32 mvarHopDong_BenhNhan_Id { get; set; }
        public System.Int32 mvarPhongban_id { get; set; }
        public System.String mvarTrangThai { get; set; }
        public System.Boolean mvarDaThuTien { get; set; }
        public System.String mvarKetQua { get; set; }
        public System.Boolean mvarSelected { get; set; }
        public System.String mvarSophieuyeucau { get; set; }
        public System.Int32 mvarclsyeucau_id { get; set; }
        public System.Int32 mvarclsyeucauchitiet_id { get; set; }
        public System.Boolean mvarDataophieu { get; set; }
        public System.Int32 mvarBenhnhan_ehos_id { get; set; }
        public System.Int32 mvarTiepnhan_id { get; set; }
        public System.Boolean mvarBatThuong { get; set; }
        public System.String mvarMucBinhThuongMin { get; set; }
        public System.String mvarMucBinhThuongMax { get; set; }
        public System.Boolean mvarDathuchien { get; set; }
        public System.Boolean mvarInbc { get; set; }
        public System.String mvarPhanLoai { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_KSK_HopDong_BenhNhan_DichVu()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_KSK_HopDong_BenhNhan_DichVu(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_KSK_HopDong_BenhNhan_DichVu(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_KSK_HopDong_BenhNhan_DichVu(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarHopDong_DichVu_BenhNhan_id = int.MinValue;
            mvarHopDong_id = int.MinValue;
            mvarHopDong_DichVu_Id = int.MinValue;
            mvarHopDong_BenhNhan_Id = int.MinValue;
            mvarPhongban_id = int.MinValue;
            mvarTrangThai = String.Empty;
            mvarDaThuTien = false;
            mvarKetQua = String.Empty;
            mvarSelected = false;
            mvarSophieuyeucau = String.Empty;
            mvarclsyeucau_id = int.MinValue;
            mvarclsyeucauchitiet_id = int.MinValue;
            mvarDataophieu = false;
            mvarBenhnhan_ehos_id = int.MinValue;
            mvarTiepnhan_id = int.MinValue;
            mvarBatThuong = false;
            mvarMucBinhThuongMin = String.Empty;
            mvarMucBinhThuongMax = String.Empty;
            mvarDathuchien = false;
            mvarInbc = false;
            mvarPhanLoai = String.Empty;
        }

        public void FillData(DataRow row)
        {
            mvarHopDong_DichVu_BenhNhan_id = Common.clsControl.IsNullOrEmpty(row["HopDong_DichVu_BenhNhan_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HopDong_DichVu_BenhNhan_id"]);
            mvarHopDong_id = Common.clsControl.IsNullOrEmpty(row["HopDong_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HopDong_id"]);
            mvarHopDong_DichVu_Id = Common.clsControl.IsNullOrEmpty(row["HopDong_DichVu_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HopDong_DichVu_Id"]);
            mvarHopDong_BenhNhan_Id = Common.clsControl.IsNullOrEmpty(row["HopDong_BenhNhan_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HopDong_BenhNhan_Id"]);
            mvarPhongban_id = Common.clsControl.IsNullOrEmpty(row["Phongban_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Phongban_id"]);
            mvarTrangThai = Common.clsControl.getValueInRow<string>(row["TrangThai"]);
            mvarDaThuTien = Common.clsControl.getValueInRow<bool>(row["DaThuTien"]);
            mvarKetQua = Common.clsControl.getValueInRow<string>(row["KetQua"]);
            mvarSelected = Common.clsControl.getValueInRow<bool>(row["Selected"]);
            mvarSophieuyeucau = Common.clsControl.getValueInRow<string>(row["Sophieuyeucau"]);
            mvarclsyeucau_id = Common.clsControl.IsNullOrEmpty(row["clsyeucau_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["clsyeucau_id"]);
            mvarclsyeucauchitiet_id = Common.clsControl.IsNullOrEmpty(row["clsyeucauchitiet_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["clsyeucauchitiet_id"]);
            mvarDataophieu = Common.clsControl.getValueInRow<bool>(row["Dataophieu"]);
            mvarBenhnhan_ehos_id = Common.clsControl.IsNullOrEmpty(row["Benhnhan_ehos_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Benhnhan_ehos_id"]);
            mvarTiepnhan_id = Common.clsControl.IsNullOrEmpty(row["Tiepnhan_id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Tiepnhan_id"]);
            mvarBatThuong = Common.clsControl.getValueInRow<bool>(row["BatThuong"]);
            mvarMucBinhThuongMin = Common.clsControl.getValueInRow<string>(row["MucBinhThuongMin"]);
            mvarMucBinhThuongMax = Common.clsControl.getValueInRow<string>(row["MucBinhThuongMax"]);
            mvarDathuchien = Common.clsControl.getValueInRow<bool>(row["Dathuchien"]);
            mvarInbc = Common.clsControl.getValueInRow<bool>(row["Inbc"]);
            mvarPhanLoai = Common.clsControl.getValueInRow<string>(row["PhanLoai"]);
        }
        public string Add()
        {
            string rtHopDong_DichVu_BenhNhan_id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_id", mvarHopDong_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_DichVu_Id", mvarHopDong_DichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_BenhNhan_Id", mvarHopDong_BenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Phongban_id", mvarPhongban_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThuTien", mvarDaThuTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQua", mvarKetQua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhieuYeuCau", mvarSophieuyeucau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSyeucau_Id", mvarclsyeucau_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSyeucauchitiet_Id", mvarclsyeucauchitiet_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@benhnhan_ehos_id", mvarBenhnhan_ehos_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@tiepnhan_id", mvarTiepnhan_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhanLoai", mvarPhanLoai);

            rtHopDong_DichVu_BenhNhan_id = ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG_BENHNHAN_DICHVU, listPara, "@HopDong_DichVu_BenhNhan_id", SqlDbType.Int, 32);
            return rtHopDong_DichVu_BenhNhan_id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_DichVu_BenhNhan_id", mvarHopDong_DichVu_BenhNhan_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_id", mvarHopDong_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_DichVu_Id", mvarHopDong_DichVu_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_BenhNhan_Id", mvarHopDong_BenhNhan_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Phongban_id", mvarPhongban_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TrangThai", mvarTrangThai);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DaThuTien", mvarDaThuTien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KetQua", mvarKetQua);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoPhieuYeuCau", mvarSophieuyeucau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSyeucau_Id", mvarclsyeucau_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CLSyeucauchitiet_Id", mvarclsyeucauchitiet_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@benhnhan_ehos_id", mvarBenhnhan_ehos_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@tiepnhan_id", mvarTiepnhan_id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhanLoai", mvarPhanLoai);
            ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG_BENHNHAN_DICHVU, listPara);
            return mvarHopDong_DichVu_BenhNhan_id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HopDong_DichVu_BenhNhan_id", mvarHopDong_DichVu_BenhNhan_id);
            string rt = ThuVien.mySQL.ExcSP(sp_KSK_HOPDONG_BENHNHAN_DICHVU, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public void GetListData_Benhnhan_hopdong_dichvu(GridControl gr, int ID)
        {
            Common.clsControl.GridView_SP(gr, sp_KSK_HOPDONG_BENHNHAN_DICHVU, "getketquaKSK", "@HopDong_BenhNhan_Id", ID.ToString());
        }

    }
}
