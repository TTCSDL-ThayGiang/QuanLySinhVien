using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_v.DTO
{
    public class SinhVien
    {
        private string maSinhVien;
        private string tenSinhVien;
        private DateTime NgaySinh;
        private string gioiTinh;
        private string diaChi;
        private string maLop;

        public SinhVien(DataRow row)
        {
            this.MaSinhVien = (string)row["Ma_sinh_vien"];
            this.TenSinhVien = (string)row["Ten_sinh_vien"];
            this.NgaySinh = (DateTime)row["Ngay_sinh"];
            this.GioiTinh = (string)row["Gioi_tinh"];
            this.DiaChi = (string)row["Dia_chi"];
            this.MaLop = (string)row["Ma_lop"];
        }

        public string MaSinhVien
        {
            get
            {
                return maSinhVien;
            }

            set
            {
                maSinhVien = value;
            }
        }

        public string TenSinhVien
        {
            get
            {
                return tenSinhVien;
            }

            set
            {
                tenSinhVien = value;
            }
        }

        public DateTime NgaySinh1
        {
            get
            {
                return NgaySinh;
            }

            set
            {
                NgaySinh = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string MaLop
        {
            get
            {
                return maLop;
            }

            set
            {
                maLop = value;
            }
        }
    }
}
