namespace Quanlysinhvien_v.GUI.Baocao
{
    partial class frmBaoCaoLopHocPhan
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
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.cboKyHoc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(71, 18);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(263, 21);
            this.cboNamHoc.TabIndex = 29;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnThoat.Location = new System.Drawing.Point(644, 388);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(363, 16);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 31;
            this.btnReport.Text = "Xuất";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // cboKyHoc
            // 
            this.cboKyHoc.FormattingEnabled = true;
            this.cboKyHoc.Location = new System.Drawing.Point(71, 56);
            this.cboKyHoc.Name = "cboKyHoc";
            this.cboKyHoc.Size = new System.Drawing.Size(263, 21);
            this.cboKyHoc.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Kỳ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Năm học:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(15, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 283);
            this.panel1.TabIndex = 33;
            // 
            // frmBaoCaoLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(731, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboNamHoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.cboKyHoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "frmBaoCaoLopHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Lớp Học Phần";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox cboKyHoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}