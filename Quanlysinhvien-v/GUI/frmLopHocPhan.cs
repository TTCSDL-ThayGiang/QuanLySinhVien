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

namespace Quanlysinhvien_v.GUI
{
    public partial class frmLopHocPhan : Form
    {
        BindingSource LopHocPhanList = new BindingSource();
        public frmLopHocPhan()
        {
            InitializeComponent();
            LoadLopHocPhan();
            LoadDataIntoCombobox();
            DataBinding();

        }



        private void DataBinding()
        {

            txtMalop.DataBindings.Add(new Binding("Text", dgvLopHocPhan.DataSource, "Malophocphan", true, DataSourceUpdateMode.Never));
            txtHinhThucThi.DataBindings.Add(new Binding("Text", dgvLopHocPhan.DataSource, "Hinhthucthi", true, DataSourceUpdateMode.Never));
            txtMaxSV.DataBindings.Add(new Binding("Text", dgvLopHocPhan.DataSource, "Sosinhvientoida", true, DataSourceUpdateMode.Never));
            txtGiangDuong.DataBindings.Add(new Binding("Text", dgvLopHocPhan.DataSource, "giangduong", true, DataSourceUpdateMode.Never));
            txtMaHocPhan.DataBindings.Add(new Binding("Text", dgvLopHocPhan.DataSource, "mahocphan", true, DataSourceUpdateMode.Never));
            txtMaGiaoVien.DataBindings.Add(new Binding("Text", dgvLopHocPhan.DataSource, "magiaovien", true, DataSourceUpdateMode.Never));
            dtpNgayBatDau.DataBindings.Add(new Binding("Value", dgvLopHocPhan.DataSource, "Ngaybatdau", true, DataSourceUpdateMode.Never));
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "MM/dd/yyyy";

            dtpNgayThi.DataBindings.Add(new Binding("Value", dgvLopHocPhan.DataSource, "Ngaythi", true, DataSourceUpdateMode.Never));
            dtpNgayThi.Format = DateTimePickerFormat.Custom;
            dtpNgayThi.CustomFormat = "MM/dd/yyyy";

        }


        #region Method

        private void LoadLopHocPhan()
        {
            dgvLopHocPhan.DataSource = LopHocPhanList;
            LopHocPhanList.DataSource = LopHocPhanDAO.Instance.GetListLopHocPhan();
        }


        private void LoadDataIntoCombobox()
        {
            List<NamHoc> listNamHoc = NamhocDAO.Instance.GetListNamHoc();
            cboNamHoc.DataSource = listNamHoc;
            cboNamHoc.DisplayMember = "Tennamhoc";

            int id = (cboNamHoc.SelectedItem as NamHoc).MaNamHoc;
            List<Kyhoc> listKyHoc = KyHocDAO.Instance.GetListKyHocByNamHocid(id);
            cboKyHoc.DataSource = listKyHoc;
            cboKyHoc.DisplayMember = "Tenkyhoc";

            List<HocPhan> listHocPhan = HocPhanDAO.Instance.GetListHocPhan();
            cboTenHocPhan.DataSource = listHocPhan;
            cboTenHocPhan.DisplayMember = "TenHocPhan";

            List<GiaoVien> listGiaoVien = GiaoVienDAO.Instance.GetListGiaoVien();
            cboTenGiaoVien.DataSource = listGiaoVien;
            cboTenGiaoVien.DisplayMember = "TenGiaoVien";

        }

        private string CheckChuoi(string Str)
        {
            string[] arr = Str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Str = string.Join(" ", arr);
            return Str;
        }

        List<LopHocPhan> SearchLopHocPhanbyName(string name)
        {
            List<LopHocPhan> listLopHocPhan = LopHocPhanDAO.Instance.SeachLopHocPhanByName(name);

            return listLopHocPhan;
        }
        #endregion

        #region Event

        private void txtMalop_TextChanged(object sender, EventArgs e)
        {
            string id = (string)dgvLopHocPhan.SelectedCells[0].OwningRow.Cells["mahocphan"].Value;

            HocPhan hocphan = HocPhanDAO.Instance.GetHocPhanByid(id);

            int index = -1;
            int i = 0;
            foreach (HocPhan item in cboTenHocPhan.Items)
            {
                if (item.MaHocPhan == hocphan.MaHocPhan)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cboTenHocPhan.SelectedIndex = index;

            //
            string id2 = (string)dgvLopHocPhan.SelectedCells[0].OwningRow.Cells["magiaovien"].Value;

            GiaoVien giaovien = GiaoVienDAO.Instance.GetGiaoVienByID(id2);

            int index2 = -1;
            int j = 0;
            foreach (GiaoVien item in cboTenGiaoVien.Items)
            {
                if (item.MaGiaoVien == giaovien.MaGiaoVien)
                {
                    index2 = j;
                    break;
                }
                j++;
            }
            cboTenGiaoVien.SelectedIndex = index2;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = CheckChuoi(txtMalop.Text);
            string maHocPhan = CheckChuoi((cboTenHocPhan.SelectedItem as HocPhan).MaHocPhan);
            string maGiaoVien = (cboTenGiaoVien.SelectedItem as GiaoVien).MaGiaoVien;
            int maxSV = Convert.ToInt32(txtMaxSV.Text);
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            string giangDuong = txtGiangDuong.Text;
            DateTime? ngayThi = dtpNgayThi.Value;
            string hinhThucThi = txtHinhThucThi.Text;

            if (LopHocPhanDAO.Instance.Insert(id, maHocPhan, maGiaoVien, maxSV, ngayBatDau, giangDuong, ngayThi, hinhThucThi))
            {
                MessageBox.Show("Thêm thành công!");
                LoadLopHocPhan();
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string idcu = (string)dgvLopHocPhan.SelectedCells[0].OwningRow.Cells["malophocphan"].Value;
            string idmoi = CheckChuoi(txtMalop.Text);
            string maHocPhan = CheckChuoi((cboTenHocPhan.SelectedItem as HocPhan).MaHocPhan);
            string maGiaoVien = (cboTenGiaoVien.SelectedItem as GiaoVien).MaGiaoVien;
            int maxSV = Convert.ToInt32(txtMaxSV.Text);
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            string giangDuong = txtGiangDuong.Text;
            DateTime? ngayThi = dtpNgayThi.Value;
            string hinhThucThi = txtHinhThucThi.Text;

            if (LopHocPhanDAO.Instance.Edit(idcu, idmoi, maHocPhan, maGiaoVien, maxSV, ngayBatDau, giangDuong, ngayThi, hinhThucThi))
            {
                MessageBox.Show("Sửa thành công!");
                LoadLopHocPhan();
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = CheckChuoi(txtMalop.Text);
            if (LopHocPhanDAO.Instance.Delete(id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadLopHocPhan();
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMalop_TextChanged_1(object sender, EventArgs e)
        {
            //string id = (string)dgvlophocphan.selectedcells[0].owningrow.cells["malophocphan"].value;

            //hocphan hocphan = hocphandao.instance.gethocphanbyhocphanid(id);

            //cbotenhocphan.selecteditem = hocphan;

            //int index = -1;
            //int i = 0;
            //foreach (hocphan item in cbotenhocphan.items)
            //{
            //    if (item.mahocphan == hocphan.mahocphan)
            //    {
            //        index = i;
            //        break;
            //    }
            //    i++;
            //}

            //cbotenhocphan.selectedindex = index;

        }

        private void M(object sender, EventArgs e)
        {

        }

        private void frmLopHocPhan_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbotenhocphanseash_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {          
            //LopHocPhanList.DataSource= SearchLopHocPhanbyName(CheckChuoi(txtSearch.Text));

        }

        private void chkTenhocphanSeach_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadLopHocPhan();
        }
    }
}
