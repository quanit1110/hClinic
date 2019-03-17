using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace hClinic
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            string ngay = DateTime.Now.ToString();
            txtNgay.Text = ngay.ToString();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //string path = @"C:\Windows\Log_admin\Config.txt";
            //String[] dataConfig = new String[50];
            //StreamReader sr = new StreamReader(path);
            //string line;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    dataConfig = line.Split(',');
            //}
            //config.dataSource = dataConfig[0];
            //config.catalog = dataConfig[1];
            //config.usreID = dataConfig[2];
            //config.pwUserSource = dataConfig[3];
            //config.userName_1 = dataConfig[4];
            //config.userPw_1 = dataConfig[5];
            //config.userName_2 = dataConfig[6];
            //config.userPw_2 = dataConfig[7];
            //if (config.userName_1 == txtTenDangNhap.Text & config.userPw_1 == txtPassword.Text)
            //{
            //    MainWindows frm = new MainWindows();
            //    frm.ShowDialog();
            //}
            //else if (config.userName_2 == txtTenDangNhap.Text & config.userPw_2 == txtPassword.Text)
            //{
            //    MainWindows frm = new MainWindows();
            //    frm.ShowDialog();

            //}
            //else
            //{
            //    MessageBox.Show("mat khau hoac ten nguoi dung khong chinh xac. Vui long thu lai.");
            //    txtPassword.Text = "";
            //    txtTenDangNhap.Text = "";
            //}
            txtPassword.Text = Common.clsControl.EncodePasswordToBase64(txtPassword.Text);
            String[] user = ThuVien.loadform.checkLogin(txtTenDangNhap.Text, txtPassword.Text);
            if (user.Length > 0)
            {
                ThuVien.loadform.userID = Int32.Parse(user[0]);
                ThuVien.loadform.userCode = user[1];
                ThuVien.loadform.userName = user[2];
                bool changePass = Convert.ToBoolean(ThuVien.mySQL.getValues("select Change_Password from Sys_Users where User_Id='" + Int32.Parse(user[0])+"'"));
                if (!changePass)
                {
                    DialogResult result = MessageBox.Show("Bạn chưa thay đổi mật khẩu. Bạn có muốn thay đổi mật khẩu để bảo mật thông tin cá nhân!", "Thay đổi mật khẩu!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result==DialogResult.Yes)
                    {
                        DoiMatKhau doiMK = new DoiMatKhau();
                        doiMK.ShowDialog();
                    }
                }
                ThuVien.mySQL.updateValue("update Sys_Users set Last_Login_Time=@Last_Login_Time where User_Id=@User_Id", "@User_Id", user[0], "@Last_Login_Time", DateTime.Now.ToString());
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.Vui lòng thử lại");
                txtTenDangNhap.Text = "";
                txtPassword.Text = "";
                txtTenDangNhap.Focus();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Text = Common.clsControl.EncodePasswordToBase64(txtPassword.Text);
                String[] user = ThuVien.loadform.checkLogin(txtTenDangNhap.Text, txtPassword.Text);
                if (user.Length > 0)
                {
                    ThuVien.loadform.userID = Int32.Parse(user[0]);
                    ThuVien.loadform.userCode = user[1];
                    ThuVien.loadform.userName = user[2];

                    bool changePass = Convert.ToBoolean(ThuVien.mySQL.getValues("select Change_Password from Sys_Users where User_Id='" + Int32.Parse(user[0]) + "'"));
                    if (!changePass)
                    {
                        DialogResult result = MessageBox.Show("Bạn chưa thay đổi mật khẩu. Bạn có muốn thay đổi mật khẩu để bảo mật thông tin cá nhân!", "Thay đổi mật khẩu!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            DoiMatKhau doiMK = new DoiMatKhau();
                            doiMK.ShowDialog();
                            this.Hide();
                            DangNhap dn = new DangNhap();
                            dn.ShowDialog();
                            this.Close();
                        }
                    }
                    ThuVien.mySQL.updateValue("update Sys_Users set Last_Login_Time=@Last_Login_Time where User_Id=@User_Id", "@User_Id", user[0], "@Last_Login_Time",DateTime.Now.ToString());
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.Vui lòng thử lại");
                    txtTenDangNhap.Text = "";
                    txtPassword.Text = "";
                    txtTenDangNhap.Focus();
                }
            }
        }
    }
}