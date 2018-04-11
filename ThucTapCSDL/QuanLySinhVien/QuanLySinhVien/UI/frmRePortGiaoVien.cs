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
    public partial class frmRePortGiaoVien : Form
    {
        public frmRePortGiaoVien()
        {
            InitializeComponent();
        }

        private void frmRePortGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_ly_sinh_vienDataSet3.GetGiaoVien' table. You can move, or remove it, as needed.
            this.getGiaoVienTableAdapter.Fill(this.quan_ly_sinh_vienDataSet3.GetGiaoVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
