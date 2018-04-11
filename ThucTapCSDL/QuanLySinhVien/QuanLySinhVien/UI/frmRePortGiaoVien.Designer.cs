namespace QuanLySinhVien.UI
{
    partial class frmRePortGiaoVien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quan_ly_sinh_vienDataSet3 = new QuanLySinhVien.Quan_ly_sinh_vienDataSet3();
            this.getGiaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getGiaoVienTableAdapter = new QuanLySinhVien.Quan_ly_sinh_vienDataSet3TableAdapters.GetGiaoVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quan_ly_sinh_vienDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGiaoVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "BaoCaoGiaoVien";
            reportDataSource2.Value = this.getGiaoVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.UI.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(723, 326);
            this.reportViewer1.TabIndex = 0;
            // 
            // quan_ly_sinh_vienDataSet3
            // 
            this.quan_ly_sinh_vienDataSet3.DataSetName = "Quan_ly_sinh_vienDataSet3";
            this.quan_ly_sinh_vienDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getGiaoVienBindingSource
            // 
            this.getGiaoVienBindingSource.DataMember = "GetGiaoVien";
            this.getGiaoVienBindingSource.DataSource = this.quan_ly_sinh_vienDataSet3;
            // 
            // getGiaoVienTableAdapter
            // 
            this.getGiaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmRePortGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 326);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRePortGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Giáo Viên";
            this.Load += new System.EventHandler(this.frmRePortGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quan_ly_sinh_vienDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGiaoVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Quan_ly_sinh_vienDataSet3 quan_ly_sinh_vienDataSet3;
        private System.Windows.Forms.BindingSource getGiaoVienBindingSource;
        private Quan_ly_sinh_vienDataSet3TableAdapters.GetGiaoVienTableAdapter getGiaoVienTableAdapter;
    }
}