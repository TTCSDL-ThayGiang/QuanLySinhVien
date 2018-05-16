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

namespace Quanlysinhvien_v.GUI.SinhVien
{
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }
        public static SqlConnection con;
        private void connect()
        {
            String cn = @"server ='DUC-PC\SQLEXPRESS' ;database ='Quan_ly_sinh_vien' ;Integrated Security = true";//;Integrated Security = false

            con = new SqlConnection(cn);
            con.Open();

        }
        public void getdata()
        {
            String sqlSELECT = "SELECT * FROM chitiet_sv";
            SqlCommand com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong SQL
            SqlDataAdapter da = new SqlDataAdapter(com); //vận chuyển dữ liệu
            DataTable dt = new DataTable();//tạo 1 bảng ảo
            da.Fill(dt); //đổ dữ liệu vào bảng ảo
            DataRow dr = dt.Rows[0];
            txtMaSinhVien.Text = dr["Ma_sinh_vien"].ToString();
            txtHoTen.Text = dr["Ten_sinh_vien"].ToString();
            txtNgaySinh.Text = dr["Ngay_sinh"].ToString();
            cbbGioiTinh.Text = dr["Gioi_tinh"].ToString();
            txtDiaChi.Text = dr["Dia_chi"].ToString();
            txtMaLop.Text = dr["Ma_lop"].ToString();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sua = "UPDATE Sinh_vien set Ten_sinh_vien = N'" + txtHoTen.Text + "',Ngay_sinh = N'" + txtNgaySinh.Text + "',Gioi_tinh = N'" + cbbGioiTinh.Text + "',Dia_chi = '" + txtDiaChi.Text + "',Ma_lop='" + txtMaLop.Text + "' where Ma_sinh_vien = '" + txtMaSinhVien.Text + "' ";
            SqlCommand comSua = new SqlCommand(sua, con);
            comSua.ExecuteNonQuery();
            getdata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            String sqlSELECT = "drop view chitiet_sv";
            SqlCommand com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong 
            com.ExecuteNonQuery();
            this.Close();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
        }
    }
}
