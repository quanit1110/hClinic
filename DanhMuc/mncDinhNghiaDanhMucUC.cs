using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ThuVien;
using System.Data.SqlClient;

namespace DanhMuc
{
    public partial class mncDinhNghiaDanhMucUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncDinhNghiaDanhMucUC()
        {
            InitializeComponent();
            tviewDinhNghiaDanhMuc.ImageList = imageList1;
            //ThuVien.clsDinhNghiaDanhMuc.loadTV(tviewDinhNghiaDanhMuc);
            ThuVien.loadform.disableControl(this);
            //lấy kích thước của màn hình
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hiển thị theo kích thước của màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;

            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1386 là chiều rộng, 788 là chiều cao Form khi thiết kế, xem trong Properties của Form
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
        }
        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                //gọi đệ quy nếu như 1 control nào có chứa các control khác nữa

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                //canh lại toạ độ x, y, chiều rộng, cao cho các control trên form

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }
    

        private void tviewDinhNghiaDanhMuc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            txtID.Text = e.Node.Tag.ToString();
        }


        private void txtID_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = ThuVien.mySQL.Conn();
            string sql = "select * from DinhNghiaDanhMuc where Dictionary_Type_Id=" + txtID.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtMaDanhMuc.Text = dt.Rows[0]["Dictionary_Type_Code"].ToString();
            txtTenDanhMuc.Text = dt.Rows[0]["Dictionary_Type_Name"].ToString();
            txtTenDanhMucE.Text = dt.Rows[0]["Dictionary_Type_Name_En"].ToString();
            txtTenDanhMucR.Text = dt.Rows[0]["Dictionary_Type_Name_Ru"].ToString();
            txtCap.Text = dt.Rows[0]["Level1"].ToString();
            lkCapTren.Properties.NullText = dt.Rows[0]["Parent_Id"].ToString();
            txtIdx.Text = dt.Rows[0]["Idx"].ToString();

            if (dt.Rows[0]["Enabled"].ToString() == "True")
            {

                cbEnable.Checked = true;
            }
            else
            {
                cbEnable.Checked = false;

            }
            if (dt.Rows[0]["LoadControl"].ToString() == "True")
            {
                cbLoad.Checked = true;
            }
            else
            {
                cbLoad.Checked = false;

            }
            if (dt.Rows[0]["IsSystem"].ToString() == "True")
            {
                cbSystem.Checked = true;
            }
            else
            {
                cbSystem.Checked = false;

            }
            txtTableName.Text = dt.Rows[0]["Table_Name"].ToString();
            txtProcedureName.Text = dt.Rows[0]["Procedure_Name"].ToString();
            txtUsingColumns.Text = dt.Rows[0]["UsingColumns"].ToString();
            txtLOV.Text = dt.Rows[0]["ListOfValueColumns"].ToString();
            txtComboCl.Text = dt.Rows[0]["ComboBoxColumns"].ToString();
            txtRequired.Text = dt.Rows[0]["RequiredColumns"].ToString();
            txtAb1.Text = dt.Rows[0]["Attribute1"].ToString();
            txtAb2.Text = dt.Rows[0]["Attribute2"].ToString();

            if (dt.Rows[0]["ShowRowNumberValue"].ToString() == "True")
            {
                ckbShowHide.Checked = true;
            }
            else
            {
                ckbShowHide.Checked = false;

            }
        }
    }
}
