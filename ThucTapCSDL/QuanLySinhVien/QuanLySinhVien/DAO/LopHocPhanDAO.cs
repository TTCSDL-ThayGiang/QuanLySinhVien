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

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Lop_hoc_phan");

            foreach (DataRow item in data.Rows)
            {
                DTO.LopHocPhan lophocphan = new DTO.LopHocPhan(item);
                list.Add(lophocphan);
            }

            return list;
        }
    }
}
