using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public static class clsControl
    {
        public static T getValueInRow<T>(object obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T), CultureInfo.InvariantCulture);
        }


        public static bool IsNullOrEmpty<T>(T[] array)
        {
            return array == null || array.Length == 0;
        }

        public static void ExecEventControl(Control control, bool act)
        {
            if (control.GetType() == typeof(CheckBox) || control.GetType() == typeof(RadioButton))
            {
                control.Enabled = act;
            }
            else if (control is LookUpEdit)
            {
                (control as LookUpEdit).ReadOnly = act;
                (control as LookUpEdit).Properties.AppearanceReadOnly.BackColor = act == true ? Color.Empty : Color.White;
            }
            else if (control is TextEdit)
            {
                (control as TextEdit).ReadOnly = act;
                (control as TextEdit).Properties.AppearanceReadOnly.BackColor = act == true ? Color.Empty : Color.White;
            }
            else if (control is RichTextBox)
            {
                (control as RichTextBox).ReadOnly = act;
                (control as RichTextBox).BackColor = act == true?Color.Empty:Color.White;
            }
            else if (control is GridControl)
            {
                ((control as GridControl).MainView as GridView).OptionsBehavior.ReadOnly = act;
            }
        }

        public static void LoadLookup(LookUpEdit lk,string group,int numCol,string parent="",string col3="",string col_fieldname="",string col_fieldcode="",string col_name3="", string filter="")
        {
            try
            {
                DataTable dt = new DataTable();
                lk.Properties.Columns.Clear();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DataGroup", group);
                if (parent.Length > 0) { ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@AdditionPara", parent); }            
                dt = ThuVien.mySQL.ExcDataTable("sp_Sys_GetListComboData", listPara,dt);               
                if (dt.Rows.Count > 0)
                {
                    
                    for (int inedx = dt.Columns.Count - 1; inedx >= 0; inedx--)   
                    {
                        if (dt.Columns[inedx].ColumnName != "FieldName" && numCol == 1)
                        {
                            dt.Columns.Remove(dt.Columns[inedx].ColumnName);

                        }
                        if (dt.Columns[inedx].ColumnName != "FieldCode" && dt.Columns[inedx].ColumnName != "FieldName" && numCol==2 )
                        {
                            dt.Columns.Remove(dt.Columns[inedx].ColumnName);
                            
                        }
                        if (numCol == 3 && dt.Columns[inedx].ColumnName != "FieldName" && dt.Columns[inedx].ColumnName != "FieldCode" && dt.Columns[inedx].ColumnName != col3)
                        { dt.Columns.Remove(dt.Columns[inedx].ColumnName); }

                    }
                    lk.Properties.DataSource = dt;
                    if (numCol == 1)
                    {
                        lk.Properties.ValueMember = "FieldName";
                        lk.Properties.DisplayMember = "FieldName";

                        lk.Properties.Columns.Add(new LookUpColumnInfo("FieldName", col_fieldname, 50));
                    }
                    if (numCol == 2)
                    {
                        lk.Properties.ValueMember = "FieldCode";
                        lk.Properties.DisplayMember = "FieldName";

                        lk.Properties.Columns.Add(new LookUpColumnInfo("FieldCode", col_fieldcode, 20));
                        lk.Properties.Columns.Add(new LookUpColumnInfo("FieldName", col_fieldname, 50));
                    }
                    if (numCol == 3)
                    {
                        lk.Properties.ValueMember = ""+col3+"";
                        lk.Properties.DisplayMember = "FieldName";

                        lk.Properties.Columns.Add(new LookUpColumnInfo("FieldCode", col_fieldcode, 20));
                        lk.Properties.Columns.Add(new LookUpColumnInfo("FieldName", col_fieldname, 50));
                        lk.Properties.Columns.Add(new LookUpColumnInfo("" + col3 + "", col_name3, 50));
                    }
                   
                }
            }
            catch (Exception ex ){ MessageBox.Show(ex.ToString()); }
        }
        public static void LoadGirdControl(GridControl grv, string group, string additionPara , DateTime workdate , string additionPara1="", string additionPara2="", string additionPara3="", string filter = "")
        {
            try
            {
                DataTable dt = new DataTable(); 
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DataGroup", group);
                if (additionPara1.Length > 0) { ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@AdditionPara1", additionPara1); }
                if (additionPara2.Length > 0) { ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@AdditionPara2", additionPara2); }
                if (additionPara3.Length > 0) { ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@AdditionPara3", additionPara3); }
                dt = ThuVien.mySQL.ExcDataTable("sp_Sys_ListOfValues", listPara, dt);
                if (dt.Rows.Count > 0)
                {
                    grv.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        //Load gridview theo SP
        public static void LoadGirdControl_Y(GridControl grv, string Sp, List<SqlParameter> listPara)
        {
            try
            {
                DataTable dt = new DataTable();              
                dt = ThuVien.mySQL.ExcDataTable(Sp, listPara, dt);
                grv.DataSource = dt;
                
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public static void LoadLookUp(LookUpEdit lk, string group, string Id1 = "", string Id2 = "")
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd = new SqlCommand("sp_Sys_GetListComboData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DataGroup", group);
            if (Id1.Length > 0)
            {
                cmd.Parameters.AddWithValue("@TuNgay", Id1);

            }
            if (Id2.Length > 0)
            {
                cmd.Parameters.AddWithValue(" @Denngay", Id1);
            }
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                lk.Properties.DataSource = dt;
                lk.Properties.Columns.Add(new LookUpColumnInfo("FieldCode", "ID", 30));
                lk.Properties.Columns.Add(new LookUpColumnInfo("FieldName", "Ten", 30));
                lk.Properties.ValueMember = "FieldCode";
                lk.Properties.DisplayMember = "FieldName";
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        public static void GridView_SP(GridControl gv, string TenStore, string action, string ma, string where)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(TenStore, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", action);
                cmd.Parameters.AddWithValue(ma, where);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                gv.DataSource = dt;
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

        public static void LoadLK(LookUpEdit lk, string group)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd = new SqlCommand("sp_Sys_GetListComboData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DataGroup", group);
            cmd.Parameters.Add("@ColumnHeader", SqlDbType.NVarChar, 2000).Direction = ParameterDirection.Output;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                lk.Properties.DataSource = dt;
                lk.Properties.ValueMember = "FieldCode";
                lk.Properties.DisplayMember = "FieldName";
                dr.Close();
                string text = cmd.Parameters["@ColumnHeader"].Value.ToString();
                if (text.Length > 8)
                {
                    text = text.Substring(7, text.Length - 8);
                    string[] tachchuoi = text.Split('#');
                    foreach (string tt in tachchuoi)
                    {
                        string[] tachtiep = tt.Split('/');
                        string ct = tachtiep[0].ToString();
                        string fn = tachtiep[1].ToString();
                        int wt = int.Parse(tachtiep[2].ToString());
                        lk.Properties.Columns.Add(new LookUpColumnInfo(ct, fn, wt));
                    }
                }
                else
                {
                    lk.Properties.Columns.Add(new LookUpColumnInfo("FieldCode", "ID", 30));
                    lk.Properties.Columns.Add(new LookUpColumnInfo("FieldName", "Ten", 30));
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static void LoadLookUpRepos(RepositoryItemLookUpEdit lk, string group, string where = "")
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd = new SqlCommand("sp_Sys_GetListComboData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DataGroup", group);
            if (where.Length > 0)
            {
                cmd.Parameters.AddWithValue("@AdditionPara", where);
            }
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("FieldCode", typeof(string));
                dt.Columns.Add("FieldName", typeof(string));
                dt.Load(dr);
                lk.DataSource = dt;
                lk.ValueMember = "FieldCode";
                lk.DisplayMember = "FieldName";
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public static void LoadLookup_RepositoryItem(RepositoryItemLookUpEdit lk, string group, int numCol, string parent = "", string col3 = "", string col_fieldname = "", string col_fieldcode = "", string col_name3 = "", string filter = "")
        {
            try
            {
                DataTable dt = new DataTable();
                lk.Columns.Clear();
                List<SqlParameter> listPara = new List<SqlParameter>();
                ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@DataGroup", group);
                if (parent.Length > 0) { ThuVien.mySQL.AddListParaWithNullValue(ref listPara, "@AdditionPara", parent); }
                dt = ThuVien.mySQL.ExcDataTable("sp_Sys_GetListComboData", listPara, dt);
                if (dt.Rows.Count > 0)
                {

                    for (int inedx = dt.Columns.Count - 1; inedx >= 0; inedx--)
                    {
                        if (dt.Columns[inedx].ColumnName != "FieldName" && numCol == 1)
                        {
                            dt.Columns.Remove(dt.Columns[inedx].ColumnName);

                        }
                        if (dt.Columns[inedx].ColumnName != "FieldCode" && dt.Columns[inedx].ColumnName != "FieldName" && numCol == 2)
                        {
                            dt.Columns.Remove(dt.Columns[inedx].ColumnName);

                        }
                        if (numCol == 3 && dt.Columns[inedx].ColumnName != "FieldName" && dt.Columns[inedx].ColumnName != "FieldCode" && dt.Columns[inedx].ColumnName != col3)
                        { dt.Columns.Remove(dt.Columns[inedx].ColumnName); }

                    }
                    lk.DataSource = dt;
                    if (numCol == 1)
                    {
                        lk.ValueMember = "FieldName";
                        lk.DisplayMember = "FieldName";

                        lk.Columns.Add(new LookUpColumnInfo("FieldName", col_fieldname, 50));
                    }
                    if (numCol == 2)
                    {
                        lk.ValueMember = "FieldCode";
                        lk.DisplayMember = "FieldName";

                        lk.Columns.Add(new LookUpColumnInfo("FieldCode", col_fieldcode, 20));
                        lk.Columns.Add(new LookUpColumnInfo("FieldName", col_fieldname, 50));
                    }
                    if (numCol == 3)
                    {
                        lk.ValueMember = "" + col3 + "";
                        lk.DisplayMember = "FieldName";

                        lk.Columns.Add(new LookUpColumnInfo("FieldCode", col_fieldcode, 20));
                        lk.Columns.Add(new LookUpColumnInfo("FieldName", col_fieldname, 50));
                        lk.Columns.Add(new LookUpColumnInfo("" + col3 + "", col_name3, 50));
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public static DataTable LoadGirdControl_RtDt(GridControl grv, DataTable dtTable, string Sp, List<SqlParameter> listPara)
        {
            try
            {

                dtTable = ThuVien.mySQL.ExcDataTable(Sp, listPara, dtTable);
                grv.DataSource = dtTable;

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            return dtTable;
        }

        public static void loadDataForGridView(GridControl gridControl1, string nameStore, string nameAction)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> lisPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref lisPara, "@Action", nameAction);
            dt = ThuVien.mySQL.ExcDataTable(nameStore, lisPara, dt);
            gridControl1.DataSource = dt;
        }
        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        public static string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        public static string ConvertToUnSign(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            return str2;
        }
    }
}
