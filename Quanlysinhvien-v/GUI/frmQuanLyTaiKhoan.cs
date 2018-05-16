using Quanlysinhvien_v.DAO;
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
    public partial class frmQuanLyTaiKhoan : Form
    {
        BindingSource accountList = new BindingSource();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            
            Load();
        }

        void Load()
        {
            dtgvAccount.DataSource = accountList;
            LoadAccount();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            txtUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "tên đăng nhập", true, DataSourceUpdateMode.Never));
            //numericUpDown1.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
            
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        #region Method

        void AddAccount(string userName, int type)
        {
            if(AccountDAO.Instance.InsertAccount(userName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }
            LoadAccount();
        }
        void EditAccount(string userName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại!");
            }
            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!");
            }
            LoadAccount();
        }
        

        #endregion
        #region Event

        private void button3_Click(object sender, EventArgs e)//btnAddAccount
        {
            string userName = txtUsername.Text;
            int type = (int)numericUpDown1.Value;

            AddAccount(userName, type);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            int type = (int)numericUpDown1.Value;

            EditAccount(userName, type);
        }

        private void button2_Click(object sender, EventArgs e)//delete
        {
            string userName = txtUsername.Text;

            DeleteAccount(userName);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
