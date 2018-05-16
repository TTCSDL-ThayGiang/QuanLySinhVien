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

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExcuteQuery("GetListAccount");
        }
        public bool UpdateAccount(string userName, string pass, string newPass)
        {

            int result = DataProvider.Instance.ExcuteNonQuery("UpdateAccount @username , @passWord , @newpassWord",new object[] { userName,pass,newPass});

            return result > 0;
        }

        public bool InsertAccount(string userName, int type)
        {
            string query = string.Format("INSERT dbo.Account (UserName, Type) VALUES(N'{0}',{1})",userName,type);

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result>0;
        }

        public bool UpdateAccount(string userName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET Type={0} WHERE UserName=N'{1}'",type,userName);

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = string.Format("Delete dbo.Account where UserName=N'{0}'", userName);

            return false;
        }

        public bool KiemTraTaiKhoanTrung(string userName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Account");

            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);

                if (acc.UserName == userName) return true;
            }
            return false;
        }

        public List<TypeNameAcc> GetListTypeName()
        {
            List<TypeNameAcc> list = new List<TypeNameAcc>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT Typename FROM dbo.AccountType");

            foreach (DataRow item in data.Rows)
            {
                TypeNameAcc type = new TypeNameAcc(item);
                list.Add(type);
            }
            return list;
        }

        public TypeNameAcc GetTypeNamebyuserName(string userName)
        {
            TypeNameAcc typename = null;

            List<TypeNameAcc> list = new List<TypeNameAcc>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT b.UserName,a.Typename FROM dbo.AccountType a, dbo.Account b WHERE a.typeid = b.Type AND b.UserName = N'" + userName+"'");

            foreach (DataRow item in data.Rows)
            {
                typename = new TypeNameAcc(item);
                return typename;
            }
            

            return typename;
        }
    }
}
