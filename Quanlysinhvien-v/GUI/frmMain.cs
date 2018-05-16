using QuanLySinhVien.UI;
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
            if (type == 1)
            {               
                lblTypeChu.Text = "";
                lblTypeChu.Text = "Admin";
                kếtQuảHọcTậpToolStripMenuItem.Enabled = false;
            }           
            //giaovien type=2
            if(type == 2)
            {
                lblTypeChu.Text = "";
                lblTypeChu.Text = "Giáo viên";
                sinhvieenToolStripMenuItem.Enabled = false;
                adminToolStripMenuItem.Enabled = false;
                thongtinToolStripMenuItem.Enabled = false;
            }
            //sinhvien type=3
            if (type == 3)
            {
                lblTypeChu.Text = "";
                lblTypeChu.Text = "Sinh viên";
                giáoViênToolStripMenuItem2.Enabled = false;
                adminToolStripMenuItem.Enabled = false;
                thongtinToolStripMenuItem.Enabled = false;
            }
        }

        

        #endregion

        #region Event
        private void sinhvieenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtintaikhoan f = new frmThongtintaikhoan(LoginAccount);
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan f = new frmQuanLyTaiKhoan();
            f.Show();
        }


        #endregion

        private void lớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thongtinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lớpHọcPhầnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLopHocPhan f = new frmLopHocPhan();
            f.ShowDialog();
        }

        private void họcPhầnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHocPhan f = new frmHocPhan();
            f.ShowDialog();
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKetQuaHocTap f = new frmKetQuaHocTap(LoginAccount);
            f.ShowDialog();
        }
    }
}
