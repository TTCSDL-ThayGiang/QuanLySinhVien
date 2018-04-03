using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DTO;
using System.Data;

namespace QuanLySinhVien.DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        public static GiaoVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new GiaoVienDAO(); return instance;
            }

            private set
            {
                instance = value;
            }

        }

        private GiaoVienDAO() { }

        public List<DTO.GiaoVien> GetListGiaoVien()
        {
            List<DTO.GiaoVien> list = new List<DTO.GiaoVien>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT* FROM dbo.Giao_vien");

            foreach (DataRow item in data.Rows)
            {
                DTO.GiaoVien giaovien = new DTO.GiaoVien(item);
                list.Add(giaovien);
            }

            return list;
        }
    }
}
