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
    public partial class frmThemDiem : Form
    {
        public static SqlConnection con;
        public frmThemDiem()
        {
            InitializeComponent();
        }
        private void connect()
        {
            String cn = @"server ='DUC-PC\SQLEXPRESS' ;database ='Quan_ly_sinh_vien' ;Integrated Security = true";
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
            
        }

        private void frmThemDiem_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã sinh viên");
            }

            else
            {
                string them = "insert into Bang_diem values ('" + txtMaSinhVien.Text + "',N'" + txtMaHocPhan.Text + "',N'" + txtDiemChuyenCan.Text + "',N'" + txtDiemThuongXuyen.Text + "',N'" + txtDiemCuoiKy.Text + "')";
                SqlCommand comThem = new SqlCommand(them, con);
                comThem.ExecuteNonQuery();
                getdata();
                MessageBox.Show("Thêm mới thành công ");
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }
    }
}
