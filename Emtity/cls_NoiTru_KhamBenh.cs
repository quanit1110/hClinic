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
    public class cls_NoiTru_KhamBenh
    {
        #region "Constants"
        private const string sp_NOITRU_KHAMBENH = "sp_NOITRU_KHAMBENH";
        #endregion

        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarKhamBenh_Id { get; set; }
        public System.Int32 mvarBenhAn_Id { get; set; }
        public System.Int32 mvarLuuTru_Id { get; set; }
        public System.Int32 mvarLanKham { get; set; }
        public System.DateTime mvarNgayKham { get; set; }
        public System.DateTime mvarThoiGianKham { get; set; }
        public System.Int32 mvarBasSiKham_Id { get; set; }
        public System.Int32 mvarDieuDuong_Id { get; set; }
        public System.String mvarDinhBenh { get; set; }
        public System.String mvarDienBien { get; set; }
        public System.String mvarLoiDan { get; set; }
        public System.Int32 mvarCheDoAnUong_Id { get; set; }
        public System.Int32 mvarCheDoChamSoc_Id { get; set; }
        public System.Int32 mvarKhoDuoc_Id { get; set; }
        public System.DateTime mvarNgayTao { get; set; }
        public System.Int32 mvarNguoiTao_Id { get; set; }
        public System.DateTime mvarNgayCapNhat { get; set; }
        public System.Int32 mvarNguoiCapNhat_Id { get; set; }
        public System.Int32 mvarDoiTuong_Id { get; set; }
        public System.Int32 mvarCapHoLy_Id { get; set; }
        public System.String mvarLoaiToaThuoc { get; set; }
        public System.Boolean mvarRavien { get; set; }
        public System.Boolean mvarKhamNgoaiTru { get; set; }
        public System.Boolean mvarThuocDacTri { get; set; }
        public System.DateTime mvarNgayTaiKham { get; set; }
        public System.Int32 mvarSoNgayHenTaiKham { get; set; }
        public System.Int32 mvarChungTuPhatThuoc_Id { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_NoiTru_KhamBenh()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_NoiTru_KhamBenh(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_NoiTru_KhamBenh(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_NoiTru_KhamBenh(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarKhamBenh_Id = int.MinValue;
            mvarBenhAn_Id = int.MinValue;
            mvarLuuTru_Id = int.MinValue;
            mvarLanKham = int.MinValue;
            mvarNgayKham = DateTime.MinValue;
            mvarThoiGianKham = DateTime.MinValue;
            mvarBasSiKham_Id = int.MinValue;
            mvarDieuDuong_Id = int.MinValue;
            mvarDinhBenh = String.Empty;
            mvarDienBien = String.Empty;
            mvarLoiDan = String.Empty;
            mvarCheDoAnUong_Id = int.MinValue;
            mvarCheDoChamSoc_Id = int.MinValue;
            mvarKhoDuoc_Id = int.MinValue;
            mvarNgayTao = DateTime.MinValue;
            mvarNguoiTao_Id = int.MinValue;
            mvarNgayCapNhat = DateTime.MinValue;
            mvarNguoiCapNhat_Id = int.MinValue;
            mvarDoiTuong_Id = int.MinValue;
            mvarCapHoLy_Id = int.MinValue;
            mvarLoaiToaThuoc = String.Empty;
            mvarRavien = false;
            mvarKhamNgoaiTru = false;
            mvarThuocDacTri = false;
            mvarNgayTaiKham = DateTime.MinValue;
            mvarSoNgayHenTaiKham = int.MinValue;
            mvarChungTuPhatThuoc_Id = int.MinValue;
        }


        public void FillData(DataRow row)
        {
            mvarKhamBenh_Id = Common.clsControl.IsNullOrEmpty(row["KhamBenh_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhamBenh_Id"]);
            mvarBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["BenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAn_Id"]);
            mvarLuuTru_Id = Common.clsControl.IsNullOrEmpty(row["LuuTru_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LuuTru_Id"]);
            mvarLanKham = Common.clsControl.IsNullOrEmpty(row["LanKham"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["LanKham"]);
            mvarNgayKham = Common.clsControl.IsNullOrEmpty(row["NgayKham"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayKham"]);
            mvarThoiGianKham = Common.clsControl.IsNullOrEmpty(row["ThoiGianKham"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["ThoiGianKham"]);
            mvarBasSiKham_Id = Common.clsControl.IsNullOrEmpty(row["BasSiKham_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BasSiKham_Id"]);
            mvarDieuDuong_Id = Common.clsControl.IsNullOrEmpty(row["DieuDuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DieuDuong_Id"]);
            mvarDinhBenh = Common.clsControl.getValueInRow<string>(row["DinhBenh"]);
            mvarDienBien = Common.clsControl.getValueInRow<string>(row["DienBien"]);
            mvarLoiDan = Common.clsControl.getValueInRow<string>(row["LoiDan"]);
            mvarCheDoAnUong_Id = Common.clsControl.IsNullOrEmpty(row["CheDoAnUong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CheDoAnUong_Id"]);
            mvarCheDoChamSoc_Id = Common.clsControl.IsNullOrEmpty(row["CheDoChamSoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CheDoChamSoc_Id"]);
            mvarKhoDuoc_Id = Common.clsControl.IsNullOrEmpty(row["KhoDuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["KhoDuoc_Id"]);
            mvarNgayTao = Common.clsControl.IsNullOrEmpty(row["NgayTao"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTao"]);
            mvarNguoiTao_Id = Common.clsControl.IsNullOrEmpty(row["NguoiTao_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiTao_Id"]);
            mvarNgayCapNhat = Common.clsControl.IsNullOrEmpty(row["NgayCapNhat"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayCapNhat"]);
            mvarNguoiCapNhat_Id = Common.clsControl.IsNullOrEmpty(row["NguoiCapNhat_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NguoiCapNhat_Id"]);
            mvarDoiTuong_Id = Common.clsControl.IsNullOrEmpty(row["DoiTuong_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["DoiTuong_Id"]);
            mvarCapHoLy_Id = Common.clsControl.IsNullOrEmpty(row["CapHoLy_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CapHoLy_Id"]);
            mvarLoaiToaThuoc = Common.clsControl.getValueInRow<string>(row["LoaiToaThuoc"]);
            mvarRavien = Common.clsControl.getValueInRow<bool>(row["Ravien"]);
            mvarKhamNgoaiTru = Common.clsControl.getValueInRow<bool>(row["KhamNgoaiTru"]);
            mvarThuocDacTri = Common.clsControl.getValueInRow<bool>(row["ThuocDacTri"]);
            mvarNgayTaiKham = Common.clsControl.IsNullOrEmpty(row["NgayTaiKham"].ToString().ToArray()) ? DateTime.MinValue : Common.clsControl.getValueInRow<DateTime>(row["NgayTaiKham"]);
            mvarSoNgayHenTaiKham = Common.clsControl.IsNullOrEmpty(row["SoNgayHenTaiKham"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoNgayHenTaiKham"]);
            mvarChungTuPhatThuoc_Id = Common.clsControl.IsNullOrEmpty(row["ChungTuPhatThuoc_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["ChungTuPhatThuoc_Id"]);
        }
        public string Add()
        {
            string rtKhamBenh_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Id", mvarLuuTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LanKham", mvarLanKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKham", mvarNgayKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKham", mvarThoiGianKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BasSiKham_Id", mvarBasSiKham_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DieuDuong_Id", mvarDieuDuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DinhBenh", mvarDinhBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienBien", mvarDienBien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoiDan", mvarLoiDan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CheDoAnUong_Id", mvarCheDoAnUong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CheDoChamSoc_Id", mvarCheDoChamSoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoDuoc_Id", mvarKhoDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CapHoLy_Id", mvarCapHoLy_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiToaThuoc", mvarLoaiToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@RaVien", mvarRavien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamNgoaiTru", mvarKhamNgoaiTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuocDacTri", mvarThuocDacTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTaiKham", mvarNgayTaiKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgayHenTaiKham", mvarSoNgayHenTaiKham);

            rtKhamBenh_Id = ThuVien.mySQL.ExcSP(sp_NOITRU_KHAMBENH, listPara, "@KhamBenh_Id", SqlDbType.Int, 32);
            return rtKhamBenh_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LuuTru_Id", mvarLuuTru_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LanKham", mvarLanKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKham", mvarNgayKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThoiGianKham", mvarThoiGianKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BasSiKham_Id", mvarBasSiKham_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DieuDuong_Id", mvarDieuDuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DinhBenh", mvarDinhBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DienBien", mvarDienBien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoiDan", mvarLoiDan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CheDoAnUong_Id", mvarCheDoAnUong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CheDoChamSoc_Id", mvarCheDoChamSoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhoDuoc_Id", mvarKhoDuoc_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTao", mvarNgayTao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiTao_Id", mvarNguoiTao_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayCapNhat", mvarNgayCapNhat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NguoiCapNhat_Id", mvarNguoiCapNhat_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DoiTuong_Id", mvarDoiTuong_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CapHoLy_Id", mvarCapHoLy_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoaiToaThuoc", mvarLoaiToaThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@RaVien", mvarRavien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamNgoaiTru", mvarKhamNgoaiTru);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuocDacTri", mvarThuocDacTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTaiKham", mvarNgayTaiKham);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoNgayHenTaiKham", mvarSoNgayHenTaiKham);

            ThuVien.mySQL.ExcSP(sp_NOITRU_KHAMBENH, listPara);
            return mvarKhamBenh_Id.ToString();
        }

        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", mvarKhamBenh_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_NOITRU_KHAMBENH, listPara);
            if (rt == "err") { return false; }
            return true;
        }

        public bool Get_By_Key(int khamBenh_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenh_Id", khamBenh_Id);
                ds = ThuVien.mySQL.ExcDataSet(sp_NOITRU_KHAMBENH, listPara);
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

        public void GetListKhamBenh(GridControl grv, int benhAn_Id)
        {
            List<SqlParameter> listPara = new List<SqlParameter>();

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetKhamBenh_By_BenhAn_Id");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", benhAn_Id);

            Common.clsControl.LoadGirdControl_Y(grv, sp_NOITRU_KHAMBENH, listPara);
        }
        public bool Get_By_NgayKham(int benhAn_Id,DateTime? dt)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetKhamBenh_By_NgayKham");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", benhAn_Id);
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayKham", dt);
                ds = ThuVien.mySQL.ExcDataSet(sp_NOITRU_KHAMBENH, listPara);
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
