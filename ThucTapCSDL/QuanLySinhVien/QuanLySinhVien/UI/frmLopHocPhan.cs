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

namespace QuanLySinhVien.LopHocPhan
{
    public partial class frmLopHocPhan : Form
    {

        public frmLopHocPhan()
        {
            InitializeComponent();
            LoadLopHocPhan();
            LoadDataIntoCombobox();
            DataBinding();
        }

        private void DataBinding()
        {
            txtMalop.DataBindings.Add(new Binding("Text", dgvLopHocPhan, "Ma_lop_hoc_phan", true, DataSourceUpdateMode.Never));
            txtHinhThucThi.DataBindings.Add(new Binding("Text", dgvLopHocPhan, "Hinh_thuc_thi", true, DataSourceUpdateMode.Never));
            //dtpNgayBatDau.DataBindings.Add(new Binding("Value",dgvLopHocPhan, "Ngay_bat_dau",true,DataSourceUpdateMode.Never));
            //dtpNgayThi.DataBindings.Add(new Binding("Value", dgvLopHocPhan, "Ngay_bat_dau", true, DataSourceUpdateMode.Never));
            
            
        }


        #region Method
        private void LoadLopHocPhan()
        {
            dgvLopHocPhan.DataSource = LopHocPhanDAO.Instance.GetListLopHocPhan();
        }

        private void LoadDataIntoCombobox()
        {
            List<HocPhan> listHocPhan = HocPhanDAO.Instance.GetListHocPhan();
            cboTenHocPhan.DataSource = listHocPhan;
            cboTenHocPhan.DisplayMember = "TenHocPhan";

            List<DTO.GiaoVien> listGiaoVien = GiaoVienDAO.Instance.GetListGiaoVien();
            cboTenGiaoVien.DataSource = listGiaoVien;
            cboTenGiaoVien.DisplayMember = "TenGiaoVien";
        }

       
        #endregion

        #region Event

        #endregion

    }
}
