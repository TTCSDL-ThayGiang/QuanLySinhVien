using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_v.DTO
{
    public class HocKy
    {
        private string maHocKy;
        private string tenHocKy;
        private DateTime? thoiGianBatDau;
        private DateTime? thoiGianKetThuc;
        private string maLop;
        private string namHoc;

        public HocKy(DataRow row)
        {
            this.MaHocKy = (string)row["Ma_hoc_ky"];
            this.TenHocKy = (string)row["Ten_hoc_ky"];
            this.ThoiGianBatDau = (DateTime?)row["Thoi_gian_bat_dau"];

            var ThoiGianKetThucTemp = row["Thoi_gian_ket_thuc"];
            if (ThoiGianKetThuc.ToString() != "")
                this.ThoiGianKetThuc = (DateTime?)ThoiGianKetThucTemp;            

            this.MaLop = (string)row["Ma_lop"];
            this.NamHoc = row["Nam_hoc"].ToString();

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

        public string TenHocKy
        {
            get
            {
                return tenHocKy;
            }

            set
            {
                tenHocKy = value;
            }
        }

        public DateTime? ThoiGianBatDau
        {
            get
            {
                return thoiGianBatDau;
            }

            set
            {
                thoiGianBatDau = value;
            }
        }

        public DateTime? ThoiGianKetThuc
        {
            get
            {
                return thoiGianKetThuc;
            }

            set
            {
                thoiGianKetThuc = value;
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

        public string NamHoc
        {
            get
            {
                return namHoc;
            }

            set
            {
                namHoc = value;
            }
        }
    }
}
