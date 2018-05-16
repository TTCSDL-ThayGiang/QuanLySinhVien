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
    public partial class frmQuanLyTaiKhoan : Form
    {
        BindingSource accountList = new BindingSource();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            
            Load();
        }

        public new void Load()
        {
            dtgvAccount.DataSource = accountList;
            LoadAccount();
            LoadTypeNameintoCombobox(cboTypeName);
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

        void LoadTypeNameintoCombobox(ComboBox cb)
        {
            cb.DataSource = AccountDAO.Instance.GetListTypeName();
            cb.DisplayMember = "TypeNamee";
        }

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
        
        bool Kiemtrataikhoantrung(string userName)
        {
            return AccountDAO.Instance.KiemTraTaiKhoanTrung(userName);
        }

        #endregion
        #region Event

        private void button3_Click(object sender, EventArgs e)//btnAddAccount
        {
            string userName = txtUsername.Text;
            int type = (int)numericUpDown1.Value;

            if(Kiemtrataikhoantrung(userName)==false)
            AddAccount(userName, type);
            else
            {
                MessageBox.Show("Đã tồn tại tài khoản!");
            }
        }

        private void button1_Click(object sender, EventArgs e)//btnsua
        {
            string userName = txtUsername.Text;
            int type = (int)numericUpDown1.Value;

            if (Kiemtrataikhoantrung(userName)==false)
            {             
                EditAccount(userName, type);
            }
            else
            {
                MessageBox.Show("Đã tồn tại tài khoản!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)//delete
        {
            string userName = txtUsername.Text;

            DeleteAccount(userName);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string username = (string)dtgvAccount.SelectedCells[0].OwningRow.Cells["tên đăng nhập"].Value;

            TypeNameAcc typename = AccountDAO.Instance.GetTypeNamebyuserName(username);

            cboTypeName.SelectedItem = typename;

            int index = -1;
            int i = 0;
            foreach (TypeNameAcc item in cboTypeName.Items)
            {
                if (item.TypeNamee == typename.TypeNamee)
                {
                    index = i;
                    break;
                }
                i++;
            }

            cboTypeName.SelectedIndex = index;
        }

        #endregion

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
