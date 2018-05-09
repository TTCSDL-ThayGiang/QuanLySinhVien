namespace QuanLySinhVien.UI
{
    partial class frmLopHocPhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.txtHinhThucThi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaxSV = new DevExpress.XtraEditors.TextEdit();
            this.txtGiangDuong = new DevExpress.XtraEditors.TextEdit();
            this.txtMalop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXuatBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvLopHocPhan = new System.Windows.Forms.DataGridView();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.cboTenHocPhan = new System.Windows.Forms.ComboBox();
            this.cboTenGiaoVien = new System.Windows.Forms.ComboBox();
            this.cboKyHoc = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHinhThucThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiangDuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMalop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 42);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(795, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lớp học phần";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboKyHoc);
            this.groupControl1.Controls.Add(this.cboTenGiaoVien);
            this.groupControl1.Controls.Add(this.cboTenHocPhan);
            this.groupControl1.Controls.Add(this.cboNamHoc);
            this.groupControl1.Controls.Add(this.dtpNgayBatDau);
            this.groupControl1.Controls.Add(this.dtpNgayThi);
            this.groupControl1.Controls.Add(this.txtHinhThucThi);
            this.groupControl1.Controls.Add(this.txtMaxSV);
            this.groupControl1.Controls.Add(this.txtGiangDuong);
            this.groupControl1.Controls.Add(this.txtMalop);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(796, 190);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chi tiết";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/mm/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(465, 70);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(263, 21);
            this.dtpNgayBatDau.TabIndex = 6;
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.CustomFormat = "dd/mm/yyyy";
            this.dtpNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThi.Location = new System.Drawing.Point(465, 99);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(263, 21);
            this.dtpNgayThi.TabIndex = 7;
            // 
            // txtHinhThucThi
            // 
            this.txtHinhThucThi.Location = new System.Drawing.Point(465, 128);
            this.txtHinhThucThi.Name = "txtHinhThucThi";
            this.txtHinhThucThi.Size = new System.Drawing.Size(263, 20);
            this.txtHinhThucThi.TabIndex = 8;
            this.txtHinhThucThi.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // txtMaxSV
            // 
            this.txtMaxSV.Location = new System.Drawing.Point(465, 156);
            this.txtMaxSV.Name = "txtMaxSV";
            this.txtMaxSV.Size = new System.Drawing.Size(263, 20);
            this.txtMaxSV.TabIndex = 9;
            this.txtMaxSV.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // txtGiangDuong
            // 
            this.txtGiangDuong.Location = new System.Drawing.Point(90, 150);
            this.txtGiangDuong.Name = "txtGiangDuong";
            this.txtGiangDuong.Size = new System.Drawing.Size(263, 20);
            this.txtGiangDuong.TabIndex = 4;
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(90, 67);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(263, 20);
            this.txtMalop.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(380, 161);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(32, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "MaxSV";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Giảng đường";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(380, 132);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(61, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Hình thức thi";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(380, 103);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(40, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Ngày thi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tên giáo viên";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(380, 74);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Ngày bắt đàu";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên học phần";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(380, 45);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(12, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Kỳ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã lớp";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Năm học";
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Location = new System.Drawing.Point(721, 479);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(76, 23);
            this.btnXuatBaoCao.TabIndex = 5;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(416, 479);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(337, 479);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(258, 479);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvLopHocPhan);
            this.groupControl2.Location = new System.Drawing.Point(8, 283);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(796, 190);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chi tiết";
            // 
            // dgvLopHocPhan
            // 
            this.dgvLopHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLopHocPhan.Location = new System.Drawing.Point(2, 20);
            this.dgvLopHocPhan.Name = "dgvLopHocPhan";
            this.dgvLopHocPhan.Size = new System.Drawing.Size(792, 168);
            this.dgvLopHocPhan.TabIndex = 3;
            // 
            // simpleButton10
            // 
            this.simpleButton10.Location = new System.Drawing.Point(102, 254);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(24, 23);
            this.simpleButton10.TabIndex = 21;
            this.simpleButton10.Text = ">>";
            // 
            // simpleButton9
            // 
            this.simpleButton9.Location = new System.Drawing.Point(42, 254);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(24, 23);
            this.simpleButton9.TabIndex = 20;
            this.simpleButton9.Text = "<";
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(72, 254);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(24, 23);
            this.simpleButton8.TabIndex = 19;
            this.simpleButton8.Text = ">";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(12, 254);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(24, 23);
            this.simpleButton7.TabIndex = 18;
            this.simpleButton7.Text = "<<";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.BackColor = System.Drawing.Color.White;
            this.cboNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(90, 39);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(263, 21);
            this.cboNamHoc.TabIndex = 26;
            // 
            // cboTenHocPhan
            // 
            this.cboTenHocPhan.BackColor = System.Drawing.Color.White;
            this.cboTenHocPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.cboTenHocPhan.FormattingEnabled = true;
            this.cboTenHocPhan.Location = new System.Drawing.Point(90, 94);
            this.cboTenHocPhan.Name = "cboTenHocPhan";
            this.cboTenHocPhan.Size = new System.Drawing.Size(263, 21);
            this.cboTenHocPhan.TabIndex = 27;
            // 
            // cboTenGiaoVien
            // 
            this.cboTenGiaoVien.BackColor = System.Drawing.Color.White;
            this.cboTenGiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.cboTenGiaoVien.FormattingEnabled = true;
            this.cboTenGiaoVien.Location = new System.Drawing.Point(90, 122);
            this.cboTenGiaoVien.Name = "cboTenGiaoVien";
            this.cboTenGiaoVien.Size = new System.Drawing.Size(263, 21);
            this.cboTenGiaoVien.TabIndex = 28;
            // 
            // cboKyHoc
            // 
            this.cboKyHoc.BackColor = System.Drawing.Color.White;
            this.cboKyHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.cboKyHoc.FormattingEnabled = true;
            this.cboKyHoc.Location = new System.Drawing.Point(465, 41);
            this.cboKyHoc.Name = "cboKyHoc";
            this.cboKyHoc.Size = new System.Drawing.Size(263, 21);
            this.cboKyHoc.TabIndex = 29;
            // 
            // frmLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 514);
            this.Controls.Add(this.simpleButton10);
            this.Controls.Add(this.simpleButton9);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "frmLopHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLopHocPhan";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHinhThucThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiangDuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMalop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private DevExpress.XtraEditors.TextEdit txtMaxSV;
        private DevExpress.XtraEditors.TextEdit txtGiangDuong;
        private DevExpress.XtraEditors.TextEdit txtMalop;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXuatBaoCao;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtHinhThucThi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.DataGridView dgvLopHocPhan;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.ComboBox cboKyHoc;
        private System.Windows.Forms.ComboBox cboTenGiaoVien;
        private System.Windows.Forms.ComboBox cboTenHocPhan;
        private System.Windows.Forms.ComboBox cboNamHoc;
    }
}