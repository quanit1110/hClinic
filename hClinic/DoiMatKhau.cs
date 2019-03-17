using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hClinic
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        

        private void btnOK_Click(object sender, EventArgs e)
        {

            bool oldPass = checkPassOld(txtOldPass.Text);
            if (!oldPass)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
            }
            else
            {
                bool samePass = checkChangePassSame(txtNewPass.Text, txtCfPass.Text);
                if (!samePass)
                {
                    MessageBox.Show("Mật khẩu không khớp! Vui lòng kiểm tra lại");
                }
                else
                {
                    bool a = ThuVien.mySQL.updateValue("update Sys_Users set User_Password=@User_Password where User_Id=@User_Id", "@User_Id", ThuVien.loadform.userID.ToString(), "@User_Password", Common.clsControl.EncodePasswordToBase64(txtNewPass.Text));
                    if (a == false)
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        this.Close();
                    }
                }
            }
        }

        private bool checkPassOld(string passOld)
        {
            string pass = ThuVien.mySQL.getValues("Select User_Password from Sys_Users where User_Id = '" + ThuVien.loadform.userID + "'");
            string decodePass = Common.clsControl.DecodeFrom64(pass);
            if (passOld != decodePass)
            {
                return false;
            }
            return true;
        }

        private bool checkChangePassSame(string passNew, string passConfirm)
        {
            if (txtNewPass.Text != txtCfPass.Text) return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
