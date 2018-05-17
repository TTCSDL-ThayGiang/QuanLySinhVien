using Quanlysinhvien_v.DAO;
using Quanlysinhvien_v.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien_v.GUI
{
    public partial class frmThongtintaikhoan : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }

            set
            {
                loginAccount = value;
                ChangeAccount(loginAccount);//Xet Type--3 lớp
            }
        }
        public frmThongtintaikhoan(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        #region method

        void ChangeAccount(Account acc)
        {
            txtUsername.Text = LoginAccount.UserName;
            if (LoginAccount.Type == 1)
                txtLoaitaikhoan.Text = "Admin";
            if (LoginAccount.Type == 2)
            {
                txtLoaitaikhoan.Text = "Giáo viên";
            }
            if (LoginAccount.Type == 3)
            {
                txtLoaitaikhoan.Text = "Học sinh";
            }
        }

        void UpdateAccount()
        {
            string passWord = txtpassWord.Text;
            string newpass = txtnewPassWord.Text;
            string reenterPass = txtReNewPassword.Text;
            string userName = txtUsername.Text;
            if (newpass!=reenterPass)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                txtpassWord.Text = "";
                txtnewPassWord.Text = "";
                txtReNewPassword.Text = "";
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, passWord, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!");
                }
            }
        }
        #endregion

        #region event
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
