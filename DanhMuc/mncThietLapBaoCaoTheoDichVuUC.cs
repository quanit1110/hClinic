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

namespace DanhMuc
{
    public partial class mncThietLapBaoCaoTheoDichVuUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncThietLapBaoCaoTheoDichVuUC()
        {
            InitializeComponent();
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
            tvMauBaoCao.ImageList = imageList1;
            tvChiTiet.ImageList = imageList1;
            ThuVien.DanhMuc.TreeDMMauBaoCao(tvMauBaoCao);
            ThuVien.DanhMuc.loadTV(tvChiTiet);

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

        string ma;
        private void tvMauBaoCao_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvChiTiet.Nodes.Clear();
            string level = e.Node.Level.ToString();
            if (level == "1")
            {
                ma = e.Node.Tag.ToString();
                ThuVien.DanhMuc.loadTV(tvChiTiet);
                DataSet ds = ThuVien.mySQL.PDataset("select DichVu_Id from [mHIS_Hethong].[dbo].[view_DM_DinhNghiaDichVu] where NhomBaoCao_Id = "+ma+"");
                foreach (DataRow dr2 in ds.Tables[0].Rows)
                {
                    int text = Int32.Parse(dr2["DichVu_Id"].ToString());
                    foreach (TreeNode child in tvChiTiet.Nodes)
                    {
                        foreach (TreeNode con in child.Nodes)
                        {
                            foreach (TreeNode con1 in con.Nodes)
                            {
                                if (con1.Checked == false)
                                {
                                    int nodecon = Int32.Parse(con1.Tag.ToString());
                                    if (text == nodecon)
                                    {
                                        con1.Checked = true;
                                    }
                                    else
                                    {
                                        con1.Checked = false;
                                    }
                                }
                            }
                        }

                    }
                }
               
            }
        }
    }
}
