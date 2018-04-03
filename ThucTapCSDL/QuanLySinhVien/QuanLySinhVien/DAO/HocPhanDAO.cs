using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public class HocPhanDAO
    {
        private static HocPhanDAO instance;

        public static HocPhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new HocPhanDAO(); return instance;
            }

            private set
            {
                instance = value;
            }

        }

        private HocPhanDAO() { }

        public List<HocPhan> GetListHocPhan()
        {
            List<HocPhan> list = new List<HocPhan>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Hoc_phan");

            foreach (DataRow item in data.Rows)
            {
                HocPhan hocphan = new HocPhan(item);
                list.Add(hocphan);
            }
            return list;
        }
    }
}
