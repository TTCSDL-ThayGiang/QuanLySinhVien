using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DTO;
using System.Data;

namespace QuanLySinhVien.DAO
{
    public class LopHocPhanDAO
    {
        private static LopHocPhanDAO instance;

        public static LopHocPhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new LopHocPhanDAO(); return instance;
            }

            private set
            {
                instance = value;
            }

        }

        private LopHocPhanDAO() { }

        public List<QuanLySinhVien.DTO.LopHocPhan> GetListLopHocPhan()
        {
            List<DTO.LopHocPhan> list = new List<DTO.LopHocPhan>();

            DataTable data = DataProvider.Instance.ExcuteQuery("dbo.GetLopHocPhan");

            foreach (DataRow item in data.Rows)
            {
                DTO.LopHocPhan lophocphan = new DTO.LopHocPhan(item);
                list.Add(lophocphan);
            }

            return list;
        }

        public bool Insert(string maLopHocPhancu, string maHocPhan, string maGiaoVien, int soSinhVienToiDa, DateTime ngayBatDau, string giangDuong, DateTime? ngayThi, string hinhThucThi)
        {
            string query = "InsertLopHocPhan @malophocphan , @Ma_hoc_phan , @Ma_giao_vien , @So_sv_toi_da , @Ngay_bat_dau , @Giang_duong , @Ngay_thi , @Hinh_thuc_thi";

            int result = (int)DataProvider.Instance.ExcuteNonQuery(query, new object[] { maLopHocPhancu, maHocPhan, maGiaoVien, soSinhVienToiDa, ngayBatDau, giangDuong, ngayThi, hinhThucThi });

            return result > 0;
        }

        public bool Edit(string maLopHocPhancu, string maLopHocPhanmoi, string maHocPhan, string maGiaoVien, int soSinhVienToiDa, DateTime ngayBatDau, string giangDuong, DateTime? ngayThi, string hinhThucThi)
        {
            string query = "UpdateLopHocPhan @malophocphancu , @malophocphanmoi , @Ma_hoc_phan , @Ma_giao_vien , @So_sv_toi_da , @Ngay_bat_dau , @Giang_duong , @Ngay_thi , @Hinh_thuc_thi";

            int result = (int)DataProvider.Instance.ExcuteNonQuery(query, new object[] { maLopHocPhancu, maLopHocPhanmoi, maHocPhan, maGiaoVien, soSinhVienToiDa, ngayBatDau, giangDuong, ngayThi, hinhThucThi });

            return result > 0;
        }

        public bool Delete(string id)
        {
            string query = string.Format("DELETE dbo.Lop_hoc_phan WHERE Ma_lop_hoc_phan='{0}'", id);

            int result = (int)DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public List<LopHocPhan> SeachLopHocPhanByName(string name)
        {
            List<LopHocPhan> list = new List<LopHocPhan>();

            string query = string.Format("SELECT*FROM dbo.Lop_hoc_phan WHERE Ma_lop_hoc_phan LIKE N'%{0}%'", name);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LopHocPhan lophocphan = new LopHocPhan(item);
                list.Add(lophocphan);
            }
            return list;
        }

    }
}
