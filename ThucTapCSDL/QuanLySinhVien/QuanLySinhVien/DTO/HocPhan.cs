using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    public class HocPhan
    {
        private string maHocPhan;
        private string tenHocPhan;
        private int soTinChi;
        private string maHocKy;

        public HocPhan(DataRow row)
        {
            this.MaHocPhan = (string)row["Ma_hoc_phan"];
            this.TenHocPhan = (string)row["Ten_hoc_phan"];
            this.SoTinChi = (int)row["So_tin_chi"];
            this.MaHocKy = (string)row["Ma_hoc_ky"];
        }

        public string MaHocPhan
        {
            get
            {
                return maHocPhan;
            }

            set
            {
                maHocPhan = value;
            }
        }

        public string TenHocPhan
        {
            get
            {
                return tenHocPhan;
            }

            set
            {
                tenHocPhan = value;
            }
        }

        public int SoTinChi
        {
            get
            {
                return soTinChi;
            }

            set
            {
                soTinChi = value;
            }
        }

        public string MaHocKy
        {
            get
            {
                return maHocKy;
            }

            set
            {
                maHocKy = value;
            }
        }
    }
}
