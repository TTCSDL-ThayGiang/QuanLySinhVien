using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    public class LopHocPhan
    {
        private string maLopHocPhan;
        private string maHocPhan;
        private string maGiaoVien;
        private int soSinhVienToiDa;
        private DateTime ngayBatDau;        
        private string giangDuong;
        private DateTime? ngayThi;
        private string hinhThucThi;

        public LopHocPhan(DataRow row)
        {
            this.MaLopHocPhan = (string)row["Ma_lop_hoc_phan"];
            this.MaHocPhan = (string)row["Ma_hoc_phan"];
            this.MaGiaoVien = (string)row["Ma_giao_vien"];
            this.SoSinhVienToiDa = (int)row["So_sv_toi_da"];
            this.NgayBatDau = (DateTime)row["Ngay_bat_dau"];
            this.GiangDuong = (string)row["Giang_duong"];
            this.HinhThucThi = (string)row["Hinh_thuc_thi"];
            var NgayThiTemp = row["Ngay_thi"];
            if(NgayThiTemp.ToString()!="")
                this.NgayThi = (DateTime?)NgayThiTemp;
        }   

        public string MaLopHocPhan
        {
            get
            {
                return maLopHocPhan;
            }

            set
            {
                maLopHocPhan = value;
            }
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

        public int SoSinhVienToiDa
        {
            get
            {
                return soSinhVienToiDa;
            }

            set
            {
                soSinhVienToiDa = value;
            }
        }

        public DateTime NgayBatDau
        {
            get
            {
                return ngayBatDau;
            }

            set
            {
                ngayBatDau = value;
            }
        }

        public string GiangDuong
        {
            get
            {
                return giangDuong;
            }

            set
            {
                giangDuong = value;
            }
        }

        public DateTime? NgayThi
        {
            get
            {
                return ngayThi;
            }

            set
            {
                ngayThi = value;
            }
        }

        public string HinhThucThi
        {
            get
            {
                return hinhThucThi;
            }

            set
            {
                hinhThucThi = value;
            }
        }
    }
}
