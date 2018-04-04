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

        public HocPhan GetHocPhanByid(string id)
        {
            HocPhan hocphan = null;

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Hoc_phan WHERE Ma_hoc_phan=" + id);

            foreach (DataRow item in data.Rows)
            {
                hocphan = new HocPhan(item);
                break;
            }

            return hocphan;
        }

        public List<HocPhan> SeachHocPhanByName(string name)
        {
            List<HocPhan> list = new List<HocPhan>();

            string query = string.Format("SELECT * FROM dbo.Hoc_phan WHERE dbo.fuConvertToUnsign1(Ten_hoc_phan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HocPhan hocphan = new HocPhan(item);
                list.Add(hocphan);
            }
            return list;
        }
    }
}
