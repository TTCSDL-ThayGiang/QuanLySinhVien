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
    public class KetQuaHocTapDAO
    {
        private static KetQuaHocTapDAO instance;

        public static KetQuaHocTapDAO Instance
        {
            get
            {
                if (instance == null) instance = new KetQuaHocTapDAO(); return instance;
            }

            private set
            {
                instance = value;
            }

        }

        private KetQuaHocTapDAO() { }

        public DataTable GetKetQuaHocTapByHocKy(string hocky)
        {
            
            return DataProvider.Instance.ExcuteQuery("GetKetQuabyHocKy @mahocky",new object[]{hocky });//
        }

        public DataTable GetKetQuaCaNam()
        {
            return DataProvider.Instance.ExcuteQuery("GetKetQuaCaNam");
        }
    }
}
