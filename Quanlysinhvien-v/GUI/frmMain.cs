using Quanlysinhvien_v.DTO;
using Quanlysinhvien_v.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien_v
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Tạo hàm dựng cho frm Main để truyền account vào
        /// </summary>
        /// 
        private Account loginAccount;
        public frmMain(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;//truyền tài khoản đăng nhập vào
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
                ChangeAccount(loginAccount.Type);//Xet Type--3 lớp
            }
        }
        #region Method

        void ChangeAccount(int type)
        {
            //admin type=1
            adminToolStripMenuItem.Enabled = type == 1;
            thongtinToolStripMenuItem.Enabled = type == 1;
            //giaovien type=2
            if(type==1 || type == 2)
            {
                giáoViênToolStripMenuItem2.Enabled = true;
                sinhvieenToolStripMenuItem.Enabled = false;
            }
            //sinhvien type=3
            if (type == 1 || type == 3)
            {
                giáoViênToolStripMenuItem2.Enabled = false;
                sinhvieenToolStripMenuItem.Enabled = true;
            }
        }

        #endregion

        #region Event
        private void sinhvieenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtintaikhoan f = new frmThongtintaikhoan();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
