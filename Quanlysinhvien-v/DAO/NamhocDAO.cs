using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public class NamhocDAO
    {
        private static NamhocDAO instance;

        public static NamhocDAO Instance
        {
            get
            {
                if (instance == null) instance = new NamhocDAO(); return instance;
            }

            private set
            {
                instance = value;
            }

        }

        private NamhocDAO() { }

        public List<NamHoc> GetListNamHoc()
        {
            List<NamHoc> list = new List<NamHoc>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Namhoc");

            foreach (DataRow item in data.Rows)
            {
                NamHoc namhoc = new NamHoc(item);
                list.Add(namhoc);
            }
            return list;

        }
    }
}
