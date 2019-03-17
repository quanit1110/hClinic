using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ThuVien
{
    public class mySQL
    {
        SqlConnection SQLcon = new SqlConnection();
        DataTable SQLTable = new DataTable();
        public static string strconn = "Data Source=14.161.32.208\\hsvdb;Initial Catalog=hsvClinic;User ID=sa;Password=hsv*8888;Persist Security Info=true;";
        public static SqlConnection Conn()
        {
            SqlConnection conSql = new SqlConnection();
            conSql.ConnectionString = strconn;
            conSql.Open();
            return conSql;
        }
        public static SqlConnection Conntext()
        {
            SqlConnection conSql = new SqlConnection();
            conSql.ConnectionString = "Data Source=14.161.32.208\\hsvdb;Initial Catalog=eHospital_DongNai_B;User ID=sa;Password=hsv*8888;Persist Security Info=true;";
            conSql.Open();
            return conSql;
        }
        public string getProject(string descrip)
        {
            string pro = "";
            try
            {
                SQLcon.ConnectionString = strconn;
                SQLcon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Menu WHERE MenuName= '" + descrip.Trim() + "'", SQLcon);
                da.Fill(SQLTable);
                foreach (DataRow dtRow in SQLTable.Rows)
                {
                    pro = (dtRow[8].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                SQLcon.Close();
            }
            return pro;
        }
        public static DataSet PDataset(string comand)
        {
            SqlConnection SQLcon = new SqlConnection();
            SQLcon.ConnectionString = strconn;
            DataSet ds = new DataSet();
            try
            {
                SQLcon.Open();
                SqlDataAdapter da = new SqlDataAdapter(comand, SQLcon);
                da.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                SQLcon.Close();
            }
            return ds;
        }
        public static DataSet ExcDataSet(string my_sp,List<SqlParameter> lisPara)
        {

            SqlConnection con = ThuVien.mySQL.Conn();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;

            DataSet dt = new DataSet();
            
            try
            {
                using (cmd = new SqlCommand(my_sp, con))
                cmd.CommandType = CommandType.StoredProcedure;
                for(int i = 0; i < lisPara.Count; i++) { cmd.Parameters.Add(lisPara[i]); }
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch(Exception ex)
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
        public static DataTable ExcDataTable(string my_sp, List<SqlParameter> lisPara,DataTable dt)
        {

            SqlConnection con = ThuVien.mySQL.Conn();
            SqlDataReader dr;
            SqlCommand cmd;

            try
            {
                using (cmd = new SqlCommand(my_sp, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < lisPara.Count; i++) { cmd.Parameters.Add(lisPara[i]); }
                dr = cmd.ExecuteReader();  
                dt.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public static void AddListParaWithNullValue(ref List<SqlParameter> lisPara, string parameterName, object value)
        {
            try
            {
                if (value.GetType() == typeof(int) && int.Parse(value.ToString()) == int.MinValue)
                    lisPara.Add(new SqlParameter(parameterName, DBNull.Value));
                else if (value.GetType() == typeof(short) && short.Parse(value.ToString()) == short.MinValue)
                    lisPara.Add(new SqlParameter(parameterName, DBNull.Value));
                else if (value.GetType() == typeof(Decimal) && Decimal.Parse(value.ToString()) == Decimal.MinValue)
                    lisPara.Add(new SqlParameter(parameterName, DBNull.Value));
                else if (value.GetType() == typeof(byte) && byte.Parse(value.ToString()) == byte.MinValue)
                    lisPara.Add(new SqlParameter(parameterName, DBNull.Value));
                else if (value.GetType() == typeof(string) && (value as string) == string.Empty)
                    lisPara.Add(new SqlParameter(parameterName, DBNull.Value));
                else if (value.GetType() == typeof(DateTime) && DateTime.Parse(value.ToString()) == DateTime.MinValue)
                    lisPara.Add(new SqlParameter(parameterName, DBNull.Value));
                else
                    lisPara.Add(new SqlParameter(parameterName, value));
            }
            catch { }
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
        /* Hàm thông báo lỗi Connection */
        public static void Message_Show(Exception e)
        {
            MessageBox.Show(e.Message);
        }
        /* End */
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

        //Check nuul values 
        public static SqlParameter AddWithNullableValue(SqlParameterCollection collection, string parameterName, object value)
        {
            try
            {
                string a = value.ToString();
                if (a.Trim().Length == 0)
                {
                    return collection.AddWithValue(parameterName, DBNull.Value);
                }
            }
            catch { }
            if (value == null)
                return collection.AddWithValue(parameterName, DBNull.Value);
            else
                return collection.AddWithValue(parameterName, value);
        }
        //hàm lấy một giá trị 
        public static string getValues(string sqlString)
        {

            SqlConnection con = ThuVien.mySQL.Conn();

            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(sqlString, con);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                foreach (DataRow dtRow in dt.Rows)
                {
                    return dtRow[0].ToString();
                }
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
            return "";
        }

        public static String ExcSP(String my_sp, List<SqlParameter> lisPara, String rtValue = "",SqlDbType type=SqlDbType.Int,int size=int.MinValue)
        {

            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;

            try
            {
                using (cmd = new SqlCommand(my_sp, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < lisPara.Count; i++) { cmd.Parameters.Add(lisPara[i]); }
                if (rtValue != "")
                {
                    var rs = cmd.Parameters.Add(rtValue, type, size);
                    rs.Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    return rs.Value.ToString();
                }
                else
                    cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return "err";
            }
            finally
            {
                con.Close();
            }
            return "";
        }

        public static DataRow RtDataRow(String sql)
        {
            SqlConnection con = ThuVien.mySQL.Conn();

            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if(dt.Rows.Count>0)
                {
                    return dt.Rows[0];
                }
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
            return null;
        }
        public static DataRow RtDataRowSP(String my_sp, List<SqlParameter> lisPara)
        {

            SqlConnection con = ThuVien.mySQL.Conn();
            SqlCommand cmd;
            SqlDataReader rd;
            DataTable dt = new DataTable();
            DataRow dtr=dt.NewRow();
            try
            {
                using (cmd = new SqlCommand(my_sp, con))
                    cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < lisPara.Count; i++) { cmd.Parameters.Add(lisPara[i]); }
                
                 rd=cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0) { return dt.Rows[0]; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return dtr;
            }
            finally
            {
                con.Close();
            }
            return dtr;
        }

        public static void Load_Lookup_PR(LookUpEdit cbo, string TenStore, string action, string value1, string value2)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(TenStore, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", action);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("" + value1 + "", typeof(string));
                dt.Columns.Add("" + value2 + "", typeof(string));
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

        public static DataTable ExcDT(string descrip)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            DataTable dt = new DataTable();
            SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(descrip, con);
                dr = cmd.ExecuteReader();  
                dt.Load(dr);            
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

        public static bool updateValue(string nameSql, params string[] value)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            //DataTable dt = new DataTable();
            //SqlDataReader dr;
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand(nameSql, con);
                for(int i = 0; i < value.Length; i++)
                {
                    cmd.Parameters.AddWithValue(value[i], value[i=i + 1]);
                }
                cmd.ExecuteReader();
                return true;
                //dt.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        //param[0]: tên store
        //param[1]: tên action
        //param[2]: giá trị của action
        //param[3]: tên trường lấy giá trị
        public static string getIdByNameFiled(string nameFiled, params string[] param)
        {

            List<SqlParameter> listPara = new List<SqlParameter>();
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, param[1], param[2]);
            ThuVien.mySQL.AddListParaWithNullValue(ref listPara, param[3], nameFiled);
            DataTable dt = new DataTable();
            dt = ThuVien.mySQL.ExcDataTable(param[0], listPara, dt);
            if (dt.Rows.Count<=0)
            {
                return null;
            }
            else
            {
                return dt.Rows[0].ItemArray[0].ToString();
            }
            
        }
    }
}
