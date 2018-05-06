namespace QuanLySinhVien.KetQuaHocTap
{
    partial class frmKetQuaHocTap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoc_ky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam_hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_tin_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Hoc_ky,
            this.Nam_hoc,
            this.So_tin_chi});
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(892, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ma_hoc_phan";
            this.Column2.HeaderText = "Mã học phần";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ten_hoc_phan";
            this.Column3.HeaderText = "Học phần";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Diem_chuyen_can";
            this.Column5.HeaderText = "Điểm chuyên cần";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Diem_thuong_xuyen";
            this.Column6.HeaderText = "Điểm thường xuyên";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Diem_cuoi_ky";
            this.Column7.HeaderText = "Điểm cuối kỳ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Hoc_ky
            // 
            this.Hoc_ky.DataPropertyName = "Ten_hoc_ky";
            this.Hoc_ky.HeaderText = "Học kỳ";
            this.Hoc_ky.Name = "Hoc_ky";
            this.Hoc_ky.ReadOnly = true;
            // 
            // Nam_hoc
            // 
            this.Nam_hoc.DataPropertyName = "Nam_hoc";
            this.Nam_hoc.HeaderText = "Năm học";
            this.Nam_hoc.Name = "Nam_hoc";
            this.Nam_hoc.ReadOnly = true;
            // 
            // So_tin_chi
            // 
            this.So_tin_chi.DataPropertyName = "So_tin_chi";
            this.So_tin_chi.HeaderText = "Số tín chỉ";
            this.So_tin_chi.Name = "So_tin_chi";
            this.So_tin_chi.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kết quả học tập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã sinh viên";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(93, 19);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(179, 20);
            this.txtMaSinhVien.TabIndex = 20;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Location = new System.Drawing.Point(486, 19);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnXemKetQua.TabIndex = 21;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMaSinhVien);
            this.groupBox1.Controls.Add(this.btnXemKetQua);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 462);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Cập nhật điểm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmKetQuaHocTap";
            this.Text = "Kết quả học tập";
            this.Load += new System.EventHandler(this.frmKetQuaHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoc_ky;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam_hoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_tin_chi;
        private System.Windows.Forms.Button button1;
    }
}