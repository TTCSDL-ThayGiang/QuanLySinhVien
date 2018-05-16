using QuanLySinhVien.DAO;
using Quanlysinhvien_v.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien_v.DAO
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

        public SinhVien GetSinhVienbyid(string id)
        {
            SinhVien sv = null;

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Sinh_vien WHERE Ma_sinh_vien=N'"+id+"'");

            foreach (DataRow item in data.Rows)
            {
                sv = new SinhVien(item);
            }
            return sv;
        }

    }
}
