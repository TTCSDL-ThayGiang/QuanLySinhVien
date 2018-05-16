using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    public class GiaoVien
    {
        private string maGiaoVien;
        private string tenGiaoVien;
        private bool gioiTinh;
        private string hocVi;
        private string diaChi;
        private string maKhoa;

        public GiaoVien(DataRow row)
        {
            this.MaGiaoVien = (string)row["Ma_giao_vien"];
            this.TenGiaoVien = (string)row["Ten_giao_vien"];
            this.GioiTinh = (bool)row["Gioi_tinh"];

            var HocViTemp = row["Hoc_vi"];
            if (HocViTemp.ToString() != "")
                this.HocVi = (string)HocViTemp;

            this.DiaChi = (string)row["Dia_chi"];
            this.MaKhoa = (string)row["Ma_khoa"];
        }

        public string MaGiaoVien
        {
            get
            {
                return maGiaoVien;
            }

            set
            {
                maGiaoVien = value;
            }
        }

        public string TenGiaoVien
        {
            get
            {
                return tenGiaoVien;
            }

            set
            {
                tenGiaoVien = value;
            }
        }

        public bool GioiTinh
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

        public string HocVi
        {
            get
            {
                return hocVi;
            }

            set
            {
                hocVi = value;
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

        public string MaKhoa
        {
            get
            {
                return maKhoa;
            }

            set
            {
                maKhoa = value;
            }
        }
    }
}
