using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public static class clsQrCode
    {
        public static string SoVaoVien;
        public static string BHYT;
        public static string HoTen; // QRCODE
        public static string Diachi;// QRCODE
        public static string NgaySinh;
        public static string GioiTinh;
        public static string TuNgay;
        public static string DenNgay;
        public static string NoiDangKy;
        public static string So1;
        public static string So2;
        public static string So3;
        public static string So4;
        public static string So5;
        public static string So6;
        public static string SoNha;
        public static int TinhThanh=0;
        public static int QuanHuyen=0;
        public static int PhuongXa=0;
        public static string Ngay;
        public static string Thang;
        public static string Nam;



        /* Hàm dùng để tách chuỗi QR-Code trên thẻ BHYT 
         Trả về 0 nếu lổi
         Trả về 1 nếu là BHYT , tách được quận huyện
         Trả về 2 nếu là BHYT , ko tách đc quận huyện
         Trả về 3 nếu là Qr-Code của phòng khám */
        public static int HamTachChuoi_QRCODE(string chuoi)
        {
            try
            {
                string[] tach = chuoi.Split('|');
                try
                {
                    Int32.Parse(tach[0]);
                    SoVaoVien = tach[0];
                    return 3;
                }
                catch { }

                /* Tách chuổi BHYT */

                BHYT = tach[0].ToString();

                So1 = BHYT.Substring(0, 2);
                So2 = BHYT.Substring(2, 1);
                So3 = BHYT.Substring(3, 2);
                So4 = BHYT.Substring(5, 3);
                So5 = BHYT.Substring(8, 3);
                So6 = BHYT.Substring(11, 4);
                /* End */


                /*Hàm giải mã ký tự Họ tên UTF8 */
                string ChuoiHoTen = tach[1].ToString();
                byte[] dBytes = StringToByteArray(ChuoiHoTen);
                string utf8result = System.Text.Encoding.UTF8.GetString(dBytes);
                HoTen = utf8result;
                /*End*/

                NgaySinh = tach[2].ToString();
                char[] ca = new char[] { ',', '-', '/' };
                string[] chuoiCanTach1 = NgaySinh.Split(ca);
                Ngay = chuoiCanTach1[0];
                Thang = chuoiCanTach1[1];
                Nam = chuoiCanTach1[2];


                GioiTinh = tach[3].ToString();

                /*Hàm giải mã ký tự Địa chỉ UTF8 */
                string ChuoiDiaChi = tach[4].ToString();
                byte[] dBytes1 = StringToByteArray(ChuoiDiaChi);
                string utf8result1 = System.Text.Encoding.UTF8.GetString(dBytes1);
                Diachi = utf8result1;
                /*End */

                

                NoiDangKy = tach[5].Replace(" - ", "");
                TuNgay = tach[6].ToString();
                DenNgay = tach[8].ToString();
                try
                {
                    /*Hàm tách chuổi địa chỉ */
                    char[] c = new char[] { ',', '-', ';' };
                    string[] chuoiCanTach = Diachi.Split(c);
                    SoNha = chuoiCanTach[0];
                    string sql = "SELECT DonViHanhChinh_Id FROM [hsvClinic].[dbo].[DM_DonViHanhChinh] where TenDonVi = N'";
                    
                    TinhThanh =int.Parse(ThuVien.mySQL.getValues(sql + chuoiCanTach[3].Trim() + "'"));
                    QuanHuyen = int.Parse(ThuVien.mySQL.getValues(sql + chuoiCanTach[5].Trim() + "'"));
                    PhuongXa = int.Parse(ThuVien.mySQL.getValues(sql + chuoiCanTach[4].Trim() + "'"));
                    return 1;
                }
                catch { }

                return 2;
            }
            catch { return 0; }    
        }
        /*End */
        /* Hàm dùng để tạo chuỗi QR-Code trên thẻ BHYT */
        public static string HamTaoChuoi_QRCODE(string sovaovien, string hoten, string ngaysinh, string gioitinh, string diachi, string bhyt)
        {
            string resurt = sovaovien + "|" + StringToHex(hoten) + "|" + ngaysinh + "|" + StringToHex(gioitinh) + "|" + StringToHex(diachi) + "|" + bhyt;
            return resurt;
        }
        /*End */

        /* Hàm giải mã từ Hex to UTF8 trong QR-Code */
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length / 2;
            byte[] bytes = new byte[NumberChars];
            using (var sr = new System.IO.StringReader(hex))
            {
                for (int i = 0; i < NumberChars; i++)
                    bytes[i] = Convert.ToByte(new string(new char[2] { (char)sr.Read(), (char)sr.Read() }), 16);
            }
            return bytes;

        }
        /* End */

        /* Hàm decoding từ UTF8 to Hex trong QR-Code */
        public static string StringToHex(string str)
        {
            var sb = new StringBuilder();

            var bytes = Encoding.UTF8.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString();
        }
        /* End */
    }
}
