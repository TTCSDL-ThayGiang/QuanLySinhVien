using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public class KyHocDAO
    {
        private static KyHocDAO instance;

        public static KyHocDAO Instance
        {
            get
            {
                if (instance == null) instance = new KyHocDAO(); return instance;
            }

            private set
            {
                instance = value;
            }

        }

        private KyHocDAO() { }

        public List<Kyhoc> GetListKyHoc()
        {
            List<Kyhoc> list = new List<Kyhoc>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.KyHoc");

            foreach (DataRow item in data.Rows)
            {
                Kyhoc kyhoc = new Kyhoc(item);
                list.Add(kyhoc);
            }
            return list;

        }

        public List<Kyhoc> GetListKyHocByNamHocid(int id)
        {
            List<Kyhoc> list = new List<Kyhoc>();

            string query = string.Format("SELECT * FROM dbo.KyHoc WHERE Manamhoc='{0}'", id);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Kyhoc kyhoc = new Kyhoc(item);
                list.Add(kyhoc);
            }

            return list;
        }
    }
}
