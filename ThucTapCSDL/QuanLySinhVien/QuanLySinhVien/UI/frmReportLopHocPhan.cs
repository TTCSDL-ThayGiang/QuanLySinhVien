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
    public partial class frmReportLopHocPhan : Form
    {
        public frmReportLopHocPhan()
        {
            InitializeComponent();
            LoadDataIntoCombobox();
        }

        #region Method
        private void LoadDataIntoCombobox()
        {
            List<NamHoc> listNamHoc = NamhocDAO.Instance.GetListNamHoc();
            cboNamHoc.DataSource = listNamHoc;
            cboNamHoc.DisplayMember = "Tennamhoc";

            int id = (cboNamHoc.SelectedItem as NamHoc).MaNamHoc;
            List<Kyhoc> listKyHoc = KyHocDAO.Instance.GetListKyHocByNamHocid(id);
            cboKyHoc.DataSource = listKyHoc;
            cboKyHoc.DisplayMember = "Tenkyhoc";
        }
        #endregion

        #region Event
        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }

        private void frmReportLopHocPhan_Load(object sender, EventArgs e)
        {
            this.getLopHocPhanByNamHocIDAndHocKyIDTableAdapter.Fill(this.quan_ly_sinh_vienDataSet.GetLopHocPhanByNamHocIDAndHocKyID,(cboNamHoc.SelectedItem as NamHoc).MaNamHoc,(cboKyHoc.SelectedItem as Kyhoc).MaKyHoc);

            this.reportViewer1.RefreshReport();
        }

        #endregion

    }
}
