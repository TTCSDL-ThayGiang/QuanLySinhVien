namespace QuanLySinhVien.UI
{
    partial class frmReportHocPhan
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quan_ly_sinh_vienDataSet1 = new QuanLySinhVien.Quan_ly_sinh_vienDataSet1();
            this.getHocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getHocPhanTableAdapter = new QuanLySinhVien.Quan_ly_sinh_vienDataSet1TableAdapters.GetHocPhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quan_ly_sinh_vienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHocPhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BaocaoHocPhan";
            reportDataSource1.Value = this.getHocPhanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.UI.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 326);
            this.reportViewer1.TabIndex = 0;
            // 
            // quan_ly_sinh_vienDataSet1
            // 
            this.quan_ly_sinh_vienDataSet1.DataSetName = "Quan_ly_sinh_vienDataSet1";
            this.quan_ly_sinh_vienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getHocPhanBindingSource
            // 
            this.getHocPhanBindingSource.DataMember = "GetHocPhan";
            this.getHocPhanBindingSource.DataSource = this.quan_ly_sinh_vienDataSet1;
            // 
            // getHocPhanTableAdapter
            // 
            this.getHocPhanTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 326);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportHocPhan";
            this.Text = "Báo cáo học phần";
            this.Load += new System.EventHandler(this.frmReportHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quan_ly_sinh_vienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getHocPhanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Quan_ly_sinh_vienDataSet1 quan_ly_sinh_vienDataSet1;
        private System.Windows.Forms.BindingSource getHocPhanBindingSource;
        private Quan_ly_sinh_vienDataSet1TableAdapters.GetHocPhanTableAdapter getHocPhanTableAdapter;
    }
}