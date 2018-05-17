using QuanLySinhVien.DAO;
using QuanLySinhVien.DTO;
using Quanlysinhvien_v.DAO;
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

namespace QuanLySinhVien.UI
{
    public partial class frmHocPhan : Form
    {
        BindingSource HocPhanList = new BindingSource();

        public frmHocPhan()
        {
            InitializeComponent();
            LoadData();

            DataBinding();
        }

        #region Method

        private void LoadData()
        {
            dtgvHocPhan.DataSource = HocPhanList;
            HocPhanList.DataSource = HocPhanDAO.Instance.GetListHocPhan();
        }

        private void DataBinding()
        {
            txtMaHP.DataBindings.Add(new Binding("Text", dtgvHocPhan.DataSource, "Mahocphan", true, DataSourceUpdateMode.Never));
            txtTenHP.DataBindings.Add(new Binding("Text", dtgvHocPhan.DataSource, "Tenhocphan", true, DataSourceUpdateMode.Never));
            txtSoTin.DataBindings.Add(new Binding("Text", dtgvHocPhan.DataSource, "Sotinchi", true, DataSourceUpdateMode.Never));
            txtHocKy.DataBindings.Add(new Binding("Text", dtgvHocPhan.DataSource, "Mahocky", true, DataSourceUpdateMode.Never));
            //
        }

        List<HocPhan> SeachHocPhanBytext(string text)
        {
            List<HocPhan> listHocPhan = HocPhanDAO.Instance.SeachHocPhanByName(text);

            return listHocPhan;
        }

        private string CheckChuoi(string Str)
        {
            string[] arr = Str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Str = string.Join(" ", arr);
            return Str;
        }

        void AddHocPhan(string userName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }
            LoadData();
        }
        void EditHocPhan(string userName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại!");
            }
            LoadData();
        }

        void DeleteHocPhan(string userName)
        {
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!");
            }
            LoadData();
        }
        #endregion

        #region event

        #endregion
        private void txtSeach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeach_Click(object sender, EventArgs e)
        {
            HocPhanList.DataSource= SeachHocPhanBytext(CheckChuoi(txtSeach.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//btn tim
        {
            dtgvHocPhan.DataSource = SeachHocPhanBytext(txtSeach.Text);
        }

        private void btnTailai_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
