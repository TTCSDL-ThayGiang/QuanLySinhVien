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
using System.Data.SqlClient;

namespace QuanLySinhVien.UI.SinhVien
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        public static SqlConnection con;
        private void connect()
        {
            String cn = @"Data Source=ADMIN\TC;Initial Catalog=Quan_ly_sinh_vien;Integrated Security=True";//;Integrated Security = false
            con = new SqlConnection(cn);
            con.Open();

        }
        public void getdata()
        {
            String sqlSELECT = "SELECT * FROM Sinh_vien";
            SqlCommand com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong SQL
            SqlDataAdapter da = new SqlDataAdapter(com); //vận chuyển dữ liệu
            DataTable dt = new DataTable();//tạo 1 bảng ảo
            da.Fill(dt); //đổ dữ liệu vào bảng ảo
            dtgvSinhVien.DataSource = dt;

        }
        #region event
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmThemSinhVien frmthemsinhvien = new frmThemSinhVien();
            frmthemsinhvien.ShowDialog();
        }
        #endregion

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sua = "UPDATE Sinh_vien set Ten_sinh_vien = N'" + txtHoTen.Text + "',Ngay_sinh = N'" + txtNgaySinh.Text + "',Gioi_tinh = N'" + cbbGioiTinh.Text + "',Dia_chi = '" + txtDiaChi.Text + "',Ma_lop='" + txtMaLop.Text + "' where Ma_sinh_vien = '" + txtMaSinhVien.Text + "' ";
            SqlCommand comSua = new SqlCommand(sua, con);
            comSua.ExecuteNonQuery();
            getdata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa k?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string xoa = "DELETE from Sinh_vien where Ma_sinh_vien = '" + txtMaSinhVien.Text + "'";
                SqlCommand comXoa = new SqlCommand(xoa, con);
                comXoa.ExecuteNonQuery();
                getdata();
            }
            else if (dialogResult == DialogResult.No)
            {
                getdata();
            }   
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            string chitiet = "create view chitiet_sv as select * from Sinh_vien where Ma_sinh_vien = '" + txtMaSinhVien.Text + "'";
            //insert into chitiet_sv values ('"+txtMaSinhVien.Text+"','" + txtHoTen.Text+"','" + txtNgaySinh.Text+ "','" + cbbGioiTinh.Text+"','" + txtDiaChi.Text+ "','" + txtMaLop.Text+"')
            SqlCommand com = new SqlCommand(chitiet, con);
            com.ExecuteNonQuery();
            frmThongTin frmthongtin = new frmThongTin();
            frmthongtin.ShowDialog();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            String sqlSELECT = "select * from Sinh_vien where Ma_sinh_vien like N'%" + txtTKMaSinhVien.Text + "%' and Ten_sinh_vien like N'%" + txtTKHoTen.Text + "%' and Ngay_sinh like N'%" + txtTKNgaySinh.Text + "%' and Gioi_tinh like N'%" + cbbTKGioiTinh.Text + "%' and Dia_chi like N'%" + txtTKDiaChi.Text + "%' and Ma_lop like N'%" + txtTKMaLop.Text + "%' ";
            SqlCommand com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong SQL
            SqlDataAdapter da = new SqlDataAdapter(com); //vận chuyển dữ liệu
            DataTable dt = new DataTable();//tạo 1 bảng ảo
            da.Fill(dt); //đổ dữ liệu vào bảng ảo
            dtgvSinhVien.DataSource = dt; // đổ dữ liệu vào dG
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvSinhVien_Click(object sender, EventArgs e)
        {
            int index = dtgvSinhVien.CurrentRow.Index;
            txtMaSinhVien.Text = dtgvSinhVien.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dtgvSinhVien.Rows[index].Cells[1].Value.ToString();
            txtNgaySinh.Text = dtgvSinhVien.Rows[index].Cells[2].Value.ToString();
            cbbGioiTinh.Text = dtgvSinhVien.Rows[index].Cells[3].Value.ToString();
            
        }
    }
}