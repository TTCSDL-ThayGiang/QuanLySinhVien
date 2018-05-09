using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    class SinhVien
    {
        private string maSinhVien;
        private string tenSinhVien;
        private DateTime? ngaysinh;
        private string gioitinh;
        private string diaChi;
        private string malop;

        public SinhVien(DataRow row)
        {
            this.MaSinhVien = (string)row["Ma_sinh_vien"];
            this.TenSinhVien = (string)row["Ten_sinh_vien"];
            this.Ngaysinh = (DateTime?)row["Ngay_sinh"];
            this.Gioitinh = (string)row["Gioi_tinh"];
            this.DiaChi = (string)row["Dia_chi"];
            this.Malop = (string)row["Ma_lop"];
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

        public DateTime? Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
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

        public string Malop
        {
            get
            {
                return malop;
            }

            set
            {
                malop = value;
            }
        }
    }
}
