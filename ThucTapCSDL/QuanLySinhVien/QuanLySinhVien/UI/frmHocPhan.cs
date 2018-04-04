using QuanLySinhVien.DAO;
using QuanLySinhVien.DTO;
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
            txtMaHP.DataBindings.Add(new Binding("Text", dtgvHocPhan.DataSource, "Mahocphan",true,DataSourceUpdateMode.Never));
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

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeach_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgvHocPhan.DataSource = SeachHocPhanBytext(txtSeach.Text);
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
