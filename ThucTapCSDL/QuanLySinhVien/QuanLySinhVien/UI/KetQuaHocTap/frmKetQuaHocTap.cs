﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLySinhVien.UI.KetQuaHocTap;

namespace QuanLySinhVien.KetQuaHocTap
{
    public partial class frmKetQuaHocTap : Form
    {
        public frmKetQuaHocTap()
        {
            InitializeComponent();
        }
        public static SqlConnection con;
        private void connect()
        {
            //@"server ='DUC-PC\SQLEXPRESS' ;database ='Quan_ly_sinh_vien' ;Integrated Security = true"
            String cn = @"server ='DUC-PC\SQLEXPRESS' ;database ='Quan_ly_sinh_vien' ;Integrated Security = true";//;Integrated Security = false

            con = new SqlConnection(cn);
            con.Open();
            //hocky
            //comboBox2.Items.Add("Học kỳ 1");
            //comboBox2.Items.Add("Học kỳ 2");
            //namhoc
            
            //foreach (DataRow dr in dt.Rows)
            //{
            //    comboBox1.Items.Add(dr["Nam_hoc"].ToString());
            //}
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
        }

        private void frmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            String sqlSELECT = "select a.Ma_hoc_phan,a.Ten_hoc_phan,a.Ten_hoc_ky,a.Nam_hoc,a.So_tin_chi,b.Diem_chuyen_can,b.Diem_thuong_xuyen,b.Diem_cuoi_ky from (select c.Ma_hoc_phan,c.Ten_hoc_phan,c.So_tin_chi, d.Ten_hoc_ky,d.Nam_hoc from Hoc_phan as c,Hoc_ky as d where c.Ma_hoc_ky=d.Ma_hoc_ky) as a, Bang_diem as b where a.Ma_hoc_phan=b.Ma_hoc_phan and b.Ma_sinh_vien = N'" + txtMaSinhVien.Text + "'";
            SqlCommand com = new SqlCommand(sqlSELECT, con);//thực thi câu lệnh trong SQL
            SqlDataAdapter da = new SqlDataAdapter(com); //vận chuyển dữ liệu
            DataTable dt = new DataTable();//tạo 1 bảng ảo
            da.Fill(dt); //đổ dữ liệu vào bảng ảo
            if (dt.Rows.Count>0)
            {
                dataGridView1.DataSource = dt; // đổ dữ liệu vào dG
            }
            else MessageBox.Show("Bạn nhập không đúng mã sinh viên!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDiem frmDiem = new frmDiem();
            frmDiem.ShowDialog();
        }
    }
}
