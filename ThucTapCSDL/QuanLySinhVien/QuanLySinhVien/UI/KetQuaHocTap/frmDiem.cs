using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.UI.KetQuaHocTap
{
    public partial class frmDiem : Form
    {
        public static SqlConnection con;
        public frmDiem()
        {
            InitializeComponent();
        }
        private void connect()
        {
            String cn = @"server ='DUC-PC\SQLEXPRESS' ;database ='Quan_ly_sinh_vien' ;Integrated Security = true";//;Integrated Security = false

            con = new SqlConnection(cn);
            con.Open();

        }
        public void getdata()
        {
            String sqlSELECT = "SELECT * FROM Bang_diem";
            SqlCommand com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong SQL
            SqlDataAdapter da = new SqlDataAdapter(com); //vận chuyển dữ liệu
            DataTable dt = new DataTable();//tạo 1 bảng ảo
            da.Fill(dt); //đổ dữ liệu vào bảng ảo
            dataGridView1.DataSource = dt;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sua = "UPDATE Bang_diem set Ma_sinh_vien = N'" + txtMaSinhVien.Text + "',Ma_hoc_phan = N'" + txtMaHocPhan.Text + "',Diem_chuyen_can = N'" + txtDiemChuyenCan.Text + "',Diem_thuong_xuyen = '" + txtDiemThuongXuyen.Text + "',Diem_cuoi_ky='" + txtDiemCuoiKy.Text + "' where Ma_sinh_vien = '" + txtMaSinhVien.Text + "' and Ma_hoc_phan = '"+txtMaHocPhan.Text+"' ";
            SqlCommand comSua = new SqlCommand(sua, con);
            comSua.ExecuteNonQuery();
            getdata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa k?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string xoa = "DELETE from Bang_diem where Ma_sinh_vien = '" + txtMaSinhVien.Text + "' and Ma_hoc_phan = '"+txtMaHocPhan.Text+"'";
                SqlCommand comXoa = new SqlCommand(xoa, con);
                comXoa.ExecuteNonQuery();
                getdata();
            }
            else if (dialogResult == DialogResult.No)
            {
                getdata();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            txtMaSinhVien.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtMaHocPhan.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtDiemChuyenCan.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtDiemThuongXuyen.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtDiemCuoiKy.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }
    }
}
