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
    public partial class frmKetQuaHocTap : Form
    {
        private Account loginAccount;
        public frmKetQuaHocTap(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadThongTin();
            LoadDataIntoCombobox();
            LoadDataGriview();
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
            DTO.SinhVien sv = SinhVienDAO.Instance.GetSinhVienbyid(LoginAccount.UserName);
            lblMaSinhVien.Text = (string)LoginAccount.UserName;
            lblTenSinhVien.Text = (sv.TenSinhVien);
        }
        void LoadDataGriview()
        {
            int index = cboHocky.SelectedIndex+1;
            //string hocky = cboHocky.SelectedItem.ToString();
            string hocky = index.ToString();
            dtgvKetQua.DataSource = KetQuaHocTapDAO.Instance.GetKetQuaHocTapByHocKy(hocky);
        }
        void LoadDataIntoCombobox()
        {

            List<HocKy> listHocKy = HocKyDAO.Instance.GetListHocKy();
            cboHocky.DataSource = listHocKy;
            cboHocky.DisplayMember = "tenhocky";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkCanam.Checked)
            {
                //load data ca nam
                dtgvKetQua.DataSource = null;
                dtgvKetQua.DataSource = KetQuaHocTapDAO.Instance.GetKetQuaCaNam();
            }
            else
            {
                LoadDataGriview();
            }
        }
    }
    #endregion

}
