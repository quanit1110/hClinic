using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using DevExpress.XtraTab;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace ThuVien
{
    public static class loadform
    {
        public static List<bool> controlBar = new List<bool>();
        public static string userName { get; set; } = "";
        public static string userCode { get; set; } = "";
        public static int userID { get; set; } = -1;
        public static int PhongBanID { get; set; } = -1;
        public static int TiepNhan_Id_DKDV { get; set; } = int.MinValue;
        public static int KhamBenh_Id_DKDV { get; set; } = int.MinValue;
        //public static int BenhNhan_Id_TnTT { get; set; } = int.MinValue;
        //public static int TiepNhan_Id_Tntt { get; set; } = int.MinValue;
        public static DataSet DataSet_Img { get; set; } = new DataSet();

        public static DataTable dataTb { get; set; } = new DataTable();

        public static string[] checkLogin(string username, string password)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "Select * from [eAccount_DongNai_B_Sys].[dbo].[Sys_Users] where User_Code='" + username + "' and User_Password='" + password + "'";
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    List<string> _data = new List<string>();
                    _data.Add(dr["User_ID"].ToString());
                    _data.Add(dr["User_Code"].ToString());
                    _data.Add(dr["User_Name"].ToString());
                    return _data.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return new string[0];
            }
            return new string[0];
        }
        public static void disableControl(Control user)
        {
            foreach (Control control in user.Controls)
            {
                if (control.GetType() == typeof(CheckBox) || control.GetType() == typeof(RadioButton))
                {
                    control.Enabled = false;
                }
                else if(control is LookUpEdit)
                {
                    (control as LookUpEdit).ReadOnly = true;
                    (control as LookUpEdit).Properties.AppearanceReadOnly.BackColor =  Color.Empty;
                }
                else if (control is TextEdit)
                {
                    (control as TextEdit).ReadOnly = true;
                    (control as TextEdit).Properties.AppearanceReadOnly.BackColor = Color.Empty;
                }
                else if (control is RichTextBox)
                {
                    (control as RichTextBox).ReadOnly = true;
                    (control as RichTextBox).BackColor = Color.Empty;
                }
                else if (control is GridControl)
                {
                    ((control as GridControl).MainView as GridView).OptionsBehavior.ReadOnly = true;
                }
                disableControl(control);
            }
        }
        public static void enableControl(Control recussiveControl)
        {
            recussiveControl.Enabled = true;
            foreach (Control control in recussiveControl.Controls)
            {
                if (control.Controls.Count != 0)
                     enableControl(control);
                if (control.GetType() == typeof(CheckBox) || control.GetType() == typeof(RadioButton))
                {
                    control.Enabled = true;
                }
                else if (control is LookUpEdit)
                {
                    (control as LookUpEdit).ReadOnly = false;
                }
                else if (control is TextEdit)
                {
                    (control as TextEdit).ReadOnly = false;
                }
                else if (control is RichTextBox)
                {
                    (control as RichTextBox).ReadOnly = false;
                    (control as RichTextBox).BackColor = Color.White;
                }
                else if (control is GridControl)
                {
                    ((control as GridControl).MainView as GridView).OptionsBehavior.ReadOnly = false;
                }
            }
        }
        public static void clearForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextEdit)
                {
                    ((TextEdit)c).Text = string.Empty;
                }

                else if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                else if (c is LookUpEdit)
                {
                    ((LookUpEdit)c).EditValue = null;
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = string.Empty;
                }
                clearForm(c);
            }
        }

        //Laays thoong tin benh nhan
        public static string[] LoadThongTinBenhNhan(string tiepnhan_id)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "Select Top 1 * from [hsvClinic].[dbo].[View_DangKyDichVu] where TiepNhan_Id='" + tiepnhan_id + "'";
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    List<string> _data = new List<string>();

                    _data.Add(dr["BenhNhan_Id"].ToString());
                    _data.Add(dr["NgayHieuLuc"].ToString());
                    _data.Add(dr["NgayHetHieuLuc"].ToString());
                    _data.Add(dr["TenBenhNhan"].ToString());
                    _data.Add(dr["GioiTinh"].ToString());


                    _data.Add(dr["NamSinh"].ToString());
                    _data.Add(dr["DiaChi"].ToString());
                    _data.Add(dr["TenDoiTuong"].ToString());
                    _data.Add(dr["DoiTuong_Id"].ToString());
                    _data.Add(dr["TenDichVu"].ToString());

                    _data.Add(dr["DichVu_Id"].ToString());
                    _data.Add(dr["SoPhieuYeuCau"].ToString());
                    _data.Add(dr["NoiYeuCau_Id"].ToString());
                    _data.Add(dr["NhomDichVu_Id"].ToString());
                    _data.Add(dr["NoiThucHien_Id"].ToString());

                    _data.Add(dr["LoaiGia_Id"].ToString());
                    _data.Add(dr["SoLuong"].ToString());
                    _data.Add(dr["DonGiaDoanhThu"].ToString());
                    _data.Add(dr["ChanDoan"].ToString());
                    _data.Add(dr["GhiChu"].ToString());

                    _data.Add(dr["BacSiChiDinh_Id"].ToString());
                    _data.Add(dr["ThoiGianYeuCau"].ToString());
                    _data.Add(dr["SoVaoVien"].ToString());
                    _data.Add(dr["KhamBenh_Id"].ToString());

                    return _data.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return new string[0];
            }
            return new string[0];
        }
        public static void XoaForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextEdit)
                {
                    ((TextEdit)c).Text = string.Empty;
                    ((TextEdit)c).Tag = null;
                }
                if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = string.Empty;
                    ((RichTextBox)c).Tag = null;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Tag = null;
                    ((CheckBox)c).Checked = false;
                }

                if (c is LookUpEdit)
                {
                    ((LookUpEdit)c).EditValue = null;
                    ((LookUpEdit)c).Tag = null;
                }
                if (c is GridControl)
                {
                    ((GridControl)c).DataSource = null;
                    ((GridControl)c).Refresh();
                }
                clearForm(c);
            }
        }

        /* Hàm load Lookupedit hai cột */
        public static void Load_Lookup_2C(LookUpEdit cbo, string value1, string value2, string table, string where)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "Select " + value1 + "," + value2 + " from " + table + " " + where + "";
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbo.Properties.DataSource = dt;
                cbo.Properties.ValueMember = "" + value1 + "";
                cbo.Properties.DisplayMember = "" + value2 + "";
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

        /* end */

        /* Hàm load Lookupedit một cột  */
        public static void Load_Lookup_1C(LookUpEdit cbo, string value1, string table, string where)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "Select " + value1 + " from " + table + " " + where + "";
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbo.Properties.DataSource = dt;
                cbo.Properties.ValueMember = "" + value1 + "";
                cbo.Properties.DisplayMember = "" + value1 + "";
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

        /* end */
        /* Hàm load Lookupedit ba cột */
        public static void Load_Lookup_3C(LookUpEdit cbo, string value1, string value2, string value3, string table, string where)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string select = "Select " + value1 + "," + value2 + "," + value3 + " from " + table + " " + where + "";
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbo.Properties.DataSource = dt;
                cbo.Properties.ValueMember = "" + value1 + "";
                cbo.Properties.DisplayMember = "" + value3 + "";
                //cbo.Properties.Tag= "" + value2 + "";
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

        /* end */
        //Hàm loadGridControl không lưu dữ liệu datatable
        public static void LoadGirdControl(GridControl grc, string sql)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            try
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                grc.DataSource = dt;
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
        //Hàm loadGridControl có lưu dữ liệu datatable
        public static void LoadGirdControl_Y(GridControl grc, DataTable dataTb, string sql)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            try
            {
                da.Fill(dataTb);
                grc.DataSource = dataTb;
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
