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
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO(); return instance;
            }

            private set
            {
                instance = value;
            }

        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "Login @username , @passWord";

            DataTable result = DataProvider.Instance.ExcuteQuery(query,new object[] {userName,passWord });

            return result.Rows.Count>0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data=DataProvider.Instance.ExcuteQuery("select*from account where username='" + userName+"'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
