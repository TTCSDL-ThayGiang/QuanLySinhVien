using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public class SinhVienDAO
    {
        private static SinhVienDAO instance;

        public static SinhVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new SinhVienDAO(); return instance;
            }

            private set
            {
                instance = value;
            }

        }

        private SinhVienDAO() { }

        List<DTO.SinhVien> GetListSinhVien()
        {
            List<DTO.SinhVien> list = new List<DTO.SinhVien>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Namhoc");

            foreach (DataRow item in data.Rows)
            {
                DTO.SinhVien namhoc = new DTO.SinhVien(item);
                list.Add(namhoc);
            }
            return list;

        }
    }
}
