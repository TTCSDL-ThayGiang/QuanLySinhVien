namespace QuanLySinhVien.UI
{
    partial class frmReportLopHocPhan
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cboKyHoc = new System.Windows.Forms.ComboBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quan_ly_sinh_vienDataSet = new QuanLySinhVien.Quan_ly_sinh_vienDataSet();
            this.getLopHocPhanByNamHocIDAndHocKyIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getLopHocPhanByNamHocIDAndHocKyIDTableAdapter = new QuanLySinhVien.Quan_ly_sinh_vienDataSetTableAdapters.GetLopHocPhanByNamHocIDAndHocKyIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quan_ly_sinh_vienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLopHocPhanByNamHocIDAndHocKyIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboKyHoc
            // 
            this.cboKyHoc.FormattingEnabled = true;
            this.cboKyHoc.Location = new System.Drawing.Point(71, 59);
            this.cboKyHoc.Name = "cboKyHoc";
            this.cboKyHoc.Size = new System.Drawing.Size(263, 21);
            this.cboKyHoc.TabIndex = 24;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(71, 21);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(263, 21);
            this.cboNamHoc.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kỳ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Năm học:";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(363, 19);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 25;
            this.btnReport.Text = "Xuất";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(629, 391);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "LopHocPhanByNHidAndHocKyId";
            reportDataSource1.Value = this.getLopHocPhanByNamHocIDAndHocKyIDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.UI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 97);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(692, 288);
            this.reportViewer1.TabIndex = 28;
            // 
            // quan_ly_sinh_vienDataSet
            // 
            this.quan_ly_sinh_vienDataSet.DataSetName = "Quan_ly_sinh_vienDataSet";
            this.quan_ly_sinh_vienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getLopHocPhanByNamHocIDAndHocKyIDBindingSource
            // 
            this.getLopHocPhanByNamHocIDAndHocKyIDBindingSource.DataMember = "GetLopHocPhanByNamHocIDAndHocKyID";
            this.getLopHocPhanByNamHocIDAndHocKyIDBindingSource.DataSource = this.quan_ly_sinh_vienDataSet;
            // 
            // getLopHocPhanByNamHocIDAndHocKyIDTableAdapter
            // 
            this.getLopHocPhanByNamHocIDAndHocKyIDTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportLopHocPhan
            // 
            this.AcceptButton = this.btnReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 426);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.cboKyHoc);
            this.Controls.Add(this.cboNamHoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "frmReportLopHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frmReportLopHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quan_ly_sinh_vienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLopHocPhanByNamHocIDAndHocKyIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKyHoc;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnThoat;


        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getLopHocPhanByNamHocIDAndHocKyIDBindingSource;
        private Quan_ly_sinh_vienDataSet quan_ly_sinh_vienDataSet;
        private Quan_ly_sinh_vienDataSetTableAdapters.GetLopHocPhanByNamHocIDAndHocKyIDTableAdapter getLopHocPhanByNamHocIDAndHocKyIDTableAdapter;
    }
}