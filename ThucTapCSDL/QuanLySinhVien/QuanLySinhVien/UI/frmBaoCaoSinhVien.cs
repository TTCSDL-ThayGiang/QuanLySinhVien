using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.UI
{
    public partial class frmBaoCaoSinhVien : Form
    {
        public frmBaoCaoSinhVien()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_ly_sinh_vienDataSet2.GetSinhVien' table. You can move, or remove it, as needed.
            this.getSinhVienTableAdapter.Fill(this.quan_ly_sinh_vienDataSet2.GetSinhVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
