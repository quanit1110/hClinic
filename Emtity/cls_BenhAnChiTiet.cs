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
    public class cls_BenhAnChiTiet
    {
        #region "Constants"
        private const string sp_BENHANCHITIET = "sp_BENHANCHITIET";
        #endregion

        #region "Member Variables"

        public System.String mvarLanguageId { get; set; }

        public System.Int32 mvarUserID { get; set; }

        public System.String mvarFreePara { get; set; }
        public System.Int32 mvarBenhAnChiTiet_Id { get; set; }
        public System.Int32 mvarBenhAn_Id { get; set; }
        public System.String mvarLyDoVaoVien { get; set; }
        public System.String mvarQuaTrinhBenhLy { get; set; }
        public System.String mvarTienSuBanThan { get; set; }
        public System.Boolean mvarDiUng { get; set; }
        public System.Int32 mvarNgayDiUng { get; set; }
        public System.Boolean mvarMaTuy { get; set; }
        public System.Int32 mvarNgayMaTuy { get; set; }
        public System.Boolean mvarRuouBia { get; set; }
        public System.Int32 mvarNgayRuouBia { get; set; }
        public System.Boolean mvarThuocLa { get; set; }
        public System.Int32 mvarNgayThuocLa { get; set; }
        public System.Boolean mvarThuocLao { get; set; }
        public System.Int32 mvarNgayThuocLao { get; set; }
        public System.Boolean mvarTienSuKhac { get; set; }
        public System.Int32 mvarNgayTienSuKhac { get; set; }
        public System.String mvarTienSuGiaDinh { get; set; }
        public System.String mvarKhamBenhToanThan { get; set; }
        public System.Int32 mvarMach { get; set; }
        public System.Int32 mvarNhipTho { get; set; }
        public System.Int32 mvarNhietDo { get; set; }
        public System.Int32 mvarCanNang { get; set; }
        public System.Int32 mvarHuyetApCao { get; set; }
        public System.Int32 mvarHuyetApThap { get; set; }
        public System.String mvarKhamBenhBoPhanTonThuong { get; set; }
        public System.String mvarThanKinh { get; set; }
        public System.String mvarTuanHoan { get; set; }
        public System.String mvarHoHap { get; set; }
        public System.String mvarTieuHoa { get; set; }
        public System.String mvarCoXuongKhop { get; set; }
        public System.String mvarTietNieu { get; set; }
        public System.String mvarSinhDuc { get; set; }
        public System.String mvarKhamBenhKhac { get; set; }
        public System.String mvarXetNghiemCLSCanLam { get; set; }
        public System.String mvarTomTatBenhAn { get; set; }
        public System.String mvarKhamBenhTienLuong { get; set; }
        public System.String mvarHuongDanDieuTri { get; set; }
        public System.String mvarQuaTrinhBenhLyVaDienBienLamSang { get; set; }
        public System.String mvarXNMau { get; set; }
        public System.String mvarXNTeBao { get; set; }
        public System.String mvarXNBLGP { get; set; }
        public System.String mvarXNXQuang { get; set; }
        public System.String mvarXNSieuAm { get; set; }
        public System.String mvarCacXNKhac { get; set; }
        public System.String mvarPhuongPhapDieuTri { get; set; }
        public System.String mvarPPTienPhauTaiU { get; set; }
        public System.String mvarPPTienPhauTaiHach { get; set; }
        public System.String mvarPPDonThuanTaiU { get; set; }
        public System.String mvarPPDonThuanTaiHach { get; set; }
        public System.String mvarPPPhauThuat { get; set; }
        public System.String mvarPPHauPhauTaiU { get; set; }
        public System.String mvarPPHauPhauTaiHach { get; set; }
        public System.String mvarPPHoaChat { get; set; }
        public System.String mvarPPSoDot { get; set; }
        public System.String mvarPPDapUng { get; set; }
        public System.String mvarPPDieuTriKhac { get; set; }
        public System.String mvarTinhTrangNguoiBenhRaVien { get; set; }
        public System.String mvarHuongDieuTriVaCheDoTiepTheo { get; set; }
        public System.Int32 mvarSoToXQuang { get; set; }
        public System.Int32 mvarSoToCTScanner { get; set; }
        public System.Int32 mvarSoToSieuAm { get; set; }
        public System.Int32 mvarSoToXetNghiem { get; set; }
        public System.Int32 mvarSoToKhac { get; set; }
        public System.Int32 mvarSoToHoSo { get; set; }
        public System.String mvarTVaoVien { get; set; }
        public System.String mvarNVaoVien { get; set; }
        public System.String mvarMVaoVien { get; set; }
        public System.String mvarGiaiDoanVaoVien { get; set; }
        public System.Boolean mvarTaiBienDoPhauThau { get; set; }
        public System.Boolean mvarTaiBienDoGayMe { get; set; }
        public System.Boolean mvarTaiBienDoNhiemKhuan { get; set; }
        public System.Boolean mvarTaiBienKhac { get; set; }
        public System.String mvarTRaVien { get; set; }
        public System.String mvarNRaVien { get; set; }
        public System.String mvarMRaVien { get; set; }
        public System.String mvarGiaDoanRaVien { get; set; }
        public System.String mvarChanDoanTruocPhauThuat { get; set; }
        public System.String mvarChanDoanSauPhauThuat { get; set; }
        public System.String mvarKhamBenhBenhChinh { get; set; }
        public System.String mvarTKhamBenh { get; set; }
        public System.String mvarNKhamBenh { get; set; }
        public System.String mvarMKhamBenh { get; set; }
        public System.String mvarGiaiDoanKhamBenh { get; set; }
        public System.String mvarKhamBenhBenhKemTheo { get; set; }
        public System.String mvarKhamBenhPhanBiet { get; set; }
        public System.Int32 mvarTongSoNgayDieuTriSauPhauThuat { get; set; }
        public System.Int32 mvarTongSoLanPhauThuat { get; set; }
        public System.String mvarHinhVeHoacAnh { get; set; }
        public System.String mvarMoTaTonThuong { get; set; }
        public System.String mvarLoiDanThayThuoc { get; set; }
        public System.String mvarPPDT { get; set; }
        #endregion
        private DataSet m_Dal;

        #region Contructor
        public cls_BenhAnChiTiet()
        {
            m_Dal = new DataSet();
            ReSet();
        }
        public cls_BenhAnChiTiet(DataSet dal)
        {
            m_Dal = dal;
            ReSet();
        }
        public cls_BenhAnChiTiet(string pLanguageId, Int32 pUserId)
        {
            ReSet();
            m_Dal = new DataSet();
        }
        public cls_BenhAnChiTiet(DataSet dal, string pLanguageId, Int32 pUserId)
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
            mvarBenhAnChiTiet_Id = int.MinValue;
            mvarBenhAn_Id = int.MinValue;
            mvarLyDoVaoVien = String.Empty;
            mvarQuaTrinhBenhLy = String.Empty;
            mvarTienSuBanThan = String.Empty;
            mvarDiUng = false;
            mvarNgayDiUng = int.MinValue;
            mvarMaTuy = false;
            mvarNgayMaTuy = int.MinValue;
            mvarRuouBia = false;
            mvarNgayRuouBia = int.MinValue;
            mvarThuocLa = false;
            mvarNgayThuocLa = int.MinValue;
            mvarThuocLao = false;
            mvarNgayThuocLao = int.MinValue;
            mvarTienSuKhac = false;
            mvarNgayTienSuKhac = int.MinValue;
            mvarTienSuGiaDinh = String.Empty;
            mvarKhamBenhToanThan = String.Empty;
            mvarMach = int.MinValue;
            mvarNhipTho = int.MinValue;
            mvarNhietDo = int.MinValue;
            mvarCanNang = int.MinValue;
            mvarHuyetApCao = int.MinValue;
            mvarHuyetApThap = int.MinValue;
            mvarKhamBenhBoPhanTonThuong = String.Empty;
            mvarThanKinh = String.Empty;
            mvarTuanHoan = String.Empty;
            mvarHoHap = String.Empty;
            mvarTieuHoa = String.Empty;
            mvarCoXuongKhop = String.Empty;
            mvarTietNieu = String.Empty;
            mvarSinhDuc = String.Empty;
            mvarKhamBenhKhac = String.Empty;
            mvarXetNghiemCLSCanLam = String.Empty;
            mvarTomTatBenhAn = String.Empty;
            mvarKhamBenhTienLuong = String.Empty;
            mvarHuongDanDieuTri = String.Empty;
            mvarQuaTrinhBenhLyVaDienBienLamSang = String.Empty;
            mvarXNMau = String.Empty;
            mvarXNTeBao = String.Empty;
            mvarXNBLGP = String.Empty;
            mvarXNXQuang = String.Empty;
            mvarXNSieuAm = String.Empty;
            mvarCacXNKhac = String.Empty;
            mvarPhuongPhapDieuTri = String.Empty;
            mvarPPTienPhauTaiU = String.Empty;
            mvarPPTienPhauTaiHach = String.Empty;
            mvarPPDonThuanTaiU = String.Empty;
            mvarPPDonThuanTaiHach = String.Empty;
            mvarPPPhauThuat = String.Empty;
            mvarPPHauPhauTaiU = String.Empty;
            mvarPPHauPhauTaiHach = String.Empty;
            mvarPPHoaChat = String.Empty;
            mvarPPSoDot = String.Empty;
            mvarPPDapUng = String.Empty;
            mvarPPDieuTriKhac = String.Empty;
            mvarTinhTrangNguoiBenhRaVien = String.Empty;
            mvarHuongDieuTriVaCheDoTiepTheo = String.Empty;
            mvarSoToXQuang = int.MinValue;
            mvarSoToCTScanner = int.MinValue;
            mvarSoToSieuAm = int.MinValue;
            mvarSoToXetNghiem = int.MinValue;
            mvarSoToKhac = int.MinValue;
            mvarSoToHoSo = int.MinValue;
            mvarTVaoVien = String.Empty;
            mvarNVaoVien = String.Empty;
            mvarMVaoVien = String.Empty;
            mvarGiaiDoanVaoVien = String.Empty;
            mvarTaiBienDoPhauThau = false;
            mvarTaiBienDoGayMe = false;
            mvarTaiBienDoNhiemKhuan = false;
            mvarTaiBienKhac = false;
            mvarTRaVien = String.Empty;
            mvarNRaVien = String.Empty;
            mvarMRaVien = String.Empty;
            mvarGiaDoanRaVien = String.Empty;
            mvarChanDoanTruocPhauThuat = String.Empty;
            mvarChanDoanSauPhauThuat = String.Empty;
            mvarKhamBenhBenhChinh = String.Empty;
            mvarTKhamBenh = String.Empty;
            mvarNKhamBenh = String.Empty;
            mvarMKhamBenh = String.Empty;
            mvarGiaiDoanKhamBenh = String.Empty;
            mvarKhamBenhBenhKemTheo = String.Empty;
            mvarKhamBenhPhanBiet = String.Empty;
            mvarTongSoNgayDieuTriSauPhauThuat = int.MinValue;
            mvarTongSoLanPhauThuat = int.MinValue;
            mvarHinhVeHoacAnh = String.Empty;
            mvarMoTaTonThuong = String.Empty;
            mvarLoiDanThayThuoc = String.Empty;
            mvarPPDT = String.Empty;
        }


        public void FillData(DataRow row)
        {
            mvarBenhAnChiTiet_Id = Common.clsControl.IsNullOrEmpty(row["BenhAnChiTiet_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAnChiTiet_Id"]);
            mvarBenhAn_Id = Common.clsControl.IsNullOrEmpty(row["BenhAn_Id"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["BenhAn_Id"]);
            mvarLyDoVaoVien = Common.clsControl.getValueInRow<string>(row["LyDoVaoVien"]);
            mvarQuaTrinhBenhLy = Common.clsControl.getValueInRow<string>(row["QuaTrinhBenhLy"]);
            mvarTienSuBanThan = Common.clsControl.getValueInRow<string>(row["TienSuBanThan"]);
            mvarDiUng = Common.clsControl.getValueInRow<bool>(row["DiUng"]);
            mvarNgayDiUng = Common.clsControl.IsNullOrEmpty(row["NgayDiUng"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NgayDiUng"]);
            mvarMaTuy = Common.clsControl.getValueInRow<bool>(row["MaTuy"]);
            mvarNgayMaTuy = Common.clsControl.IsNullOrEmpty(row["NgayMaTuy"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NgayMaTuy"]);
            mvarRuouBia = Common.clsControl.getValueInRow<bool>(row["RuouBia"]);
            mvarNgayRuouBia = Common.clsControl.IsNullOrEmpty(row["NgayRuouBia"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NgayRuouBia"]);
            mvarThuocLa = Common.clsControl.getValueInRow<bool>(row["ThuocLa"]);
            mvarNgayThuocLa = Common.clsControl.IsNullOrEmpty(row["NgayThuocLa"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NgayThuocLa"]);
            mvarThuocLao = Common.clsControl.getValueInRow<bool>(row["ThuocLao"]);
            mvarNgayThuocLao = Common.clsControl.IsNullOrEmpty(row["NgayThuocLao"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NgayThuocLao"]);
            mvarTienSuKhac = Common.clsControl.getValueInRow<bool>(row["TienSuKhac"]);
            mvarNgayTienSuKhac = Common.clsControl.IsNullOrEmpty(row["NgayTienSuKhac"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NgayTienSuKhac"]);
            mvarTienSuGiaDinh = Common.clsControl.getValueInRow<string>(row["TienSuGiaDinh"]);
            mvarKhamBenhToanThan = Common.clsControl.getValueInRow<string>(row["KhamBenhToanThan"]);
            mvarMach = Common.clsControl.IsNullOrEmpty(row["Mach"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["Mach"]);
            mvarNhipTho = Common.clsControl.IsNullOrEmpty(row["NhipTho"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhipTho"]);
            mvarNhietDo = Common.clsControl.IsNullOrEmpty(row["NhietDo"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["NhietDo"]);
            mvarCanNang = Common.clsControl.IsNullOrEmpty(row["CanNang"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["CanNang"]);
            mvarHuyetApCao = Common.clsControl.IsNullOrEmpty(row["HuyetApCao"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuyetApCao"]);
            mvarHuyetApThap = Common.clsControl.IsNullOrEmpty(row["HuyetApThap"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["HuyetApThap"]);
            mvarKhamBenhBoPhanTonThuong = Common.clsControl.getValueInRow<string>(row["KhamBenhBoPhanTonThuong"]);
            mvarThanKinh = Common.clsControl.getValueInRow<string>(row["ThanKinh"]);
            mvarTuanHoan = Common.clsControl.getValueInRow<string>(row["TuanHoan"]);
            mvarHoHap = Common.clsControl.getValueInRow<string>(row["HoHap"]);
            mvarTieuHoa = Common.clsControl.getValueInRow<string>(row["TieuHoa"]);
            mvarCoXuongKhop = Common.clsControl.getValueInRow<string>(row["CoXuongKhop"]);
            mvarTietNieu = Common.clsControl.getValueInRow<string>(row["TietNieu"]);
            mvarSinhDuc = Common.clsControl.getValueInRow<string>(row["SinhDuc"]);
            mvarKhamBenhKhac = Common.clsControl.getValueInRow<string>(row["KhamBenhKhac"]);
            mvarXetNghiemCLSCanLam = Common.clsControl.getValueInRow<string>(row["XetNghiemCLSCanLam"]);
            mvarTomTatBenhAn = Common.clsControl.getValueInRow<string>(row["TomTatBenhAn"]);
            mvarKhamBenhTienLuong = Common.clsControl.getValueInRow<string>(row["KhamBenhTienLuong"]);
            mvarHuongDanDieuTri = Common.clsControl.getValueInRow<string>(row["HuongDanDieuTri"]);
            mvarQuaTrinhBenhLyVaDienBienLamSang = Common.clsControl.getValueInRow<string>(row["QuaTrinhBenhLyVaDienBienLamSang"]);
            mvarXNMau = Common.clsControl.getValueInRow<string>(row["XNMau"]);
            mvarXNTeBao = Common.clsControl.getValueInRow<string>(row["XNTeBao"]);
            mvarXNBLGP = Common.clsControl.getValueInRow<string>(row["XNBLGP"]);
            mvarXNXQuang = Common.clsControl.getValueInRow<string>(row["XNXQuang"]);
            mvarXNSieuAm = Common.clsControl.getValueInRow<string>(row["XNSieuAm"]);
            mvarCacXNKhac = Common.clsControl.getValueInRow<string>(row["CacXNKhac"]);
            mvarPhuongPhapDieuTri = Common.clsControl.getValueInRow<string>(row["PhuongPhapDieuTri"]);
            mvarPPTienPhauTaiU = Common.clsControl.getValueInRow<string>(row["PPTienPhauTaiU"]);
            mvarPPTienPhauTaiHach = Common.clsControl.getValueInRow<string>(row["PPTienPhauTaiHach"]);
            mvarPPDonThuanTaiU = Common.clsControl.getValueInRow<string>(row["PPDonThuanTaiU"]);
            mvarPPDonThuanTaiHach = Common.clsControl.getValueInRow<string>(row["PPDonThuanTaiHach"]);
            mvarPPPhauThuat = Common.clsControl.getValueInRow<string>(row["PPPhauThuat"]);
            mvarPPHauPhauTaiU = Common.clsControl.getValueInRow<string>(row["PPHauPhauTaiU"]);
            mvarPPHauPhauTaiHach = Common.clsControl.getValueInRow<string>(row["PPHauPhauTaiHach"]);
            mvarPPHoaChat = Common.clsControl.getValueInRow<string>(row["PPHoaChat"]);
            mvarPPSoDot = Common.clsControl.getValueInRow<string>(row["PPSoDot"]);
            mvarPPDapUng = Common.clsControl.getValueInRow<string>(row["PPDapUng"]);
            mvarPPDieuTriKhac = Common.clsControl.getValueInRow<string>(row["PPDieuTriKhac"]);
            mvarTinhTrangNguoiBenhRaVien = Common.clsControl.getValueInRow<string>(row["TinhTrangNguoiBenhRaVien"]);
            mvarHuongDieuTriVaCheDoTiepTheo = Common.clsControl.getValueInRow<string>(row["HuongDieuTriVaCheDoTiepTheo"]);
            mvarSoToXQuang = Common.clsControl.IsNullOrEmpty(row["SoToXQuang"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoToXQuang"]);
            mvarSoToCTScanner = Common.clsControl.IsNullOrEmpty(row["SoToCTScanner"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoToCTScanner"]);
            mvarSoToSieuAm = Common.clsControl.IsNullOrEmpty(row["SoToSieuAm"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoToSieuAm"]);
            mvarSoToXetNghiem = Common.clsControl.IsNullOrEmpty(row["SoToXetNghiem"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoToXetNghiem"]);
            mvarSoToKhac = Common.clsControl.IsNullOrEmpty(row["SoToKhac"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoToKhac"]);
            mvarSoToHoSo = Common.clsControl.IsNullOrEmpty(row["SoToHoSo"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["SoToHoSo"]);
            mvarTVaoVien = Common.clsControl.getValueInRow<string>(row["TVaoVien"]);
            mvarNVaoVien = Common.clsControl.getValueInRow<string>(row["NVaoVien"]);
            mvarMVaoVien = Common.clsControl.getValueInRow<string>(row["MVaoVien"]);
            mvarGiaiDoanVaoVien = Common.clsControl.getValueInRow<string>(row["GiaiDoanVaoVien"]);
            mvarTaiBienDoPhauThau = Common.clsControl.getValueInRow<bool>(row["TaiBienDoPhauThau"]);
            mvarTaiBienDoGayMe = Common.clsControl.getValueInRow<bool>(row["TaiBienDoGayMe"]);
            mvarTaiBienDoNhiemKhuan = Common.clsControl.getValueInRow<bool>(row["TaiBienDoNhiemKhuan"]);
            mvarTaiBienKhac = Common.clsControl.getValueInRow<bool>(row["TaiBienKhac"]);
            mvarTRaVien = Common.clsControl.getValueInRow<string>(row["TRaVien"]);
            mvarNRaVien = Common.clsControl.getValueInRow<string>(row["NRaVien"]);
            mvarMRaVien = Common.clsControl.getValueInRow<string>(row["MRaVien"]);
            mvarGiaDoanRaVien = Common.clsControl.getValueInRow<string>(row["GiaDoanRaVien"]);
            mvarChanDoanTruocPhauThuat = Common.clsControl.getValueInRow<string>(row["ChanDoanTruocPhauThuat"]);
            mvarChanDoanSauPhauThuat = Common.clsControl.getValueInRow<string>(row["ChanDoanSauPhauThuat"]);
            mvarKhamBenhBenhChinh = Common.clsControl.getValueInRow<string>(row["KhamBenhBenhChinh"]);
            mvarTKhamBenh = Common.clsControl.getValueInRow<string>(row["TKhamBenh"]);
            mvarNKhamBenh = Common.clsControl.getValueInRow<string>(row["NKhamBenh"]);
            mvarMKhamBenh = Common.clsControl.getValueInRow<string>(row["MKhamBenh"]);
            mvarGiaiDoanKhamBenh = Common.clsControl.getValueInRow<string>(row["GiaiDoanKhamBenh"]);
            mvarKhamBenhBenhKemTheo = Common.clsControl.getValueInRow<string>(row["KhamBenhBenhKemTheo"]);
            mvarKhamBenhPhanBiet = Common.clsControl.getValueInRow<string>(row["KhamBenhPhanBiet"]);
            mvarTongSoNgayDieuTriSauPhauThuat = Common.clsControl.IsNullOrEmpty(row["TongSoNgayDieuTriSauPhauThuat"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TongSoNgayDieuTriSauPhauThuat"]);
            mvarTongSoLanPhauThuat = Common.clsControl.IsNullOrEmpty(row["TongSoLanPhauThuat"].ToString().ToArray()) ? int.MinValue : Common.clsControl.getValueInRow<int>(row["TongSoLanPhauThuat"]);
            mvarHinhVeHoacAnh = Common.clsControl.getValueInRow<string>(row["HinhVeHoacAnh"]);
            mvarMoTaTonThuong = Common.clsControl.getValueInRow<string>(row["MoTaTonThuong"]);
            mvarLoiDanThayThuoc = Common.clsControl.getValueInRow<string>(row["LoiDanThayThuoc"]);
            mvarPPDT = Common.clsControl.getValueInRow<string>(row["PPDT"]);
        }
        public string Add()
        {
            string rtBenhAnChiTiet_Id = "";
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "AddNew");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoVaoVien", mvarLyDoVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuaTrinhBenhLy", mvarQuaTrinhBenhLy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBanThan", mvarTienSuBanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiUng", mvarDiUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayDiUng", mvarNgayDiUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaTuy", mvarMaTuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayMaTuy", mvarNgayMaTuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@RuouBia", mvarRuouBia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRuouBia", mvarNgayRuouBia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuocLa", mvarThuocLa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThuocLa", mvarNgayThuocLa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuocLao", mvarThuocLao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThuocLao", mvarNgayThuocLao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuKhac", mvarTienSuKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTienSuKhac", mvarNgayTienSuKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuGiaDinh", mvarTienSuGiaDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhToanThan", mvarKhamBenhToanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhBoPhanTonThuong", mvarKhamBenhBoPhanTonThuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThanKinh", mvarThanKinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuanHoan", mvarTuanHoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoHap", mvarHoHap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TieuHoa", mvarTieuHoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CoXuongKhop", mvarCoXuongKhop);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TietNieu", mvarTietNieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SinhDuc", mvarSinhDuc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhKhac", mvarKhamBenhKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XetNghiemCLSCanLam", mvarXetNghiemCLSCanLam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TomTatBenhAn", mvarTomTatBenhAn);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhTienLuong", mvarKhamBenhTienLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuongDanDieuTri", mvarHuongDanDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuaTrinhBenhLyVaDienBienLamSang", mvarQuaTrinhBenhLyVaDienBienLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XNMau", mvarXNMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XNTeBao", mvarXNTeBao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XNBLGP", mvarXNBLGP);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XNXQuang", mvarXNXQuang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XNSieuAm", mvarXNSieuAm);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CacXNKhac", mvarCacXNKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhuongPhapDieuTri", mvarPhuongPhapDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPTienPhauTaiU", mvarPPTienPhauTaiU);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPTienPhauTaiHach", mvarPPTienPhauTaiHach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPDonThuanTaiU", mvarPPDonThuanTaiU);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPDonThuanTaiHach", mvarPPDonThuanTaiHach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPPhauThuat", mvarPPPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPHauPhauTaiU", mvarPPHauPhauTaiU);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPHauPhauTaiHach", mvarPPHauPhauTaiHach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPHoaChat", mvarPPHoaChat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPSoDot", mvarPPSoDot);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPDapUng", mvarPPDapUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPDieuTriKhac", mvarPPDieuTriKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhTrangNguoiBenhRaVien", mvarTinhTrangNguoiBenhRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuongDieuTriVaCheDoTiepTheo", mvarHuongDieuTriVaCheDoTiepTheo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToXQuang", mvarSoToXQuang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToCTScanner", mvarSoToCTScanner);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToSieuAm", mvarSoToSieuAm);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToXetNghiem", mvarSoToXetNghiem);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToKhac", mvarSoToKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToHoSo", mvarSoToHoSo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TVaoVien", mvarTVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NVaoVien", mvarNVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MVaoVien", mvarMVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaiDoanVaoVien", mvarGiaiDoanVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiBienDoPhauThau", mvarTaiBienDoPhauThau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiBienDoGayMe", mvarTaiBienDoGayMe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiBienDoNhiemKhuan", mvarTaiBienDoNhiemKhuan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiBienKhac", mvarTaiBienKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TRaVien", mvarTRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NRaVien", mvarNRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MRaVien", mvarMRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaDoanRaVien", mvarGiaDoanRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanTruocPhauThuat", mvarChanDoanTruocPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanSauPhauThuat", mvarChanDoanSauPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhBenhChinh", mvarKhamBenhBenhChinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TKhamBenh", mvarTKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NKhamBenh", mvarNKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MKhamBenh", mvarMKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaiDoanKhamBenh", mvarGiaiDoanKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhBenhKemTheo", mvarKhamBenhBenhKemTheo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhPhanBiet", mvarKhamBenhPhanBiet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TongSoNgayDieuTriSauPhauThuat", mvarTongSoNgayDieuTriSauPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TongSoLanPhauThuat", mvarTongSoLanPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhVeHoacAnh", mvarHinhVeHoacAnh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTaTonThuong", mvarMoTaTonThuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoiDanThayThuoc", mvarLoiDanThayThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPDT", mvarPPDT);

            rtBenhAnChiTiet_Id = ThuVien.mySQL.ExcSP(sp_BENHANCHITIET, listPara, "@BenhAnChiTiet_Id", SqlDbType.Int, 32);
            return rtBenhAnChiTiet_Id;
        }

        public string Update()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Update");

            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAnChiTiet_Id", mvarBenhAnChiTiet_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", mvarBenhAn_Id);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LyDoVaoVien", mvarLyDoVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuaTrinhBenhLy", mvarQuaTrinhBenhLy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuBanThan", mvarTienSuBanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DiUng", mvarDiUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayDiUng", mvarNgayDiUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MaTuy", mvarMaTuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayMaTuy", mvarNgayMaTuy);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@RuouBia", mvarRuouBia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayRuouBia", mvarNgayRuouBia);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuocLa", mvarThuocLa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThuocLa", mvarNgayThuocLa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThuocLao", mvarThuocLao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayThuocLao", mvarNgayThuocLao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuKhac", mvarTienSuKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NgayTienSuKhac", mvarNgayTienSuKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TienSuGiaDinh", mvarTienSuGiaDinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhToanThan", mvarKhamBenhToanThan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Mach", mvarMach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhipTho", mvarNhipTho);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NhietDo", mvarNhietDo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CanNang", mvarCanNang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApCao", mvarHuyetApCao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuyetApThap", mvarHuyetApThap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhBoPhanTonThuong", mvarKhamBenhBoPhanTonThuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ThanKinh", mvarThanKinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TuanHoan", mvarTuanHoan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HoHap", mvarHoHap);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TieuHoa", mvarTieuHoa);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CoXuongKhop", mvarCoXuongKhop);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TietNieu", mvarTietNieu);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SinhDuc", mvarSinhDuc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhKhac", mvarKhamBenhKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XetNghiemCLSCanLam", mvarXetNghiemCLSCanLam);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TomTatBenhAn", mvarTomTatBenhAn);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhTienLuong", mvarKhamBenhTienLuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuongDanDieuTri", mvarHuongDanDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@QuaTrinhBenhLyVaDienBienLamSang", mvarQuaTrinhBenhLyVaDienBienLamSang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XNMau", mvarXNMau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XNTeBao", mvarXNTeBao);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XNBLGP", mvarXNBLGP);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XNXQuang", mvarXNXQuang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@XNSieuAm", mvarXNSieuAm);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@CacXNKhac", mvarCacXNKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PhuongPhapDieuTri", mvarPhuongPhapDieuTri);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPTienPhauTaiU", mvarPPTienPhauTaiU);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPTienPhauTaiHach", mvarPPTienPhauTaiHach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPDonThuanTaiU", mvarPPDonThuanTaiU);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPDonThuanTaiHach", mvarPPDonThuanTaiHach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPPhauThuat", mvarPPPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPHauPhauTaiU", mvarPPHauPhauTaiU);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPHauPhauTaiHach", mvarPPHauPhauTaiHach);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPHoaChat", mvarPPHoaChat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPSoDot", mvarPPSoDot);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPDapUng", mvarPPDapUng);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPDieuTriKhac", mvarPPDieuTriKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TinhTrangNguoiBenhRaVien", mvarTinhTrangNguoiBenhRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HuongDieuTriVaCheDoTiepTheo", mvarHuongDieuTriVaCheDoTiepTheo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToXQuang", mvarSoToXQuang);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToCTScanner", mvarSoToCTScanner);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToSieuAm", mvarSoToSieuAm);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToXetNghiem", mvarSoToXetNghiem);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToKhac", mvarSoToKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@SoToHoSo", mvarSoToHoSo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TVaoVien", mvarTVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NVaoVien", mvarNVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MVaoVien", mvarMVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaiDoanVaoVien", mvarGiaiDoanVaoVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiBienDoPhauThau", mvarTaiBienDoPhauThau);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiBienDoGayMe", mvarTaiBienDoGayMe);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiBienDoNhiemKhuan", mvarTaiBienDoNhiemKhuan);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TaiBienKhac", mvarTaiBienKhac);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TRaVien", mvarTRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NRaVien", mvarNRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MRaVien", mvarMRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaDoanRaVien", mvarGiaDoanRaVien);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanTruocPhauThuat", mvarChanDoanTruocPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@ChanDoanSauPhauThuat", mvarChanDoanSauPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhBenhChinh", mvarKhamBenhBenhChinh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TKhamBenh", mvarTKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@NKhamBenh", mvarNKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MKhamBenh", mvarMKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@GiaiDoanKhamBenh", mvarGiaiDoanKhamBenh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhBenhKemTheo", mvarKhamBenhBenhKemTheo);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@KhamBenhPhanBiet", mvarKhamBenhPhanBiet);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TongSoNgayDieuTriSauPhauThuat", mvarTongSoNgayDieuTriSauPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@TongSoLanPhauThuat", mvarTongSoLanPhauThuat);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@HinhVeHoacAnh", mvarHinhVeHoacAnh);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@MoTaTonThuong", mvarMoTaTonThuong);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@LoiDanThayThuoc", mvarLoiDanThayThuoc);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@PPDT", mvarPPDT);

            ThuVien.mySQL.ExcSP(sp_BENHANCHITIET, listPara);
            return mvarBenhAnChiTiet_Id.ToString();
        }
        public bool Delete()
        {
            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "Delete");
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAnChiTiet_Id", mvarBenhAnChiTiet_Id);
            string rt = ThuVien.mySQL.ExcSP(sp_BENHANCHITIET, listPara);
            if (rt == "err") { return false; }
            return true;
        }
        public bool Get_By_Key(int benhAnChiTiet_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetData_ByKey");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAnChiTiet_Id", benhAnChiTiet_Id);
                ds = ThuVien.mySQL.ExcDataSet(sp_BENHANCHITIET, listPara);
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
        public bool Get_By_BenhAn_Id(int benhAn_Id)
        {
            try
            {
                DataSet ds = new DataSet();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@Action", "GetThongTinBenhAnChiTiet");
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@BenhAn_Id", benhAn_Id);
                ds = ThuVien.mySQL.ExcDataSet(sp_BENHANCHITIET, listPara);
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
