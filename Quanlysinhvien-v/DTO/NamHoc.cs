using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    public class NamHoc
    {
        private int maNamHoc;
        private string tenNamHoc;
        public NamHoc(DataRow row)
        {
            this.MaNamHoc = (int)row["manamhoc"];
            this.TenNamHoc = (string)row["tennamhoc"];
        }

        public int MaNamHoc
        {
            get
            {
                return maNamHoc;
            }

            set
            {
                maNamHoc = value;
            }
        }

        public string TenNamHoc
        {
            get
            {
                return tenNamHoc;
            }

            set
            {
                tenNamHoc = value;
            }
        }
    }
}
