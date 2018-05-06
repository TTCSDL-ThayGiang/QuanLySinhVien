﻿using QuanLySinhVien.KetQuaHocTap;
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

namespace QuanLySinhVien.UI.SinhVien
{
    public partial class frmThongTin : Form
    {
        public static SqlConnection con;
        public frmThongTin()
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
        private void frmThongTin_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                String sqlSELECT = "drop view chitiet_sv";
                SqlCommand com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong 
                com.ExecuteNonQuery();
            }
            catch(Exception ex) { }
                this.Close();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            frmKetQuaHocTap frmketquahoctap = new frmKetQuaHocTap();
            frmketquahoctap.ShowDialog();

        }
    }
}
