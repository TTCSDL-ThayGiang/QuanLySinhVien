using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLySinhVien.DAO;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.UI
{
    public partial class frmLopHocPhan : DevExpress.XtraEditors.XtraForm
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

            txtMalop.DataBindings.Add(new Binding("Text", dgvLopHocPhan.DataSource, "Malophocphan", true, DataSourceUpdateMode.Never));
            txtHinhThucThi.DataBindings.Add(new Binding("Text", dgvLopHocPhan.DataSource, "Hinhthucthi", true, DataSourceUpdateMode.Never));
            txtMaxSV.DataBindings.Add(new Binding("Text", dgvLopHocPhan.DataSource, "Sosinhvientoida", true, DataSourceUpdateMode.Never));
            txtGiangDuong.DataBindings.Add(new Binding("Text", dgvLopHocPhan.DataSource, "giangduong", true, DataSourceUpdateMode.Never));
            dtpNgayBatDau.DataBindings.Add(new Binding("Value", dgvLopHocPhan.DataSource, "Ngaybatdau", true, DataSourceUpdateMode.Never));
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "MM/dd/yyyy";

            dtpNgayThi.DataBindings.Add(new Binding("Value", dgvLopHocPhan.DataSource, "Ngaythi", true, DataSourceUpdateMode.Never));
            dtpNgayThi.Format = DateTimePickerFormat.Custom;
            dtpNgayThi.CustomFormat = "MM/dd/yyyy";

        }
        private void LoadLopHocPhan()
        {
            dgvLopHocPhan.DataSource = LopHocPhanDAO.Instance.GetListLopHocPhan();
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

            List<DTO.GiaoVien> listGiaoVien = GiaoVienDAO.Instance.GetListGiaoVien();
            cboTenGiaoVien.DataSource = listGiaoVien;
            cboTenGiaoVien.DisplayMember = "TenGiaoVien";

        }

        private string CheckChuoi(string Str)
        {
            string[] arr = Str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Str = string.Join(" ", arr);
            return Str;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

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

            DTO.GiaoVien giaovien = GiaoVienDAO.Instance.GetGiaoVienByID(id2);

            int index2 = -1;
            int j = 0;
            foreach (DTO.GiaoVien item in cboTenGiaoVien.Items)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = CheckChuoi(txtMalop.Text);
            string maHocPhan = CheckChuoi((cboTenHocPhan.SelectedItem as HocPhan).MaHocPhan);
            string maGiaoVien = (cboTenGiaoVien.SelectedItem as DTO.GiaoVien).MaGiaoVien;
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
            string maGiaoVien = (cboTenGiaoVien.SelectedItem as DTO.GiaoVien).MaGiaoVien;
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

        
    }
}