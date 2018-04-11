namespace QuanLySinhVien.UI
{
    partial class frmBaoCaoSinhVien
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
            this.quan_ly_sinh_vienDataSet2 = new QuanLySinhVien.Quan_ly_sinh_vienDataSet2();
            this.getSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getSinhVienTableAdapter = new QuanLySinhVien.Quan_ly_sinh_vienDataSet2TableAdapters.GetSinhVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quan_ly_sinh_vienDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "BaoCaoSinhVien";
            reportDataSource2.Value = this.getSinhVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.UI.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(723, 326);
            this.reportViewer1.TabIndex = 0;
            // 
            // quan_ly_sinh_vienDataSet2
            // 
            this.quan_ly_sinh_vienDataSet2.DataSetName = "Quan_ly_sinh_vienDataSet2";
            this.quan_ly_sinh_vienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getSinhVienBindingSource
            // 
            this.getSinhVienBindingSource.DataMember = "GetSinhVien";
            this.getSinhVienBindingSource.DataSource = this.quan_ly_sinh_vienDataSet2;
            // 
            // getSinhVienTableAdapter
            // 
            this.getSinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 326);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo Sinh viên";
            this.Load += new System.EventHandler(this.frmBaoCaoSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quan_ly_sinh_vienDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Quan_ly_sinh_vienDataSet2 quan_ly_sinh_vienDataSet2;
        private System.Windows.Forms.BindingSource getSinhVienBindingSource;
        private Quan_ly_sinh_vienDataSet2TableAdapters.GetSinhVienTableAdapter getSinhVienTableAdapter;
    }
}