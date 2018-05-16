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
    public partial class frmKetQuaHocTap : Form
    {
        private Account loginAccount;
        public frmKetQuaHocTap(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadThongTin();
        }

        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }

            set
            {
                loginAccount = value;
            }
        }
        #region Method

        void LoadThongTin()
        {
            lblMaSinhVien.Text = (string)LoginAccount.UserName;
        }
        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
