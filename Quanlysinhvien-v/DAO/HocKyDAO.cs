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
    public class HocKyDAO
    {
        private static HocKyDAO instance;

        public static HocKyDAO Instance
        {
            get
            {
                if (instance == null) instance = new HocKyDAO(); return instance;
            }

            private set
            {
                instance = value;
            }

        }

        private HocKyDAO() { }

        public List<HocKy> GetListHocKy()
        {
            List<HocKy> list = new List<HocKy>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Hoc_ky");

            foreach (DataRow item in data.Rows)
            {
                HocKy hocky = new HocKy(item);
                list.Add(hocky);
            }
            return list;
        }
    }
}
